using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tazer : Ability
{

   private void Start()
   {
      
   }
   private void Update()
   {
      if(remainingUses <= 0)
      {
         diceSlots[0].gameObject.GetComponent<BoxCollider2D>().enabled = false;
         diceSlots[0].Dice = null;
      }
      else
      {
         diceSlots[0].gameObject.GetComponent<BoxCollider2D>().enabled = true;
      }
      if(diceSlots[0].Dice != null)
      {
         DoThing();
      }
   }
   public override void DoThing()
   {
      remainingUses--;
      if(diceSlots[0].Dice.GetElelmentName() == "electric")
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
      Ability.Refresh(this);
   }
}
