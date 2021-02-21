using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TaskLoader : MonoBehaviour
{
    public GameObject[] tasks;
    public Transform position1;
    public Transform position2;
    public Transform position0;
    private GameObject instantiatedObject0 = null;
    private GameObject instantiatedObject1 = null;
    private GameObject instantiatedObject2 = null;
    private string scene;
    private bool complete = false;

    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene().name;
        if (scene.Equals("Dormitorio Luke"))
        {
            complete = true;
        }
        if (scene.Equals("Dormitorio Luke") || scene.Equals("Pasillo"))
        {
            instantiatedObject0 = Instantiate(tasks[0], position0.position, Quaternion.identity, GameObject.FindGameObjectWithTag("Task").transform) as GameObject;
            instantiatedObject1 = Instantiate(tasks[1], position1.position, Quaternion.identity, GameObject.FindGameObjectWithTag("Task").transform) as GameObject;
            instantiatedObject2 = Instantiate(tasks[2], position2.position, Quaternion.identity, GameObject.FindGameObjectWithTag("Task").transform) as GameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (!instantiatedObject0)
            {
                instantiatedObject0 = Instantiate(tasks[0], position0.position, Quaternion.identity, GameObject.FindGameObjectWithTag("Task").transform) as GameObject;
                instantiatedObject1 = Instantiate(tasks[1], position1.position, Quaternion.identity, GameObject.FindGameObjectWithTag("Task").transform) as GameObject;
                instantiatedObject2 = Instantiate(tasks[2], position2.position, Quaternion.identity, GameObject.FindGameObjectWithTag("Task").transform) as GameObject;
            }
        }
    }

    private void LateUpdate()
    {
        if (!scene.Equals("Dormitorio Luke") && !scene.Equals("Pasillo"))
        {
            if (instantiatedObject0)
            {
                instantiatedObject1.GetComponent<Animator>().SetBool("Appear", true);
                instantiatedObject2.GetComponent<Animator>().SetBool("Appear", true);
                instantiatedObject0.GetComponent<Animator>().SetBool("Appear", true);
            }
        }
        if (complete == true)
        {
            instantiatedObject1.GetComponent<Animator>().SetTrigger("Complete");
        }
    }
}
