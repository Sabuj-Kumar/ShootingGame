using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column_Distroy : MonoBehaviour
{
    public int health = 100;
    public GameObject deathEfect;
    public GameObject impactEffect;
    Human_Movement human;
    public void TakeDamage(int damage)
    {
        health -= damage;
        
        if (health <= 0)
        {
            Die();
        }
    }

    // Update is called once per frame
    void Die()
    {
        Instantiate(deathEfect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        //human.Human_Move(1);
    }
}
