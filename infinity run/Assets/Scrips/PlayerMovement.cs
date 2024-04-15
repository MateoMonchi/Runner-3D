using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    bool alive = true;


    public float rapidez = 5f;
    public float horizontalMultiplier = 2;
    
    public Rigidbody RB;
    float horizontalInput;
    public Tiempo tiempo;

    private void FixedUpdate()
    {
        if (!alive) return;
        Vector3 forwardMove = transform.forward * rapidez * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * rapidez * Time.fixedDeltaTime * horizontalMultiplier;
        RB.MovePosition(RB.position + forwardMove + horizontalMove);
    }
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        if (transform.position.y < -5)
        {
            Muerte();
        }
        
    }

    public void Muerte()
    {
        alive = false;
        Invoke("Reiniciar", 1);
        tiempo.timeRunning = false;
    }
    void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }






}


