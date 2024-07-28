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

namespace Java.Security
{
    #region AlgorithmParameters
    public partial class AlgorithmParameters
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/AlgorithmParameters.html#getInstance(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Security.AlgorithmParameters"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.NoSuchProviderException"/>
        public static Java.Security.AlgorithmParameters GetInstance(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecute<Java.Security.AlgorithmParameters>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/AlgorithmParameters.html#getInstance(java.lang.String,java.security.Provider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.Provider"/></param>
        /// <returns><see cref="Java.Security.AlgorithmParameters"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Java.Security.AlgorithmParameters GetInstance(Java.Lang.String arg0, Java.Security.Provider arg1)
        {
            return SExecute<Java.Security.AlgorithmParameters>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/AlgorithmParameters.html#getInstance(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Security.AlgorithmParameters"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Java.Security.AlgorithmParameters GetInstance(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Security.AlgorithmParameters>(LocalBridgeClazz, "getInstance", "(Ljava/lang/String;)Ljava/security/AlgorithmParameters;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/AlgorithmParameters.html#getParameterSpec(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"><see cref="Java.Security.Spec.IAlgorithmParameterSpec"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Java.Security.Spec.InvalidParameterSpecException"/>
        public T GetParameterSpec<T>(Java.Lang.Class arg0) where T : Java.Security.Spec.IAlgorithmParameterSpec, new()
        {
            return IExecuteWithSignature<T>("getParameterSpec", "(Ljava/lang/Class;)Ljava/security/spec/AlgorithmParameterSpec;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/AlgorithmParameters.html#getEncoded()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public byte[] GetEncoded()
        {
            return IExecuteWithSignatureArray<byte>("getEncoded", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/AlgorithmParameters.html#getEncoded(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public byte[] GetEncoded(Java.Lang.String arg0)
        {
            return IExecuteWithSignatureArray<byte>("getEncoded", "(Ljava/lang/String;)[B", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/AlgorithmParameters.html#getAlgorithm()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAlgorithm()
        {
            return IExecuteWithSignature<Java.Lang.String>("getAlgorithm", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/AlgorithmParameters.html#getProvider()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Provider"/></returns>
        public Java.Security.Provider GetProvider()
        {
            return IExecuteWithSignature<Java.Security.Provider>("getProvider", "()Ljava/security/Provider;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/AlgorithmParameters.html#init(byte[],java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Init(byte[] arg0, Java.Lang.String arg1)
        {
            IExecute("init", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/AlgorithmParameters.html#init(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Init(byte[] arg0)
        {
            IExecuteWithSignature("init", "([B)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/AlgorithmParameters.html#init(java.security.spec.AlgorithmParameterSpec)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Spec.AlgorithmParameterSpec"/></param>
        /// <exception cref="Java.Security.Spec.InvalidParameterSpecException"/>
        public void Init(Java.Security.Spec.AlgorithmParameterSpec arg0)
        {
            IExecuteWithSignature("init", "(Ljava/security/spec/AlgorithmParameterSpec;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}