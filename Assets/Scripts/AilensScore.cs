using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AilensScore : MonoBehaviour
{
    public GameObject mainGameAsset;
    public GameObject miniGame1Asset;
    public ApocalypsesManager apocalypsesManager;
    public AlienSpawner alienSpawner;

    public float ailensScore = 0f;
    public float loseScore = 0f;

    private void Update()
    {
        if (loseScore == 5)
        {
            ailensScore = 0f;
            loseScore = 0f;
            alienSpawner.aliensCounter = 20;
            mainGameAsset.SetActive(true);
            miniGame1Asset.SetActive(false);
            apocalypsesManager.LastError.SetActive(false);
        }

        if (ailensScore == 15)
        {
            ailensScore = 0f;
            ailensScore = 0f;
            alienSpawner.aliensCounter = 20;
            mainGameAsset.SetActive(true);
            miniGame1Asset.SetActive(false);
            apocalypsesManager.LastError.SetActive(false);
        }
    }
}
