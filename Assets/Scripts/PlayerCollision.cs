using System;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerScript playerScript;
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Obstacle"))
        {
            playerScript.enabled = false;
            FindObjectOfType<GameManager>().endGame();
        }
    }
}
