using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll2D : MonoBehaviour
{
    [Range(0f, 1f)]
    public float scrollFactor = 0.5f; // Controls the scrolling sensitivity to player movement
    private Vector2 offset; // Tracks the current texture offset
    private Material mat;
    private Transform playerTransform;
    private Vector2 lastPlayerPosition;

    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;

        // Find the player by tag (you can replace this with a direct reference to the player if preferred)
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (player != null)
        {
            playerTransform = player.transform;
            lastPlayerPosition = playerTransform.position;
        }
        else
        {
            Debug.LogError("Player not found! Please assign the Player tag to your player object.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform != null)
        {
            // Calculate player movement direction
            Vector2 playerMovement = (Vector2)playerTransform.position - lastPlayerPosition;

            // Update offset based on player movement
            offset += playerMovement * scrollFactor;

            // Apply the offset to the material
            mat.SetTextureOffset("_MainTex", offset);

            // Update the last player position
            lastPlayerPosition = playerTransform.position;
        }
    }
}
