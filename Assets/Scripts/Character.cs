using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Character : MonoBehaviour
{
    private Quaternion qto;

    private Vector3 destination;

    public float speed;

    public float speedToMove;

    // Use this for initialization
    void Start()
    {
        destination = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            destination += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            destination += Vector3.down * speed * Time.deltaTime;
        }

        Vector3 target = new Vector3(destination.x - transform.position.x, destination.y - transform.position.y, destination.z - transform.position.z);
        qto = Quaternion.LookRotation(target);
        transform.position = Vector3.MoveTowards(transform.position, destination, speedToMove * Time.deltaTime);
    }
}


 

