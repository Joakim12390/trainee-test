using System;
using System.Collections.Generic;

namespace DeleteThis
{
	class Solution
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			Entry[] entries = new Entry[n];
			// 0 <= x < 100
			int[] countingArray = new int[100];
			string[] strings = new string[n];
			for (int i = 0; i < n; i++)
			{
				strings[i] = Console.ReadLine();
			}
			string[] final = new string[strings.Length];
			for (int i = 0; i < strings.Length; i++)
			{
				entries[i] = new Entry(strings[i].Split(' '));
				// replace first half with "-"
				if (i < strings.Length / 2)
				{
					entries[i].text = "-";
				}
				countingArray[entries[i].number]++;
			}
			// add numbers in array to represent index
			for (int j = 1; j < countingArray.Length; j++)
			{
				countingArray[j] += countingArray[j - 1];
			}
			Entry entry;
			int number;
			// loop from back since index decreases (countingArray)
			for (int k = entries.Length; k > 0; k--)
			{
				entry = entries[k -1];
				number = entry.number;
				final[countingArray[number] - 1] = entry.text;
				countingArray[number]--;
			}
			Console.WriteLine(String.Join(" ", final));
			Console.ReadLine();
		}
		private class Entry
		{
			public int number;
			public string text;

			public Entry(string[] input)
			{
				this.number = int.Parse(input[0]);
				this.text = input[1];
			}
		}
	}
}
