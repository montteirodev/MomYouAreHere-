using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InteragirComCenario : MonoBehaviour
{

    public string IdDaPorta;
    public KeyCode interacaoTecla = KeyCode.E; // troca de tecla no inspetor sem precisar mudar o codigo
    private bool jogadorNaArea; //controla se o jogador ta na range da porta
    public GameObject telaPreta;
    public string nomeDaCena;
    public float tempoDeTransicao = 1f;
    
    void Update()
    {
        if (jogadorNaArea && Input.GetKeyDown(interacaoTecla))
        {
            
            StartCoroutine(Interact());

        }
    }
 

    IEnumerator Interact()
    {
        Color cor = telaPreta.GetComponent<Image>().color;
        telaPreta.gameObject.SetActive(true);
        float tempo = 0f;
        while (tempo < tempoDeTransicao)
        {
            cor.a = Mathf.Lerp(0f, 1f, tempo / tempoDeTransicao);
            telaPreta.GetComponent<Image>().color = cor;
            tempo += Time.deltaTime;

            yield return null;
        }
        PlayerPrefs.SetString("UltimaPorta", IdDaPorta);
        TrocarCena();
    }

    void TrocarCena()
    {
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
