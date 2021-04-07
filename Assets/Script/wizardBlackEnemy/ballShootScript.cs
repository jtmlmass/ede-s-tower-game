using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballShootScript : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    Vector3 _currentSpeed=new Vector3();
    Vector3 _deltaPos=new Vector3();
    public GameObject player;
    bool  _shooted=true;
    Transform target;
    Transform kaos;
    float distance = 0;
    public GameObject wizardEvil;

    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update(){

        //target = GameObject.FindWithTag("Player").transform; //Finds the player in any place of the map
        target=player.transform;
        kaos=wizardEvil.transform;
        //kaos = GameObject.Find("Kaos").transform;
        distance = target.transform.position.x - transform.position.x; //Gets their distance
        if (!_shooted){
            return;
        }
        
        _deltaPos=_currentSpeed*Time.deltaTime+Physics.gravity*Mathf.Pow(Time.deltaTime,2)/2;
        gameObject.transform.Translate(_deltaPos);
        _currentSpeed+=Physics.gravity*Time.deltaTime;
    }
    public void ShootBall(Vector3 startingSpeed, float shootingAngle){
        if (player.transform.position.x > wizardEvil.transform.position.x) //If the distance is negative
        {
            _currentSpeed = new Vector3(-1f *startingSpeed.x * Mathf.Cos(shootingAngle), startingSpeed.y * Mathf.Sin(shootingAngle));
        }else 
        {
            _currentSpeed = new Vector3( startingSpeed.x * Mathf.Cos(shootingAngle), startingSpeed.y * Mathf.Sin(shootingAngle));
        }
        Debug.Log("pos player "+player.transform.position.x);
        
        //rb.velocity = new Vector2(player.transform.position.x, rb.velocity.y);
        _shooted =true;
    }
    void OnCollisionEnter2D(Collision2D collisionInfo){
        if(collisionInfo.collider.gameObject.layer == LayerMask.NameToLayer("Ground")){
            //gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
	{
		
			if (collision.CompareTag("Player"))
			{
				
				collision.SendMessageUpwards("AddDamage", 1);
				Debug.Log("Se esta enviando");
                Destroy(gameObject);
			}

		
	}
}
