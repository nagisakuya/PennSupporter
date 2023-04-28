using System;
using System.Collections.Generic;
using System.IO;

namespace PennSupporter
{
	class Program
	{
		static void Main(string[] args)
		{
			string today = DateTime.Now.ToString("yyyyMMdd");
			List<string> projectNames = new List<string>();
			Console.WriteLine("名前を入力してね");
			string name = Console.ReadLine();
			if (name == "") name = "1-3-6 umehara_nagisa";
			Console.WriteLine("課題名を一行に一個ずつ入力して、終わったらエンターを押してね");
			while (true)
			{
				string temp = Console.ReadLine();
				if (temp == "") break;
				projectNames.Add(temp);
			}
			Console.WriteLine("日付を入力してね(今日の日付なら空欄のままで良いよ！)");
			string date = Console.ReadLine();
			if (date == "") date = DateTime.Now.ToString("yyyy/MM/dd");
			System.IO.Directory.CreateDirectory($"./{today}");
			foreach (string s in projectNames) {
				System.IO.Directory.CreateDirectory($"./{today}/{s}");
				var file = new StreamWriter(File.Create($"./{today}/{s}/{s}.pde"));
				file.WriteLine($"//{s}");
				file.WriteLine($"ここにプログラムの説明を書いてね！");
				file.WriteLine($"//{name}");
				file.WriteLine($"//{date}");
				file.WriteLine("\nvoid setup(){\n\t\n}");
				file.Close();
			}
		}
	}
}
