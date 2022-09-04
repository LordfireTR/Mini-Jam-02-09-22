using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SensorBehaviour : MonoBehaviour
{
    [SerializeField] Slider healthSlider;
    float maxHealth = 100.0f, currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
        healthSlider.maxValue = maxHealth;
        healthSlider.value = currentHealth;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            currentHealth -= 10.0f;
            healthSlider.value = currentHealth;
        }
    }
}
