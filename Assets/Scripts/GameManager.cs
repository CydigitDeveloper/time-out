using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] Errors;

    float countdown;

    int randomTime, randomError;

    private void Start()
    {
        randomTime = Random.Range(5, 10);
        randomError = Random.Range(0, Errors.Length);
        countdown = randomTime;
    }

    private void Update()
    {
        if (countdown > 0)
        {
            countdown -= Time.deltaTime;
        }
        else
        {
            if (Errors[randomError].activeSelf)
            {
                randomTime = Random.Range(5, 10);
                randomError = Random.Range(0, Errors.Length);
                countdown = randomTime;
            }
            else
            {
                countdown = 0;
                Errors[randomError].SetActive(true);
                randomTime = Random.Range(5, 10);
                randomError = Random.Range(0, Errors.Length);
                countdown = randomTime;
            }
        }

    }
}
