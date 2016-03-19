using UnityEngine;
using System.Collections;

public class PlayerShooter : MonoBehaviour {

    public GameObject shot;
    public Transform shotSpawn;


    public float fireRate;
    private float nextFire;

    private int screenWidth;
    private int screenHeight;

    bool fired = false;
    // Use this for initialization
    void Start ()
    {
        screenHeight = Screen.height;
        screenWidth = Screen.width;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            Fire();
        }
    }

    public void Fire()
    {
        if (fired)
            return;

        fired = true;
        var position = new Vector2(screenWidth / 2, screenHeight / 2);
        var worldPosition = Camera.main.ScreenToWorldPoint(position);
        nextFire = Time.time + fireRate;
        Instantiate(shot, worldPosition, Camera.main.transform.rotation);

        StartCoroutine(Fired());
    }

    IEnumerator Fired()
    {
        Debug.Log("Test");
        yield return new WaitForSeconds(1.0f);
        fired = false;
    }
}
