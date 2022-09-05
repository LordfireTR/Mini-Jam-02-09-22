using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    [SerializeField] Slider healthSlider;
    [SerializeField] EnemyBehaviour EnemyBehaviour;

    void Start()
    {
        healthSlider.maxValue = EnemyBehaviour.enemyHealth;
        healthSlider.value = healthSlider.maxValue;
    }

    // Update is called once per frame
    void OnTriggerEnter()
    {
        healthSlider.value = EnemyBehaviour.enemyHealth;
    }
}
