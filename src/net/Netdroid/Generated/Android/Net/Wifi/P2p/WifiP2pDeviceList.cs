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

namespace Android.Net.Wifi.P2p
{
    #region WifiP2pDeviceList
    public partial class WifiP2pDeviceList
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pDeviceList.html#%3Cinit%3E(android.net.wifi.p2p.WifiP2pDeviceList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Wifi.P2p.WifiP2pDeviceList"/></param>
        public WifiP2pDeviceList(Android.Net.Wifi.P2p.WifiP2pDeviceList arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pDeviceList.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pDeviceList.html#get(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Net.Wifi.P2p.WifiP2pDevice"/></returns>
        public Android.Net.Wifi.P2p.WifiP2pDevice Get(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Net.Wifi.P2p.WifiP2pDevice>("get", "(Ljava/lang/String;)Landroid/net/wifi/p2p/WifiP2pDevice;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pDeviceList.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pDeviceList.html#getDeviceList()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection<Android.Net.Wifi.P2p.WifiP2pDevice> GetDeviceList()
        {
            return IExecuteWithSignature<Java.Util.Collection<Android.Net.Wifi.P2p.WifiP2pDevice>>("getDeviceList", "()Ljava/util/Collection;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pDeviceList.html#writeToParcel(android.os.Parcel,int)"/>
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