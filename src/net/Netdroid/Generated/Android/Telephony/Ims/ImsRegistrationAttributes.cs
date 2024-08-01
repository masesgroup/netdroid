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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Telephony.Ims
{
    #region ImsRegistrationAttributes
    public partial class ImsRegistrationAttributes
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/ImsRegistrationAttributes.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/ImsRegistrationAttributes.html#ATTR_EPDG_OVER_CELL_INTERNET"/>
        /// </summary>
        public static int ATTR_EPDG_OVER_CELL_INTERNET { get { if (!_ATTR_EPDG_OVER_CELL_INTERNETReady) { _ATTR_EPDG_OVER_CELL_INTERNETContent = SGetField<int>(LocalBridgeClazz, "ATTR_EPDG_OVER_CELL_INTERNET"); _ATTR_EPDG_OVER_CELL_INTERNETReady = true; } return _ATTR_EPDG_OVER_CELL_INTERNETContent; } }
        private static int _ATTR_EPDG_OVER_CELL_INTERNETContent = default;
        private static bool _ATTR_EPDG_OVER_CELL_INTERNETReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/ImsRegistrationAttributes.html#getSipDetails()"/>
        /// </summary>
        /// <returns><see cref="Android.Telephony.Ims.SipDetails"/></returns>
        public Android.Telephony.Ims.SipDetails GetSipDetails()
        {
            return IExecuteWithSignature<Android.Telephony.Ims.SipDetails>("getSipDetails", "()Landroid/telephony/ims/SipDetails;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/ImsRegistrationAttributes.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/ImsRegistrationAttributes.html#getAttributeFlags()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetAttributeFlags()
        {
            return IExecuteWithSignature<int>("getAttributeFlags", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/ImsRegistrationAttributes.html#getTransportType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTransportType()
        {
            return IExecuteWithSignature<int>("getTransportType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/ImsRegistrationAttributes.html#getFeatureTags()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> GetFeatureTags()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getFeatureTags", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/ImsRegistrationAttributes.html#writeToParcel(android.os.Parcel,int)"/>
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