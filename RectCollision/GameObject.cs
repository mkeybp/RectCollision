using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectCollision
{
    abstract class GameObject
    {
        public Vector2 position;
        public KeyboardState keyState;

        public Color playerColor = Color.White;
        protected Texture2D playerSprite;
        protected Texture2D[] playerSprites;
        public float moveSpeed = 500f;

        public Color enemyColor = Color.White;
        protected Texture2D enemySprite;
        protected Texture2D[] enemySprites;


        private Vector2 origin;
        protected int fps;

        private float timeElapsed;

        private int eCurrentIndex;
        private int pCurrentIndex;

        public abstract void LoadContent(ContentManager content);

        public abstract void Update(GameTime gameTime);

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(playerSprite, position, null, Color.White, 0, origin, 1, SpriteEffects.None, 0);
            //spriteBatch.Draw(enemySprite, position, null, Color.White, 0, origin, 1, SpriteEffects.None, 0);

        }

        //protected void Animate(GameTime gameTime)
        //{
        //    //Adds time that has passed since last update
        //    timeElapsed += (float)gameTime.ElapsedGameTime.TotalSeconds;

        //    //Calculates the curent index
        //    pCurrentIndex = (int)(timeElapsed * fps);

        //    playerSprite = playerSprites[pCurrentIndex];

        //    //Checks if we need to restart the animation
        //    if (pCurrentIndex >= playerSprites.Length - 1)
        //    {
        //        //Resets the animation
        //        timeElapsed = 0;
        //        pCurrentIndex = 0;
        //    }




        //    eCurrentIndex = (int)(timeElapsed * fps);


        //    enemySprite = enemySprites[eCurrentIndex];

        //    //Checks if we need to restart the animation
        //    if (eCurrentIndex >= enemySprites.Length - 1)
        //    {
        //        //Resets the animation
        //        timeElapsed = 0;
        //        eCurrentIndex = 0;
        //    }
        //}
        protected void Collision(GameTime gameTime)

        {
            if (position.X + playerSprites[3].Width < 100 || position.X > 100 + enemySprites[2].Width || position.Y + playerSprites[3].Height < 100 || position.Y > 100 + enemySprites[2].Height)
            {
                // No collision
                playerColor = Color.White;
            }
            else
            {
                // Collision
                playerColor = Color.Red;
            }
        }
    }
}
