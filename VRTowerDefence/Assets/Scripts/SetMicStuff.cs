using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetMicStuff : MonoBehaviour {

    public Text DBT;
    public Text PT;

    public static Text DBText;
    public static Text PitchText;


	// Use this for initialization
	void Start () {
        SetMicStuff.DBText = DBT;
        SetMicStuff.PitchText = PT;
	}
	
	// Update is called once per frame
	void Update () {
        	
	}

    public static void SetText(string DB, string Pitch)
    {
        DBText.text = DB;
        PitchText.text = Pitch;
    }
}
