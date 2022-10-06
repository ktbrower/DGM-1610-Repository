using System;
					
public class Program
{
	public void Main()
	{
		weapon[] WeaponsObj = {new weapon(), new weapon(), new weapon()};	
		WeaponsObj[1].WeaponName = "Axe of Power";
		WeaponsObj[2].WeaponName = "Spear of Hope";
		WeaponsObj[1].PowerLevel = 1;
		
		for (var i=0;i<WeaponsObj.Length;i++) {
			WeaponsObj[i].PowerLevel = 10;
		}
		WeaponsObj[2].PowerLevel = 14;
		
		foreach (var item in WeaponsObj) {
			Console.WriteLine(item.WeaponName);
			Console.WriteLine(item.PowerLevel);
		}
	}
	public class weapon
	{
		public string WeaponName = "Sword of Truth";
		public int PowerLevel = 2;
	}	
}
