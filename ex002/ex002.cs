using static Metods;
public class Ex002
{
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Расстояние между двумя точками равно квадратному корню из суммы квадратов разностей координат по каждой 
// оси. Каждая точка на плоскости характеризуется двумя координатами, а каждая точка в пространстве – тремя.
//  Формула: l = √ (x 2 - x 1)^2+ (y 2 - y 1)^2+ (z 2 - z 1)^2

public static void Ex002_Points()
{
//получить точки с координатами:
//создали два массива для хранения координат
int []point1 = CreateArray(3);
int []point2 = CreateArray(3);
//заполняем массивы с клавиатуры
FillArrayKeyboard(point1);
FillArrayKeyboard(point2);
//проверка, выводим что получилось
WriteArray(point1);
Console.WriteLine();
WriteArray(point2);
//считаем расстояние по формуле и выводим в консоль
Console.WriteLine();
Console.WriteLine(LengthBetwinPoints(point1, point2));
}
}



