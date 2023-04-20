//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите x первой точки:");
string str_x_a = Console.ReadLine();
double x_a = Convert.ToInt32(str_x_a);
Console.WriteLine("Введите y первой точки:");
string str_y_a = Console.ReadLine();
double y_a = Convert.ToInt32(str_y_a);
Console.WriteLine("Введите z первой точки:");
string str_z_a = Console.ReadLine();
double z_a = Convert.ToInt32(str_z_a);
Console.WriteLine("Введите x второй точки:");
string str_x_b = Console.ReadLine();
double x_b = Convert.ToInt32(str_x_b);
Console.WriteLine("Введите y второй точки:");
string str_y_b = Console.ReadLine();
double y_b = Convert.ToInt32(str_y_b);
Console.WriteLine("Введите z второй точки:");
string str_z_b = Console.ReadLine();
double z_b = Convert.ToInt32(str_z_b);
double distance_3D = Math.Sqrt(((x_b-x_a)*(x_b-x_a))+((y_b-y_a)*(y_b-y_a))+((z_b-z_a)*(z_b-z_a))); //Ну или через ^2
Console.WriteLine(distance_3D);
