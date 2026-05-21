using UnityEngine;

public class SpawnJogador : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string ultimaPorta = PlayerPrefs.GetString("UltimaPorta");
        if (string.IsNullOrEmpty(ultimaPorta))
        {
            Debug.Log("Nenhuma porta encontrada, spawn padrão.");
            return;
        }

        string nomeSpawn = "Spawn_" + ultimaPorta;

        GameObject spawn = GameObject.Find(nomeSpawn);

        if (spawn != null)
        {
            transform.position = spawn.transform.position;
        }

        PlayerPrefs.DeleteKey("UltimaPorta");
    }
}
