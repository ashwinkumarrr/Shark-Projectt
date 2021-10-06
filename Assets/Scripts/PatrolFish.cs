using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolFish : MonoBehaviour
{
    public float speed;

    public bool MoveRight;

    void Update()
    {
        if (MoveRight)
        {
            transform.Translate(2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(13, 13);
        }
        else
        {
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(-13, 13);
        }

    }

    void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.CompareTag("Turn"))
        {
            if (MoveRight)
            {
                MoveRight = false;
            }
            else
            {
                MoveRight = true;
            }
        }



    }


}
