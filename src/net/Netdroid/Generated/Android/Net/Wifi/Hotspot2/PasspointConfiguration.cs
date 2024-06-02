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

namespace Android.Net.Wifi.Hotspot2
{
    #region PasspointConfiguration
    public partial class PasspointConfiguration
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/hotspot2/PasspointConfiguration.html#%3Cinit%3E(android.net.wifi.hotspot2.PasspointConfiguration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Wifi.Hotspot2.PasspointConfiguration"/></param>
        public PasspointConfiguration(Android.Net.Wifi.Hotspot2.PasspointConfiguration arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/hotspot2/PasspointConfiguration.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/hotspot2/PasspointConfiguration.html#getCredential()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Wifi.Hotspot2.Pps.Credential"/></returns>
        public Android.Net.Wifi.Hotspot2.Pps.Credential GetCredential()
        {
            return IExecuteWithSignature<Android.Net.Wifi.Hotspot2.Pps.Credential>("getCredential", "()Landroid/net/wifi/hotspot2/pps/Credential;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/hotspot2/PasspointConfiguration.html#getHomeSp()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Wifi.Hotspot2.Pps.HomeSp"/></returns>
        public Android.Net.Wifi.Hotspot2.Pps.HomeSp GetHomeSp()
        {
            return IExecuteWithSignature<Android.Net.Wifi.Hotspot2.Pps.HomeSp>("getHomeSp", "()Landroid/net/wifi/hotspot2/pps/HomeSp;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/hotspot2/PasspointConfiguration.html#isOsuProvisioned()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOsuProvisioned()
        {
            return IExecuteWithSignature<bool>("isOsuProvisioned", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/hotspot2/PasspointConfiguration.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/hotspot2/PasspointConfiguration.html#getDecoratedIdentityPrefix()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDecoratedIdentityPrefix()
        {
            return IExecuteWithSignature<Java.Lang.String>("getDecoratedIdentityPrefix", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/hotspot2/PasspointConfiguration.html#getUniqueId()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetUniqueId()
        {
            return IExecuteWithSignature<Java.Lang.String>("getUniqueId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/hotspot2/PasspointConfiguration.html#getSubscriptionExpirationTimeMillis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetSubscriptionExpirationTimeMillis()
        {
            return IExecuteWithSignature<long>("getSubscriptionExpirationTimeMillis", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/hotspot2/PasspointConfiguration.html#setCredential(android.net.wifi.hotspot2.pps.Credential)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Wifi.Hotspot2.Pps.Credential"/></param>
        public void SetCredential(Android.Net.Wifi.Hotspot2.Pps.Credential arg0)
        {
            IExecuteWithSignature("setCredential", "(Landroid/net/wifi/hotspot2/pps/Credential;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/hotspot2/PasspointConfiguration.html#setDecoratedIdentityPrefix(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetDecoratedIdentityPrefix(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setDecoratedIdentityPrefix", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/hotspot2/PasspointConfiguration.html#setHomeSp(android.net.wifi.hotspot2.pps.HomeSp)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Wifi.Hotspot2.Pps.HomeSp"/></param>
        public void SetHomeSp(Android.Net.Wifi.Hotspot2.Pps.HomeSp arg0)
        {
            IExecuteWithSignature("setHomeSp", "(Landroid/net/wifi/hotspot2/pps/HomeSp;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/hotspot2/PasspointConfiguration.html#setSubscriptionExpirationTimeInMillis(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetSubscriptionExpirationTimeInMillis(long arg0)
        {
            IExecuteWithSignature("setSubscriptionExpirationTimeInMillis", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/hotspot2/PasspointConfiguration.html#writeToParcel(android.os.Parcel,int)"/>
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