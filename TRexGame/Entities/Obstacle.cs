using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.Text;

namespace TRexGame.Entities
{
    public abstract class Obstacle : IGameEntity
    {
        private Trex _trex;

        public abstract Rectangle CollisionBox { get; }

        public int DrawOrder { get; set; }

        public Vector2 Position { get; private set; }

        protected Obstacle(Trex trex, Vector2 position)
        {
            _trex = trex;
            Position = position;
        }

        public abstract void Draw(SpriteBatch spriteBatch, GameTime gameTime);

        public void Update(GameTime gameTime)
        {
            float posX = Position.X - _trex.Speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            
            Position = new Vector2(posX, Position.Y);
        }
    }
}
