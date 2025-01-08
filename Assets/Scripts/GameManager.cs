using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public TextMeshProUGUI scoreText;

    int _score = 0;

    private void Start()
    {
        if(instance == null) 
        { 
            instance = this; 
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void UpdateScore(int points)
    {
        _score += points;
        scoreText.text = "Score: " + _score.ToString();
    }

}
