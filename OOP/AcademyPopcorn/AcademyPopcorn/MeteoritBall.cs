using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class MeteoritBall : Ball
    {
        private MatrixCoords topLeft;

        public MeteoritBall(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, speed)
        {
            this.topLeft = topLeft;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> produceObjects = new List<GameObject>();
            produceObjects.Add(new TrailObject(base.topLeft, 3));
            return produceObjects;
        }
    }
}
