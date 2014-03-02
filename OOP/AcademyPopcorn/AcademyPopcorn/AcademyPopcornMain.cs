using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow, i));
                if (i % 3 == 0)
                {
                   // currBlock = new ExplodingBlock(new MatrixCoords( startRow, i));
                    currBlock = new GiftBox(new MatrixCoords(startRow, i));
                }
                else if (i % 4 == 0)
                {
                    currBlock = new ExplodingBlock(new MatrixCoords(startRow, i));
                    //currBlock = new GiftBox(new MatrixCoords(startRow, i));
                }
                engine.AddObject(currBlock);
            }

            Ball theBall = new MeteoritBall(new MatrixCoords(WorldRows / 2, 2),
                new MatrixCoords(1, 1));
            engine.AddObject(theBall);

            Ball unpassableBall = new UnstoppableBall(new MatrixCoords(WorldRows/2, 0),
                new MatrixCoords(1, 2));
            engine.AddObject(unpassableBall);

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2 - 9), RacketLength);

            engine.AddObject(theRacket);
            for (int i = 0; i < WorldRows; i++)
            {
                IndestructibleBlock leftBlock = new IndestructibleBlock(new MatrixCoords(i, 0));
                engine.AddObject(leftBlock);
                IndestructibleBlock rightBlock = new IndestructibleBlock(new MatrixCoords(i, WorldCols-1));
                engine.AddObject(rightBlock);
            }

            for (int i = 0; i < WorldCols; i++)
            {
                IndestructibleBlock ceilingBlock = new IndestructibleBlock(new MatrixCoords(0,i));
                engine.AddObject(ceilingBlock);
            }

            TrailObject trailObject = new TrailObject(new MatrixCoords(WorldRows / 2, WorldCols /2), 50);
            engine.AddObject(trailObject);

            for (int i = 0; i < WorldRows; i++)
            {
                UnpassableBlock leftBlock = new UnpassableBlock(new MatrixCoords(i, 2 ));
                engine.AddObject(leftBlock);
                UnpassableBlock rightBlock = new UnpassableBlock(new MatrixCoords(i, WorldCols - 2));
                engine.AddObject(rightBlock);
            }

            for (int i = 0; i < WorldCols; i++)
            {
                UnpassableBlock ceilingBlock = new UnpassableBlock(new MatrixCoords(1, i));
                engine.AddObject(ceilingBlock);
            }
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;

            Engine gameEngine = new Engine(renderer, keyboard,50);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            Initialize(gameEngine);

            //

            gameEngine.Run();
        }
    }
}
