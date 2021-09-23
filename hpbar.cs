using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hpbar : MonoBehaviour
{

    public Slider slider;
    public Gradient gradient;
    public Image fill;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;

        fill.color = gradient.Evaluate(1f);
    }

    public void SetHealth(int health)
    {
        slider.value = health;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.hitboxchest.CompareTag("Enemy"))
        {
            TakeDamage(5);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.hitboxhead.CompareTag("Enemy"))
        {
            TakeDamage(10);
        }
    }
}
