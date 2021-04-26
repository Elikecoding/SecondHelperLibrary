using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHelperLibrary.LogicClasses
{
    public class DemeritPointsCalculator
    {
        //Create two new variables for the speed limit and max speed
        private const int speedLimit = 65;
        private const int maxSpeed = 300;

        //This is where the points are calculated
        public int CalculateDemeritPoints(int speed)
        {
            //Throw an exception if the speed is outside of my range
            if (speed < 0 || speed > maxSpeed)
            {
                throw new ArgumentOutOfRangeException();
            }

            //Under the speed limit so nothing needs to be returned
            if (speed <= speedLimit)
            {
                return 0; 
            }
            //Over the speed limit so deduct points
            else
            {
                const int milePerDemeritPoint = 5;
                var demeritPoints = (speed / speedLimit) / milePerDemeritPoint;

                return demeritPoints;
            }
        }

    }
}
