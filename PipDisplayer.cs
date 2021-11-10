using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipDisplayer : MonoBehaviour
{
   [SerializeField] int startingInt;
   [SerializeField] List<GameObject> currentPips;
   [SerializeField] GameObject onePip;
   [SerializeField] GameObject fivePip;
   [SerializeField] GameObject tenPip;
   // Start is called before the first frame update
   float y;
   public void Start()
   {
      changePips(startingInt);
   }
   public void changePips(int i)
   {
      GameObject temp;
      y = 0;
      foreach (GameObject obj in currentPips)
      {
         Destroy(obj);
      }
      while(i >= 10)
      {
         i = i - 10;
         temp = Instantiate(tenPip);
         temp.transform.parent = gameObject.transform;
         temp.transform.localPosition = new Vector3(0, y, transform.position.z);
         y += 0.075f;
         currentPips.Add(temp);

      }
      while(i >= 5)
      {
         i = i - 5;
         temp = Instantiate(fivePip);
         temp.transform.parent = gameObject.transform;
         temp.transform.localPosition = new Vector3(0, y, transform.position.z);
         y += 0.075f;
         currentPips.Add(temp);
      }
      while (i >= 1)
      {
         i = i - 1;
         temp = Instantiate(onePip);
         temp.transform.parent = gameObject.transform;
         temp.transform.localPosition = new Vector3(0, y, transform.position.z);
         y += 0.05f;
         currentPips.Add(temp);
      }

   }
    
}
