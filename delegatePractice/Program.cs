using System;

namespace delegatePractice
{
  class Program
  {
    static void Main(string[] args) {
      //Action<int, int> printNumber = methods.PrintNumbersUp;
      //printNumber(5, 20);
      //printNumber = methods.PrintNumbersDown;
      //printNumber(5, 20);

      Action<int, int> displaySize = (a, b) => Console.WriteLine(string.Format("object is {0} x {1}", a, b));

      var box = new Rectangle();
      box.AdjustSize(box.Grow());

      displaySize(box.Perimiter(), box.Area());

      DoInorder(methods.PrintNumbersUp, methods.PrintNumbersDown);

      Console.Read();
    }

    private static void DoInorder(Action<int, int> firstAction,
                                  Action<int, int> secondAction) {
      firstAction(1, 5);
      secondAction(6, 10);
    }


  }
}
