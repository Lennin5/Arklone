using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour

{
    Rigidbody2D rb;
    float speed = 100f; // Velocidad con la que se moverá la pelota

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Obtenemos el componente Rigidbody2D de la pelota
    }
    void Update()
    {
        // Llamamos a la función StartGameOnPressSpace en cada frame para manejar el inicio del juego
       StartGameOnPressSpace();
    }

    void StartGameOnPressSpace()
    {
        // Si se presiona la tecla espacio
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(3f, 5f) * speed); // Agregamos una fuerza a la pelota en diagonal
            transform.parent = null; // Despegamos la pelota de la paleta (componente padre)
        }
    }

}
