using UnityEngine;

public class Pausar : MonoBehaviour
{
    public GameObject MenuPause;
    public  GameObject Fundo;
    private bool TaPausado = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (TaPausado)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }

    }
   void ResumeGame(){
         MenuPause.SetActive(false);
         Fundo.SetActive(false);
         Time.timeScale = 1f;
         TaPausado = false;
   }
   void PauseGame(){
         MenuPause.SetActive(true);
         Fundo.SetActive(true);
         Time.timeScale = 0f;
         TaPausado = true;
   }

}
 
