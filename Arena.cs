using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppRobot
{
    public class Arena : Messages
    {
        public DateTime Fecha()
        {
            return DateTime.Now;
        }
      


        public int RandomNumber()
        {
            Random n = new Random();
            int m = n.Next(0, 2);
            return m;
        }

        

        public RobotFrame GenerateRobot(int m )
        {

            if (m == 1)
            {
                return new HeavyRobot();
            }
            else
            {
                return new LightRobot();
            }


        }

        public void Combat(RobotFrame robotOne, RobotFrame robotTwo)
        {
            bool flag = true;
            var r1 = robotOne;
            var r2 = robotTwo;
          
            while (flag)
            {
                if (r1.energy >0 && r2.energy > 0)
                {
                    r1.energy -= r2.power;
                    Thread.Sleep(300);

                    Console.WriteLine($"* {r1.modelRobot} << INCOMING DAMAGE >> {r2.power} - ENERGY REMAINING: {r1.energy}");
                    PrintE();

                    if (r1.energy <= 0)
                    {
                        Console.WriteLine($"{r2.modelRobot} IS THE WINNER!");
                        flag = false;
                    }

                    r2.energy -= r1.power;
                    Thread.Sleep(300);


                    Console.WriteLine($"{r2.modelRobot} << INCOMING DAMAGE >> {r1.power} - ENERGY REMAINING: {r2.energy}");
                    PrintE();

                    if (r2.energy <= 0)
                    {
                        Console.WriteLine($"* {r1.modelRobot} IS THE WINNER!");
                        PrintE();
                        flag = false;
                    }


                }
                else
                {
                    flag = false;

                    
                   
                }
            }
            

        }

        public void Start()
        {
            Print($"...STARTING PROGRAM....{Fecha()}");
            PrintA();
            Print($"...GENERATING ROBOTS....{Fecha()}");
            PrintA();

           var robot1 =  GenerateRobot(RandomNumber()); 
           Thread.Sleep(2000);                                        
           var robot2 =  GenerateRobot(RandomNumber());
            Print($"...ROBOTS GENERATED...{Fecha()}");
            PrintA();

            Print($"...ROBOTS STATS: ...{Fecha()}");
            PrintE();
            PrintA();
            Print(robot1.GetData());
            PrintE();
            Print(robot2.GetData());
            PrintA();

            Print($"....STARTING COMBAT...{Fecha()}");
            PrintA();


            Combat(robot1,robot2);

            PrintA();
            Console.WriteLine($"....COMBAT FINISHED...{Fecha()}");
            PrintA();



        }

        

    }
}
