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
    class Player : GameObject
    {

        // Lav en "if debug" hvor den bruger billeder med sider på for at se collision box



        public Player()
        {
        }
        public override void LoadContent(ContentManager content)
        {
            //player = content.Load<Texture2D>("1Player");
            //enemy = content.Load<Texture2D>("1trashcan");

            playerSprites = new Texture2D[3];

            //Loads all sprites into the array
            for (int i = 0; i < playerSprites.Length; i++)
            {
                playerSprites[i] = content.Load<Texture2D>(i + 1 + "Player");
            }

            //Sets a default sprite
            //playerSprite = playerSprites[0];
            // Set the speed of the animation
            fps = 10;
        }


        public override void Update(GameTime gameTime)
        {
            Movement(gameTime);
            //Animate(gameTime);
        }
        private void Movement(GameTime gameTime)
        {
            //if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            //      Exit();

            keyState = Keyboard.GetState();

            if (keyState.IsKeyDown(Keys.D))
            {
                position.X += moveSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }
            else if (keyState.IsKeyDown(Keys.A))
                position.X -= moveSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            else if (keyState.IsKeyDown(Keys.W))
                position.Y -= moveSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            else if (keyState.IsKeyDown(Keys.S))
                position.Y += moveSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
        }
    }
}
