using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{
    int max;
    int min;
    int guess;
    public Text textGuess;

    public Button buttonMore;
    public Button buttonLess;
    public Button buttonCorrect;

    // Start is called before the first frame update
    void Start()
    {
        max = 100;
        min = 1;
        guess = 50;

        buttonMore.onClick.AddListener(More);
        buttonLess.onClick.AddListener(Less);
        buttonCorrect.onClick.AddListener(Correct);
    }

    void More(){
        min = guess;
        guessNext();
        Debug.Log("More");
    }

    void Less()
    {
        max = guess;
        guessNext();
        Debug.Log("Less");
    }

    void Correct()
    {
        Debug.Log("Right guess");
        SceneManager.LoadScene("FinishedScene", LoadSceneMode.Single);
    }

    void guessNext()
    {
        guess = (min + max) / 2;
        textGuess.text = guess.ToString();
    }
}
