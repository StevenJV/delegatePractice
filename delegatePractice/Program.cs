using System;

// ReSharper disable once CheckNamespace
namespace delegatePractice
{
  class Program
  {
    static void Main(string[] args) {

      Action<string, int, int> displaySize = (a, b, c) => Console.WriteLine(string.Format("{0} has perimiter {1}, area {2}", a, b, c));

      IShape box = new Rectangle();

      IShape myThing = box;  // or = circle; we shouldn't care from this point on. 
      displaySize(myThing.Type(), myThing.Perimiter(), myThing.Area());

      Action myAction = myThing.Grow;  // or .Shrink, we don't care
      displaySize(myThing.Type(), myThing.Perimiter(), myThing.Area());

      var circle = CreateAndDoAction<Circle>(shape => {
        shape.Grow();
        shape.Shrink();
      });

      var rectangle = CreateAndDoAction<Rectangle>(ShrinkRectangle);
      displaySize(myThing.Type(), myThing.Perimiter(), myThing.Area());

      //we don't care what the thing or the action is, do it twice.
      PerformTwice(myAction);
      displaySize(myThing.Type(), myThing.Perimiter(), myThing.Area());

      Console.Read();
    }

    private static void ShrinkRectangle(Rectangle rectangle) {
      rectangle.Shrink();
    }

    private static TShape CreateAndDoAction<TShape>(Action<TShape> shapeInitializer)
      where TShape : IShape, new() {
      var shape = new TShape();
      shapeInitializer(shape);
      return shape;
    }

    private static void PerformTwice(Action shapeAction) {
      shapeAction();
      shapeAction();
    }

  }
}
