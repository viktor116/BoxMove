using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    public float forwardForce = 1000f;

    public float sideForce = 500f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        playerRigidbody.AddForce(0,0,forwardForce*Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
        {
            playerRigidbody.AddForce(-sideForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerRigidbody.AddForce(sideForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if (playerRigidbody.position.y < -1)
        {
            FindObjectOfType<GameManager>().endGame();
        }
    }
}
