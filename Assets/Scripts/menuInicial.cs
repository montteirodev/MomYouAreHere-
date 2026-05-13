using UnityEngine;
using UnityEngine.SceneManagement;

public class menuInicial : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Iniciar()
    {
        SceneManager.LoadScene("Cutscene1");
    }

    // Update is called once per frame
    public void Controles()
    {
        SceneManager.LoadScene("MenuControles");
    }
}
