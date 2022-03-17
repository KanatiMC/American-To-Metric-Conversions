using System;

class MassManager {

    public static void ToMG()
    {
      Console.WriteLine("1. Ounce To Milligrams");
      Console.WriteLine("2. Pound To Milligrams");
      Console.WriteLine("3. Ton To Milligrams");
      MassManager.mmMsg = Console.ReadLine();
      string mm1s;
      Console.WriteLine("Write Number To Convert");
      mm1s = Console.ReadLine();
    if (mmMsg.Contains("1")){
      float mm1i = float.Parse(mm1s) * 28349.5231f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"mg");
    }
       if (mmMsg.Contains("2")){
      float mm1i = float.Parse(mm1s) * 453592.37f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"mg");
    }
       if (mmMsg.Contains("3")){
      float mm1i = float.Parse(mm1s) * 907184740f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"mg");
    }
    }
public static void ToCG()
{
  Console.WriteLine("1. Ounce To Centigrams");
    Console.WriteLine("2. Pound To Centigrams");
    Console.WriteLine("3. Ton To Centigrams");
    MassManager.mmMsg = Console.ReadLine();
      string mm1s;
      Console.WriteLine("Write Number To Convert");
      mm1s = Console.ReadLine();
    if (mmMsg.Contains("1")){
      float mm1i = float.Parse(mm1s) * 2834.95231f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"cg");
    }
       if (mmMsg.Contains("2")){
      float mm1i = float.Parse(mm1s) * 45359.237f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"cg");
    }
       if (mmMsg.Contains("3")){
      float mm1i = float.Parse(mm1s) * 90718474f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"cg");
    }
}
    public static void ToDG(){
    Console.WriteLine("1. Ounce To Decigrams");
    Console.WriteLine("2. Pound To Decigrams");
    Console.WriteLine("3. Ton To Decigrams");
      MassManager.mmMsg = Console.ReadLine();
      string mm1s;
      Console.WriteLine("Write Number To Convert");
      mm1s = Console.ReadLine();
    if (mmMsg.Contains("1")){
      float mm1i = float.Parse(mm1s) * 283.49523125f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"dg");
    }
       if (mmMsg.Contains("2")){
      float mm1i = float.Parse(mm1s) * 4535.9237f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"dg");
    }
       if (mmMsg.Contains("3")){
      float mm1i = float.Parse(mm1s) * 907184740f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"dg");
    }
    }
    public static void ToG()
    {
        Console.WriteLine("1. Ounce To Grams");
    Console.WriteLine("2. Pound To Grams");
    Console.WriteLine("3. Ton To Grams");
      MassManager.mmMsg = Console.ReadLine();
      string mm1s;
      Console.WriteLine("Write Number To Convert");
      mm1s = Console.ReadLine();
    if (mmMsg.Contains("1")){
      float mm1i = float.Parse(mm1s) * 28.3495231f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"g");
    }
       if (mmMsg.Contains("2")){
      float mm1i = float.Parse(mm1s) * 453.59237f;;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"g");
    }
       if (mmMsg.Contains("3")){
      float mm1i = float.Parse(mm1s) * 907184.74f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"g");
    }
    }
    public static void ToDAG(){
    Console.WriteLine("1. Ounce To Decagrams");
    Console.WriteLine("2. Pound To Decagrams");
    Console.WriteLine("3. Ton To Decagrams");
      MassManager.mmMsg = Console.ReadLine();
      string mm1s;
      Console.WriteLine("Write Number To Convert");
      mm1s = Console.ReadLine();
    if (mmMsg.Contains("1")){
      float mm1i = float.Parse(mm1s) * 2.83495231f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"dag");
    }
       if (mmMsg.Contains("2")){
      float mm1i = float.Parse(mm1s) * 45.359237f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"dag");
    }
       if (mmMsg.Contains("3")){
      float mm1i = float.Parse(mm1s) * 90718.474f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"dag");
    }
    }
    public static void ToHG(){
    Console.WriteLine("1. Ounce To Hectograms");
    Console.WriteLine("2. Pound To Hectograms");
    Console.WriteLine("3. Ton To Hectograms");
      MassManager.mmMsg = Console.ReadLine();
      string mm1s;
      Console.WriteLine("Write Number To Convert");
      mm1s = Console.ReadLine();
    if (mmMsg.Contains("1")){
      float mm1i = float.Parse(mm1s) * .283495231f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"hg");
    }
       if (mmMsg.Contains("2")){
      float mm1i = float.Parse(mm1s) * 4.5359237f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"hg");
    }
       if (mmMsg.Contains("3")){
      float mm1i = float.Parse(mm1s) * 9071.84740f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"hg");
    }
    }
    public static void ToKG(){
    Console.WriteLine("1. Ounce To Kilograms");
    Console.WriteLine("2. Pound To Kilograms");
    Console.WriteLine("3. Ton To Kilograms");
      MassManager.mmMsg = Console.ReadLine();
      string mm1s;
      Console.WriteLine("Write Number To Convert");
      mm1s = Console.ReadLine();
    if (mmMsg.Contains("1")){
      float mm1i = float.Parse(mm1s) * .0283495231f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"kg");
    }
       if (mmMsg.Contains("2")){
      float mm1i = float.Parse(mm1s) * .45359237f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"kg");
    }
       if (mmMsg.Contains("3")){
      float mm1i = float.Parse(mm1s) * 907.184740f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"kg");
    }
    }
  public static string mmMsg;
  
}