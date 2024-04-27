using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ApocalypsesManager : MonoBehaviour
{
    public Image apocalypsesImage;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    public int miniGameIndex;

    public void StartApocalypses(Apocalypses apocalypses)
    {
        apocalypsesImage.sprite = apocalypses.apocalypsesImage;
        nameText.text = apocalypses.apocalypsesName;
        descriptionText.text = apocalypses.apocalypsesDescription;
        miniGameIndex = apocalypses.apocalypsesIndex;
    }
}
