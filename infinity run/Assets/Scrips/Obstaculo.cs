using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    PlayerMovement playerMovement;


   private void Start()
    {
        playerMovement = GameObject.FindObjectOfType<PlayerMovement>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Jugador")
        {
            playerMovement.Muerte();
        }
    }

    private void Update()
    {
        
    }
}
