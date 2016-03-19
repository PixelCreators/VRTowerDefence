using UnityEngine;
using System.Collections;

public class DestroyBoltOnCollision : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary" || other.tag == "Player" || other.tag == "Wall")
            return;

        if (other.tag == "Enemy")
            other.GetComponent<AgentScript>().Die();

        Destroy(gameObject);
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag != "Boundary")
            return;

        Destroy(gameObject);
    }
}
