using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuntingTarget : MonoBehaviour
{
    public float health = 3f;

    public void DamageReceived(float damageAmount)
    {
        health -= damageAmount;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
