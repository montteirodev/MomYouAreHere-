using UnityEngine;

public class SpawnJogador : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //
        string UltimaPorta = PlayerPrefs.GetString("UltimaPorta");

        if (UltimaPorta == "portaSala")
        {
            GameObject spawn = GameObject.Find("Spawn_PortaSala");
            transform.position = spawn.transform.position;
        }

    }

    
    
}
