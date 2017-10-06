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
        private Keys leftControl;
        private Keys rightControl;
        private Keys upControl;
        private Keys downControl; 


        public Player (Game game, SpriteBatch sb, int x, int y, int xv, int yv, Keys lc, Keys rc, Keys uc, Keys dc) : base(game)
        {
            this.sb = sb;
            solidTexture = new Texture2D(GraphicsDevice, 1, 1);
            solidTexture.SetData(new Color[] { Color.White });
            boundingBox = new Rectangle(x, y, 25, 25);
            xVelocity = xv;
            yVelocity = yv;
            leftControl = lc;
            rightControl = rc;
            upControl = uc;
            downControl = dc;
        color = Color.Purple;
        }

        public override void Update(GameTime gameTime)
        {

            KeyboardState state = Keyboard.GetState();
            bool leftArrowKeyDown = state.IsKeyDown(leftControl);
            bool rightArrowKeyDown = state.IsKeyDown(rightControl);
            bool upArrowKeyDown = state.IsKeyDown(upControl);
            bool downArrowKeyDown = state.IsKeyDown(downControl);


            if (state.IsKeyDown(leftControl))
            {
                boundingBox.X -= 10;
            }

            if (state.IsKeyDown(rightControl))
            {
                boundingBox.X += 10;
            }

            if (state.IsKeyDown(upControl))
            {
                boundingBox.Y -= 10;
            }

            if (state.IsKeyDown(downControl))
            {
                boundingBox.Y += 10;
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

