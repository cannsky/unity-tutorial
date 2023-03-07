using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class MusicManager
{
    public List<AudioClip> backgroundMusicAudioClips;
    public AudioSource backgroundMusicAudioSource;
    public float musicChangeTime, musicMaxVolume, musicVolumeChangeTime;

    private bool isChanging;
    private float changeTimer;

    public void Start() => SetNewMusic();

    public void Update()
    {
        if (isChanging) return;
        changeTimer += Time.deltaTime;
        if (changeTimer >= musicChangeTime) ChangeMusic();
    }

    public void ChangeMusic()
    {
        isChanging = true;
        changeTimer = 0;
        GameManager.Instance.StartCoroutine(DecreaseVolume());
    }

    public void SetNewMusic()
    {
        backgroundMusicAudioSource.Stop();
        backgroundMusicAudioSource.clip = backgroundMusicAudioClips[UnityEngine.Random.Range(0, backgroundMusicAudioClips.Count)];
        backgroundMusicAudioSource.Play();
        GameManager.Instance.StartCoroutine(IncreaseVolume());
    }

    IEnumerator IncreaseVolume()
    {
        while (backgroundMusicAudioSource.volume < musicMaxVolume)
        {
            backgroundMusicAudioSource.volume += musicMaxVolume / musicVolumeChangeTime * Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        if (backgroundMusicAudioSource.volume >= musicMaxVolume) isChanging = false;
    }

    IEnumerator DecreaseVolume()
    {
        while(backgroundMusicAudioSource.volume != 0)
        {
            backgroundMusicAudioSource.volume -= musicMaxVolume / musicVolumeChangeTime * Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        SetNewMusic();
    }
}
