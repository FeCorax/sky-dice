using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Element : MonoBehaviour
{
   [SerializeField] Color _color = Color.white;
   [SerializeField] public string elementName = "";
   public Color color
   {
      get { return _color; }
   }


}
