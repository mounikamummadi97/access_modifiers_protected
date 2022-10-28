using System;
namespace protectedAccessModifier
{
    class x
    {
        protected int X;
        public x()
        {
            X = 20;
        }
    }
    class Y : x
    {
        public int getX()
        {
            return X;   
        }
    }
   
    class program
    {
        static void Main(string[] args)

        {
            x obj1 = new x();
            Y obj2 = new Y();
            Console.WriteLine("value of x is : {0}", obj2.getX());
            //Console.WriteLine("value of Y is : {0}", obj1.getY());
        }
    }
}