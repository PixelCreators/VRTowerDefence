using UnityEngine;
using System.Collections;

public class GetMicrophon : MonoBehaviour
{
	void Start ()
    {
        Debug.Log("Start");
        AudioSource aud = GetComponent<AudioSource>();
        aud.clip = Microphone.Start("", true, 10, 44100);
        aud.loop = true;
        aud.Play();
    }
	
	void Update ()
    {
	    
	}
}
