int x1 = ReadInt("Введите X точки A: ");
int y1 = ReadInt("Введите Y точки A: ");
int z1 = ReadInt("Введите Z точки A: ");
int x2 = ReadInt("Введите X точки B: ");
int y2 = ReadInt("Введите Y точки B: ");
int z2 = ReadInt("Введите Z точки B: ");

int lengthX = x2 - x1; // длинна катетов
int lengthY = y2 - y1;
int lengthZ = z2 - z1;
double distance = Math.Sqrt(lengthX *lengthX + lengthY *lengthY + lengthZ * lengthZ);
Console.WriteLine(distance);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
