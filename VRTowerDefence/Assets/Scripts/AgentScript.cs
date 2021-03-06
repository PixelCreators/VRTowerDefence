﻿using UnityEngine;
using System.Collections;

public class AgentScript : MonoBehaviour {

    private WallController wall;

    public AudioClip orc;
    public Transform target;
    public int scoreValue;
    NavMeshAgent agent;
    public float Strength = 3.0f;
    private IEnumerator DamageCoroutine;
    Animator anim;
	// Use this for initialization
	void Start ()
    {    
        target = FindObjectOfType<WallController>().transform;
        agent = GetComponent<NavMeshAgent>();
        transform.LookAt(target);
        anim = GetComponentInChildren<Animator>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        agent.SetDestination(target.position);
	}
    public void Die()
    {
        FindObjectOfType<PointsManager>().AddScore(scoreValue);

        if (DamageCoroutine != null)
            StopCoroutine(DamageCoroutine);
        
        Destroy(gameObject);
    }

    void OnTriggerEnter(Collider other)
    {;
        if (other.tag != "Wall")
            return;

        wall = other.GetComponentInParent<WallController>();

        if (DamageCoroutine == null)
        {
            DamageCoroutine = DealDamage();
            StartCoroutine(DealDamage());
        }
    }
    

    IEnumerator DealDamage()
    {
        anim.SetBool("lsAtacking", true);
        while(true)
        {
            wall.GetDamage(Strength);
            Debug.Log("a masz");
            AudioSource.PlayClipAtPoint(orc, transform.position);
            yield return new WaitForSeconds(3.0f);
        }
    }
}
