using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    private AudioSource _audio;
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        _audio = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    public void PlayMusic()
    {
        if (_audio.isPlaying) return;
        _audio.Play();
    }

    // Update is called once per frame
    public void StopMusic()
    {
        _audio.Stop();
    }
}
