﻿using CustomNPCFramework.Framework.ModularNPCS.ColorCollections;
using CustomNPCFramework.Framework.NPCS;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomNPCFramework.Framework.ModularNPCS.CharacterAnimationBases
{
    public class StandardCharacterAnimation :CharacterAnimationBase
    {
        public AnimatedSpriteCollection hair;
        public AnimatedSpriteCollection body;
        public AnimatedSpriteCollection eyes;
        public AnimatedSpriteCollection shirt;
        public AnimatedSpriteCollection pants;
        public AnimatedSpriteCollection shoes;
        public StandardColorCollection drawColors;
        public List<AnimatedSpriteCollection> accessories;

        public StandardCharacterAnimation(AnimatedSpriteCollection bodyAnimation, AnimatedSpriteCollection eyeAnimation, AnimatedSpriteCollection hairAnimation, AnimatedSpriteCollection shirtAnimation, AnimatedSpriteCollection pantsAnimation, AnimatedSpriteCollection shoesAnimation,List<AnimatedSpriteCollection> accessoriesWithAnimations, StandardColorCollection DrawColors) :base()
        {
            this.body = bodyAnimation;
            this.hair = hairAnimation;
            this.eyes = eyeAnimation;
            this.shirt = shirtAnimation;
            this.pants = pantsAnimation;
            this.shoes = shoesAnimation;
            this.accessories = accessoriesWithAnimations;
            this.drawColors = DrawColors;
        }

        public override void setLeft()
        {
            this.body.setLeft();
            this.hair.setLeft();
            this.eyes.setLeft();
            this.shirt.setLeft();
            this.pants.setLeft();
            this.shoes.setLeft();

            foreach(var accessory in this.accessories)
            {
                accessory.setLeft();
            }
        }
        public override void setRight()
        {
            this.body.setRight();
            this.hair.setRight();
            this.eyes.setRight();
            this.shirt.setRight();
            this.pants.setRight();
            this.shoes.setRight();

            foreach (var accessory in this.accessories)
            {
                accessory.setRight();
            }
        }
        public override void setUp()
        {
            this.body.setUp();
            this.hair.setUp();
            this.eyes.setUp();
            this.shirt.setUp();
            this.pants.setUp();
            this.shoes.setUp();

            foreach (var accessory in this.accessories)
            {
                accessory.setUp();
            }
        }
        public override void setDown()
        {
            this.body.setDown();
            this.hair.setDown();
            this.eyes.setDown();
            this.shirt.setDown();
            this.pants.setDown();
            this.shoes.setDown();

            foreach (var accessory in this.accessories)
            {
                accessory.setDown();
            }
        }

        public override void reload()
        {
            this.body.reload();
            this.hair.reload();
            this.eyes.reload();
            this.shirt.reload();
            this.pants.reload();
            this.shoes.reload();
        }

        public override void Animate(float animationInterval,bool loop=true)
        {
            this.body.Animate(animationInterval,loop);
            this.hair.Animate(animationInterval,loop);
            this.eyes.Animate(animationInterval,loop);
            this.shirt.Animate(animationInterval,loop);
            this.pants.Animate(animationInterval,loop);
            this.shoes.Animate(animationInterval,loop);
            foreach(var accessory in this.accessories)
            {
                accessory.Animate(animationInterval,loop);
            }
            
        }

        /// <summary>
        /// Used to draw the sprite to the screen.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="screenPosition"></param>
        /// <param name="layerDepth"></param>
        public override void draw(SpriteBatch b, Vector2 screenPosition, float layerDepth)
        {
            this.body.draw(b,screenPosition,layerDepth);
            this.hair.draw(b, screenPosition, layerDepth);
            this.eyes.draw(b, screenPosition, layerDepth);
            this.shirt.draw(b, screenPosition, layerDepth);
            this.pants.draw(b, screenPosition, layerDepth);
            this.shoes.draw(b, screenPosition, layerDepth);
            foreach (var accessory in this.accessories)
            {
                accessory.draw(b, screenPosition, layerDepth);
            }
            //b.Draw(this.currentSprite.Texture, screenPosition, new Rectangle?(this.currentSprite.sourceRect), Color.White, 0.0f, Vector2.Zero, (float)Game1.pixelZoom, this.currentSprite.currentAnimation == null || !this.currentSprite.currentAnimation[this.currentSprite.currentAnimationIndex].flip ? SpriteEffects.None : SpriteEffects.FlipHorizontally, layerDepth);
        }



        /// <summary>
        /// Used to draw the sprite to the screen.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="screenPosition"></param>
        /// <param name="layerDepth"></param>
        /// <param name="xOffset"></param>
        /// <param name="yOffset"></param>
        /// <param name="c"></param>
        /// <param name="flip"></param>
        /// <param name="scale"></param>
        /// <param name="rotation"></param>
        /// <param name="characterSourceRectOffset"></param>
        public override void draw(SpriteBatch b, Vector2 screenPosition, float layerDepth, int xOffset, int yOffset, Color c, bool flip = false, float scale = 1f, float rotation = 0.0f, bool characterSourceRectOffset = false)
        {
            // b.Draw(this.currentSprite.Texture, screenPosition, new Rectangle?(new Rectangle(this.currentSprite.sourceRect.X + xOffset, this.currentSprite.sourceRect.Y + yOffset, this.currentSprite.sourceRect.Width, this.currentSprite.sourceRect.Height)), c, rotation, characterSourceRectOffset ? new Vector2((float)(this.currentSprite.spriteWidth / 2), (float)((double)this.currentSprite.spriteHeight * 3.0 / 4.0)) : Vector2.Zero, scale, flip || this.currentSprite.currentAnimation != null && this.currentSprite.currentAnimation[this.currentSprite.currentAnimationIndex].flip ? SpriteEffects.FlipHorizontally : SpriteEffects.None, layerDepth);
            this.body.draw(b, screenPosition, layerDepth, xOffset, yOffset, StandardColorCollection.colorMult(c,this.drawColors.bodyColor), flip, scale, rotation, characterSourceRectOffset);
            this.hair.draw(b, screenPosition, layerDepth, xOffset, yOffset, StandardColorCollection.colorMult(c, this.drawColors.hairColor), flip, scale, rotation, characterSourceRectOffset);
            this.eyes.draw(b, screenPosition, layerDepth, xOffset, yOffset, StandardColorCollection.colorMult(c, this.drawColors.eyeColor), flip, scale, rotation, characterSourceRectOffset);
            this.shirt.draw(b, screenPosition, layerDepth, xOffset, yOffset, StandardColorCollection.colorMult(c, this.drawColors.shirtColor), flip, scale, rotation, characterSourceRectOffset);
            this.pants.draw(b, screenPosition, layerDepth, xOffset, yOffset, StandardColorCollection.colorMult(c, this.drawColors.bottomsColor), flip, scale, rotation, characterSourceRectOffset);
            this.shoes.draw(b, screenPosition, layerDepth, xOffset, yOffset, StandardColorCollection.colorMult(c, this.drawColors.shoesColor), flip, scale, rotation, characterSourceRectOffset);
            foreach(var accessory in this.accessories)
            {
                accessory.draw(b, screenPosition, layerDepth, xOffset, yOffset, c, flip, scale, rotation, characterSourceRectOffset);
            }
        }

        /// <summary>
        /// A very verbose asset drawer.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="npc"></param>
        /// <param name="position"></param>
        /// <param name="sourceRectangle"></param>
        /// <param name="color"></param>
        /// <param name="alpha"></param>
        /// <param name="origin"></param>
        /// <param name="scale"></param>
        /// <param name="effects"></param>
        /// <param name="layerDepth"></param>
        public override void draw(SpriteBatch b, ExtendedNPC npc, Vector2 position, Rectangle sourceRectangle, Color color, float alpha, Vector2 origin, float scale, SpriteEffects effects, float layerDepth)
        {
            //Class1.ModMonitor.Log(sourceRectangle.ToString());
            Vector2 generalOffset = new Vector2(0, 1*Game1.tileSize); //Puts the sprite at the correct positioning.
            position -= new Vector2(0, 0.25f * Game1.tileSize);
            float smallOffset = 0.001f;
            float tinyOffset = 0.0001f;
            //Class1.ModMonitor.Log((position - generalOffset).ToString());
            float num = Math.Max(0.0f, (float)(Math.Ceiling(Math.Sin(Game1.currentGameTime.TotalGameTime.TotalMilliseconds / 600.0 + (double)npc.DefaultPosition.X * 20.0)) / 4.0));
            this.body.draw(b, npc, position-generalOffset, sourceRectangle, StandardColorCollection.colorMult(color, this.drawColors.bodyColor), alpha, origin, scale*Game1.pixelZoom, effects, layerDepth + smallOffset);
            this.eyes.draw(b, npc, position - generalOffset, sourceRectangle, StandardColorCollection.colorMult(color, this.drawColors.eyeColor), alpha, origin, scale*Game1.pixelZoom, effects, layerDepth + smallOffset+(tinyOffset *1));
            this.hair.draw(b, npc, position-generalOffset, sourceRectangle, StandardColorCollection.colorMult(color, this.drawColors.hairColor), alpha, origin, scale*Game1.pixelZoom, effects, layerDepth + smallOffset+(tinyOffset *2));

            if (num > 0.0f)
            {
                Vector2 shirtOffset = new Vector2((1 * Game1.tileSize) / 4, (1 * Game1.tileSize) / 4);
                this.shirt.draw(b, npc, position - generalOffset, sourceRectangle, StandardColorCollection.colorMult(color, this.drawColors.shirtColor), alpha, new Vector2(0.5f,1), scale * Game1.pixelZoom + num, effects, layerDepth + smallOffset + (tinyOffset * 3));
            }
            else
            {
                this.shirt.draw(b, npc, position - generalOffset, sourceRectangle, StandardColorCollection.colorMult(color, this.drawColors.shirtColor), alpha, origin, scale * Game1.pixelZoom, effects, layerDepth + smallOffset + (tinyOffset * 3));
            }
            this.pants.draw(b, npc, position-generalOffset, sourceRectangle, StandardColorCollection.colorMult(color, this.drawColors.bottomsColor), alpha, origin, scale*Game1.pixelZoom, effects, layerDepth + smallOffset+(tinyOffset*4));
            this.shoes.draw(b, npc, position-generalOffset, sourceRectangle, StandardColorCollection.colorMult(color, this.drawColors.shoesColor), alpha, origin, scale*Game1.pixelZoom, effects, layerDepth + smallOffset+(tinyOffset*5));
            foreach(var accessory in this.accessories)
            {
                accessory.draw(b, npc, position-generalOffset, sourceRectangle, color, alpha, origin, scale, effects, layerDepth +0.0006f);
            }
        }

    }
}