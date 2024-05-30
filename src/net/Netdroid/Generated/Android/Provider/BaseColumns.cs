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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Provider
{
    #region IBaseColumns
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IBaseColumns
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BaseColumns
    public partial class BaseColumns : Android.Provider.IBaseColumns
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/BaseColumns.html#_COUNT"/>
        /// </summary>
        public static Java.Lang.String _COUNT { get { if (!__COUNTReady) { __COUNTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "_COUNT"); __COUNTReady = true; } return __COUNTContent; } }
        private static Java.Lang.String __COUNTContent = default;
        private static bool __COUNTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/BaseColumns.html#_ID"/>
        /// </summary>
        public static Java.Lang.String _ID { get { if (!__IDReady) { __IDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "_ID"); __IDReady = true; } return __IDContent; } }
        private static Java.Lang.String __IDContent = default;
        private static bool __IDReady = false; // this is used because in case of generics 

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