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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Provider
{
    #region E2eeContactKeysManager declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.html"/>
    /// </summary>
    public partial class E2eeContactKeysManager : MASES.JCOBridge.C2JBridge.JVMBridgeBase<E2eeContactKeysManager>
    {
        const string _bridgeClassName = "android.provider.E2eeContactKeysManager";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public E2eeContactKeysManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public E2eeContactKeysManager(params object[] args) : base(args) { }
    
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
        #region E2eeContactKey declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.E2eeContactKey.html"/>
        /// </summary>
        public partial class E2eeContactKey : Android.Os.Parcelable
        {
            const string _bridgeClassName = "android.provider.E2eeContactKeysManager$E2eeContactKey";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public E2eeContactKey() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public E2eeContactKey(params object[] args) : base(args) { }
        
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

        #region E2eeSelfKey declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.E2eeSelfKey.html"/>
        /// </summary>
        public partial class E2eeSelfKey : Android.Os.Parcelable
        {
            const string _bridgeClassName = "android.provider.E2eeContactKeysManager$E2eeSelfKey";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public E2eeSelfKey() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public E2eeSelfKey(params object[] args) : base(args) { }
        
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

    #region E2eeContactKeysManager implementation
    public partial class E2eeContactKeysManager
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.html#VERIFICATION_STATE_UNVERIFIED"/>
        /// </summary>
        public static int VERIFICATION_STATE_UNVERIFIED { get { if (!_VERIFICATION_STATE_UNVERIFIEDReady) { _VERIFICATION_STATE_UNVERIFIEDContent = SGetField<int>(LocalBridgeClazz, "VERIFICATION_STATE_UNVERIFIED"); _VERIFICATION_STATE_UNVERIFIEDReady = true; } return _VERIFICATION_STATE_UNVERIFIEDContent; } }
        private static int _VERIFICATION_STATE_UNVERIFIEDContent = default;
        private static bool _VERIFICATION_STATE_UNVERIFIEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.html#VERIFICATION_STATE_VERIFICATION_FAILED"/>
        /// </summary>
        public static int VERIFICATION_STATE_VERIFICATION_FAILED { get { if (!_VERIFICATION_STATE_VERIFICATION_FAILEDReady) { _VERIFICATION_STATE_VERIFICATION_FAILEDContent = SGetField<int>(LocalBridgeClazz, "VERIFICATION_STATE_VERIFICATION_FAILED"); _VERIFICATION_STATE_VERIFICATION_FAILEDReady = true; } return _VERIFICATION_STATE_VERIFICATION_FAILEDContent; } }
        private static int _VERIFICATION_STATE_VERIFICATION_FAILEDContent = default;
        private static bool _VERIFICATION_STATE_VERIFICATION_FAILEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.html#VERIFICATION_STATE_VERIFIED"/>
        /// </summary>
        public static int VERIFICATION_STATE_VERIFIED { get { if (!_VERIFICATION_STATE_VERIFIEDReady) { _VERIFICATION_STATE_VERIFIEDContent = SGetField<int>(LocalBridgeClazz, "VERIFICATION_STATE_VERIFIED"); _VERIFICATION_STATE_VERIFIEDReady = true; } return _VERIFICATION_STATE_VERIFIEDContent; } }
        private static int _VERIFICATION_STATE_VERIFIEDContent = default;
        private static bool _VERIFICATION_STATE_VERIFIEDReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.html#getMaxKeySizeBytes()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int GetMaxKeySizeBytes()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getMaxKeySizeBytes", "()I");
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.html#getE2eeContactKey(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Provider.E2eeContactKeysManager.E2eeContactKey"/></returns>
        public Android.Provider.E2eeContactKeysManager.E2eeContactKey GetE2eeContactKey(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            return IExecuteWithSignature<Android.Provider.E2eeContactKeysManager.E2eeContactKey>("getE2eeContactKey", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/provider/E2eeContactKeysManager$E2eeContactKey;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.html#getE2eeSelfKey(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Provider.E2eeContactKeysManager.E2eeSelfKey"/></returns>
        public Android.Provider.E2eeContactKeysManager.E2eeSelfKey GetE2eeSelfKey(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecuteWithSignature<Android.Provider.E2eeContactKeysManager.E2eeSelfKey>("getE2eeSelfKey", "(Ljava/lang/String;Ljava/lang/String;)Landroid/provider/E2eeContactKeysManager$E2eeSelfKey;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.html#removeE2eeContactKey(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveE2eeContactKey(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            return IExecuteWithSignature<bool>("removeE2eeContactKey", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Z", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.html#removeE2eeSelfKey(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveE2eeSelfKey(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecuteWithSignature<bool>("removeE2eeSelfKey", "(Ljava/lang/String;Ljava/lang/String;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.html#updateE2eeContactKeyLocalVerificationState(java.lang.String,java.lang.String,java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool UpdateE2eeContactKeyLocalVerificationState(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, int arg3)
        {
            return IExecuteWithSignature<bool>("updateE2eeContactKeyLocalVerificationState", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)Z", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.html#updateE2eeContactKeyRemoteVerificationState(java.lang.String,java.lang.String,java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool UpdateE2eeContactKeyRemoteVerificationState(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, int arg3)
        {
            return IExecuteWithSignature<bool>("updateE2eeContactKeyRemoteVerificationState", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)Z", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.html#updateE2eeSelfKeyRemoteVerificationState(java.lang.String,java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool UpdateE2eeSelfKeyRemoteVerificationState(Java.Lang.String arg0, Java.Lang.String arg1, int arg2)
        {
            return IExecuteWithSignature<bool>("updateE2eeSelfKeyRemoteVerificationState", "(Ljava/lang/String;Ljava/lang/String;I)Z", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.html#updateOrInsertE2eeSelfKey(java.lang.String,java.lang.String,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool UpdateOrInsertE2eeSelfKey(Java.Lang.String arg0, Java.Lang.String arg1, byte[] arg2)
        {
            return IExecuteWithSignature<bool>("updateOrInsertE2eeSelfKey", "(Ljava/lang/String;Ljava/lang/String;[B)Z", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.html#getAllE2eeContactKeys(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Provider.E2eeContactKeysManager.E2eeContactKey> GetAllE2eeContactKeys(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.List<Android.Provider.E2eeContactKeysManager.E2eeContactKey>>("getAllE2eeContactKeys", "(Ljava/lang/String;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.html#getOwnerE2eeContactKeys(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Provider.E2eeContactKeysManager.E2eeContactKey> GetOwnerE2eeContactKeys(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.List<Android.Provider.E2eeContactKeysManager.E2eeContactKey>>("getOwnerE2eeContactKeys", "(Ljava/lang/String;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.html#getAllE2eeSelfKeys()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Provider.E2eeContactKeysManager.E2eeSelfKey> GetAllE2eeSelfKeys()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Provider.E2eeContactKeysManager.E2eeSelfKey>>("getAllE2eeSelfKeys", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.html#getOwnerE2eeSelfKeys()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Provider.E2eeContactKeysManager.E2eeSelfKey> GetOwnerE2eeSelfKeys()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Provider.E2eeContactKeysManager.E2eeSelfKey>>("getOwnerE2eeSelfKeys", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.html#updateOrInsertE2eeContactKey(java.lang.String,java.lang.String,java.lang.String,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="byte"/></param>
        public void UpdateOrInsertE2eeContactKey(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, byte[] arg3)
        {
            IExecuteWithSignature("updateOrInsertE2eeContactKey", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[B)V", arg0, arg1, arg2, arg3);
        }
    
        #endregion
    
        #region Nested classes
        #region E2eeContactKey implementation
        public partial class E2eeContactKey
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.E2eeContactKey.html#CREATOR"/>
            /// </summary>
            public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
            private static Android.Os.Parcelable.Creator _CREATORContent = default;
            private static bool _CREATORReady = false; // this is used because in case of generics 
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.E2eeContactKey.html#getKeyValue()"/>
            /// </summary>
            /// <returns><see cref="byte"/></returns>
            public byte[] GetKeyValue()
            {
                return IExecuteWithSignatureArray<byte>("getKeyValue", "()[B");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.E2eeContactKey.html#describeContents()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int DescribeContents()
            {
                return IExecuteWithSignature<int>("describeContents", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.E2eeContactKey.html#getLocalVerificationState()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetLocalVerificationState()
            {
                return IExecuteWithSignature<int>("getLocalVerificationState", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.E2eeContactKey.html#getRemoteVerificationState()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetRemoteVerificationState()
            {
                return IExecuteWithSignature<int>("getRemoteVerificationState", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.E2eeContactKey.html#getAccountId()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetAccountId()
            {
                return IExecuteWithSignature<Java.Lang.String>("getAccountId", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.E2eeContactKey.html#getDeviceId()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetDeviceId()
            {
                return IExecuteWithSignature<Java.Lang.String>("getDeviceId", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.E2eeContactKey.html#getDisplayName()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetDisplayName()
            {
                return IExecuteWithSignature<Java.Lang.String>("getDisplayName", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.E2eeContactKey.html#getEmailAddress()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetEmailAddress()
            {
                return IExecuteWithSignature<Java.Lang.String>("getEmailAddress", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.E2eeContactKey.html#getOwnerPackageName()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetOwnerPackageName()
            {
                return IExecuteWithSignature<Java.Lang.String>("getOwnerPackageName", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.E2eeContactKey.html#getPhoneNumber()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetPhoneNumber()
            {
                return IExecuteWithSignature<Java.Lang.String>("getPhoneNumber", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.E2eeContactKey.html#getTimeUpdated()"/>
            /// </summary>
            /// <returns><see cref="long"/></returns>
            public long GetTimeUpdated()
            {
                return IExecuteWithSignature<long>("getTimeUpdated", "()J");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.E2eeContactKey.html#writeToParcel(android.os.Parcel,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
            {
                IExecuteWithSignature("writeToParcel", "(Landroid/os/Parcel;I)V", arg0, arg1);
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region E2eeSelfKey implementation
        public partial class E2eeSelfKey
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.E2eeSelfKey.html#CREATOR"/>
            /// </summary>
            public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
            private static Android.Os.Parcelable.Creator _CREATORContent = default;
            private static bool _CREATORReady = false; // this is used because in case of generics 
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.E2eeSelfKey.html#getKeyValue()"/>
            /// </summary>
            /// <returns><see cref="byte"/></returns>
            public byte[] GetKeyValue()
            {
                return IExecuteWithSignatureArray<byte>("getKeyValue", "()[B");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.E2eeSelfKey.html#describeContents()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int DescribeContents()
            {
                return IExecuteWithSignature<int>("describeContents", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.E2eeSelfKey.html#getRemoteVerificationState()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetRemoteVerificationState()
            {
                return IExecuteWithSignature<int>("getRemoteVerificationState", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.E2eeSelfKey.html#getAccountId()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetAccountId()
            {
                return IExecuteWithSignature<Java.Lang.String>("getAccountId", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.E2eeSelfKey.html#getDeviceId()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetDeviceId()
            {
                return IExecuteWithSignature<Java.Lang.String>("getDeviceId", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.E2eeSelfKey.html#getOwnerPackageName()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetOwnerPackageName()
            {
                return IExecuteWithSignature<Java.Lang.String>("getOwnerPackageName", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.E2eeSelfKey.html#getTimeUpdated()"/>
            /// </summary>
            /// <returns><see cref="long"/></returns>
            public long GetTimeUpdated()
            {
                return IExecuteWithSignature<long>("getTimeUpdated", "()J");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/E2eeContactKeysManager.E2eeSelfKey.html#writeToParcel(android.os.Parcel,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
            {
                IExecuteWithSignature("writeToParcel", "(Landroid/os/Parcel;I)V", arg0, arg1);
            }
        
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