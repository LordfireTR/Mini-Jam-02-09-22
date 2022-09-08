using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Handle Aim
    [SerializeField] Camera mainCamera;
    Vector3 targetPosition;
    [SerializeField] Transform turret;

    //Handle Gun
    [SerializeField] Transform gunPoint;
    [SerializeField] GameObject bullet;
    [SerializeField] float _gunCooldown;
    float gunCooldown;

    //Handle Special Attacks
    [SerializeField] GameObject deathRay;
    [SerializeField] float _rayCooldown, _rayDuration;
    float rayCooldown, rayDuration;

    void Update()
    {
        AimHandler();
        GunHandler();
        RayHandler();
    }

    void AimHandler()
    {
        targetPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        targetPosition.y = transform.position.y;
        turret.LookAt(targetPosition);
    }

    void GunHandler()
    {
        if (Input.GetKey(KeyCode.Mouse0) && gunCooldown <= 0)
        {
            Instantiate(bullet, gunPoint.position, gunPoint.rotation, gameObject.transform);
            gunCooldown = _gunCooldown;
        }
        else if(gunCooldown > 0)
        {
            gunCooldown -= Time.deltaTime;
        }
    }

    void RayHandler()
    {
        
        if(rayCooldown <= 0)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1))
            {
                deathRay.SetActive(true);
                rayCooldown = _rayCooldown;
                rayDuration = _rayDuration;
            }
        }
        else
        {
            if(rayDuration <= 0)
            {
                deathRay.SetActive(false);
                rayCooldown -= Time.deltaTime;
            }
            else
            {
                rayDuration -= Time.deltaTime;
            }
        }
    }
}
