using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class Coin : MonoBehaviour
{
    public int score;   
    public Text scoreText;
    public AudioSource Pickcoin;
    private void Start()
    {
        score = 0;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Item")
        {
            score++;
            scoreText.text = " Score =  " + score;
            Pickcoin.Play();
            Destroy(other.gameObject);

        }

    }


}

