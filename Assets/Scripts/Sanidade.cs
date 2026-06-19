using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class Sanidade : MonoBehaviour
{
    public Light2D luz;
    public Slider sanidadeSlider;
    private float sanidade;
    public float sanidadeMaxima = 100f;
    private float tempo;

    void Start()
    {
        sanidade = sanidadeMaxima;
        sanidadeSlider.maxValue = sanidadeMaxima;
        sanidadeSlider.value = sanidade;
    }
    void Update()
    {
        if (luz.intensity <= 0.05f)
        {
            tempo += Time.deltaTime;

            if(tempo >= 1f)
            {
                sanidade -= 5f;
                sanidade = Mathf.Clamp(sanidade, 0f, sanidadeMaxima);
                sanidadeSlider.value = sanidade;
                tempo = 0f;
            }

        }
    }
}
