using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    //�X�R�A
    public int Score;
    public Text scoreText;

    
    void Start()
    {
        //scoreText = GameObject.FindWithTag("UI").transform.Find("Score").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //�X�R�A���Z
    public void AddScore(int num)
    {
        Score += num;
        scoreText.text = Score.ToString();
        Debug.Log("Score : " + Score);
    }
}
