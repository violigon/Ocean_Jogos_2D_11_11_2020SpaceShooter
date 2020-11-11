using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidade = 2f;

    public BoxCollider2D areaJogo;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Movimentação do Jogador
        var vertical = Input.GetAxis("Vertical");
        var horizontal = Input.GetAxis("Horizontal");

        transform.Translate(new Vector2(horizontal, vertical) * velocidade * Time.deltaTime);

        // Garantir que o jogador está dentro da área de jogo

        var position = areaJogo.transform.position;
        var extents = areaJogo.bounds.extents;
        var offset = areaJogo.offset;

        var limiteXMin = -extents.x + position.x + offset.x * 2.5f;
        var limiteXMax = extents.x + position.x + offset.x * 2.5f;

        var limiteYMin = -extents.y + position.y + offset.y * 2.5f;
        var limiteYMax = extents.y + position.y + offset.y * 2.5f;

        transform.position = new Vector2(
            Mathf.Clamp(transform.position.x, limiteXMin, limiteXMax),
            Mathf.Clamp(transform.position.y, limiteYMin, limiteYMax)
        );
    }
}
