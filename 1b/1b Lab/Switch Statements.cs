using System;
					
public class Program
{
	public GameStates gameStates;
	public void Main()
	{
		gameStates = new GameStates();
		gameStates.CheckState();
	}
}
public class GameStates 
{
	public enum States {
		Starting,
		Playing,
		Ending
	}
	public States currentState = States.Starting;
		public void CheckState() {
		switch (currentState) {
			case States.Starting:
				Console.WriteLine("Starting");
				break;
		}}
}
