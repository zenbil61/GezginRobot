using GezginRobot.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GezginRobot.Extension
{
   public static class PlanetExtension
    {
        public static void SetSurface(this Planet _planet,string _move)
        {

            var x = _move.Split(' ')[0];
            var y = _move.Split(' ')[1];

            _planet.X = Convert.ToInt32(x);
            _planet.Y = Convert.ToInt32(y);

        }
        public static void CheckRobotsCoordinat(this Planet _mars)
        {
            foreach (var robot in _mars.Robots)
            {
                if (robot.Location.X > _mars.X)
                    robot.Location.X = _mars.X;

                if (robot.Location.X < 0)
                    robot.Location.X = 0;


                if (robot.Location.Y > _mars.Y)
                    robot.Location.Y = _mars.Y;

                if (robot.Location.Y < 0)
                    robot.Location.Y = 0;
            }
        }
    }
}
