using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

   
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        //this is to allow the player to take damamge when the space bar is pressed, so you can programm the logic to receive damage when the enemy attacks it. 
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            TakeDamage(20);
        }
    }
    void TakeDamage (int damage) 
    {
        currentHealth -= damage;

        healthBar.setHealth(currentHealth);
    }
}
