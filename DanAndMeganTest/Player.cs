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


        public Player (Game game, SpriteBatch sb, int x, int y, int xv, int yv) : base(game)
        {
            this.sb = sb;
            solidTexture = new Texture2D(GraphicsDevice, 1, 1);
            solidTexture.SetData(new Color[] { Color.White });
            boundingBox = new Rectangle(x, y, 75, 75);
            xVelocity = xv;
            yVelocity = yv;
        }

        public override void Update(GameTime gameTime)
        {





            base.Update(gameTime);


        }

        public override void Draw(GameTime gameTime)
        {
            sb.Draw(solidTexture, boundingBox, Color.Blue);
            base.Draw(gameTime);
        }
    }
}
