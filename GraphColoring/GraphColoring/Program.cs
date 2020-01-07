using System;
using System.Collections.Generic;

namespace GraphColoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = Affichage();
            Console.WriteLine();
            graph.AffichagePoint();
            graph.SortPoints();
            Console.WriteLine();
            graph.AffichagePoint();
            Console.WriteLine();
            Console.WriteLine(graph.Fill());
            graph.AffichagePoint();
        }

        public static Graph Affichage()
        {
            List<Point> points = new List<Point>();
            Console.WriteLine("Quel modele de graph ?");
            Console.WriteLine("1 : Modele A | 2 : Modele B | 3 : Modele C");
            int input = Convert.ToInt32(Console.ReadLine());
            switch(input)
            {
                case 1:
                    points = ModeleA();
                    break;

                case 2:
                    points = ModeleB();
                    break;
            }
            Console.WriteLine("Combien de couleur ?");
            input = Convert.ToInt32(Console.ReadLine());
            List<ColorEnum> colors = new List<ColorEnum>();
            switch(input)
            {
                case 2:
                    colors = new List<ColorEnum>()
                    {
                        ColorEnum.blue,
                        ColorEnum.red,
                    };
                    break;

                case 3:
                    colors = new List<ColorEnum>()
                    {
                        ColorEnum.blue,
                        ColorEnum.red,
                        ColorEnum.green,
                    };
                    break;
            }
            return new Graph(points, colors);
        }
        public static List<Point> ModeleB()
        {
            Point A = new Point("A");
            Point B = new Point("B");
            Point C = new Point("C");

            List<Point> AL = new List<Point>()
            {
                B,
                C,
            };
            A.Voisin = AL;

            List<Point> BL = new List<Point>()
            {
                A,
                C,
            };
            B.Voisin = BL;

            List<Point> CL = new List<Point>()
            {
                A,
                B,
            };
            C.Voisin = CL;

            return new List<Point>()
            {
                A,
                B,
                C,
            };
        }
        public static List<Point> ModeleA()
        {
            Point A = new Point("A");
            Point B = new Point("B");
            Point C = new Point("C");
            Point D = new Point("D");

            List<Point> AL = new List<Point>()
            {
                B,
                C,
            };
            A.Voisin = AL;

            List<Point> BL = new List<Point>()
            {
                A,
                C,
                D,
            };
            B.Voisin = BL;

            List<Point> CL = new List<Point>()
            {
                A,
                B,
            };
            C.Voisin = CL;

            List<Point> DL = new List<Point>()
            {
                B,
            };
            D.Voisin = DL;

            return new List<Point>()
            {
                A,
                B,
                C,
                D,
            };
        }
    }
}
