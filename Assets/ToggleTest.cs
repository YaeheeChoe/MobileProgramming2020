using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class ToggleTest : MonoBehaviour
{
    public GameObject TogObject;
    public Color changeColor;
    bool isOn = false;
    public void OnToggleOnOff()
    {   
        isOn = !isOn;
        if (isOn)
            TogObject.GetComponent<Renderer>().material.color = changeColor;
        else
            TogObject.GetComponent<Renderer>().material.color = Color.white;
        
    }
}
