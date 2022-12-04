using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteBehaviour : MonoBehaviour
{
   private SpriteRenderer _rendererObj;

   private void Start()
   {
      _rendererObj = GetComponent<SpriteRenderer>();
   }

   public void ChangeRendererColor(ColorID obj)
   {
      _rendererObj.color = obj.value;
   }
}
