using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class Music : MonoBehaviour
{
    public Slider BGMSlider;
    public AudioMixer mixer;

    [SerializeField] Toggle muteToggle;

    private void Start()
        {
            float db;

            if(mixer.GetFloat("BGM_VOL", out db))
                BGMSlider.value = (db + 80) / 80;
        }

    public void BGMVolume(float value)
        {
            value = value * 80 - 80;

            mixer.SetFloat("BGM_VOL",value);

            Debug.Log("BGM_VOL: " + value);
        }
    
    public void Mute()
    {
        if (muteToggle.isOn == true)
        {
            mixer.SetFloat("BGM_VOL", -80);
        }
        else
        {
            mixer.SetFloat("BGM_VOL", 0);
        }

        Debug.Log("now is mute" + muteToggle.isOn);
    }
}