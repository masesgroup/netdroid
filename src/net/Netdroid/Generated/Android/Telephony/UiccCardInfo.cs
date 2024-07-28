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
    #region UiccCardInfo
    public partial class UiccCardInfo
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/UiccCardInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/UiccCardInfo.html#isEuicc()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEuicc()
        {
            return IExecuteWithSignature<bool>("isEuicc", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/UiccCardInfo.html#isMultipleEnabledProfilesSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsMultipleEnabledProfilesSupported()
        {
            return IExecuteWithSignature<bool>("isMultipleEnabledProfilesSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/UiccCardInfo.html#isRemovable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRemovable()
        {
            return IExecuteWithSignature<bool>("isRemovable", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/UiccCardInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/UiccCardInfo.html#getCardId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCardId()
        {
            return IExecuteWithSignature<int>("getCardId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/UiccCardInfo.html#getPhysicalSlotIndex()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPhysicalSlotIndex()
        {
            return IExecuteWithSignature<int>("getPhysicalSlotIndex", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/UiccCardInfo.html#getSlotIndex()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetSlotIndex()
        {
            return IExecuteWithSignature<int>("getSlotIndex", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/UiccCardInfo.html#getEid()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetEid()
        {
            return IExecuteWithSignature<Java.Lang.String>("getEid", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/UiccCardInfo.html#getIccId()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetIccId()
        {
            return IExecuteWithSignature<Java.Lang.String>("getIccId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/UiccCardInfo.html#getPorts()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection<Android.Telephony.UiccPortInfo> GetPorts()
        {
            return IExecuteWithSignature<Java.Util.Collection<Android.Telephony.UiccPortInfo>>("getPorts", "()Ljava/util/Collection;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/UiccCardInfo.html#writeToParcel(android.os.Parcel,int)"/>
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