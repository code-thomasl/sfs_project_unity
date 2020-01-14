using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{

    private LevelManager gameLevelManager;
    public int coinValue;

    // Start is called before the first frame update
    void Start()
    {
        gameLevelManager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            //ScoreScript.scoreValue += 10;
            //SoundManagerScript.PlaySound("");
            gameLevelManager.AddCoins(coinValue);
            ScoreTextScript.coinAmount += 1;
            FindObjectOfType<AudioManager>().Play("PlayerCollect");

            Destroy(gameObject);
        }
    }
}
