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

namespace Android.View.Displayhash
{
    #region IDisplayHashResultCallback
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDisplayHashResultCallback
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DisplayHashResultCallback
    public partial class DisplayHashResultCallback : Android.View.Displayhash.IDisplayHashResultCallback
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/displayhash/DisplayHashResultCallback.html#DISPLAY_HASH_ERROR_INVALID_BOUNDS"/>
        /// </summary>
        public static int DISPLAY_HASH_ERROR_INVALID_BOUNDS { get { if (!_DISPLAY_HASH_ERROR_INVALID_BOUNDSReady) { _DISPLAY_HASH_ERROR_INVALID_BOUNDSContent = SGetField<int>(LocalBridgeClazz, "DISPLAY_HASH_ERROR_INVALID_BOUNDS"); _DISPLAY_HASH_ERROR_INVALID_BOUNDSReady = true; } return _DISPLAY_HASH_ERROR_INVALID_BOUNDSContent; } }
        private static int _DISPLAY_HASH_ERROR_INVALID_BOUNDSContent = default;
        private static bool _DISPLAY_HASH_ERROR_INVALID_BOUNDSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/displayhash/DisplayHashResultCallback.html#DISPLAY_HASH_ERROR_INVALID_HASH_ALGORITHM"/>
        /// </summary>
        public static int DISPLAY_HASH_ERROR_INVALID_HASH_ALGORITHM { get { if (!_DISPLAY_HASH_ERROR_INVALID_HASH_ALGORITHMReady) { _DISPLAY_HASH_ERROR_INVALID_HASH_ALGORITHMContent = SGetField<int>(LocalBridgeClazz, "DISPLAY_HASH_ERROR_INVALID_HASH_ALGORITHM"); _DISPLAY_HASH_ERROR_INVALID_HASH_ALGORITHMReady = true; } return _DISPLAY_HASH_ERROR_INVALID_HASH_ALGORITHMContent; } }
        private static int _DISPLAY_HASH_ERROR_INVALID_HASH_ALGORITHMContent = default;
        private static bool _DISPLAY_HASH_ERROR_INVALID_HASH_ALGORITHMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/displayhash/DisplayHashResultCallback.html#DISPLAY_HASH_ERROR_MISSING_WINDOW"/>
        /// </summary>
        public static int DISPLAY_HASH_ERROR_MISSING_WINDOW { get { if (!_DISPLAY_HASH_ERROR_MISSING_WINDOWReady) { _DISPLAY_HASH_ERROR_MISSING_WINDOWContent = SGetField<int>(LocalBridgeClazz, "DISPLAY_HASH_ERROR_MISSING_WINDOW"); _DISPLAY_HASH_ERROR_MISSING_WINDOWReady = true; } return _DISPLAY_HASH_ERROR_MISSING_WINDOWContent; } }
        private static int _DISPLAY_HASH_ERROR_MISSING_WINDOWContent = default;
        private static bool _DISPLAY_HASH_ERROR_MISSING_WINDOWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/displayhash/DisplayHashResultCallback.html#DISPLAY_HASH_ERROR_NOT_VISIBLE_ON_SCREEN"/>
        /// </summary>
        public static int DISPLAY_HASH_ERROR_NOT_VISIBLE_ON_SCREEN { get { if (!_DISPLAY_HASH_ERROR_NOT_VISIBLE_ON_SCREENReady) { _DISPLAY_HASH_ERROR_NOT_VISIBLE_ON_SCREENContent = SGetField<int>(LocalBridgeClazz, "DISPLAY_HASH_ERROR_NOT_VISIBLE_ON_SCREEN"); _DISPLAY_HASH_ERROR_NOT_VISIBLE_ON_SCREENReady = true; } return _DISPLAY_HASH_ERROR_NOT_VISIBLE_ON_SCREENContent; } }
        private static int _DISPLAY_HASH_ERROR_NOT_VISIBLE_ON_SCREENContent = default;
        private static bool _DISPLAY_HASH_ERROR_NOT_VISIBLE_ON_SCREENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/displayhash/DisplayHashResultCallback.html#DISPLAY_HASH_ERROR_TOO_MANY_REQUESTS"/>
        /// </summary>
        public static int DISPLAY_HASH_ERROR_TOO_MANY_REQUESTS { get { if (!_DISPLAY_HASH_ERROR_TOO_MANY_REQUESTSReady) { _DISPLAY_HASH_ERROR_TOO_MANY_REQUESTSContent = SGetField<int>(LocalBridgeClazz, "DISPLAY_HASH_ERROR_TOO_MANY_REQUESTS"); _DISPLAY_HASH_ERROR_TOO_MANY_REQUESTSReady = true; } return _DISPLAY_HASH_ERROR_TOO_MANY_REQUESTSContent; } }
        private static int _DISPLAY_HASH_ERROR_TOO_MANY_REQUESTSContent = default;
        private static bool _DISPLAY_HASH_ERROR_TOO_MANY_REQUESTSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/displayhash/DisplayHashResultCallback.html#DISPLAY_HASH_ERROR_UNKNOWN"/>
        /// </summary>
        public static int DISPLAY_HASH_ERROR_UNKNOWN { get { if (!_DISPLAY_HASH_ERROR_UNKNOWNReady) { _DISPLAY_HASH_ERROR_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "DISPLAY_HASH_ERROR_UNKNOWN"); _DISPLAY_HASH_ERROR_UNKNOWNReady = true; } return _DISPLAY_HASH_ERROR_UNKNOWNContent; } }
        private static int _DISPLAY_HASH_ERROR_UNKNOWNContent = default;
        private static bool _DISPLAY_HASH_ERROR_UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/displayhash/DisplayHashResultCallback.html#onDisplayHashError(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void OnDisplayHashError(int arg0)
        {
            IExecuteWithSignature("onDisplayHashError", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/displayhash/DisplayHashResultCallback.html#onDisplayHashResult(android.view.displayhash.DisplayHash)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Displayhash.DisplayHash"/></param>
        public void OnDisplayHashResult(Android.View.Displayhash.DisplayHash arg0)
        {
            IExecuteWithSignature("onDisplayHashResult", "(Landroid/view/displayhash/DisplayHash;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}