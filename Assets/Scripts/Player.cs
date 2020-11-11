using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidade = 2f;

    void Start()
    {
        
    }

    
    void Update()
    {
        //Input Vertical
        //Recebe 0 quando não está apertado
        //Recebe -1 quando está apertado para baixo
        //Recebe 1 quando está apertado para cima

        var vertical = Input.GetAxis("Vertical");
       
        transform.Translate(Vector2.up * vertical * velocidade * Time.deltaTime);
    }
}
