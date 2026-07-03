using UnityEngine;
using UnityEngine.UI;

public class GerenciaInventario : MonoBehaviour
{
    public GameObject InventarioPainel;

    

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
