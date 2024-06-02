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

namespace Android.Telephony.Ims
{
    #region SipDetails
    public partial class SipDetails
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/SipDetails.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/SipDetails.html#METHOD_PUBLISH"/>
        /// </summary>
        public static int METHOD_PUBLISH { get { if (!_METHOD_PUBLISHReady) { _METHOD_PUBLISHContent = SGetField<int>(LocalBridgeClazz, "METHOD_PUBLISH"); _METHOD_PUBLISHReady = true; } return _METHOD_PUBLISHContent; } }
        private static int _METHOD_PUBLISHContent = default;
        private static bool _METHOD_PUBLISHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/SipDetails.html#METHOD_REGISTER"/>
        /// </summary>
        public static int METHOD_REGISTER { get { if (!_METHOD_REGISTERReady) { _METHOD_REGISTERContent = SGetField<int>(LocalBridgeClazz, "METHOD_REGISTER"); _METHOD_REGISTERReady = true; } return _METHOD_REGISTERContent; } }
        private static int _METHOD_REGISTERContent = default;
        private static bool _METHOD_REGISTERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/SipDetails.html#METHOD_SUBSCRIBE"/>
        /// </summary>
        public static int METHOD_SUBSCRIBE { get { if (!_METHOD_SUBSCRIBEReady) { _METHOD_SUBSCRIBEContent = SGetField<int>(LocalBridgeClazz, "METHOD_SUBSCRIBE"); _METHOD_SUBSCRIBEReady = true; } return _METHOD_SUBSCRIBEContent; } }
        private static int _METHOD_SUBSCRIBEContent = default;
        private static bool _METHOD_SUBSCRIBEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/SipDetails.html#METHOD_UNKNOWN"/>
        /// </summary>
        public static int METHOD_UNKNOWN { get { if (!_METHOD_UNKNOWNReady) { _METHOD_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "METHOD_UNKNOWN"); _METHOD_UNKNOWNReady = true; } return _METHOD_UNKNOWNContent; } }
        private static int _METHOD_UNKNOWNContent = default;
        private static bool _METHOD_UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/SipDetails.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/SipDetails.html#getCSeq()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCSeq()
        {
            return IExecuteWithSignature<int>("getCSeq", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/SipDetails.html#getMethod()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMethod()
        {
            return IExecuteWithSignature<int>("getMethod", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/SipDetails.html#getReasonHeaderCause()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetReasonHeaderCause()
        {
            return IExecuteWithSignature<int>("getReasonHeaderCause", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/SipDetails.html#getResponseCode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetResponseCode()
        {
            return IExecuteWithSignature<int>("getResponseCode", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/SipDetails.html#getCallId()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetCallId()
        {
            return IExecuteWithSignature<Java.Lang.String>("getCallId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/SipDetails.html#getReasonHeaderText()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetReasonHeaderText()
        {
            return IExecuteWithSignature<Java.Lang.String>("getReasonHeaderText", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/SipDetails.html#getResponsePhrase()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetResponsePhrase()
        {
            return IExecuteWithSignature<Java.Lang.String>("getResponsePhrase", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/SipDetails.html#writeToParcel(android.os.Parcel,int)"/>
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