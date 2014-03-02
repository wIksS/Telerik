using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class ExplodingBlock : Block
    {
        public ExplodingBlock(MatrixCoords topLeft)
            : base(topLeft)
        {
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> explosions = new List<GameObject>();
            if (IsDestroyed == true)
            {
                explosions.Add(new Explosion(new MatrixCoords(this.TopLeft.Row, this.TopLeft.Col), new MatrixCoords(-1, 0)));
                explosions.Add(new Explosion(new MatrixCoords(this.TopLeft.Row, this.TopLeft.Col), new MatrixCoords(1, 0)));
                explosions.Add(new Explosion(new MatrixCoords(this.TopLeft.Row, this.TopLeft.Col), new MatrixCoords(0, 1)));
                explosions.Add(new Explosion(new MatrixCoords(this.TopLeft.Row, this.TopLeft.Col), new MatrixCoords(1, -1)));
            }

            return explosions;
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "ball" || otherCollisionGroupString == "unstopableBall";
        }
    }
}
