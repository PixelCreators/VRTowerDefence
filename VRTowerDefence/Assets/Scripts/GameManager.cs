using UnityEngine;
using System.Collections;

public enum Platform
{
    Windows,
    Android,
    i0S,
    WindowsMobile
}

public class GameManager : MonoBehaviour
{
    private static GameManager Instance;
    public Platform CurrentPlatform;
    public ScreenFadeInOut ScreenFadeInOut;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        ScreenFadeInOut = GetComponent<ScreenFadeInOut>();
    }

   public static void FadeInOut()
   {
        Instance.ScreenFadeInOut.FadeOutIn();
   }

    public static GameManager GetInstance()
    {
        return Instance;
    }
}
