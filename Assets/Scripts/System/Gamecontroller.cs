//============================================================
// Player.cs
//======================================================================
// 開発履歴
//
// 2022/06/03 制作開始
//
//======================================================================
using UnityEngine;
using UnityEngine.InputSystem;

public class Gamecontroller : MonoBehaviour
{
    public PlayerInput ControllerData;
    bool bIsPose = false;

    // 入力種類
    InputAction MoveAction, JumpAction, AttackAction, PoseAction;

    //シーン上の操作プレイヤー（どっかで受けるようにする）

    PlayerAction Action;

    private void Start()
    {
        InitController(ControllerData = GetComponent<PlayerInput>());

    }

    private void Update()
    {
        if (PoseAction.triggered) bIsPose = !bIsPose;

        if (!bIsPose) // ゲーム中の処理
        {
            Debug.Log("ゲーム中");
            
        }
        else // ポーズ中の処理
        {
            Debug.Log("ポーズ中");
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
