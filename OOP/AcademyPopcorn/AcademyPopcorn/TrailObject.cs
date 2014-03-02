using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class TrailObject : GameObject
    {
        public new const string CollisionGroupString = "trailObject";
        private int turns;
        private int lifeTime;

        public TrailObject(MatrixCoords topLeft, int lifeTime)
            : base(topLeft, new char[,] { { '@' } })
        {
            this.lifeTime = lifeTime;
        }

        public override void Update()
        {
            turns++;
            if (turns >= lifeTime)
            {
                this.IsDestroyed = true;
            }
        }
    }
}
