using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public float lookTime = 2.0f;
    private IEnumerator timerCorutine;

    public void SetGazedAt()
    {
        timerCorutine = WaitTime();
        StartCoroutine(timerCorutine);
    }

    public void SetGazedOff()
    {
        StopCoroutine(timerCorutine);
    }
    

    public IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(lookTime);
        GetComponent<Button>().onClick.Invoke();
    }
}
