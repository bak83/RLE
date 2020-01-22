using System;

namespace RLE
{
	class Program
	{
		static void Main(string[] args)
		{
			string napis = "aaabddddddsssssswesweeeee", rle = "";
			//int licznik = 1;

			for (int i = 0; i < napis.Length; i++)
			{
				int licznik = 1;

				while (i + 1 < napis.Length && napis[i] == napis[i + 1])
				{
					licznik++;
					i++;
				}
				rle += napis[i];
				rle += licznik;

			}
			Console.WriteLine(rle);


		}

	}
}
