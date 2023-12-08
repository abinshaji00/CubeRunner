using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public float forward = 200f;
    void FixedUpdate()
    {
        if(Input.GetKey("w"))
        {
           Vector3 move = new Vector3 (0, 0, forward*Time.deltaTime);
            transform.Translate (move);
            Debug.Log("running Forword");
        }
        
        
    }
}
