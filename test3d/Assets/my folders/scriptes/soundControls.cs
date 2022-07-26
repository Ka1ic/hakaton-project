using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class soundControls : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup mixer;

    [SerializeField] private Slider slider;

    void Start()
    {
        mixer.audioMixer.GetFloat("masterVolume", out float value);

        slider.value = value;
    }

    public void changeVolume()
    {
        mixer.audioMixer.SetFloat("masterVolume", slider.value);
    }
}
