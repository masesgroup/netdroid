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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Accessibilityservice
{
    #region IBrailleDisplayController
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IBrailleDisplayController
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BrailleDisplayController
    public partial class BrailleDisplayController : Android.Accessibilityservice.IBrailleDisplayController
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
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/BrailleDisplayController.html#isConnected()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsConnected()
        {
            return IExecuteWithSignature<bool>("isConnected", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/BrailleDisplayController.html#connect(android.bluetooth.BluetoothDevice,android.accessibilityservice.BrailleDisplayController.BrailleDisplayCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <param name="arg1"><see cref="Android.Accessibilityservice.BrailleDisplayController.BrailleDisplayCallback"/></param>
        public void Connect(Android.Bluetooth.BluetoothDevice arg0, Android.Accessibilityservice.BrailleDisplayController.BrailleDisplayCallback arg1)
        {
            IExecute("connect", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/BrailleDisplayController.html#connect(android.bluetooth.BluetoothDevice,java.util.concurrent.Executor,android.accessibilityservice.BrailleDisplayController.BrailleDisplayCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Accessibilityservice.BrailleDisplayController.BrailleDisplayCallback"/></param>
        public void Connect(Android.Bluetooth.BluetoothDevice arg0, Java.Util.Concurrent.Executor arg1, Android.Accessibilityservice.BrailleDisplayController.BrailleDisplayCallback arg2)
        {
            IExecute("connect", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/BrailleDisplayController.html#connect(android.hardware.usb.UsbDevice,android.accessibilityservice.BrailleDisplayController.BrailleDisplayCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Usb.UsbDevice"/></param>
        /// <param name="arg1"><see cref="Android.Accessibilityservice.BrailleDisplayController.BrailleDisplayCallback"/></param>
        public void Connect(Android.Hardware.Usb.UsbDevice arg0, Android.Accessibilityservice.BrailleDisplayController.BrailleDisplayCallback arg1)
        {
            IExecute("connect", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/BrailleDisplayController.html#connect(android.hardware.usb.UsbDevice,java.util.concurrent.Executor,android.accessibilityservice.BrailleDisplayController.BrailleDisplayCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Usb.UsbDevice"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Accessibilityservice.BrailleDisplayController.BrailleDisplayCallback"/></param>
        public void Connect(Android.Hardware.Usb.UsbDevice arg0, Java.Util.Concurrent.Executor arg1, Android.Accessibilityservice.BrailleDisplayController.BrailleDisplayCallback arg2)
        {
            IExecute("connect", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/BrailleDisplayController.html#disconnect()"/>
        /// </summary>
        public void Disconnect()
        {
            IExecuteWithSignature("disconnect", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/BrailleDisplayController.html#write(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Write(byte[] arg0)
        {
            IExecuteWithSignature("write", "([B)V", new object[] { arg0 });
        }

        #endregion

        #region Nested classes
        #region BrailleDisplayCallback
        public partial class BrailleDisplayCallback
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/BrailleDisplayController.BrailleDisplayCallback.html#FLAG_ERROR_BRAILLE_DISPLAY_NOT_FOUND"/>
            /// </summary>
            public static int FLAG_ERROR_BRAILLE_DISPLAY_NOT_FOUND { get { if (!_FLAG_ERROR_BRAILLE_DISPLAY_NOT_FOUNDReady) { _FLAG_ERROR_BRAILLE_DISPLAY_NOT_FOUNDContent = SGetField<int>(LocalBridgeClazz, "FLAG_ERROR_BRAILLE_DISPLAY_NOT_FOUND"); _FLAG_ERROR_BRAILLE_DISPLAY_NOT_FOUNDReady = true; } return _FLAG_ERROR_BRAILLE_DISPLAY_NOT_FOUNDContent; } }
            private static int _FLAG_ERROR_BRAILLE_DISPLAY_NOT_FOUNDContent = default;
            private static bool _FLAG_ERROR_BRAILLE_DISPLAY_NOT_FOUNDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/BrailleDisplayController.BrailleDisplayCallback.html#FLAG_ERROR_CANNOT_ACCESS"/>
            /// </summary>
            public static int FLAG_ERROR_CANNOT_ACCESS { get { if (!_FLAG_ERROR_CANNOT_ACCESSReady) { _FLAG_ERROR_CANNOT_ACCESSContent = SGetField<int>(LocalBridgeClazz, "FLAG_ERROR_CANNOT_ACCESS"); _FLAG_ERROR_CANNOT_ACCESSReady = true; } return _FLAG_ERROR_CANNOT_ACCESSContent; } }
            private static int _FLAG_ERROR_CANNOT_ACCESSContent = default;
            private static bool _FLAG_ERROR_CANNOT_ACCESSReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/BrailleDisplayController.BrailleDisplayCallback.html#onConnected(byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            public void OnConnected(byte[] arg0)
            {
                IExecuteWithSignature("onConnected", "([B)V", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/BrailleDisplayController.BrailleDisplayCallback.html#onConnectionFailed(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public void OnConnectionFailed(int arg0)
            {
                IExecuteWithSignature("onConnectionFailed", "(I)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/BrailleDisplayController.BrailleDisplayCallback.html#onDisconnected()"/>
            /// </summary>
            public void OnDisconnected()
            {
                IExecuteWithSignature("onDisconnected", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/BrailleDisplayController.BrailleDisplayCallback.html#onInput(byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            public void OnInput(byte[] arg0)
            {
                IExecuteWithSignature("onInput", "([B)V", new object[] { arg0 });
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