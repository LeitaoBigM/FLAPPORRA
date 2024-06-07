using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    Animator anim;
    public float speed;
    Rigidbody2D rig;
    public GameController controle;
    public GameObject gameOver;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        vua();
    }
    void OnCollisionEnter2D(Collision2D colisao)
    {
        if(colisao.gameObject.CompareTag("Chão"))
        {
            Destroy(this.gameObject);
        }
        if(colisao.gameObject.CompareTag("Cano"))
        {
            Destroy(this.gameObject);
        }
        gameOver.SetActive(true);
        Time.timeScale = 0f;
    }
    void vua()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rig.velocity = Vector2.up * speed;
            anim.Play("Vuando");
        }
    }
    void OnTriggerEnter2D(Collider2D colisao)
    {
        if(colisao.gameObject.tag == "ponto")
        {
            controle.pontos ++;
            controle.txtPontos.text = controle.pontos.ToString();
        }
    }
}