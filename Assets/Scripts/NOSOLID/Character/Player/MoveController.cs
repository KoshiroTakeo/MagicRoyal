//============================================================
// MoveController.cs
//======================================================================
// 開発履歴
//
// 2022/06/04 制作開始
//
//======================================================================
using UnityEngine;

public class MoveController
{
    // コントローラーによる移動(簡略化しよう)
    public void Move(Vector2 _vector2, Rigidbody2D _rigidbody2D, Transform _transform, float _speed, Animator _anim)
    {
        if (_vector2.x > 0)
        {
            _anim.SetBool("isMove", true);
            _rigidbody2D.AddForce(_transform.right * _vector2.x * _speed, ForceMode2D.Force);
            _transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (_vector2.x < 0)
        {
            _anim.SetBool("isMove", true);
            _rigidbody2D.AddForce(-_transform.right * _vector2.x * _speed, ForceMode2D.Force);
            Debug.Log(_rigidbody2D.velocity);
            _transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else
        {
            _anim.SetBool("isMove", false);
        }
        

        _anim.SetFloat("MoveX", _vector2.x);
    }

    // コントローラーによるジャンプ
    public void Jump(bool _jump, Rigidbody2D _rigidbody2D, float _jumppower, Animator _anim)
    { 
        //ふんわりジャンプに変更
        if (_jump) _rigidbody2D.AddForce(Vector2.up * _jumppower, ForceMode2D.Force);

        _anim.SetBool("Jump", _jump);
    }
}
