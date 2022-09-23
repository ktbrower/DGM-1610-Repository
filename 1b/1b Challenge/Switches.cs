using System;
					
public class Program
{
public GameAnswers gameAnswers;
	
	public void Main()
	{
		gameAnswers = new GameAnswers();
		gameAnswers.currentAnswer = GameAnswers.Answers.Okay;
		gameAnswers.CheckAnswer();
	}
}
	
		public class GameAnswers {
	
	public enum Answers {
		Good,
		Bad,
		Okay
	}
	
	public Answers currentAnswer = Answers.Good;
	
	public void CheckAnswer () {
		switch (currentAnswer) {
			case Answers.Good:
				Console.WriteLine("Good");
				break;
			case Answers.Bad:
				Console.WriteLine("Bad");
				break;
			case Answers.Okay:
				Console.WriteLine("Okay");
				break;
		}
	}
		
	}
	
