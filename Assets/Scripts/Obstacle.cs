using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private float movespeed = 10f;
    [SerializeField] private float endpoint = -10;
    
    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position += new Vector3(0, 0, -1) * movespeed * Time.deltaTime;

        if (transform.position.z < endpoint)
        {
            Destroy(this.gameObject);
        }
    }
}
