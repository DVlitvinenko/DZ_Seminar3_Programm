
public class Metods
{
  
//1. Ввод данных

public static int Input (string text)
{
  Console.Write(text + " ");
  return Convert.ToInt32(Console.ReadLine());;
}




//2/ получаем таблицу кубов до max
public static void ThreeCubed (int max)
{
  Console.Write(max + " -> 1");
  for (int i = 2; i <= max; i++)
  {
    Console.Write(", " + i*i*i);
  }
}
}

 
