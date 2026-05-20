using UnityEngine;
using UnityEngine.SceneManagement;

public class PularCutscene : MonoBehaviour
{
    
     // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButtonDown(0))
       {
           SceneManager.LoadScene("Quarto1");


       } 
    }
}
