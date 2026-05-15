using UnityEngine;



public class ControleMenu : MonoBehaviour
{
    public GameObject TextoDeInteração;
    public bool jogadorNaArea;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         TextoDeInteração.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        TextoDeInteração.SetActive(jogadorNaArea);
        
    }
    
    public void OnTriggerEnter2D(Collider2D other)
    
    {
       if(other.CompareTag("Player")){
            jogadorNaArea = true; 
       }
     }
   
    public void OnTriggerExit2D(Collider2D other){ //detecta quando o jogador sai da area
        if (other.CompareTag("Player")){
            jogadorNaArea = false;
        }

}
}