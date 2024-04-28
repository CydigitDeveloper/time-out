using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ailen : MonoBehaviour
{
    public AilensScore ailenScore;

    private void Start()
    {
        ailenScore = FindObjectOfType<AilensScore>();
    }

    private void Update()
    {
        transform.Translate(0f, 0.025f, 0f);
        Destroy(gameObject, 5f);
    }

    private void OnMouseDown()
    {
        ailenScore.ailensScore++;
        Destroy(gameObject);
    }
}
