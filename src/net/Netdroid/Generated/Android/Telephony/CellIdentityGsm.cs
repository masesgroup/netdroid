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
    #region CellIdentityGsm
    public partial class CellIdentityGsm
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityGsm.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityGsm.html#getArfcn()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetArfcn()
        {
            return IExecuteWithSignature<int>("getArfcn", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityGsm.html#getBsic()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetBsic()
        {
            return IExecuteWithSignature<int>("getBsic", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityGsm.html#getCid()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCid()
        {
            return IExecuteWithSignature<int>("getCid", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityGsm.html#getLac()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetLac()
        {
            return IExecuteWithSignature<int>("getLac", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityGsm.html#getMcc()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetMcc()
        {
            return IExecuteWithSignature<int>("getMcc", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityGsm.html#getMnc()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetMnc()
        {
            return IExecuteWithSignature<int>("getMnc", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityGsm.html#getPsc()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetPsc()
        {
            return IExecuteWithSignature<int>("getPsc", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityGsm.html#getMccString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetMccString()
        {
            return IExecuteWithSignature<Java.Lang.String>("getMccString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityGsm.html#getMncString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetMncString()
        {
            return IExecuteWithSignature<Java.Lang.String>("getMncString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityGsm.html#getMobileNetworkOperator()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetMobileNetworkOperator()
        {
            return IExecuteWithSignature<Java.Lang.String>("getMobileNetworkOperator", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityGsm.html#getAdditionalPlmns()"/>
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