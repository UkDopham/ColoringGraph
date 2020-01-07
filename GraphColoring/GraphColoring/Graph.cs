using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphColoring
{
    public class Graph
    {
        private List<Point> _points;
        private List<ColorEnum> _colors;

        public Graph(List<Point> points, List<ColorEnum> colors)
        {
            this._points = points;
            this._colors = colors;
        }

        public Graph()
        {

        }
        public bool Fill()
        {
            bool isPossible = true;
            SortPoints();
            foreach(Point point in this._points)
            {
                isPossible = GetColor(point);
                if(!isPossible)
                {
                    Console.WriteLine("Stop");
                    break;
                }
            }
            return isPossible;
        }
        private bool GetColor(Point point)
        {
            List<ColorEnum> colors = point.Voisin.Select(x => x.Color).Where(x => x != ColorEnum.none).ToList();
            point.Color = GetLessUsedColor(colors);
            return point.Color != ColorEnum.none;
        }
        private ColorEnum GetLessUsedColor(List<ColorEnum> colorvoisin)
        {
            return this._colors.FirstOrDefault(x => !colorvoisin.Contains(x) && x != ColorEnum.none);
        }
        public void SortPoints()
        {
            this._points.Sort();
        }
        public void AffichagePoint()
        {
            foreach(Point point in this._points)
            {
                Console.Write($"| {point} |");
            }
        }
    }
}
