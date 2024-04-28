using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ApocalypsesManager : MonoBehaviour
{
    public int id;
    public Image apocalypsesImage;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    public GameObject apocalypsesScene;
    public GameObject LastError;

    public void StartApocalypses(Apocalypses apocalypses)
    {
        id = apocalypses.apocalypsesId;
        apocalypsesImage.sprite = apocalypses.apocalypsesImage;
        nameText.text = apocalypses.apocalypsesName;
        descriptionText.text = apocalypses.apocalypsesDescription;
        apocalypsesScene = apocalypses.apocalypsesPrefab;
    }
}
