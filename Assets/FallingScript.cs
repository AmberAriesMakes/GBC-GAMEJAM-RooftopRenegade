using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingScript : MonoBehaviour
{

    Rigidbody2D fallRb;
    public float gravitymultiplier;
    // Start is called before the first frame update
    private void Awake()
    {
        fallRb = GetComponent<Rigidbody2D> ();
    }
    // Update is called once per frame
    void Update()
    {
        //Fiddling with the gravity and velocity to ensure better landing after jumping.
        if (fallRb.velocity.y < 0)
        {
           fallRb.velocity += Vector2.up * Physics2D.gravity * (gravitymultiplier - 1) * Time.deltaTime;
        }
    }
}
