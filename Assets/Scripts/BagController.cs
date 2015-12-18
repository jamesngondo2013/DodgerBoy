using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BagController : MonoBehaviour {
   
    
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "DodgerMan")
        {
            Destroy(gameObject);
           
        }
    }
     
}
