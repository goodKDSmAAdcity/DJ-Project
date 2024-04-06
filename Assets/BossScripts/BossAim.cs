using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAim : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPos1;
    public Transform bulletPos2;    
    private float timer;
    private float switchshoottimer;
    private GameObject player;
    public GameObject laser;
    public Transform laserpoint;
    public GameObject startLaser;
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        timer += Time.deltaTime;
        switchshoottimer+= Time.deltaTime;
        if (switchshoottimer < 10f)
        {
            if (timer > 0.5f)
            {
                timer = 0;
                Shoot1();
            }
        }
        else
        {
            if(timer > 2)
            {
                timer = 0;
                Shoot2();
            }
            if(switchshoottimer > 20f)
            {
                switchshoottimer = 0;
            }
            
        }
    }

    void Shoot1()
    {
        Instantiate(bullet, bulletPos1.position,bulletPos1.rotation);
        Instantiate(bullet, bulletPos2.position, bulletPos2.rotation);
    }

    void Shoot2()
    {
        GameObject start = Instantiate(startLaser, laserpoint.position, laserpoint.rotation);
        Destroy(start, start.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);
        Instantiate(laser, laserpoint.position, laserpoint.rotation);
    }
}
