//============================================================
// Menu.cs
//======================================================================
// ŠJ”­—š—ğ
//
// 2022/06/06 §ìŠJn
//
//======================================================================
using UnityEngine.SceneManagement;

public class Menu : Pause
{
    void Start()
    {
        InitUI();
    }

    public Menu OpenMenu(bool _pushpausebutton, bool _pushescbutton)
    {
        if (_pushpausebutton == true) bActiveUI = !bActiveUI;

        if (bActiveUI)
        {
            StopGame();
            if(_pushescbutton) InTitle();

        }

        else ContinueGame();

        return this;
    }

    void InTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
