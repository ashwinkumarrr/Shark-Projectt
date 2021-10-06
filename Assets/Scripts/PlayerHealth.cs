using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static float healthAmount;
    Animator anim;
    public AudioSource song;
    public AudioClip hitSound;

    void Start()
    {
        healthAmount = 1;

    }


    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag.Equals("enemy"))
        {
            healthAmount -= 0.1f;

            if (healthAmount < 0)
            {
                Destroy(gameObject);
                healthAmount = 0;
            }


        }


    }
}
