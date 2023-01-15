using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Volume_Slider_RTPC : MonoBehaviour
{
    public UnityEngine.UI.Slider thisSlider;
    public float masterVolume;
    public float sfxVolume;
    public float musicVolume;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetRtpcVolume(string whatValue)
    {

        float sliderValue = thisSlider.value;

        if(whatValue == "Master")
        {
            masterVolume = thisSlider.value;
            AkSoundEngine.SetRTPCValue("MASTER", masterVolume);
        }

        if (whatValue == "Music")
        {
            musicVolume = thisSlider.value;
            AkSoundEngine.SetRTPCValue("MUSIC", musicVolume);
        }

        if (whatValue == "Sfx")
        {
            sfxVolume = thisSlider.value;
            AkSoundEngine.SetRTPCValue("SFX", sfxVolume);
        }



    }
}
