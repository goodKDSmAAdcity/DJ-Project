using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class InteractRange : MonoBehaviour
{
    public GameObject player;
    private float distance;
    public GameObject interactText;
    public bool canInteract;
    void Update()
    {
        distance = Vector2.Distance(gameObject.transform.position, player.transform.position);
        interactText.SetActive(distance < 8f);
        canInteract= distance<8f;




    }
}
