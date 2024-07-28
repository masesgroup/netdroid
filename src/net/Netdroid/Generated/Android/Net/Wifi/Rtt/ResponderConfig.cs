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

namespace Android.Net.Wifi.Rtt
{
    #region ResponderConfig
    public partial class ResponderConfig
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderConfig.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderConfig.html#RESPONDER_AP"/>
        /// </summary>
        public static int RESPONDER_AP { get { if (!_RESPONDER_APReady) { _RESPONDER_APContent = SGetField<int>(LocalBridgeClazz, "RESPONDER_AP"); _RESPONDER_APReady = true; } return _RESPONDER_APContent; } }
        private static int _RESPONDER_APContent = default;
        private static bool _RESPONDER_APReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderConfig.html#RESPONDER_STA"/>
        /// </summary>
        public static int RESPONDER_STA { get { if (!_RESPONDER_STAReady) { _RESPONDER_STAContent = SGetField<int>(LocalBridgeClazz, "RESPONDER_STA"); _RESPONDER_STAReady = true; } return _RESPONDER_STAContent; } }
        private static int _RESPONDER_STAContent = default;
        private static bool _RESPONDER_STAReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderConfig.html#fromScanResult(android.net.wifi.ScanResult)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Wifi.ScanResult"/></param>
        /// <returns><see cref="Android.Net.Wifi.Rtt.ResponderConfig"/></returns>
        public static Android.Net.Wifi.Rtt.ResponderConfig FromScanResult(Android.Net.Wifi.ScanResult arg0)
        {
            return SExecuteWithSignature<Android.Net.Wifi.Rtt.ResponderConfig>(LocalBridgeClazz, "fromScanResult", "(Landroid/net/wifi/ScanResult;)Landroid/net/wifi/rtt/ResponderConfig;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderConfig.html#getMacAddress()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.MacAddress"/></returns>
        public Android.Net.MacAddress GetMacAddress()
        {
            return IExecuteWithSignature<Android.Net.MacAddress>("getMacAddress", "()Landroid/net/MacAddress;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderConfig.html#is80211azNtbSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Is80211azNtbSupported()
        {
            return IExecuteWithSignature<bool>("is80211azNtbSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderConfig.html#is80211mcSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Is80211mcSupported()
        {
            return IExecuteWithSignature<bool>("is80211mcSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderConfig.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderConfig.html#getCenterFreq0Mhz()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCenterFreq0Mhz()
        {
            return IExecuteWithSignature<int>("getCenterFreq0Mhz", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderConfig.html#getCenterFreq1Mhz()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCenterFreq1Mhz()
        {
            return IExecuteWithSignature<int>("getCenterFreq1Mhz", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderConfig.html#getChannelWidth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetChannelWidth()
        {
            return IExecuteWithSignature<int>("getChannelWidth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderConfig.html#getFrequencyMhz()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetFrequencyMhz()
        {
            return IExecuteWithSignature<int>("getFrequencyMhz", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderConfig.html#getPreamble()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPreamble()
        {
            return IExecuteWithSignature<int>("getPreamble", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderConfig.html#getResponderType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetResponderType()
        {
            return IExecuteWithSignature<int>("getResponderType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderConfig.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderConfig.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Net.Wifi.Rtt.ResponderConfig"/></returns>
            public Android.Net.Wifi.Rtt.ResponderConfig Build()
            {
                return IExecuteWithSignature<Android.Net.Wifi.Rtt.ResponderConfig>("build", "()Landroid/net/wifi/rtt/ResponderConfig;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderConfig.Builder.html#set80211azNtbSupported(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Net.Wifi.Rtt.ResponderConfig.Builder"/></returns>
            public Android.Net.Wifi.Rtt.ResponderConfig.Builder Set80211azNtbSupported(bool arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.Rtt.ResponderConfig.Builder>("set80211azNtbSupported", "(Z)Landroid/net/wifi/rtt/ResponderConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderConfig.Builder.html#set80211mcSupported(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Net.Wifi.Rtt.ResponderConfig.Builder"/></returns>
            public Android.Net.Wifi.Rtt.ResponderConfig.Builder Set80211mcSupported(bool arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.Rtt.ResponderConfig.Builder>("set80211mcSupported", "(Z)Landroid/net/wifi/rtt/ResponderConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderConfig.Builder.html#setCenterFreq0Mhz(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Wifi.Rtt.ResponderConfig.Builder"/></returns>
            public Android.Net.Wifi.Rtt.ResponderConfig.Builder SetCenterFreq0Mhz(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.Rtt.ResponderConfig.Builder>("setCenterFreq0Mhz", "(I)Landroid/net/wifi/rtt/ResponderConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderConfig.Builder.html#setCenterFreq1Mhz(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Wifi.Rtt.ResponderConfig.Builder"/></returns>
            public Android.Net.Wifi.Rtt.ResponderConfig.Builder SetCenterFreq1Mhz(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.Rtt.ResponderConfig.Builder>("setCenterFreq1Mhz", "(I)Landroid/net/wifi/rtt/ResponderConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderConfig.Builder.html#setChannelWidth(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Wifi.Rtt.ResponderConfig.Builder"/></returns>
            public Android.Net.Wifi.Rtt.ResponderConfig.Builder SetChannelWidth(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.Rtt.ResponderConfig.Builder>("setChannelWidth", "(I)Landroid/net/wifi/rtt/ResponderConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderConfig.Builder.html#setFrequencyMhz(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Wifi.Rtt.ResponderConfig.Builder"/></returns>
            public Android.Net.Wifi.Rtt.ResponderConfig.Builder SetFrequencyMhz(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.Rtt.ResponderConfig.Builder>("setFrequencyMhz", "(I)Landroid/net/wifi/rtt/ResponderConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderConfig.Builder.html#setMacAddress(android.net.MacAddress)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.MacAddress"/></param>
            /// <returns><see cref="Android.Net.Wifi.Rtt.ResponderConfig.Builder"/></returns>
            public Android.Net.Wifi.Rtt.ResponderConfig.Builder SetMacAddress(Android.Net.MacAddress arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.Rtt.ResponderConfig.Builder>("setMacAddress", "(Landroid/net/MacAddress;)Landroid/net/wifi/rtt/ResponderConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderConfig.Builder.html#setPreamble(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Wifi.Rtt.ResponderConfig.Builder"/></returns>
            public Android.Net.Wifi.Rtt.ResponderConfig.Builder SetPreamble(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.Rtt.ResponderConfig.Builder>("setPreamble", "(I)Landroid/net/wifi/rtt/ResponderConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/ResponderConfig.Builder.html#setResponderType(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Wifi.Rtt.ResponderConfig.Builder"/></returns>
            public Android.Net.Wifi.Rtt.ResponderConfig.Builder SetResponderType(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.Rtt.ResponderConfig.Builder>("setResponderType", "(I)Landroid/net/wifi/rtt/ResponderConfig$Builder;", arg0);
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