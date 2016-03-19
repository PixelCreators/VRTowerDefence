using UnityEngine;

public class CardboardManager : MonoBehaviour
{
    private GameManager gameManager;
    public GameObject WPCam;
    public GameObject OtherCam;

    private PlayerController player;

	void Awake ()
    {
        gameManager = GameManager.GetInstance();
        if (gameManager.CurrentPlatform == Platform.WindowsMobile)
            WPCam.SetActive(true);
        else
            OtherCam.SetActive(true);

        player = FindObjectOfType<PlayerController>();
    }
    
    public void HMDReset()
    {

    }
}