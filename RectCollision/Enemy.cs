//using Microsoft.Xna.Framework;
//using Microsoft.Xna.Framework.Content;
//using Microsoft.Xna.Framework.Graphics;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace RectCollision
//{
//    class Enemy : GameObject
//    {
//        public override void Update(GameTime gameTime)
//        {
//            //Animate(gameTime);
//        }

//        public override void LoadContent(ContentManager content)
//        {
//            enemySprites = new Texture2D[2];

//            //Loads all sprites into the array
//            for (int i = 0; i < enemySprites.Length; i++)
//            {
//                enemySprites[i] = content.Load<Texture2D>(i + 1 + "trashcan");
//            }

//            //Sets a default sprite
//            //enemySprite = enemySprites[0];
//            // Set the speed of the animation
//            fps = 10;



//            //playerSprites = new Texture2D[2];

//            ////Loads all sprites into the array
//            //for (int i = 0; i < playerSprites.Length; i++)
//            //{
//            //    playerSprites[i] = content.Load<Texture2D>(i + 1 + "trashcan");
//            //}

//            ////Sets a default sprite
//            //playerSprite = playerSprites[0];
//            //// Set the speed of the animation
//            //fps = 10;
//        }
//    }
//}
