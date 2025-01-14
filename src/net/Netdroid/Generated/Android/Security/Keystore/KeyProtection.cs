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

namespace Android.Security.Keystore
{
    #region KeyProtection declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.html"/>
    /// </summary>
    public partial class KeyProtection : Java.Security.KeyStore.ProtectionParameter
    {
        const string _bridgeClassName = "android.security.keystore.KeyProtection";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public KeyProtection() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public KeyProtection(params object[] args) : base(args) { }
    
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
        #region Builder declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.security.keystore.KeyProtection$Builder";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Builder() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Builder(params object[] args) : base(args) { }
        
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

    #region KeyProtection implementation
    public partial class KeyProtection
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.html#isDigestsSpecified()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDigestsSpecified()
        {
            return IExecuteWithSignature<bool>("isDigestsSpecified", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.html#isInvalidatedByBiometricEnrollment()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsInvalidatedByBiometricEnrollment()
        {
            return IExecuteWithSignature<bool>("isInvalidatedByBiometricEnrollment", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.html#isMgf1DigestsSpecified()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsMgf1DigestsSpecified()
        {
            return IExecuteWithSignature<bool>("isMgf1DigestsSpecified", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.html#isRandomizedEncryptionRequired()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRandomizedEncryptionRequired()
        {
            return IExecuteWithSignature<bool>("isRandomizedEncryptionRequired", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.html#isUnlockedDeviceRequired()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUnlockedDeviceRequired()
        {
            return IExecuteWithSignature<bool>("isUnlockedDeviceRequired", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.html#isUserAuthenticationRequired()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUserAuthenticationRequired()
        {
            return IExecuteWithSignature<bool>("isUserAuthenticationRequired", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.html#isUserAuthenticationValidWhileOnBody()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUserAuthenticationValidWhileOnBody()
        {
            return IExecuteWithSignature<bool>("isUserAuthenticationValidWhileOnBody", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.html#isUserConfirmationRequired()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUserConfirmationRequired()
        {
            return IExecuteWithSignature<bool>("isUserConfirmationRequired", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.html#isUserPresenceRequired()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUserPresenceRequired()
        {
            return IExecuteWithSignature<bool>("isUserPresenceRequired", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.html#getMaxUsageCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaxUsageCount()
        {
            return IExecuteWithSignature<int>("getMaxUsageCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.html#getPurposes()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPurposes()
        {
            return IExecuteWithSignature<int>("getPurposes", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.html#getUserAuthenticationType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetUserAuthenticationType()
        {
            return IExecuteWithSignature<int>("getUserAuthenticationType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.html#getUserAuthenticationValidityDurationSeconds()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetUserAuthenticationValidityDurationSeconds()
        {
            return IExecuteWithSignature<int>("getUserAuthenticationValidityDurationSeconds", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.html#getBlockModes()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetBlockModes()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getBlockModes", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.html#getDigests()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetDigests()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getDigests", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.html#getEncryptionPaddings()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetEncryptionPaddings()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getEncryptionPaddings", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.html#getSignaturePaddings()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetSignaturePaddings()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getSignaturePaddings", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.html#getKeyValidityForConsumptionEnd()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Date"/></returns>
        public Java.Util.Date GetKeyValidityForConsumptionEnd()
        {
            return IExecuteWithSignature<Java.Util.Date>("getKeyValidityForConsumptionEnd", "()Ljava/util/Date;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.html#getKeyValidityForOriginationEnd()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Date"/></returns>
        public Java.Util.Date GetKeyValidityForOriginationEnd()
        {
            return IExecuteWithSignature<Java.Util.Date>("getKeyValidityForOriginationEnd", "()Ljava/util/Date;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.html#getKeyValidityStart()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Date"/></returns>
        public Java.Util.Date GetKeyValidityStart()
        {
            return IExecuteWithSignature<Java.Util.Date>("getKeyValidityStart", "()Ljava/util/Date;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.html#getMgf1Digests()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> GetMgf1Digests()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getMgf1Digests", "()Ljava/util/Set;");
        }
    
        #endregion
    
        #region Nested classes
        #region Builder implementation
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.Builder.html#%3Cinit%3E(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public Builder(int arg0)
                : base(arg0)
            {
            }
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Security.Keystore.KeyProtection"/></returns>
            public Android.Security.Keystore.KeyProtection Build()
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyProtection>("build", "()Landroid/security/keystore/KeyProtection;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.Builder.html#setBlockModes(java.lang.String[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyProtection.Builder"/></returns>
            public Android.Security.Keystore.KeyProtection.Builder SetBlockModes(params Java.Lang.String[] arg0)
            {
                if (arg0.Length == 0) return IExecuteWithSignature<Android.Security.Keystore.KeyProtection.Builder>("setBlockModes", "([Ljava/lang/String;)Landroid/security/keystore/KeyProtection$Builder;"); else return IExecuteWithSignature<Android.Security.Keystore.KeyProtection.Builder>("setBlockModes", "([Ljava/lang/String;)Landroid/security/keystore/KeyProtection$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.Builder.html#setDigests(java.lang.String[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyProtection.Builder"/></returns>
            public Android.Security.Keystore.KeyProtection.Builder SetDigests(params Java.Lang.String[] arg0)
            {
                if (arg0.Length == 0) return IExecuteWithSignature<Android.Security.Keystore.KeyProtection.Builder>("setDigests", "([Ljava/lang/String;)Landroid/security/keystore/KeyProtection$Builder;"); else return IExecuteWithSignature<Android.Security.Keystore.KeyProtection.Builder>("setDigests", "([Ljava/lang/String;)Landroid/security/keystore/KeyProtection$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.Builder.html#setEncryptionPaddings(java.lang.String[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyProtection.Builder"/></returns>
            public Android.Security.Keystore.KeyProtection.Builder SetEncryptionPaddings(params Java.Lang.String[] arg0)
            {
                if (arg0.Length == 0) return IExecuteWithSignature<Android.Security.Keystore.KeyProtection.Builder>("setEncryptionPaddings", "([Ljava/lang/String;)Landroid/security/keystore/KeyProtection$Builder;"); else return IExecuteWithSignature<Android.Security.Keystore.KeyProtection.Builder>("setEncryptionPaddings", "([Ljava/lang/String;)Landroid/security/keystore/KeyProtection$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.Builder.html#setInvalidatedByBiometricEnrollment(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyProtection.Builder"/></returns>
            public Android.Security.Keystore.KeyProtection.Builder SetInvalidatedByBiometricEnrollment(bool arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyProtection.Builder>("setInvalidatedByBiometricEnrollment", "(Z)Landroid/security/keystore/KeyProtection$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.Builder.html#setIsStrongBoxBacked(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyProtection.Builder"/></returns>
            public Android.Security.Keystore.KeyProtection.Builder SetIsStrongBoxBacked(bool arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyProtection.Builder>("setIsStrongBoxBacked", "(Z)Landroid/security/keystore/KeyProtection$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.Builder.html#setKeyValidityEnd(java.util.Date)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Date"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyProtection.Builder"/></returns>
            public Android.Security.Keystore.KeyProtection.Builder SetKeyValidityEnd(Java.Util.Date arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyProtection.Builder>("setKeyValidityEnd", "(Ljava/util/Date;)Landroid/security/keystore/KeyProtection$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.Builder.html#setKeyValidityForConsumptionEnd(java.util.Date)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Date"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyProtection.Builder"/></returns>
            public Android.Security.Keystore.KeyProtection.Builder SetKeyValidityForConsumptionEnd(Java.Util.Date arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyProtection.Builder>("setKeyValidityForConsumptionEnd", "(Ljava/util/Date;)Landroid/security/keystore/KeyProtection$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.Builder.html#setKeyValidityForOriginationEnd(java.util.Date)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Date"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyProtection.Builder"/></returns>
            public Android.Security.Keystore.KeyProtection.Builder SetKeyValidityForOriginationEnd(Java.Util.Date arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyProtection.Builder>("setKeyValidityForOriginationEnd", "(Ljava/util/Date;)Landroid/security/keystore/KeyProtection$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.Builder.html#setKeyValidityStart(java.util.Date)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Date"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyProtection.Builder"/></returns>
            public Android.Security.Keystore.KeyProtection.Builder SetKeyValidityStart(Java.Util.Date arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyProtection.Builder>("setKeyValidityStart", "(Ljava/util/Date;)Landroid/security/keystore/KeyProtection$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.Builder.html#setMaxUsageCount(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyProtection.Builder"/></returns>
            public Android.Security.Keystore.KeyProtection.Builder SetMaxUsageCount(int arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyProtection.Builder>("setMaxUsageCount", "(I)Landroid/security/keystore/KeyProtection$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.Builder.html#setMgf1Digests(java.lang.String[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyProtection.Builder"/></returns>
            public Android.Security.Keystore.KeyProtection.Builder SetMgf1Digests(params Java.Lang.String[] arg0)
            {
                if (arg0.Length == 0) return IExecuteWithSignature<Android.Security.Keystore.KeyProtection.Builder>("setMgf1Digests", "([Ljava/lang/String;)Landroid/security/keystore/KeyProtection$Builder;"); else return IExecuteWithSignature<Android.Security.Keystore.KeyProtection.Builder>("setMgf1Digests", "([Ljava/lang/String;)Landroid/security/keystore/KeyProtection$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.Builder.html#setRandomizedEncryptionRequired(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyProtection.Builder"/></returns>
            public Android.Security.Keystore.KeyProtection.Builder SetRandomizedEncryptionRequired(bool arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyProtection.Builder>("setRandomizedEncryptionRequired", "(Z)Landroid/security/keystore/KeyProtection$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.Builder.html#setSignaturePaddings(java.lang.String[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyProtection.Builder"/></returns>
            public Android.Security.Keystore.KeyProtection.Builder SetSignaturePaddings(params Java.Lang.String[] arg0)
            {
                if (arg0.Length == 0) return IExecuteWithSignature<Android.Security.Keystore.KeyProtection.Builder>("setSignaturePaddings", "([Ljava/lang/String;)Landroid/security/keystore/KeyProtection$Builder;"); else return IExecuteWithSignature<Android.Security.Keystore.KeyProtection.Builder>("setSignaturePaddings", "([Ljava/lang/String;)Landroid/security/keystore/KeyProtection$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.Builder.html#setUnlockedDeviceRequired(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyProtection.Builder"/></returns>
            public Android.Security.Keystore.KeyProtection.Builder SetUnlockedDeviceRequired(bool arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyProtection.Builder>("setUnlockedDeviceRequired", "(Z)Landroid/security/keystore/KeyProtection$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.Builder.html#setUserAuthenticationParameters(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyProtection.Builder"/></returns>
            public Android.Security.Keystore.KeyProtection.Builder SetUserAuthenticationParameters(int arg0, int arg1)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyProtection.Builder>("setUserAuthenticationParameters", "(II)Landroid/security/keystore/KeyProtection$Builder;", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.Builder.html#setUserAuthenticationRequired(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyProtection.Builder"/></returns>
            public Android.Security.Keystore.KeyProtection.Builder SetUserAuthenticationRequired(bool arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyProtection.Builder>("setUserAuthenticationRequired", "(Z)Landroid/security/keystore/KeyProtection$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.Builder.html#setUserAuthenticationValidityDurationSeconds(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyProtection.Builder"/></returns>
            [global::System.Obsolete()]
            public Android.Security.Keystore.KeyProtection.Builder SetUserAuthenticationValidityDurationSeconds(int arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyProtection.Builder>("setUserAuthenticationValidityDurationSeconds", "(I)Landroid/security/keystore/KeyProtection$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.Builder.html#setUserAuthenticationValidWhileOnBody(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyProtection.Builder"/></returns>
            public Android.Security.Keystore.KeyProtection.Builder SetUserAuthenticationValidWhileOnBody(bool arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyProtection.Builder>("setUserAuthenticationValidWhileOnBody", "(Z)Landroid/security/keystore/KeyProtection$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.Builder.html#setUserConfirmationRequired(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyProtection.Builder"/></returns>
            public Android.Security.Keystore.KeyProtection.Builder SetUserConfirmationRequired(bool arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyProtection.Builder>("setUserConfirmationRequired", "(Z)Landroid/security/keystore/KeyProtection$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyProtection.Builder.html#setUserPresenceRequired(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyProtection.Builder"/></returns>
            public Android.Security.Keystore.KeyProtection.Builder SetUserPresenceRequired(bool arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyProtection.Builder>("setUserPresenceRequired", "(Z)Landroid/security/keystore/KeyProtection$Builder;", arg0);
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