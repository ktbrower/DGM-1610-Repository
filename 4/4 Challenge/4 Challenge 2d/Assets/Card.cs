using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card",menuName = "Card")]
public class Card : ScriptableObject

{
   public new string name;
   public string description;
   public int health;
   
}
