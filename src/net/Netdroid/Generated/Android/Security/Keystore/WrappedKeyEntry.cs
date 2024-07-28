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

namespace Android.Security.Keystore
{
    #region WrappedKeyEntry
    public partial class WrappedKeyEntry
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/WrappedKeyEntry.html#%3Cinit%3E(byte[],java.lang.String,java.lang.String,java.security.spec.AlgorithmParameterSpec)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Security.Spec.AlgorithmParameterSpec"/></param>
        public WrappedKeyEntry(byte[] arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Security.Spec.AlgorithmParameterSpec arg3)
            : base(arg0, arg1, arg2, arg3)
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
        /// <see href="https://developer.android.com/reference/android/security/keystore/WrappedKeyEntry.html#getWrappedKeyBytes()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetWrappedKeyBytes()
        {
            return IExecuteWithSignatureArray<byte>("getWrappedKeyBytes", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/WrappedKeyEntry.html#getTransformation()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetTransformation()
        {
            return IExecuteWithSignature<Java.Lang.String>("getTransformation", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/WrappedKeyEntry.html#getWrappingKeyAlias()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetWrappingKeyAlias()
        {
            return IExecuteWithSignature<Java.Lang.String>("getWrappingKeyAlias", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/WrappedKeyEntry.html#getAlgorithmParameterSpec()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Spec.AlgorithmParameterSpec"/></returns>
        public Java.Security.Spec.AlgorithmParameterSpec GetAlgorithmParameterSpec()
        {
            return IExecuteWithSignature<Java.Security.Spec.AlgorithmParameterSpec>("getAlgorithmParameterSpec", "()Ljava/security/spec/AlgorithmParameterSpec;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}