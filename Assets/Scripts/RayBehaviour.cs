using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayBehaviour : MonoBehaviour
{
    float rayDamage = 30.0f;
    
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            other.GetComponent<EnemyBehaviour>().DamageRecieved(rayDamage);
        }
    }
}
