using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{

    GameManager gameManager; // Variable para almacenar el script GameManager

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>(); // Buscamos el script GameManager en la escena (lo hace de manera automática, no es necesaria ninguna referencia)
    }

    // Función que se ejecuta cuando la pelota colisiona con otro objeto (cualquiera), la variable collision contiene la información del objeto con el que colisionó
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Collision detected, details: " + collision.gameObject.name);
        // Podemos usar también if(collision.gameObject.CompareTag("Block"))
        if (collision.gameObject.tag == "Block")
        {
            Destroy(collision.gameObject); // Destruimos el objeto con el que colisionó la pelota
            gameManager.DecreaseBlocks(); // Llamamos a la función DecreaseBlocks del script GameManager que disminuye la cantidad de bloques restantes
        }
    }

    // Función que se ejecuta cuando la pelota entra en contacto con un trigger (un objeto con el componente Collider2D con la propiedad IsTrigger activada)
    private void OnTriggerEnter2D(Collider2D collider)
    {
        //Debug.Log("Se disparó el trigger, detalles: " + collider.gameObject.name);
        gameManager.RestartScene(); // Llamamos a la función RestartScene del script GameManager
    }

}
