using System;
					
public class Program
{

	public void Main()
	{
		Secondary (24);
		int x = 14;
		int y = 18;
		if (x > y) 
{
  Console.WriteLine("x is greater than y");
}
		else Console.WriteLine("y is greater than x");
		
	int time = 14;
if (time < 18) 
{
  Console.WriteLine("Good day.");
} 
else 
{
  Console.WriteLine("Good evening.");
}
// Outputs "Good evening."
	}

	public void Secondary (int time) 
	{
if (time < 10) 
{
  Console.WriteLine("Good morning.");
} 
else if (time < 20) 
{
  Console.WriteLine("Good day.");
} 
else 
{
  Console.WriteLine("Good evening.");
}
// Outputs "Good evening."}
	}}
