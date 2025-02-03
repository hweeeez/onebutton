using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatMap : MonoBehaviour

{

    public float songBpm;
    //The number of seconds for each song beat
    public float secPerBeat;
    //Current song position, in seconds
    public float songPosition;
    //Current song position, in beats
    public float songPositionInBeats;
    //How many seconds have passed since the song started
    public float dspSongTime;
    //an AudioSource attached to this GameObject that will play the music.
    public AudioSource musicSource;
    public float firstBeatOffset;
    public float beatsShownInAdvance;
    public float bpm;
    public float[] notes;
    int nextIndex = 0;
    public GameObject Blankey;
    // Start is called before the first frame update

    void Start()
    {
        musicSource = GetComponent<AudioSource>();
        //Calculate the number of seconds in each beat
        secPerBeat = 60f / songBpm;
        //Record the time when the music starts
        dspSongTime = (float)AudioSettings.dspTime;
        //Start the music
        musicSource.Play();

    }

    // Update is called once per frame
    void Update()
    {
        songPosition = (float)(AudioSettings.dspTime - dspSongTime - firstBeatOffset);
        //determine how many beats since the song started
        songPositionInBeats = songPosition / secPerBeat;
        if (nextIndex < notes.Length && notes[nextIndex] < songPositionInBeats + beatsShownInAdvance)
        {
            Instantiate(Blankey);

            //initialize the fields of the music note

            nextIndex++;
        }

    }
}
