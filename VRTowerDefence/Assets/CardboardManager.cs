using UnityEngine;

public class CardboardManager : MonoBehaviour
{
    private GameManager gameManager;
    public GameObject WPCam;
    public GameObject OtherCam;

	void Awake ()
    {
        gameManager = GameManager.Instance;
        if (gameManager.CurrentPlatform == Platform.WindowsMobile)
            WPCam.SetActive(true);
        else
            OtherCam.SetActive(true);
    }
}