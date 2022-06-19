//============================================================
// Controller.cs
//======================================================================
// �J������
//
// 2022/06/04 ����J�n
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

        //�A�N�V�����}�b�v����A�N�V�������擾
        _moveAction = actionMap["Move"];
        _lookAction = actionMap["Look"];
        _fireAction = actionMap["Fire"];
    }
}
