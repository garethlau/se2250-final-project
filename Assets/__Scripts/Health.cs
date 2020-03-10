﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 10;
    public int currhealth;
    private Animator animator;

    private void Start()
    {
        animator = GetComponentInChildren<Animator>();
        currhealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        currhealth-= amount;
        if (currhealth <= 0)
        {
            print("Died");
            animator.SetBool("isDead", true);
        }
        else
        {
            print("Took damage");
            animator.SetTrigger("hit");
        }
    }



}
