using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideEffect : MonoBehaviour
{
    // Start is called before the first frame update

    /*
     *  En este script lo que se hace es aumentarle la gravedad al rigidbody del Player
     *  para que parezca que se esta resbalando.
     */

    public GameObject _Player;


    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            _Player.GetComponent<Rigidbody2D>().gravityScale = 80f;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _Player.GetComponent<Rigidbody2D>().gravityScale = 3.5f;
        }
    }

}
