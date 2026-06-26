using UnityEngine;
using UnityEngine.SceneManagement;

public class menuInicial : MonoBehaviour
{
    
    public void Iniciar()
    {
        SceneManager.LoadScene("Quarto1");
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
