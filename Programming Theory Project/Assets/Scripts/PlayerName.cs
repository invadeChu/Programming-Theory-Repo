using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerName : MonoBehaviour
{
    public void SetPlayerName()
    {
        GameObject textInputObject = GameObject.Find("Player Name Text");
        string s = textInputObject.GetComponent<TextMeshProUGUI>().text;
        GameObject.Find("Game Manager").GetComponent<GameManager>().playerName = s;
        GameObject.Find("Game Manager").GetComponent<GameManager>().nameIsSet = true;
    }
}
