using System;
using System.Collections.Generic;
using System.Text;
using MathLibrary;
using Raylib_cs;

namespace Pong
{
    class Ping : Actor
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

        public Ping(char icon, float x, float y, float speed, Color color, string name = "Paddle")
            : base(icon, x, y, speed, color, name)
        {
            _speed = speed;
        }



        public override void Update(float deltaTime)
        {
            int yDiretion = 0;
            int xDirection = 1;
            

            //Create a vector tht stores the move input
            //Vector2 moveDirection = new Vector2(xDiretion, yDiretion);
            Vector2 moveDirection = new Vector2(xDirection, yDiretion);

            //caculates the veclocity 
            Velocity = moveDirection.Normalized * Speed * deltaTime;

            base.Update(deltaTime);
            //moves the player
            Position += Velocity;

            if (Position.X > 800)
                Position = new Vector2 { X = 400, Y = 225 };
        }

        public override void OnCollision(Actor actor)
        {
            Console.WriteLine("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
        }
    }
}
