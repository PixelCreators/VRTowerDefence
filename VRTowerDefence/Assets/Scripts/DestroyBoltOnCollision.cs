using UnityEngine;
using System.Collections;

public class DestroyBoltOnCollision : MonoBehaviour
{
    public GameObject explosion;
    bool done = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary" || other.tag == "Player" || other.tag == "Wall" || other.tag == "Fire")
            return;


        if (!done)
        {
            StartCoroutine(WaitBeforeDestroy());
            GetComponent<SphereCollider>().radius *= 30;
            Debug.Log(GetComponent<SphereCollider>().radius);
            Instantiate(explosion, transform.position, Quaternion.identity);
        }
        done = true;

        if (other.tag == "Enemy")
        { 
            other.GetComponent<AgentScript>().Die();
        
        }
    }

    IEnumerator WaitBeforeDestroy()
    {
        yield return new WaitForSeconds(0.1f);
        Destroy(gameObject);
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag != "Boundary")
            return;

        Destroy(gameObject);
    }
}
