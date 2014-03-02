using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class UnstoppableBall : Ball
    {
        public new const string CollisionGroupString = "unstopableBall";

        public UnstoppableBall(MatrixCoords topLeft, MatrixCoords speed) 
            : base (topLeft,speed)
        {
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "unpassableBlock" || otherCollisionGroupString == "racket";             
        }

        public override string GetCollisionGroupString()
        {
            return UnstoppableBall.CollisionGroupString;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            foreach (var item in collisionData.hitObjectsCollisionGroupStrings)
            {
                if (item == "unpassableBlock" || item == "racket")
                {
                    if (collisionData.CollisionForceDirection.Row * this.Speed.Row < 0)
                    {
                        this.Speed.Row *= -1;
                    }
                    if (collisionData.CollisionForceDirection.Col * this.Speed.Col < 0)
                    {
                        this.Speed.Col *= -1;
                    }
                }
            }
        }
    }
}
