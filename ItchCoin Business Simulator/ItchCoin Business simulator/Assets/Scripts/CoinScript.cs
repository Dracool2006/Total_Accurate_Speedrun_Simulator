﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{

    // Use this for initialization
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            ScoreTextScript.coinAmount += 10;
            Destroy(gameObject);
        }
    }
}
