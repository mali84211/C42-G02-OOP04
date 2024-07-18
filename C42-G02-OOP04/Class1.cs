using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_OOP04
{
    internal class Class1
    {
        public interface IShape
        {
            double Area { get; }  
            void DisplayShapeInfo();  
        }
        public interface ICircle : IShape
        {
            double Radius { get; }  
        }
        public interface IRectangle : IShape
        {
            double Length { get; }  
            double Width { get; }  
        }
        public class Circle : ICircle
        {
            public double Radius { get; private set; }

            public Circle(double radius)
            {
                Radius = radius;
            }

            public double Area => Math.PI * Radius * Radius;

            public void DisplayShapeInfo()
            {
                Console.WriteLine($"Circle with radius {Radius}");
                Console.WriteLine($"Area: {Area}");
            }
        }
        public class Rectangle1 : IRectangle
        {
            public double Length { get; private set; }
            public double Width { get; private set; }

            public Rectangle1(double length, double width)
            {
                Length = length;
                Width = width;
            }

            public double Area => Length * Width;

            public void DisplayShapeInfo()
            {
                Console.WriteLine($"Rectangle with length {Length} and width {Width}");
                Console.WriteLine($"Area: {Area}");
            }
        }
        public interface IAuthenticationService
        {
            bool AuthenticateUser(string username, string password);
            bool AuthorizeUser(string username, string role);
        }

       
        public class BasicAuthenticationService : IAuthenticationService
        {
            private readonly string validUsername = "admin";
            private readonly string validPassword = "123456789";
            private readonly string validRole = "admin";

            public bool AuthenticateUser(string username, string password)
            {
                
                return username == validUsername && password == validPassword;
            }

            public bool AuthorizeUser(string username, string role)
            {
                
                return username == validUsername && role == validRole;
            }
        }
    }
}
