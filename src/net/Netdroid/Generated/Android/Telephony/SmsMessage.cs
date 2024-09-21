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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Telephony
{
    #region SmsMessage declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html"/>
    /// </summary>
    public partial class SmsMessage : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SmsMessage>
    {
        const string _bridgeClassName = "android.telephony.SmsMessage";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SmsMessage() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SmsMessage(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
        #region MessageClass declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.MessageClass.html"/>
        /// </summary>
        public partial class MessageClass : Java.Lang.Enum<Android.Telephony.SmsMessage.MessageClass>
        {
            const string _bridgeClassName = "android.telephony.SmsMessage$MessageClass";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public MessageClass() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public MessageClass(params object[] args) : base(args) { }

            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
            /// </summary>
            public override bool IsBridgeCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
            /// </summary>
            public override bool IsBridgeInterface => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

        #region SubmitPdu declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.SubmitPdu.html"/>
        /// </summary>
        public partial class SubmitPdu : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SubmitPdu>
        {
            const string _bridgeClassName = "android.telephony.SmsMessage$SubmitPdu";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public SubmitPdu() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public SubmitPdu(params object[] args) : base(args) { }

            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
            /// </summary>
            public override bool IsBridgeCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
            /// </summary>
            public override bool IsBridgeInterface => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region SmsMessage implementation
    public partial class SmsMessage
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#ENCODING_16BIT"/>
        /// </summary>
        public static int ENCODING_16BIT { get { if (!_ENCODING_16BITReady) { _ENCODING_16BITContent = SGetField<int>(LocalBridgeClazz, "ENCODING_16BIT"); _ENCODING_16BITReady = true; } return _ENCODING_16BITContent; } }
        private static int _ENCODING_16BITContent = default;
        private static bool _ENCODING_16BITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#ENCODING_7BIT"/>
        /// </summary>
        public static int ENCODING_7BIT { get { if (!_ENCODING_7BITReady) { _ENCODING_7BITContent = SGetField<int>(LocalBridgeClazz, "ENCODING_7BIT"); _ENCODING_7BITReady = true; } return _ENCODING_7BITContent; } }
        private static int _ENCODING_7BITContent = default;
        private static bool _ENCODING_7BITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#ENCODING_8BIT"/>
        /// </summary>
        public static int ENCODING_8BIT { get { if (!_ENCODING_8BITReady) { _ENCODING_8BITContent = SGetField<int>(LocalBridgeClazz, "ENCODING_8BIT"); _ENCODING_8BITReady = true; } return _ENCODING_8BITContent; } }
        private static int _ENCODING_8BITContent = default;
        private static bool _ENCODING_8BITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#ENCODING_KSC5601"/>
        /// </summary>
        public static int ENCODING_KSC5601 { get { if (!_ENCODING_KSC5601Ready) { _ENCODING_KSC5601Content = SGetField<int>(LocalBridgeClazz, "ENCODING_KSC5601"); _ENCODING_KSC5601Ready = true; } return _ENCODING_KSC5601Content; } }
        private static int _ENCODING_KSC5601Content = default;
        private static bool _ENCODING_KSC5601Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#ENCODING_UNKNOWN"/>
        /// </summary>
        public static int ENCODING_UNKNOWN { get { if (!_ENCODING_UNKNOWNReady) { _ENCODING_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "ENCODING_UNKNOWN"); _ENCODING_UNKNOWNReady = true; } return _ENCODING_UNKNOWNContent; } }
        private static int _ENCODING_UNKNOWNContent = default;
        private static bool _ENCODING_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#MAX_USER_DATA_BYTES"/>
        /// </summary>
        public static int MAX_USER_DATA_BYTES { get { if (!_MAX_USER_DATA_BYTESReady) { _MAX_USER_DATA_BYTESContent = SGetField<int>(LocalBridgeClazz, "MAX_USER_DATA_BYTES"); _MAX_USER_DATA_BYTESReady = true; } return _MAX_USER_DATA_BYTESContent; } }
        private static int _MAX_USER_DATA_BYTESContent = default;
        private static bool _MAX_USER_DATA_BYTESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#MAX_USER_DATA_BYTES_WITH_HEADER"/>
        /// </summary>
        public static int MAX_USER_DATA_BYTES_WITH_HEADER { get { if (!_MAX_USER_DATA_BYTES_WITH_HEADERReady) { _MAX_USER_DATA_BYTES_WITH_HEADERContent = SGetField<int>(LocalBridgeClazz, "MAX_USER_DATA_BYTES_WITH_HEADER"); _MAX_USER_DATA_BYTES_WITH_HEADERReady = true; } return _MAX_USER_DATA_BYTES_WITH_HEADERContent; } }
        private static int _MAX_USER_DATA_BYTES_WITH_HEADERContent = default;
        private static bool _MAX_USER_DATA_BYTES_WITH_HEADERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#MAX_USER_DATA_SEPTETS"/>
        /// </summary>
        public static int MAX_USER_DATA_SEPTETS { get { if (!_MAX_USER_DATA_SEPTETSReady) { _MAX_USER_DATA_SEPTETSContent = SGetField<int>(LocalBridgeClazz, "MAX_USER_DATA_SEPTETS"); _MAX_USER_DATA_SEPTETSReady = true; } return _MAX_USER_DATA_SEPTETSContent; } }
        private static int _MAX_USER_DATA_SEPTETSContent = default;
        private static bool _MAX_USER_DATA_SEPTETSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#MAX_USER_DATA_SEPTETS_WITH_HEADER"/>
        /// </summary>
        public static int MAX_USER_DATA_SEPTETS_WITH_HEADER { get { if (!_MAX_USER_DATA_SEPTETS_WITH_HEADERReady) { _MAX_USER_DATA_SEPTETS_WITH_HEADERContent = SGetField<int>(LocalBridgeClazz, "MAX_USER_DATA_SEPTETS_WITH_HEADER"); _MAX_USER_DATA_SEPTETS_WITH_HEADERReady = true; } return _MAX_USER_DATA_SEPTETS_WITH_HEADERContent; } }
        private static int _MAX_USER_DATA_SEPTETS_WITH_HEADERContent = default;
        private static bool _MAX_USER_DATA_SEPTETS_WITH_HEADERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#FORMAT_3GPP"/>
        /// </summary>
        public static Java.Lang.String FORMAT_3GPP { get { if (!_FORMAT_3GPPReady) { _FORMAT_3GPPContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FORMAT_3GPP"); _FORMAT_3GPPReady = true; } return _FORMAT_3GPPContent; } }
        private static Java.Lang.String _FORMAT_3GPPContent = default;
        private static bool _FORMAT_3GPPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#FORMAT_3GPP2"/>
        /// </summary>
        public static Java.Lang.String FORMAT_3GPP2 { get { if (!_FORMAT_3GPP2Ready) { _FORMAT_3GPP2Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "FORMAT_3GPP2"); _FORMAT_3GPP2Ready = true; } return _FORMAT_3GPP2Content; } }
        private static Java.Lang.String _FORMAT_3GPP2Content = default;
        private static bool _FORMAT_3GPP2Ready = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#createFromPdu(byte[],java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Telephony.SmsMessage"/></returns>
        public static Android.Telephony.SmsMessage CreateFromPdu(byte[] arg0, Java.Lang.String arg1)
        {
            return SExecute<Android.Telephony.SmsMessage>(LocalBridgeClazz, "createFromPdu", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#createFromPdu(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Android.Telephony.SmsMessage"/></returns>
        [global::System.Obsolete()]
        public static Android.Telephony.SmsMessage CreateFromPdu(byte[] arg0)
        {
            return SExecuteWithSignature<Android.Telephony.SmsMessage>(LocalBridgeClazz, "createFromPdu", "([B)Landroid/telephony/SmsMessage;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#getSubmitPdu(java.lang.String,java.lang.String,java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <returns><see cref="Android.Telephony.SmsMessage.SubmitPdu"/></returns>
        public static Android.Telephony.SmsMessage.SubmitPdu GetSubmitPdu(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, bool arg3)
        {
            return SExecute<Android.Telephony.SmsMessage.SubmitPdu>(LocalBridgeClazz, "getSubmitPdu", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#getSubmitPdu(java.lang.String,java.lang.String,short,byte[],boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="short"/></param>
        /// <param name="arg3"><see cref="byte"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        /// <returns><see cref="Android.Telephony.SmsMessage.SubmitPdu"/></returns>
        public static Android.Telephony.SmsMessage.SubmitPdu GetSubmitPdu(Java.Lang.String arg0, Java.Lang.String arg1, short arg2, byte[] arg3, bool arg4)
        {
            return SExecute<Android.Telephony.SmsMessage.SubmitPdu>(LocalBridgeClazz, "getSubmitPdu", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#getTPLayerLengthForPDU(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetTPLayerLengthForPDU(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getTPLayerLengthForPDU", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#calculateLength(java.lang.CharSequence,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="int"/></returns>
        public static int[] CalculateLength(Java.Lang.CharSequence arg0, bool arg1)
        {
            return SExecuteArray<int>(LocalBridgeClazz, "calculateLength", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#calculateLength(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="int"/></returns>
        public static int[] CalculateLength(Java.Lang.String arg0, bool arg1)
        {
            return SExecuteArray<int>(LocalBridgeClazz, "calculateLength", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#getMessageClass()"/>
        /// </summary>
        /// <returns><see cref="Android.Telephony.SmsMessage.MessageClass"/></returns>
        public Android.Telephony.SmsMessage.MessageClass GetMessageClass()
        {
            return IExecuteWithSignature<Android.Telephony.SmsMessage.MessageClass>("getMessageClass", "()Landroid/telephony/SmsMessage$MessageClass;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#isCphsMwiMessage()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCphsMwiMessage()
        {
            return IExecuteWithSignature<bool>("isCphsMwiMessage", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#isEmail()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEmail()
        {
            return IExecuteWithSignature<bool>("isEmail", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#isMWIClearMessage()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsMWIClearMessage()
        {
            return IExecuteWithSignature<bool>("isMWIClearMessage", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#isMwiDontStore()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsMwiDontStore()
        {
            return IExecuteWithSignature<bool>("isMwiDontStore", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#isMWISetMessage()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsMWISetMessage()
        {
            return IExecuteWithSignature<bool>("isMWISetMessage", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#isReplace()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsReplace()
        {
            return IExecuteWithSignature<bool>("isReplace", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#isReplyPathPresent()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsReplyPathPresent()
        {
            return IExecuteWithSignature<bool>("isReplyPathPresent", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#isStatusReportMessage()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsStatusReportMessage()
        {
            return IExecuteWithSignature<bool>("isStatusReportMessage", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#getPdu()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetPdu()
        {
            return IExecuteWithSignatureArray<byte>("getPdu", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#getUserData()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetUserData()
        {
            return IExecuteWithSignatureArray<byte>("getUserData", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#getIndexOnIcc()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetIndexOnIcc()
        {
            return IExecuteWithSignature<int>("getIndexOnIcc", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#getIndexOnSim()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetIndexOnSim()
        {
            return IExecuteWithSignature<int>("getIndexOnSim", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#getProtocolIdentifier()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetProtocolIdentifier()
        {
            return IExecuteWithSignature<int>("getProtocolIdentifier", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#getStatus()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetStatus()
        {
            return IExecuteWithSignature<int>("getStatus", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#getStatusOnIcc()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetStatusOnIcc()
        {
            return IExecuteWithSignature<int>("getStatusOnIcc", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#getStatusOnSim()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetStatusOnSim()
        {
            return IExecuteWithSignature<int>("getStatusOnSim", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#getDisplayMessageBody()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDisplayMessageBody()
        {
            return IExecuteWithSignature<Java.Lang.String>("getDisplayMessageBody", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#getDisplayOriginatingAddress()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDisplayOriginatingAddress()
        {
            return IExecuteWithSignature<Java.Lang.String>("getDisplayOriginatingAddress", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#getEmailBody()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetEmailBody()
        {
            return IExecuteWithSignature<Java.Lang.String>("getEmailBody", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#getEmailFrom()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetEmailFrom()
        {
            return IExecuteWithSignature<Java.Lang.String>("getEmailFrom", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#getMessageBody()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetMessageBody()
        {
            return IExecuteWithSignature<Java.Lang.String>("getMessageBody", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#getOriginatingAddress()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetOriginatingAddress()
        {
            return IExecuteWithSignature<Java.Lang.String>("getOriginatingAddress", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#getPseudoSubject()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPseudoSubject()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPseudoSubject", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#getServiceCenterAddress()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetServiceCenterAddress()
        {
            return IExecuteWithSignature<Java.Lang.String>("getServiceCenterAddress", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.html#getTimestampMillis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetTimestampMillis()
        {
            return IExecuteWithSignature<long>("getTimestampMillis", "()J");
        }

        #endregion

        #region Nested classes
        #region MessageClass implementation
        public partial class MessageClass
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.MessageClass.html#CLASS_0"/>
            /// </summary>
            public static Android.Telephony.SmsMessage.MessageClass CLASS_0 { get { if (!_CLASS_0Ready) { _CLASS_0Content = SGetField<Android.Telephony.SmsMessage.MessageClass>(LocalBridgeClazz, "CLASS_0"); _CLASS_0Ready = true; } return _CLASS_0Content; } }
            private static Android.Telephony.SmsMessage.MessageClass _CLASS_0Content = default;
            private static bool _CLASS_0Ready = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.MessageClass.html#CLASS_1"/>
            /// </summary>
            public static Android.Telephony.SmsMessage.MessageClass CLASS_1 { get { if (!_CLASS_1Ready) { _CLASS_1Content = SGetField<Android.Telephony.SmsMessage.MessageClass>(LocalBridgeClazz, "CLASS_1"); _CLASS_1Ready = true; } return _CLASS_1Content; } }
            private static Android.Telephony.SmsMessage.MessageClass _CLASS_1Content = default;
            private static bool _CLASS_1Ready = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.MessageClass.html#CLASS_2"/>
            /// </summary>
            public static Android.Telephony.SmsMessage.MessageClass CLASS_2 { get { if (!_CLASS_2Ready) { _CLASS_2Content = SGetField<Android.Telephony.SmsMessage.MessageClass>(LocalBridgeClazz, "CLASS_2"); _CLASS_2Ready = true; } return _CLASS_2Content; } }
            private static Android.Telephony.SmsMessage.MessageClass _CLASS_2Content = default;
            private static bool _CLASS_2Ready = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.MessageClass.html#CLASS_3"/>
            /// </summary>
            public static Android.Telephony.SmsMessage.MessageClass CLASS_3 { get { if (!_CLASS_3Ready) { _CLASS_3Content = SGetField<Android.Telephony.SmsMessage.MessageClass>(LocalBridgeClazz, "CLASS_3"); _CLASS_3Ready = true; } return _CLASS_3Content; } }
            private static Android.Telephony.SmsMessage.MessageClass _CLASS_3Content = default;
            private static bool _CLASS_3Ready = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.MessageClass.html#UNKNOWN"/>
            /// </summary>
            public static Android.Telephony.SmsMessage.MessageClass UNKNOWN { get { if (!_UNKNOWNReady) { _UNKNOWNContent = SGetField<Android.Telephony.SmsMessage.MessageClass>(LocalBridgeClazz, "UNKNOWN"); _UNKNOWNReady = true; } return _UNKNOWNContent; } }
            private static Android.Telephony.SmsMessage.MessageClass _UNKNOWNContent = default;
            private static bool _UNKNOWNReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.MessageClass.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Telephony.SmsMessage.MessageClass"/></returns>
            public static Android.Telephony.SmsMessage.MessageClass ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Telephony.SmsMessage.MessageClass>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/telephony/SmsMessage$MessageClass;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.MessageClass.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Telephony.SmsMessage.MessageClass"/></returns>
            public static Android.Telephony.SmsMessage.MessageClass[] Values()
            {
                return SExecuteWithSignatureArray<Android.Telephony.SmsMessage.MessageClass>(LocalBridgeClazz, "values", "()[Landroid/telephony/SmsMessage$MessageClass;");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region SubmitPdu implementation
        public partial class SubmitPdu
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.SubmitPdu.html#encodedMessage"/>
            /// </summary>
            public byte[] encodedMessage { get { return IGetFieldArray<byte>("encodedMessage"); } set { ISetField("encodedMessage", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/SmsMessage.SubmitPdu.html#encodedScAddress"/>
            /// </summary>
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