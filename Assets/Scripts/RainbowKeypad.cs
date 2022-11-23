using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RainbowKeypad : MonoBehaviour
{
    public string password = "1597";
    private string userInput = "";

    public AudioClip clickSound;
    public AudioClip openSound;
    public AudioClip errorSound;
    AudioSource audioSource;

    public UnityEvent OnEntryAllowed;

    private void Start()
    {
        userInput = "";
        audioSource = GetComponent<AudioSource>();
    }
    public void ButtonClicked(string number)
    {
        audioSource.PlayOneShot(clickSound);
        userInput += number;
        if (userInput.Length >= 4)
        {
            //check password
            if (userInput == password)
            {
                //TODO - invoke the event play a sound
                Debug.Log("Entry Allowed");
                audioSource.PlayOneShot(openSound);
                OnEntryAllowed.Invoke();
            }
            else
            {
                Debug.Log("Not this time");
                //TODO play sound
                userInput = "";
                audioSource.PlayOneShot(errorSound);
            }
        }

    }
}
