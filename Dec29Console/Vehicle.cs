using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec29Console
{
    public abstract class vehicle
    {
        public abstract void start();
        public abstract void stop();
    }
    public class car : vehicle
    {
        public override void start()
        {
            Console.WriteLine("car start by key igneation");
        }
        public override void stop()
        {
            Console.WriteLine("by pressing break");
        }
    }
    public class train : vehicle
    {
        public override void start()
        {
            Console.WriteLine("train runs on power ");
        }
        public override void stop()
        { Console.WriteLine(" stops by off power "); }
        static void Main(string[] args)
        {
            vehicle v1 = new car();v1.start();v1.stop();
            vehicle v2 = new train(); v2.start(); v2.stop();
        }
    }
}
