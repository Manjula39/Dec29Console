using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec29Console { 
    public interface First { void Fun1();
    }
    public interface second { void Fun2();
    }
    public interface Third { void Fun3();
    }
    internal class class1 : First, second, Third
    {
        public void Fun1() { Console.WriteLine("from first interface"); }
        public void Fun2() { Console.WriteLine("from second interface"); }
        public void Fun3() { Console.WriteLine("from third interface"); }

        static void Main(string[] args)
        {
            First f = new class1(); f.Fun1();
            second s = new class1(); s.Fun2();
            Third t = new class1(); t.Fun3();
        }
    }
        }