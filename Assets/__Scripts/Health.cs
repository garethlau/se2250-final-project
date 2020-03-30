﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public bool hasHealthBar = false;
    public int maxHealth = 10;
    public float currhealth;
    public SimpleHealthBar healthBar;
    public Animator animator;
    private int _level;


    public bool isDead = false;

    private void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    virtual public void TakeDamage(int amount)
    {
        currhealth-= amount;
        if (hasHealthBar)
        {
            healthBar.UpdateBar(currhealth, maxHealth);
        }
        if (currhealth <= 0)
        {
            print("Died");
            isDead = true;
            animator.SetBool("isDead", true);
        }
        else
        {
            print("Took damage");
            animator.SetTrigger("hit");
        }
    }
}
