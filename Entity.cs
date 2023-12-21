using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace OO_1
{
    public class Entity
    {
        protected Texture2D texture;
        protected Vector2 position;
        protected Color color;
        protected Rectangle hitbox;

        public Rectangle Hitbox{
            get{return hitbox;}
        }
        
        public Entity(Texture2D texture){
            this.texture = texture;
        }

        public virtual void Draw(SpriteBatch spriteBatch){
            hitbox.Location = position.ToPoint();
            spriteBatch.Draw(texture, hitbox, color);
        }
    }
}