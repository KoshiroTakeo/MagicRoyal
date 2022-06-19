//============================================================
// Controller.cs
//======================================================================
// 開発履歴
//
// 2022/06/04 制作開始
//
//======================================================================
using UnityEngine;
using UnityEngine.InputSystem;

public class Controller 
{
    PlayerInput InputData;
    InputAction _moveAction, _lookAction, _fireAction;

    public void InitController(GameObject _player)
    {
        InputData = _player.GetComponent<PlayerInput>();
        var actionMap = InputData.currentActionMap;

        //アクションマップからアクションを取得
        _moveAction = actionMap["Move"];
        _lookAction = actionMap["Look"];
        _fireAction = actionMap["Fire"];
    }
}
