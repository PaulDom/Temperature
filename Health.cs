using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth = 10;

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth > 0)
        {
            print("Здоровье игрока: " + currentHealth);
        }
    }   
}
