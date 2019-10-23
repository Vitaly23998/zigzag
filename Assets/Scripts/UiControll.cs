using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UiControll : MonoBehaviour
{
    public TextMeshProUGUI Scoretext;
    public TextMeshProUGUI RestartGame;
    int tempScore;

    private void Start()
    {
        RestartGame.CrossFadeAlpha(0, 0.01f, false);
        tempScore = 0;
    }

    private void Update()
    {
        UiScoreNumber();
        UDied();
    }

    void UiScoreNumber()
    {
        if (ScoreService.Score > tempScore)
        {
            tempScore = ScoreService.Score;
            Scoretext.text = ScoreService.Score.ToString();
        }
    }

    void UDied()
    {
        if(PlayerController.die == true)
        {
            RestartGame.CrossFadeAlpha(1, 1, false);
            if (Input.GetMouseButtonDown(0))
                SceneManager.LoadScene(0);
        }
       
    }

}
