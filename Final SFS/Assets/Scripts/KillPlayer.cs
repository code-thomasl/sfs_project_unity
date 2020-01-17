using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;
    private LevelManager gameLevelManager;
    public GameObject explosion;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player")) {
            //collision.transform.position = spawnPoint.position;

            Instantiate(explosion, transform.position, Quaternion.identity);
            LifeTextScript.health += -1;


            FindObjectOfType<AudioManager2>().Play("PlayerDeathCollision");

            //gameLevelManager.RemoveLife();
            LevelManager.instance.Respawn();
            LevelManager.instance.RemoveLife();

        }
    }

}
