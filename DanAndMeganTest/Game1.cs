
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
        }


        protected override void Initialize()
        {
    

            base.Initialize();
        }


        protected override void LoadContent()
        {

            spriteBatch = new SpriteBatch(GraphicsDevice);
            Components.Add(new Enemies(this, spriteBatch, 100, 200, 75, 75));
            Components.Add(new Player(this, spriteBatch, 250, 250, 100, 100));
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
                    xv = 10;
                }
                else
                {
                    xv = -10;
                }
                int yv = r.Next(0, 2);
                if (yv == 0)
                {
                    yv = 10;
                }

                else
                {
                    yv = -10;
                }

                int x = r.Next(0, 1150);
                int y = r.Next(0, 650);

                Components.Add(new Player(this, spriteBatch, x, y, xv, yv));
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

