using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048Tile
{
    
    class GameArray
    {
        private Random rng = new Random((int)DateTime.Now.Ticks);
        private KeyboardState newState = Keyboard.GetState();
        private KeyboardState oldState;
        public int[,] Array;

        public GameArray()
        {
            Array = new int[4, 4];
        }

        public void Initialize()
        {
            for (int n = 0; n < Array.Length; n++)
            {
                Array[(int)n / 4, n - (n / 4 * 4)] = 0;
            }
        }

        public void LoadContent()
        {
            generationTile();
            generationTile();
        }

        public void UnloadContent()
        {
        }

        public void Update(GameTime gameTime)
        {
            if (oldState.IsKeyUp(Keys.Up) && newState.IsKeyDown(Keys.Up))
            {

            }
        }

        public void Draw(GameTime gameTime)
        {
        }

        private void generationTile()
        {
            int x, y;
            bool tileValid = false;

            while (!tileValid)
            {
                x = rng.Next(4);
                y = rng.Next(4);

                if (Array[y, x] == 0)
                {
                    Array[y, x] = (rng.Next(1)*2) + 2;
                    tileValid = !tileValid;
                }
            }
        }



        enum Direction { up, down, right, left };
    }
}
