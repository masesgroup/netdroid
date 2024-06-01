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

namespace Android.Security
{
    #region KeyPairGeneratorSpec
    public partial class KeyPairGeneratorSpec
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
        /// <see href="https://developer.android.com/reference/android/security/KeyPairGeneratorSpec.html#getAlgorithmParameterSpec()"/> 
        /// </summary>
        [System.Obsolete()]
        public Java.Security.Spec.AlgorithmParameterSpec AlgorithmParameterSpec
        {
            get { return IExecuteWithSignature<Java.Security.Spec.AlgorithmParameterSpec>("getAlgorithmParameterSpec", "()Ljava/security/spec/AlgorithmParameterSpec;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/KeyPairGeneratorSpec.html#getContext()"/> 
        /// </summary>
        [System.Obsolete()]
        public Android.Content.Context Context
        {
            get { return IExecuteWithSignature<Android.Content.Context>("getContext", "()Landroid/content/Context;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/KeyPairGeneratorSpec.html#getEndDate()"/> 
        /// </summary>
        [System.Obsolete()]
        public Java.Util.Date EndDate
        {
            get { return IExecuteWithSignature<Java.Util.Date>("getEndDate", "()Ljava/util/Date;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/KeyPairGeneratorSpec.html#getKeySize()"/> 
        /// </summary>
        [System.Obsolete()]
        public int KeySize
        {
            get { return IExecuteWithSignature<int>("getKeySize", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/KeyPairGeneratorSpec.html#getKeystoreAlias()"/> 
        /// </summary>
        [System.Obsolete()]
        public Java.Lang.String KeystoreAlias
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getKeystoreAlias", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/KeyPairGeneratorSpec.html#getKeyType()"/> 
        /// </summary>
        [System.Obsolete()]
        public Java.Lang.String KeyType
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getKeyType", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/KeyPairGeneratorSpec.html#getSerialNumber()"/> 
        /// </summary>
        [System.Obsolete()]
        public Java.Math.BigInteger SerialNumber
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getSerialNumber", "()Ljava/math/BigInteger;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/KeyPairGeneratorSpec.html#getStartDate()"/> 
        /// </summary>
        [System.Obsolete()]
        public Java.Util.Date StartDate
        {
            get { return IExecuteWithSignature<Java.Util.Date>("getStartDate", "()Ljava/util/Date;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/KeyPairGeneratorSpec.html#getSubjectDN()"/> 
        /// </summary>
        [System.Obsolete()]
        public Javax.Security.Auth.X500.X500Principal SubjectDN
        {
            get { return IExecuteWithSignature<Javax.Security.Auth.X500.X500Principal>("getSubjectDN", "()Ljavax/security/auth/x500/X500Principal;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/KeyPairGeneratorSpec.html#isEncryptionRequired()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [System.Obsolete()]
        public bool IsEncryptionRequired()
        {
            return IExecuteWithSignature<bool>("isEncryptionRequired", "()Z");
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/KeyPairGeneratorSpec.Builder.html#%3Cinit%3E(android.content.Context)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Context"/></param>
            [System.Obsolete()]
            public Builder(Android.Content.Context arg0)
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
            /// <see href="https://developer.android.com/reference/android/security/KeyPairGeneratorSpec.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Security.KeyPairGeneratorSpec"/></returns>
            [System.Obsolete()]
            public Android.Security.KeyPairGeneratorSpec Build()
            {
                return IExecuteWithSignature<Android.Security.KeyPairGeneratorSpec>("build", "()Landroid/security/KeyPairGeneratorSpec;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/KeyPairGeneratorSpec.Builder.html#setAlgorithmParameterSpec(java.security.spec.AlgorithmParameterSpec)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Security.Spec.AlgorithmParameterSpec"/></param>
            /// <returns><see cref="Android.Security.KeyPairGeneratorSpec.Builder"/></returns>
            [System.Obsolete()]
            public Android.Security.KeyPairGeneratorSpec.Builder SetAlgorithmParameterSpec(Java.Security.Spec.AlgorithmParameterSpec arg0)
            {
                return IExecuteWithSignature<Android.Security.KeyPairGeneratorSpec.Builder>("setAlgorithmParameterSpec", "(Ljava/security/spec/AlgorithmParameterSpec;)Landroid/security/KeyPairGeneratorSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/KeyPairGeneratorSpec.Builder.html#setAlias(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Security.KeyPairGeneratorSpec.Builder"/></returns>
            [System.Obsolete()]
            public Android.Security.KeyPairGeneratorSpec.Builder SetAlias(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Security.KeyPairGeneratorSpec.Builder>("setAlias", "(Ljava/lang/String;)Landroid/security/KeyPairGeneratorSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/KeyPairGeneratorSpec.Builder.html#setEncryptionRequired()"/>
            /// </summary>
            /// <returns><see cref="Android.Security.KeyPairGeneratorSpec.Builder"/></returns>
            [System.Obsolete()]
            public Android.Security.KeyPairGeneratorSpec.Builder SetEncryptionRequired()
            {
                return IExecuteWithSignature<Android.Security.KeyPairGeneratorSpec.Builder>("setEncryptionRequired", "()Landroid/security/KeyPairGeneratorSpec$Builder;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/KeyPairGeneratorSpec.Builder.html#setEndDate(java.util.Date)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Date"/></param>
            /// <returns><see cref="Android.Security.KeyPairGeneratorSpec.Builder"/></returns>
            [System.Obsolete()]
            public Android.Security.KeyPairGeneratorSpec.Builder SetEndDate(Java.Util.Date arg0)
            {
                return IExecuteWithSignature<Android.Security.KeyPairGeneratorSpec.Builder>("setEndDate", "(Ljava/util/Date;)Landroid/security/KeyPairGeneratorSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/KeyPairGeneratorSpec.Builder.html#setKeySize(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Security.KeyPairGeneratorSpec.Builder"/></returns>
            [System.Obsolete()]
            public Android.Security.KeyPairGeneratorSpec.Builder SetKeySize(int arg0)
            {
                return IExecuteWithSignature<Android.Security.KeyPairGeneratorSpec.Builder>("setKeySize", "(I)Landroid/security/KeyPairGeneratorSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/KeyPairGeneratorSpec.Builder.html#setKeyType(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Security.KeyPairGeneratorSpec.Builder"/></returns>
            /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
            [System.Obsolete()]
            public Android.Security.KeyPairGeneratorSpec.Builder SetKeyType(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Security.KeyPairGeneratorSpec.Builder>("setKeyType", "(Ljava/lang/String;)Landroid/security/KeyPairGeneratorSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/KeyPairGeneratorSpec.Builder.html#setSerialNumber(java.math.BigInteger)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
            /// <returns><see cref="Android.Security.KeyPairGeneratorSpec.Builder"/></returns>
            [System.Obsolete()]
            public Android.Security.KeyPairGeneratorSpec.Builder SetSerialNumber(Java.Math.BigInteger arg0)
            {
                return IExecuteWithSignature<Android.Security.KeyPairGeneratorSpec.Builder>("setSerialNumber", "(Ljava/math/BigInteger;)Landroid/security/KeyPairGeneratorSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/KeyPairGeneratorSpec.Builder.html#setStartDate(java.util.Date)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Date"/></param>
            /// <returns><see cref="Android.Security.KeyPairGeneratorSpec.Builder"/></returns>
            [System.Obsolete()]
            public Android.Security.KeyPairGeneratorSpec.Builder SetStartDate(Java.Util.Date arg0)
            {
                return IExecuteWithSignature<Android.Security.KeyPairGeneratorSpec.Builder>("setStartDate", "(Ljava/util/Date;)Landroid/security/KeyPairGeneratorSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/KeyPairGeneratorSpec.Builder.html#setSubject(javax.security.auth.x500.X500Principal)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Security.Auth.X500.X500Principal"/></param>
            /// <returns><see cref="Android.Security.KeyPairGeneratorSpec.Builder"/></returns>
            [System.Obsolete()]
            public Android.Security.KeyPairGeneratorSpec.Builder SetSubject(Javax.Security.Auth.X500.X500Principal arg0)
            {
                return IExecuteWithSignature<Android.Security.KeyPairGeneratorSpec.Builder>("setSubject", "(Ljavax/security/auth/x500/X500Principal;)Landroid/security/KeyPairGeneratorSpec$Builder;", arg0);
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