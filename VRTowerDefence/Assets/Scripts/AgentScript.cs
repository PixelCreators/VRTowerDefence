using UnityEngine;
using System.Collections;

public class AgentScript : MonoBehaviour {

    public Transform target;
    NavMeshAgent agent;


	// Use this for initialization
	void Start ()
    {
        target = FindObjectOfType<WallController>().transform;
        agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        agent.SetDestination(target.position);
	}
}
