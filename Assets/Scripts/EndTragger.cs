using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EndTragger : MonoBehaviour
{
    public GameManager gameManager;
    
    void OnTriggerEnter()
    {
        gameManager.completeLevel();
        // throw new NotImplementedException();
    }
}
