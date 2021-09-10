﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TRexGame.Graphics;

namespace TRexGame.Entities
{
    public class GroundTile : IGameEntity
    { 
        private float _positionY;
        public float PositionX { get; set; }
        public Sprite Sprite { get; }
        public int DrawOrder { get; set; }
        public GroundTile(float positionX, float positionY, Sprite sprite)
        {
            _positionY = positionY;
            PositionX = positionX;
            Sprite = sprite;
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            Sprite.Draw(spriteBatch, new Vector2(PositionX, _positionY));
        }

        public void Update(GameTime gameTime)
        {
        }
    }
}
