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

namespace Android.Net.Ipsec.Ike
{
    #region IkeTrafficSelector
    public partial class IkeTrafficSelector
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeTrafficSelector.html#%3Cinit%3E(int,int,java.net.InetAddress,java.net.InetAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Net.InetAddress"/></param>
        /// <param name="arg3"><see cref="Java.Net.InetAddress"/></param>
        public IkeTrafficSelector(int arg0, int arg1, Java.Net.InetAddress arg2, Java.Net.InetAddress arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeTrafficSelector.html#endPort"/>
        /// </summary>
        public int endPort { get { if (!_endPortReady) { _endPortContent = IGetField<int>("endPort"); _endPortReady = true; } return _endPortContent; } }
        private int _endPortContent = default;
        private bool _endPortReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeTrafficSelector.html#startPort"/>
        /// </summary>
        public int startPort { get { if (!_startPortReady) { _startPortContent = IGetField<int>("startPort"); _startPortReady = true; } return _startPortContent; } }
        private int _startPortContent = default;
        private bool _startPortReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeTrafficSelector.html#endingAddress"/>
        /// </summary>
        public Java.Net.InetAddress endingAddress { get { if (!_endingAddressReady) { _endingAddressContent = IGetField<Java.Net.InetAddress>("endingAddress"); _endingAddressReady = true; } return _endingAddressContent; } }
        private Java.Net.InetAddress _endingAddressContent = default;
        private bool _endingAddressReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeTrafficSelector.html#startingAddress"/>
        /// </summary>
        public Java.Net.InetAddress startingAddress { get { if (!_startingAddressReady) { _startingAddressContent = IGetField<Java.Net.InetAddress>("startingAddress"); _startingAddressReady = true; } return _startingAddressContent; } }
        private Java.Net.InetAddress _startingAddressContent = default;
        private bool _startingAddressReady = false; // this is used because in case of generics 

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