using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAudio : MonoBehaviour
{
    public AudioSource audioPlayer;

    public AudioClip eatClip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void replayBGM()
    {
        audioPlayer.Play();
    }

    public void PlayEatSound()
    {
        audioPlayer.PlayOneShot(eatClip);
    }

}
