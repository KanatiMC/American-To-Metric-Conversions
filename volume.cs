using System;

class VolumeManager {

    public static void ToML()
    {
      Console.WriteLine("1. Cups To Milliliters");
      Console.WriteLine("2. Pints To Milliliters");
      Console.WriteLine("3. Quarts To Milliliters");
      Console.WriteLine("4. Gallons To Milliliters");
      VolumeManager.mmMsg = Console.ReadLine();
      string mm1s;
      Console.WriteLine("Write Number To Convert");
      mm1s = Console.ReadLine();
    if (mmMsg.Contains("1")){
      float mm1i = float.Parse(mm1s) * 236.588237f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"mL");
    }
       if (mmMsg.Contains("2")){
      float mm1i = float.Parse(mm1s) * 473.176473f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"mL");
    }
       if (mmMsg.Contains("3")){
      float mm1i = float.Parse(mm1s) * 946.352946f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"mL");
    }
       if (mmMsg.Contains("4")){
      float mm1i = float.Parse(mm1s) * 3785.41178f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"mL");
    }
    }
public static void ToCL()
{
  Console.WriteLine("1. Cups To Centiliters");
    Console.WriteLine("2. Pints To Centiliters");
    Console.WriteLine("3. Quarts To Centiliters");
    Console.WriteLine("4. Gallons To Centiliters");
    VolumeManager.mmMsg = Console.ReadLine();
      string mm1s;
      Console.WriteLine("Write Number To Convert");
      mm1s = Console.ReadLine();
    if (mmMsg.Contains("1")){
      float mm1i = float.Parse(mm1s) * 23.6588237f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"cL");
    }
       if (mmMsg.Contains("2")){
      float mm1i = float.Parse(mm1s) * 47.376473f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"cL");
    }
       if (mmMsg.Contains("3")){
      float mm1i = float.Parse(mm1s) * 94.6352946f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"cL");
    }
       if (mmMsg.Contains("4")){
      float mm1i = float.Parse(mm1s) * 378.541178f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"cL");
    }
}
    public static void ToDL(){
    Console.WriteLine("1. Cups To Deciliters");
    Console.WriteLine("2. Pints To Deciliters");
    Console.WriteLine("3. Quarts To Deciliters");
    Console.WriteLine("4. Gallons To Deciliters");
      VolumeManager.mmMsg = Console.ReadLine();
      string mm1s;
      Console.WriteLine("Write Number To Convert");
      mm1s = Console.ReadLine();
    if (mmMsg.Contains("1")){
      float mm1i = float.Parse(mm1s) * 4.73176473f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"dL");
    }
       if (mmMsg.Contains("2")){
      float mm1i = float.Parse(mm1s) * 3.048f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"dL");
    }
       if (mmMsg.Contains("3")){
      float mm1i = float.Parse(mm1s) * 9.46352946f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"dL");
    }
       if (mmMsg.Contains("4")){
      float mm1i = float.Parse(mm1s) * 37.8541178f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"dL");
    }
    }
    public static void ToL()
    {
        Console.WriteLine("1. Cups To Liters");
    Console.WriteLine("2. Pints To Liters");
    Console.WriteLine("3. Quarts To Liters");
    Console.WriteLine("4. Gallons To Liters");
      VolumeManager.mmMsg = Console.ReadLine();
      string mm1s;
      Console.WriteLine("Write Number To Convert");
      mm1s = Console.ReadLine();
    if (mmMsg.Contains("1")){
      float mm1i = float.Parse(mm1s) * .236588237f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"L");
    }
       if (mmMsg.Contains("2")){
      float mm1i = float.Parse(mm1s) * .473176473f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"L");
    }
       if (mmMsg.Contains("3")){
      float mm1i = float.Parse(mm1s) * .946352946f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"L");
    }
       if (mmMsg.Contains("4")){
      float mm1i = float.Parse(mm1s) * 3.78541178f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"L");
    }
    }
    public static void ToDAL(){
    Console.WriteLine("1. Cups To Decaliters");
    Console.WriteLine("2. Pints To Decaliters");
    Console.WriteLine("3. Quarts To Decaliters");
    Console.WriteLine("4. Gallons To Decaliters");
      VolumeManager.mmMsg = Console.ReadLine();
      string mm1s;
      Console.WriteLine("Write Number To Convert");
      mm1s = Console.ReadLine();
    if (mmMsg.Contains("1")){
      float mm1i = float.Parse(mm1s) * .0236588237f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"daL");
    }
       if (mmMsg.Contains("2")){
      float mm1i = float.Parse(mm1s) * .047376473f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"daL");
    }
       if (mmMsg.Contains("3")){
      float mm1i = float.Parse(mm1s) * .0946352946f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"daL");
    }
       if (mmMsg.Contains("4")){
      float mm1i = float.Parse(mm1s) * .378541178f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"daL");
    }
    }
    public static void ToHL(){
    Console.WriteLine("1. Cups To Hectoliters");
    Console.WriteLine("2. Pints To Hectoliters");
    Console.WriteLine("3. Quarts To Hectoliters");
    Console.WriteLine("4. Gallons To Hectoliters");
      VolumeManager.mmMsg = Console.ReadLine();
      string mm1s;
      Console.WriteLine("Write Number To Convert");
      mm1s = Console.ReadLine();
    if (mmMsg.Contains("1")){
      float mm1i = float.Parse(mm1s) * .00236588237f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"hL");
    }
       if (mmMsg.Contains("2")){
      float mm1i = float.Parse(mm1s) * .00473176473f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"hL");
    }
       if (mmMsg.Contains("3")){
      float mm1i = float.Parse(mm1s) * .00946352946f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"hL");
    }
       if (mmMsg.Contains("4")){
      float mm1i = float.Parse(mm1s) * .0378541178f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"hL");
    }
    }
    public static void ToKL(){
    Console.WriteLine("1. Cups To Kiloliters");
    Console.WriteLine("2. Pints To Kiloliters");
    Console.WriteLine("3. Quarts To Kiloliters");
    Console.WriteLine("4. Gallons To Kiloliters");
      VolumeManager.mmMsg = Console.ReadLine();
      string mm1s;
      Console.WriteLine("Write Number To Convert");
      mm1s = Console.ReadLine();
    if (mmMsg.Contains("1")){
      float mm1i = float.Parse(mm1s) * .000236588237f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"kL");
    }
       if (mmMsg.Contains("2")){
      float mm1i = float.Parse(mm1s) * .000473176473f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"kL");
    }
       if (mmMsg.Contains("3")){
      float mm1i = float.Parse(mm1s) * .00946352946f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"kL");
    }
       if (mmMsg.Contains("4")){
      float mm1i = float.Parse(mm1s) * .00378541178f;
      Console.WriteLine("Your Result Is: "+mm1i.ToString()+"kL");
    }
    }
  public static string mmMsg;
  
}