using System;
					
public class Program
{
	public void Main()
	{
		string[] colors = {"red","orange","yellow","green","blue","purple"};
		Console.WriteLine(colors.Length);
		Console.WriteLine(colors [2]);
		foreach (var color in colors) {
		Console.WriteLine("My favorite color is " + color + ".");	
		}
	}
}
