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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.App.Admin
{
    #region WifiSsidPolicy
    public partial class WifiSsidPolicy
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/WifiSsidPolicy.html#%3Cinit%3E(int,java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        public WifiSsidPolicy(int arg0, Java.Util.Set<Android.Net.Wifi.WifiSsid> arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/WifiSsidPolicy.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/WifiSsidPolicy.html#WIFI_SSID_POLICY_TYPE_ALLOWLIST"/>
        /// </summary>
        public static int WIFI_SSID_POLICY_TYPE_ALLOWLIST { get { if (!_WIFI_SSID_POLICY_TYPE_ALLOWLISTReady) { _WIFI_SSID_POLICY_TYPE_ALLOWLISTContent = SGetField<int>(LocalBridgeClazz, "WIFI_SSID_POLICY_TYPE_ALLOWLIST"); _WIFI_SSID_POLICY_TYPE_ALLOWLISTReady = true; } return _WIFI_SSID_POLICY_TYPE_ALLOWLISTContent; } }
        private static int _WIFI_SSID_POLICY_TYPE_ALLOWLISTContent = default;
        private static bool _WIFI_SSID_POLICY_TYPE_ALLOWLISTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/WifiSsidPolicy.html#WIFI_SSID_POLICY_TYPE_DENYLIST"/>
        /// </summary>
        public static int WIFI_SSID_POLICY_TYPE_DENYLIST { get { if (!_WIFI_SSID_POLICY_TYPE_DENYLISTReady) { _WIFI_SSID_POLICY_TYPE_DENYLISTContent = SGetField<int>(LocalBridgeClazz, "WIFI_SSID_POLICY_TYPE_DENYLIST"); _WIFI_SSID_POLICY_TYPE_DENYLISTReady = true; } return _WIFI_SSID_POLICY_TYPE_DENYLISTContent; } }
        private static int _WIFI_SSID_POLICY_TYPE_DENYLISTContent = default;
        private static bool _WIFI_SSID_POLICY_TYPE_DENYLISTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/WifiSsidPolicy.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/WifiSsidPolicy.html#getPolicyType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPolicyType()
        {
            return IExecuteWithSignature<int>("getPolicyType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/WifiSsidPolicy.html#getSsids()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Android.Net.Wifi.WifiSsid> GetSsids()
        {
            return IExecuteWithSignature<Java.Util.Set<Android.Net.Wifi.WifiSsid>>("getSsids", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/WifiSsidPolicy.html#writeToParcel(android.os.Parcel,int)"/>
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