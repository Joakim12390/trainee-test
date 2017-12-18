using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int makingAnagrams(string s1, string s2){
        for(int i = 0; i < s1.Length; i++)
			{
				for (int j = 0; j < s2.Length; j++)
				{
					if(s1[i].Equals(s2[j]))
					{
						s1 = s1.Remove(i,1);
						i -= 1;
						s2 = s2.Remove(j,1);
						break;
					}
				}
			}
		return s1.Length + s2.Length;
    }

    static void Main(String[] args) {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();
        int result = makingAnagrams(s1, s2);
        Console.WriteLine(result);
    }
}
