using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    private void OnCollisionEnter(Collision collision)
    public Hpbar2 healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        // coup torse
        
        {
            if (collision.collider.hitboxchest.CompareTag("Enemy"))
            {
                TakeDamage(5);
            }
        }
}
