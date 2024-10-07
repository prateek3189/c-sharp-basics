using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      // --------- Introduction ---------------- //
      // Console.WriteLine("Hello World!!");

      // Variables and Constant
      // var number = 0;
      // var count = 10;
      // var totalPrice = 20.95f;
      // var character = 'A';
      // var firstName = "Prateek";
      // var isWorking = true;

      // Console.WriteLine(number);
      // Console.WriteLine(count);
      // Console.WriteLine(totalPrice);
      // Console.WriteLine(character);
      // Console.WriteLine(firstName);
      // Console.WriteLine(isWorking);

      // System.Console.WriteLine("{0} {1}", 123, 456);
    
      // --------- Type Conversion ---------------- //
      // int i = 1000;
      // byte b = (byte) i;

      // var number = "1234";
      // int i = Convert.ToInt32(number);

      // try 
      // {
      //   var number = "1234";
      //   int i = Convert.ToByte(number);
      //   System.Console.WriteLine(i);
      // } 
      // catch(Exception) 
      // {
      //   System.Console.WriteLine("The number could not be converted to a byte");
      // }
      
      // --------- Operators ---------------- //
      var a = 10;
      var b = 30;

      System.Console.WriteLine(a + b);
      System.Console.WriteLine(a - b);
      System.Console.WriteLine(a * b);
      System.Console.WriteLine((float)a / (float)b);
    }
  }
}