        using UnityEngine;

public class coins : MonoBehaviour
{
    public int pontos;
    public GameManager gamemaneger;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D colisao)
    {
        if (colisao.CompareTag("Player"))
        {
            gamemaneger.addPontos(10);
            Destroy(gameObject);
        }


        
    }
}
