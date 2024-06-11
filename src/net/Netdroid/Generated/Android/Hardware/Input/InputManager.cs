/*
*  Copyright 2024 MASES s.r.l.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*  http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
*  Refer to LICENSE for more information.
*/

/*
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Hardware.Input
{
    #region InputManager
    public partial class InputManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/input/InputManager.html#ACTION_QUERY_KEYBOARD_LAYOUTS"/>
        /// </summary>
        public static Java.Lang.String ACTION_QUERY_KEYBOARD_LAYOUTS { get { if (!_ACTION_QUERY_KEYBOARD_LAYOUTSReady) { _ACTION_QUERY_KEYBOARD_LAYOUTSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_QUERY_KEYBOARD_LAYOUTS"); _ACTION_QUERY_KEYBOARD_LAYOUTSReady = true; } return _ACTION_QUERY_KEYBOARD_LAYOUTSContent; } }
        private static Java.Lang.String _ACTION_QUERY_KEYBOARD_LAYOUTSContent = default;
        private static bool _ACTION_QUERY_KEYBOARD_LAYOUTSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/input/InputManager.html#META_DATA_KEYBOARD_LAYOUTS"/>
        /// </summary>
        public static Java.Lang.String META_DATA_KEYBOARD_LAYOUTS { get { if (!_META_DATA_KEYBOARD_LAYOUTSReady) { _META_DATA_KEYBOARD_LAYOUTSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "META_DATA_KEYBOARD_LAYOUTS"); _META_DATA_KEYBOARD_LAYOUTSReady = true; } return _META_DATA_KEYBOARD_LAYOUTSContent; } }
        private static Java.Lang.String _META_DATA_KEYBOARD_LAYOUTSContent = default;
        private static bool _META_DATA_KEYBOARD_LAYOUTSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/input/InputManager.html#getHostUsiVersion(android.view.Display)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Display"/></param>
        /// <returns><see cref="Android.Hardware.Input.HostUsiVersion"/></returns>
        public Android.Hardware.Input.HostUsiVersion GetHostUsiVersion(Android.View.Display arg0)
        {
            return IExecuteWithSignature<Android.Hardware.Input.HostUsiVersion>("getHostUsiVersion", "(Landroid/view/Display;)Landroid/hardware/input/HostUsiVersion;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/input/InputManager.html#getInputDevice(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.View.InputDevice"/></returns>
        public Android.View.InputDevice GetInputDevice(int arg0)
        {
            return IExecuteWithSignature<Android.View.InputDevice>("getInputDevice", "(I)Landroid/view/InputDevice;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/input/InputManager.html#verifyInputEvent(android.view.InputEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.InputEvent"/></param>
        /// <returns><see cref="Android.View.VerifiedInputEvent"/></returns>
        public Android.View.VerifiedInputEvent VerifyInputEvent(Android.View.InputEvent arg0)
        {
            return IExecuteWithSignature<Android.View.VerifiedInputEvent>("verifyInputEvent", "(Landroid/view/InputEvent;)Landroid/view/VerifiedInputEvent;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/input/InputManager.html#isStylusPointerIconEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsStylusPointerIconEnabled()
        {
            return IExecuteWithSignature<bool>("isStylusPointerIconEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/input/InputManager.html#getMaximumObscuringOpacityForTouch()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetMaximumObscuringOpacityForTouch()
        {
            return IExecuteWithSignature<float>("getMaximumObscuringOpacityForTouch", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/input/InputManager.html#getInputDeviceIds()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int[] GetInputDeviceIds()
        {
            return IExecuteWithSignatureArray<int>("getInputDeviceIds", "()[I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/input/InputManager.html#registerInputDeviceListener(android.hardware.input.InputManager.InputDeviceListener,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Input.InputManager.InputDeviceListener"/></param>
        /// <param name="arg1"><see cref="Android.Os.Handler"/></param>
        public void RegisterInputDeviceListener(Android.Hardware.Input.InputManager.InputDeviceListener arg0, Android.Os.Handler arg1)
        {
            IExecute("registerInputDeviceListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/input/InputManager.html#unregisterInputDeviceListener(android.hardware.input.InputManager.InputDeviceListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Input.InputManager.InputDeviceListener"/></param>
        public void UnregisterInputDeviceListener(Android.Hardware.Input.InputManager.InputDeviceListener arg0)
        {
            IExecuteWithSignature("unregisterInputDeviceListener", "(Landroid/hardware/input/InputManager$InputDeviceListener;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region InputDeviceListener
        public partial class InputDeviceListener
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// Handlers initializer for <see cref="InputDeviceListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onInputDeviceAdded", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(OnInputDeviceAddedEventHandler));
                AddEventHandler("onInputDeviceChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(OnInputDeviceChangedEventHandler));
                AddEventHandler("onInputDeviceRemoved", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(OnInputDeviceRemovedEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/hardware/input/InputManager.InputDeviceListener.html#onInputDeviceAdded(int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnInputDeviceAdded"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<int> OnOnInputDeviceAdded { get; set; } = null;

            void OnInputDeviceAddedEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
            {
                var methodToExecute = (OnOnInputDeviceAdded != null) ? OnOnInputDeviceAdded : OnInputDeviceAdded;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/input/InputManager.InputDeviceListener.html#onInputDeviceAdded(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public virtual void OnInputDeviceAdded(int arg0)
            {
                
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/hardware/input/InputManager.InputDeviceListener.html#onInputDeviceChanged(int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnInputDeviceChanged"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<int> OnOnInputDeviceChanged { get; set; } = null;

            void OnInputDeviceChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
            {
                var methodToExecute = (OnOnInputDeviceChanged != null) ? OnOnInputDeviceChanged : OnInputDeviceChanged;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/input/InputManager.InputDeviceListener.html#onInputDeviceChanged(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public virtual void OnInputDeviceChanged(int arg0)
            {
                
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/hardware/input/InputManager.InputDeviceListener.html#onInputDeviceRemoved(int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnInputDeviceRemoved"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<int> OnOnInputDeviceRemoved { get; set; } = null;

            void OnInputDeviceRemovedEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
            {
                var methodToExecute = (OnOnInputDeviceRemoved != null) ? OnOnInputDeviceRemoved : OnInputDeviceRemoved;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/input/InputManager.InputDeviceListener.html#onInputDeviceRemoved(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public virtual void OnInputDeviceRemoved(int arg0)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region InputDeviceListenerDirect
        public partial class InputDeviceListenerDirect
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/input/InputManager.InputDeviceListener.html#onInputDeviceAdded(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public override void OnInputDeviceAdded(int arg0)
            {
                IExecuteWithSignature("onInputDeviceAdded", "(I)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/input/InputManager.InputDeviceListener.html#onInputDeviceChanged(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public override void OnInputDeviceChanged(int arg0)
            {
                IExecuteWithSignature("onInputDeviceChanged", "(I)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/input/InputManager.InputDeviceListener.html#onInputDeviceRemoved(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public override void OnInputDeviceRemoved(int arg0)
            {
                IExecuteWithSignature("onInputDeviceRemoved", "(I)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}