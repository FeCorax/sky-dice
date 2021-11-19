using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberSprites : MonoBehaviour
{
   [SerializeField] public Sprite[] numbs = new Sprite[10];
    public Sprite getSprite(int i)
   {
      return numbs[i];
   }
}
