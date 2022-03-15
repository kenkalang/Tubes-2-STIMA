
using System;
using System.IO;

class main
{

	static void Main()
	{

		// Here we search the file present in C drive
		// and A directory. Using SearchOption

		string[] list = Directory.GetFiles("drive":\\"target folder"\\", "target file name.target file type",
										SearchOption.AllDirectories);

		// Display the file names
		// Present in the A directory
		foreach (string file in list)
		{
			Console.WriteLine(file)
		}
	}
}
