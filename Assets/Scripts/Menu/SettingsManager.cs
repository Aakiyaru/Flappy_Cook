using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    public Dropdown GraphicsQuality;
    public Toggle RTX;
    public Text RTXtext;
    public Scrollbar Scale;
    
    void Start()
    {
        //Graphics Quality
        GraphicsQuality.value = PlayerPrefs.GetInt("savequality");

        //RTX
        if (PlayerPrefs.GetInt("saveRTX") == 1)
        {
            RTX.isOn = true;
            RTXtext.text = "On";
        }
        else
        {
            RTX.isOn = false;
            RTXtext.text = "Off";
        }

        //Scale
        Scale.value = PlayerPrefs.GetFloat("savescale");
    }

    void Update()
    {
        //Graphics Quality
        int quality = GraphicsQuality.value;
        PlayerPrefs.SetInt("savequality", quality);

        //RTX
        int RTXbool;

        if (RTX.isOn)
        {
            RTXbool = 1;
            RTXtext.text = "On";
        }
        else
        {
            RTXbool = 0;
            RTXtext.text = "Off";
        }

        PlayerPrefs.SetInt("saveRTX", RTXbool);

        //Scale
        float scale = Scale.value;
        PlayerPrefs.SetFloat("savescale", scale);
    }
}
