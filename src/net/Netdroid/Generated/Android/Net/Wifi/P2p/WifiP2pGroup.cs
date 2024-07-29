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

namespace Android.Net.Wifi.P2p
{
    #region WifiP2pGroup
    public partial class WifiP2pGroup
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pGroup.html#%3Cinit%3E(android.net.wifi.p2p.WifiP2pGroup)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Wifi.P2p.WifiP2pGroup"/></param>
        public WifiP2pGroup(Android.Net.Wifi.P2p.WifiP2pGroup arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pGroup.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pGroup.html#NETWORK_ID_PERSISTENT"/>
        /// </summary>
        public static int NETWORK_ID_PERSISTENT { get { if (!_NETWORK_ID_PERSISTENTReady) { _NETWORK_ID_PERSISTENTContent = SGetField<int>(LocalBridgeClazz, "NETWORK_ID_PERSISTENT"); _NETWORK_ID_PERSISTENTReady = true; } return _NETWORK_ID_PERSISTENTContent; } }
        private static int _NETWORK_ID_PERSISTENTContent = default;
        private static bool _NETWORK_ID_PERSISTENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pGroup.html#NETWORK_ID_TEMPORARY"/>
        /// </summary>
        public static int NETWORK_ID_TEMPORARY { get { if (!_NETWORK_ID_TEMPORARYReady) { _NETWORK_ID_TEMPORARYContent = SGetField<int>(LocalBridgeClazz, "NETWORK_ID_TEMPORARY"); _NETWORK_ID_TEMPORARYReady = true; } return _NETWORK_ID_TEMPORARYContent; } }
        private static int _NETWORK_ID_TEMPORARYContent = default;
        private static bool _NETWORK_ID_TEMPORARYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pGroup.html#getOwner()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Wifi.P2p.WifiP2pDevice"/></returns>
        public Android.Net.Wifi.P2p.WifiP2pDevice GetOwner()
        {
            return IExecuteWithSignature<Android.Net.Wifi.P2p.WifiP2pDevice>("getOwner", "()Landroid/net/wifi/p2p/WifiP2pDevice;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pGroup.html#isGroupOwner()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsGroupOwner()
        {
            return IExecuteWithSignature<bool>("isGroupOwner", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pGroup.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pGroup.html#getFrequency()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetFrequency()
        {
            return IExecuteWithSignature<int>("getFrequency", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pGroup.html#getNetworkId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetNetworkId()
        {
            return IExecuteWithSignature<int>("getNetworkId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pGroup.html#getInterface()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetInterface()
        {
            return IExecuteWithSignature<Java.Lang.String>("getInterface", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pGroup.html#getNetworkName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetNetworkName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getNetworkName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pGroup.html#getPassphrase()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPassphrase()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPassphrase", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pGroup.html#getClientList()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection<Android.Net.Wifi.P2p.WifiP2pDevice> GetClientList()
        {
            return IExecuteWithSignature<Java.Util.Collection<Android.Net.Wifi.P2p.WifiP2pDevice>>("getClientList", "()Ljava/util/Collection;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pGroup.html#writeToParcel(android.os.Parcel,int)"/>
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