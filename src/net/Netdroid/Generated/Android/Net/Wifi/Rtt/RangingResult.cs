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
    #region RangingResult
    public partial class RangingResult
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingResult.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingResult.html#STATUS_FAIL"/>
        /// </summary>
        public static int STATUS_FAIL { get { if (!_STATUS_FAILReady) { _STATUS_FAILContent = SGetField<int>(LocalBridgeClazz, "STATUS_FAIL"); _STATUS_FAILReady = true; } return _STATUS_FAILContent; } }
        private static int _STATUS_FAILContent = default;
        private static bool _STATUS_FAILReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingResult.html#STATUS_RESPONDER_DOES_NOT_SUPPORT_IEEE80211MC"/>
        /// </summary>
        public static int STATUS_RESPONDER_DOES_NOT_SUPPORT_IEEE80211MC { get { if (!_STATUS_RESPONDER_DOES_NOT_SUPPORT_IEEE80211MCReady) { _STATUS_RESPONDER_DOES_NOT_SUPPORT_IEEE80211MCContent = SGetField<int>(LocalBridgeClazz, "STATUS_RESPONDER_DOES_NOT_SUPPORT_IEEE80211MC"); _STATUS_RESPONDER_DOES_NOT_SUPPORT_IEEE80211MCReady = true; } return _STATUS_RESPONDER_DOES_NOT_SUPPORT_IEEE80211MCContent; } }
        private static int _STATUS_RESPONDER_DOES_NOT_SUPPORT_IEEE80211MCContent = default;
        private static bool _STATUS_RESPONDER_DOES_NOT_SUPPORT_IEEE80211MCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingResult.html#STATUS_SUCCESS"/>
        /// </summary>
        public static int STATUS_SUCCESS { get { if (!_STATUS_SUCCESSReady) { _STATUS_SUCCESSContent = SGetField<int>(LocalBridgeClazz, "STATUS_SUCCESS"); _STATUS_SUCCESSReady = true; } return _STATUS_SUCCESSContent; } }
        private static int _STATUS_SUCCESSContent = default;
        private static bool _STATUS_SUCCESSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingResult.html#UNSPECIFIED"/>
        /// </summary>
        public static int UNSPECIFIED { get { if (!_UNSPECIFIEDReady) { _UNSPECIFIEDContent = SGetField<int>(LocalBridgeClazz, "UNSPECIFIED"); _UNSPECIFIEDReady = true; } return _UNSPECIFIEDContent; } }
        private static int _UNSPECIFIEDContent = default;
        private static bool _UNSPECIFIEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingResult.html#getDistanceMm()"/> 
        /// </summary>
        public int DistanceMm
        {
            get { return IExecuteWithSignature<int>("getDistanceMm", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingResult.html#getDistanceStdDevMm()"/> 
        /// </summary>
        public int DistanceStdDevMm
        {
            get { return IExecuteWithSignature<int>("getDistanceStdDevMm", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingResult.html#getMacAddress()"/> 
        /// </summary>
        public Android.Net.MacAddress MacAddress
        {
            get { return IExecuteWithSignature<Android.Net.MacAddress>("getMacAddress", "()Landroid/net/MacAddress;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingResult.html#getMeasurementBandwidth()"/> 
        /// </summary>
        public int MeasurementBandwidth
        {
            get { return IExecuteWithSignature<int>("getMeasurementBandwidth", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingResult.html#getMeasurementChannelFrequencyMHz()"/> 
        /// </summary>
        public int MeasurementChannelFrequencyMHz
        {
            get { return IExecuteWithSignature<int>("getMeasurementChannelFrequencyMHz", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingResult.html#getNumAttemptedMeasurements()"/> 
        /// </summary>
        public int NumAttemptedMeasurements
        {
            get { return IExecuteWithSignature<int>("getNumAttemptedMeasurements", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingResult.html#getNumSuccessfulMeasurements()"/> 
        /// </summary>
        public int NumSuccessfulMeasurements
        {
            get { return IExecuteWithSignature<int>("getNumSuccessfulMeasurements", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingResult.html#getPeerHandle()"/> 
        /// </summary>
        public Android.Net.Wifi.Aware.PeerHandle PeerHandle
        {
            get { return IExecuteWithSignature<Android.Net.Wifi.Aware.PeerHandle>("getPeerHandle", "()Landroid/net/wifi/aware/PeerHandle;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingResult.html#getRangingTimestampMillis()"/> 
        /// </summary>
        public long RangingTimestampMillis
        {
            get { return IExecuteWithSignature<long>("getRangingTimestampMillis", "()J"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingResult.html#getRssi()"/> 
        /// </summary>
        public int Rssi
        {
            get { return IExecuteWithSignature<int>("getRssi", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingResult.html#getStatus()"/> 
        /// </summary>
        public int Status
        {
            get { return IExecuteWithSignature<int>("getStatus", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingResult.html#getUnverifiedResponderLocation()"/> 
        /// </summary>
        public Android.Net.Wifi.Rtt.ResponderLocation UnverifiedResponderLocation
        {
            get { return IExecuteWithSignature<Android.Net.Wifi.Rtt.ResponderLocation>("getUnverifiedResponderLocation", "()Landroid/net/wifi/rtt/ResponderLocation;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingResult.html#is80211mcMeasurement()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Is80211mcMeasurement()
        {
            return IExecuteWithSignature<bool>("is80211mcMeasurement", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingResult.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/RangingResult.html#writeToParcel(android.os.Parcel,int)"/>
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