using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundKeypadButtons : MonoBehaviour
{

    public AudioClip buttonBeep;
    AudioSource audiosource;
    private void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    public void ButtonClicked()
    {
        audiosource.PlayOneShot(buttonBeep);
    }
}
