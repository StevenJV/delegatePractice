using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using delegatePractice;

namespace delegatePractice
{
  internal class Rectangle
  {
    private int _length;
    private int _width;

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
      if (_length >= 1) {
        _length--;
      }
      if (_width >= 1) {
        _width--;
      }
    }

    public void AdjustSize(Action<Rectangle> thingToDo) {
      thingToDo.Invoke(this);
    }


  }
}

