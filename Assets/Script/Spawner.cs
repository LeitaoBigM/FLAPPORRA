using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Spawner : MonoBehaviour
{
    public GameObject canos;
    public float altura, tempoMax = 1f, tempo = 0f;
    void Start()
    {
        
    }
    void Update()
    {
        if(tempo > tempoMax)
        {
            GameObject novoCano = Instantiate(canos);
            novoCano.transform.position = transform.position + new Vector3(0 ,Random.Range(-altura, altura), 0);
            Destroy(novoCano, 20f);
            tempo = 0f;
        }
        tempo += Time.deltaTime;
    }
}