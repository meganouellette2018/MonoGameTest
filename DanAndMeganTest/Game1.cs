
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DanAndMeganTest
{

    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Random r;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferWidth = 1200;
            graphics.PreferredBackBufferHeight = 600;
            graphics.ApplyChanges();
        }


        protected override void Initialize()
        {

            this.IsMouseVisible = true;

            base.Initialize();
        }


        protected override void LoadContent()
        {

            spriteBatch = new SpriteBatch(GraphicsDevice);
            

            Components.Add(new Player(this, spriteBatch, 250, 250, 100, 100, Keys.Left, Keys.Right, Keys.Up, Keys.Down));
            Components.Add(new Player(this, spriteBatch, 250, 40, 100, 100, Keys.A, Keys.D, Keys.W, Keys.S));
            r = new Random();

            


        }

        protected override void UnloadContent()
        {

        }


        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

         


            base.Update(gameTime);

            if (gameTime.TotalGameTime.Seconds % 5 == 0 && gameTime.TotalGameTime.Milliseconds == 0)
            {
                int xv = r.Next(0, 2);
                if (xv == 0)
                {
                    xv = 8;
                }
                else
                {
                    xv = -8;
                }
                int yv = r.Next(0, 2);
                if (yv == 0)
                {
                    yv = 8;
                }

                else
                {
                    yv = -8;
                }

                int x = r.Next(0, 1150);
                int y = r.Next(0, 650);

                Components.Add(new Enemies(this, spriteBatch, x, y, xv, yv));
            }

        }


        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            base.Draw(gameTime);
            spriteBatch.End();
        }
    }
}

