using System;
					
public class Program
{
	public void Main()
	{
	string [] playerTypes = {"Human", "Human", "Human"};
	
	foreach (var playerType in playerTypes) {
		Console.WriteLine(playerType);
	}
		for (var i=0;i<playerTypes.Length;i++)
			playerTypes [i] = "Vampire";
			
	foreach (var playerType in playerTypes) {
		Console.WriteLine(playerType);
	}
						 
	}
}
