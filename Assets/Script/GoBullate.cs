using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBullate : MonoBehaviour
{
    public float speed = 40;
    public int damage = 30;
    public Rigidbody2D rb;
    public GameObject impactEffect;
    void Start()
    {
        rb.velocity = transform.right * speed;
    }
    void OnTriggerEnter2D(Collider2D hitinfo)
    {
        Enemy enemy = hitinfo.GetComponent<Enemy>();
        Column_Distroy column = hitinfo.GetComponent<Column_Distroy>();

        if(enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        
        if(column != null)
        {
            column.TakeDamage(damage);
        }
        Destroy(gameObject);

        Instantiate(impactEffect, transform.position, transform.rotation);
    }
}
