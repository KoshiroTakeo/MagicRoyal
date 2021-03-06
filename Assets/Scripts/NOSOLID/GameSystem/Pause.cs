//============================================================
// Pause.cs
//======================================================================
// 開発履歴
//
// 2022/06/06 制作開始
//
//======================================================================
using UnityEngine;

public  abstract class Pause : MonoBehaviour
{
    [SerializeField] GameObject pauseUI;
    protected bool bActiveUI;

    protected void InitUI()
    {
        bActiveUI = false;
        pauseUI.SetActive(false);
    }

    protected void StopGame()
    {
        Time.timeScale = 0f;
        pauseUI.SetActive(true);
    }

    protected void ContinueGame()
    {
        Time.timeScale = 1.0f;
        pauseUI.SetActive(false);
    }

    
}

