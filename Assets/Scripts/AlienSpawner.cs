using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienSpawner : MonoBehaviour
{
    public GameObject aliens;

    public float xPos;

    public float aliensCounter = 20;

    private void OnEnable()
    {
        StartCoroutine(SpawnAlien());
    }

    public IEnumerator SpawnAlien()
    {
        while (aliensCounter > 0)
        {
            Instantiate(aliens, new Vector3(Random.Range(-xPos, xPos), -7f, 0f), Quaternion.identity);
            aliensCounter--;
            yield return new WaitForSeconds(Random.Range(1, 3));
        }
    }
}
