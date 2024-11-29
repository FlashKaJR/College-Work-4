using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkAudio : MonoBehaviour
{
    AudioSource audioSource;
    public GameObject audioObject;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void PlayWalkSound()
    {
        if (audioObject != null)
        {
            audioObject.GetComponent<AudioSource>().Play();
        }
        if (audioObject == null)
        {
            audioSource.Play();
        }

    }
}
