using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
   // Start is called before the first frame update
   [SerializeField] DiceFace[] faces = new DiceFace[6];
   [SerializeField] public GameObject element;
   [SerializeField] SpriteRenderer faceRenderer;
   [SerializeField] SpriteRenderer intensityRenderer;
   public int showingFace = 0;
   private Vector3 startingSpot;
   private Vector3 screenPoint;
   private Vector3 mOffset;
   private float mZCoord;
   private GameObject col = null;

   public DiceFace[] Faces { get => faces; set => faces = value; }

   void Start()
    {
      SpriteRenderer renderer = this.gameObject.GetComponent<SpriteRenderer>();
      renderer.color = element.GetComponent<Element>().color;
      faceRenderer.sprite = Faces[showingFace].sprite;
      startingSpot = gameObject.transform.position;
   }
    public void roll()
   {
      this.GetComponent<Animator>().SetTrigger("DiceShake");
      showingFace = Random.Range(0, 6);
      faceRenderer.sprite = Faces[showingFace].sprite;
      transform.position = startingSpot;
      //NumberSprites numberSprites = GetComponentInChildren<NumberSprites>();
      //intensityRenderer.GetComponent<SpriteRenderer>().sprite = numberSprites.getSprite(faces[showingFace].intensity);

   }
   public string GetElelmentName()
   {
      return element.GetComponent<Element>().elementName;
   }
   private void OnMouseDown()
   {
      mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
      mOffset = gameObject.transform.position - GetMouseWorldPos();
      
   }
   private Vector3 GetMouseWorldPos()
   {
      Vector3 mousePoint = Input.mousePosition;

      mousePoint.z = mZCoord;
      return Camera.main.ScreenToWorldPoint(mousePoint);
   }
   private void OnMouseDrag()
   {
      transform.position = GetMouseWorldPos() + mOffset;
   }
   private void OnTriggerEnter2D(Collider2D collision)
   {
      //Debug.Log("hello");
      if (collision.gameObject.GetComponent<DiceSlot>())
      {
         col = collision.gameObject;
      }
   }
   private void OnTriggerExit2D(Collider2D collision)
   {
      if (col == collision.gameObject)
      {
         col = null;
      }
   }
   private void OnMouseUp()
   {
      //Debug.Log(col);
      if(col != null)
      {
         col.GetComponent<DiceSlot>().Dice = this;
         transform.position = new Vector3(col.transform.position.x, col.transform.position.y, transform.position.z);

      }
   }
   // Update is called once per frame
   void Update()
    {
    }

}

