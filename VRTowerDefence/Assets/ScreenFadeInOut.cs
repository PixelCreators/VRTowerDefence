using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScreenFadeInOut : MonoBehaviour
{
    public float fadeSpeed = 1.5f;          // Speed that the screen fades to and from black.

    private bool fadedOut = false;
    public RawImage image;

    void Awake()
    {
        image.color = Color.clear;
        image.enabled = false;
        Debug.Log(image.color.a);
        Debug.Log(image);
    }

    void Start()
    {
       // FadeOut();
    }

    public void FadeOutIn()
    { 
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeToClear()
    {
        while (true)
        {
            yield return new WaitForFixedUpdate();
            image.color = Color.Lerp(image.color, Color.clear, fadeSpeed * Time.fixedDeltaTime);
            if (image.color.a <= 0.05f)
            {
                image.color = Color.clear;
                break;
            }
        }
        fadedOut = false;

        Debug.Log(fadedOut);
        yield return null;
    }

    IEnumerator FadeToBlack()
    {
        while (true)
        {
            yield return new WaitForFixedUpdate();
            image.color = Color.Lerp(image.color, Color.black, fadeSpeed * Time.fixedDeltaTime);
            if (image.color.a >= 0.95f)
            {
                image.color = Color.black;
                break;
            }
        }
        fadedOut = true;
  
        Debug.Log(fadedOut);
        yield return null;
    }


    IEnumerator FadeOut()
    {
        image.enabled = true;
        StartCoroutine(FadeToBlack());
        while (true)
        {
            if (fadedOut)
            {
                StartCoroutine(FadeToClear());
                break;
            }
            yield return new WaitForFixedUpdate();
        }
        image.enabled = false;
    }
}