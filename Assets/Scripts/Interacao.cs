using UnityEngine;

public class Interacao : MonoBehaviour
{
    public KeyCode interacaoTecla = KeyCode.G;
    public bool jogadorNaArea;

    // Start is called once before the first execution of Update after the MonoBehaviour is created  

    private void OnTriggerEnter2D(Collider2D other)
    { //detecta quando o jogador entra na area
        if (other.CompareTag("Player"))
        {
            jogadorNaArea = true;
        }


    }
    private void OnTriggerExit2D(Collider2D other)
    { //detecta quando o jogador sai da area
        if (other.CompareTag("Player"))
        {
            jogadorNaArea = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (jogadorNaArea && Input.GetKeyDown(interacaoTecla))
        {
            Debug.Log("Interagiu com o item!");
            Destroy(gameObject); // Remove o item da cena ap�s a interacao
        }
    }
}
