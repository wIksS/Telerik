using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class GiftBox : Block
    {
        public GiftBox(MatrixCoords topLeft)
            : base(topLeft)
        {
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> giftBox = new List<GameObject>();
            if (IsDestroyed == true)
            {
                giftBox.Add(new Gift (topLeft, new char[,] {{'$'}}));
            }

            return giftBox;
        }
    }
}
