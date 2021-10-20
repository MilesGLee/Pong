using System;
using System.Collections.Generic;
using System.Text;
using MathLibrary;
using Raylib_cs;

namespace Pong
{
    class Paddle : Actor
    {
        private float _speed;
        private Vector2 _velocity;

        public float Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public Vector2 Velocity
        {
            get { return _velocity; }
            set { _velocity = value; }
        }

        public Paddle(char icon, float x, float y, float speed, Color color, string name = "Paddle")
            : base(icon, x, y, speed, color, name)
        {
            _speed = speed;

        }



        public override void Update(float deltaTime)
        {
            //get the player input direction
            //int xDiretion = -Convert.ToInt32(Raylib.IsKeyDown(KeyboardKey.KEY_A))
            //    + Convert.ToInt32(Raylib.IsKeyDown(KeyboardKey.KEY_D));
            int yDiretion = -Convert.ToInt32(Raylib.IsKeyDown(KeyboardKey.KEY_W))
                + Convert.ToInt32(Raylib.IsKeyDown(KeyboardKey.KEY_S));

            //Create a vector tht stores the move input
            //Vector2 moveDirection = new Vector2(xDiretion, yDiretion);
            Vector2 moveDirection = new Vector2(0, yDiretion);

            //caculates the veclocity 
            Velocity = moveDirection.Normalized * Speed * deltaTime;

            base.Update(deltaTime);
            //moves the player
            Postion += Velocity;

        }

        public override void OnCollision(Actor actor)
        {

        }
    }
}
