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

namespace Javax.Crypto.Interfaces
{
    #region IDHPrivateKey
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDHPrivateKey
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DHPrivateKey
    public partial class DHPrivateKey : Javax.Crypto.Interfaces.IDHPrivateKey, Javax.Crypto.Interfaces.IDHKey, Java.Security.IPrivateKey
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Crypto.Interfaces.DHPrivateKey"/> to <see cref="Javax.Crypto.Interfaces.DHKey"/>
        /// </summary>
        public static implicit operator Javax.Crypto.Interfaces.DHKey(Javax.Crypto.Interfaces.DHPrivateKey t) => t.Cast<Javax.Crypto.Interfaces.DHKey>();
        /// <summary>
        /// Converter from <see cref="Javax.Crypto.Interfaces.DHPrivateKey"/> to <see cref="Java.Security.PrivateKey"/>
        /// </summary>
        public static implicit operator Java.Security.PrivateKey(Javax.Crypto.Interfaces.DHPrivateKey t) => t.Cast<Java.Security.PrivateKey>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/crypto/interfaces/DHPrivateKey.html#serialVersionUID"/>
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
        /// <see href="https://developer.android.com/reference/javax/crypto/interfaces/DHPrivateKey.html#getX()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger GetX()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("getX", "()Ljava/math/BigInteger;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}