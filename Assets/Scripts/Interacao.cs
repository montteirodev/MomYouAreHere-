using UnityEngine;


public class Interacao : MonoBehaviour
{
    public KeyCode interacaoTecla = KeyCode.L;
    public bool jogadorNaArea;
    public Sprite ItemIcone;

    private void Start()
    {
        
    }
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
            

            InventarioUI inventario = FindFirstObjectByType<InventarioUI>();
            
            Debug.Log(inventario);
            
            if (inventario != null)
            {
                inventario.AdicionarItem(ItemIcone);
                Debug.Log("Item adicionado ao inventário!");
            }

            Destroy(gameObject); // Remove o item da cena ap�s a interacao

        }


        

    }



}
