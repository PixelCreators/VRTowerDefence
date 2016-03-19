using UnityEngine;
using System.Collections;

public class PointsManager : MonoBehaviour {
    
    private int score;

    // Use this for initialization
    void Start ()
    {
        score = 0;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
    }

}
