//============================================================
// Reaction.cs
//======================================================================
// äJî≠óöó
//
// 2022/06/04 êßçÏäJén
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
