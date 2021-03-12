using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class PowerButton : MonoBehaviour
{
    public PowerSlider[] bar = new PowerSlider[3];
    private int choice =1;
    public void choiceBar(int n)
    {
        choice = n;
    }
    void Start()
    {
        
    }

    public void OnClick()
    {
        bar[choice].Upup();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
