using System;


namespace delegatePractice
{
  public interface IShape
  {
    int Perimiter();
    int Area();
    void Grow();
    void Shrink();
    void AdjustSize();
    string Type();
  }

  internal class Circle : IShape
  {
    private int _radius ;

    public string Type()
    {
      return "Circle";
    }
    public Circle()
    {
      this._radius = 2;
    }

    public Circle(int radius)
    {
      this._radius = radius;
    }

    public int Perimiter()
    {
      return (int) (_radius*2*Math.PI);
    }

    public int Area()
    {
      return (int) (Math.PI*(_radius ^ 2));
    }

    public void Grow()
    {
      this._radius++;
    }

    public void Shrink()
    {
      if (_radius >= 1) {
        _radius--;
      }
    }

    public void AdjustSize()
    {
      throw new NotImplementedException();
    }
  }

  internal class Rectangle:IShape
  {
    private int _length;
    private int _width;
    private int _minLength = 1;
    private int _minWidth = 1;
    private int maxLength = 5;
    private int maxWidth = 5;

    public string Type()
    {
      return "Rectangle";
    }
    public Rectangle()
    {
      this._length = 2;
      this._width = 3;
    }
    public Rectangle(int lengthOfSquareSize) {
      this._length = lengthOfSquareSize;
      this._width = lengthOfSquareSize;
    }
    public Rectangle(int length, int width) {
      this._length = length;
      this._width = width;
    }

    public int Perimiter() {
      return _length * 2 + _width * 2;
    }

    public int Area() {
      return _length * _width;
    }

    public void Grow() {
      _length++;
      _width++;
    }

    public void Shrink() {
      if (_length >= _minLength) {
        _length--;
      }
      if (_width >= _minWidth) {
        _width--;
      }
    }

    public void AdjustSize()
    {
      throw new NotImplementedException();
    }
  }



}

