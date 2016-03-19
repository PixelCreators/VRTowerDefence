using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public Teleporter startingTeleporter;
    private Teleporter currentTeleporter;

    private Quaternion startingRotation;
    private Quaternion leftCamStartingRotation;
    private Quaternion rightCamStartingRotation;

    public Transform LeftCam;
    public Transform RightCam;

	void Start ()
    {
        currentTeleporter = startingTeleporter;
        startingTeleporter.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void TeleportTo(Teleporter teleporter)
    {
        Debug.Log("DADA");
        GameManager.FadeInOut();
        currentTeleporter.gameObject.SetActive(true);
        currentTeleporter = teleporter;
        teleporter.gameObject.SetActive(false);
        gameObject.transform.position = teleporter.transform.position;
    }
    
}
