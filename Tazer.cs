using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tazer : Ability
{
   [SerializeField] DiceSlot diceSlot;
   private void Start()
   {
      
   }
   private void Update()
   {
      if(remainingUses <= 0)
      {
         diceSlot.gameObject.GetComponent<BoxCollider2D>().enabled = false;
         diceSlot.Dice = null;
      }
      else
      {
         diceSlot.gameObject.GetComponent<BoxCollider2D>().enabled = true;
      }
      if(diceSlot.Dice != null)
      {
         DoThing();
      }
   }
   public override void DoThing()
   {
      remainingUses--;
      if(diceSlot.Dice.GetElelmentName() == "electric")
      {
         Debug.Log("Deal 2 Damage");
      }
      else
      {
         Debug.Log("Deal 1 Damage");
      }

      
   }

   public override void Refresh()
   {
      remainingUses = maxUses;
   }
}
