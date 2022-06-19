//============================================================
// SceneTransitionManager.cs
//======================================================================
// 開発履歴
//
// 2022/06/04 制作開始
//
//======================================================================
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class SceneTransitionManager : MonoBehaviour
{
    [SerializeField] PlayerInput InputData;
    InputAction _menuAction, _exitAction;


    void Start()
    {
        InitController(InputData);
    }

    void Update()
    {

        if (SceneManager.GetActiveScene().name == "TitleScene")
        {
            
            if (_menuAction.triggered)
            {
                InGame();
                
            }

            if(_exitAction.triggered)
            {
                Application.Quit();
            }
        }

        
    }

    void InGame()
    {
        SceneManager.LoadScene("1-1");
    }

    void InTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }

    // 操作設定 =================================
    void InitController(PlayerInput _input)
    {
        var actionMap = _input.currentActionMap;

        //アクションマップからアクションを取得
        _menuAction = actionMap["Jump"];
        _exitAction = actionMap["Exit"];

    }
    //===========================================
}

