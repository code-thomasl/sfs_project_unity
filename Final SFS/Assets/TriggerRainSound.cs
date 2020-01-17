using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRainSound : MonoBehaviour
{
    public AudioSource sound; // drag the rain sound here in the Inspector

    void Start()
    { // find it at Start:
      // supposing that the music player is named "MusicPlayer":
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        { // only an object tagged Player stops the sound
            sound.Play();
            Debug.Log("Player entered!");
        }
    }

    void OnTriggerExit2D(Collider2D other)
    //use ontriggerexit 2D instead of no 2D because of collider

    {
        if (other.tag == "Player")
        { // only an object tagged Player restarts the sound
            sound.Stop();
            Debug.Log("Player exit!");
        }
    }
}
