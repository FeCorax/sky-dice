using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
   [SerializeField] List<Combatant> combatants;
   [SerializeField] Combatant activeCombatant;
   [SerializeField] int turnItr = 0;
   public void EndTurn(Combatant ender)
   {
      if(ender == activeCombatant)
      {
         turnItr = (turnItr + 1) % combatants.Count;
      }
      activeCombatant = combatants[turnItr];
      activeCombatant.beginTurn();
   }
   
}
