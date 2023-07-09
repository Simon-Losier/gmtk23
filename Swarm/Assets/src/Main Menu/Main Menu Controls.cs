//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.1
//     from Assets/src/Main Menu/Main Menu Controls.inputactions
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

public partial class @MainMenuControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @MainMenuControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Main Menu Controls"",
    ""maps"": [
        {
            ""name"": ""mainMenu"",
            ""id"": ""446625fd-0cdd-4bed-8337-6cbf0733dd73"",
            ""actions"": [
                {
                    ""name"": ""Start Game"",
                    ""type"": ""Button"",
                    ""id"": ""d93f3d83-b9d6-4190-b9b4-f01345ae5582"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Exit Game"",
                    ""type"": ""Button"",
                    ""id"": ""6763de8b-6c1c-4412-bf96-046c8681589a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5f958c46-f6c4-446f-ac2a-6937cbbd9354"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB"",
                    ""action"": ""Start Game"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""86bfd9f1-f964-4a78-a77a-d6984b229197"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Start Game"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""49206212-3371-4f73-861e-61142af9b6fe"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB"",
                    ""action"": ""Exit Game"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""617c41e4-54b3-4bab-bf7f-c4eb4c02c52f"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Exit Game"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KB"",
            ""bindingGroup"": ""KB"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // mainMenu
        m_mainMenu = asset.FindActionMap("mainMenu", throwIfNotFound: true);
        m_mainMenu_StartGame = m_mainMenu.FindAction("Start Game", throwIfNotFound: true);
        m_mainMenu_ExitGame = m_mainMenu.FindAction("Exit Game", throwIfNotFound: true);
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

    // mainMenu
    private readonly InputActionMap m_mainMenu;
    private List<IMainMenuActions> m_MainMenuActionsCallbackInterfaces = new List<IMainMenuActions>();
    private readonly InputAction m_mainMenu_StartGame;
    private readonly InputAction m_mainMenu_ExitGame;
    public struct MainMenuActions
    {
        private @MainMenuControls m_Wrapper;
        public MainMenuActions(@MainMenuControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @StartGame => m_Wrapper.m_mainMenu_StartGame;
        public InputAction @ExitGame => m_Wrapper.m_mainMenu_ExitGame;
        public InputActionMap Get() { return m_Wrapper.m_mainMenu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainMenuActions set) { return set.Get(); }
        public void AddCallbacks(IMainMenuActions instance)
        {
            if (instance == null || m_Wrapper.m_MainMenuActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MainMenuActionsCallbackInterfaces.Add(instance);
            @StartGame.started += instance.OnStartGame;
            @StartGame.performed += instance.OnStartGame;
            @StartGame.canceled += instance.OnStartGame;
            @ExitGame.started += instance.OnExitGame;
            @ExitGame.performed += instance.OnExitGame;
            @ExitGame.canceled += instance.OnExitGame;
        }

        private void UnregisterCallbacks(IMainMenuActions instance)
        {
            @StartGame.started -= instance.OnStartGame;
            @StartGame.performed -= instance.OnStartGame;
            @StartGame.canceled -= instance.OnStartGame;
            @ExitGame.started -= instance.OnExitGame;
            @ExitGame.performed -= instance.OnExitGame;
            @ExitGame.canceled -= instance.OnExitGame;
        }

        public void RemoveCallbacks(IMainMenuActions instance)
        {
            if (m_Wrapper.m_MainMenuActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMainMenuActions instance)
        {
            foreach (var item in m_Wrapper.m_MainMenuActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MainMenuActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MainMenuActions @mainMenu => new MainMenuActions(this);
    private int m_KBSchemeIndex = -1;
    public InputControlScheme KBScheme
    {
        get
        {
            if (m_KBSchemeIndex == -1) m_KBSchemeIndex = asset.FindControlSchemeIndex("KB");
            return asset.controlSchemes[m_KBSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IMainMenuActions
    {
        void OnStartGame(InputAction.CallbackContext context);
        void OnExitGame(InputAction.CallbackContext context);
    }
}