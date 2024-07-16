using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int blocksLeft = 0; // Variable para almacenar la cantidad de bloques restantes en la escena
    // Start is called before the first frame update
    void Start()
    {
        blocksLeft = GameObject.FindGameObjectsWithTag("Block").Length; // Buscamos todos los objetos con el tag "Block" y almacenamos la cantidad en la variable blocksLeft
        //Debug.Log("Blocks left: " + blocksLeft); // Mostramos en consola la cantidad de bloques restantes
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Función que se ejecuta cuando se presiona el botón de reinicio
    public void RestartScene()
    {
        // Recargamos la escena actual
        //SceneManager.LoadScene("SampleScene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void DecreaseBlocks()
    {
        blocksLeft -= 1; // Restamos 1 a la cantidad de bloques restantes
        Debug.Log("Blocks left: " + blocksLeft); // Mostramos en consola la cantidad de bloques restantes

        if (blocksLeft == 0)
        {
            Debug.Log("No blocks left!");
        }        
               
    }
}
