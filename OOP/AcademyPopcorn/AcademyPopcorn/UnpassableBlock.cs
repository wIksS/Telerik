using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class UnpassableBlock : Block
    {

        public new const string CollisionGroupString = "unpassableBlock";
        public const char Symbol = '|';

        public UnpassableBlock(MatrixCoords upperLeft)
            : base(upperLeft)
        {
            this.body[0, 0] = IndestructibleBlock.Symbol;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
        }

        public override string GetCollisionGroupString()
        {
            return UnpassableBlock.CollisionGroupString;
        }
    }
}
