using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource[] speakers;
    public AudioClip[] musicTracks;

    private int currentTrackIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        if(speakers.Length !=4 || musicTracks.Length == 0)
        {
            Debug.LogError("Please assign four speakers and at least one music track");
            return;
        }

        for(int i = 0; i<speakers.Length; i++)
        {
            speakers[i].clip = musicTracks[currentTrackIndex];
        }
        PlayMusic();
    }

    // Update is called once per frame
    void Update()
    {
        if (!speakers[0].isPlaying)
        {
            //the modulus sign ensures that the song index does not go out of bounds
            currentTrackIndex = (currentTrackIndex + 1) % musicTracks.Length;
            for(int i = 0; i < speakers.Length; i++)
            {
                speakers[i].clip = musicTracks[currentTrackIndex];
            }
            PlayMusic();
        }
    }

    void PlayMusic()
    {
        for(int i = 0; i< speakers.Length; i++)
        {
            speakers[i].Play();
        }
    }
}
