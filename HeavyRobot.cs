using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRobot
{
    public class HeavyRobot : RobotFrame
    {
        public HeavyRobot()
        {
            modelRobot = $"MK Heavy Robot Serial Number-{CreateRandomSerial(100000000, 999999999)}";
            energy += CreateStatsEnergy(0, 10);
            power += CreateStatsPower(10, 100);

        }
    }
}
