using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace OO_1
{
    public class Bullet : Entity
    {
        private Vector2 direction;
        private float speed = 8;

        public Bullet(Texture2D texture, Vector2 startPosistion):base(texture){
            position = startPosistion;
            hitbox.Width = 10;
            hitbox.Height = 10;
            color = Color.White;

            MouseState mouse = Mouse.GetState();
            direction = mouse.Position.ToVector2() - startPosistion;
            direction.Normalize();

        }

        public void Update(){
            position += direction * speed;
        }

    }
}