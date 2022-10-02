using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Weapon : MonoBehaviour
{
    public Transform shootingpoint;
    public GameObject bulleyprefab;

    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            Instantiate(bulleyprefab, shootingpoint.position,transform.rotation);

        }
    }

}
