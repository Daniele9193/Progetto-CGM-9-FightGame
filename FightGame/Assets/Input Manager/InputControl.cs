// GENERATED AUTOMATICALLY FROM 'Assets/Input Manager/InputControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputControl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputControl"",
    ""maps"": [
        {
            ""name"": ""FighterControl"",
            ""id"": ""d93a79fc-6b4c-40d9-b559-6a87f6fff7f2"",
            ""actions"": [
                {
                    ""name"": ""Punch"",
                    ""type"": ""Button"",
                    ""id"": ""6bb385ca-b12b-413e-a06d-4d6b8296c9c2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Kick"",
                    ""type"": ""Button"",
                    ""id"": ""6c35534e-3685-4232-a0e6-86dec01aed67"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Block"",
                    ""type"": ""Button"",
                    ""id"": ""9fadf5d9-be6f-4581-808f-86c767182a20"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""f2bf7f5a-3921-4eed-857d-1abc5d66d370"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""4d6d5abb-8014-4db0-a28b-46af94b43974"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""42040816-6a2c-41f5-ad7f-60dd48075c06"",
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
                    ""id"": ""1c79df84-9db7-46ab-ad81-12e4ee489ae0"",
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
                    ""id"": ""6eb66451-f8f0-41fc-98b7-cdccfd5d6b2d"",
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
                    ""id"": ""b576989e-bf18-4676-bfca-ecc743fbbe04"",
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
                    ""id"": ""0cf360cf-3680-4171-9dc2-31c4be3565bd"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Punch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0391ac05-1791-4cb1-8f8b-1e3322a3ab38"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Kick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c11a4a21-1cd0-44eb-9485-2357b7b7ab86"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // FighterControl
        m_FighterControl = asset.FindActionMap("FighterControl", throwIfNotFound: true);
        m_FighterControl_Punch = m_FighterControl.FindAction("Punch", throwIfNotFound: true);
        m_FighterControl_Kick = m_FighterControl.FindAction("Kick", throwIfNotFound: true);
        m_FighterControl_Block = m_FighterControl.FindAction("Block", throwIfNotFound: true);
        m_FighterControl_Move = m_FighterControl.FindAction("Move", throwIfNotFound: true);
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

    // FighterControl
    private readonly InputActionMap m_FighterControl;
    private IFighterControlActions m_FighterControlActionsCallbackInterface;
    private readonly InputAction m_FighterControl_Punch;
    private readonly InputAction m_FighterControl_Kick;
    private readonly InputAction m_FighterControl_Block;
    private readonly InputAction m_FighterControl_Move;
    public struct FighterControlActions
    {
        private @InputControl m_Wrapper;
        public FighterControlActions(@InputControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Punch => m_Wrapper.m_FighterControl_Punch;
        public InputAction @Kick => m_Wrapper.m_FighterControl_Kick;
        public InputAction @Block => m_Wrapper.m_FighterControl_Block;
        public InputAction @Move => m_Wrapper.m_FighterControl_Move;
        public InputActionMap Get() { return m_Wrapper.m_FighterControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FighterControlActions set) { return set.Get(); }
        public void SetCallbacks(IFighterControlActions instance)
        {
            if (m_Wrapper.m_FighterControlActionsCallbackInterface != null)
            {
                @Punch.started -= m_Wrapper.m_FighterControlActionsCallbackInterface.OnPunch;
                @Punch.performed -= m_Wrapper.m_FighterControlActionsCallbackInterface.OnPunch;
                @Punch.canceled -= m_Wrapper.m_FighterControlActionsCallbackInterface.OnPunch;
                @Kick.started -= m_Wrapper.m_FighterControlActionsCallbackInterface.OnKick;
                @Kick.performed -= m_Wrapper.m_FighterControlActionsCallbackInterface.OnKick;
                @Kick.canceled -= m_Wrapper.m_FighterControlActionsCallbackInterface.OnKick;
                @Block.started -= m_Wrapper.m_FighterControlActionsCallbackInterface.OnBlock;
                @Block.performed -= m_Wrapper.m_FighterControlActionsCallbackInterface.OnBlock;
                @Block.canceled -= m_Wrapper.m_FighterControlActionsCallbackInterface.OnBlock;
                @Move.started -= m_Wrapper.m_FighterControlActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_FighterControlActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_FighterControlActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_FighterControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Punch.started += instance.OnPunch;
                @Punch.performed += instance.OnPunch;
                @Punch.canceled += instance.OnPunch;
                @Kick.started += instance.OnKick;
                @Kick.performed += instance.OnKick;
                @Kick.canceled += instance.OnKick;
                @Block.started += instance.OnBlock;
                @Block.performed += instance.OnBlock;
                @Block.canceled += instance.OnBlock;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public FighterControlActions @FighterControl => new FighterControlActions(this);
    public interface IFighterControlActions
    {
        void OnPunch(InputAction.CallbackContext context);
        void OnKick(InputAction.CallbackContext context);
        void OnBlock(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
}
