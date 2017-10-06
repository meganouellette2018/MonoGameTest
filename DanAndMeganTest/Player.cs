using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DanAndMeganTest
{
    public class Player : DrawableGameComponent
    {

        private Texture2D solidTexture;
        private Rectangle boundingBox;
        private int xVelocity, yVelocity;
        private SpriteBatch sb;
        private Color color;


        public Player (Game game, SpriteBatch sb, int x, int y, int xv, int yv) : base(game)
        {
            this.sb = sb;
            solidTexture = new Texture2D(GraphicsDevice, 1, 1);
            solidTexture.SetData(new Color[] { Color.White });
            boundingBox = new Rectangle(x, y, 25, 25);
            xVelocity = xv;
            yVelocity = yv;
            color = Color.Purple;
        }

        public override void Update(GameTime gameTime)
        {

            KeyboardState state = Keyboard.GetState();
            bool leftArrowKeyDown = state.IsKeyDown(Keys.Left);
            bool rightArrowKeyDown = state.IsKeyDown(Keys.Right);
            bool upArrowKeyDown = state.IsKeyDown(Keys.Up);
            bool downArrowKeyDown = state.IsKeyDown(Keys.Down);
            bool downArrowKeySpace = state.IsKeyDown(Keys.Space);

            if (state.IsKeyDown(Keys.Left))
            {
                boundingBox.X -= 10;
            }

            if (state.IsKeyDown(Keys.Right))
            {
                boundingBox.X += 10;
            }

            if (state.IsKeyDown(Keys.Up))
            {
                boundingBox.Y -= 10;
            }

            if (state.IsKeyDown(Keys.Down))
            {
                boundingBox.Y += 10;
            }

            if (state.IsKeyDown(Keys.Space) && state.IsKeyDown(Keys.Left))
            {
                boundingBox.X -= 30;
            }

            if (state.IsKeyDown(Keys.Space) && state.IsKeyDown(Keys.Right))
            {
                boundingBox.X += 30;
            }

            if (state.IsKeyDown(Keys.Space) && state.IsKeyDown(Keys.Up))
            {
                boundingBox.Y -= 30;
            }

            if (state.IsKeyDown(Keys.Space) && state.IsKeyDown(Keys.Down))
            {
                boundingBox.X -= 30;
            }

            

            base.Update(gameTime);


        }

        public override void Draw(GameTime gameTime)
        {

            sb.Draw(solidTexture, boundingBox, color);
            base.Draw(gameTime);
        }
        }
    }

