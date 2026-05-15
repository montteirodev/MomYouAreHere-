using UnityEngine;
using UnityEngine.SceneManagement;

public class menuInicial : MonoBehaviour
{
    
    public void Iniciar()
    {
        SceneManager.LoadScene("Cutscene1");
    }

    public void Controles()
    {
        SceneManager.LoadScene("MenuControles");
    }
    
    public void Configuracoes()
    {
        SceneManager.LoadScene("Configuracao");
    }
}
