using UnityEngine;

public class GerenciaInventario : MonoBehaviour
{
    public GameObject InventarioPainel;

    private static GerenciaInventario instancia;

    private bool InventarioAtivo = false;




    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            InventarioAtivo =! InventarioAtivo;
            InventarioPainel.SetActive(InventarioAtivo);
        }
    }
}
