using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Funci�n que se ejecuta cuando se presiona el bot�n de reinicio
    public void RestartScene()
    {
        // Recargamos la escena actual
        //SceneManager.LoadScene("SampleScene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
