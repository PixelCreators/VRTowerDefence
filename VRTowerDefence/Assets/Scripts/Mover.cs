using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour
{
    public float speed;

    private Transform player;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
    }
}
