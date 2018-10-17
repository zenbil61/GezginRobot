using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GezginRobot.Model.Robots
{
    public class Robot:BaseRobot
    {
        public Robot()
        {

        }
        public Robot(string _name)
        {
            this.Name = _name;
        }
        public string Name { get; set; }
    }
}
