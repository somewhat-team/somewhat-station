using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControls : MonoBehaviour
{
    public float speed = 0.3f;
    public GameObject player;
    void Start()
    {
        Rigidbody2D rbody = player.GetComponent<Rigidbody2D>();
    }
        
    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");

        
    }
}