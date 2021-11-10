using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ability : MonoBehaviour
{

   [SerializeField] public int slotCount;
   [SerializeField] public int maxUses;
   [SerializeField] public int remainingUses;

   public abstract void DoThing();

   public abstract void Refresh();
}
