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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Net.Ipsec.Ike
{
    #region IkeIpv4AddrIdentification declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeIpv4AddrIdentification.html"/>
    /// </summary>
    public partial class IkeIpv4AddrIdentification : Android.Net.Ipsec.Ike.IkeIdentification
    {
        const string _bridgeClassName = "android.net.ipsec.ike.IkeIpv4AddrIdentification";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public IkeIpv4AddrIdentification() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public IkeIpv4AddrIdentification(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
    
    }
    #endregion

    #region IkeIpv4AddrIdentification implementation
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