using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayerIntoVoid : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;
    private LevelManager gameLevelManager;
    public GameObject explosion;
    private GameObject player = null;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        player = GameObject.Find("Player");
        // get player position


        if (collision.transform.CompareTag("Player"))
        {
            //collision.transform.position = spawnPoint.position;

            //Instantiate(explosion, position: player.transform.position, rotation: Quaternion.identity);
            Instantiate(explosion, collision.transform.position, rotation: Quaternion.identity);

            LifeTextScript.health += -1;


            FindObjectOfType<AudioManager2>().Play("PlayerDeathVoid");

            //gameLevelManager.RemoveLife();
            LevelManager.instance.Respawn();
            LevelManager.instance.RemoveLife();

        }
    }

}
