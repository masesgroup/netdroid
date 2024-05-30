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

namespace Java.Nio.Charset
{
    #region CodingErrorAction
    public partial class CodingErrorAction
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/charset/CodingErrorAction.html#IGNORE"/>
        /// </summary>
        public static Java.Nio.Charset.CodingErrorAction IGNORE { get { if (!_IGNOREReady) { _IGNOREContent = SGetField<Java.Nio.Charset.CodingErrorAction>(LocalBridgeClazz, "IGNORE"); _IGNOREReady = true; } return _IGNOREContent; } }
        private static Java.Nio.Charset.CodingErrorAction _IGNOREContent = default;
        private static bool _IGNOREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/charset/CodingErrorAction.html#REPLACE"/>
        /// </summary>
        public static Java.Nio.Charset.CodingErrorAction REPLACE { get { if (!_REPLACEReady) { _REPLACEContent = SGetField<Java.Nio.Charset.CodingErrorAction>(LocalBridgeClazz, "REPLACE"); _REPLACEReady = true; } return _REPLACEContent; } }
        private static Java.Nio.Charset.CodingErrorAction _REPLACEContent = default;
        private static bool _REPLACEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/charset/CodingErrorAction.html#REPORT"/>
        /// </summary>
        public static Java.Nio.Charset.CodingErrorAction REPORT { get { if (!_REPORTReady) { _REPORTContent = SGetField<Java.Nio.Charset.CodingErrorAction>(LocalBridgeClazz, "REPORT"); _REPORTReady = true; } return _REPORTContent; } }
        private static Java.Nio.Charset.CodingErrorAction _REPORTContent = default;
        private static bool _REPORTReady = false; // this is used because in case of generics 

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