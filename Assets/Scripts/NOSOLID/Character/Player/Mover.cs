//============================================================
// Mover.cs
//======================================================================
// 開発履歴
//
// 2022/06/14 制作開始
//
//======================================================================
using UnityEngine;

namespace Characters
{
    public class Mover
    {
        public Vector3 Move(Vector2 _vector2, Transform _transform)
        {
            Vector3 vector3 = new Vector3();

            vector3 = _transform.right * _vector2.x;
            _transform.eulerAngles = new Vector3(0, 0, 0);

            return vector3;

            
        }
    }
    
}


