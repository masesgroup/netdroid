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

namespace Android.Telephony
{
    #region CellIdentityLte
    public partial class CellIdentityLte
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityLte.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityLte.html#getClosedSubscriberGroupInfo()"/>
        /// </summary>
        /// <returns><see cref="Android.Telephony.ClosedSubscriberGroupInfo"/></returns>
        public Android.Telephony.ClosedSubscriberGroupInfo GetClosedSubscriberGroupInfo()
        {
            return IExecuteWithSignature<Android.Telephony.ClosedSubscriberGroupInfo>("getClosedSubscriberGroupInfo", "()Landroid/telephony/ClosedSubscriberGroupInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityLte.html#getBandwidth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetBandwidth()
        {
            return IExecuteWithSignature<int>("getBandwidth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityLte.html#getCi()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCi()
        {
            return IExecuteWithSignature<int>("getCi", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityLte.html#getEarfcn()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetEarfcn()
        {
            return IExecuteWithSignature<int>("getEarfcn", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityLte.html#getMcc()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetMcc()
        {
            return IExecuteWithSignature<int>("getMcc", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityLte.html#getMnc()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetMnc()
        {
            return IExecuteWithSignature<int>("getMnc", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityLte.html#getPci()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPci()
        {
            return IExecuteWithSignature<int>("getPci", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityLte.html#getTac()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTac()
        {
            return IExecuteWithSignature<int>("getTac", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityLte.html#getBands()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int[] GetBands()
        {
            return IExecuteWithSignatureArray<int>("getBands", "()[I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityLte.html#getMccString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetMccString()
        {
            return IExecuteWithSignature<Java.Lang.String>("getMccString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityLte.html#getMncString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetMncString()
        {
            return IExecuteWithSignature<Java.Lang.String>("getMncString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityLte.html#getMobileNetworkOperator()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetMobileNetworkOperator()
        {
            return IExecuteWithSignature<Java.Lang.String>("getMobileNetworkOperator", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityLte.html#getAdditionalPlmns()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> GetAdditionalPlmns()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getAdditionalPlmns", "()Ljava/util/Set;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}