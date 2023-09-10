using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRobot
{
    public class LightRobot : RobotFrame
    {
       
     
        public LightRobot() 
       {
            modelRobot = $"MK Light Robot Serial Number-{CreateRandomSerial(100000000, 999999999)}";
            energy += CreateStatsEnergy(20, 300);
            power += CreateStatsPower(0,30); 
        
       }
    }
}
