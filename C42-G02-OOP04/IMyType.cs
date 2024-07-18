using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_OOP04
{
    //internal class IMyType
    //{
    //    public int Id { get; set; }
    //    public void MyFun(int x);

    //    public void Print() {
    //        Console.WriteLine("Hello Default Implement Method From Interface");
    //    }

    //}
    internal class MyType : IMyType
    {
        private int _id;
        public int Id 
        { get {return Id; }
            set { Id = value; } 
        }
        public void MyFun(int x) { 
        throw new NotImplementedExcption();
        }
    }
}
