using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallKick : MonoBehaviour
{
    public KickImpact kickImpact;
    AudioSource audioSource;
    public GameObject audioObject;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    void callKick()
    {
        Debug.Log("Kick called");
        kickImpact.ActivateKick();
    }
    void PlaySound()
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
