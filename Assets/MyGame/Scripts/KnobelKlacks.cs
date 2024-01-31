using System.Collections;
using UnityEngine;
using TMPro;

public class KnobelKlacks : MonoBehaviour
{

    private int currentNumber;
    private bool isGameRunning;
    private int highscore;

    public TextMeshProUGUI numberText;
    public TextMeshProUGUI resultText;

    private float timeBetweenNum = 3.0f;
    private float timeLeftForNum;

    private void Start()
    {
        StartNewLevel();
    }

    private void Update()
    {
        if (isGameRunning)
        {
            timeLeftForNum -= Time.deltaTime;

            if (Input.GetKeyDown(currentNumber.ToString()))
            {
                highscore++;
                StartNewLevel();
            }
            else if (timeLeftForNum <= 0 || !IsValidInput())
            {
                isGameRunning = false;
                resultText.text = "Highscore: " + highscore + ", du hast verloren, drücke 1 um neu zu starten";
            }
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            highscore = 0;
            StartNewLevel();
        }
    }

    private void StartNewLevel()
    {
        currentNumber = Random.Range(1, 7);
        numberText.text = currentNumber.ToString();
        resultText.text = "Spiel läuft!";
        timeLeftForNum = timeBetweenNum;
        isGameRunning = true;
    }

    private bool IsValidInput()
    {
        for (int i = 1; i <= 6; i++)
        {
            if (Input.GetKeyDown(i.ToString()) && i != currentNumber)
            {
                return false;
            }
        }
        return true;
    }
}
