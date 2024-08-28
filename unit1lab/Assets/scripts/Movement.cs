using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3Data Vector3Data;

    public float speed = 3.0f;

    private Rigidbody healthPowerRb;
    private GameObject player;

    void Start()
    {
        healthPowerRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        healthPowerRb.AddForce(lookDirection * speed);
    }
}
