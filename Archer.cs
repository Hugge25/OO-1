using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace OO_1
{
    public class Archer : Enemy
    {
        public Archer(Texture2D texture, Player target):base(texture, target){
            position = new Vector2(500, 500);
            color = Color.DarkGreen;
            hitbox = new Rectangle(0,0,25,50);
        }

        public override void Update(){
            Vector2 direction = target.Position - position;
            direction.Normalize();
            if(Vector2.Distance(target.Position,position) > 150){
                position += direction;
            }
            else if(Vector2.Distance(target.Position,position) < 150){
                position -= direction;
            }   
        }
    }
}