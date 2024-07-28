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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Crypto
{
    #region SecretKeyFactory
    public partial class SecretKeyFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/crypto/SecretKeyFactory.html#getInstance(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Crypto.SecretKeyFactory"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.NoSuchProviderException"/>
        public static Javax.Crypto.SecretKeyFactory GetInstance(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecute<Javax.Crypto.SecretKeyFactory>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/crypto/SecretKeyFactory.html#getInstance(java.lang.String,java.security.Provider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.Provider"/></param>
        /// <returns><see cref="Javax.Crypto.SecretKeyFactory"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Javax.Crypto.SecretKeyFactory GetInstance(Java.Lang.String arg0, Java.Security.Provider arg1)
        {
            return SExecute<Javax.Crypto.SecretKeyFactory>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/crypto/SecretKeyFactory.html#getInstance(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Crypto.SecretKeyFactory"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Javax.Crypto.SecretKeyFactory GetInstance(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Javax.Crypto.SecretKeyFactory>(LocalBridgeClazz, "getInstance", "(Ljava/lang/String;)Ljavax/crypto/SecretKeyFactory;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/crypto/SecretKeyFactory.html#getAlgorithm()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAlgorithm()
        {
            return IExecuteWithSignature<Java.Lang.String>("getAlgorithm", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/crypto/SecretKeyFactory.html#getProvider()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Provider"/></returns>
        public Java.Security.Provider GetProvider()
        {
            return IExecuteWithSignature<Java.Security.Provider>("getProvider", "()Ljava/security/Provider;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/crypto/SecretKeyFactory.html#getKeySpec(javax.crypto.SecretKey,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Crypto.SecretKey"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Security.Spec.KeySpec"/></returns>
        /// <exception cref="Java.Security.Spec.InvalidKeySpecException"/>
        public Java.Security.Spec.KeySpec GetKeySpec(Javax.Crypto.SecretKey arg0, Java.Lang.Class arg1)
        {
            return IExecute<Java.Security.Spec.KeySpec>("getKeySpec", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/crypto/SecretKeyFactory.html#generateSecret(java.security.spec.KeySpec)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Spec.KeySpec"/></param>
        /// <returns><see cref="Javax.Crypto.SecretKey"/></returns>
        /// <exception cref="Java.Security.Spec.InvalidKeySpecException"/>
        public Javax.Crypto.SecretKey GenerateSecret(Java.Security.Spec.KeySpec arg0)
        {
            return IExecuteWithSignature<Javax.Crypto.SecretKey>("generateSecret", "(Ljava/security/spec/KeySpec;)Ljavax/crypto/SecretKey;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/crypto/SecretKeyFactory.html#translateKey(javax.crypto.SecretKey)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Crypto.SecretKey"/></param>
        /// <returns><see cref="Javax.Crypto.SecretKey"/></returns>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        public Javax.Crypto.SecretKey TranslateKey(Javax.Crypto.SecretKey arg0)
        {
            return IExecuteWithSignature<Javax.Crypto.SecretKey>("translateKey", "(Ljavax/crypto/SecretKey;)Ljavax/crypto/SecretKey;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}