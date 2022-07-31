//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Input/TankInputActions.inputactions
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

public partial class @TankInputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @TankInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""TankInputActions"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""b366ad39-c79e-480c-8cb8-66086061fb31"",
            ""actions"": [
                {
                    ""name"": ""MoveDirection"",
                    ""type"": ""Value"",
                    ""id"": ""1ae1d989-0922-42d2-9ef5-5a8e4185cbfb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""TurretDirection"",
                    ""type"": ""Value"",
                    ""id"": ""6c04fa0e-c720-479b-a6e2-9fbf66543d48"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Flip"",
                    ""type"": ""Value"",
                    ""id"": ""4de72e92-6ef6-434f-ad2e-71f3ea62d5cd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""dce14372-9209-4e6a-acf7-8041ce417845"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e17d52d3-cbb0-49e3-a4d4-ce3ff3fbe01c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f43ae17b-c7dc-46fb-b338-cf9fb676f5c7"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1b813a98-f204-41a1-b82b-7969d1a3961f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9ce6fe5e-bf07-4448-8024-56747dd98560"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d728d926-6f72-4e7b-97ba-cf9427b3bf65"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7617ef0a-3122-476c-af33-e933ae51302e"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""TurretDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb038653-df8e-4f58-83c2-b28c0ca54a10"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Flip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""564151ad-2c19-4d02-a08e-a38aba46da73"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Flip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Abilities"",
            ""id"": ""81511380-8e12-4fe1-a6b0-044ba2251c1c"",
            ""actions"": [
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""fe6bdb3b-5644-4d5c-a033-1677c3225406"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Boost"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f77b8a19-3ac5-4729-8760-f1ca9f94a121"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Landmine"",
                    ""type"": ""Button"",
                    ""id"": ""29567489-56fd-43b4-bcf2-ba0283a14541"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4ac48077-04a6-4985-ac5b-4dde0716504d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1c58814d-eeb2-438a-930a-195de532394e"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0b745d54-a0fc-475f-ba61-c939c6e909c1"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Landmine"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b8279d12-6491-43c3-9626-4e1bbbbe54e1"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Landmine"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0ccb203-2910-4b0f-bdc5-d48fde606832"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8445d52b-906f-4457-8661-f2c6e24ca473"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""904fe03b-6364-4a63-83d1-d8e003cd225d"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard+Mouse"",
            ""bindingGroup"": ""Keyboard+Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Controller"",
            ""bindingGroup"": ""Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_MoveDirection = m_Movement.FindAction("MoveDirection", throwIfNotFound: true);
        m_Movement_TurretDirection = m_Movement.FindAction("TurretDirection", throwIfNotFound: true);
        m_Movement_Flip = m_Movement.FindAction("Flip", throwIfNotFound: true);
        // Abilities
        m_Abilities = asset.FindActionMap("Abilities", throwIfNotFound: true);
        m_Abilities_Shoot = m_Abilities.FindAction("Shoot", throwIfNotFound: true);
        m_Abilities_Boost = m_Abilities.FindAction("Boost", throwIfNotFound: true);
        m_Abilities_Landmine = m_Abilities.FindAction("Landmine", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_MoveDirection;
    private readonly InputAction m_Movement_TurretDirection;
    private readonly InputAction m_Movement_Flip;
    public struct MovementActions
    {
        private @TankInputActions m_Wrapper;
        public MovementActions(@TankInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveDirection => m_Wrapper.m_Movement_MoveDirection;
        public InputAction @TurretDirection => m_Wrapper.m_Movement_TurretDirection;
        public InputAction @Flip => m_Wrapper.m_Movement_Flip;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @MoveDirection.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMoveDirection;
                @MoveDirection.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMoveDirection;
                @MoveDirection.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMoveDirection;
                @TurretDirection.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnTurretDirection;
                @TurretDirection.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnTurretDirection;
                @TurretDirection.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnTurretDirection;
                @Flip.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnFlip;
                @Flip.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnFlip;
                @Flip.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnFlip;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveDirection.started += instance.OnMoveDirection;
                @MoveDirection.performed += instance.OnMoveDirection;
                @MoveDirection.canceled += instance.OnMoveDirection;
                @TurretDirection.started += instance.OnTurretDirection;
                @TurretDirection.performed += instance.OnTurretDirection;
                @TurretDirection.canceled += instance.OnTurretDirection;
                @Flip.started += instance.OnFlip;
                @Flip.performed += instance.OnFlip;
                @Flip.canceled += instance.OnFlip;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // Abilities
    private readonly InputActionMap m_Abilities;
    private IAbilitiesActions m_AbilitiesActionsCallbackInterface;
    private readonly InputAction m_Abilities_Shoot;
    private readonly InputAction m_Abilities_Boost;
    private readonly InputAction m_Abilities_Landmine;
    public struct AbilitiesActions
    {
        private @TankInputActions m_Wrapper;
        public AbilitiesActions(@TankInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shoot => m_Wrapper.m_Abilities_Shoot;
        public InputAction @Boost => m_Wrapper.m_Abilities_Boost;
        public InputAction @Landmine => m_Wrapper.m_Abilities_Landmine;
        public InputActionMap Get() { return m_Wrapper.m_Abilities; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AbilitiesActions set) { return set.Get(); }
        public void SetCallbacks(IAbilitiesActions instance)
        {
            if (m_Wrapper.m_AbilitiesActionsCallbackInterface != null)
            {
                @Shoot.started -= m_Wrapper.m_AbilitiesActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_AbilitiesActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_AbilitiesActionsCallbackInterface.OnShoot;
                @Boost.started -= m_Wrapper.m_AbilitiesActionsCallbackInterface.OnBoost;
                @Boost.performed -= m_Wrapper.m_AbilitiesActionsCallbackInterface.OnBoost;
                @Boost.canceled -= m_Wrapper.m_AbilitiesActionsCallbackInterface.OnBoost;
                @Landmine.started -= m_Wrapper.m_AbilitiesActionsCallbackInterface.OnLandmine;
                @Landmine.performed -= m_Wrapper.m_AbilitiesActionsCallbackInterface.OnLandmine;
                @Landmine.canceled -= m_Wrapper.m_AbilitiesActionsCallbackInterface.OnLandmine;
            }
            m_Wrapper.m_AbilitiesActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Boost.started += instance.OnBoost;
                @Boost.performed += instance.OnBoost;
                @Boost.canceled += instance.OnBoost;
                @Landmine.started += instance.OnLandmine;
                @Landmine.performed += instance.OnLandmine;
                @Landmine.canceled += instance.OnLandmine;
            }
        }
    }
    public AbilitiesActions @Abilities => new AbilitiesActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard+Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_ControllerSchemeIndex = -1;
    public InputControlScheme ControllerScheme
    {
        get
        {
            if (m_ControllerSchemeIndex == -1) m_ControllerSchemeIndex = asset.FindControlSchemeIndex("Controller");
            return asset.controlSchemes[m_ControllerSchemeIndex];
        }
    }
    public interface IMovementActions
    {
        void OnMoveDirection(InputAction.CallbackContext context);
        void OnTurretDirection(InputAction.CallbackContext context);
        void OnFlip(InputAction.CallbackContext context);
    }
    public interface IAbilitiesActions
    {
        void OnShoot(InputAction.CallbackContext context);
        void OnBoost(InputAction.CallbackContext context);
        void OnLandmine(InputAction.CallbackContext context);
    }
}
