using System.IO;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int pontos = 6;
    public int vidas = 3;



    public void addPontos(int qtd) 
    {
        pontos += qtd;

        if (pontos < 0) { 
        
            pontos = 0;
        }

        Debug.Log("pontos"+pontos);


    }
    public void PerderVidas(int vida) 
    {
    vidas -= vida;
        Debug.Log("vidas" + vidas);
        GameObject player = GameObject.FindWithTag("Player");
        player.GetComponent<Player>().ReiniciarPosicao();

        if (vidas == 0) {
            Time.timeScale = 0;
            Debug.Log("Cabo playboy, coloca mais ficha");
        }  

    }

}
