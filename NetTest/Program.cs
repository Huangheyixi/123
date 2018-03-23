using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetTest
{
	class Program
	{
		static void Main(string[] args)
		{
			//1.不用中间变量交换两个变量(常考)
			//int i = 10;
			//int j = 30;
			//Console.WriteLine("交换前：");
			//Console.WriteLine($"i={i},j={j}");
			//i = i + j;
			//j = i - j;
			//i = i - j;
			//Console.WriteLine("交换后：");
			//Console.WriteLine($"i={i},j={j}");
			//Console.ReadKey();

			//2.下面是一个由*号组成的4行倒三角形图案。要求：1、输入倒三角形的行数，行数的取值3-21之间，对于非法的行数，要求抛出提示“非法行数！”；2、在屏幕上打印这个指定了行数的倒三角形。

			//*******

			// *****

			//  ***

			//   *

			//Console.WriteLine("请输入三角形行数（3-21）：");
			//string linestr = Console.ReadLine();
			//int line;

			//try
			//{
			//	line = Convert.ToInt32(linestr);
			//	if (line < 3 || line > 21)
			//	{
			//		Console.WriteLine("请输入3-21内的数字");
			//		Console.ReadKey();
			//		return;
			//	}
			//}
			//catch
			//{
			//	Console.WriteLine("请输入合法数字");
			//	Console.ReadKey();
			//	return;
			//}

			//int space = 0;
			//int star = line * 2 - 1;
			//for (int i = line - 1; i >= 0; i--)
			//{
			//	for (int j = space; j > 0; j--)
			//	{
			//		Console.Write(" ");
			//	}
			//	space++;
			//	for (int z = star; z > 0; z--)
			//	{
			//		Console.Write("*");
			//	}
			//	star -= 2;
			//	Console.WriteLine();
			//}
			//Console.ReadKey();

			//3.现有1~10共十个自然数，已随机放入一个有8个元素的数组nums[8]
			//（ 假如是int[] nums = { 3, 9, 8, 2, 4, 6, 10, 7 };）。
			//要求写出一个尽量简单的方案，找出没有被放入数组的那2个数，并在屏幕上打印这2个数。
			//注意：程序不用实现自然数随机放入数组的过程

			//int[] sources = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			//int[] nums = { 3, 9, 8, 2, 4, 6, 10, 7 };
			//Console.WriteLine("以下两个数字在对应数组中不存在");
			//foreach (var num_of_sources in sources)
			//{
			//	if (!IsContain(num_of_sources, nums))
			//	{
			//		Console.WriteLine(num_of_sources);
			//	}
			//}
			//Console.ReadKey();

			//4. 2+5+"8"得到的结果是什么？

			//Console.WriteLine(2 + 5 + "8");//78
			//Console.ReadKey();

			//27. 
			//Person p1 = new Person();
			////Person p2 = new Person();
			//Jack jk = new Jack();

			//Console.ReadKey();

			//28.
			//int i = 2000;
			//object j = i;
			//i = 2001;
			//int o = (int)j;
			//Console.WriteLine($"i={i},j={j},o={o}");
			//Console.ReadKey();

			//29.一个数组：1,1,2,3,5,8,13,21...+m，求第30位数是多少？分别用递归和非递归实现；(常考！！！)

			//非递归
			//int i = 1;
			//int j = 1;
			//int temp;
			//Console.WriteLine($"{i}");
			//for (int z = 2; z <= 30; z++)
			//{
			//	Console.WriteLine($"{j}");
			//	temp = i + j;
			//	//i = j = temp;
			//	i = j;
			//	j = temp;
			//}
			//Console.ReadKey();

			//递归
			//Console.WriteLine(F(30));
			//Console.ReadKey();

			//int[,] sums = new int[,] { { 1, 2, 3, 4, 9 }, { 2, 3, 4, 6, 4 },{ 1,2,3,4,5} };

			//int number =[] ={ 31,23,33,43,35,63};错误

			//AA a = new BB();
			//a.Prt();//调用子类隐藏父类的方法时，父类类型对象调用父类方法；若override父类方法时:总是调用子类方法
			//Console.ReadKey();
		}


		//			41 、
		//下列说法错误的有？（多选题）

		//A：在类方法中可用 this 来调用本类的类方法
		//B：在类方法中调用本类的类方法时可直接调用
		//C：在类方法中只能调用本类中的类方法
		//D：在类方法中绝对不能调用实例方法
		static void Prt()
		{
			//A. this.BB();错误
			//D. new Program().F(1);正确
		}
		static void BB()
		{ }
		static int F(int n)
		{
			if (n == 1)
			{
				return 1;
			}
			if (n == 2)
			{
				return 1;
			}
			return F(n - 1) + F(n - 2);
		}
		private static bool IsContain(int n, int[] nums)
		{
			bool isContain = false;
			foreach (var num in nums)
			{
				if (num == n)
				{
					isContain = true;
				}
			}
			return isContain;
		}
	}
	class AA
	{
		public void Prt()
		{
			Console.WriteLine("父类Prt");
		}
	}
	class BB : AA
	{
		new public void Prt()
		{
			Console.WriteLine("子类Prt");
		}
	}
	class Person
	{
		static Person()
		{
			Console.WriteLine("这是一个Person static构造方法");
		}
		public Person()
		{
			Console.WriteLine("这是一个Person构造方法");
		}
		public static int A = GetValue();
		public static int GetValue()
		{
			Console.WriteLine("已执行GetValue方法");
			return 32;
		}
	}
	class Jack : Person
	{
		public Jack()
		{
			Console.WriteLine("Jack构造方法");
		}
	}

}
