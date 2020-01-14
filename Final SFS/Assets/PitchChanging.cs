using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitchChanging : MonoBehaviour
{
    public int startingPitch = 4;
    public int timeToDecrease = 5;
    public bool decrease;
    AudioSource audioSource;

    void Start()
    {
        //Fetch the AudioSource from the GameObject
        audioSource = GetComponent<AudioSource>();


        //Initialize the pitch
        audioSource.pitch = startingPitch;

        decrease = Random.value > 0.5f;
        Debug.Log(decrease);
    }

    void Update()
    {
        //While the pitch is over 0, decrease it as time passes.
        if (audioSource.pitch > 0 && decrease == true)
        {
            audioSource.pitch -= Time.deltaTime * startingPitch / timeToDecrease;
        }
    }

}
