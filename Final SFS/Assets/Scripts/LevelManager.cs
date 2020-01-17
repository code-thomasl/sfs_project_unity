using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public float respawnDelay;
    public CharacterController2D gamePlayer;

    public static LevelManager instance;
    public GameObject gameOverText;
    public GameObject respawnParticles;

    public bool gameOver = false;

    public int coins;
    public int health;

    // Start is called before the first frame update
    void Awake()
    {
        gamePlayer = FindObjectOfType<CharacterController2D>();
        health = 3;

        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (health > 3)
        {
            health = 3;
        }

        if (gameOver == true && Input.GetButtonDown("Jump"))
        {
            health = 3;
            coins = 0;
            ScoreTextScript.coinAmount = 0;
            LifeTextScript.health = 3;

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void AddCoins(int numberOfCoins)
    {
        coins += numberOfCoins;
    }

    public void SquareDead()
    {

        gameOver = true;
        gameOverText.SetActive(true);
        gamePlayer.gameObject.SetActive(false);
    }

    public void RemoveLife()
    {
            //health += -1;

            //manage death
            if (health == 0)
            {
                SquareDead();
                Debug.Log("YOU ARE DEAD");
            }
    }

    public void RespawnBase()
    {
        gamePlayer.gameObject.SetActive(false);
        gamePlayer.transform.position = gamePlayer.respawnPoint;
        gamePlayer.gameObject.SetActive(true);
    }

    public void Respawn()
    {
        health += -1;


        //manage death
        if (health == 0)
        {
            SquareDead();
            Debug.Log("YOU ARE DEAD");
        }else
        {
            StartCoroutine(RespawnCoroutine());
        }

    }

    public IEnumerator RespawnCoroutine()
    {
        gamePlayer.gameObject.SetActive(false);

        yield return new WaitForSeconds(respawnDelay);
        Instantiate(respawnParticles, gamePlayer.respawnPoint, Quaternion.identity);
        FindObjectOfType<AudioManager2>().Play("PlayerRespawn");
        gamePlayer.transform.position = gamePlayer.respawnPoint;
        gamePlayer.gameObject.SetActive(true);


    }
}
