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
    #region IccOpenLogicalChannelResponse
    public partial class IccOpenLogicalChannelResponse
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/IccOpenLogicalChannelResponse.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/IccOpenLogicalChannelResponse.html#INVALID_CHANNEL"/>
        /// </summary>
        public static int INVALID_CHANNEL { get { if (!_INVALID_CHANNELReady) { _INVALID_CHANNELContent = SGetField<int>(LocalBridgeClazz, "INVALID_CHANNEL"); _INVALID_CHANNELReady = true; } return _INVALID_CHANNELContent; } }
        private static int _INVALID_CHANNELContent = default;
        private static bool _INVALID_CHANNELReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/IccOpenLogicalChannelResponse.html#STATUS_MISSING_RESOURCE"/>
        /// </summary>
        public static int STATUS_MISSING_RESOURCE { get { if (!_STATUS_MISSING_RESOURCEReady) { _STATUS_MISSING_RESOURCEContent = SGetField<int>(LocalBridgeClazz, "STATUS_MISSING_RESOURCE"); _STATUS_MISSING_RESOURCEReady = true; } return _STATUS_MISSING_RESOURCEContent; } }
        private static int _STATUS_MISSING_RESOURCEContent = default;
        private static bool _STATUS_MISSING_RESOURCEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/IccOpenLogicalChannelResponse.html#STATUS_NO_ERROR"/>
        /// </summary>
        public static int STATUS_NO_ERROR { get { if (!_STATUS_NO_ERRORReady) { _STATUS_NO_ERRORContent = SGetField<int>(LocalBridgeClazz, "STATUS_NO_ERROR"); _STATUS_NO_ERRORReady = true; } return _STATUS_NO_ERRORContent; } }
        private static int _STATUS_NO_ERRORContent = default;
        private static bool _STATUS_NO_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/IccOpenLogicalChannelResponse.html#STATUS_NO_SUCH_ELEMENT"/>
        /// </summary>
        public static int STATUS_NO_SUCH_ELEMENT { get { if (!_STATUS_NO_SUCH_ELEMENTReady) { _STATUS_NO_SUCH_ELEMENTContent = SGetField<int>(LocalBridgeClazz, "STATUS_NO_SUCH_ELEMENT"); _STATUS_NO_SUCH_ELEMENTReady = true; } return _STATUS_NO_SUCH_ELEMENTContent; } }
        private static int _STATUS_NO_SUCH_ELEMENTContent = default;
        private static bool _STATUS_NO_SUCH_ELEMENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/IccOpenLogicalChannelResponse.html#STATUS_UNKNOWN_ERROR"/>
        /// </summary>
        public static int STATUS_UNKNOWN_ERROR { get { if (!_STATUS_UNKNOWN_ERRORReady) { _STATUS_UNKNOWN_ERRORContent = SGetField<int>(LocalBridgeClazz, "STATUS_UNKNOWN_ERROR"); _STATUS_UNKNOWN_ERRORReady = true; } return _STATUS_UNKNOWN_ERRORContent; } }
        private static int _STATUS_UNKNOWN_ERRORContent = default;
        private static bool _STATUS_UNKNOWN_ERRORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/IccOpenLogicalChannelResponse.html#getChannel()"/> 
        /// </summary>
        public int Channel
        {
            get { return IExecuteWithSignature<int>("getChannel", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/IccOpenLogicalChannelResponse.html#getSelectResponse()"/> 
        /// </summary>
        public byte[] SelectResponse
        {
            get { return IExecuteWithSignatureArray<byte>("getSelectResponse", "()[B"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/IccOpenLogicalChannelResponse.html#getStatus()"/> 
        /// </summary>
        public int Status
        {
            get { return IExecuteWithSignature<int>("getStatus", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/IccOpenLogicalChannelResponse.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/IccOpenLogicalChannelResponse.html#writeToParcel(android.os.Parcel,int)"/>
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