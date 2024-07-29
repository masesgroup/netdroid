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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Security.Spec
{
    #region ECPrivateKeySpec
    public partial class ECPrivateKeySpec
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/spec/ECPrivateKeySpec.html#%3Cinit%3E(java.math.BigInteger,java.security.spec.ECParameterSpec)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg1"><see cref="Java.Security.Spec.ECParameterSpec"/></param>
        public ECPrivateKeySpec(Java.Math.BigInteger arg0, Java.Security.Spec.ECParameterSpec arg1)
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
        /// <see href="https://developer.android.com/reference/java/security/spec/ECPrivateKeySpec.html#getS()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger GetS()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("getS", "()Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/spec/ECPrivateKeySpec.html#getParams()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Spec.ECParameterSpec"/></returns>
        public Java.Security.Spec.ECParameterSpec GetParams()
        {
            return IExecuteWithSignature<Java.Security.Spec.ECParameterSpec>("getParams", "()Ljava/security/spec/ECParameterSpec;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}