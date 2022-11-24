using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplayAudio : MonoBehaviour
{
    public AudioClip replayAudio;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        audioSource.PlayOneShot(replayAudio);
    }
}
