using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidBossBehaviour : EnemyBehaviour
{
    public bool damagedChannel = false, damagedCharge = false;
    public float _enemySpeed, channelDuration; 

    public override void Begin()
    {
        base.Begin();
        isBoss = true;
        enemyMaxHealth *= 2.5f;
        enemyHealth = enemyMaxHealth;
        _enemySpeed = enemySpeed;

    }

    public override void DamageRecieved(float damagePoint)
    {
        if (!damagedChannel)
        {
            enemyHealth -= damagePoint;
        }
    }

    public override void DamagedChannel()
    {
        damagedChannel = true;
        enemySpeed = 0;
        channelDuration = 0.6f;
    }

    public override void DamagedCharge()
    {
        damagedChannel = false;
        damagedCharge = true;
        enemySpeed = 3*_enemySpeed;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (damagedCharge = true && other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<EnemyBehaviour>().enemySpeed *= 5;
        }
    }
}
