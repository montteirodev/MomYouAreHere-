using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuInicial : MonoBehaviour
{
    public GameObject controles;
    public GameObject Fundo;

    public void Iniciar()
    {
        SceneManager.LoadScene("Cutscene1");
    }

    private void OnMouseDown()
    {
        controles.SetActive(true);
        Fundo.SetActive(true);
    }

    public void Configuracoes()
    {
        SceneManager.LoadScene("Configuracao");
    }

    public void Fechar()
    {
        controles.SetActive(false);
        Fundo.SetActive(false);
    }
}
