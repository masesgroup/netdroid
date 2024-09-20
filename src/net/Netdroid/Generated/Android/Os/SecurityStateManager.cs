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

namespace Android.Os
{
    #region SecurityStateManager
    public partial class SecurityStateManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/SecurityStateManager.html#KEY_KERNEL_VERSION"/>
        /// </summary>
        public static Java.Lang.String KEY_KERNEL_VERSION { get { if (!_KEY_KERNEL_VERSIONReady) { _KEY_KERNEL_VERSIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "KEY_KERNEL_VERSION"); _KEY_KERNEL_VERSIONReady = true; } return _KEY_KERNEL_VERSIONContent; } }
        private static Java.Lang.String _KEY_KERNEL_VERSIONContent = default;
        private static bool _KEY_KERNEL_VERSIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/SecurityStateManager.html#KEY_SYSTEM_SPL"/>
        /// </summary>
        public static Java.Lang.String KEY_SYSTEM_SPL { get { if (!_KEY_SYSTEM_SPLReady) { _KEY_SYSTEM_SPLContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "KEY_SYSTEM_SPL"); _KEY_SYSTEM_SPLReady = true; } return _KEY_SYSTEM_SPLContent; } }
        private static Java.Lang.String _KEY_SYSTEM_SPLContent = default;
        private static bool _KEY_SYSTEM_SPLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/SecurityStateManager.html#KEY_VENDOR_SPL"/>
        /// </summary>
        public static Java.Lang.String KEY_VENDOR_SPL { get { if (!_KEY_VENDOR_SPLReady) { _KEY_VENDOR_SPLContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "KEY_VENDOR_SPL"); _KEY_VENDOR_SPLReady = true; } return _KEY_VENDOR_SPLContent; } }
        private static Java.Lang.String _KEY_VENDOR_SPLContent = default;
        private static bool _KEY_VENDOR_SPLReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/SecurityStateManager.html#getGlobalSecurityState()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle GetGlobalSecurityState()
        {
            return IExecuteWithSignature<Android.Os.Bundle>("getGlobalSecurityState", "()Landroid/os/Bundle;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}