using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float enemyHealth, enemySpeed;

    public virtual void Begin()
    {
        enemyHealth = 20.0f;
        enemySpeed = 5.0f;
    }

    public virtual void DeathHandler()
    {
        Destroy(gameObject);
    }

    public virtual void DamageRecieved(float damagePoint)
    {
        enemyHealth -= damagePoint;
    }

    public virtual void Movement()
    {
        transform.Translate(Vector3.forward * enemySpeed * Time.deltaTime);
    }
}
