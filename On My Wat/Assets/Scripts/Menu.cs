using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class Menu : MonoBehaviour
{

    public Slider slider1;
    public Toggle toggle1;

    public int numero;

    public float sliderValue;

    void Start()
    {
        Values();
        ToggleOn();
        slider1.onValueChanged.AddListener(SetSlider);
        toggle1?.onValueChanged.AddListener(ChangeToggle);
    }


    void Values()
    {
        slider1.value = PlayerPrefs.GetFloat("save" + numero, sliderValue);
    }

    public void SetSlider(float value)
    {
        sliderValue = value;
        PlayerPrefs.SetFloat("save" + numero , sliderValue);
    }

    public void ChangeToggle(bool value)
    {
        PlayerPrefs.SetInt("IsOn" + numero, (toggle1.isOn ? 1 : 0));
    }

    public void ToggleOn()
    {
        if (!toggle1)
        {
            return;
        }
        toggle1.isOn = PlayerPrefs.GetInt("IsOn" + numero,  0) == 1;

    }


    public void ChanceScene()
    {
        SceneManager.LoadScene("Simulacion");
    }











}
