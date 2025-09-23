        using UnityEngine;

public class coins : MonoBehaviour
{
    public int pontos;
    
    
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
            Debug.Log("colidiu");
        }


        
    }
}
