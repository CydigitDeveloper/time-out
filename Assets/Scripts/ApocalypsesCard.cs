using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ApocalypsesCard : MonoBehaviour
{
    public Apocalypses apocalypses;

    public void TriggerApocalypses()
    {
        FindObjectOfType<ApocalypsesManager>().StartApocalypses(apocalypses);
    }
}
