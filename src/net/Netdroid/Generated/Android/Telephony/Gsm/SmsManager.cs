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

namespace Android.Telephony.Gsm
{
    #region SmsManager
    public partial class SmsManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsManager.html#RESULT_ERROR_GENERIC_FAILURE"/>
        /// </summary>
        [System.Obsolete()]
        public static int RESULT_ERROR_GENERIC_FAILURE { get { if (!_RESULT_ERROR_GENERIC_FAILUREReady) { _RESULT_ERROR_GENERIC_FAILUREContent = SGetField<int>(LocalBridgeClazz, "RESULT_ERROR_GENERIC_FAILURE"); _RESULT_ERROR_GENERIC_FAILUREReady = true; } return _RESULT_ERROR_GENERIC_FAILUREContent; } }
        private static int _RESULT_ERROR_GENERIC_FAILUREContent = default;
        private static bool _RESULT_ERROR_GENERIC_FAILUREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsManager.html#RESULT_ERROR_NO_SERVICE"/>
        /// </summary>
        [System.Obsolete()]
        public static int RESULT_ERROR_NO_SERVICE { get { if (!_RESULT_ERROR_NO_SERVICEReady) { _RESULT_ERROR_NO_SERVICEContent = SGetField<int>(LocalBridgeClazz, "RESULT_ERROR_NO_SERVICE"); _RESULT_ERROR_NO_SERVICEReady = true; } return _RESULT_ERROR_NO_SERVICEContent; } }
        private static int _RESULT_ERROR_NO_SERVICEContent = default;
        private static bool _RESULT_ERROR_NO_SERVICEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsManager.html#RESULT_ERROR_NULL_PDU"/>
        /// </summary>
        [System.Obsolete()]
        public static int RESULT_ERROR_NULL_PDU { get { if (!_RESULT_ERROR_NULL_PDUReady) { _RESULT_ERROR_NULL_PDUContent = SGetField<int>(LocalBridgeClazz, "RESULT_ERROR_NULL_PDU"); _RESULT_ERROR_NULL_PDUReady = true; } return _RESULT_ERROR_NULL_PDUContent; } }
        private static int _RESULT_ERROR_NULL_PDUContent = default;
        private static bool _RESULT_ERROR_NULL_PDUReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsManager.html#RESULT_ERROR_RADIO_OFF"/>
        /// </summary>
        [System.Obsolete()]
        public static int RESULT_ERROR_RADIO_OFF { get { if (!_RESULT_ERROR_RADIO_OFFReady) { _RESULT_ERROR_RADIO_OFFContent = SGetField<int>(LocalBridgeClazz, "RESULT_ERROR_RADIO_OFF"); _RESULT_ERROR_RADIO_OFFReady = true; } return _RESULT_ERROR_RADIO_OFFContent; } }
        private static int _RESULT_ERROR_RADIO_OFFContent = default;
        private static bool _RESULT_ERROR_RADIO_OFFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsManager.html#STATUS_ON_SIM_FREE"/>
        /// </summary>
        [System.Obsolete()]
        public static int STATUS_ON_SIM_FREE { get { if (!_STATUS_ON_SIM_FREEReady) { _STATUS_ON_SIM_FREEContent = SGetField<int>(LocalBridgeClazz, "STATUS_ON_SIM_FREE"); _STATUS_ON_SIM_FREEReady = true; } return _STATUS_ON_SIM_FREEContent; } }
        private static int _STATUS_ON_SIM_FREEContent = default;
        private static bool _STATUS_ON_SIM_FREEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsManager.html#STATUS_ON_SIM_READ"/>
        /// </summary>
        [System.Obsolete()]
        public static int STATUS_ON_SIM_READ { get { if (!_STATUS_ON_SIM_READReady) { _STATUS_ON_SIM_READContent = SGetField<int>(LocalBridgeClazz, "STATUS_ON_SIM_READ"); _STATUS_ON_SIM_READReady = true; } return _STATUS_ON_SIM_READContent; } }
        private static int _STATUS_ON_SIM_READContent = default;
        private static bool _STATUS_ON_SIM_READReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsManager.html#STATUS_ON_SIM_SENT"/>
        /// </summary>
        [System.Obsolete()]
        public static int STATUS_ON_SIM_SENT { get { if (!_STATUS_ON_SIM_SENTReady) { _STATUS_ON_SIM_SENTContent = SGetField<int>(LocalBridgeClazz, "STATUS_ON_SIM_SENT"); _STATUS_ON_SIM_SENTReady = true; } return _STATUS_ON_SIM_SENTContent; } }
        private static int _STATUS_ON_SIM_SENTContent = default;
        private static bool _STATUS_ON_SIM_SENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsManager.html#STATUS_ON_SIM_UNREAD"/>
        /// </summary>
        [System.Obsolete()]
        public static int STATUS_ON_SIM_UNREAD { get { if (!_STATUS_ON_SIM_UNREADReady) { _STATUS_ON_SIM_UNREADContent = SGetField<int>(LocalBridgeClazz, "STATUS_ON_SIM_UNREAD"); _STATUS_ON_SIM_UNREADReady = true; } return _STATUS_ON_SIM_UNREADContent; } }
        private static int _STATUS_ON_SIM_UNREADContent = default;
        private static bool _STATUS_ON_SIM_UNREADReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsManager.html#STATUS_ON_SIM_UNSENT"/>
        /// </summary>
        [System.Obsolete()]
        public static int STATUS_ON_SIM_UNSENT { get { if (!_STATUS_ON_SIM_UNSENTReady) { _STATUS_ON_SIM_UNSENTContent = SGetField<int>(LocalBridgeClazz, "STATUS_ON_SIM_UNSENT"); _STATUS_ON_SIM_UNSENTReady = true; } return _STATUS_ON_SIM_UNSENTContent; } }
        private static int _STATUS_ON_SIM_UNSENTContent = default;
        private static bool _STATUS_ON_SIM_UNSENTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsManager.html#getDefault()"/> 
        /// </summary>
        [System.Obsolete()]
        public static Android.Telephony.Gsm.SmsManager Default
        {
            get { return SExecuteWithSignature<Android.Telephony.Gsm.SmsManager>(LocalBridgeClazz, "getDefault", "()Landroid/telephony/gsm/SmsManager;"); }
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsManager.html#divideMessage(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.ArrayList"/></returns>
        [System.Obsolete()]
        public Java.Util.ArrayList<Java.Lang.String> DivideMessage(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.ArrayList<Java.Lang.String>>("divideMessage", "(Ljava/lang/String;)Ljava/util/ArrayList;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsManager.html#sendDataMessage(java.lang.String,java.lang.String,short,byte[],android.app.PendingIntent,android.app.PendingIntent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="short"/></param>
        /// <param name="arg3"><see cref="byte"/></param>
        /// <param name="arg4"><see cref="Android.App.PendingIntent"/></param>
        /// <param name="arg5"><see cref="Android.App.PendingIntent"/></param>
        [System.Obsolete()]
        public void SendDataMessage(Java.Lang.String arg0, Java.Lang.String arg1, short arg2, byte[] arg3, Android.App.PendingIntent arg4, Android.App.PendingIntent arg5)
        {
            IExecute("sendDataMessage", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsManager.html#sendMultipartTextMessage(java.lang.String,java.lang.String,java.util.ArrayList,java.util.ArrayList,java.util.ArrayList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Util.ArrayList"/></param>
        /// <param name="arg3"><see cref="Java.Util.ArrayList"/></param>
        /// <param name="arg4"><see cref="Java.Util.ArrayList"/></param>
        [System.Obsolete()]
        public void SendMultipartTextMessage(Java.Lang.String arg0, Java.Lang.String arg1, Java.Util.ArrayList<Java.Lang.String> arg2, Java.Util.ArrayList<Android.App.PendingIntent> arg3, Java.Util.ArrayList<Android.App.PendingIntent> arg4)
        {
            IExecute("sendMultipartTextMessage", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/gsm/SmsManager.html#sendTextMessage(java.lang.String,java.lang.String,java.lang.String,android.app.PendingIntent,android.app.PendingIntent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Android.App.PendingIntent"/></param>
        /// <param name="arg4"><see cref="Android.App.PendingIntent"/></param>
        [System.Obsolete()]
        public void SendTextMessage(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, Android.App.PendingIntent arg3, Android.App.PendingIntent arg4)
        {
            IExecute("sendTextMessage", arg0, arg1, arg2, arg3, arg4);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}