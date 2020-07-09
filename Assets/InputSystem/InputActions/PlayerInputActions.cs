// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/InputActions/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace InputMapping
{
    public class @PlayerInputActions : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerInputActions()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""PlayerController"",
            ""id"": ""e3966f9e-06a8-461f-821d-17ad4963b018"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""beb4e162-8675-45b0-af01-45d2f7244f18"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""f7fff6fd-d284-4ddc-9307-12872526c6cb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BasicAttack"",
                    ""type"": ""Button"",
                    ""id"": ""6c1cc586-ab71-4796-bca4-4368615828c9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ActivateColorShift"",
                    ""type"": ""Button"",
                    ""id"": ""09d68755-3ea4-4aa7-9c5d-c6dce79a2a42"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShiftColorLeft"",
                    ""type"": ""Button"",
                    ""id"": ""bf69d6ce-dcf7-4528-8ab4-f0d22fd23cff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShiftColorRight"",
                    ""type"": ""Button"",
                    ""id"": ""641c2087-6e0c-4536-a3e8-07fa675755b8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""c2f7b8b4-467a-41c3-b88a-1f935cc01369"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MapToggle"",
                    ""type"": ""Button"",
                    ""id"": ""f17c88ed-17b1-4d23-b016-2777adf7f460"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""0d17eaa9-28ce-48fe-974c-991997851fd2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e6bb5acb-71a5-4c44-a12d-9ecc88a13a27"",
                    ""path"": ""<SwitchProControllerHID>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e982d7e7-55c6-4b96-8f43-8b603b60bb2a"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6833c4ca-f103-43d1-9fda-98c3230ec107"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d3cc285e-fce2-4631-9cde-bd2519d97bc8"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""526d2b1f-f692-4b24-84f5-1364078cf430"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6c3430c3-1fd0-4efe-ab28-6d917eae2c46"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8e7e7a98-5f16-45e9-b730-7fab4859f6b9"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d7d3142-621b-4e50-b628-a9c93c82ceaa"",
                    ""path"": ""<SwitchProControllerHID>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b0bf0f26-2041-4a0c-ab76-7ec07e2bde40"",
                    ""path"": ""<DualShockGamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3881f1bc-8780-4966-8d64-74d3cee3086e"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3c42f61c-efeb-4ee0-b608-34f75304bf57"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""BasicAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7cbc14d7-6573-41e3-9551-f2de91f13885"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""BasicAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b69c334c-453b-4751-9669-73f3d11d6bed"",
                    ""path"": ""<SwitchProControllerHID>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""BasicAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6118b887-c2fc-462f-a909-0a0f6258331a"",
                    ""path"": ""<DualShockGamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""BasicAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""25542b5f-0acc-44f4-8ba7-6b7cc34317ee"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""BasicAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ea473a48-e33b-4132-8a1a-a4ffce100d84"",
                    ""path"": ""<Keyboard>/alt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ActivateColorShift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""51e41309-39c1-465d-972a-e4dd22b821ea"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ActivateColorShift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9566960a-5e4d-4d7e-bd72-c108cf436e93"",
                    ""path"": ""<SwitchProControllerHID>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ActivateColorShift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a1ecd88e-1b23-4ca4-a2fa-a515b65722eb"",
                    ""path"": ""<DualShockGamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ActivateColorShift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b05277c1-6741-4a7b-8220-18e07f48639e"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ActivateColorShift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8005ffa6-2f00-4d41-b5f5-20e9debb13af"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ShiftColorLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""34c99aa7-760a-46ef-bd2a-cc8bb7413bc6"",
                    ""path"": ""<DualShockGamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ShiftColorLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9418aa90-006a-4295-8021-fb54e80534ba"",
                    ""path"": ""<SwitchProControllerHID>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ShiftColorLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23d8315b-61de-4364-8b71-e37bcf798584"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ShiftColorLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9fc72706-5e03-4ba1-9839-da33876edd68"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ShiftColorLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""10443ddc-cf07-45fc-a7aa-6769e3c71723"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ShiftColorRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""80b7a379-0e66-4ce6-b786-030b59bb6e83"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ShiftColorRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a41c8d1-0c2d-415f-9c53-7022f044e69b"",
                    ""path"": ""<SwitchProControllerHID>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ShiftColorRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""88baa81d-f898-47da-898d-304ee0a9071d"",
                    ""path"": ""<DualShockGamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ShiftColorRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""551b7abc-f3c2-4496-b0e5-b2cc2c8aa0ea"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ShiftColorRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD/Arrows (Keyboard)"",
                    ""id"": ""a5b6e6bb-bd7d-4bd0-a248-e2616a0799c6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9abc6ce4-b025-4502-ba05-fd5785c0fed8"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""365557fd-abd4-4c1b-88bf-03c8b04bdf70"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""07cb8a2f-f39c-4163-b5a6-182d4a3f071b"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a5174cd4-249f-476f-a838-96e9f814711a"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d39b654b-9733-4115-8539-ec7118684aee"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""614b33ca-4327-4893-9f05-893c738cc10e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8b6eb7ee-b765-4bd3-889e-fa1b47f623c1"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9729af1f-7a23-4327-b2da-60932204ae01"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left Stick (Switch Pro Controller)"",
                    ""id"": ""0f1c7dc2-c467-4c11-8b10-757ef70f215f"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9bf1dfb5-6bf7-4a94-8be9-bc1a0319f7d9"",
                    ""path"": ""<SwitchProControllerHID>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8d2f0f20-7666-4c0e-8a4f-359d71b6c979"",
                    ""path"": ""<SwitchProControllerHID>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e791f1c4-bd1a-48db-a51b-370cdd381302"",
                    ""path"": ""<SwitchProControllerHID>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""25b19c26-8355-456a-b6da-305eeef4f05b"",
                    ""path"": ""<SwitchProControllerHID>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD (Keyboard)"",
                    ""id"": ""9cba6b27-69e5-4472-92e2-4bb16a433701"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Left Stick (Xbox Controller)"",
                    ""id"": ""395845e4-5f65-473a-949a-58c0a32fe134"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f8c606f5-97cf-4a6f-aeb3-fc35a6b7a6b5"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8b9013aa-cec7-4b12-a0c7-02a9cbaac218"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9fe75365-b705-4556-9e66-79b25092ada7"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""63a7aae1-3fb6-4daf-ac83-46357100264c"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left Stick (PS4 Controller)"",
                    ""id"": ""a1fda853-9cad-485c-9a76-26b92eb7a070"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""aba11742-e897-4342-8c98-366192f661ab"",
                    ""path"": ""<DualShockGamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ac6fd3d5-faf6-4c6f-b26a-16b5bea9a251"",
                    ""path"": ""<DualShockGamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c66a2541-c85b-4fa6-9796-18d2bd60286c"",
                    ""path"": ""<DualShockGamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6b9849ef-875c-48c0-9dee-030cef77953b"",
                    ""path"": ""<DualShockGamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left Stick (Gamepad)"",
                    ""id"": ""6e217013-f74b-4f8b-a4c1-93758deb2079"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""07c8a044-4fea-477c-8397-24f5109a4585"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""886551cc-815b-41b2-ab64-a03e85ae4fd8"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""eb96c0f6-6131-4e28-b044-a603b7fe3131"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2f156aa5-83e2-4cdb-8352-fcc3341002c0"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""00f355e8-9015-4184-a1a2-4c26b8525cd4"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MapToggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9aa369d0-3ffd-4920-80d8-7d45ea0df498"",
                    ""path"": ""<SwitchProControllerHID>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MapToggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6db0a833-c7f5-45b0-886d-7eec1cd82955"",
                    ""path"": ""<DualShockGamepad>/touchpadButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MapToggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""64ddb30c-65b1-45ba-9b83-21944a17da6a"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MapToggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd2f08a9-0290-4eff-9d98-5c3fed20febf"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MapToggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""47d064ff-f177-411e-8900-6e8fa24f4a09"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""996f8fa6-175d-431e-8a58-a1efbeffab4b"",
                    ""path"": ""<DualShockGamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2f6789de-98a6-475c-99e5-ad93a585f4e8"",
                    ""path"": ""<SwitchProControllerHID>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a97a11f3-fa5e-4527-a208-2a26f5688dd1"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d38f03e0-ab7c-49c0-be12-ba8eec07081d"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": []
        },
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": []
        }
    ]
}");
            // PlayerController
            m_PlayerController = asset.FindActionMap("PlayerController", throwIfNotFound: true);
            m_PlayerController_Jump = m_PlayerController.FindAction("Jump", throwIfNotFound: true);
            m_PlayerController_Dash = m_PlayerController.FindAction("Dash", throwIfNotFound: true);
            m_PlayerController_BasicAttack = m_PlayerController.FindAction("BasicAttack", throwIfNotFound: true);
            m_PlayerController_ActivateColorShift = m_PlayerController.FindAction("ActivateColorShift", throwIfNotFound: true);
            m_PlayerController_ShiftColorLeft = m_PlayerController.FindAction("ShiftColorLeft", throwIfNotFound: true);
            m_PlayerController_ShiftColorRight = m_PlayerController.FindAction("ShiftColorRight", throwIfNotFound: true);
            m_PlayerController_Movement = m_PlayerController.FindAction("Movement", throwIfNotFound: true);
            m_PlayerController_MapToggle = m_PlayerController.FindAction("MapToggle", throwIfNotFound: true);
            m_PlayerController_Pause = m_PlayerController.FindAction("Pause", throwIfNotFound: true);
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

        // PlayerController
        private readonly InputActionMap m_PlayerController;
        private IPlayerControllerActions m_PlayerControllerActionsCallbackInterface;
        private readonly InputAction m_PlayerController_Jump;
        private readonly InputAction m_PlayerController_Dash;
        private readonly InputAction m_PlayerController_BasicAttack;
        private readonly InputAction m_PlayerController_ActivateColorShift;
        private readonly InputAction m_PlayerController_ShiftColorLeft;
        private readonly InputAction m_PlayerController_ShiftColorRight;
        private readonly InputAction m_PlayerController_Movement;
        private readonly InputAction m_PlayerController_MapToggle;
        private readonly InputAction m_PlayerController_Pause;
        public struct PlayerControllerActions
        {
            private @PlayerInputActions m_Wrapper;
            public PlayerControllerActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Jump => m_Wrapper.m_PlayerController_Jump;
            public InputAction @Dash => m_Wrapper.m_PlayerController_Dash;
            public InputAction @BasicAttack => m_Wrapper.m_PlayerController_BasicAttack;
            public InputAction @ActivateColorShift => m_Wrapper.m_PlayerController_ActivateColorShift;
            public InputAction @ShiftColorLeft => m_Wrapper.m_PlayerController_ShiftColorLeft;
            public InputAction @ShiftColorRight => m_Wrapper.m_PlayerController_ShiftColorRight;
            public InputAction @Movement => m_Wrapper.m_PlayerController_Movement;
            public InputAction @MapToggle => m_Wrapper.m_PlayerController_MapToggle;
            public InputAction @Pause => m_Wrapper.m_PlayerController_Pause;
            public InputActionMap Get() { return m_Wrapper.m_PlayerController; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerControllerActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerControllerActions instance)
            {
                if (m_Wrapper.m_PlayerControllerActionsCallbackInterface != null)
                {
                    @Jump.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnJump;
                    @Jump.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnJump;
                    @Jump.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnJump;
                    @Dash.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnDash;
                    @Dash.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnDash;
                    @Dash.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnDash;
                    @BasicAttack.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnBasicAttack;
                    @BasicAttack.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnBasicAttack;
                    @BasicAttack.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnBasicAttack;
                    @ActivateColorShift.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnActivateColorShift;
                    @ActivateColorShift.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnActivateColorShift;
                    @ActivateColorShift.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnActivateColorShift;
                    @ShiftColorLeft.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnShiftColorLeft;
                    @ShiftColorLeft.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnShiftColorLeft;
                    @ShiftColorLeft.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnShiftColorLeft;
                    @ShiftColorRight.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnShiftColorRight;
                    @ShiftColorRight.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnShiftColorRight;
                    @ShiftColorRight.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnShiftColorRight;
                    @Movement.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnMovement;
                    @Movement.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnMovement;
                    @Movement.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnMovement;
                    @MapToggle.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnMapToggle;
                    @MapToggle.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnMapToggle;
                    @MapToggle.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnMapToggle;
                    @Pause.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnPause;
                    @Pause.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnPause;
                    @Pause.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnPause;
                }
                m_Wrapper.m_PlayerControllerActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Jump.started += instance.OnJump;
                    @Jump.performed += instance.OnJump;
                    @Jump.canceled += instance.OnJump;
                    @Dash.started += instance.OnDash;
                    @Dash.performed += instance.OnDash;
                    @Dash.canceled += instance.OnDash;
                    @BasicAttack.started += instance.OnBasicAttack;
                    @BasicAttack.performed += instance.OnBasicAttack;
                    @BasicAttack.canceled += instance.OnBasicAttack;
                    @ActivateColorShift.started += instance.OnActivateColorShift;
                    @ActivateColorShift.performed += instance.OnActivateColorShift;
                    @ActivateColorShift.canceled += instance.OnActivateColorShift;
                    @ShiftColorLeft.started += instance.OnShiftColorLeft;
                    @ShiftColorLeft.performed += instance.OnShiftColorLeft;
                    @ShiftColorLeft.canceled += instance.OnShiftColorLeft;
                    @ShiftColorRight.started += instance.OnShiftColorRight;
                    @ShiftColorRight.performed += instance.OnShiftColorRight;
                    @ShiftColorRight.canceled += instance.OnShiftColorRight;
                    @Movement.started += instance.OnMovement;
                    @Movement.performed += instance.OnMovement;
                    @Movement.canceled += instance.OnMovement;
                    @MapToggle.started += instance.OnMapToggle;
                    @MapToggle.performed += instance.OnMapToggle;
                    @MapToggle.canceled += instance.OnMapToggle;
                    @Pause.started += instance.OnPause;
                    @Pause.performed += instance.OnPause;
                    @Pause.canceled += instance.OnPause;
                }
            }
        }
        public PlayerControllerActions @PlayerController => new PlayerControllerActions(this);
        private int m_GamepadSchemeIndex = -1;
        public InputControlScheme GamepadScheme
        {
            get
            {
                if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
                return asset.controlSchemes[m_GamepadSchemeIndex];
            }
        }
        private int m_KeyboardSchemeIndex = -1;
        public InputControlScheme KeyboardScheme
        {
            get
            {
                if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
                return asset.controlSchemes[m_KeyboardSchemeIndex];
            }
        }
        public interface IPlayerControllerActions
        {
            void OnJump(InputAction.CallbackContext context);
            void OnDash(InputAction.CallbackContext context);
            void OnBasicAttack(InputAction.CallbackContext context);
            void OnActivateColorShift(InputAction.CallbackContext context);
            void OnShiftColorLeft(InputAction.CallbackContext context);
            void OnShiftColorRight(InputAction.CallbackContext context);
            void OnMovement(InputAction.CallbackContext context);
            void OnMapToggle(InputAction.CallbackContext context);
            void OnPause(InputAction.CallbackContext context);
        }
    }
}