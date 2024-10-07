using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class mouse_move : MonoBehaviour
{
    private GameObject cat;
    public Transform target;
    NavMeshAgent agent;

    void Start()
    {
        cat = GameObject.Find("cat");
        target = cat.transform;
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    void Update()
    {
        agent.SetDestination(target.position);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.name == "cat") { 
            GameManager.Instance.Win();
        }
    }
}
