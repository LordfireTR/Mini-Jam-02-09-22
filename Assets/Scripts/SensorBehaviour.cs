using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SensorBehaviour : MonoBehaviour
{
    [SerializeField] Image healthImage;
    float maxHealth = 100.0f, _currentHealth;
    public float currentHealth;

    void Start()
    {
        _currentHealth = maxHealth;
        currentHealth = _currentHealth;
        healthImage.fillAmount = 1;
    }

    void Update()
    {
        healthImage.fillAmount = _currentHealth/maxHealth;
        currentHealth = _currentHealth;
        //Debug.Log(currentHealth);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            _currentHealth -= 10.0f;
            Destroy(other.gameObject);
        }
    }
}
