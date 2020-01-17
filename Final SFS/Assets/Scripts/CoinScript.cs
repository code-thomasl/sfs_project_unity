using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{

    private LevelManager gameLevelManager;
    public int coinValue;
    public int soundSelect;

    // Start is called before the first frame update
    void Start()
    {
        gameLevelManager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        soundSelect = Random.Range(1, 4);
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
            switch (soundSelect)
            {
                case 1:
                    FindObjectOfType<AudioManager2>().Play("CollectObject");
                    break;
                case 2:
                    FindObjectOfType<AudioManager2>().Play("CollectObject2");
                    break;
                case 3:
                    FindObjectOfType<AudioManager2>().Play("CollectObject3");
                    break;
            }

            Destroy(gameObject);
        }
    }
}
