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
            ""id"": ""e9d6c236-2d75-4330-926e-a7c323393e03"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""96b3c385-24a3-4bfb-8c82-a200e9135eaa"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KickLeft"",
                    ""type"": ""Button"",
                    ""id"": ""3c1a250a-08e4-4f89-b33b-521c86f893a1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KickRight"",
                    ""type"": ""Button"",
                    ""id"": ""c6e5fdf2-10d6-43fa-8fd7-fef1f5a84094"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PunchRight"",
                    ""type"": ""Button"",
                    ""id"": ""3bcdcec7-4459-422d-87a7-edd42e3badbf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PunchLeft"",
                    ""type"": ""Button"",
                    ""id"": ""7158b20d-79f6-4406-9fc6-533cc04594a4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Defense"",
                    ""type"": ""PassThrough"",
                    ""id"": ""86b708ae-79ed-401f-96ef-1f1b44b337de"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Impenetrability"",
                    ""type"": ""Button"",
                    ""id"": ""c363675a-5e07-45fa-b08b-705a9dd80401"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e8fd0fac-55a3-42c4-88e3-1c376608643d"",
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
                    ""id"": ""a719c8d4-7c62-4685-a630-a580a9b3e2f5"",
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
                    ""id"": ""96ff86a6-863d-4604-afe3-ff0da09ff872"",
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
                    ""id"": ""123dc1be-e36f-4310-ba8a-45e11546e91d"",
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
                    ""id"": ""73403928-27c0-4d37-b5ab-afd40798774e"",
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
                    ""id"": ""88a81b63-94fb-4a7c-8c7e-b51add791306"",
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
                    ""id"": ""c7d930ec-76b9-4441-938a-e4e0079963ca"",
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
                    ""id"": ""1986977e-e589-49ad-afcc-6ba79f5d2bff"",
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
                    ""id"": ""51736a24-38a6-4f83-85ce-bf5c6deea98f"",
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
                    ""id"": ""0c57f8a6-58cc-4694-a342-f6d14022b5a4"",
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
                    ""id"": ""43728408-eb02-4cb5-a458-a737f059e569"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Impenetrability"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""InteractionMouse"",
            ""id"": ""502d9e02-c75d-4056-b7c8-d7226f9f93f7"",
            ""actions"": [
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""c488f080-976b-427b-a4c4-dc599eb45e5f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9c3b5a35-8cc1-4206-83b2-cde77cbf6ef3"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
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
        m_Fighter_Defense = m_Fighter.FindAction("Defense", throwIfNotFound: true);
        m_Fighter_Impenetrability = m_Fighter.FindAction("Impenetrability", throwIfNotFound: true);
        // InteractionMouse
        m_InteractionMouse = asset.FindActionMap("InteractionMouse", throwIfNotFound: true);
        m_InteractionMouse_Click = m_InteractionMouse.FindAction("Click", throwIfNotFound: true);
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
    private readonly InputAction m_Fighter_Defense;
    private readonly InputAction m_Fighter_Impenetrability;
    public struct FighterActions
    {
        private @Controls m_Wrapper;
        public FighterActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Fighter_Move;
        public InputAction @KickLeft => m_Wrapper.m_Fighter_KickLeft;
        public InputAction @KickRight => m_Wrapper.m_Fighter_KickRight;
        public InputAction @PunchRight => m_Wrapper.m_Fighter_PunchRight;
        public InputAction @PunchLeft => m_Wrapper.m_Fighter_PunchLeft;
        public InputAction @Defense => m_Wrapper.m_Fighter_Defense;
        public InputAction @Impenetrability => m_Wrapper.m_Fighter_Impenetrability;
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
                @Defense.started -= m_Wrapper.m_FighterActionsCallbackInterface.OnDefense;
                @Defense.performed -= m_Wrapper.m_FighterActionsCallbackInterface.OnDefense;
                @Defense.canceled -= m_Wrapper.m_FighterActionsCallbackInterface.OnDefense;
                @Impenetrability.started -= m_Wrapper.m_FighterActionsCallbackInterface.OnImpenetrability;
                @Impenetrability.performed -= m_Wrapper.m_FighterActionsCallbackInterface.OnImpenetrability;
                @Impenetrability.canceled -= m_Wrapper.m_FighterActionsCallbackInterface.OnImpenetrability;
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
                @Defense.started += instance.OnDefense;
                @Defense.performed += instance.OnDefense;
                @Defense.canceled += instance.OnDefense;
                @Impenetrability.started += instance.OnImpenetrability;
                @Impenetrability.performed += instance.OnImpenetrability;
                @Impenetrability.canceled += instance.OnImpenetrability;
            }
        }
    }
    public FighterActions @Fighter => new FighterActions(this);

    // InteractionMouse
    private readonly InputActionMap m_InteractionMouse;
    private IInteractionMouseActions m_InteractionMouseActionsCallbackInterface;
    private readonly InputAction m_InteractionMouse_Click;
    public struct InteractionMouseActions
    {
        private @Controls m_Wrapper;
        public InteractionMouseActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Click => m_Wrapper.m_InteractionMouse_Click;
        public InputActionMap Get() { return m_Wrapper.m_InteractionMouse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InteractionMouseActions set) { return set.Get(); }
        public void SetCallbacks(IInteractionMouseActions instance)
        {
            if (m_Wrapper.m_InteractionMouseActionsCallbackInterface != null)
            {
                @Click.started -= m_Wrapper.m_InteractionMouseActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_InteractionMouseActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_InteractionMouseActionsCallbackInterface.OnClick;
            }
            m_Wrapper.m_InteractionMouseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
            }
        }
    }
    public InteractionMouseActions @InteractionMouse => new InteractionMouseActions(this);
    public interface IFighterActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnKickLeft(InputAction.CallbackContext context);
        void OnKickRight(InputAction.CallbackContext context);
        void OnPunchRight(InputAction.CallbackContext context);
        void OnPunchLeft(InputAction.CallbackContext context);
        void OnDefense(InputAction.CallbackContext context);
        void OnImpenetrability(InputAction.CallbackContext context);
    }
    public interface IInteractionMouseActions
    {
        void OnClick(InputAction.CallbackContext context);
    }
}
