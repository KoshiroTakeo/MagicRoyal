//============================================================
// PlayerManager.cs
//======================================================================
// 開発履歴
//
// 2022/06/04 制作開始
// 2022/06/06 見直し
// 2022/06/14 見
//
//======================================================================
using UnityEngine;
using UnityEngine.InputSystem;

namespace Players
{
    public class PlayerManager : Character
    {
        PlayerInput InputData;
        InputAction _moveAction, _lookAction, _fireAction, _jumpAction, _menuAction, _exitAction;

        MoveController Contoroller;
        BulletAttack CreateBullet;

        [SerializeField] Menu Pause;
        [SerializeField] GameOver GameOverPause;

        [SerializeField] GameObject Mazzle;

        public string Field;



        void Start()
        {
            InitStatus();

            InitController(InputData = GetComponent<PlayerInput>());

            Contoroller = new MoveController();

            CreateBullet = new BulletAttack();

        }


        void Update()
        {
            HPChecker();

            ExpChecker();

            GameOverPause = GameOverPause.OpenMenu(fHP < 0);

            Contoroller.Move(_moveAction.ReadValue<Vector2>(), Rb2D, this.transform, fSPD, Anim);
            Contoroller.Jump(_jumpAction.triggered, Rb2D, fJumpPower, Anim);
            if (_jumpAction.triggered) sound.Jump(this.gameObject);

            Pause = Pause.OpenMenu(_menuAction.triggered, _exitAction.triggered);

            if (_fireAction.triggered)
            {
                sound.Attack(this.gameObject);
                CreateBullet.Bullet(Mazzle, transform.localScale / 3, this.transform, (int)eType, fATK, fBulletSpeed, Anim);
            }

            Fall();
        }




        //あたり判定取得*************************************
        private void OnCollisionEnter2D(Collision2D collision)
        {

        }

        // 操作設定 =================================
        void InitController(PlayerInput _input)
        {
            var actionMap = _input.currentActionMap;

            //アクションマップからアクションを取得
            _moveAction = actionMap["Move"];
            _lookAction = actionMap["Look"];
            _fireAction = actionMap["Fire"];
            _jumpAction = actionMap["Jump"];
            _menuAction = actionMap["Menu"];
            _exitAction = actionMap["Exit"];

        }
        //===========================================



        private void OnCollisionStay2D(Collision2D collision)
        {
            Field = collision.gameObject.tag;
        }

        private void OnCollisionExit2D(Collision2D collision)
        {
            Field = null;
        }
        //***************************************************



        //リスポーン*****************************************
        public void Respown()
        {
            //ここに最後に触れた床へ戻す処理
            transform.position = new Vector3(-5.5f, 0, 0);

        }
        //***************************************************

        //奈落に落ちたとき************************************
        void Fall()
        {
            if (transform.position.y <= -5)
            {
                //割合ダメージ
                fHP -= fHP % 5;
                Respown();
            }
        }
        //****************************************************

        ////*****************************************************
        // void StatusCheck()
        // {
        //     LifeGauge.fillAmount = (float)currentLife / (float)Status.Life;
        // }
        // //****************************************************


    }

}

