using System.Drawing;
using static C42_G02_OOP04.Class1;

namespace C42_G02_OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //What is the primary purpose of an interface in C#?
            // b) To define a blueprint for a class
            #endregion

            #region 2
            //Which of the following is NOT a valid access modifier for interface members in C#?
            //a) private
            #endregion

            #region 3
            //Can an interface contain fields in C#?
            //b) No
            #endregion

            #region 4
            //In C#, can an interface inherit from another interface?
            //b) Yes, interfaces can inherit from multiple interfaces
            #endregion

            #region 5
            //Which keyword is used to implement an interface in a class in C#?
            //b) use
            #endregion

            #region 6
            //Can an interface contain static methods in C#?
            //a) Yes
            #endregion

            #region 7
            //In C#, can an interface have explicit access modifiers for its members?
            //b) No, all members are implicitly public
            #endregion

            #region 8
            //What is the purpose of an explicit interface implementation in C#?
            //b) To provide a clear separation between interface and class members
            #endregion

            #region 9
            //In C#, can an interface have a constructor?
            //b) No, interfaces cannot have constructors
            #endregion

            #region 10
            //How can a C# class implement multiple interfaces?
            //c) By separating interface names with commas
            #endregion

            #region part2 -1
            //Define an interface named IShape with a property Area and a method DisplayShapeInfo. Create two interfaces, ICircle and IRectangle, that inherit from IShape. Implement these interfaces in classes Circle and Rectangle. Test your implementation by creating instances of both classes and displaying their shape information.
            ICircle circle = new Circle(5.0);
            circle.DisplayShapeInfo();

            Console.WriteLine();

            IRectangle rectangle = new Rectangle1(4.0,5.0);
            rectangle.DisplayShapeInfo();
            #endregion

            #region Q2
            IAuthenticationService authService = new BasicAuthenticationService();
            string username = "admin";
            string password = "123456789";
            bool isAuthenticated = authService.AuthenticateUser(username, password);
            if (isAuthenticated)
            {
                Console.WriteLine("Authentication successful!");
            }
            else
            {
                Console.WriteLine("Authentication failed!");
            }

            Console.WriteLine();
            string role = "admin";
            bool isAuthorized = authService.AuthorizeUser(username, role);

            if (isAuthorized)
            {
                Console.WriteLine("Authorization successful!");
            }
            else
            {
                Console.WriteLine("Authorization failed!");
            }
            #endregion
        }
    }
}
