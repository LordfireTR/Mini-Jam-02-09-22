using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyUnitHandler : MonoBehaviour
{
    void Update()
    {
        if(transform.childCount == 0)
        {
            Destroy(gameObject);
        }
    }
}
