using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float globalSpeed = 10f; // Velocidad del movimiento de la paleta
    float limitX = 4.8f;  // L�mite horizontal del movimiento de la paleta
    BallMovement ballMovement; // Variable para almacenar el script BallMovement

    void Start()
    {
        ballMovement = FindObjectOfType<BallMovement>(); // Buscamos el script BallMovement en la escena (lo hace de manera autom�tica, no es necesaria ninguna referencia)
    }

    void Update()
    {
        // Llamamos a la funci�n Move en cada frame para manejar el movimiento de la paleta
        Move();
    }

    void Move()
    {

        // Variables para determinar si la tecla izquierda o derecha est� siendo presionada
        bool moveLeft = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A);
        bool moveRight = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);
        // Variables para determinar si se ha tocado el lado izquierdo o derecho de la pantalla
        bool touchLeft = Input.touchCount > 0 && Input.GetTouch(0).position.x < Screen.width / 2;
        bool touchRight = Input.touchCount > 0 && Input.GetTouch(0).position.x > Screen.width / 2;

        // Inicializamos el movimiento en 0
        float movement = 0f;

        // Actualizamos el movimiento dependiendo de la tecla presionada o el lado de la pantalla tocado
        if (ballMovement.isBallLaunched == true)
        {
            if (moveLeft || touchLeft)
            {
                movement = -globalSpeed * Time.deltaTime;
            }
            else if (moveRight || touchRight)
            {
                movement = globalSpeed * Time.deltaTime;
            }
        }


        // Calculamos la nueva posici�n basada en la posici�n actual y el movimiento calculado
        float newPosition = transform.position.x + movement;

        // Verificamos que la nueva posici�n no exceda los l�mites establecidos
        if (newPosition > -limitX && newPosition < limitX)
        {
            // Si est� dentro de los l�mites, actualizamos la posici�n de la paleta
            transform.position = new Vector3(newPosition, transform.position.y, transform.position.z);
        }
    }
}
