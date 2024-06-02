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

namespace Javax.Crypto.Spec
{
    #region SecretKeySpec
    public partial class SecretKeySpec : Java.Security.Spec.IKeySpec, Javax.Crypto.ISecretKey
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/crypto/spec/SecretKeySpec.html#%3Cinit%3E(byte[],int,int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        public SecretKeySpec(byte[] arg0, int arg1, int arg2, Java.Lang.String arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/crypto/spec/SecretKeySpec.html#%3Cinit%3E(byte[],java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public SecretKeySpec(byte[] arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Crypto.Spec.SecretKeySpec"/> to <see cref="Java.Security.Spec.KeySpec"/>
        /// </summary>
        public static implicit operator Java.Security.Spec.KeySpec(Javax.Crypto.Spec.SecretKeySpec t) => t.Cast<Java.Security.Spec.KeySpec>();
        /// <summary>
        /// Converter from <see cref="Javax.Crypto.Spec.SecretKeySpec"/> to <see cref="Javax.Crypto.SecretKey"/>
        /// </summary>
        public static implicit operator Javax.Crypto.SecretKey(Javax.Crypto.Spec.SecretKeySpec t) => t.Cast<Javax.Crypto.SecretKey>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/crypto/spec/SecretKeySpec.html#getEncoded()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetEncoded()
        {
            return IExecuteWithSignatureArray<byte>("getEncoded", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/crypto/spec/SecretKeySpec.html#getAlgorithm()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAlgorithm()
        {
            return IExecuteWithSignature<Java.Lang.String>("getAlgorithm", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/crypto/spec/SecretKeySpec.html#getFormat()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetFormat()
        {
            return IExecuteWithSignature<Java.Lang.String>("getFormat", "()Ljava/lang/String;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}