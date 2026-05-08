using UnityEngine;

public class Movimentacao : MonoBehaviour
{
  public float speed = 5f;
    private Rigidbody2D rb; //Variável para referenciar o componente Rigidbody2D sendo manipulável com o nome rb
    private float movimento; //Variável para indicar o movimento que pode ser flutuante
    private SpriteRenderer sr;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Minha variável rb pega o componente do game object 
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Zera o movimento todo frame
        movimento = 0f;
        
        //Se apertar A vai pra esquerda
        if (Input.GetKey(KeyCode.A))
        {
           movimento = -1f;
        }
        
        //Se apertar D vai pra direita
        if (Input.GetKey(KeyCode.D))
        {
           movimento = 1f;
        }
    
        if(Input.GetAxis("Horizontal") > 0) { //Ele verifica se o personagem está se movendo para a direita (move > 0) ou para a esquerda (move < 0) e muda o valor de flipX para inverter o sprite.
            sr.flipX = false;} //propriedade booleana que espelha o sprite horizontalmente.
          else if(Input.GetAxis("Horizontal") < 0) {
            sr.flipX = true; //propriedade booleana que espelha o sprite horizontalmente.
        }
        

    }

    //Executa em tempo fixo
    void FixedUpdate()
    {
      //Deixa a velocidade vertical fixa, como o valor é 0 vai evitar afetar gravidade
      rb.linearVelocity = new Vector3 (movimento * speed, rb.linearVelocity.y);


    }

    
       
    
    


}
