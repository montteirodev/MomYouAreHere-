using UnityEngine;
using UnityEngine.UI;

public class InventarioUI : MonoBehaviour
{
    public Image slot;

    public void AdicionarItem(Sprite spriteDoItem)
    {
        slot.sprite = spriteDoItem;
        slot.enabled = true;
    }

}
