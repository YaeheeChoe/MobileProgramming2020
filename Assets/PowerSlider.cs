using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerSlider : MonoBehaviour
{
    private Slider bar;
    public Text max_alert;
    // Start is called before the first frame update
    public void Upup()
    {
        bar.value = bar.value + 0.1f;
    }
    void Start()
    {
        bar = transform.GetComponent<Slider>();
        StartCoroutine(PowerDown());
    }
    void Update()
    {
        if (bar.value > 0.999f)
            max_alert.color =new Color(161, 0, 0, 1);
        else
            max_alert.color = new Color(161, 0, 0, 0);
    }

    IEnumerator PowerDown()
    {
        while(true)
        {
            bar.value = bar.value - 0.1f;
            yield return new WaitForSeconds(1f);
        }
        
    }
}
