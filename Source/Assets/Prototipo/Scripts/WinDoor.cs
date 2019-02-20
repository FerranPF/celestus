﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinDoor : MonoBehaviour
{
    GameManager manager;

    private void Awake()
    {
        manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerStats player = other.gameObject.GetComponent<PlayerStats>();
            if (player.win)
            {
                manager.Win();
            }
        }
    }
}
