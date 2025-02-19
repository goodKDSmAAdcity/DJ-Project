using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPos;
    private float timer;
    private GameObject player;
    public AudioSource source;
    public AudioClip clip;
    public float interval = 2;
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        timer += Time.deltaTime;
        if(timer > interval)
        {
            timer = 0;
            Shoot();
        }
        Vector3 direction = player.transform.position - transform.position;
        float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot);
    }

    void Shoot()
    {
        if(source !=null && clip !=null)
        {
            source.Play();
        }
        Instantiate(bullet, bulletPos.position,bulletPos.rotation);
    }
}
