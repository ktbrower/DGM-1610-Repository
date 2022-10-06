using System;
					
public class Program
{
	public void Main(){
		Console.WriteLine("Let's do some Math!");
		Secondary(10,4);
		Secondary(20,7);
		Secondary(30,15);
		Compare(15,2);
		Compare(2,15);
		CheckPassword("Blackpink");
		CheckPassword("Pinkblack");
	}
	public void Secondary (int value, int value2) {
		var number = value + value2;
		Console.WriteLine(number);
	}
	public void Compare (int value, int value2)	{
		if (value > value2) 
		{
			Console.WriteLine("True");
		}
	else{
		Console.WriteLine("False");
	}
	}
	public void CheckPassword (string password) {
	if (password == "Blackpink") {
		Console.WriteLine("Correct Password");
	} else {
		Console.WriteLine("Incorrect Password");
	}
	}	
}
