using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatPlayer : Combatant
{
   [SerializeField] List<Dice> dice;
   [SerializeField] List<Ability> abilities;
   public override void beginTurn()
   {
      foreach(Dice die in this.dice)
      {
         die.roll();

      }
      foreach(Ability ability in abilities)
      {
         ability.Refresh();
      }
   }

   // Start is called before the first frame update
   void Start()
    {
      if(dice == null)
      {
         dice = new List<Dice>(FindObjectsOfType<Dice>());
      }
      if(abilities == null)
      {
         abilities = new List<Ability>(FindObjectsOfType<Ability>());
      }
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown("space"))
      {
         beginTurn();
      }
    }
}
