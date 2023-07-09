using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] private float time = 15f;

    [SerializeField] private TextMeshProUGUI timeText;
    // Start is called before the first frame update
    void Start()
    {
        timeText.text = "Time: " + time;
    }

    // Update is called once per frame
    void Update()
    {
        time -= 1 * Time.deltaTime;
        timeText.text = "Time: " + time;
        if (time <= 0)
        {
            SceneManager.LoadSceneAsync("Main Menu");
        }
    }
}
