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
    #region BlockedNumberContract declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/provider/BlockedNumberContract.html"/>
    /// </summary>
    public partial class BlockedNumberContract : MASES.JCOBridge.C2JBridge.JVMBridgeBase<BlockedNumberContract>
    {
        const string _bridgeClassName = "android.provider.BlockedNumberContract";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public BlockedNumberContract() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public BlockedNumberContract(params object[] args) : base(args) { }

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
        #region BlockedNumbers declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/BlockedNumberContract.BlockedNumbers.html"/>
        /// </summary>
        public partial class BlockedNumbers : MASES.JCOBridge.C2JBridge.JVMBridgeBase<BlockedNumbers>
        {
            const string _bridgeClassName = "android.provider.BlockedNumberContract$BlockedNumbers";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public BlockedNumbers() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public BlockedNumbers(params object[] args) : base(args) { }

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

    #region BlockedNumberContract implementation
    public partial class BlockedNumberContract
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/BlockedNumberContract.html#AUTHORITY_URI"/>
        /// </summary>
        public static Android.Net.Uri AUTHORITY_URI { get { if (!_AUTHORITY_URIReady) { _AUTHORITY_URIContent = SGetField<Android.Net.Uri>(LocalBridgeClazz, "AUTHORITY_URI"); _AUTHORITY_URIReady = true; } return _AUTHORITY_URIContent; } }
        private static Android.Net.Uri _AUTHORITY_URIContent = default;
        private static bool _AUTHORITY_URIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/BlockedNumberContract.html#AUTHORITY"/>
        /// </summary>
        public static Java.Lang.String AUTHORITY { get { if (!_AUTHORITYReady) { _AUTHORITYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "AUTHORITY"); _AUTHORITYReady = true; } return _AUTHORITYContent; } }
        private static Java.Lang.String _AUTHORITYContent = default;
        private static bool _AUTHORITYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/BlockedNumberContract.html#canCurrentUserBlockNumbers(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool CanCurrentUserBlockNumbers(Android.Content.Context arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "canCurrentUserBlockNumbers", "(Landroid/content/Context;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/BlockedNumberContract.html#isBlocked(android.content.Context,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsBlocked(Android.Content.Context arg0, Java.Lang.String arg1)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isBlocked", "(Landroid/content/Context;Ljava/lang/String;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/BlockedNumberContract.html#unblock(android.content.Context,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Unblock(Android.Content.Context arg0, Java.Lang.String arg1)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "unblock", "(Landroid/content/Context;Ljava/lang/String;)I", arg0, arg1);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region BlockedNumbers implementation
        public partial class BlockedNumbers
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/BlockedNumberContract.BlockedNumbers.html#CONTENT_URI"/>
            /// </summary>
            public static Android.Net.Uri CONTENT_URI { get { if (!_CONTENT_URIReady) { _CONTENT_URIContent = SGetField<Android.Net.Uri>(LocalBridgeClazz, "CONTENT_URI"); _CONTENT_URIReady = true; } return _CONTENT_URIContent; } }
            private static Android.Net.Uri _CONTENT_URIContent = default;
            private static bool _CONTENT_URIReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/BlockedNumberContract.BlockedNumbers.html#COLUMN_E164_NUMBER"/>
            /// </summary>
            public static Java.Lang.String COLUMN_E164_NUMBER { get { if (!_COLUMN_E164_NUMBERReady) { _COLUMN_E164_NUMBERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "COLUMN_E164_NUMBER"); _COLUMN_E164_NUMBERReady = true; } return _COLUMN_E164_NUMBERContent; } }
            private static Java.Lang.String _COLUMN_E164_NUMBERContent = default;
            private static bool _COLUMN_E164_NUMBERReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/BlockedNumberContract.BlockedNumbers.html#COLUMN_ID"/>
            /// </summary>
            public static Java.Lang.String COLUMN_ID { get { if (!_COLUMN_IDReady) { _COLUMN_IDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "COLUMN_ID"); _COLUMN_IDReady = true; } return _COLUMN_IDContent; } }
            private static Java.Lang.String _COLUMN_IDContent = default;
            private static bool _COLUMN_IDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/BlockedNumberContract.BlockedNumbers.html#COLUMN_ORIGINAL_NUMBER"/>
            /// </summary>
            public static Java.Lang.String COLUMN_ORIGINAL_NUMBER { get { if (!_COLUMN_ORIGINAL_NUMBERReady) { _COLUMN_ORIGINAL_NUMBERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "COLUMN_ORIGINAL_NUMBER"); _COLUMN_ORIGINAL_NUMBERReady = true; } return _COLUMN_ORIGINAL_NUMBERContent; } }
            private static Java.Lang.String _COLUMN_ORIGINAL_NUMBERContent = default;
            private static bool _COLUMN_ORIGINAL_NUMBERReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/BlockedNumberContract.BlockedNumbers.html#CONTENT_ITEM_TYPE"/>
            /// </summary>
            public static Java.Lang.String CONTENT_ITEM_TYPE { get { if (!_CONTENT_ITEM_TYPEReady) { _CONTENT_ITEM_TYPEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CONTENT_ITEM_TYPE"); _CONTENT_ITEM_TYPEReady = true; } return _CONTENT_ITEM_TYPEContent; } }
            private static Java.Lang.String _CONTENT_ITEM_TYPEContent = default;
            private static bool _CONTENT_ITEM_TYPEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/BlockedNumberContract.BlockedNumbers.html#CONTENT_TYPE"/>
            /// </summary>
            public static Java.Lang.String CONTENT_TYPE { get { if (!_CONTENT_TYPEReady) { _CONTENT_TYPEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CONTENT_TYPE"); _CONTENT_TYPEReady = true; } return _CONTENT_TYPEContent; } }
            private static Java.Lang.String _CONTENT_TYPEContent = default;
            private static bool _CONTENT_TYPEReady = false; // this is used because in case of generics 

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

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}