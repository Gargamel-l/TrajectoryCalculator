using System;

class TrajectoryCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the initial velocity of the ball in mps:");
        double v0 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the angle of the ball launch relative to the horizontal in degrees:");
        double angleDegrees = Convert.ToDouble(Console.ReadLine());
        double angleRadians = angleDegrees * (Math.PI / 180); // Преобразование в радианы

        const double g = 9.81; // Ускорение свободного падения

        // Расчет максимальной высоты
        double maxHeight = (v0 * v0 * Math.Sin(angleRadians) * Math.Sin(angleRadians)) / (2 * g);

        // Расчет дальности полета
        double range = (v0 * v0 * Math.Sin(2 * angleRadians)) / g;

        Console.WriteLine($"Max hight: {maxHeight:F2} meters");
        Console.WriteLine($"Long flight: {range:F2} meters");
    }
}
