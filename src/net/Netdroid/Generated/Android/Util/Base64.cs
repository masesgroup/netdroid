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

namespace Android.Util
{
    #region Base64 declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/util/Base64.html"/>
    /// </summary>
    public partial class Base64 : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Base64>
    {
        const string _bridgeClassName = "android.util.Base64";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Base64() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Base64(params object[] args) : base(args) { }

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

    }
    #endregion

    #region Base64 implementation
    public partial class Base64
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Base64.html#CRLF"/>
        /// </summary>
        public static int CRLF { get { if (!_CRLFReady) { _CRLFContent = SGetField<int>(LocalBridgeClazz, "CRLF"); _CRLFReady = true; } return _CRLFContent; } }
        private static int _CRLFContent = default;
        private static bool _CRLFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Base64.html#DEFAULT"/>
        /// </summary>
        public static int DEFAULT { get { if (!_DEFAULTReady) { _DEFAULTContent = SGetField<int>(LocalBridgeClazz, "DEFAULT"); _DEFAULTReady = true; } return _DEFAULTContent; } }
        private static int _DEFAULTContent = default;
        private static bool _DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Base64.html#NO_CLOSE"/>
        /// </summary>
        public static int NO_CLOSE { get { if (!_NO_CLOSEReady) { _NO_CLOSEContent = SGetField<int>(LocalBridgeClazz, "NO_CLOSE"); _NO_CLOSEReady = true; } return _NO_CLOSEContent; } }
        private static int _NO_CLOSEContent = default;
        private static bool _NO_CLOSEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Base64.html#NO_PADDING"/>
        /// </summary>
        public static int NO_PADDING { get { if (!_NO_PADDINGReady) { _NO_PADDINGContent = SGetField<int>(LocalBridgeClazz, "NO_PADDING"); _NO_PADDINGReady = true; } return _NO_PADDINGContent; } }
        private static int _NO_PADDINGContent = default;
        private static bool _NO_PADDINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Base64.html#NO_WRAP"/>
        /// </summary>
        public static int NO_WRAP { get { if (!_NO_WRAPReady) { _NO_WRAPContent = SGetField<int>(LocalBridgeClazz, "NO_WRAP"); _NO_WRAPReady = true; } return _NO_WRAPContent; } }
        private static int _NO_WRAPContent = default;
        private static bool _NO_WRAPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Base64.html#URL_SAFE"/>
        /// </summary>
        public static int URL_SAFE { get { if (!_URL_SAFEReady) { _URL_SAFEContent = SGetField<int>(LocalBridgeClazz, "URL_SAFE"); _URL_SAFEReady = true; } return _URL_SAFEContent; } }
        private static int _URL_SAFEContent = default;
        private static bool _URL_SAFEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Base64.html#decode(byte[],int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        public static byte[] Decode(byte[] arg0, int arg1, int arg2, int arg3)
        {
            return SExecuteWithSignatureArray<byte>(LocalBridgeClazz, "decode", "([BIII)[B", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Base64.html#decode(byte[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        public static byte[] Decode(byte[] arg0, int arg1)
        {
            return SExecuteWithSignatureArray<byte>(LocalBridgeClazz, "decode", "([BI)[B", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Base64.html#decode(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        public static byte[] Decode(Java.Lang.String arg0, int arg1)
        {
            return SExecuteWithSignatureArray<byte>(LocalBridgeClazz, "decode", "(Ljava/lang/String;I)[B", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Base64.html#encode(byte[],int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        public static byte[] Encode(byte[] arg0, int arg1, int arg2, int arg3)
        {
            return SExecuteWithSignatureArray<byte>(LocalBridgeClazz, "encode", "([BIII)[B", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Base64.html#encode(byte[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        public static byte[] Encode(byte[] arg0, int arg1)
        {
            return SExecuteWithSignatureArray<byte>(LocalBridgeClazz, "encode", "([BI)[B", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Base64.html#encodeToString(byte[],int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String EncodeToString(byte[] arg0, int arg1, int arg2, int arg3)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "encodeToString", "([BIII)Ljava/lang/String;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Base64.html#encodeToString(byte[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String EncodeToString(byte[] arg0, int arg1)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "encodeToString", "([BI)Ljava/lang/String;", arg0, arg1);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}