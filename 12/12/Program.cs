using System;

class Program
{
    static void Main(string[] args)
    {
        // 輸入身高(公分)與體重(公斤)
        Console.Write("請輸入身高(公分): ");
        double height = Convert.ToDouble(Console.ReadLine());

        Console.Write("請輸入體重(公斤): ");
        double weight = Convert.ToDouble(Console.ReadLine());

        // 換算身高為公尺
        double heightInMeter = height / 100;

        // 計算 BMI
        double bmi = weight / (heightInMeter * heightInMeter);

        // 輸出結果
        Console.WriteLine("您的BMI值為: " + bmi);
        Console.Read();
    }
}
