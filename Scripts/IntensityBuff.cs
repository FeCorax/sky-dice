using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntensityBuff : Ability
{
   [SerializeField] DiceSlot slot;
   public override void DoThing()
   {
      foreach(DiceFace face in slot.Dice.Faces)
      {
         face.intensity++;
      }
      remainingUses--;
   }

   public override void Refresh()
   {
      Ability.Refresh(this);
   }

   // Start is called before the first frame update
   void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (remainingUses <= 0)
      {
         slot.gameObject.GetComponent<BoxCollider2D>().enabled = false;
         slot.Dice = null;
      }
      if (slot.Dice != null)
      {
         DoThing();
      }
   }
}
