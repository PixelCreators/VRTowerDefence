using UnityEngine;
using System.Collections;

public class PointsManager : MonoBehaviour {

    public GUIText scoreText;

    private int score;

    // Use this for initialization
    void Start ()
    {
        score = 0;
        UpdateScore();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }
    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }

}
