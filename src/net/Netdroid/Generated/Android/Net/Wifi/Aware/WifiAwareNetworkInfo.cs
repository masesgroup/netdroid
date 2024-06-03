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

namespace Android.Net.Wifi.Aware
{
    #region WifiAwareNetworkInfo
    public partial class WifiAwareNetworkInfo : Android.Os.IParcelable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Net.Wifi.Aware.WifiAwareNetworkInfo"/> to <see cref="Android.Os.Parcelable"/>
        /// </summary>
        public static implicit operator Android.Os.Parcelable(Android.Net.Wifi.Aware.WifiAwareNetworkInfo t) => t.Cast<Android.Os.Parcelable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareNetworkInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareNetworkInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareNetworkInfo.html#getPort()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPort()
        {
            return IExecuteWithSignature<int>("getPort", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareNetworkInfo.html#getTransportProtocol()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTransportProtocol()
        {
            return IExecuteWithSignature<int>("getTransportProtocol", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareNetworkInfo.html#getPeerIpv6Addr()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.Inet6Address"/></returns>
        public Java.Net.Inet6Address GetPeerIpv6Addr()
        {
            return IExecuteWithSignature<Java.Net.Inet6Address>("getPeerIpv6Addr", "()Ljava/net/Inet6Address;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareNetworkInfo.html#getChannelInfoList()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Net.Wifi.Aware.WifiAwareChannelInfo> GetChannelInfoList()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Net.Wifi.Aware.WifiAwareChannelInfo>>("getChannelInfoList", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareNetworkInfo.html#writeToParcel(android.os.Parcel,int)"/>
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