using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    public float duration;

    int _score = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (duration <= 1)
        {
            Time.timeScale = 0;
        }
        else
        {
            duration -= Time.deltaTime;
            timerText.text = "Timer: " + Mathf.FloorToInt(duration).ToString();
        }
    }

    public void UpdateScore(int points)
    {
        _score += points;
        scoreText.text = "Score: " + _score.ToString();
    }

}
