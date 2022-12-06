using System;
using Shapes;

namespace MyProgram {
  class Program {
    static void Main(){
      Console.WriteLine("Please enter a side:");
      int a = int.Parse(Console.ReadLine());
      Console.WriteLine("Please enter a side:");
      int b = int.Parse(Console.ReadLine());
      Console.WriteLine("Please enter a side:");
      int c = int.Parse(Console.ReadLine());
      Console.WriteLine(Triangle.IsTriangle(a, b, c));
    }

  }

}
