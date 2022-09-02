using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    [SerializeField] float bulletSpeed, bulletDuration;
    float bulletAge;

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
}
