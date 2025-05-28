using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody2D rBody;
    
    public float balaForce = 10;

    private Enemy enemyScript;

    void Awake()
    {
        rBody = GetComponent<Rigidbody2D>();
        
    }
    void Start()
    {
        rBody.AddForce(transform.right * balaForce, ForceMode2D.Impulse);
    }

    
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.layer == 6)
        {
            Enemy enemyScript = collider.gameObject.GetComponent<Enemy>();
            enemyScript.Die();
            Destroy(gameObject);
        }
    }

   
}
