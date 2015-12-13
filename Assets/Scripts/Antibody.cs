﻿using UnityEngine;
using System.Collections;

public class Antibody : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") {
            ++other.gameObject.GetComponent<PlayerStatus>().antibody;
            Destroy(gameObject);
        }
    }
}
