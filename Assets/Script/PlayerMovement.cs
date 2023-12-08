using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float Front = 2000f;
    public float Side = 50f;
    public Text scoreText;
    public float Score;
    void FixedUpdate()
    {
        Vector3 moveForward = new Vector3 (0,0,Front*Time.deltaTime);
        transform.Translate (moveForward);
       // rb.AddForce(0,0,Front*Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(Side * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-Side * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
       
        if (rb.position.y<-1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
   
    void Update()
    {
        Score++;
        scoreText.text = Score.ToString("0");
    }
}
