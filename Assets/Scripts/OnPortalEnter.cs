﻿using UnityEngine;
using System.Collections;

public class OnPortalEnter : MonoBehaviour
{
    void Start() {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.collider.CompareTag("Player")) {
            GameManager.Instance.GetComponent<GameManager>().GoToNextLevel();
        }
    }
}
