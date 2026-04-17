using System.Collections;
using System.Diagnostics.Tracing;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class ChangeAudioAndPlay : MonoBehaviour
{
    [Header("Change Audio")]
    [SerializeField] GameObject audio;
    [SerializeField] AudioClip audioClip;
    [SerializeField] float volume = 0.15f;

    [Header("Turn off main Audio")]
    [SerializeField] bool turnOffAudio = false;
    [SerializeField] GameObject mainAudio;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(turnOffAudio) mainAudio.SetActive(false);

        AudioSource source = audio.GetComponent<AudioSource>();
        if (audio.activeSelf == true) audio.SetActive(false);
        source.clip = audioClip;
        source.volume = volume;
        audio.SetActive(true);
    }
}
