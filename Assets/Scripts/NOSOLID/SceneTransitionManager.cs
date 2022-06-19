//============================================================
// SceneTransitionManager.cs
//======================================================================
// �J������
//
// 2022/06/04 ����J�n
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

    // ����ݒ� =================================
    void InitController(PlayerInput _input)
    {
        var actionMap = _input.currentActionMap;

        //�A�N�V�����}�b�v����A�N�V�������擾
        _menuAction = actionMap["Jump"];
        _exitAction = actionMap["Exit"];

    }
    //===========================================
}

