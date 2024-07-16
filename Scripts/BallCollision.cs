using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{

    // Funci�n que se ejecuta cuando la pelota colisiona con otro objeto (cualquiera), la variable collision contiene la informaci�n del objeto con el que colision�
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Collision detected, details: " + collision.gameObject.name);


        if (collision.gameObject.tag == "Block") // podemos usar tambi�n collision.gameObject.CompareTag("Block")
            Destroy(collision.gameObject); // Destruimos el objeto con el que colision� la pelota
    }
}
