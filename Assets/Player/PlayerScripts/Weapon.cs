using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
        public Transform firePoint;
        public GameObject bulletPrefab;
        public AudioSource source;
        public AudioClip clip;
    public GameObject misslePrefab;
        public float  bulletFireRate = 0.1f;
        private float bulletNextFireTime = 0f;
        public float missleFireRate = 1f;
        private float missleNextFireTime = 0f;
    public Missions m;
    private void Start()
    {
        StartCoroutine(Find());        
    }
    void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0) && Time.time >= bulletNextFireTime)
            {
                Shoot();
                bulletNextFireTime = Time.time + bulletFireRate;
            }
            if (Input.GetKeyDown(KeyCode.Q) && Time.time >= missleNextFireTime && m.isPurchased==true)
            {
            ShootMissles();
            missleNextFireTime = Time.time + missleFireRate;

            }
        }


        void Shoot()
        {
            if (source != null && clip != null)
            {
                source.Play();
            }
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
        void ShootMissles()
        {

        Instantiate(misslePrefab, firePoint.position, firePoint.rotation);
        }
    IEnumerator Find()
    {
        yield return new WaitForSeconds(1f);
        m = FindObjectOfType<Missions>();
    }

}
