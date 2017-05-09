using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    interface A
    {
        void a();//theo mac dinh, public va abstract  
        void b();
        void c();
        void d();
    }

    abstract class B : A
    {
        public void a()
        {
            throw new NotImplementedException();
        }

        public void b()
        {
            throw new NotImplementedException();
        }

        public void c()
        {
            throw new NotImplementedException();
        }

        public void d()
        {
            throw new NotImplementedException();
        }
    }
    class M : B
    {
        public void a() { System.out.println("Toi la a"); }
        public void b() { System.out.println("Toi la b"); }
        public void d() { System.out.println("Toi la d"); }
    }


class Program
    {


    static void Main(string[] args)
        {
        }
    }
}
