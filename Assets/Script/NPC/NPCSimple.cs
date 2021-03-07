using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSimple : MonoBehaviour
{
    public float speed = 1f;
    private GameObject _target;
    public float minX;
    private Animator _animator;
    private bool idle = true;
    public bool finished = false;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        UpdateTarget();
        StartCoroutine("PatrolToTarget");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator PatrolToTarget()
    {
        while (Vector2.Distance(transform.position, _target.transform.position) > 0.05f)
        {
            Vector2 direction = _target.transform.position - transform.position;
            float xDirection = direction.x;
            transform.Translate(direction.normalized * speed * Time.deltaTime);
            yield return null;
        }

        transform.position = new Vector2(_target.transform.position.x, transform.position.y);
        yield return null;

        UpdateTarget();
        StartCoroutine("PatrolToTarget");
    }

    private void UpdateTarget()
    {
        if (_target == null)
        {
            _target = new GameObject("Target");
            _target.transform.position = new Vector2(minX, transform.position.y);
        }
        if(_target && finished)
        {
            minX = -13000;
           _target.transform.position = new Vector2(minX, transform.position.y);
        }
    }
    void LateUpdate()
    {
        _animator.SetBool("Idle", idle);
    }
}
