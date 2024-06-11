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

namespace Android.Provider
{
    #region IOpenableColumns
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IOpenableColumns
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region OpenableColumns
    public partial class OpenableColumns : Android.Provider.IOpenableColumns
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/OpenableColumns.html#DISPLAY_NAME"/>
        /// </summary>
        public static Java.Lang.String DISPLAY_NAME { get { if (!_DISPLAY_NAMEReady) { _DISPLAY_NAMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DISPLAY_NAME"); _DISPLAY_NAMEReady = true; } return _DISPLAY_NAMEContent; } }
        private static Java.Lang.String _DISPLAY_NAMEContent = default;
        private static bool _DISPLAY_NAMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/OpenableColumns.html#SIZE"/>
        /// </summary>
        public static Java.Lang.String SIZE { get { if (!_SIZEReady) { _SIZEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SIZE"); _SIZEReady = true; } return _SIZEContent; } }
        private static Java.Lang.String _SIZEContent = default;
        private static bool _SIZEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}