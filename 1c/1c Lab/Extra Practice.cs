using System;
					
public class Program
{
	public static void Main()
	{
string[] words = {"blah", "bleh", "undertale", "poop"};
		Console.WriteLine (words [2]);
		words [2] = "blech";
		Console.WriteLine (words.Length);
		for (int i=0; i < words.Length; i++)
		{
			Console.WriteLine (words[i]); 
		}
		foreach (string i in words)
		{
			Console.WriteLine (i);
		}
	}
}
