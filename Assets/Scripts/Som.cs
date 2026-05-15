using UnityEngine;

public class Som : MonoBehaviour
{
[Header("Áudio ambiente")]
public AudioClip somAmbiente;

[Header("Controle")]
public bool ligarSom = true;

private AudioSource audioSource;

void Start()
{
audioSource = GetComponent<AudioSource>();

if (audioSource == null)
{
audioSource = gameObject.AddComponent<AudioSource>();
}

audioSource.clip = somAmbiente;
audioSource.loop = true;
audioSource.playOnAwake = false;

if (ligarSom == true && somAmbiente != null)
{
audioSource.Play();
}
}

void Update()
{
if (ligarSom == true)
{
if (audioSource.isPlaying == false)
{
audioSource.Play();
}
}
else
{
if (audioSource.isPlaying == true)
{
audioSource.Stop();
}
}
}
}