using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace GraphColoring
{
    public class Point : IComparable<Point> 
    {
        private ColorEnum _color;
        private string _name;
        private List<Point> _voisins;

        public string Name
        {
            get
            {
                return this._name;
            }
        }
        public ColorEnum Color
        {
            get
            {
                return this._color;
            }
            set
            {
                this._color = value;
            }
        }

        public List<Point> Voisin
        {
            get
            {
                return this._voisins;
            }
            set
            {
                this._voisins = value;
            }
        }
        public Point(string name)
        {
            this._name = name;
            this._color = ColorEnum.none;
        }
        public Point(List<Point> voisins)
        {
            this._color = ColorEnum.none;
            this._voisins = voisins;
        }

        public override string ToString()
        {
            return $"{this._name} {this._color} {this._voisins.Count}";
        }

        public int CompareTo([AllowNull] Point other)
        {
            int value = 0;
            value = this._voisins.Count < other._voisins.Count ? 1 : -1;
            return value;
        }
    }
}
