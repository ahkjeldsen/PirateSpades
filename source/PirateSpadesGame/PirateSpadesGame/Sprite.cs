﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PirateSpades;
using PirateSpades.GameLogic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace PirateSpadesGame {

    public class Sprite {
        public Vector2 Position = new Vector2(0,0);
        private Texture2D mSpriteTexture;
        public Rectangle Size;
        public float Scale = 1.0f;
        private Player player;

        public Sprite() {
            Color = Color.White;
        }

        public Player Player { get { return player; } }

        public Color Color { get; set; }

        public Texture2D Tex { get { return mSpriteTexture; } }

        public void LoadContent(ContentManager theContentManager, string theAssetName) {
            mSpriteTexture = theContentManager.Load<Texture2D>(theAssetName);
            Size = new Rectangle(0, 0, (int)(mSpriteTexture.Width * Scale), (int)(mSpriteTexture.Height * Scale));
        }

        public void Draw(SpriteBatch theSpriteBatch) {
            theSpriteBatch.Draw(mSpriteTexture, Position,
                new Rectangle(0, 0, mSpriteTexture.Width, mSpriteTexture.Height),
                Color, 0.0f, Vector2.Zero, Scale, SpriteEffects.None, 0);
        }
    }
}