using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRobot
{
    public class RobotFrame
    {
        public string modelRobot;
        public int energy = 1000;
        public int power = 50;

        public int CreateStatsEnergy(int n1, int n2)
        {
            Random r = new Random();
            int energy = r.Next(n1, n2);
            return energy;

        }

        public int CreateStatsPower(int n1, int n2)
        {
            Random r = new Random();
            int power = r.Next(n1, n2);
            return power;

        }

        public virtual int CreateRandomSerial(int n1, int n2)
        {
            Random r = new Random();
            int serial = r.Next(n1, n2);
            return serial;

        }

        public string GetData()
        {
            return $"MODEL: {this.modelRobot}\nENERGY: {this.energy}\nPOWER ATTACK: {this.power}";
        }


    }
}
