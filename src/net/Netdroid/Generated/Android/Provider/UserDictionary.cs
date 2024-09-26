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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Provider
{
    #region UserDictionary declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/provider/UserDictionary.html"/>
    /// </summary>
    public partial class UserDictionary : MASES.JCOBridge.C2JBridge.JVMBridgeBase<UserDictionary>
    {
        const string _bridgeClassName = "android.provider.UserDictionary";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public UserDictionary() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public UserDictionary(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
        #region Words declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/UserDictionary.Words.html"/>
        /// </summary>
        public partial class Words : Android.Provider.BaseColumns
        {
            const string _bridgeClassName = "android.provider.UserDictionary$Words";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Words() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Words(params object[] args) : base(args) { }

            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
            /// </summary>
            public override bool IsBridgeCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
            /// </summary>
            public override bool IsBridgeInterface => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region UserDictionary implementation
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
        #region Words implementation
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
            /// <see href="https://developer.android.com/reference/android/provider/UserDictionary.Words.html#LOCALE_TYPE_ALL"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int LOCALE_TYPE_ALL { get { if (!_LOCALE_TYPE_ALLReady) { _LOCALE_TYPE_ALLContent = SGetField<int>(LocalBridgeClazz, "LOCALE_TYPE_ALL"); _LOCALE_TYPE_ALLReady = true; } return _LOCALE_TYPE_ALLContent; } }
            private static int _LOCALE_TYPE_ALLContent = default;
            private static bool _LOCALE_TYPE_ALLReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/UserDictionary.Words.html#LOCALE_TYPE_CURRENT"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int LOCALE_TYPE_CURRENT { get { if (!_LOCALE_TYPE_CURRENTReady) { _LOCALE_TYPE_CURRENTContent = SGetField<int>(LocalBridgeClazz, "LOCALE_TYPE_CURRENT"); _LOCALE_TYPE_CURRENTReady = true; } return _LOCALE_TYPE_CURRENTContent; } }
            private static int _LOCALE_TYPE_CURRENTContent = default;
            private static bool _LOCALE_TYPE_CURRENTReady = false; // this is used because in case of generics 
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
            /// <see href="https://developer.android.com/reference/android/provider/UserDictionary.Words.html#addWord(android.content.Context,java.lang.String,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Context"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            [global::System.Obsolete()]
            public static void AddWord(Android.Content.Context arg0, Java.Lang.String arg1, int arg2, int arg3)
            {
                SExecuteWithSignature(LocalBridgeClazz, "addWord", "(Landroid/content/Context;Ljava/lang/String;II)V", arg0, arg1, arg2, arg3);
            }
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
                SExecuteWithSignature(LocalBridgeClazz, "addWord", "(Landroid/content/Context;Ljava/lang/String;ILjava/lang/String;Ljava/util/Locale;)V", arg0, arg1, arg2, arg3, arg4);
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