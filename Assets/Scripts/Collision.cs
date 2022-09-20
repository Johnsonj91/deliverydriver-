using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    //stick with 2d because the project is 2d
    void OnCollisionEnter2D(Collision2D other) 
   {
        Debug.Log("TOUCH!!!");
   }
}
