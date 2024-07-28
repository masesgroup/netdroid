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

namespace Android.Net.Wifi.Hotspot2.Pps
{
    #region HomeSp
    public partial class HomeSp
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/hotspot2/pps/HomeSp.html#%3Cinit%3E(android.net.wifi.hotspot2.pps.HomeSp)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Wifi.Hotspot2.Pps.HomeSp"/></param>
        public HomeSp(Android.Net.Wifi.Hotspot2.Pps.HomeSp arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/hotspot2/pps/HomeSp.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/hotspot2/pps/HomeSp.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/hotspot2/pps/HomeSp.html#getFqdn()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetFqdn()
        {
            return IExecuteWithSignature<Java.Lang.String>("getFqdn", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/hotspot2/pps/HomeSp.html#getFriendlyName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetFriendlyName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getFriendlyName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/hotspot2/pps/HomeSp.html#getOtherHomePartnersList()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection<Java.Lang.String> GetOtherHomePartnersList()
        {
            return IExecuteWithSignature<Java.Util.Collection<Java.Lang.String>>("getOtherHomePartnersList", "()Ljava/util/Collection;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/hotspot2/pps/HomeSp.html#getMatchAllOis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long[] GetMatchAllOis()
        {
            return IExecuteWithSignatureArray<long>("getMatchAllOis", "()[J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/hotspot2/pps/HomeSp.html#getMatchAnyOis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long[] GetMatchAnyOis()
        {
            return IExecuteWithSignatureArray<long>("getMatchAnyOis", "()[J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/hotspot2/pps/HomeSp.html#getRoamingConsortiumOis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long[] GetRoamingConsortiumOis()
        {
            return IExecuteWithSignatureArray<long>("getRoamingConsortiumOis", "()[J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/hotspot2/pps/HomeSp.html#setFqdn(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetFqdn(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setFqdn", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/hotspot2/pps/HomeSp.html#setFriendlyName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetFriendlyName(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setFriendlyName", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/hotspot2/pps/HomeSp.html#setMatchAllOis(long[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetMatchAllOis(long[] arg0)
        {
            IExecuteWithSignature("setMatchAllOis", "([J)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/hotspot2/pps/HomeSp.html#setMatchAnyOis(long[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetMatchAnyOis(long[] arg0)
        {
            IExecuteWithSignature("setMatchAnyOis", "([J)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/hotspot2/pps/HomeSp.html#setOtherHomePartnersList(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public void SetOtherHomePartnersList(Java.Util.Collection<Java.Lang.String> arg0)
        {
            IExecuteWithSignature("setOtherHomePartnersList", "(Ljava/util/Collection;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/hotspot2/pps/HomeSp.html#setRoamingConsortiumOis(long[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetRoamingConsortiumOis(long[] arg0)
        {
            IExecuteWithSignature("setRoamingConsortiumOis", "([J)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/hotspot2/pps/HomeSp.html#writeToParcel(android.os.Parcel,int)"/>
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