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
    #region FingerprintGestureController
    public partial class FingerprintGestureController
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/FingerprintGestureController.html#FINGERPRINT_GESTURE_SWIPE_DOWN"/>
        /// </summary>
        public static int FINGERPRINT_GESTURE_SWIPE_DOWN { get { if (!_FINGERPRINT_GESTURE_SWIPE_DOWNReady) { _FINGERPRINT_GESTURE_SWIPE_DOWNContent = SGetField<int>(LocalBridgeClazz, "FINGERPRINT_GESTURE_SWIPE_DOWN"); _FINGERPRINT_GESTURE_SWIPE_DOWNReady = true; } return _FINGERPRINT_GESTURE_SWIPE_DOWNContent; } }
        private static int _FINGERPRINT_GESTURE_SWIPE_DOWNContent = default;
        private static bool _FINGERPRINT_GESTURE_SWIPE_DOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/FingerprintGestureController.html#FINGERPRINT_GESTURE_SWIPE_LEFT"/>
        /// </summary>
        public static int FINGERPRINT_GESTURE_SWIPE_LEFT { get { if (!_FINGERPRINT_GESTURE_SWIPE_LEFTReady) { _FINGERPRINT_GESTURE_SWIPE_LEFTContent = SGetField<int>(LocalBridgeClazz, "FINGERPRINT_GESTURE_SWIPE_LEFT"); _FINGERPRINT_GESTURE_SWIPE_LEFTReady = true; } return _FINGERPRINT_GESTURE_SWIPE_LEFTContent; } }
        private static int _FINGERPRINT_GESTURE_SWIPE_LEFTContent = default;
        private static bool _FINGERPRINT_GESTURE_SWIPE_LEFTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/FingerprintGestureController.html#FINGERPRINT_GESTURE_SWIPE_RIGHT"/>
        /// </summary>
        public static int FINGERPRINT_GESTURE_SWIPE_RIGHT { get { if (!_FINGERPRINT_GESTURE_SWIPE_RIGHTReady) { _FINGERPRINT_GESTURE_SWIPE_RIGHTContent = SGetField<int>(LocalBridgeClazz, "FINGERPRINT_GESTURE_SWIPE_RIGHT"); _FINGERPRINT_GESTURE_SWIPE_RIGHTReady = true; } return _FINGERPRINT_GESTURE_SWIPE_RIGHTContent; } }
        private static int _FINGERPRINT_GESTURE_SWIPE_RIGHTContent = default;
        private static bool _FINGERPRINT_GESTURE_SWIPE_RIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/FingerprintGestureController.html#FINGERPRINT_GESTURE_SWIPE_UP"/>
        /// </summary>
        public static int FINGERPRINT_GESTURE_SWIPE_UP { get { if (!_FINGERPRINT_GESTURE_SWIPE_UPReady) { _FINGERPRINT_GESTURE_SWIPE_UPContent = SGetField<int>(LocalBridgeClazz, "FINGERPRINT_GESTURE_SWIPE_UP"); _FINGERPRINT_GESTURE_SWIPE_UPReady = true; } return _FINGERPRINT_GESTURE_SWIPE_UPContent; } }
        private static int _FINGERPRINT_GESTURE_SWIPE_UPContent = default;
        private static bool _FINGERPRINT_GESTURE_SWIPE_UPReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/FingerprintGestureController.html#isGestureDetectionAvailable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsGestureDetectionAvailable()
        {
            return IExecuteWithSignature<bool>("isGestureDetectionAvailable", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/FingerprintGestureController.html#registerFingerprintGestureCallback(android.accessibilityservice.FingerprintGestureController.FingerprintGestureCallback,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Accessibilityservice.FingerprintGestureController.FingerprintGestureCallback"/></param>
        /// <param name="arg1"><see cref="Android.Os.Handler"/></param>
        public void RegisterFingerprintGestureCallback(Android.Accessibilityservice.FingerprintGestureController.FingerprintGestureCallback arg0, Android.Os.Handler arg1)
        {
            IExecute("registerFingerprintGestureCallback", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/FingerprintGestureController.html#unregisterFingerprintGestureCallback(android.accessibilityservice.FingerprintGestureController.FingerprintGestureCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Accessibilityservice.FingerprintGestureController.FingerprintGestureCallback"/></param>
        public void UnregisterFingerprintGestureCallback(Android.Accessibilityservice.FingerprintGestureController.FingerprintGestureCallback arg0)
        {
            IExecuteWithSignature("unregisterFingerprintGestureCallback", "(Landroid/accessibilityservice/FingerprintGestureController$FingerprintGestureCallback;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region FingerprintGestureCallback
        public partial class FingerprintGestureCallback
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
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/FingerprintGestureController.FingerprintGestureCallback.html#onGestureDetected(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public void OnGestureDetected(int arg0)
            {
                IExecuteWithSignature("onGestureDetected", "(I)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/FingerprintGestureController.FingerprintGestureCallback.html#onGestureDetectionAvailabilityChanged(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            public void OnGestureDetectionAvailabilityChanged(bool arg0)
            {
                IExecuteWithSignature("onGestureDetectionAvailabilityChanged", "(Z)V", arg0);
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