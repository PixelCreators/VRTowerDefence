using UnityEngine;
using System.Collections;

public class WallController : MonoBehaviour {

    public float WallHP;

    //void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log("heheszki");
    //}

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("heheszki");
    }
}
