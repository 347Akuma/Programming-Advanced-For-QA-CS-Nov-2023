using System;
using System.Text;

namespace BoxData;

public class Box
{
    private double _length;
    private double _height;
    private double _width;

    public Box(double length, double height, double width)
    {
        this.Length = length;
        this.Height = height;
        this.Width = width;
    }

    public double Length
    {
        get { return this._length; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Length cannot be zero or negative");
            }
            this._length = value;
        }
    }

    public double Height
    {
        get { return this._height; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Height cannot be zero or negative");
            }
            this._height = value;
        }
    }

    public double Width
    {
        get { return this._width; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Width cannot be zero or negative");
            }
            this._width = value;
        }
    }

    public double SurfaceArea()
    {
        return 2 * this.Length * this.Width + 2 * this.Length * this.Height + 2 *
            this.Width * this.Height;
    }

    public double Volume()
    {
        return this.Length * this.Height * this.Width;
    }

    public override string ToString()
    {
        return $"Surface Area - {this.SurfaceArea():F2}{Environment.NewLine}Volume - {this.Volume():F2}";
    }
}
