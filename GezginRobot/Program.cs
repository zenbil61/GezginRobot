using GezginRobot.Extension;
using GezginRobot.Model;
using GezginRobot.Model.Robots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GezginRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            var mars = new Mars();

            mars.Robots = new List<Robot>() {
                new Robot("Robot A"),
                new Robot("Robot B")
            };


            Console.WriteLine("Gezegen uzunluğunu Belirt");
            mars.SetSurface(Console.ReadLine()); // mars gezegeninin uzunluğu belirlenir

            foreach (var robot in mars.Robots)
            {
                Console.WriteLine($"{robot.Name} Konumunu Gir");
                robot.Location = Console.ReadLine().ToLocation(); // robotun konumu belirlenir

                Console.WriteLine($"{robot.Name} Hareketlerini Gir");
                robot.Movement(Console.ReadLine()); // robot hareketleri girilir
            }

            mars.CheckRobotsCoordinat(); // gezegen için belirlenen koordinatların dışına çıkılmışsa max koordinat setlenir

            foreach (var robot in mars.Robots)           
               Console.WriteLine($"{robot.Name} : {robot.Location.X} - {robot.Location.Y} -  {robot.Location.Direction}" );
  
             Console.ReadLine();


        }
    }
}
