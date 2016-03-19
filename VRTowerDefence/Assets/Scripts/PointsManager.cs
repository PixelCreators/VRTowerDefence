using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PointsManager : MonoBehaviour {
    
    private int score;
    public Text scoreText;
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
        scoreText.text = "Score: " + score;
    }

}
