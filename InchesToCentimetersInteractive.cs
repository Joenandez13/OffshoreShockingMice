using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter inches: ");
    double inches = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(inches * 2.54 + " centimeters");
  }
}