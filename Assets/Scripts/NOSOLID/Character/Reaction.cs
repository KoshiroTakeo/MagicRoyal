//============================================================
// Reaction.cs
//======================================================================
// 開発履歴
//
// 2022/06/04 制作開始
//
//======================================================================
using UnityEngine;

public class Reaction
{
    public void KnockBack(Rigidbody2D _rigidbody2D, Transform _player, Transform _obj, float _force)
    {
        Vector2 direction = _player.position - _obj.position;

        _rigidbody2D.AddForce(new Vector2(direction.x * _force, 0), ForceMode2D.Impulse);
    }
    
}
