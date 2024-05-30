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

namespace Android.Telephony
{
    #region PhysicalChannelConfig
    public partial class PhysicalChannelConfig
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhysicalChannelConfig.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhysicalChannelConfig.html#BAND_UNKNOWN"/>
        /// </summary>
        public static int BAND_UNKNOWN { get { if (!_BAND_UNKNOWNReady) { _BAND_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "BAND_UNKNOWN"); _BAND_UNKNOWNReady = true; } return _BAND_UNKNOWNContent; } }
        private static int _BAND_UNKNOWNContent = default;
        private static bool _BAND_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhysicalChannelConfig.html#CELL_BANDWIDTH_UNKNOWN"/>
        /// </summary>
        public static int CELL_BANDWIDTH_UNKNOWN { get { if (!_CELL_BANDWIDTH_UNKNOWNReady) { _CELL_BANDWIDTH_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "CELL_BANDWIDTH_UNKNOWN"); _CELL_BANDWIDTH_UNKNOWNReady = true; } return _CELL_BANDWIDTH_UNKNOWNContent; } }
        private static int _CELL_BANDWIDTH_UNKNOWNContent = default;
        private static bool _CELL_BANDWIDTH_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhysicalChannelConfig.html#CHANNEL_NUMBER_UNKNOWN"/>
        /// </summary>
        public static int CHANNEL_NUMBER_UNKNOWN { get { if (!_CHANNEL_NUMBER_UNKNOWNReady) { _CHANNEL_NUMBER_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "CHANNEL_NUMBER_UNKNOWN"); _CHANNEL_NUMBER_UNKNOWNReady = true; } return _CHANNEL_NUMBER_UNKNOWNContent; } }
        private static int _CHANNEL_NUMBER_UNKNOWNContent = default;
        private static bool _CHANNEL_NUMBER_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhysicalChannelConfig.html#FREQUENCY_UNKNOWN"/>
        /// </summary>
        public static int FREQUENCY_UNKNOWN { get { if (!_FREQUENCY_UNKNOWNReady) { _FREQUENCY_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "FREQUENCY_UNKNOWN"); _FREQUENCY_UNKNOWNReady = true; } return _FREQUENCY_UNKNOWNContent; } }
        private static int _FREQUENCY_UNKNOWNContent = default;
        private static bool _FREQUENCY_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhysicalChannelConfig.html#PHYSICAL_CELL_ID_MAXIMUM_VALUE"/>
        /// </summary>
        public static int PHYSICAL_CELL_ID_MAXIMUM_VALUE { get { if (!_PHYSICAL_CELL_ID_MAXIMUM_VALUEReady) { _PHYSICAL_CELL_ID_MAXIMUM_VALUEContent = SGetField<int>(LocalBridgeClazz, "PHYSICAL_CELL_ID_MAXIMUM_VALUE"); _PHYSICAL_CELL_ID_MAXIMUM_VALUEReady = true; } return _PHYSICAL_CELL_ID_MAXIMUM_VALUEContent; } }
        private static int _PHYSICAL_CELL_ID_MAXIMUM_VALUEContent = default;
        private static bool _PHYSICAL_CELL_ID_MAXIMUM_VALUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhysicalChannelConfig.html#PHYSICAL_CELL_ID_UNKNOWN"/>
        /// </summary>
        public static int PHYSICAL_CELL_ID_UNKNOWN { get { if (!_PHYSICAL_CELL_ID_UNKNOWNReady) { _PHYSICAL_CELL_ID_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "PHYSICAL_CELL_ID_UNKNOWN"); _PHYSICAL_CELL_ID_UNKNOWNReady = true; } return _PHYSICAL_CELL_ID_UNKNOWNContent; } }
        private static int _PHYSICAL_CELL_ID_UNKNOWNContent = default;
        private static bool _PHYSICAL_CELL_ID_UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhysicalChannelConfig.html#getBand()"/> 
        /// </summary>
        public int Band
        {
            get { return IExecuteWithSignature<int>("getBand", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhysicalChannelConfig.html#getCellBandwidthDownlinkKhz()"/> 
        /// </summary>
        public int CellBandwidthDownlinkKhz
        {
            get { return IExecuteWithSignature<int>("getCellBandwidthDownlinkKhz", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhysicalChannelConfig.html#getCellBandwidthUplinkKhz()"/> 
        /// </summary>
        public int CellBandwidthUplinkKhz
        {
            get { return IExecuteWithSignature<int>("getCellBandwidthUplinkKhz", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhysicalChannelConfig.html#getConnectionStatus()"/> 
        /// </summary>
        public int ConnectionStatus
        {
            get { return IExecuteWithSignature<int>("getConnectionStatus", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhysicalChannelConfig.html#getDownlinkChannelNumber()"/> 
        /// </summary>
        public int DownlinkChannelNumber
        {
            get { return IExecuteWithSignature<int>("getDownlinkChannelNumber", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhysicalChannelConfig.html#getDownlinkFrequencyKhz()"/> 
        /// </summary>
        public int DownlinkFrequencyKhz
        {
            get { return IExecuteWithSignature<int>("getDownlinkFrequencyKhz", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhysicalChannelConfig.html#getNetworkType()"/> 
        /// </summary>
        public int NetworkType
        {
            get { return IExecuteWithSignature<int>("getNetworkType", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhysicalChannelConfig.html#getPhysicalCellId()"/> 
        /// </summary>
        public int PhysicalCellId
        {
            get { return IExecuteWithSignature<int>("getPhysicalCellId", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhysicalChannelConfig.html#getUplinkChannelNumber()"/> 
        /// </summary>
        public int UplinkChannelNumber
        {
            get { return IExecuteWithSignature<int>("getUplinkChannelNumber", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhysicalChannelConfig.html#getUplinkFrequencyKhz()"/> 
        /// </summary>
        public int UplinkFrequencyKhz
        {
            get { return IExecuteWithSignature<int>("getUplinkFrequencyKhz", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhysicalChannelConfig.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhysicalChannelConfig.html#writeToParcel(android.os.Parcel,int)"/>
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