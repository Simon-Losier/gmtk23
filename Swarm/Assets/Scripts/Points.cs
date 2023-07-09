using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Points : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI goalText;
    public static int points;
    public int goal;
    // Start is called before the first frame update
    void Start()
    {
        points = 0;
        goalText.text = "Goal: " + goal;
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
