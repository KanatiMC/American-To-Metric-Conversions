using System;

class LengthManager {

    public static void ToMM()
    {
      Console.WriteLine("1. Inches To Millimeters");
      Console.WriteLine("2. Feet To Millimeters");
      Console.WriteLine("3. Yards To Millimeters");
      Console.WriteLine("4. Miles To Millimeters");
      LengthManager.mmMsg = Console.ReadLine();
      string mm1s;
      Console.WriteLine("Write Number To Convert");
      mm1s = Console.ReadLine();
    if (mmMsg.Contains("1")){
      float mm1i = float.Parse(mm1s) * 25.4f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"mm");
    }
       if (mmMsg.Contains("2")){
      float mm1i = float.Parse(mm1s) * 304.8f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"mm");
    }
       if (mmMsg.Contains("3")){
      float mm1i = float.Parse(mm1s) * 914.4f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"mm");
    }
       if (mmMsg.Contains("4")){
      float mm1i = float.Parse(mm1s) * 1609344f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"mm");
    }
    }
public static void ToCM()
{
  Console.WriteLine("1. Inches To Centimeters");
    Console.WriteLine("2. Feet To Centimeters");
    Console.WriteLine("3. Yards To Centimeters");
    Console.WriteLine("4. Miles To Centimeters");
    LengthManager.mmMsg = Console.ReadLine();
      string mm1s;
      Console.WriteLine("Write Number To Convert");
      mm1s = Console.ReadLine();
    if (mmMsg.Contains("1")){
      float mm1i = float.Parse(mm1s) * 2.54f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"cm");
    }
       if (mmMsg.Contains("2")){
      float mm1i = float.Parse(mm1s) * 30.48f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"cm");
    }
       if (mmMsg.Contains("3")){
      float mm1i = float.Parse(mm1s) * 91.44f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"cm");
    }
       if (mmMsg.Contains("4")){
      float mm1i = float.Parse(mm1s) * 160934f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"cm");
    }
}
    public static void ToDM(){
    Console.WriteLine("1. Inches To Decimeters");
    Console.WriteLine("2. Feet To Decimeters");
    Console.WriteLine("3. Yards To Decimeters");
    Console.WriteLine("4. Miles To Decimeters");
      LengthManager.mmMsg = Console.ReadLine();
      string mm1s;
      Console.WriteLine("Write Number To Convert");
      mm1s = Console.ReadLine();
    if (mmMsg.Contains("1")){
      float mm1i = float.Parse(mm1s) * .254f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"dm");
    }
       if (mmMsg.Contains("2")){
      float mm1i = float.Parse(mm1s) * 3.048f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"dm");
    }
       if (mmMsg.Contains("3")){
      float mm1i = float.Parse(mm1s) * 9.144f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"dm");
    }
       if (mmMsg.Contains("4")){
      float mm1i = float.Parse(mm1s) * 16093.4f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"dm");
    }
    }
    public static void ToM()
    {
    Console.WriteLine("1. Inches To Meters");
    Console.WriteLine("2. Feet To Meters");
    Console.WriteLine("3. Yards To Meters");
    Console.WriteLine("4. Miles To Meters");
      LengthManager.mmMsg = Console.ReadLine();
      string mm1s;
      Console.WriteLine("Write Number To Convert");
      mm1s = Console.ReadLine();
    if (mmMsg.Contains("1")){
      float mm1i = float.Parse(mm1s) * .0254f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"m");
    }
       if (mmMsg.Contains("2")){
      float mm1i = float.Parse(mm1s) * .3048f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"m");
    }
       if (mmMsg.Contains("3")){
      float mm1i = float.Parse(mm1s) * .9144f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"m");
    }
       if (mmMsg.Contains("4")){
      float mm1i = float.Parse(mm1s) * 1609.34f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"m");
    }
    }
    public static void ToDAM(){
    Console.WriteLine("1. Inches To Decameters");
    Console.WriteLine("2. Feet To Decameters");
    Console.WriteLine("3. Yards To Decameters");
    Console.WriteLine("4. Miles To Decameters");
      LengthManager.mmMsg = Console.ReadLine();
      string mm1s;
      Console.WriteLine("Write Number To Convert");
      mm1s = Console.ReadLine();
    if (mmMsg.Contains("1")){
      float mm1i = float.Parse(mm1s) * .00254f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"dam");
    }
       if (mmMsg.Contains("2")){
      float mm1i = float.Parse(mm1s) * .03048f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"dam");
    }
       if (mmMsg.Contains("3")){
      float mm1i = float.Parse(mm1s) * .09144f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"dam");
    }
       if (mmMsg.Contains("4")){
      float mm1i = float.Parse(mm1s) * 160.934f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"dam");
    }
    }
    public static void ToHM(){
    Console.WriteLine("1. Inches To Hectometers");
    Console.WriteLine("2. Feet To Hectometers");
    Console.WriteLine("3. Yards To Hectometers");
    Console.WriteLine("4. Miles To Hectometers");
      LengthManager.mmMsg = Console.ReadLine();
      string mm1s;
      Console.WriteLine("Write Number To Convert");
      mm1s = Console.ReadLine();
    if (mmMsg.Contains("1")){
      float mm1i = float.Parse(mm1s) * .000254f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"hm");
    }
       if (mmMsg.Contains("2")){
      float mm1i = float.Parse(mm1s) * .003048f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"hm");
    }
       if (mmMsg.Contains("3")){
      float mm1i = float.Parse(mm1s) * .009144f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"hm");
    }
       if (mmMsg.Contains("4")){
      float mm1i = float.Parse(mm1s) * 16.0934f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"hm");
    }
    }
    public static void ToKM(){
    Console.WriteLine("1. Inches To Kilometers");
    Console.WriteLine("2. Feet To Kilometers");
    Console.WriteLine("3. Yards To Kilometers");
    Console.WriteLine("4. Miles To Kilometers");
      LengthManager.mmMsg = Console.ReadLine();
      string mm1s;
      Console.WriteLine("Write Number To Convert");
      mm1s = Console.ReadLine();
    if (mmMsg.Contains("1")){
      float mm1i = float.Parse(mm1s) * .0000254f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"km");
    }
       if (mmMsg.Contains("2")){
      float mm1i = float.Parse(mm1s) * .0003048f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"km");
    }
       if (mmMsg.Contains("3")){
      float mm1i = float.Parse(mm1s) * .0009144f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"km");
    }
       if (mmMsg.Contains("4")){
      float mm1i = float.Parse(mm1s) * 1.60934f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"km");
    }
    }
  public static string mmMsg;
}