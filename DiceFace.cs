using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DiceFace : MonoBehaviour
{
   [SerializeField] public Sprite sprite;
   [SerializeField] public int intensity = 1;
   [SerializeField] public List<string> tags;
   public abstract void DefaultEffect();         


    // Start is called before the first frame update
   
   
}
