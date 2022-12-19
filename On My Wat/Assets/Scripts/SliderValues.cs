using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValues : MonoBehaviour
{
    Text text;
    
    
    void Awake()
    {
        text = GetComponent<Text>();
    }

    
    void Update()
    {
        
    }

    public void UpdateText(float newvalue)
    {
        text.text = newvalue.ToString();
    }
}
