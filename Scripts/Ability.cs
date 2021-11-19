using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ability : MonoBehaviour
{

   [SerializeField] public int slotCount;
   [SerializeField] public int maxUses;
   [SerializeField] public int remainingUses;
   [SerializeField] public List<DiceSlot> diceSlots;

   public abstract void DoThing();

   public static void Refresh(Ability ability)
   {
      ability.remainingUses = ability.maxUses;

   }
   public abstract void Refresh();

}
