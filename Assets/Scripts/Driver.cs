using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        //transform.Rotate(0,0, 45);
    }

    // Update is called once per frame
    void Update()
    {
        // This is the old system of doing Input Axis in Unity 
        // The delta time is allows for frame rate independence
        //Steer Amount is from -1 to +1 on the X axis
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;

        //move Amount is from -1 to +1 on the Y axis
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        
        transform.Rotate(0,0, -steerAmount);
        transform.Translate(0, moveAmount,0);
    }
}
