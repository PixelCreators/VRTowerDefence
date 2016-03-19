using UnityEngine;
using System.Collections;

public class MultiplyRadiusOnCollision : MonoBehaviour {

    public GameObject[] hazards;
    public Vector3 spawnValues;

    public float multiply;
    public float Wait;

    void Start () {
	    
	}
	
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary" || other.tag == "Player" || other.tag == "Wall")
            return;

        if (other.tag == "Enemy")
        {
            StartCoroutine(Multiply());
            other.GetComponent<AgentScript>().Die();
        }
    }
    IEnumerator Multiply()
    {
        var sphereCollider = GetComponent<SphereCollider>();
        sphereCollider.radius *= multiply;
        Debug.Log(sphereCollider.radius);
        yield return new WaitForSeconds(Wait);
        Destroy(gameObject);
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag != "Boundary")
            return;

        Destroy(gameObject);
    }
}
