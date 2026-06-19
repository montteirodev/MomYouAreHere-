using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FadeInTransicao : MonoBehaviour
{
    public Image telaPreta;
    public float duracao = 1f;
    void Start()
    {
        StartCoroutine(FadeIn());
    }
    IEnumerator FadeIn()
    {
        Color corAtual = telaPreta.color;
        corAtual.a = 1f;
        telaPreta.color = corAtual;

        float tempo = 0f;

        while (tempo < duracao)
        {
            tempo += Time.deltaTime;
            float alpha = Mathf.Lerp(1f, 0f, tempo / duracao);
            corAtual.a = alpha;
            telaPreta.color = corAtual;
            yield return null;
        }

        corAtual.a = 0f;
        telaPreta.color = corAtual;
        telaPreta.gameObject.SetActive(false);
    }
}
