using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLR1
{
    class Program
    {
        static void Main(string[] args)
        {
            var figures = new List<BaseFigure>();
            while (true)
            {
                Console.WriteLine("Choose what you want");
                Console.WriteLine("0 - Add new figure");
                Console.WriteLine("1 - Write list of figures");
                Console.WriteLine("2 - Delete figure");
                Console.WriteLine("3 - Exit");

                
                int choice = int.Parse(Console.ReadLine());

                if (choice == 0)
                {
                    Console.WriteLine("Choose figure that you want to add");
                    Console.WriteLine("0 - Triangle");
                    Console.WriteLine("1 - Quadrangle");
                    Console.WriteLine("2 - Parallelogram");
                    Console.WriteLine("3 - Rectangle");
                    Console.WriteLine("4 - Square");
                    Console.WriteLine("5 - Rhombus");
                    Console.WriteLine("6 - Ellipse");
                    Console.WriteLine("7 - Circle");

                    int ChoiceForAdd = int.Parse(Console.ReadLine());
                    int[] Coordinates = new int[8];
                    string[] nums_strings;

                    switch (ChoiceForAdd)
                    {
                        case 0:
                            Console.WriteLine("Write sides of triangle");
                            nums_strings = Console.ReadLine().Split();
                            for (int i = 0; i < nums_strings.Length; i++)
                                Coordinates[i] = Convert.ToInt32(nums_strings[i]);
                            figures.Add(new Triangle(Coordinates[0],Coordinates[1],Coordinates[2]));
                            break;

                        case 1:
                            Console.WriteLine("Write 8 coordinates for quadrangle");
                            nums_strings = Console.ReadLine().Split();
                            for (int i = 0; i < nums_strings.Length; i++)
                                Coordinates[i] = Convert.ToInt32(nums_strings[i]);
                            figures.Add(new Quadrangle(Coordinates[0], Coordinates[1], Coordinates[2], Coordinates[3], Coordinates[4], Coordinates[5], Coordinates[6], Coordinates[7]));
                            break;

                        case 2:
                            Console.WriteLine("Write 8 coordinates for parallelogram");
                            nums_strings = Console.ReadLine().Split();
                            for (int i = 0; i < nums_strings.Length; i++)
                                Coordinates[i] = Convert.ToInt32(nums_strings[i]);
                            figures.Add(new Parallelogram(Coordinates[0], Coordinates[1], Coordinates[2], Coordinates[3], Coordinates[4], Coordinates[5], Coordinates[6], Coordinates[7]));
                             break;

                        case 3:
                            Console.WriteLine("Write 8 coordinates for rectangle");
                            nums_strings = Console.ReadLine().Split();
                            for (int i = 0; i < nums_strings.Length; i++)
                                Coordinates[i] = Convert.ToInt32(nums_strings[i]);
                            figures.Add(new Rectangle(Coordinates[0], Coordinates[1], Coordinates[2], Coordinates[3], Coordinates[4], Coordinates[5], Coordinates[6], Coordinates[7]));
                            break;

                        case 4:
                            Console.WriteLine("Write 8 coordinates for square");
                            nums_strings = Console.ReadLine().Split();
                            for (int i = 0; i < nums_strings.Length; i++)
                                Coordinates[i] = Convert.ToInt32(nums_strings[i]);
                            figures.Add(new Square(Coordinates[0], Coordinates[1], Coordinates[2], Coordinates[3], Coordinates[4], Coordinates[5], Coordinates[6], Coordinates[7]));
                            break;

                        case 5:
                            Console.WriteLine("Write 4 coordinates for rhombus");
                            nums_strings = Console.ReadLine().Split();
                            for (int i = 0; i < nums_strings.Length; i++)
                                Coordinates[i] = Convert.ToInt32(nums_strings[i]);
                            figures.Add(new Rhombus(Coordinates[0], Coordinates[1], Coordinates[2], Coordinates[3]));
                            break;

                        case 6:
                            Console.WriteLine("Write 4 coordinates for ellipse");
                            nums_strings = Console.ReadLine().Split();
                            for (int i = 0; i < nums_strings.Length; i++)
                                Coordinates[i] = Convert.ToInt32(nums_strings[i]);
                            figures.Add(new Ellipse(Coordinates[0], Coordinates[1], Coordinates[2], Coordinates[3]));
                          break;

                        case 7:
                            Console.WriteLine("Write 2 coordinates and radius for circle");
                            nums_strings = Console.ReadLine().Split();
                            for (int i = 0; i < nums_strings.Length; i++)
                                Coordinates[i] = Convert.ToInt32(nums_strings[i]);
                            figures.Add(new Circle(Coordinates[0], Coordinates[1], Coordinates[2]));
                            break;

                            
                    }
                    Console.Clear();
                }

                if (choice == 1)
                {
                     foreach (var f in figures)
                      {
                          f.PrintFigure();
                      }
                    
                }

                if (choice == 2)
                {
                    Console.WriteLine("Write index figure that you want delete");
                    int id = int.Parse(Console.ReadLine());
                    figures.RemoveAt(id);
                    
                }

                if (choice == 3)
                {
                    break;
                }
            }

        }
    }
}
