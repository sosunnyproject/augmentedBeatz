using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class AudioPlay : MonoBehaviour
{
        public AudioClip otherClip;
   IEnumerator Start()
    {
        AudioSource audio = GetComponent<AudioSource>(); audio.Play();
        yield return new WaitForSeconds(audio.clip.length);
        audio.clip = otherClip;
        audio.Play();
    }
}