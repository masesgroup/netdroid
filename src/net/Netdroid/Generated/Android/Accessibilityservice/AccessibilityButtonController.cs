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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Accessibilityservice
{
    #region AccessibilityButtonController
    public partial class AccessibilityButtonController
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
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityButtonController.html#isAccessibilityButtonAvailable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAccessibilityButtonAvailable()
        {
            return IExecuteWithSignature<bool>("isAccessibilityButtonAvailable", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityButtonController.html#registerAccessibilityButtonCallback(android.accessibilityservice.AccessibilityButtonController.AccessibilityButtonCallback,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Accessibilityservice.AccessibilityButtonController.AccessibilityButtonCallback"/></param>
        /// <param name="arg1"><see cref="Android.Os.Handler"/></param>
        public void RegisterAccessibilityButtonCallback(Android.Accessibilityservice.AccessibilityButtonController.AccessibilityButtonCallback arg0, Android.Os.Handler arg1)
        {
            IExecute("registerAccessibilityButtonCallback", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityButtonController.html#registerAccessibilityButtonCallback(android.accessibilityservice.AccessibilityButtonController.AccessibilityButtonCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Accessibilityservice.AccessibilityButtonController.AccessibilityButtonCallback"/></param>
        public void RegisterAccessibilityButtonCallback(Android.Accessibilityservice.AccessibilityButtonController.AccessibilityButtonCallback arg0)
        {
            IExecuteWithSignature("registerAccessibilityButtonCallback", "(Landroid/accessibilityservice/AccessibilityButtonController$AccessibilityButtonCallback;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityButtonController.html#unregisterAccessibilityButtonCallback(android.accessibilityservice.AccessibilityButtonController.AccessibilityButtonCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Accessibilityservice.AccessibilityButtonController.AccessibilityButtonCallback"/></param>
        public void UnregisterAccessibilityButtonCallback(Android.Accessibilityservice.AccessibilityButtonController.AccessibilityButtonCallback arg0)
        {
            IExecuteWithSignature("unregisterAccessibilityButtonCallback", "(Landroid/accessibilityservice/AccessibilityButtonController$AccessibilityButtonCallback;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region AccessibilityButtonCallback
        public partial class AccessibilityButtonCallback
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
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityButtonController.AccessibilityButtonCallback.html#onAvailabilityChanged(android.accessibilityservice.AccessibilityButtonController,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Accessibilityservice.AccessibilityButtonController"/></param>
            /// <param name="arg1"><see cref="bool"/></param>
            public void OnAvailabilityChanged(Android.Accessibilityservice.AccessibilityButtonController arg0, bool arg1)
            {
                IExecute("onAvailabilityChanged", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityButtonController.AccessibilityButtonCallback.html#onClicked(android.accessibilityservice.AccessibilityButtonController)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Accessibilityservice.AccessibilityButtonController"/></param>
            public void OnClicked(Android.Accessibilityservice.AccessibilityButtonController arg0)
            {
                IExecuteWithSignature("onClicked", "(Landroid/accessibilityservice/AccessibilityButtonController;)V", arg0);
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