using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float enemyHealth, enemySpeed;
    [SerializeField] Transform player;

    public virtual void DeathHandler()
    {
        if(enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public virtual void DamageRecieved(float damagePoint)
    {
        enemyHealth -= damagePoint;
    }

    public virtual void Movement()
    {
        transform.LookAt(player);
        transform.Translate(Vector3.forward * enemySpeed * Time.deltaTime);
    }
}
