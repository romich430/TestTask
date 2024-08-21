using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private float movespeed = 5f;
    [SerializeField] private int score;

    private void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -7f, 7f), transform.position.y,
            transform.position.z);
        
        if (Input.touchCount > 0)
        {
            if (Camera.main.ScreenToViewportPoint(Input.GetTouch(0).position).x < 0.5f)
            {
                transform.position += new Vector3(-1, 0) * movespeed * Time.deltaTime;
            }
            else
            {
                transform.position += new Vector3(1, 0) * movespeed * Time.deltaTime;
            }
        }
        #if UNITY_EDITOR
        if (Input.GetMouseButton(0))
        {
            Debug.Log(Input.mousePosition);
            if (Camera.main.ScreenToViewportPoint(Input.mousePosition).x < 0.5f)
            {
                transform.position += new Vector3(-movespeed * Time.deltaTime, 0);
            }
            else
            {
                transform.position += new Vector3(movespeed * Time.deltaTime, 0);
            }
        }
        #endif
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            GameOver();
        }

        if (other.gameObject.tag == "Coin")
        {
            score += 1;
            GameUIManager.instance.UpdateScore(score);
            Destroy(other.gameObject);
        }
    }

    private void GameOver()
    {
        Time.timeScale = 0f;
        GameUIManager.instance.ActivateGameOver(score);
    }
}
