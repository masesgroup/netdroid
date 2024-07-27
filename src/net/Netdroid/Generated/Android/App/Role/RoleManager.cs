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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.App.Role
{
    #region RoleManager
    public partial class RoleManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/role/RoleManager.html#ROLE_ASSISTANT"/>
        /// </summary>
        public static Java.Lang.String ROLE_ASSISTANT { get { if (!_ROLE_ASSISTANTReady) { _ROLE_ASSISTANTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ROLE_ASSISTANT"); _ROLE_ASSISTANTReady = true; } return _ROLE_ASSISTANTContent; } }
        private static Java.Lang.String _ROLE_ASSISTANTContent = default;
        private static bool _ROLE_ASSISTANTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/role/RoleManager.html#ROLE_BROWSER"/>
        /// </summary>
        public static Java.Lang.String ROLE_BROWSER { get { if (!_ROLE_BROWSERReady) { _ROLE_BROWSERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ROLE_BROWSER"); _ROLE_BROWSERReady = true; } return _ROLE_BROWSERContent; } }
        private static Java.Lang.String _ROLE_BROWSERContent = default;
        private static bool _ROLE_BROWSERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/role/RoleManager.html#ROLE_CALL_REDIRECTION"/>
        /// </summary>
        public static Java.Lang.String ROLE_CALL_REDIRECTION { get { if (!_ROLE_CALL_REDIRECTIONReady) { _ROLE_CALL_REDIRECTIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ROLE_CALL_REDIRECTION"); _ROLE_CALL_REDIRECTIONReady = true; } return _ROLE_CALL_REDIRECTIONContent; } }
        private static Java.Lang.String _ROLE_CALL_REDIRECTIONContent = default;
        private static bool _ROLE_CALL_REDIRECTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/role/RoleManager.html#ROLE_CALL_SCREENING"/>
        /// </summary>
        public static Java.Lang.String ROLE_CALL_SCREENING { get { if (!_ROLE_CALL_SCREENINGReady) { _ROLE_CALL_SCREENINGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ROLE_CALL_SCREENING"); _ROLE_CALL_SCREENINGReady = true; } return _ROLE_CALL_SCREENINGContent; } }
        private static Java.Lang.String _ROLE_CALL_SCREENINGContent = default;
        private static bool _ROLE_CALL_SCREENINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/role/RoleManager.html#ROLE_DIALER"/>
        /// </summary>
        public static Java.Lang.String ROLE_DIALER { get { if (!_ROLE_DIALERReady) { _ROLE_DIALERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ROLE_DIALER"); _ROLE_DIALERReady = true; } return _ROLE_DIALERContent; } }
        private static Java.Lang.String _ROLE_DIALERContent = default;
        private static bool _ROLE_DIALERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/role/RoleManager.html#ROLE_EMERGENCY"/>
        /// </summary>
        public static Java.Lang.String ROLE_EMERGENCY { get { if (!_ROLE_EMERGENCYReady) { _ROLE_EMERGENCYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ROLE_EMERGENCY"); _ROLE_EMERGENCYReady = true; } return _ROLE_EMERGENCYContent; } }
        private static Java.Lang.String _ROLE_EMERGENCYContent = default;
        private static bool _ROLE_EMERGENCYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/role/RoleManager.html#ROLE_HOME"/>
        /// </summary>
        public static Java.Lang.String ROLE_HOME { get { if (!_ROLE_HOMEReady) { _ROLE_HOMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ROLE_HOME"); _ROLE_HOMEReady = true; } return _ROLE_HOMEContent; } }
        private static Java.Lang.String _ROLE_HOMEContent = default;
        private static bool _ROLE_HOMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/role/RoleManager.html#ROLE_NOTES"/>
        /// </summary>
        public static Java.Lang.String ROLE_NOTES { get { if (!_ROLE_NOTESReady) { _ROLE_NOTESContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ROLE_NOTES"); _ROLE_NOTESReady = true; } return _ROLE_NOTESContent; } }
        private static Java.Lang.String _ROLE_NOTESContent = default;
        private static bool _ROLE_NOTESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/role/RoleManager.html#ROLE_SMS"/>
        /// </summary>
        public static Java.Lang.String ROLE_SMS { get { if (!_ROLE_SMSReady) { _ROLE_SMSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ROLE_SMS"); _ROLE_SMSReady = true; } return _ROLE_SMSContent; } }
        private static Java.Lang.String _ROLE_SMSContent = default;
        private static bool _ROLE_SMSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/role/RoleManager.html#ROLE_WALLET"/>
        /// </summary>
        public static Java.Lang.String ROLE_WALLET { get { if (!_ROLE_WALLETReady) { _ROLE_WALLETContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ROLE_WALLET"); _ROLE_WALLETReady = true; } return _ROLE_WALLETContent; } }
        private static Java.Lang.String _ROLE_WALLETContent = default;
        private static bool _ROLE_WALLETReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/role/RoleManager.html#createRequestRoleIntent(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Content.Intent"/></returns>
        public Android.Content.Intent CreateRequestRoleIntent(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Content.Intent>("createRequestRoleIntent", "(Ljava/lang/String;)Landroid/content/Intent;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/role/RoleManager.html#isRoleAvailable(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsRoleAvailable(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("isRoleAvailable", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/role/RoleManager.html#isRoleHeld(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsRoleHeld(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("isRoleHeld", "(Ljava/lang/String;)Z", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}