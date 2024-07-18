using System.ComponentModel.DataAnnotations;

namespace C42_G02_OOP04
{
    internal class Program
    {
        //public static void Print10NumbersFromSeries(SeriesByTow seriesByTow)
        //{
        //    if (seriesByTow is not null)
        //    {
        //        for (int i = 0; i < 10; i++)
        //        {         
        //            console.writeline($"{series.Current}");
        //            series.GetNext();
        //        }
        //        series.Reset();
        //    }
        //}
        //public static void Print10NumbersFromSeries(SeriesByTow seriesByThree)
        //{
        //    if (seriesByTow is not null)
        //    {
        //        for (int i = 0; i < 10; i++)
        //        {         
        //            console.writeline($"{series.Current}");
        //            series.GetNext();
        //        }
        //        series.Reset();
        //    }
        //}
        static void Main(string[] args)
        {
            #region V1
            //IMyType myType = new IMyType();
            //IMyType myType;

            //myType.Id = 20;
            //myType.MyFun(1);
            //myType.Print();

            //MyType myType1 = new MyType();
            //myType1.Id = 20;
            //myType1.MyFun(100);
            //myType1.Print();
            #endregion

            #region V2
            //SeriesByTow seriesByTow =new SeriesByTow();
            //Print10NumbersFromSeries(seriesByTow);

            //SeriesByThree seriesByThree = new SeriesByThree();
            //Print10NumbersFromSeries(seriesByThree);

            #endregion

            #region V3
            //Car car =new Car();
            //car.Backward();
            //car.Forward();
            //Airplane airplane = new Airplane();
            //airplane.Forward();
            //airplane.Backward();
            //airplane.Forward();

            //IMovable movableplan = new Airplane();
            //movableplan.Forward();

            //IFlyable flyableplan = new Airplane();
            //flyableplan.Forward();
            #endregion

            #region V4
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = new int[3];
            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());
            //Arr02 = Arr01;
            //Console.WriteLine("After shallow copy");
            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());

            //Console.WriteLine(Arr01[0]);
            //Console.WriteLine(Arr02[0]);

            //Arr02[0] = 100;

            //Console.WriteLine("After  Arr02[0] = 100;");

            //Console.WriteLine(Arr01[0]);
            //Console.WriteLine(Arr02[0]);


            //Arr02 = (int[]) Arr01.Clone();
            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());

            //Console.WriteLine(Arr01[0]);
            //Console.WriteLine(Arr02[0]);

            //Arr01[0] = 100;

            //Console.WriteLine("After  Arr01[0] = 100;");
            //Console.WriteLine(Arr01[0]);
            //Console.WriteLine(Arr02[0]);
            #endregion

            #region V5
            //string[] names1 = { "ali" };
            //string[] names2 = new string[1];
            //Console.WriteLine(names1.GetHashCode());
            //Console.WriteLine(names2.GetHashCode());
            //names2 = names1;
            //Console.WriteLine("After shallow copy");
            //Console.WriteLine(names1.GetHashCode());
            //Console.WriteLine(names2.GetHashCode());
            //Console.WriteLine(names1[0]);
            //Console.WriteLine(names2[0]);
            //names2[0] = "aya";
            //Console.WriteLine(names1[0]);
            //Console.WriteLine(names2[0]);
            ////Deepcopy
            //names2 = (string[]) names1.Clone();
            //Console.WriteLine("After shallow copy");
            //Console.WriteLine(names1.GetHashCode());
            //Console.WriteLine(names2.GetHashCode());
            //Console.WriteLine(names1[0]);
            //Console.WriteLine(names2[0]);
            //names2[0] = "aya";
            //Console.WriteLine(names1[0]);
            //Console.WriteLine(names2[0]);

            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion
        }
    }
}
