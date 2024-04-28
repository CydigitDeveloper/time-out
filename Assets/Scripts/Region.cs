using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Region : MonoBehaviour
{
    public ApocalypsesCard[] apocalypsesCards;
    public GameObject apocalypsesCard;
    public ApocalypsesManager apocalypsesManager;
    public bool isMirror;

    private void Start()
    {
        apocalypsesManager = FindObjectOfType<ApocalypsesManager>();

        int randomNumber = Random.Range(0, apocalypsesCards.Length);
        GetComponent<Button>().onClick.AddListener(() =>
        {
            apocalypsesCards[randomNumber].TriggerApocalypses();
        });
    }

    public void ClickPoint()
    {
        apocalypsesManager.LastError = this.gameObject;

        apocalypsesCard.SetActive(true);

        if (isMirror)
        {
            apocalypsesCard.transform.position = transform.position + new Vector3(-360, -160, 0);
        }
        else
        {
            apocalypsesCard.transform.position = transform.position + new Vector3(360, -160, 0);
        }
    }
}
