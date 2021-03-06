//============================================================
// CameraManager.cs
//======================================================================
// 開発履歴
//
// 2022/06/05 制作開始
//
//======================================================================
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    Transform Player;
    Vector3 SetPlayerPos;
    
    

    
    void Start()
    {
        Player = GameObject.FindWithTag("Player").transform;
        SetPlayerPos = Player.position;
    }

    // Update is called once per frame
    void Update()
    {
        Follower(Player);
        
    }

    public void Follower(Transform _player)
    {
        transform.position = new Vector3(_player.position.x, SetPlayerPos.y + 2, -10);
    }
}
