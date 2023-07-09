using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Points : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public static int points;
    public int maxScore;
    // Start is called before the first frame update
    void Start()
    {
        points = 0;
    }

    public static void AddPoints(int addedPoints)
    {
        points += addedPoints;
    }

    public void UpdateScore()
    {
        scoreText.text = "Points: " + points;
    }
    
    // Update is called once per frame
    void Update()
    {
        UpdateScore();
    }
}
