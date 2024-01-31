using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyZombieController : MonoBehaviour
{
    public float velocityX = 2f;
    public SpriteRenderer _sprite;


    // Start is called before the first frame update
    void Start()
    {
        _sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Explaning the FPS(Fotogramas por segundo) to show the rendiment of each computer
        Debug.Log(Time.deltaTime + "seg - " + (1.0f / Time.deltaTime) + " FPS");

        //Movement horizontal only works X axis
        transform.Translate(velocityX * Time.deltaTime, 0, 0);

        //Bouncing in axis X
        if (transform.position.x > 11.5) {
            _sprite.flipX = true;
            velocityX = -velocityX;
        } else if (transform.position.x < -11.5){
            velocityX = -velocityX;
            _sprite.flipX = false;
        }

        //Movement with X axis and Y axis
        //transform.Translate(velocityX * Time.deltaTime, velocityY * Time.deltaTime, 0);

        //Bouncing in axis Y
        /*if (transform.position.y > 4.5 || transform.position.y < -4.5)
        {
            velocityY = -velocityY;
        }*/

    }
}
