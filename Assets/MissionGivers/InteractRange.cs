using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class InteractRange : MonoBehaviour
{
    public GameObject player;
    private float distance;
    public TextMeshProUGUI interactText;
    void Update()
    {
        distance = Vector2.Distance(gameObject.transform.position, player.transform.position);
            interactText.enabled = distance<8f;



    }
}
