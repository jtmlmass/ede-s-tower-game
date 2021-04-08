using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
	public int totalHealth = 3;

	private int health;

	private SpriteRenderer _renderer;
	private Animator _animator;

	public UnityEngine.UI.Image barraRoja;


	private void Awake()
	{
		_renderer = GetComponent<SpriteRenderer>();
		_animator = GetComponent<Animator>();
	}

	void Start()
	{
		health = totalHealth;
	}
    private void FixedUpdate()
    {
		actualizarDisplay(); 
    }

	void actualizarDisplay()
    {
		barraRoja.fillAmount = (float)health / totalHealth;
	}
    public void AddDamageEnemy(int amount)
	{
		health = health - amount;

		// Visual Feedback
		StartCoroutine("VisualFeedback");
		Debug.Log("Se esta recibiendo");

		// Game  Over
		if (health <= 0)
		{
			switch (GameManager.instance.saveData.difficulty)
			{
				case SaveData.Difficulty.Easy:
					GameManager.instance.saveData.playerData.AddPoints(5);
					break;
				case SaveData.Difficulty.Normal:
					GameManager.instance.saveData.playerData.AddPoints(10);
					break;
				case SaveData.Difficulty.Hard:
					GameManager.instance.saveData.playerData.AddPoints(15);
					break;
				case SaveData.Difficulty.Hell:
					GameManager.instance.saveData.playerData.AddPoints(20);
					break;
			}
			health = 0;
			StartCoroutine("Died");
		}

		Debug.Log("Enemy got damaged. His current health is " + health);
	}

	private IEnumerator VisualFeedback()
	{
		_animator.SetTrigger("isDamaged");

		yield return new WaitForSeconds(0.7f);
	}

	private IEnumerator Died()
    {
		_animator.SetTrigger("Died");

		yield return new WaitForSeconds(1f);

		gameObject.SetActive(false);
		//Destroy(gameObject,2f);
    }

	public int getCurrentHealthEnemy()
	{
		return health;
	}

	public int totalHealthEnemy()
	{
		return health;
	}
}

