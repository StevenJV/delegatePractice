using System;

// ReSharper disable once CheckNamespace
namespace delegatePractice
{
  class Program
  {
    static void Main(string[] args) {

      Action<int, int> displaySize = (a, b) => Console.WriteLine(string.Format("object is {0} x {1}", a, b));

      IShape box = new Rectangle();
      displaySize(box.Perimiter(), box.Area());

      var circle = When<Circle>(shape =>
      {
        shape.Grow();
        shape.Shrink();
      });

      var rectangle = When<Rectangle>(ShrinkRectangle);



      IShape myThing = box;  // or = circle; we shouldn't care from this point on. 

      Action myAction = myThing.Grow;

      //we don't care what the thing is, make it bigger
      PerformTwice(myAction);

      // doSomething(  )  

      Console.Read();
    }

    private static void ShrinkRectangle(Rectangle rectangle)
    {
      rectangle.Shrink();
    }

    private static TShape When<TShape>(Action<TShape> shapeInitializer)
      where TShape : IShape, new()
    {
      var shape = new TShape();
      shapeInitializer(shape);
      return shape;
    }

    private static void PerformTwice(Action shapeAction)
    {
      shapeAction();
      shapeAction();
    }

  }
}
