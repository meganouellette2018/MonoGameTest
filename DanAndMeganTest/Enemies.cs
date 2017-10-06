using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DanAndMeganTest
{
    public class Enemies : DrawableGameComponent
    {

        private Texture2D solidTexture;
        private Rectangle boundingBox;
        private int xVelocity, yVelocity;
        private SpriteBatch sb;
        private Color color;

        public Enemies(Game game, SpriteBatch sb, int x, int y, int xv, int yv) : base(game)
        {
            this.sb = sb;
            solidTexture = new Texture2D(GraphicsDevice, 1, 1);
            solidTexture.SetData(new Color[] { Color.White });
            boundingBox = new Rectangle(x, y, 75,75);
            xVelocity = xv;
            yVelocity = yv;
            color = Color.Red;
        }

        public override void Update(GameTime gameTime)
        {

            if (boundingBox.X <= 0 || boundingBox.X >= 1125)
                xVelocity *= -1;

            boundingBox.X += xVelocity;

            if (boundingBox.Y <= 0 || boundingBox.Y >= 525)
                yVelocity *= -1;

            boundingBox.Y += yVelocity;


            base.Update(gameTime);


        }

        public override void Draw(GameTime gameTime)
        {

            sb.Draw(solidTexture, boundingBox, color);

            base.Draw(gameTime);
        }


    }
}
