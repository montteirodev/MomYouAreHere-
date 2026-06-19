using UnityEngine;

public class Interacaocomitens : MonoBehaviour
{
    public KeyCode interacaoTecla = KeyCode.G;
    private bool jogadorNaArea;

    public Sprite iconeItem; 


    // Start is called once before the first execution of Update after the MonoBehaviour is created  

    private void OnTriggerEnter2D(Collider2D other)
    { //detecta quando o jogador entra na área
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
            Destroy(gameObject); // Remove o item da cena após a interação

            InventarioUI inventario = Object.FindFirstObjectByType<InventarioUI>();

             if (inventario != null)
            {
                inventario.AdicionarItem(iconeItem);
            }


        }
    }
}
