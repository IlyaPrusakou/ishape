using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ishape // interface
{
    public interface IShape
    {
        double? GetArea
        {
            get;
            set;
        }
    }
    class Round : IShape // realize interface
    {
        public double radius { get; set; }
        public string title { get; set; }
        private double? area;
        public double? GetArea
        {
            get
            {
                return area;
            }
            set
            {
                if (value.HasValue == false)
                {
                    
                    value = Math.PI * Math.Pow(radius, 2);
                    area = value;
                } 
            }
        }
    }
    class Rectangle: IShape // realize interface
    {
        public double aside { get; set; }
        public double bside { get; set; }
        public string title { get; set; }
        private double? area;
        public double? GetArea
        {
            get
            {
                return area;
            }
            set
            {
                if (value.HasValue == false)
                {
                   
                    value = aside * bside;
                    area = value;
                }
            }
        }
    }
    class Square: IShape // realize interface
    {
        public double side { get; set; }
        public string title { get; set; }
        private double? area;
        public double? GetArea
        {
            get
            {
                return area;
            }
            set
            {
                if (value.HasValue == false)
                {
                    
                    value = Math.Pow(side, 2);
                    area = value;
                }
            }
        }
    }
    class Program
    {
        public static IShape[,] CreateShape() // create massive
        {
            IShape[,] mas = new IShape[10, 3];
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        mas[j, i] = new Round { radius = j + 1, GetArea = null };
                    }
                }
                else if (i == 1)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        mas[j, i] = new Rectangle { aside = j + 1, bside = j+3, GetArea = null };
                    }
                }
                else if (i == 2)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        mas[j, i] = new Square { side = j + 1, GetArea = null };
                    }
                } 
            }
            return mas;
        }
        public static void PrintShape() // render massive
        {
            IShape[,] renderMas = CreateShape();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                        Console.Write(renderMas[i, j].GetArea + "  ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            PrintShape();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
