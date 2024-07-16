using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float globalSpeed = 10f; // Velocidad del movimiento de la paleta
    float limitX = 4.8f;  // Límite horizontal del movimiento de la paleta

    void Update()
    {
        // Llamamos a la función Move en cada frame para manejar el movimiento de la paleta
        Move();
    }

    void Move()
    {
        // Variables para determinar si la tecla izquierda o derecha está siendo presionada
        bool moveLeft = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A);
        bool moveRight = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);

        // Inicializamos el movimiento en 0
        float movement = 0f;

        // Actualizamos el movimiento dependiendo de la tecla presionada
        if (moveLeft)
        {
            movement = -globalSpeed * Time.deltaTime;
        }
        else if (moveRight)
        {
            movement = globalSpeed * Time.deltaTime;
        }

        // Calculamos la nueva posición basada en la posición actual y el movimiento calculado
        float newPosition = transform.position.x + movement;

        // Verificamos que la nueva posición no exceda los límites establecidos
        if (newPosition > -limitX && newPosition < limitX)
        {
            // Si está dentro de los límites, actualizamos la posición de la paleta
            transform.position = new Vector3(newPosition, transform.position.y, transform.position.z);
        }
    }

}
