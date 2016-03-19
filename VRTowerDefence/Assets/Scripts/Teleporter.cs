using UnityEngine;
using System.Collections;

public class Teleporter : MonoBehaviour
{
    public float lookTime = 2.0f;
    private IEnumerator timerCorutine;
    private PlayerController player;

    void Awake()
    {
        player = FindObjectOfType<PlayerController>();
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void SetGazedAt(bool gazedAt)
    {
        Debug.Log("Gaz");
        timerCorutine = WaitTime();
        StartCoroutine(timerCorutine);
    }

    public void SetGazedOff()
    {
        StopCoroutine(timerCorutine);
        GetComponent<Renderer>().material.color = Color.red;
    }

    public void GazedClick()
    {
        player.TeleportTo(this);
        GetComponent<Renderer>().material.color = Color.green;
    }

    public IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(lookTime);
        GazedClick();
    }
}
