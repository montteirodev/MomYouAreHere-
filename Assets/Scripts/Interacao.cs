using UnityEngine;

public class Interacao : MonoBehaviour
{
    public KeyCode interacaoTecla = KeyCode.G; // troca de tecla no inspetor sem precisar mudar o codigo
    public bool jogadorNaArea; //controla se o jogador ta na range da porta
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        if (jogadorNaArea && Input.GetKeyDown(interacaoTecla))
        {
          InteRact();
        } //o código só executa quando o jogador está no trigger
        // a tecla foi pressionada
    }
    // Update is called once per frame
    void InteRact()
    {
        Debug.Log("Lucinda Interagiu");
        
    }
    public void OnTriggerEnter2D(Collider2D other){//detecta quando o jogador entra na área
        if (other.CompareTag("Player")){
            jogadorNaArea = true;
        }
    }
    public void OnTriggerExit2D(Collider2D other){ //detecta quando o jogador sai da area
        if (other.CompareTag("Player")){
        
            jogadorNaArea = false;
        }
    }
}
