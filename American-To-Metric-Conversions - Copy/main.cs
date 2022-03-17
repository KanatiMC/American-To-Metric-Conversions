using System;

class Program {
  public static void Main (string[] args) {
    Console.Title= "US To Metric Conversion Calculator";
    Console.WriteLine("American To Metric Conversions\n");
    Console.WriteLine("1. Length");
    Console.WriteLine("2. Weight");
    Console.WriteLine("3. Volume");
    Console.WriteLine("");
    string picking = Console.ReadLine();
    if (picking == "1"){
    Console.WriteLine("Length Units:");
    Console.WriteLine("1. To Millimeters");
    Console.WriteLine("2. To Centimeters");
    Console.WriteLine("3. To Decimeter");
    Console.WriteLine("4. To Meter");
    Console.WriteLine("5. To Decameters");
    Console.WriteLine("6. To Hectometer");
    Console.WriteLine("7. To Kilometer");
    }
    if (picking == "2"){
    Console.WriteLine("Weight Units:");
    Console.WriteLine("1. To Milligrams");
    Console.WriteLine("2. To Centigrams");
    Console.WriteLine("3. To Decigram");
    Console.WriteLine("4. To Gram");
    Console.WriteLine("5. To Decagrams");
    Console.WriteLine("6. To Hectogram");
    Console.WriteLine("7. To Kilogram");
    }
    if (picking == "3"){
    Console.WriteLine("Volume Units:");
    Console.WriteLine("1. To Milliliters");
    Console.WriteLine("2. To Centiliters");
    Console.WriteLine("3. To Deciliter");
    Console.WriteLine("4. To Liter");
    Console.WriteLine("5. To Decaliters");
    Console.WriteLine("6. To Hectoliter");
    Console.WriteLine("7. To Kiloliter");
    }
    Console.WriteLine("\n");
    Program.conMsg = Console.ReadLine();
    Console.WriteLine("\n");
    if (picking == "1"){
      if (conMsg == "1")
      {
        LengthManager.ToMM();
      }
      if (conMsg == "2")
      {
        LengthManager.ToCM();
      }
      if (conMsg == "3")
      {
        LengthManager.ToDM();
      }
      if (conMsg == "4")
      {
        LengthManager.ToM();
      }
      if (conMsg == "5")
      {
        LengthManager.ToDAM();
      }
      if (conMsg == "6")
      {
        LengthManager.ToHM();
      }
      if (conMsg == "7")
      {
        LengthManager.ToKM();
      }
    }
    if (picking == "2"){
      if (conMsg == "1")
      {
        MassManager.ToMG();
      }
      if (conMsg == "2")
      {
        MassManager.ToCG();
      }
      if (conMsg == "3")
      {
        MassManager.ToDG();
      }
      if (conMsg == "4")
      {
        MassManager.ToG();
      }
      if (conMsg == "5")
      {
        MassManager.ToDAG();
      }
      if (conMsg == "6")
      {
        MassManager.ToHG();
      }
      if (conMsg == "7")
      {
        MassManager.ToKG();
      }
    }
    if (picking == "3"){
    
     if (conMsg == "1")
      {
        VolumeManager.ToML();
      }
      if (conMsg == "2")
      {
        VolumeManager.ToCL();
      }
      if (conMsg == "3")
      
      {
        VolumeManager.ToDL();
      }
      if (conMsg == "4")
      {
        VolumeManager.ToL();
      }
      if (conMsg == "5")
      {
        VolumeManager.ToDAL();
      }
      if (conMsg == "6")
      {
        VolumeManager.ToHL();
      }
      if (conMsg == "7")
      {
        VolumeManager.ToKL();
      }
    }
    for (int i = int.MinValue; i < int.MaxValue; i++){
      Console.ReadLine();
    }
  }

  public static string conMsg;
  
}