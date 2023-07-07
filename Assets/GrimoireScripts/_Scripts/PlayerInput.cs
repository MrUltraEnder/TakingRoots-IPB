using UnityEngine;

#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#endif

namespace GrimoireScripts
{
    public class PlayerInput : MonoBehaviour
    {
        public FrameInput FrameInput { get; private set; }

        private void Update() => FrameInput = Gather();

#if ENABLE_INPUT_SYSTEM
        [SerializeField] bool _player1 = true;
        private Players _actions;
        private InputAction _move, _jump, _dash, _attack, _exampleAction, _salir;
        public InputAction Attack => _attack;

        private void Awake()
        {
            _actions = new Players();
            if (_player1)
            {
                _move = _actions.Player1.Movement;
                _jump = _actions.Player1.Jump;
                _dash = _actions.Player1.Dash;
                _attack = _actions.Player1.Attack;
            }
            else
            {
                _move = _actions.Player2.Movement;
                _jump = _actions.Player2.Jump;
                _dash = _actions.Player2.Dash;
                _attack = _actions.Player2.Attack;
            }
            _salir = _actions.Player1.Salir;

        }


        private void OnEnable() => _actions.Enable();

        private void OnDisable() => _actions.Disable();

        private FrameInput Gather()
        {
            return new FrameInput
            {
                JumpDown = _jump.WasPressedThisFrame(),
                JumpHeld = _jump.IsPressed(),
                DashDown = _dash.WasPressedThisFrame(),
                AttackDown = _attack.WasPressedThisFrame(),
                Move = _move.ReadValue<Vector2>(),
                Salir = _salir.WasPressedThisFrame(),

            };
        }

#elif ENABLE_LEGACY_INPUT_MANAGER
        private FrameInput Gather() {
            return new FrameInput {
                JumpDown = Input.GetButtonDown("Jump") || Input.GetKeyDown(KeyCode.C),
                JumpHeld = Input.GetButton("Jump") || Input.GetKey(KeyCode.C),
                DashDown = Input.GetKeyDown(KeyCode.X),
                AttackDown = Input.GetKeyDown(KeyCode.Z),
                Move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")),
                ExampleActionHeld = Input.GetKey(KeyCode.E),
            };
        }
#endif
    }

    public struct FrameInput
    {
        public Vector2 Move;
        public bool JumpDown;
        public bool JumpHeld;
        public bool DashDown;
        public bool AttackDown;
        public bool ExampleActionHeld;

        public bool Salir;
    }
}