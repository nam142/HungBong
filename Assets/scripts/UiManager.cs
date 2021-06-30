using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UiManager : MonoBehaviour
{
    public Text ScoreText;
    public GameObject gameoverpanel;
    // Start is called before the first frame update
    public void setScoreText(string txt)
    {
        if (ScoreText)
        {
            ScoreText.text = txt;
        }

    }
    public void ShowGameoverPanel(bool isShow)
    {
        if (gameoverpanel)
            gameoverpanel.SetActive(isShow);
    }
}
