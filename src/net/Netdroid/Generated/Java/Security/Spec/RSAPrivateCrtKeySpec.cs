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

namespace Java.Security.Spec
{
    #region RSAPrivateCrtKeySpec
    public partial class RSAPrivateCrtKeySpec
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/spec/RSAPrivateCrtKeySpec.html#%3Cinit%3E(java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.security.spec.AlgorithmParameterSpec)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg1"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg2"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg3"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg4"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg5"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg6"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg7"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg8"><see cref="Java.Security.Spec.AlgorithmParameterSpec"/></param>
        public RSAPrivateCrtKeySpec(Java.Math.BigInteger arg0, Java.Math.BigInteger arg1, Java.Math.BigInteger arg2, Java.Math.BigInteger arg3, Java.Math.BigInteger arg4, Java.Math.BigInteger arg5, Java.Math.BigInteger arg6, Java.Math.BigInteger arg7, Java.Security.Spec.AlgorithmParameterSpec arg8)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/spec/RSAPrivateCrtKeySpec.html#%3Cinit%3E(java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg1"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg2"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg3"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg4"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg5"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg6"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg7"><see cref="Java.Math.BigInteger"/></param>
        public RSAPrivateCrtKeySpec(Java.Math.BigInteger arg0, Java.Math.BigInteger arg1, Java.Math.BigInteger arg2, Java.Math.BigInteger arg3, Java.Math.BigInteger arg4, Java.Math.BigInteger arg5, Java.Math.BigInteger arg6, Java.Math.BigInteger arg7)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)
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
        /// <see href="https://developer.android.com/reference/java/security/spec/RSAPrivateCrtKeySpec.html#getCrtCoefficient()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger GetCrtCoefficient()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("getCrtCoefficient", "()Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/spec/RSAPrivateCrtKeySpec.html#getPrimeExponentP()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger GetPrimeExponentP()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("getPrimeExponentP", "()Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/spec/RSAPrivateCrtKeySpec.html#getPrimeExponentQ()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger GetPrimeExponentQ()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("getPrimeExponentQ", "()Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/spec/RSAPrivateCrtKeySpec.html#getPrimeP()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger GetPrimeP()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("getPrimeP", "()Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/spec/RSAPrivateCrtKeySpec.html#getPrimeQ()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger GetPrimeQ()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("getPrimeQ", "()Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/spec/RSAPrivateCrtKeySpec.html#getPublicExponent()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger GetPublicExponent()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("getPublicExponent", "()Ljava/math/BigInteger;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}