using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class ShootingRacket : Racket
    {
        private bool isShooting = true;
        private bool isTrue = true;

        public ShootingRacket(MatrixCoords topLeft, int width)
            : base(topLeft, width)
        {
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            isShooting = true;
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            if (otherCollisionGroupString == "gift")
            {
                isShooting = true;
            }
            return otherCollisionGroupString == "gift";
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> producedObjects = new List<GameObject>();
            producedObjects.Add(new Bullet(new MatrixCoords (topLeft.Row,topLeft.Col + 7)));
            return producedObjects;
        }

        public override void Update()
        {
            ProduceObjects();
        }
    }
}
