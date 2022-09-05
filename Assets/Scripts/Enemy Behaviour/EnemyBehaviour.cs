using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float enemyHealth, enemyMaxHealth, enemySpeed;
    public bool isBoss;

    public virtual void Begin()
    {
        isBoss = false;
        enemyMaxHealth = 20.0f;
        enemyHealth = enemyMaxHealth;
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

    public virtual void DamagedCharge()
    {
        //For Midboss
    }

    public virtual void DamagedChannel()
    {
        //For Midboss
    }
}