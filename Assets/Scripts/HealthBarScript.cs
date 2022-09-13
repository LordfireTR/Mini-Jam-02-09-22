using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    [SerializeField] Image healthFill;
    [SerializeField] EnemyBehaviour EnemyBehaviour;
    float maxHealth, currentHealth;

    void Start()
    {
        maxHealth = EnemyBehaviour.enemyHealth;
        currentHealth = maxHealth;
        healthFill.fillAmount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        currentHealth = EnemyBehaviour.enemyHealth;
        healthFill.fillAmount = currentHealth/maxHealth;
    }
}
