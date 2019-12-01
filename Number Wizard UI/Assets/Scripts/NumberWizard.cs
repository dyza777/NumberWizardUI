using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] Text guessText;
    [SerializeField] Text topText;

    int guess;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {

        guess = Random.Range(min, max + 1);
        guessText.text = "Загадал? Это " + guess.ToString() + "?";
    }


    public void OnHigherPress()
    {
        min = guess + 1;
        if (min <= max)
        {
            NextGuess();
        }

    }
    public void OnLowerPress()
    {
        max = guess;
        if (min <= max)
        {
            NextGuess();
        }

    }

    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = "Это " + guess.ToString() + "?";
        topText.text = "";
    }
}
