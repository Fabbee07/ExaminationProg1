using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Reference to the TextMeshPro text component
    private int score = 0; // Current score

    // Update the displayed score text
    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }

    // Method to increase the score
    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }
}