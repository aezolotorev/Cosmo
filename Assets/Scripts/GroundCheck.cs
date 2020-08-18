using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public Collider2D groundCheck;
    public PlayerProperties playerProperties;

    void Awake()
    {
        groundCheck = GetComponent<Collider2D>();

    }

 

    public void OnTriggerEnter2D(Collider2D other)
    {
        playerProperties.isGround = true;
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        playerProperties.isGround = false;
    }
    public void OnTriggerStay2D(Collider2D other)
    {
        playerProperties.isGround = true;
    }
   
   
}
