// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("Введите число x1: ");
int numb1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число y1: ");
int numb2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число z1: ");
int numb3 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число x2: ");
int numb4 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число y2: ");
int numb5 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число z2: ");
int numb6 = Convert.ToInt32(Console.ReadLine());

int DifX = numb1 - numb4;
int DifY = numb2 - numb5;
int DifZ = numb3 - numb6;

double squareX = Math.Pow(DifX, 2);
double squareY = Math.Pow(DifY, 2);
double squareZ = Math.Pow(DifZ, 2);
double sumSqr = squareX + squareY + squareZ;
double result = Math.Sqrt(sumSqr);

System.Console.WriteLine(Math.Round(result, 2));
