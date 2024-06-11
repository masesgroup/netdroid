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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Security
{
    #region SignedObject
    public partial class SignedObject
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/SignedObject.html#%3Cinit%3E(java.io.Serializable,java.security.PrivateKey,java.security.Signature)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Serializable"/></param>
        /// <param name="arg1"><see cref="Java.Security.PrivateKey"/></param>
        /// <param name="arg2"><see cref="Java.Security.Signature"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        /// <exception cref="Java.Security.SignatureException"/>
        public SignedObject(Java.Io.Serializable arg0, Java.Security.PrivateKey arg1, Java.Security.Signature arg2)
            : base(arg0, arg1, arg2)
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
        /// <see href="https://developer.android.com/reference/java/security/SignedObject.html#verify(java.security.PublicKey,java.security.Signature)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PublicKey"/></param>
        /// <param name="arg1"><see cref="Java.Security.Signature"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        /// <exception cref="Java.Security.SignatureException"/>
        public bool Verify(Java.Security.PublicKey arg0, Java.Security.Signature arg1)
        {
            return IExecute<bool>("verify", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/SignedObject.html#getSignature()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetSignature()
        {
            return IExecuteWithSignatureArray<byte>("getSignature", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/SignedObject.html#getObject()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        public object GetObject()
        {
            return IExecuteWithSignature("getObject", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/SignedObject.html#getAlgorithm()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAlgorithm()
        {
            return IExecuteWithSignature<Java.Lang.String>("getAlgorithm", "()Ljava/lang/String;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}