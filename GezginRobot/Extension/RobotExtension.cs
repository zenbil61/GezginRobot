using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GezginRobot.Model.Robots;
using GezginRobot.Constant;

namespace GezginRobot.Extension
{
    public static class MovementExtension
    {

        public static void Movement(this Robot _robot, string _move)
        {
            var moveList = _move.ToUpper().Trim().Select(c => c.ToString());
          
            foreach (var item in moveList)
            {
                if (item == MovementConstant.TurnLeft)
                {
                    #region Sola Döndüyse yeni Yön Belirlenir

                    if (_robot.Location.Direction == DirectionConstant.South)//güney
                        _robot.Location.Direction = DirectionConstant.East;

                    else if (_robot.Location.Direction == DirectionConstant.East) //doğu
                        _robot.Location.Direction = DirectionConstant.North;

                    else if (_robot.Location.Direction == DirectionConstant.North) // kuzey                
                        _robot.Location.Direction = DirectionConstant.West;

                    else if (_robot.Location.Direction == DirectionConstant.West) // batı                  
                        _robot.Location.Direction = DirectionConstant.South;

                    #endregion
                }
                else if (item == MovementConstant.TurnRight)
                {
                    #region Sağa Döndüyse Yeni Yön Belirlenir

                    if (_robot.Location.Direction == DirectionConstant.South)//güney
                        _robot.Location.Direction = DirectionConstant.West;

                    else if (_robot.Location.Direction == DirectionConstant.West) // batı                  
                        _robot.Location.Direction = DirectionConstant.North;

                    else if (_robot.Location.Direction == DirectionConstant.North) // kuzey                
                        _robot.Location.Direction = DirectionConstant.East;

                    else if (_robot.Location.Direction == DirectionConstant.East) //doğu
                        _robot.Location.Direction = DirectionConstant.South;

                    #endregion
                }

                else if (item == MovementConstant.Go)
                {
                    #region Yeni Koordinat Belirlenir

                    if (_robot.Location.Direction == DirectionConstant.South)//güney
                        _robot.Location.Y--;

                    else if (_robot.Location.Direction == DirectionConstant.North) // kuzey                
                        _robot.Location.Y++;

                    else if (_robot.Location.Direction == DirectionConstant.West) // batı                  
                        _robot.Location.X--;

                    else if (_robot.Location.Direction == DirectionConstant.East) //doğu
                        _robot.Location.X++;

                    #endregion
                }
            }


        }
     
        public static Location ToLocation(this string _move)
        {
            var location = new Location();
            _move = _move.ToUpper();
            location.X = Convert.ToInt32(_move.Split(' ')[0]);
            location.Y = Convert.ToInt32(_move.Split(' ')[1]);
            location.Direction = _move.Split(' ')[2];

            return location;
        }

    
    }
}
