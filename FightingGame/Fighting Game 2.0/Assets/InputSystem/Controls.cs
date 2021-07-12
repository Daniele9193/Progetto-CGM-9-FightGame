// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Fighter"",
            ""id"": ""423e9c91-9d8c-4ca8-9769-bba556f1facd"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3658d6ca-3d95-4d9d-abe1-b2e161612cf5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KickLeft"",
                    ""type"": ""Button"",
                    ""id"": ""4064a852-064a-4631-a0a0-e71d347523c3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KickRight"",
                    ""type"": ""Button"",
                    ""id"": ""03bb3c7d-80d7-429b-a0f2-c279d115dc81"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PunchRight"",
                    ""type"": ""Button"",
                    ""id"": ""e132347d-cdec-4546-b7a4-c6bb3a2754fa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PunchLeft"",
                    ""type"": ""Button"",
                    ""id"": ""d68a98ea-63c9-42b2-8fe4-2c833a7e52e6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""View"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0ac14430-ecab-41e1-9de7-92341b811c02"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Defense"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7b8e6923-fdf4-4969-a01c-53df3f26a9ae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Defense2"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8f22ca71-6e2f-43e8-bb64-af8f47697979"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""98fecd20-0930-4a9d-a98a-4170d661eaae"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KickLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b01527f6-86a4-403f-972e-f12f1e0c3456"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KickRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d78c39fc-7b69-42a0-af1e-4f02ed39cf82"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PunchRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8a0f37b7-65d2-494c-bb95-c0b910e2e04e"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PunchLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""8a7cdb5b-a7fe-4b61-a04e-a3bd5420bebd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""fe5694c8-8c7d-4ffb-b6e2-06f85a9f749a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""46d990a3-3eca-4942-b4c6-f5c6a86a97d1"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7b341aa4-5a77-4af6-9c28-06ba24359ee5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fc1553b5-5053-4cfd-9add-320fb9730dcd"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""adb5a23c-080e-4fd8-9c75-1f896429710d"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""View"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""650d9541-4ff1-4b1b-b73b-eecd125a9a11"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Defense"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7ad25e9f-ae05-497c-9d19-80ca90134705"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Defense2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Fighter
        m_Fighter = asset.FindActionMap("Fighter", throwIfNotFound: true);
        m_Fighter_Move = m_Fighter.FindAction("Move", throwIfNotFound: true);
        m_Fighter_KickLeft = m_Fighter.FindAction("KickLeft", throwIfNotFound: true);
        m_Fighter_KickRight = m_Fighter.FindAction("KickRight", throwIfNotFound: true);
        m_Fighter_PunchRight = m_Fighter.FindAction("PunchRight", throwIfNotFound: true);
        m_Fighter_PunchLeft = m_Fighter.FindAction("PunchLeft", throwIfNotFound: true);
        m_Fighter_View = m_Fighter.FindAction("View", throwIfNotFound: true);
        m_Fighter_Defense = m_Fighter.FindAction("Defense", throwIfNotFound: true);
        m_Fighter_Defense2 = m_Fighter.FindAction("Defense2", throwIfNotFound: true);
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

    // Fighter
    private readonly InputActionMap m_Fighter;
    private IFighterActions m_FighterActionsCallbackInterface;
    private readonly InputAction m_Fighter_Move;
    private readonly InputAction m_Fighter_KickLeft;
    private readonly InputAction m_Fighter_KickRight;
    private readonly InputAction m_Fighter_PunchRight;
    private readonly InputAction m_Fighter_PunchLeft;
    private readonly InputAction m_Fighter_View;
    private readonly InputAction m_Fighter_Defense;
    private readonly InputAction m_Fighter_Defense2;
    public struct FighterActions
    {
        private @Controls m_Wrapper;
        public FighterActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Fighter_Move;
        public InputAction @KickLeft => m_Wrapper.m_Fighter_KickLeft;
        public InputAction @KickRight => m_Wrapper.m_Fighter_KickRight;
        public InputAction @PunchRight => m_Wrapper.m_Fighter_PunchRight;
        public InputAction @PunchLeft => m_Wrapper.m_Fighter_PunchLeft;
        public InputAction @View => m_Wrapper.m_Fighter_View;
        public InputAction @Defense => m_Wrapper.m_Fighter_Defense;
        public InputAction @Defense2 => m_Wrapper.m_Fighter_Defense2;
        public InputActionMap Get() { return m_Wrapper.m_Fighter; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FighterActions set) { return set.Get(); }
        public void SetCallbacks(IFighterActions instance)
        {
            if (m_Wrapper.m_FighterActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_FighterActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_FighterActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_FighterActionsCallbackInterface.OnMove;
                @KickLeft.started -= m_Wrapper.m_FighterActionsCallbackInterface.OnKickLeft;
                @KickLeft.performed -= m_Wrapper.m_FighterActionsCallbackInterface.OnKickLeft;
                @KickLeft.canceled -= m_Wrapper.m_FighterActionsCallbackInterface.OnKickLeft;
                @KickRight.started -= m_Wrapper.m_FighterActionsCallbackInterface.OnKickRight;
                @KickRight.performed -= m_Wrapper.m_FighterActionsCallbackInterface.OnKickRight;
                @KickRight.canceled -= m_Wrapper.m_FighterActionsCallbackInterface.OnKickRight;
                @PunchRight.started -= m_Wrapper.m_FighterActionsCallbackInterface.OnPunchRight;
                @PunchRight.performed -= m_Wrapper.m_FighterActionsCallbackInterface.OnPunchRight;
                @PunchRight.canceled -= m_Wrapper.m_FighterActionsCallbackInterface.OnPunchRight;
                @PunchLeft.started -= m_Wrapper.m_FighterActionsCallbackInterface.OnPunchLeft;
                @PunchLeft.performed -= m_Wrapper.m_FighterActionsCallbackInterface.OnPunchLeft;
                @PunchLeft.canceled -= m_Wrapper.m_FighterActionsCallbackInterface.OnPunchLeft;
                @View.started -= m_Wrapper.m_FighterActionsCallbackInterface.OnView;
                @View.performed -= m_Wrapper.m_FighterActionsCallbackInterface.OnView;
                @View.canceled -= m_Wrapper.m_FighterActionsCallbackInterface.OnView;
                @Defense.started -= m_Wrapper.m_FighterActionsCallbackInterface.OnDefense;
                @Defense.performed -= m_Wrapper.m_FighterActionsCallbackInterface.OnDefense;
                @Defense.canceled -= m_Wrapper.m_FighterActionsCallbackInterface.OnDefense;
                @Defense2.started -= m_Wrapper.m_FighterActionsCallbackInterface.OnDefense2;
                @Defense2.performed -= m_Wrapper.m_FighterActionsCallbackInterface.OnDefense2;
                @Defense2.canceled -= m_Wrapper.m_FighterActionsCallbackInterface.OnDefense2;
            }
            m_Wrapper.m_FighterActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @KickLeft.started += instance.OnKickLeft;
                @KickLeft.performed += instance.OnKickLeft;
                @KickLeft.canceled += instance.OnKickLeft;
                @KickRight.started += instance.OnKickRight;
                @KickRight.performed += instance.OnKickRight;
                @KickRight.canceled += instance.OnKickRight;
                @PunchRight.started += instance.OnPunchRight;
                @PunchRight.performed += instance.OnPunchRight;
                @PunchRight.canceled += instance.OnPunchRight;
                @PunchLeft.started += instance.OnPunchLeft;
                @PunchLeft.performed += instance.OnPunchLeft;
                @PunchLeft.canceled += instance.OnPunchLeft;
                @View.started += instance.OnView;
                @View.performed += instance.OnView;
                @View.canceled += instance.OnView;
                @Defense.started += instance.OnDefense;
                @Defense.performed += instance.OnDefense;
                @Defense.canceled += instance.OnDefense;
                @Defense2.started += instance.OnDefense2;
                @Defense2.performed += instance.OnDefense2;
                @Defense2.canceled += instance.OnDefense2;
            }
        }
    }
    public FighterActions @Fighter => new FighterActions(this);
    public interface IFighterActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnKickLeft(InputAction.CallbackContext context);
        void OnKickRight(InputAction.CallbackContext context);
        void OnPunchRight(InputAction.CallbackContext context);
        void OnPunchLeft(InputAction.CallbackContext context);
        void OnView(InputAction.CallbackContext context);
        void OnDefense(InputAction.CallbackContext context);
        void OnDefense2(InputAction.CallbackContext context);
    }
}
