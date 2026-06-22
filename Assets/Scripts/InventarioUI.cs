using UnityEngine;
using UnityEngine.UI;
public class InventarioUI : MonoBehaviour
{
    public Image slot;
    public void AdicionarItem(Sprite itemSprite)
    {

        slot.sprite = itemSprite; //Coloca a imagem no slot
        slot.enabled = true; //Ativa a imagem no slot

    }

    void Update()
    {
        
    }
}
