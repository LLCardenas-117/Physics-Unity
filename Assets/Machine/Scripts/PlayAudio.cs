using System.Collections;
using System.Diagnostics.Tracing;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    [SerializeField] GameObject audio;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        AudioSource source = audio.GetComponent<AudioSource>();
        if (audio.activeSelf == true) audio.SetActive(false);
        audio.SetActive(true);
        StartCoroutine(audioAdjuster(source, 2.0f));
    }

    public static IEnumerator audioAdjuster(AudioSource audioSource, float fadeTime)
    {
        audioSource.volume = 0.5f;
        while (audioSource.volume > 0.10)
        {
            audioSource.volume -= 1 * Time.deltaTime / fadeTime;
            yield return null;
        }
    }
}
