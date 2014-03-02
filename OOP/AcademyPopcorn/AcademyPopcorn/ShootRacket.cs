using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class ShootRacket : Engine
    {
        public ShootRacket(IRenderer renderer, IUserInterface userInterface, int sleepThreading)
            : base(renderer, userInterface,sleepThreading)
        {
        }

        void ShootPlayerRacket()
        {
        }
    }
}
