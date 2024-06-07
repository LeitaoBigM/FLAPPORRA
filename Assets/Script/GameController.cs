using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public int pontos = 0;
    public Text Score, Best;
    public Text txtPontos;
    public static int best = 0;
    void Start()
    {
        Time.timeScale = 1;
        pontos = 0;
    }
    public void restart()
    {
        SceneManager.LoadScene(0);
    }
    public void Update()
    {
        if(best < pontos)
        {
            best = pontos;
        }
        Best.text = best.ToString();
        Score.text = pontos.ToString();
    }
}