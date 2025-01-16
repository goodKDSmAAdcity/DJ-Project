using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public AudioSource source;
    public AudioClip clip;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if(source !=null && clip !=null)
        {
            source.Play();
        }
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
