using UnityEngine;
using System.Collections;

public class DestroyByTime : MonoBehaviour {

    public float lifetime;
    //lifetime 2
    void Start()
    {
        Destroy(gameObject, lifetime);
    }

}
