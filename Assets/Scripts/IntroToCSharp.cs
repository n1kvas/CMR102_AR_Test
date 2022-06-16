using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroToCSharp : MonoBehaviour
{
   [SerializeField] private int targetNumber = 0;
    private float tagretDistance = 2.5f;
    private bool isTargetActive = false;
   private string targetName = "Bob";
   private Vector3 cubePosition = new Vector3(0.5f, 0, 0);
   
   void Start()
   {

      tagretDistance = 5000f;
      
      Debug.Log(targetName);
      Debug.Log("Target Distance is: " + tagretDistance + "meters");
   }

   void ReturnTargetOrientation()
   {
      
   }
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
}


