﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventController : MonoBehaviour
{

    public AudioClip[] attackAudio;

    public void AttackAudio()
    {
        float i = Random.Range(0.0f, (float)attackAudio.Length);
        PlayerController playerCont;
        playerCont = GetComponentInParent<PlayerController>();
        playerCont.PlayAudio(attackAudio[(int)i]);
    }

    public void AttackEvent()
    {
        PlayerController playerCont;
        playerCont = GetComponentInParent<PlayerController>();

        playerCont.AttackOverlap();
        Debug.Log("AttackEvent");
    }

    public void SpellEvent()
    {
        PlayerSpellSystem playerSpell;
        playerSpell = GetComponentInParent<PlayerSpellSystem>();

        playerSpell.InstSpell();
        Debug.Log("AttackEvent");
    }

    public void EnemyAttackEvent()
    {
        EnemyController enemyCont;
        enemyCont = GetComponentInParent<EnemyController>();

        enemyCont.AttackOverlap();
        Debug.Log("EnemyAttackEvent");
    }

}
