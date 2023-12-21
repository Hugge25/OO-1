using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace OO_1
{
    public class Wernow : Enemy
    {
        public Wernow(Texture2D texture, Player target):base(texture, target){
            position = new Vector2(500, 500);
            color = Color.HotPink;
            hitbox = new Rectangle(0,0,25,50);
        }

        public override void Update(){
            Vector2 direction = target.Position - position;
            direction.Normalize();

            position += direction;

        }

    }
}