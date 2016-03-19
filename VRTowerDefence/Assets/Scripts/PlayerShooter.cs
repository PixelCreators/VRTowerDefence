using UnityEngine;
using System.Collections;

public class PlayerShooter : MonoBehaviour {

    public GameObject shot;
    public Transform shotSpawn;

    public int screenWidth;
    public int screenHeight;

    public float fireRate;
    public float distance;
    private float nextFire;

    private Rigidbody rb;

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            var position = new Vector2(screenWidth / 2, screenHeight / 2);
            var worldPosition = Camera.main.ScreenToWorldPoint(position);
            nextFire = Time.time + fireRate;
            Instantiate(shot, worldPosition, Camera.main.transform.rotation);
        }
    }
}
