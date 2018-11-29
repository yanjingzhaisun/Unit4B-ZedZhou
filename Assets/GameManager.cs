using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    float timer;
    public float healthPercentage;
    public float infectionSpeed;
    // Use this for initialization
    void Start()
    {
        timer = 0;
        healthPercentage = 1f; //100%
        infectionSpeed = 0.005f; //0.5%
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1f)
        {
            Debug.Log("1 second!");
            timer = 0;
            healthPercentage -= infectionSpeed;
        }
    }
}
