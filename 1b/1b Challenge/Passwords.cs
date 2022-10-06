using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("Type in password below");
		CheckPassword ("kittens");
		CheckPassword ("password");
		CheckPassword ("Midnight");
		CheckPassword ("Midnights");
	
	}
	public void CheckPassword(string password)
	{
	if (password == "Midnights")
	{
		Console.WriteLine("Correct, Welcome in.");
	}
			else if (password == "password")
			{ 
				Console.WriteLine("That's really stupid, also incorrect");
			}
			else 
			{
				Console.WriteLine("Incorrect Password, try again");
			}}}
	
