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

namespace Java.Security.Spec
{
    #region XECPrivateKeySpec
    public partial class XECPrivateKeySpec
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/spec/XECPrivateKeySpec.html#%3Cinit%3E(java.security.spec.AlgorithmParameterSpec,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Spec.AlgorithmParameterSpec"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        public XECPrivateKeySpec(Java.Security.Spec.AlgorithmParameterSpec arg0, byte[] arg1)
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
        /// <see href="https://developer.android.com/reference/java/security/spec/XECPrivateKeySpec.html#getScalar()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetScalar()
        {
            return IExecuteWithSignatureArray<byte>("getScalar", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/spec/XECPrivateKeySpec.html#getParams()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Spec.AlgorithmParameterSpec"/></returns>
        public Java.Security.Spec.AlgorithmParameterSpec GetParams()
        {
            return IExecuteWithSignature<Java.Security.Spec.AlgorithmParameterSpec>("getParams", "()Ljava/security/spec/AlgorithmParameterSpec;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}