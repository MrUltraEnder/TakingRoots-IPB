//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Scripts/Prueba/Players.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Players : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Players()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Players"",
    ""maps"": [
        {
            ""name"": ""Player1"",
            ""id"": ""9bd5f5c2-f14f-44a9-a9e9-43314b5a1dbd"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""d2230a4f-cd9e-4990-b1f2-b82e318374df"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""b6b9f6fe-55e1-4689-b4e9-a2062e219819"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""e182d6fc-631a-436e-833b-a53fee3493b2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""01d78183-c3fb-4a34-8803-0b50dabde125"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""1c653839-6c57-43ec-830a-a1e5ac131bd2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""a7a5a0b5-a043-42bf-80f2-5e2da18f8325"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""ba7c2786-db2d-4b48-b9c7-0319fb92c1c0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Salir"",
                    ""type"": ""Button"",
                    ""id"": ""f26fceec-b395-491d-bd03-29a6bbbd823a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""5efd44a0-c907-4715-8947-c43f009e80bc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interaction"",
                    ""type"": ""Button"",
                    ""id"": ""f41c81f6-858a-4add-a738-a0b83b5a04c4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeffQ"",
                    ""type"": ""Button"",
                    ""id"": ""bf0cc3b7-e358-4127-801a-d80239d2d996"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RightE"",
                    ""type"": ""Button"",
                    ""id"": ""421a7390-b8df-4931-a24d-fbb7ab2315c2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""68deb636-eff5-4c47-8e0d-6eaf3c652048"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6119ee15-8aa9-4a1a-9ea5-a52e11faf441"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fad20383-e033-4b40-9d06-44328b41bd3f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e16fa5cb-1cf6-4b2f-a178-4fc9ce963861"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5a504294-db60-4bc0-ae1b-eda6e64505d4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5b05bcf8-33b8-4e02-b969-ac733949ce2e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b8c9a6d3-678b-44a8-b20a-7ce126d60f32"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ea6a37b9-7dcc-4207-9af0-dae5d255e5a1"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2fc86664-0791-4cf0-a3f7-d66a8cb171b1"",
                    ""path"": ""<Keyboard>/leftAlt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6c7e526e-c8d2-43ae-8124-4dcd2ee15be2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d50e0e85-a2a7-4ff4-a433-fb79dd69f4ac"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""182c0397-19e0-4726-8eee-65d8a2133a11"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Salir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e10fc6af-27c6-4a87-809f-5261d5ccc077"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a6f4461d-c513-41ab-96c7-80178d6fa130"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a697ecc-2489-44da-bbff-ccbb5689f04a"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeffQ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7497d3f3-ac5b-4aef-bcac-0bba86cb9667"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player2"",
            ""id"": ""fb15c103-40f9-488b-bb34-8210f9972fe2"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""de3d5100-ba6b-4333-8867-4cecc0b1c44c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""6e34c8ea-8495-4ae6-8be6-5fbcde02264c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""d9c52de9-fa1f-4ba9-8c92-087fc4f17b58"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""1c9e400d-abf8-418a-ac93-d9a6b916acb8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""cc0bcf83-1ab4-4eea-b455-769512881c07"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""38bf8af8-805f-4d9d-82d8-41daffd2aaf9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""82f61e76-d08d-4dc0-bfe4-a1cae0d1a01e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Salir"",
                    ""type"": ""Button"",
                    ""id"": ""f18c2869-941a-452a-a319-15ba7e21d469"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""5238a9e0-8d7c-46a3-a794-7a0f9eff6186"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""116fa2c8-0014-426c-97cb-8c3228b50d8a"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0a491499-5480-4ba2-86fe-c83d9a10cb37"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""91931ca2-de61-470f-9d0c-cd5b90159a64"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b765fd81-39ad-45bf-9af0-7f022b3159a8"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f55ef838-4e9e-4dd6-96b8-0e1fbacd9adb"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""097ba9ef-0288-41cc-8451-1ed6fbae5e28"",
                    ""path"": ""<Keyboard>/rightCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""74cd77e5-d9a8-44a8-9d03-fc2e6724fc3d"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4ab1beb3-092f-4b3a-a199-eb973fe881d6"",
                    ""path"": ""<Keyboard>/rightShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd19eedd-bb81-419d-817c-60be713ab819"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20f12480-3783-4185-b837-a0481eae192a"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94a5167d-2491-4565-8925-feb09927b3c1"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Salir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player1
        m_Player1 = asset.FindActionMap("Player1", throwIfNotFound: true);
        m_Player1_Movement = m_Player1.FindAction("Movement", throwIfNotFound: true);
        m_Player1_Jump = m_Player1.FindAction("Jump", throwIfNotFound: true);
        m_Player1_Dash = m_Player1.FindAction("Dash", throwIfNotFound: true);
        m_Player1_Down = m_Player1.FindAction("Down", throwIfNotFound: true);
        m_Player1_Attack = m_Player1.FindAction("Attack", throwIfNotFound: true);
        m_Player1_Left = m_Player1.FindAction("Left", throwIfNotFound: true);
        m_Player1_Right = m_Player1.FindAction("Right", throwIfNotFound: true);
        m_Player1_Salir = m_Player1.FindAction("Salir", throwIfNotFound: true);
        m_Player1_Up = m_Player1.FindAction("Up", throwIfNotFound: true);
        m_Player1_Interaction = m_Player1.FindAction("Interaction", throwIfNotFound: true);
        m_Player1_LeffQ = m_Player1.FindAction("LeffQ", throwIfNotFound: true);
        m_Player1_RightE = m_Player1.FindAction("RightE", throwIfNotFound: true);
        // Player2
        m_Player2 = asset.FindActionMap("Player2", throwIfNotFound: true);
        m_Player2_Movement = m_Player2.FindAction("Movement", throwIfNotFound: true);
        m_Player2_Jump = m_Player2.FindAction("Jump", throwIfNotFound: true);
        m_Player2_Dash = m_Player2.FindAction("Dash", throwIfNotFound: true);
        m_Player2_Down = m_Player2.FindAction("Down", throwIfNotFound: true);
        m_Player2_Attack = m_Player2.FindAction("Attack", throwIfNotFound: true);
        m_Player2_Left = m_Player2.FindAction("Left", throwIfNotFound: true);
        m_Player2_Right = m_Player2.FindAction("Right", throwIfNotFound: true);
        m_Player2_Salir = m_Player2.FindAction("Salir", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player1
    private readonly InputActionMap m_Player1;
    private IPlayer1Actions m_Player1ActionsCallbackInterface;
    private readonly InputAction m_Player1_Movement;
    private readonly InputAction m_Player1_Jump;
    private readonly InputAction m_Player1_Dash;
    private readonly InputAction m_Player1_Down;
    private readonly InputAction m_Player1_Attack;
    private readonly InputAction m_Player1_Left;
    private readonly InputAction m_Player1_Right;
    private readonly InputAction m_Player1_Salir;
    private readonly InputAction m_Player1_Up;
    private readonly InputAction m_Player1_Interaction;
    private readonly InputAction m_Player1_LeffQ;
    private readonly InputAction m_Player1_RightE;
    public struct Player1Actions
    {
        private @Players m_Wrapper;
        public Player1Actions(@Players wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player1_Movement;
        public InputAction @Jump => m_Wrapper.m_Player1_Jump;
        public InputAction @Dash => m_Wrapper.m_Player1_Dash;
        public InputAction @Down => m_Wrapper.m_Player1_Down;
        public InputAction @Attack => m_Wrapper.m_Player1_Attack;
        public InputAction @Left => m_Wrapper.m_Player1_Left;
        public InputAction @Right => m_Wrapper.m_Player1_Right;
        public InputAction @Salir => m_Wrapper.m_Player1_Salir;
        public InputAction @Up => m_Wrapper.m_Player1_Up;
        public InputAction @Interaction => m_Wrapper.m_Player1_Interaction;
        public InputAction @LeffQ => m_Wrapper.m_Player1_LeffQ;
        public InputAction @RightE => m_Wrapper.m_Player1_RightE;
        public InputActionMap Get() { return m_Wrapper.m_Player1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer1Actions instance)
        {
            if (m_Wrapper.m_Player1ActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnJump;
                @Dash.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDash;
                @Down.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDown;
                @Attack.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnAttack;
                @Left.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnRight;
                @Salir.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnSalir;
                @Salir.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnSalir;
                @Salir.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnSalir;
                @Up.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnUp;
                @Interaction.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnInteraction;
                @Interaction.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnInteraction;
                @Interaction.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnInteraction;
                @LeffQ.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnLeffQ;
                @LeffQ.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnLeffQ;
                @LeffQ.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnLeffQ;
                @RightE.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnRightE;
                @RightE.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnRightE;
                @RightE.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnRightE;
            }
            m_Wrapper.m_Player1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
                @Salir.started += instance.OnSalir;
                @Salir.performed += instance.OnSalir;
                @Salir.canceled += instance.OnSalir;
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Interaction.started += instance.OnInteraction;
                @Interaction.performed += instance.OnInteraction;
                @Interaction.canceled += instance.OnInteraction;
                @LeffQ.started += instance.OnLeffQ;
                @LeffQ.performed += instance.OnLeffQ;
                @LeffQ.canceled += instance.OnLeffQ;
                @RightE.started += instance.OnRightE;
                @RightE.performed += instance.OnRightE;
                @RightE.canceled += instance.OnRightE;
            }
        }
    }
    public Player1Actions @Player1 => new Player1Actions(this);

    // Player2
    private readonly InputActionMap m_Player2;
    private IPlayer2Actions m_Player2ActionsCallbackInterface;
    private readonly InputAction m_Player2_Movement;
    private readonly InputAction m_Player2_Jump;
    private readonly InputAction m_Player2_Dash;
    private readonly InputAction m_Player2_Down;
    private readonly InputAction m_Player2_Attack;
    private readonly InputAction m_Player2_Left;
    private readonly InputAction m_Player2_Right;
    private readonly InputAction m_Player2_Salir;
    public struct Player2Actions
    {
        private @Players m_Wrapper;
        public Player2Actions(@Players wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player2_Movement;
        public InputAction @Jump => m_Wrapper.m_Player2_Jump;
        public InputAction @Dash => m_Wrapper.m_Player2_Dash;
        public InputAction @Down => m_Wrapper.m_Player2_Down;
        public InputAction @Attack => m_Wrapper.m_Player2_Attack;
        public InputAction @Left => m_Wrapper.m_Player2_Left;
        public InputAction @Right => m_Wrapper.m_Player2_Right;
        public InputAction @Salir => m_Wrapper.m_Player2_Salir;
        public InputActionMap Get() { return m_Wrapper.m_Player2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player2Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer2Actions instance)
        {
            if (m_Wrapper.m_Player2ActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnJump;
                @Dash.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnDash;
                @Down.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnDown;
                @Attack.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnAttack;
                @Left.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnRight;
                @Salir.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnSalir;
                @Salir.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnSalir;
                @Salir.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnSalir;
            }
            m_Wrapper.m_Player2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
                @Salir.started += instance.OnSalir;
                @Salir.performed += instance.OnSalir;
                @Salir.canceled += instance.OnSalir;
            }
        }
    }
    public Player2Actions @Player2 => new Player2Actions(this);
    public interface IPlayer1Actions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnSalir(InputAction.CallbackContext context);
        void OnUp(InputAction.CallbackContext context);
        void OnInteraction(InputAction.CallbackContext context);
        void OnLeffQ(InputAction.CallbackContext context);
        void OnRightE(InputAction.CallbackContext context);
    }
    public interface IPlayer2Actions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnSalir(InputAction.CallbackContext context);
    }
}
