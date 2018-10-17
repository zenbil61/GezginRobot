using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GezginRobot.Model.Robots;
namespace GezginRobot.Model
{
    public class Planet
    {
        public int X { get; set; }
        public int Y { get; set; }
        public List<Robot> Robots { get; set; }
    }
}
