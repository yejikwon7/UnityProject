using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class g2_time : MonoBehaviour
{
    [SerializeField] float setTime = 180.0f;
    [SerializeField] Text countdownText;

    [SerializeField]
    Text timerText;

    // Update is called once per frame
    void Update()
    {
        if (setTime > 0)
            setTime -= Time.deltaTime;

        else if (setTime <= 0)
            Time.timeScale = 0.0f;

        countdownText.text = Mathf.Round(setTime).ToString();
    }
}
