using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monedas : MonoBehaviour
{
    public float turnSpeed = 90;

    private void OnTriggerEnter(Collider other)
    {
        if ( other.gameObject.GetComponent<Obstaculo>())
        {
            Destroy(gameObject);
            return;
        }
        if (other.gameObject.name != "Jugador")
        {
            return;
        }
        Destroy(gameObject);
    }



    void Start()
    {
        
    }

   
    void Update()
    {
        transform.Rotate(0,0, turnSpeed *  Time.deltaTime);
    }
}
