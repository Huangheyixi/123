using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBase2
{
	class Program
	{
		static void Main(string[] args)
		{
			////read text to datebase
			//using (FileStream steam = File.OpenRead("data.txt"))
			//using (StreamReader reader = new StreamReader(steam,Encoding.Default))
			//{
			//	string line;
			//	while (!((line = reader.ReadLine())==null))
			//	{
			//		string[] items = line.Split('|');
			//	}
			//}
			//Console.ReadKey();

			//read text to select name 
			//Dictionary<string, decimal> dic = new Dictionary<string, decimal>();
			//Console.WriteLine("正在读取中。。。");
			//using (FileStream stream = File.OpenRead("data2.txt"))
			//using (StreamReader reader = new StreamReader(stream, Encoding.Default))
			//{
			//	string line;
			//	while (!((line = reader.ReadLine()) == null))
			//	{
			//		if (string.IsNullOrWhiteSpace(line))
			//		{
			//			continue;
			//		}
			//		try
			//		{
			//			string[] items = line.Split(' ');
			//			string name = items[0];
			//			decimal socre = Convert.ToDecimal(items[1]);
			//			dic.Add(name, socre);
			//		}
			//		catch
			//		{
			//			continue;
			//		}
			//	}
			//	string in_name;
			//	while (true)
			//	{
			//		Console.WriteLine("请输入姓名");
			//		in_name = Console.ReadLine();
			//		if (string.IsNullOrWhiteSpace(in_name))
			//		{
			//			break;
			//		}
			//		try
			//		{
			//			Console.WriteLine(dic[in_name]);
			//		}
			//		catch (KeyNotFoundException e)
			//		{
			//			Console.WriteLine("查找的姓名\"" +
			//				in_name+
			//				"\"不在范围中");
			//		}
			//	}

			//	Console.ReadKey();

			//
			SqlCommand cmd = new SqlCommand();
			SqlDataReader reader = cmd.ExecuteReader();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.Fill
			}
		}
	}
}
