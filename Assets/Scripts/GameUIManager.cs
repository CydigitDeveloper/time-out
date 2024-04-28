using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUIManager : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject apocalypsesCard;
    public GameObject mainGameAsset;
    public ApocalypsesManager apocalypsesManager;
    public AlienSpawner ailenSpawner;

    public void AnyClick()
    {
        menuPanel.SetActive(false);
        apocalypsesCard.SetActive(false);
    }

    public void MenuButton()
    {
        menuPanel.SetActive(true);
        apocalypsesCard.SetActive(false);
    }

    public void BackButton()
    {
        apocalypsesCard.SetActive(false);
    }

    public void StartButton()
    {
        apocalypsesCard.SetActive(false);
        apocalypsesManager.apocalypsesScene.SetActive(true);
        mainGameAsset.SetActive(false);

        if (apocalypsesManager.id == 1)
        {
            ailenSpawner.enabled = true;
        }
    }
}
