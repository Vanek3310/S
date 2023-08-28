using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public int minutes=1;
    public float seconds=30;
    //Попробовали так
    public TextMeshProUGUI timerText;
    private int roundSeconds;
    


    // Цикл обновления составляет примерно 0.01 секунды
    void Update()
    {
     
        seconds -= Time.deltaTime;

        if (seconds <= 0)
        {
            if (minutes > 0)
            {
                seconds += 59;

                minutes--;
            }
            else
            {
                // Если таймер остановился, перезагружаем текущую сцену
                int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneIndex);
            }
        }
        roundSeconds = Mathf.RoundToInt(seconds);
        timerText.text = minutes.ToString()  +":"+roundSeconds.ToString();
    }
}
