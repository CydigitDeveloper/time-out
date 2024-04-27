using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUIManager : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject apocalypsesCard;
    public ApocalypsesManager apocalypsesManager;

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
        SceneManager.LoadScene(apocalypsesManager.miniGameIndex);
    }
}
