
using UnityEngine;

public class SeguirCamara : MonoBehaviour
{
    public Transform Jugador;
    Vector3 offset;
    
    void Start()
    {
        offset = transform.position - Jugador.position; 
    }

    
    void Update()
    {
        Vector3 targetPos = Jugador.position + offset;
        targetPos.x = 0;
        transform.position = targetPos;
    }
}
