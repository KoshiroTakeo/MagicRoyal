//============================================================
// GameOver.cs
//======================================================================
// äJî≠óöó
//
// 2022/06/06 êßçÏäJén
//
//======================================================================
using UnityEngine.SceneManagement;

public class GameOver : Pause
{


    void Start()
    {
        InitUI();
    }

    private void Update()
    {
        if(bActiveUI)
        {
            Invoke("InTitle", 3.0f);
        }
    }

    public GameOver OpenMenu(bool _pushbutton)
    {
        if (_pushbutton == true) bActiveUI = !bActiveUI;

        if (bActiveUI) StopGame();
        

        return this;
    }

    void InTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
