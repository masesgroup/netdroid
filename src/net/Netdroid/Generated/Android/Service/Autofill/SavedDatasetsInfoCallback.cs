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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Service.Autofill
{
    #region ISavedDatasetsInfoCallback
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISavedDatasetsInfoCallback
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SavedDatasetsInfoCallback
    public partial class SavedDatasetsInfoCallback : Android.Service.Autofill.ISavedDatasetsInfoCallback
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/SavedDatasetsInfoCallback.html#ERROR_NEEDS_USER_ACTION"/>
        /// </summary>
        public static int ERROR_NEEDS_USER_ACTION { get { if (!_ERROR_NEEDS_USER_ACTIONReady) { _ERROR_NEEDS_USER_ACTIONContent = SGetField<int>(LocalBridgeClazz, "ERROR_NEEDS_USER_ACTION"); _ERROR_NEEDS_USER_ACTIONReady = true; } return _ERROR_NEEDS_USER_ACTIONContent; } }
        private static int _ERROR_NEEDS_USER_ACTIONContent = default;
        private static bool _ERROR_NEEDS_USER_ACTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/SavedDatasetsInfoCallback.html#ERROR_OTHER"/>
        /// </summary>
        public static int ERROR_OTHER { get { if (!_ERROR_OTHERReady) { _ERROR_OTHERContent = SGetField<int>(LocalBridgeClazz, "ERROR_OTHER"); _ERROR_OTHERReady = true; } return _ERROR_OTHERContent; } }
        private static int _ERROR_OTHERContent = default;
        private static bool _ERROR_OTHERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/SavedDatasetsInfoCallback.html#ERROR_UNSUPPORTED"/>
        /// </summary>
        public static int ERROR_UNSUPPORTED { get { if (!_ERROR_UNSUPPORTEDReady) { _ERROR_UNSUPPORTEDContent = SGetField<int>(LocalBridgeClazz, "ERROR_UNSUPPORTED"); _ERROR_UNSUPPORTEDReady = true; } return _ERROR_UNSUPPORTEDContent; } }
        private static int _ERROR_UNSUPPORTEDContent = default;
        private static bool _ERROR_UNSUPPORTEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/SavedDatasetsInfoCallback.html#onError(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void OnError(int arg0)
        {
            IExecuteWithSignature("onError", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/SavedDatasetsInfoCallback.html#onSuccess(java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        public void OnSuccess(Java.Util.Set<Android.Service.Autofill.SavedDatasetsInfo> arg0)
        {
            IExecuteWithSignature("onSuccess", "(Ljava/util/Set;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}