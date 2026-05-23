using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Luz : MonoBehaviour
{
    public Light2D luz;
    private bool ligado = false;
    private bool jogadorNaArea = false;


    private void Update()
    {
        if (jogadorNaArea && Input.GetKeyDown(KeyCode.E))
        {
            ligado = !ligado;
            luz.intensity = ligado ? 1.0f : 0.05f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            jogadorNaArea = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            jogadorNaArea = false;
        }
    }
}
    
