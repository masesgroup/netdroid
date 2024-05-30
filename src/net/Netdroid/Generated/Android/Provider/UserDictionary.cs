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
    #region UserDictionary
    public partial class UserDictionary
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/UserDictionary.html#CONTENT_URI"/>
        /// </summary>
        public static Android.Net.Uri CONTENT_URI { get { if (!_CONTENT_URIReady) { _CONTENT_URIContent = SGetField<Android.Net.Uri>(LocalBridgeClazz, "CONTENT_URI"); _CONTENT_URIReady = true; } return _CONTENT_URIContent; } }
        private static Android.Net.Uri _CONTENT_URIContent = default;
        private static bool _CONTENT_URIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/UserDictionary.html#AUTHORITY"/>
        /// </summary>
        public static Java.Lang.String AUTHORITY { get { if (!_AUTHORITYReady) { _AUTHORITYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "AUTHORITY"); _AUTHORITYReady = true; } return _AUTHORITYContent; } }
        private static Java.Lang.String _AUTHORITYContent = default;
        private static bool _AUTHORITYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region Words
        public partial class Words
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/UserDictionary.Words.html#CONTENT_URI"/>
            /// </summary>
            public static Android.Net.Uri CONTENT_URI { get { if (!_CONTENT_URIReady) { _CONTENT_URIContent = SGetField<Android.Net.Uri>(LocalBridgeClazz, "CONTENT_URI"); _CONTENT_URIReady = true; } return _CONTENT_URIContent; } }
            private static Android.Net.Uri _CONTENT_URIContent = default;
            private static bool _CONTENT_URIReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/UserDictionary.Words.html#_ID"/>
            /// </summary>
            public static Java.Lang.String _ID { get { if (!__IDReady) { __IDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "_ID"); __IDReady = true; } return __IDContent; } }
            private static Java.Lang.String __IDContent = default;
            private static bool __IDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/UserDictionary.Words.html#APP_ID"/>
            /// </summary>
            public static Java.Lang.String APP_ID { get { if (!_APP_IDReady) { _APP_IDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "APP_ID"); _APP_IDReady = true; } return _APP_IDContent; } }
            private static Java.Lang.String _APP_IDContent = default;
            private static bool _APP_IDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/UserDictionary.Words.html#CONTENT_ITEM_TYPE"/>
            /// </summary>
            public static Java.Lang.String CONTENT_ITEM_TYPE { get { if (!_CONTENT_ITEM_TYPEReady) { _CONTENT_ITEM_TYPEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CONTENT_ITEM_TYPE"); _CONTENT_ITEM_TYPEReady = true; } return _CONTENT_ITEM_TYPEContent; } }
            private static Java.Lang.String _CONTENT_ITEM_TYPEContent = default;
            private static bool _CONTENT_ITEM_TYPEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/UserDictionary.Words.html#CONTENT_TYPE"/>
            /// </summary>
            public static Java.Lang.String CONTENT_TYPE { get { if (!_CONTENT_TYPEReady) { _CONTENT_TYPEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CONTENT_TYPE"); _CONTENT_TYPEReady = true; } return _CONTENT_TYPEContent; } }
            private static Java.Lang.String _CONTENT_TYPEContent = default;
            private static bool _CONTENT_TYPEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/UserDictionary.Words.html#DEFAULT_SORT_ORDER"/>
            /// </summary>
            public static Java.Lang.String DEFAULT_SORT_ORDER { get { if (!_DEFAULT_SORT_ORDERReady) { _DEFAULT_SORT_ORDERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DEFAULT_SORT_ORDER"); _DEFAULT_SORT_ORDERReady = true; } return _DEFAULT_SORT_ORDERContent; } }
            private static Java.Lang.String _DEFAULT_SORT_ORDERContent = default;
            private static bool _DEFAULT_SORT_ORDERReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/UserDictionary.Words.html#FREQUENCY"/>
            /// </summary>
            public static Java.Lang.String FREQUENCY { get { if (!_FREQUENCYReady) { _FREQUENCYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FREQUENCY"); _FREQUENCYReady = true; } return _FREQUENCYContent; } }
            private static Java.Lang.String _FREQUENCYContent = default;
            private static bool _FREQUENCYReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/UserDictionary.Words.html#LOCALE"/>
            /// </summary>
            public static Java.Lang.String LOCALE { get { if (!_LOCALEReady) { _LOCALEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "LOCALE"); _LOCALEReady = true; } return _LOCALEContent; } }
            private static Java.Lang.String _LOCALEContent = default;
            private static bool _LOCALEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/UserDictionary.Words.html#SHORTCUT"/>
            /// </summary>
            public static Java.Lang.String SHORTCUT { get { if (!_SHORTCUTReady) { _SHORTCUTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SHORTCUT"); _SHORTCUTReady = true; } return _SHORTCUTContent; } }
            private static Java.Lang.String _SHORTCUTContent = default;
            private static bool _SHORTCUTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/UserDictionary.Words.html#WORD"/>
            /// </summary>
            public static Java.Lang.String WORD { get { if (!_WORDReady) { _WORDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "WORD"); _WORDReady = true; } return _WORDContent; } }
            private static Java.Lang.String _WORDContent = default;
            private static bool _WORDReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/UserDictionary.Words.html#addWord(android.content.Context,java.lang.String,int,java.lang.String,java.util.Locale)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Context"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="Java.Lang.String"/></param>
            /// <param name="arg4"><see cref="Java.Util.Locale"/></param>
            public static void AddWord(Android.Content.Context arg0, Java.Lang.String arg1, int arg2, Java.Lang.String arg3, Java.Util.Locale arg4)
            {
                SExecute(LocalBridgeClazz, "addWord", arg0, arg1, arg2, arg3, arg4);
            }

            #endregion

            #region Instance methods

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