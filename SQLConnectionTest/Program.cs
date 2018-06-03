using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLConnectionTest
{
	class Program
	{
		static void Main(string[] args)
		{
			////文件流读写
			//using (Stream inStream = new FileStream(@"1.txt", FileMode.OpenOrCreate))
			//using (StreamWriter writer = new StreamWriter(inStream,Encoding.ASCII))
			//{
			//	writer.WriteAsync("I'm a Student.");
			//}
			//using (Stream inStream = new FileStream("1.txt", FileMode.Open))
			//using (StreamReader reader = new StreamReader(inStream,Encoding.ASCII))
			//{
			//	string text = reader.ReadToEnd();
			//	Console.WriteLine(text);
			//}
			//Console.ReadKey();

			Action a = new Action(() => Console.WriteLine("Action委托"));
			a += () => Console.WriteLine("qgatq");
			Delegate[] list = a.GetInvocationList();
			foreach(var item in list)
			{
				Console.WriteLine(item.GetType());
			}
			a();
			Console.ReadKey();
		}
	}
}
