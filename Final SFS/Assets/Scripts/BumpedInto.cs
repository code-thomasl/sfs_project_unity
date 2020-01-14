using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpedInto : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
            FindObjectOfType<AudioManager>().Play("PlayerBump");
    }
}
