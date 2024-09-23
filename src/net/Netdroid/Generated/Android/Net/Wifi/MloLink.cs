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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Net.Wifi
{
    #region MloLink declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/net/wifi/MloLink.html"/>
    /// </summary>
    public partial class MloLink : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.net.wifi.MloLink";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MloLink() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public MloLink(params object[] args) : base(args) { }
    
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

    #region MloLink implementation
    public partial class MloLink
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/MloLink.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/MloLink.html#INVALID_MLO_LINK_ID"/>
        /// </summary>
        public static int INVALID_MLO_LINK_ID { get { if (!_INVALID_MLO_LINK_IDReady) { _INVALID_MLO_LINK_IDContent = SGetField<int>(LocalBridgeClazz, "INVALID_MLO_LINK_ID"); _INVALID_MLO_LINK_IDReady = true; } return _INVALID_MLO_LINK_IDContent; } }
        private static int _INVALID_MLO_LINK_IDContent = default;
        private static bool _INVALID_MLO_LINK_IDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/MloLink.html#MLO_LINK_STATE_ACTIVE"/>
        /// </summary>
        public static int MLO_LINK_STATE_ACTIVE { get { if (!_MLO_LINK_STATE_ACTIVEReady) { _MLO_LINK_STATE_ACTIVEContent = SGetField<int>(LocalBridgeClazz, "MLO_LINK_STATE_ACTIVE"); _MLO_LINK_STATE_ACTIVEReady = true; } return _MLO_LINK_STATE_ACTIVEContent; } }
        private static int _MLO_LINK_STATE_ACTIVEContent = default;
        private static bool _MLO_LINK_STATE_ACTIVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/MloLink.html#MLO_LINK_STATE_IDLE"/>
        /// </summary>
        public static int MLO_LINK_STATE_IDLE { get { if (!_MLO_LINK_STATE_IDLEReady) { _MLO_LINK_STATE_IDLEContent = SGetField<int>(LocalBridgeClazz, "MLO_LINK_STATE_IDLE"); _MLO_LINK_STATE_IDLEReady = true; } return _MLO_LINK_STATE_IDLEContent; } }
        private static int _MLO_LINK_STATE_IDLEContent = default;
        private static bool _MLO_LINK_STATE_IDLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/MloLink.html#MLO_LINK_STATE_INVALID"/>
        /// </summary>
        public static int MLO_LINK_STATE_INVALID { get { if (!_MLO_LINK_STATE_INVALIDReady) { _MLO_LINK_STATE_INVALIDContent = SGetField<int>(LocalBridgeClazz, "MLO_LINK_STATE_INVALID"); _MLO_LINK_STATE_INVALIDReady = true; } return _MLO_LINK_STATE_INVALIDContent; } }
        private static int _MLO_LINK_STATE_INVALIDContent = default;
        private static bool _MLO_LINK_STATE_INVALIDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/MloLink.html#MLO_LINK_STATE_UNASSOCIATED"/>
        /// </summary>
        public static int MLO_LINK_STATE_UNASSOCIATED { get { if (!_MLO_LINK_STATE_UNASSOCIATEDReady) { _MLO_LINK_STATE_UNASSOCIATEDContent = SGetField<int>(LocalBridgeClazz, "MLO_LINK_STATE_UNASSOCIATED"); _MLO_LINK_STATE_UNASSOCIATEDReady = true; } return _MLO_LINK_STATE_UNASSOCIATEDContent; } }
        private static int _MLO_LINK_STATE_UNASSOCIATEDContent = default;
        private static bool _MLO_LINK_STATE_UNASSOCIATEDReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/MloLink.html#getApMacAddress()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.MacAddress"/></returns>
        public Android.Net.MacAddress GetApMacAddress()
        {
            return IExecuteWithSignature<Android.Net.MacAddress>("getApMacAddress", "()Landroid/net/MacAddress;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/MloLink.html#getStaMacAddress()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.MacAddress"/></returns>
        public Android.Net.MacAddress GetStaMacAddress()
        {
            return IExecuteWithSignature<Android.Net.MacAddress>("getStaMacAddress", "()Landroid/net/MacAddress;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/MloLink.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/MloLink.html#getBand()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetBand()
        {
            return IExecuteWithSignature<int>("getBand", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/MloLink.html#getChannel()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetChannel()
        {
            return IExecuteWithSignature<int>("getChannel", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/MloLink.html#getLinkId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetLinkId()
        {
            return IExecuteWithSignature<int>("getLinkId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/MloLink.html#getRssi()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetRssi()
        {
            return IExecuteWithSignature<int>("getRssi", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/MloLink.html#getRxLinkSpeedMbps()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetRxLinkSpeedMbps()
        {
            return IExecuteWithSignature<int>("getRxLinkSpeedMbps", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/MloLink.html#getState()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetState()
        {
            return IExecuteWithSignature<int>("getState", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/MloLink.html#getTxLinkSpeedMbps()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTxLinkSpeedMbps()
        {
            return IExecuteWithSignature<int>("getTxLinkSpeedMbps", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/MloLink.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}