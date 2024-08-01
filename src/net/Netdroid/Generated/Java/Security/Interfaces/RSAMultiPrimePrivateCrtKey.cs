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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Security.Interfaces
{
    #region IRSAMultiPrimePrivateCrtKey
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IRSAMultiPrimePrivateCrtKey : Java.Security.Interfaces.IRSAPrivateKey
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RSAMultiPrimePrivateCrtKey
    public partial class RSAMultiPrimePrivateCrtKey : Java.Security.Interfaces.IRSAMultiPrimePrivateCrtKey
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#serialVersionUID"/>
        /// </summary>
        [global::System.Obsolete()]
        public static long serialVersionUID { get { if (!_serialVersionUIDReady) { _serialVersionUIDContent = SGetField<long>(LocalBridgeClazz, "serialVersionUID"); _serialVersionUIDReady = true; } return _serialVersionUIDContent; } }
        private static long _serialVersionUIDContent = default;
        private static bool _serialVersionUIDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getCrtCoefficient()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger GetCrtCoefficient()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("getCrtCoefficient", "()Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getPrimeExponentP()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger GetPrimeExponentP()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("getPrimeExponentP", "()Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getPrimeExponentQ()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger GetPrimeExponentQ()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("getPrimeExponentQ", "()Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getPrimeP()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger GetPrimeP()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("getPrimeP", "()Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getPrimeQ()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger GetPrimeQ()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("getPrimeQ", "()Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getPublicExponent()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger GetPublicExponent()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("getPublicExponent", "()Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getOtherPrimeInfo()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Spec.RSAOtherPrimeInfo"/></returns>
        public Java.Security.Spec.RSAOtherPrimeInfo[] GetOtherPrimeInfo()
        {
            return IExecuteWithSignatureArray<Java.Security.Spec.RSAOtherPrimeInfo>("getOtherPrimeInfo", "()[Ljava/security/spec/RSAOtherPrimeInfo;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}