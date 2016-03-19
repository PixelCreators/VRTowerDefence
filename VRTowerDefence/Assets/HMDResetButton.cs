using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HMDResetButton : MonoBehaviour {

    public Cardboard cardboard;
    public Text CountDownText;
    private bool ResetInProgress;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Recenter()
    {
        ResetInProgress = true;
        StartCoroutine(ResetHMD());
    }

    IEnumerator ResetHMD()
    {
        var counter = 0.0f;
        while (true)
        {
            CountDownText.text = ((int)((5.0f - counter)*100))/100.0f + "";
            yield return new WaitForSeconds(5.0f/30);
            counter += 5.0f / 30;
            if(counter >= 5.0f)
            {
                cardboard.Recenter();
           

                ResetInProgress = false;
                break;
            }
        }
    }
}
