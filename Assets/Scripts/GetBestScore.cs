using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetBestScore : MonoBehaviour
{
    private int recordToGet;
    public Text bestScoreText;

    void Update()
    {
        recordToGet = PlayerPrefs.GetInt("savescore");
        bestScoreText.text = ($"Your best score: {recordToGet}");
    }
}
