namespace Task_1;
//Разработать статический класс для работы с окружностью. Класс должен содержать 3 метода:

//метод, определяющий длину окружности по заданному радиусу;
//метод, определяющий площадь круга по заданному радиусу;
//метод, проверяющий принадлежность точки с координатами(x, y) кругу с радиусом r и координатами центра x0, y0.
 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите радиус");
        double r = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите координаты точки");
        double x = Convert.ToDouble(Console.ReadLine());
        double y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите координаты центра круга");
        double x0 = Convert.ToDouble(Console.ReadLine());
        double y0 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(Circle.GetLenth(r));
        Console.WriteLine(Circle.GetSquare(r));
        Console.WriteLine(Circle.IsPoinHere(r,x,y,x0,y0));
        Console.ReadKey();

    }
}

