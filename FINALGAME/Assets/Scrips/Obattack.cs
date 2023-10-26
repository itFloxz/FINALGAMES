using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Obattack : MonoBehaviour
{

    public AudioSource DieAttack;
    private void OnTriggerEnter(Collider target)
    {
        if (target.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene("Restart");
        }

    }

}