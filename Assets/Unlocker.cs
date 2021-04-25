using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlocker : MonoBehaviour
{
    public GameObject Player;
    public Rigidbody2D rigiddoor;
    public MovementScript movescript;
    bool islocked = true;
    //This I'm most proud of.. This script locks doors by their rigidbody rotations off the start
    private void Awake()
    {
        rigiddoor.freezeRotation = true;
        movescript = Player.GetComponent<MovementScript>();   //And call for the player script for the amount of keys
    }
    private void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)

       
    {
       if (collision.gameObject.CompareTag("Player") && movescript.keycount > 0 && islocked == true)  //If the player does have keys on approaching the door.
        {
           rigiddoor.freezeRotation = false;  //It loosens up to be pushed open. 
            movescript.keycount--;
            islocked = false; //And wont ask for any more keys.
        }
      
    }
}
