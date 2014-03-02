using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class Gift : MovingObject
    {
        public new const string CollisionGroupString = "gift";

        public Gift(MatrixCoords topLeft, char[,] body)
            : base(topLeft, body, new MatrixCoords(1,0))
        {
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "racket";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> producedObjects = new List<GameObject>();
            if (IsDestroyed == true)
            {
                producedObjects.Add(new ShootingRacket(new MatrixCoords(topLeft.Row+1,topLeft.Col),6));
            }
            return producedObjects;
        }
    }
}
