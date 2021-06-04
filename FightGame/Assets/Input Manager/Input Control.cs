// GENERATED AUTOMATICALLY FROM 'Assets/Input Manager/Input Control.inputactions'

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
    ""name"": ""Input Control"",
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
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""774ef469-ba15-4d1d-ae21-7483c0432cb1"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
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
