using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    [SerializeField] float bulletSpeed, bulletDuration;
    float bulletAge;
    float bulletDamage = 5.0f;

    void Start()
    {
        bulletAge = 0;
    }

    void Update()
    {
        MovementHandler();
        DurationHandler();
    }

    void MovementHandler()
    {
        transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);
    }
    
    void DurationHandler()
    {
        if (bulletAge >= bulletDuration)
        {
            Destroy(gameObject);
        }
        bulletAge += Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            other.GetComponent<EnemyBehaviour>().DamageRecieved(bulletDamage);
            Destroy(gameObject);
        }
    }
}
