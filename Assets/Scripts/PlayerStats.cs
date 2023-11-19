using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class PlayerStats : MonoBehaviour
{
    public static PlayerStats playerStats;
    
    [SerializeField] private GameObject player;
    [SerializeField] private float health;
    [SerializeField] private float maxHealth;
    [SerializeField] private Text healthText;
    [SerializeField] private Slider healthSlider;


    private void Awake()
    {
        if (playerStats != null)
        {
            Destroy(playerStats);
        }
        else
        {
            playerStats = this;
        }
        DontDestroyOnLoad(this);
    }

    void Start()
    {
        health = maxHealth;
        healthSlider.value = 1;
    }

    public void DealDamage(float damage)
    {
        health -= damage;
        CheckDeath();
        healthSlider.value = CalculateHealthPercentege();
    }


    public void healChar(float heal)
    {
        health += heal; 
        CheckOverheal();
        
        healthSlider.value = CalculateHealthPercentege();
    }
    private float CalculateHealthPercentege()
    {
        return health / maxHealth;
    }

    private void CheckOverheal()
    {
        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }

    private void CheckDeath()
    {
        if (health <= 0)
        {
            Destroy(player);
        }
    }
}
