using UnityEngine;
using System.Collections;

public class Teleporter : MonoBehaviour
{
    public float lookTime = 2.0f;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void SetGazedAt(bool gazedAt)
    {
        StartCoroutine(WaitTime());
    
    }

    public void SetGazedOff()
    {
        StopCoroutine(WaitTime());
        GetComponent<Renderer>().material.color = Color.red;
    }

    public void GazedClick()
    {

    }

    public IEnumerator WaitTime()
    {
        var currentLookTime = 0.0f;
        while (true)
        {
            yield return new WaitForSeconds(lookTime / 60);
            currentLookTime += lookTime / 60;
            if (currentLookTime == lookTime)
                break;
        }
        GetComponent<Renderer>().material.color = Color.green;
    }
}
