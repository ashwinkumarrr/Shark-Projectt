using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerObject : MonoBehaviour
{
    public GameObject objectToDestroy;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "GoodFish")
        {
            Destroy(collision.gameObject);
        }
    }
    
}
