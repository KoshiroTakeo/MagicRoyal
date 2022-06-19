//============================================================
// Player.cs
//======================================================================
// �J������
//
// 2022/06/03 ����J�n
//
//======================================================================
using UnityEngine;
using UnityEngine.InputSystem;

public class Gamecontroller : MonoBehaviour
{
    public PlayerInput ControllerData;
    bool bIsPose = false;

    // ���͎��
    InputAction MoveAction, JumpAction, AttackAction, PoseAction;

    //�V�[����̑���v���C���[�i�ǂ����Ŏ󂯂�悤�ɂ���j

    PlayerAction Action;

    private void Start()
    {
        InitController(ControllerData = GetComponent<PlayerInput>());

    }

    private void Update()
    {
        if (PoseAction.triggered) bIsPose = !bIsPose;

        if (!bIsPose) // �Q�[�����̏���
        {
            Debug.Log("�Q�[����");
            
        }
        else // �|�[�Y���̏���
        {
            Debug.Log("�|�[�Y��");
        }
    }

    void InitController(PlayerInput _input)
    {
        var actionMap = _input.currentActionMap;

        MoveAction = actionMap["Move"];
        JumpAction = actionMap["Jump"];
        AttackAction = actionMap["Fire"];
        PoseAction = actionMap["Pose"];
    }
}
