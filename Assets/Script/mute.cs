using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mute : MonoBehaviour
{
     private AudioSource audioSource;
    private bool isMuted = false;

    void Start()
    {
        audioSource = GameObject.Find("music").GetComponent<AudioSource>();
    }

    public void muteIt()
    {
        isMuted = !isMuted;
        audioSource.mute = isMuted;
    }
}
