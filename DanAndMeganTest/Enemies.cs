﻿using Microsoft.Xna.Framework;
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
            boundingBox = new Rectangle(50, 100, 25,25);
            xVelocity = xv;
            yVelocity = yv;
            color = Color.Red;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);


        }

        public override void Draw(GameTime gameTime)
        {

            sb.Draw(solidTexture, boundingBox, color);

            base.Draw(gameTime);
        }


    }
}
