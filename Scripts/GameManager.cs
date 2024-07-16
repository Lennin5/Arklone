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
        // Recargamos la escena actual (diferentes formas de hacerlo)
        // SceneManager.LoadScene("SampleScene");
        // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Función que se ejecuta cuando se destruye un bloque
    public void DecreaseBlocks()
    {
        blocksLeft -= 1; // Restamos 1 a la cantidad de bloques restantes
        Debug.Log("Blocks left: " + blocksLeft); // Mostramos en consola la cantidad de bloques restantes

        if (blocksLeft == 0)
        {
            //Debug.Log("No blocks left!");
            LoadNextSceneIndex(); // Llamamos a la función LoadNextSceneIndex del script GameManager
        }                       
    }

    // Función que sirve para cargar la siguiente escena
    public void LoadNextSceneIndex()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1; // .buildIndex nos da el índice de la escena actual, entonce sumamos 1 para obtener el índice de la siguiente escena (Nivel 2, 3, 4, etc.)
        SceneManager.LoadScene(nextSceneIndex); // Cargamos la siguiente escena
    }
}
