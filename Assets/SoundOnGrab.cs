using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnGrab : MonoBehaviour
{
    public AudioClip phoneRingSound;

    private bool isGrabbed = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!isGrabbed && other.CompareTag("Hand")) // Assurez-vous d'ajuster le tag en fonction de votre scène VR
        {
            isGrabbed = true;
            PlayPhoneRingSound();
        }
    }

    private void PlayPhoneRingSound()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        if (audioSource != null && phoneRingSound != null)
        {
            audioSource.clip = phoneRingSound;
            audioSource.Play();
        }
    }
}
