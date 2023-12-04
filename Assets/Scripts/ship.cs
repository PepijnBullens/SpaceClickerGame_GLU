using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship : MonoBehaviour
{
    // reference to game manager script
    private GameManager game;

    // score amount
    [SerializeField]
    int scoreAmount;

    private float shipWidth;

    [SerializeField]
    private float resetXPosition;

    [SerializeField]
    private float speedX;

    // start
    void Start()
    {
        game = FindObjectOfType<GameManager>();

        shipWidth = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // update
    void Update()
    {
        if(transform.position.x + (shipWidth / 2f) < 0)
        {
            game.AddScore(-1);
            Resetpos();
        }

        transform.position = transform.position + new Vector3(speedX * Time.deltaTime, 0f, 0f);
    }

    // reset pos
    private void Resetpos()
    {
        transform.position = new Vector3(resetXPosition, Random.Range(-4.5f, 4.5f), transform.position.z);
    }

    // mouse down
    private void OnMouseDown()
    {
        game.AddScore(scoreAmount);
        Resetpos();
    }
}
