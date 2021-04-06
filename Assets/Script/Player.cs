using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 100;
    public GameObject deathEfect;
    private int damage = 30;

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "EnemyBullet")
        {
            health -= damage;

            if (health <= 0)
            {
                Instantiate(deathEfect, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
}
