using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicChange : MonoBehaviour
{
        public AudioSource mySource;
        public int rangeScan;
        public AudioClip[] myAudio;
        public int toPlay;
        public bool debugging;

        void OnEnable()
        {
            toPlay = Random.Range(0, rangeScan);
            if (debugging)
            {
                foreach (AudioClip value in myAudio)
                {
                    print(value);
                }
            }
            mySource.loop = true;
            //mySource.PlayOneShot(myAudio[toPlay], 1F);
            mySource.clip = myAudio[toPlay];
            mySource.volume = 1f;
            //mySource.PlayScheduled(AudioSettings.dspTime + myAudio[toPlay].length);
            mySource.Play();

            Debug.Log(mySource.loop);
    }
}

