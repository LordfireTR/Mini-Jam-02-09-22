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
    [SerializeField] GameObject gammaRay;

    void Update()
    {
        AimHandler();
        GunHandler();
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
            Instantiate(bullet, gunPoint.position, gunPoint.rotation);
            gunCooldown = _gunCooldown;
        }
        else if(gunCooldown > 0)
        {
            gunCooldown -= Time.deltaTime;
        }
    }
}
