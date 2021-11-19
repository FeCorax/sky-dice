using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceSlot : MonoBehaviour
{
   [SerializeField] private Dice dice;

   public Dice Dice { get => dice; set => dice = value; }
}
