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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Security.Keystore
{
    #region KeyGenParameterSpec
    public partial class KeyGenParameterSpec
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
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.html#isDevicePropertiesAttestationIncluded()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDevicePropertiesAttestationIncluded()
        {
            return IExecuteWithSignature<bool>("isDevicePropertiesAttestationIncluded", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.html#isDigestsSpecified()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDigestsSpecified()
        {
            return IExecuteWithSignature<bool>("isDigestsSpecified", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.html#isInvalidatedByBiometricEnrollment()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsInvalidatedByBiometricEnrollment()
        {
            return IExecuteWithSignature<bool>("isInvalidatedByBiometricEnrollment", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.html#isMgf1DigestsSpecified()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsMgf1DigestsSpecified()
        {
            return IExecuteWithSignature<bool>("isMgf1DigestsSpecified", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.html#isRandomizedEncryptionRequired()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRandomizedEncryptionRequired()
        {
            return IExecuteWithSignature<bool>("isRandomizedEncryptionRequired", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.html#isStrongBoxBacked()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsStrongBoxBacked()
        {
            return IExecuteWithSignature<bool>("isStrongBoxBacked", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.html#isUnlockedDeviceRequired()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUnlockedDeviceRequired()
        {
            return IExecuteWithSignature<bool>("isUnlockedDeviceRequired", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.html#isUserAuthenticationRequired()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUserAuthenticationRequired()
        {
            return IExecuteWithSignature<bool>("isUserAuthenticationRequired", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.html#isUserAuthenticationValidWhileOnBody()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUserAuthenticationValidWhileOnBody()
        {
            return IExecuteWithSignature<bool>("isUserAuthenticationValidWhileOnBody", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.html#isUserConfirmationRequired()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUserConfirmationRequired()
        {
            return IExecuteWithSignature<bool>("isUserConfirmationRequired", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.html#isUserPresenceRequired()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUserPresenceRequired()
        {
            return IExecuteWithSignature<bool>("isUserPresenceRequired", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.html#getAttestationChallenge()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetAttestationChallenge()
        {
            return IExecuteWithSignatureArray<byte>("getAttestationChallenge", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.html#getKeySize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetKeySize()
        {
            return IExecuteWithSignature<int>("getKeySize", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.html#getMaxUsageCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaxUsageCount()
        {
            return IExecuteWithSignature<int>("getMaxUsageCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.html#getPurposes()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPurposes()
        {
            return IExecuteWithSignature<int>("getPurposes", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.html#getUserAuthenticationType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetUserAuthenticationType()
        {
            return IExecuteWithSignature<int>("getUserAuthenticationType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.html#getUserAuthenticationValidityDurationSeconds()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetUserAuthenticationValidityDurationSeconds()
        {
            return IExecuteWithSignature<int>("getUserAuthenticationValidityDurationSeconds", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.html#getAttestKeyAlias()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAttestKeyAlias()
        {
            return IExecuteWithSignature<Java.Lang.String>("getAttestKeyAlias", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.html#getKeystoreAlias()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetKeystoreAlias()
        {
            return IExecuteWithSignature<Java.Lang.String>("getKeystoreAlias", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.html#getBlockModes()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetBlockModes()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getBlockModes", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.html#getDigests()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetDigests()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getDigests", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.html#getEncryptionPaddings()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetEncryptionPaddings()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getEncryptionPaddings", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.html#getSignaturePaddings()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetSignaturePaddings()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getSignaturePaddings", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.html#getCertificateSerialNumber()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger GetCertificateSerialNumber()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("getCertificateSerialNumber", "()Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.html#getAlgorithmParameterSpec()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Spec.AlgorithmParameterSpec"/></returns>
        public Java.Security.Spec.AlgorithmParameterSpec GetAlgorithmParameterSpec()
        {
            return IExecuteWithSignature<Java.Security.Spec.AlgorithmParameterSpec>("getAlgorithmParameterSpec", "()Ljava/security/spec/AlgorithmParameterSpec;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.html#getCertificateNotAfter()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Date"/></returns>
        public Java.Util.Date GetCertificateNotAfter()
        {
            return IExecuteWithSignature<Java.Util.Date>("getCertificateNotAfter", "()Ljava/util/Date;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.html#getCertificateNotBefore()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Date"/></returns>
        public Java.Util.Date GetCertificateNotBefore()
        {
            return IExecuteWithSignature<Java.Util.Date>("getCertificateNotBefore", "()Ljava/util/Date;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.html#getKeyValidityForConsumptionEnd()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Date"/></returns>
        public Java.Util.Date GetKeyValidityForConsumptionEnd()
        {
            return IExecuteWithSignature<Java.Util.Date>("getKeyValidityForConsumptionEnd", "()Ljava/util/Date;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.html#getKeyValidityForOriginationEnd()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Date"/></returns>
        public Java.Util.Date GetKeyValidityForOriginationEnd()
        {
            return IExecuteWithSignature<Java.Util.Date>("getKeyValidityForOriginationEnd", "()Ljava/util/Date;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.html#getKeyValidityStart()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Date"/></returns>
        public Java.Util.Date GetKeyValidityStart()
        {
            return IExecuteWithSignature<Java.Util.Date>("getKeyValidityStart", "()Ljava/util/Date;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.html#getMgf1Digests()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> GetMgf1Digests()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getMgf1Digests", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.html#getCertificateSubject()"/>
        /// </summary>
        /// <returns><see cref="Javax.Security.Auth.X500.X500Principal"/></returns>
        public Javax.Security.Auth.X500.X500Principal GetCertificateSubject()
        {
            return IExecuteWithSignature<Javax.Security.Auth.X500.X500Principal>("getCertificateSubject", "()Ljavax/security/auth/x500/X500Principal;");
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.Builder.html#%3Cinit%3E(java.lang.String,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public Builder(Java.Lang.String arg0, int arg1)
                : base(arg0, arg1)
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
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Security.Keystore.KeyGenParameterSpec"/></returns>
            public Android.Security.Keystore.KeyGenParameterSpec Build()
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyGenParameterSpec>("build", "()Landroid/security/keystore/KeyGenParameterSpec;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.Builder.html#setAlgorithmParameterSpec(java.security.spec.AlgorithmParameterSpec)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Security.Spec.AlgorithmParameterSpec"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyGenParameterSpec.Builder"/></returns>
            public Android.Security.Keystore.KeyGenParameterSpec.Builder SetAlgorithmParameterSpec(Java.Security.Spec.AlgorithmParameterSpec arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyGenParameterSpec.Builder>("setAlgorithmParameterSpec", "(Ljava/security/spec/AlgorithmParameterSpec;)Landroid/security/keystore/KeyGenParameterSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.Builder.html#setAttestationChallenge(byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyGenParameterSpec.Builder"/></returns>
            public Android.Security.Keystore.KeyGenParameterSpec.Builder SetAttestationChallenge(byte[] arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyGenParameterSpec.Builder>("setAttestationChallenge", "([B)Landroid/security/keystore/KeyGenParameterSpec$Builder;", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.Builder.html#setAttestKeyAlias(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyGenParameterSpec.Builder"/></returns>
            public Android.Security.Keystore.KeyGenParameterSpec.Builder SetAttestKeyAlias(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyGenParameterSpec.Builder>("setAttestKeyAlias", "(Ljava/lang/String;)Landroid/security/keystore/KeyGenParameterSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.Builder.html#setBlockModes(java.lang.String[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyGenParameterSpec.Builder"/></returns>
            public Android.Security.Keystore.KeyGenParameterSpec.Builder SetBlockModes(params Java.Lang.String[] arg0)
            {
                if (arg0.Length == 0) return IExecuteWithSignature<Android.Security.Keystore.KeyGenParameterSpec.Builder>("setBlockModes", "([Ljava/lang/String;)Landroid/security/keystore/KeyGenParameterSpec$Builder;"); else return IExecuteWithSignature<Android.Security.Keystore.KeyGenParameterSpec.Builder>("setBlockModes", "([Ljava/lang/String;)Landroid/security/keystore/KeyGenParameterSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.Builder.html#setCertificateNotAfter(java.util.Date)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Date"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyGenParameterSpec.Builder"/></returns>
            public Android.Security.Keystore.KeyGenParameterSpec.Builder SetCertificateNotAfter(Java.Util.Date arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyGenParameterSpec.Builder>("setCertificateNotAfter", "(Ljava/util/Date;)Landroid/security/keystore/KeyGenParameterSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.Builder.html#setCertificateNotBefore(java.util.Date)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Date"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyGenParameterSpec.Builder"/></returns>
            public Android.Security.Keystore.KeyGenParameterSpec.Builder SetCertificateNotBefore(Java.Util.Date arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyGenParameterSpec.Builder>("setCertificateNotBefore", "(Ljava/util/Date;)Landroid/security/keystore/KeyGenParameterSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.Builder.html#setCertificateSerialNumber(java.math.BigInteger)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyGenParameterSpec.Builder"/></returns>
            public Android.Security.Keystore.KeyGenParameterSpec.Builder SetCertificateSerialNumber(Java.Math.BigInteger arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyGenParameterSpec.Builder>("setCertificateSerialNumber", "(Ljava/math/BigInteger;)Landroid/security/keystore/KeyGenParameterSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.Builder.html#setCertificateSubject(javax.security.auth.x500.X500Principal)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Security.Auth.X500.X500Principal"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyGenParameterSpec.Builder"/></returns>
            public Android.Security.Keystore.KeyGenParameterSpec.Builder SetCertificateSubject(Javax.Security.Auth.X500.X500Principal arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyGenParameterSpec.Builder>("setCertificateSubject", "(Ljavax/security/auth/x500/X500Principal;)Landroid/security/keystore/KeyGenParameterSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.Builder.html#setDevicePropertiesAttestationIncluded(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyGenParameterSpec.Builder"/></returns>
            public Android.Security.Keystore.KeyGenParameterSpec.Builder SetDevicePropertiesAttestationIncluded(bool arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyGenParameterSpec.Builder>("setDevicePropertiesAttestationIncluded", "(Z)Landroid/security/keystore/KeyGenParameterSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.Builder.html#setDigests(java.lang.String[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyGenParameterSpec.Builder"/></returns>
            public Android.Security.Keystore.KeyGenParameterSpec.Builder SetDigests(params Java.Lang.String[] arg0)
            {
                if (arg0.Length == 0) return IExecuteWithSignature<Android.Security.Keystore.KeyGenParameterSpec.Builder>("setDigests", "([Ljava/lang/String;)Landroid/security/keystore/KeyGenParameterSpec$Builder;"); else return IExecuteWithSignature<Android.Security.Keystore.KeyGenParameterSpec.Builder>("setDigests", "([Ljava/lang/String;)Landroid/security/keystore/KeyGenParameterSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.Builder.html#setEncryptionPaddings(java.lang.String[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyGenParameterSpec.Builder"/></returns>
            public Android.Security.Keystore.KeyGenParameterSpec.Builder SetEncryptionPaddings(params Java.Lang.String[] arg0)
            {
                if (arg0.Length == 0) return IExecuteWithSignature<Android.Security.Keystore.KeyGenParameterSpec.Builder>("setEncryptionPaddings", "([Ljava/lang/String;)Landroid/security/keystore/KeyGenParameterSpec$Builder;"); else return IExecuteWithSignature<Android.Security.Keystore.KeyGenParameterSpec.Builder>("setEncryptionPaddings", "([Ljava/lang/String;)Landroid/security/keystore/KeyGenParameterSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.Builder.html#setInvalidatedByBiometricEnrollment(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyGenParameterSpec.Builder"/></returns>
            public Android.Security.Keystore.KeyGenParameterSpec.Builder SetInvalidatedByBiometricEnrollment(bool arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyGenParameterSpec.Builder>("setInvalidatedByBiometricEnrollment", "(Z)Landroid/security/keystore/KeyGenParameterSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.Builder.html#setIsStrongBoxBacked(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyGenParameterSpec.Builder"/></returns>
            public Android.Security.Keystore.KeyGenParameterSpec.Builder SetIsStrongBoxBacked(bool arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyGenParameterSpec.Builder>("setIsStrongBoxBacked", "(Z)Landroid/security/keystore/KeyGenParameterSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.Builder.html#setKeySize(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyGenParameterSpec.Builder"/></returns>
            public Android.Security.Keystore.KeyGenParameterSpec.Builder SetKeySize(int arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyGenParameterSpec.Builder>("setKeySize", "(I)Landroid/security/keystore/KeyGenParameterSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.Builder.html#setKeyValidityEnd(java.util.Date)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Date"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyGenParameterSpec.Builder"/></returns>
            public Android.Security.Keystore.KeyGenParameterSpec.Builder SetKeyValidityEnd(Java.Util.Date arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyGenParameterSpec.Builder>("setKeyValidityEnd", "(Ljava/util/Date;)Landroid/security/keystore/KeyGenParameterSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.Builder.html#setKeyValidityForConsumptionEnd(java.util.Date)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Date"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyGenParameterSpec.Builder"/></returns>
            public Android.Security.Keystore.KeyGenParameterSpec.Builder SetKeyValidityForConsumptionEnd(Java.Util.Date arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyGenParameterSpec.Builder>("setKeyValidityForConsumptionEnd", "(Ljava/util/Date;)Landroid/security/keystore/KeyGenParameterSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.Builder.html#setKeyValidityForOriginationEnd(java.util.Date)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Date"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyGenParameterSpec.Builder"/></returns>
            public Android.Security.Keystore.KeyGenParameterSpec.Builder SetKeyValidityForOriginationEnd(Java.Util.Date arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyGenParameterSpec.Builder>("setKeyValidityForOriginationEnd", "(Ljava/util/Date;)Landroid/security/keystore/KeyGenParameterSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.Builder.html#setKeyValidityStart(java.util.Date)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Date"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyGenParameterSpec.Builder"/></returns>
            public Android.Security.Keystore.KeyGenParameterSpec.Builder SetKeyValidityStart(Java.Util.Date arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyGenParameterSpec.Builder>("setKeyValidityStart", "(Ljava/util/Date;)Landroid/security/keystore/KeyGenParameterSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.Builder.html#setMaxUsageCount(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyGenParameterSpec.Builder"/></returns>
            public Android.Security.Keystore.KeyGenParameterSpec.Builder SetMaxUsageCount(int arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyGenParameterSpec.Builder>("setMaxUsageCount", "(I)Landroid/security/keystore/KeyGenParameterSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.Builder.html#setMgf1Digests(java.lang.String[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyGenParameterSpec.Builder"/></returns>
            public Android.Security.Keystore.KeyGenParameterSpec.Builder SetMgf1Digests(params Java.Lang.String[] arg0)
            {
                if (arg0.Length == 0) return IExecuteWithSignature<Android.Security.Keystore.KeyGenParameterSpec.Builder>("setMgf1Digests", "([Ljava/lang/String;)Landroid/security/keystore/KeyGenParameterSpec$Builder;"); else return IExecuteWithSignature<Android.Security.Keystore.KeyGenParameterSpec.Builder>("setMgf1Digests", "([Ljava/lang/String;)Landroid/security/keystore/KeyGenParameterSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.Builder.html#setRandomizedEncryptionRequired(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyGenParameterSpec.Builder"/></returns>
            public Android.Security.Keystore.KeyGenParameterSpec.Builder SetRandomizedEncryptionRequired(bool arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyGenParameterSpec.Builder>("setRandomizedEncryptionRequired", "(Z)Landroid/security/keystore/KeyGenParameterSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.Builder.html#setSignaturePaddings(java.lang.String[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyGenParameterSpec.Builder"/></returns>
            public Android.Security.Keystore.KeyGenParameterSpec.Builder SetSignaturePaddings(params Java.Lang.String[] arg0)
            {
                if (arg0.Length == 0) return IExecuteWithSignature<Android.Security.Keystore.KeyGenParameterSpec.Builder>("setSignaturePaddings", "([Ljava/lang/String;)Landroid/security/keystore/KeyGenParameterSpec$Builder;"); else return IExecuteWithSignature<Android.Security.Keystore.KeyGenParameterSpec.Builder>("setSignaturePaddings", "([Ljava/lang/String;)Landroid/security/keystore/KeyGenParameterSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.Builder.html#setUnlockedDeviceRequired(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyGenParameterSpec.Builder"/></returns>
            public Android.Security.Keystore.KeyGenParameterSpec.Builder SetUnlockedDeviceRequired(bool arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyGenParameterSpec.Builder>("setUnlockedDeviceRequired", "(Z)Landroid/security/keystore/KeyGenParameterSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.Builder.html#setUserAuthenticationParameters(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyGenParameterSpec.Builder"/></returns>
            public Android.Security.Keystore.KeyGenParameterSpec.Builder SetUserAuthenticationParameters(int arg0, int arg1)
            {
                return IExecute<Android.Security.Keystore.KeyGenParameterSpec.Builder>("setUserAuthenticationParameters", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.Builder.html#setUserAuthenticationRequired(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyGenParameterSpec.Builder"/></returns>
            public Android.Security.Keystore.KeyGenParameterSpec.Builder SetUserAuthenticationRequired(bool arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyGenParameterSpec.Builder>("setUserAuthenticationRequired", "(Z)Landroid/security/keystore/KeyGenParameterSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.Builder.html#setUserAuthenticationValidityDurationSeconds(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyGenParameterSpec.Builder"/></returns>
            [global::System.Obsolete()]
            public Android.Security.Keystore.KeyGenParameterSpec.Builder SetUserAuthenticationValidityDurationSeconds(int arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyGenParameterSpec.Builder>("setUserAuthenticationValidityDurationSeconds", "(I)Landroid/security/keystore/KeyGenParameterSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.Builder.html#setUserAuthenticationValidWhileOnBody(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyGenParameterSpec.Builder"/></returns>
            public Android.Security.Keystore.KeyGenParameterSpec.Builder SetUserAuthenticationValidWhileOnBody(bool arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyGenParameterSpec.Builder>("setUserAuthenticationValidWhileOnBody", "(Z)Landroid/security/keystore/KeyGenParameterSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.Builder.html#setUserConfirmationRequired(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyGenParameterSpec.Builder"/></returns>
            public Android.Security.Keystore.KeyGenParameterSpec.Builder SetUserConfirmationRequired(bool arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyGenParameterSpec.Builder>("setUserConfirmationRequired", "(Z)Landroid/security/keystore/KeyGenParameterSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec.Builder.html#setUserPresenceRequired(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Security.Keystore.KeyGenParameterSpec.Builder"/></returns>
            public Android.Security.Keystore.KeyGenParameterSpec.Builder SetUserPresenceRequired(bool arg0)
            {
                return IExecuteWithSignature<Android.Security.Keystore.KeyGenParameterSpec.Builder>("setUserPresenceRequired", "(Z)Landroid/security/keystore/KeyGenParameterSpec$Builder;", arg0);
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