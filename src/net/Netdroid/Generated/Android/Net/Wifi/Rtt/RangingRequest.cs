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

namespace Android.Net.Wifi.Rtt
{
    #region RangingRequest
    public partial class RangingRequest
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingRequest.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingRequest.html#getDefaultRttBurstSize()"/> 
        /// </summary>
        public static int DefaultRttBurstSize
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getDefaultRttBurstSize", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingRequest.html#getMaxPeers()"/> 
        /// </summary>
        public static int MaxPeers
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getMaxPeers", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingRequest.html#getMaxRttBurstSize()"/> 
        /// </summary>
        public static int MaxRttBurstSize
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getMaxRttBurstSize", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingRequest.html#getMinRttBurstSize()"/> 
        /// </summary>
        public static int MinRttBurstSize
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getMinRttBurstSize", "()I"); }
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingRequest.html#getRttBurstSize()"/> 
        /// </summary>
        public int RttBurstSize
        {
            get { return IExecuteWithSignature<int>("getRttBurstSize", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingRequest.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingRequest.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingRequest.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Net.Wifi.Rtt.RangingRequest"/></returns>
            public Android.Net.Wifi.Rtt.RangingRequest Build()
            {
                return IExecuteWithSignature<Android.Net.Wifi.Rtt.RangingRequest>("build", "()Landroid/net/wifi/rtt/RangingRequest;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingRequest.Builder.html#addAccessPoint(android.net.wifi.ScanResult)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Wifi.ScanResult"/></param>
            /// <returns><see cref="Android.Net.Wifi.Rtt.RangingRequest.Builder"/></returns>
            public Android.Net.Wifi.Rtt.RangingRequest.Builder AddAccessPoint(Android.Net.Wifi.ScanResult arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.Rtt.RangingRequest.Builder>("addAccessPoint", "(Landroid/net/wifi/ScanResult;)Landroid/net/wifi/rtt/RangingRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingRequest.Builder.html#addAccessPoints(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.Net.Wifi.Rtt.RangingRequest.Builder"/></returns>
            public Android.Net.Wifi.Rtt.RangingRequest.Builder AddAccessPoints(Java.Util.List<Android.Net.Wifi.ScanResult> arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.Rtt.RangingRequest.Builder>("addAccessPoints", "(Ljava/util/List;)Landroid/net/wifi/rtt/RangingRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingRequest.Builder.html#addNon80211mcCapableAccessPoint(android.net.wifi.ScanResult)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Wifi.ScanResult"/></param>
            /// <returns><see cref="Android.Net.Wifi.Rtt.RangingRequest.Builder"/></returns>
            public Android.Net.Wifi.Rtt.RangingRequest.Builder AddNon80211mcCapableAccessPoint(Android.Net.Wifi.ScanResult arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.Rtt.RangingRequest.Builder>("addNon80211mcCapableAccessPoint", "(Landroid/net/wifi/ScanResult;)Landroid/net/wifi/rtt/RangingRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingRequest.Builder.html#addNon80211mcCapableAccessPoints(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.Net.Wifi.Rtt.RangingRequest.Builder"/></returns>
            public Android.Net.Wifi.Rtt.RangingRequest.Builder AddNon80211mcCapableAccessPoints(Java.Util.List<Android.Net.Wifi.ScanResult> arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.Rtt.RangingRequest.Builder>("addNon80211mcCapableAccessPoints", "(Ljava/util/List;)Landroid/net/wifi/rtt/RangingRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingRequest.Builder.html#addResponder(android.net.wifi.rtt.ResponderConfig)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Wifi.Rtt.ResponderConfig"/></param>
            /// <returns><see cref="Android.Net.Wifi.Rtt.RangingRequest.Builder"/></returns>
            public Android.Net.Wifi.Rtt.RangingRequest.Builder AddResponder(Android.Net.Wifi.Rtt.ResponderConfig arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.Rtt.RangingRequest.Builder>("addResponder", "(Landroid/net/wifi/rtt/ResponderConfig;)Landroid/net/wifi/rtt/RangingRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingRequest.Builder.html#addResponders(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.Net.Wifi.Rtt.RangingRequest.Builder"/></returns>
            public Android.Net.Wifi.Rtt.RangingRequest.Builder AddResponders(Java.Util.List<Android.Net.Wifi.Rtt.ResponderConfig> arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.Rtt.RangingRequest.Builder>("addResponders", "(Ljava/util/List;)Landroid/net/wifi/rtt/RangingRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingRequest.Builder.html#addWifiAwarePeer(android.net.MacAddress)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.MacAddress"/></param>
            /// <returns><see cref="Android.Net.Wifi.Rtt.RangingRequest.Builder"/></returns>
            public Android.Net.Wifi.Rtt.RangingRequest.Builder AddWifiAwarePeer(Android.Net.MacAddress arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.Rtt.RangingRequest.Builder>("addWifiAwarePeer", "(Landroid/net/MacAddress;)Landroid/net/wifi/rtt/RangingRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingRequest.Builder.html#addWifiAwarePeer(android.net.wifi.aware.PeerHandle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Wifi.Aware.PeerHandle"/></param>
            /// <returns><see cref="Android.Net.Wifi.Rtt.RangingRequest.Builder"/></returns>
            public Android.Net.Wifi.Rtt.RangingRequest.Builder AddWifiAwarePeer(Android.Net.Wifi.Aware.PeerHandle arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.Rtt.RangingRequest.Builder>("addWifiAwarePeer", "(Landroid/net/wifi/aware/PeerHandle;)Landroid/net/wifi/rtt/RangingRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingRequest.Builder.html#setRttBurstSize(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Wifi.Rtt.RangingRequest.Builder"/></returns>
            public Android.Net.Wifi.Rtt.RangingRequest.Builder SetRttBurstSize(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.Rtt.RangingRequest.Builder>("setRttBurstSize", "(I)Landroid/net/wifi/rtt/RangingRequest$Builder;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}