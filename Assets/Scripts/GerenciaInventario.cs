using UnityEngine;

public class GerenciaInventário : MonoBehaviour
{
    public GameObject InventarioPainel;
    
    private static GerenciaInventário instancia;

    private bool InventarioAtivo = false;

      



    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            InventarioAtivo =! InventarioAtivo;
            InventarioPainel.SetActive(InventarioAtivo);
        }
    }
}
