using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AilensEnd : MonoBehaviour
{
    public AilensScore ailensScore;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ailen"))
        {
            ailensScore.loseScore++;
        }
    }
}
