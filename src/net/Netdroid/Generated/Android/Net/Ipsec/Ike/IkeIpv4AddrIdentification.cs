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

namespace Android.Net.Ipsec.Ike
{
    #region IkeIpv4AddrIdentification
    public partial class IkeIpv4AddrIdentification
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeIpv4AddrIdentification.html#%3Cinit%3E(java.net.Inet4Address)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.Inet4Address"/></param>
        public IkeIpv4AddrIdentification(Java.Net.Inet4Address arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeIpv4AddrIdentification.html#ipv4Address"/>
        /// </summary>
        public Java.Net.Inet4Address ipv4Address { get { if (!_ipv4AddressReady) { _ipv4AddressContent = IGetField<Java.Net.Inet4Address>("ipv4Address"); _ipv4AddressReady = true; } return _ipv4AddressContent; } }
        private Java.Net.Inet4Address _ipv4AddressContent = default;
        private bool _ipv4AddressReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}