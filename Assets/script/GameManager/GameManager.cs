using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TimerText TimerTextUI;
    public GameOverUI GameOverUI;
    private bool _isOver;

    private void Update()
    {
        if (_isOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void End()
    {
        // Ÿ�̸� ����
        TimerTextUI.IsOn = false;

        // ������ ����
        int saveBestTime = PlayerPrefs.GetInt("BestTime", 0);
        int bestTime = Math.Max((int)TimerTextUI.SurvivalTime, saveBestTime);


        PlayerPrefs.SetInt("BestTime", bestTime);
            
        
        // GameOverUI���ٰ� ����
        GameOverUI.Activate(bestTime);
        

        // _isOver = true;
        _isOver = true;
    }

    
}
