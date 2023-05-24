using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Collectible : MonoBehaviour
{
    public GameObject dropOffZone;
    public GameObject collectible1;
    public GameObject collectible2;
    public TeleportationArea teleportationArea;

   void Start()
   {
        teleportationArea.enabled = false;
        dropOffZone = GameObject.Find("Drop-Off Zone");
        collectible1 = GameObject.Find("Collectible 1");
        collectible2 = GameObject.Find("Collectible 2");
   }

   void Update()
   {
        Bounds bounds = dropOffZone.GetComponent<Renderer>().bounds;
        Bounds bounds1 = collectible1.GetComponent<Renderer>().bounds;
        Bounds bounds2 = collectible2.GetComponent<Renderer>().bounds;

        bool isWithinBounds = bounds.Intersects(bounds1);  
        bool isWithinBounds2 = bounds.Intersects(bounds2);  

        if (isWithinBounds)
        {
            teleportationArea.enabled = true;
            if (isWithinBounds2){
                Debug.Log("Both collectibles are within bounds");
                UnityEditor.EditorApplication.isPlaying = false;
            }
        }
   } 
}
