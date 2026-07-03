using UnityEngine;

public class Som : MonoBehaviour
{
    public static Som instance;

    [Header("Áudio ambiente")]
    public AudioClip somAmbiente;

    [Header("Controle")]
    public bool ligarSom = true;

    [Header("Menu inicio")]
    public AudioClip Inicio;

    private AudioSource audioSource;

    private void Awake()
    {
            if (instance == null && instance != this)
        {
             DontDestroyOnLoad(gameObject);

        }
       else
       {
           Destroy(gameObject);
       }
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        //if (audioSource == null)
        //{
        //    audioSource = gameObject.AddComponent<AudioSource>();
        //}

        //audioSource.clip = somAmbiente;
        //audioSource.loop = true;
        //audioSource.playOnAwake = false;
        //audioSource.clip = Inicio; audioSource.loop = false;

        if (ligarSom == true && somAmbiente != null)
        {
            audioSource.Play();
        }
    }

    //void Update()
    //{
    //    if (ligarSom == true)
    //    {
    //        if (audioSource.isPlaying == false)
    //        {
    //            audioSource.Play();
    //        }
    //    }
    //    else
    //    {
    //        if (audioSource.isPlaying == true)
    //        {
    //            audioSource.Stop();
    //        }
    //    }
    //}

    public void TocarSomInicio()
    {
            audioSource.PlayOneShot(Inicio); 
        //if (Inicio != null && audioSource != null)
        //{ 
        //   // TocarSomInicio();
        //}
    }
}