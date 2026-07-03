using System.Collections;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LuzInicial : MonoBehaviour
{
    private float intensidadeMaxima = 1f;
    private float intensidadeMinima = 0.8f;
    private float tempoMaximo = 3f;
    private float tempoMinimo = 3f;
    public Light2D luz;
    void Start()
    {
        GetComponent<Light2D>();
    }


    void Update()
    {
        StartCoroutine(LuzPiscando());
    }

    IEnumerator LuzPiscando()
    {
            luz.intensity = Random.Range(intensidadeMinima, intensidadeMaxima);

            yield return new WaitForSeconds(Random.Range(tempoMinimo, tempoMaximo));
    }

}

