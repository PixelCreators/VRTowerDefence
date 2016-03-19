using UnityEngine;
using System.Collections;

public class DestroyOnContact : MonoBehaviour {

    //public GameObject enemyDeath;
    //public GameObject playerDeath;
    public int scoreValue;

    private PointsManager pointsManager;

    void Start()
    {
        pointsManager = FindObjectOfType<PointsManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boundary") || other.CompareTag("Enemy"))
        {
            return;
        }

        pointsManager.AddScore(scoreValue);
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
    
    void OnCollisionEnter(Collision other)
    {
        Debug.Log("heheszki");
    }
}