using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.UI;

public class InventarioUI : MonoBehaviour
{
    public Image[] slots;
    private static InventarioUI instance;
    public void Start()
    {
        Debug.Log("InventárioUI encontrado");
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void AdicionarItem(Sprite spriteDoItem)
    {
        Debug.Log("Tentando adicionar item ao inventário...");

        for (int i = 0; i < slots.Length; i++)
        {
            // procura um slot vazio
            if (slots[i].sprite == null)
            {   
                Debug.Log("Slot vazio encontrado no slot " + i);
                slots[i].sprite = spriteDoItem;
                slots[i].color = Color.white;

                Debug.Log("Item colocado no slot " + i);
                return;
            }
        }

        Debug.Log("Inventário cheio!");
    }


  

}



