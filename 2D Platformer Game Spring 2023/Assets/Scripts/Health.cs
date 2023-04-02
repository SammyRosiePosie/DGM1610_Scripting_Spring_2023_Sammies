using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1; //Reset Time back to real time
        currentHealth = maxHealth; //Set current health to max health
    }

    public void TakeDamage(int dmgAmount)
    {
        currentHealth -= dmgAmount;
        Debug.Log("Player Health = " + currentHealth);

        if(currentHealth <=0)
        {
            Debug.Log("You are DEAD! Game Over!"); //Game Over message in the console
            Time.timeScale = 0; //Freeze the game
        }
    }

    public void AddHealth(int healAmount)
    {
        currentHealth += healAmount;

        if(currentHealth >= maxHealth) //Puts a cap on current health amoutn
        {
            currentHealth = maxHealth;
        }
    }
    
}
