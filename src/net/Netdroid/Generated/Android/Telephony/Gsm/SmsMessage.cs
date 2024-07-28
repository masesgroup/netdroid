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

namespace Android.Telephony.Gsm
{
    #region SmsMessage
    public partial class SmsMessage
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#ENCODING_16BIT"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int ENCODING_16BIT { get { if (!_ENCODING_16BITReady) { _ENCODING_16BITContent = SGetField<int>(LocalBridgeClazz, "ENCODING_16BIT"); _ENCODING_16BITReady = true; } return _ENCODING_16BITContent; } }
        private static int _ENCODING_16BITContent = default;
        private static bool _ENCODING_16BITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#ENCODING_7BIT"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int ENCODING_7BIT { get { if (!_ENCODING_7BITReady) { _ENCODING_7BITContent = SGetField<int>(LocalBridgeClazz, "ENCODING_7BIT"); _ENCODING_7BITReady = true; } return _ENCODING_7BITContent; } }
        private static int _ENCODING_7BITContent = default;
        private static bool _ENCODING_7BITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#ENCODING_8BIT"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int ENCODING_8BIT { get { if (!_ENCODING_8BITReady) { _ENCODING_8BITContent = SGetField<int>(LocalBridgeClazz, "ENCODING_8BIT"); _ENCODING_8BITReady = true; } return _ENCODING_8BITContent; } }
        private static int _ENCODING_8BITContent = default;
        private static bool _ENCODING_8BITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#ENCODING_UNKNOWN"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int ENCODING_UNKNOWN { get { if (!_ENCODING_UNKNOWNReady) { _ENCODING_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "ENCODING_UNKNOWN"); _ENCODING_UNKNOWNReady = true; } return _ENCODING_UNKNOWNContent; } }
        private static int _ENCODING_UNKNOWNContent = default;
        private static bool _ENCODING_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#MAX_USER_DATA_BYTES"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int MAX_USER_DATA_BYTES { get { if (!_MAX_USER_DATA_BYTESReady) { _MAX_USER_DATA_BYTESContent = SGetField<int>(LocalBridgeClazz, "MAX_USER_DATA_BYTES"); _MAX_USER_DATA_BYTESReady = true; } return _MAX_USER_DATA_BYTESContent; } }
        private static int _MAX_USER_DATA_BYTESContent = default;
        private static bool _MAX_USER_DATA_BYTESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#MAX_USER_DATA_SEPTETS"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int MAX_USER_DATA_SEPTETS { get { if (!_MAX_USER_DATA_SEPTETSReady) { _MAX_USER_DATA_SEPTETSContent = SGetField<int>(LocalBridgeClazz, "MAX_USER_DATA_SEPTETS"); _MAX_USER_DATA_SEPTETSReady = true; } return _MAX_USER_DATA_SEPTETSContent; } }
        private static int _MAX_USER_DATA_SEPTETSContent = default;
        private static bool _MAX_USER_DATA_SEPTETSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#MAX_USER_DATA_SEPTETS_WITH_HEADER"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int MAX_USER_DATA_SEPTETS_WITH_HEADER { get { if (!_MAX_USER_DATA_SEPTETS_WITH_HEADERReady) { _MAX_USER_DATA_SEPTETS_WITH_HEADERContent = SGetField<int>(LocalBridgeClazz, "MAX_USER_DATA_SEPTETS_WITH_HEADER"); _MAX_USER_DATA_SEPTETS_WITH_HEADERReady = true; } return _MAX_USER_DATA_SEPTETS_WITH_HEADERContent; } }
        private static int _MAX_USER_DATA_SEPTETS_WITH_HEADERContent = default;
        private static bool _MAX_USER_DATA_SEPTETS_WITH_HEADERReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#createFromPdu(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Android.Telephony.Gsm.SmsMessage"/></returns>
        [global::System.Obsolete()]
        public static Android.Telephony.Gsm.SmsMessage CreateFromPdu(byte[] arg0)
        {
            return SExecuteWithSignature<Android.Telephony.Gsm.SmsMessage>(LocalBridgeClazz, "createFromPdu", "([B)Landroid/telephony/gsm/SmsMessage;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#getSubmitPdu(java.lang.String,java.lang.String,java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <returns><see cref="Android.Telephony.Gsm.SmsMessage.SubmitPdu"/></returns>
        [global::System.Obsolete()]
        public static Android.Telephony.Gsm.SmsMessage.SubmitPdu GetSubmitPdu(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, bool arg3)
        {
            return SExecute<Android.Telephony.Gsm.SmsMessage.SubmitPdu>(LocalBridgeClazz, "getSubmitPdu", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#getSubmitPdu(java.lang.String,java.lang.String,short,byte[],boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="short"/></param>
        /// <param name="arg3"><see cref="byte"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        /// <returns><see cref="Android.Telephony.Gsm.SmsMessage.SubmitPdu"/></returns>
        [global::System.Obsolete()]
        public static Android.Telephony.Gsm.SmsMessage.SubmitPdu GetSubmitPdu(Java.Lang.String arg0, Java.Lang.String arg1, short arg2, byte[] arg3, bool arg4)
        {
            return SExecute<Android.Telephony.Gsm.SmsMessage.SubmitPdu>(LocalBridgeClazz, "getSubmitPdu", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#getTPLayerLengthForPDU(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public static int GetTPLayerLengthForPDU(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getTPLayerLengthForPDU", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#calculateLength(java.lang.CharSequence,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public static int[] CalculateLength(Java.Lang.CharSequence arg0, bool arg1)
        {
            return SExecuteArray<int>(LocalBridgeClazz, "calculateLength", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#calculateLength(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public static int[] CalculateLength(Java.Lang.String arg0, bool arg1)
        {
            return SExecuteArray<int>(LocalBridgeClazz, "calculateLength", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#getMessageClass()"/>
        /// </summary>
        /// <returns><see cref="Android.Telephony.Gsm.SmsMessage.MessageClass"/></returns>
        [global::System.Obsolete()]
        public Android.Telephony.Gsm.SmsMessage.MessageClass GetMessageClass()
        {
            return IExecuteWithSignature<Android.Telephony.Gsm.SmsMessage.MessageClass>("getMessageClass", "()Landroid/telephony/gsm/SmsMessage$MessageClass;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#isCphsMwiMessage()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsCphsMwiMessage()
        {
            return IExecuteWithSignature<bool>("isCphsMwiMessage", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#isEmail()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsEmail()
        {
            return IExecuteWithSignature<bool>("isEmail", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#isMWIClearMessage()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsMWIClearMessage()
        {
            return IExecuteWithSignature<bool>("isMWIClearMessage", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#isMwiDontStore()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsMwiDontStore()
        {
            return IExecuteWithSignature<bool>("isMwiDontStore", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#isMWISetMessage()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsMWISetMessage()
        {
            return IExecuteWithSignature<bool>("isMWISetMessage", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#isReplace()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsReplace()
        {
            return IExecuteWithSignature<bool>("isReplace", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#isReplyPathPresent()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsReplyPathPresent()
        {
            return IExecuteWithSignature<bool>("isReplyPathPresent", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#isStatusReportMessage()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsStatusReportMessage()
        {
            return IExecuteWithSignature<bool>("isStatusReportMessage", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#getPdu()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        [global::System.Obsolete()]
        public byte[] GetPdu()
        {
            return IExecuteWithSignatureArray<byte>("getPdu", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#getUserData()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        [global::System.Obsolete()]
        public byte[] GetUserData()
        {
            return IExecuteWithSignatureArray<byte>("getUserData", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#getIndexOnSim()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetIndexOnSim()
        {
            return IExecuteWithSignature<int>("getIndexOnSim", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#getProtocolIdentifier()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetProtocolIdentifier()
        {
            return IExecuteWithSignature<int>("getProtocolIdentifier", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#getStatus()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetStatus()
        {
            return IExecuteWithSignature<int>("getStatus", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#getStatusOnSim()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetStatusOnSim()
        {
            return IExecuteWithSignature<int>("getStatusOnSim", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#getDisplayMessageBody()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetDisplayMessageBody()
        {
            return IExecuteWithSignature<Java.Lang.String>("getDisplayMessageBody", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#getDisplayOriginatingAddress()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetDisplayOriginatingAddress()
        {
            return IExecuteWithSignature<Java.Lang.String>("getDisplayOriginatingAddress", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#getEmailBody()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetEmailBody()
        {
            return IExecuteWithSignature<Java.Lang.String>("getEmailBody", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#getEmailFrom()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetEmailFrom()
        {
            return IExecuteWithSignature<Java.Lang.String>("getEmailFrom", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#getMessageBody()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetMessageBody()
        {
            return IExecuteWithSignature<Java.Lang.String>("getMessageBody", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#getOriginatingAddress()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetOriginatingAddress()
        {
            return IExecuteWithSignature<Java.Lang.String>("getOriginatingAddress", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#getPseudoSubject()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetPseudoSubject()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPseudoSubject", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#getServiceCenterAddress()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetServiceCenterAddress()
        {
            return IExecuteWithSignature<Java.Lang.String>("getServiceCenterAddress", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.html#getTimestampMillis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        [global::System.Obsolete()]
        public long GetTimestampMillis()
        {
            return IExecuteWithSignature<long>("getTimestampMillis", "()J");
        }

        #endregion

        #region Nested classes
        #region MessageClass
        public partial class MessageClass
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.MessageClass.html#CLASS_0"/>
            /// </summary>
            [global::System.Obsolete()]
            public static Android.Telephony.Gsm.SmsMessage.MessageClass CLASS_0 { get { if (!_CLASS_0Ready) { _CLASS_0Content = SGetField<Android.Telephony.Gsm.SmsMessage.MessageClass>(LocalBridgeClazz, "CLASS_0"); _CLASS_0Ready = true; } return _CLASS_0Content; } }
            private static Android.Telephony.Gsm.SmsMessage.MessageClass _CLASS_0Content = default;
            private static bool _CLASS_0Ready = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.MessageClass.html#CLASS_1"/>
            /// </summary>
            [global::System.Obsolete()]
            public static Android.Telephony.Gsm.SmsMessage.MessageClass CLASS_1 { get { if (!_CLASS_1Ready) { _CLASS_1Content = SGetField<Android.Telephony.Gsm.SmsMessage.MessageClass>(LocalBridgeClazz, "CLASS_1"); _CLASS_1Ready = true; } return _CLASS_1Content; } }
            private static Android.Telephony.Gsm.SmsMessage.MessageClass _CLASS_1Content = default;
            private static bool _CLASS_1Ready = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.MessageClass.html#CLASS_2"/>
            /// </summary>
            [global::System.Obsolete()]
            public static Android.Telephony.Gsm.SmsMessage.MessageClass CLASS_2 { get { if (!_CLASS_2Ready) { _CLASS_2Content = SGetField<Android.Telephony.Gsm.SmsMessage.MessageClass>(LocalBridgeClazz, "CLASS_2"); _CLASS_2Ready = true; } return _CLASS_2Content; } }
            private static Android.Telephony.Gsm.SmsMessage.MessageClass _CLASS_2Content = default;
            private static bool _CLASS_2Ready = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.MessageClass.html#CLASS_3"/>
            /// </summary>
            [global::System.Obsolete()]
            public static Android.Telephony.Gsm.SmsMessage.MessageClass CLASS_3 { get { if (!_CLASS_3Ready) { _CLASS_3Content = SGetField<Android.Telephony.Gsm.SmsMessage.MessageClass>(LocalBridgeClazz, "CLASS_3"); _CLASS_3Ready = true; } return _CLASS_3Content; } }
            private static Android.Telephony.Gsm.SmsMessage.MessageClass _CLASS_3Content = default;
            private static bool _CLASS_3Ready = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.MessageClass.html#UNKNOWN"/>
            /// </summary>
            [global::System.Obsolete()]
            public static Android.Telephony.Gsm.SmsMessage.MessageClass UNKNOWN { get { if (!_UNKNOWNReady) { _UNKNOWNContent = SGetField<Android.Telephony.Gsm.SmsMessage.MessageClass>(LocalBridgeClazz, "UNKNOWN"); _UNKNOWNReady = true; } return _UNKNOWNContent; } }
            private static Android.Telephony.Gsm.SmsMessage.MessageClass _UNKNOWNContent = default;
            private static bool _UNKNOWNReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.MessageClass.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Telephony.Gsm.SmsMessage.MessageClass"/></returns>
            public static Android.Telephony.Gsm.SmsMessage.MessageClass ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Telephony.Gsm.SmsMessage.MessageClass>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/telephony/gsm/SmsMessage$MessageClass;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.MessageClass.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Telephony.Gsm.SmsMessage.MessageClass"/></returns>
            public static Android.Telephony.Gsm.SmsMessage.MessageClass[] Values()
            {
                return SExecuteWithSignatureArray<Android.Telephony.Gsm.SmsMessage.MessageClass>(LocalBridgeClazz, "values", "()[Landroid/telephony/gsm/SmsMessage$MessageClass;");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region SubmitPdu
        public partial class SubmitPdu
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.SubmitPdu.html#encodedMessage"/>
            /// </summary>
            [global::System.Obsolete()]
            public byte[] encodedMessage { get { return IGetFieldArray<byte>("encodedMessage"); } set { ISetField("encodedMessage", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsMessage.SubmitPdu.html#encodedScAddress"/>
            /// </summary>
            [global::System.Obsolete()]
            public byte[] encodedScAddress { get { return IGetFieldArray<byte>("encodedScAddress"); } set { ISetField("encodedScAddress", value); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

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