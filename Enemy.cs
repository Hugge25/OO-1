using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace OO_1
{
    public abstract class Enemy : Entity
    {

        protected Player target;


        public Enemy(Texture2D texture, Player target) : base(texture){
            position = new Vector2(500, 500);
            this.target = target;
        }

        public abstract void Update();
    }        
}