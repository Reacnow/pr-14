using ClassLibraryFigur0206;
using System.Drawing;
{
    Circle c;
    Rectangle r;
    Triangle t;
    double p, s;
    Console.WriteLine("Введите значение радиуса окружности");
    c = new Circle(Convert.ToDouble(Console.ReadLine()));
    p = c.Perimeter();
    s = c.Square();
    Console.WriteLine("Периметр окружности равен {0:0.00}; площадь равна {1:0.00}", p, s);
    Console.WriteLine("Введите значение сторон прямоугольника(одно значение на строке)");
    r = new Rectangle(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
    p = r.Perimeter();
    s = r.Square();
    Console.WriteLine("Периметр прямоугольника равен {0:0.00}; площадь равна {1:0.00}", p, s);
    Console.WriteLine("Введите значение сторон треугольника(одно значение на строке)");
    t = new Triangle(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
    if (t.Exists)
    {
        p = t.Perimeter();
        s = t.Square();
        Console.WriteLine("Периметр треугольника равен {0:0.00}; площадь равна {1:0.00}", p, s);
    }
    else Console.WriteLine("С заданными длинами сторон треугольник не может быть построен.");
    Console.WriteLine("Нажмите любую клавишу для завершения работы...");
}
