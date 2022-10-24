using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_BMI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int weight;
			int height;
			try
			{
				Console.Write("請輸入身高(cm): ");
				string inputHeight = Console.ReadLine();
				height = IsTrueNumber(inputHeight);
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
				return;
			}

			try
			{
				Console.Write("請輸入體重(kg): ");
				string inputWeight = Console.ReadLine();
				weight = IsTrueNumber(inputWeight);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				return;
			}

			double heightCM = (double)height / 100;
			double BMI = weight / (heightCM * heightCM);
			BMI = BMIProcess(BMI);
			Console.WriteLine($"BMI = {BMI}");
		}

		// 只有正確的值才會return值, 否則皆拋出Exception
		static int IsTrueNumber(string value)
		{
			bool isNumber = int.TryParse(value, out int number);
			if (!isNumber) throw new Exception("輸入的值非數字");
			else
			{
				if (number < 0) throw new Exception("數字小於0");
				return number;
			}
		}

		static double BMIProcess(double value)
		{
			value *= 10;
			value = Math.Floor(value);
			value /= 10;

			return value;
		}
	}
}
