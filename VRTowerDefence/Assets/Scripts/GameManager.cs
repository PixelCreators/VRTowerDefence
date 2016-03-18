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
    public static GameManager Instance;
    public Platform CurrentPlatform;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }
}
