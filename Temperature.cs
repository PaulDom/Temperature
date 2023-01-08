using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperature : MonoBehaviour
{
    public float temperatureCurrent = 36.6f;
    public float freezeSpeed = 0.05f;
    public Health health;

    private float temperatureNormal = 36.6f;
    private float temperatureCritical = 34f;
    private int playerDamage = 2;

    private float freezeTimer = 0;
    private float freezeDelay = 2;


    private void Update()
    {
        temperatureCurrent -= freezeSpeed * Time.deltaTime;
        
        if (temperatureCurrent <= temperatureCritical)
        {
            if (freezeTimer >= freezeDelay)
            {
                health.TakeDamage(playerDamage);
                freezeTimer = 0;
            }
            else
            {
                freezeTimer += Time.deltaTime;
            }
        }
    }
}
