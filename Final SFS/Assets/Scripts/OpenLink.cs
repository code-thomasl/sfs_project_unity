using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLink : MonoBehaviour
{
    public void PlayTheSound()
    {
        FindObjectOfType<AudioManager>().Play("SecretSound");
    }

    public void OpenChannel()
    {
        Application.OpenURL("https://soundcloud.com/monsie_ur/sets/training-sessions-ii");
    }
}
