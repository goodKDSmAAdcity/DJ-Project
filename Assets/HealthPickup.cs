using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public float speed = 5f;
    public int healthAmount = 25;
    public Player player;
    public HP hb;
    public AudioSource audioSource;
    void Start()
    {
        StartCoroutine(Find());        
    }
    void Update()
    {
        // Move the object to the left (negative x direction)
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        // Check if the object has reached x = -10 or lower
        if (transform.position.x <= -10f)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("heal");
            player.currenthealth += healthAmount;
            if(player.currenthealth > player.maxhealth) {
            player.currenthealth = player.maxhealth;
            }
            hb.SetHealth(player.currenthealth);
            AudioSource.PlayClipAtPoint(audioSource.clip, transform.position);
            Destroy(gameObject);
        }
    }
    IEnumerator Find()
    {
        yield return new WaitForSeconds(1f);
        player = FindAnyObjectByType<Player>();
        hb= FindAnyObjectByType<HP>();  
    }
}
