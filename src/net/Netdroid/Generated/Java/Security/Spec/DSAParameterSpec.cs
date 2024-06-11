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
    #region DSAParameterSpec
    public partial class DSAParameterSpec : Java.Security.Spec.IAlgorithmParameterSpec, Java.Security.Interfaces.IDSAParams
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/spec/DSAParameterSpec.html#%3Cinit%3E(java.math.BigInteger,java.math.BigInteger,java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg1"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg2"><see cref="Java.Math.BigInteger"/></param>
        public DSAParameterSpec(Java.Math.BigInteger arg0, Java.Math.BigInteger arg1, Java.Math.BigInteger arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Security.Spec.DSAParameterSpec"/> to <see cref="Java.Security.Spec.AlgorithmParameterSpec"/>
        /// </summary>
        public static implicit operator Java.Security.Spec.AlgorithmParameterSpec(Java.Security.Spec.DSAParameterSpec t) => t.Cast<Java.Security.Spec.AlgorithmParameterSpec>();
        /// <summary>
        /// Converter from <see cref="Java.Security.Spec.DSAParameterSpec"/> to <see cref="Java.Security.Interfaces.DSAParams"/>
        /// </summary>
        public static implicit operator Java.Security.Interfaces.DSAParams(Java.Security.Spec.DSAParameterSpec t) => t.Cast<Java.Security.Interfaces.DSAParams>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/spec/DSAParameterSpec.html#getG()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger GetG()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("getG", "()Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/spec/DSAParameterSpec.html#getP()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger GetP()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("getP", "()Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/spec/DSAParameterSpec.html#getQ()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger GetQ()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("getQ", "()Ljava/math/BigInteger;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}