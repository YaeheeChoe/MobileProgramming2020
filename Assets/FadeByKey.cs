using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class FadeByKey : MonoBehaviour
{
    public KeyCode keyCode;
    private FadeControllerYH fader;
    bool stopUpdate =false;
    // Start is called before the first frame update
    void Awake()
    {
        fader = GetComponent<FadeControllerYH>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!stopUpdate)
        {
            if (Input.GetKeyDown(keyCode))
            {
                StartCoroutine(getKeyRoutine());
                stopUpdate = true;
            }
        }
        
    }
    IEnumerator getKeyRoutine()
    {
        for(int i=0; i <3; i++)
        {
            fader.FadeOut(0.5f);
            yield return new WaitForSeconds(0.5f);
            fader.FadeIn(0.5f);
            yield return new WaitForSeconds(0.5f);
        }
        stopUpdate = false;
        yield return null;
        
    }
}
