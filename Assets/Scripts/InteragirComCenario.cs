using UnityEngine;
using UnityEngine.SceneManagement;

public class InteragirComCenario : MonoBehaviour
{

    public string IdDaPorta;
    public KeyCode interacaoTecla = KeyCode.E; // troca de tecla no inspetor sem precisar mudar o codigo
    private bool jogadorNaArea; //controla se o jogador ta na range da porta
    
    public string nomeDaCena;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        if (jogadorNaArea && Input.GetKeyDown(interacaoTecla)){
            Interact();
        }
    }
    // Update is called once per frame
    void Interact()
    {
        SceneManager.LoadScene(nomeDaCena);
        PlayerPrefs.SetString("UltimaPorta", IdDaPorta);
        
        SceneManager.LoadScene(nomeDaCena);
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    { //detecta quando o jogador entra na área
        if (other.CompareTag("Player")){
            jogadorNaArea = true;
        }
      
       
    }
    private void OnTriggerExit2D(Collider2D other){ //detecta quando o jogador sai da area
        if (other.CompareTag("Player")){
            jogadorNaArea = false;
        }
    }
}
