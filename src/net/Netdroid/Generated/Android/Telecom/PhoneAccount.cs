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

namespace Android.Telecom
{
    #region PhoneAccount
    public partial class PhoneAccount
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#CAPABILITY_ADHOC_CONFERENCE_CALLING"/>
        /// </summary>
        public static int CAPABILITY_ADHOC_CONFERENCE_CALLING { get { if (!_CAPABILITY_ADHOC_CONFERENCE_CALLINGReady) { _CAPABILITY_ADHOC_CONFERENCE_CALLINGContent = SGetField<int>(LocalBridgeClazz, "CAPABILITY_ADHOC_CONFERENCE_CALLING"); _CAPABILITY_ADHOC_CONFERENCE_CALLINGReady = true; } return _CAPABILITY_ADHOC_CONFERENCE_CALLINGContent; } }
        private static int _CAPABILITY_ADHOC_CONFERENCE_CALLINGContent = default;
        private static bool _CAPABILITY_ADHOC_CONFERENCE_CALLINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#CAPABILITY_CALL_COMPOSER"/>
        /// </summary>
        public static int CAPABILITY_CALL_COMPOSER { get { if (!_CAPABILITY_CALL_COMPOSERReady) { _CAPABILITY_CALL_COMPOSERContent = SGetField<int>(LocalBridgeClazz, "CAPABILITY_CALL_COMPOSER"); _CAPABILITY_CALL_COMPOSERReady = true; } return _CAPABILITY_CALL_COMPOSERContent; } }
        private static int _CAPABILITY_CALL_COMPOSERContent = default;
        private static bool _CAPABILITY_CALL_COMPOSERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#CAPABILITY_CALL_PROVIDER"/>
        /// </summary>
        public static int CAPABILITY_CALL_PROVIDER { get { if (!_CAPABILITY_CALL_PROVIDERReady) { _CAPABILITY_CALL_PROVIDERContent = SGetField<int>(LocalBridgeClazz, "CAPABILITY_CALL_PROVIDER"); _CAPABILITY_CALL_PROVIDERReady = true; } return _CAPABILITY_CALL_PROVIDERContent; } }
        private static int _CAPABILITY_CALL_PROVIDERContent = default;
        private static bool _CAPABILITY_CALL_PROVIDERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#CAPABILITY_CALL_SUBJECT"/>
        /// </summary>
        public static int CAPABILITY_CALL_SUBJECT { get { if (!_CAPABILITY_CALL_SUBJECTReady) { _CAPABILITY_CALL_SUBJECTContent = SGetField<int>(LocalBridgeClazz, "CAPABILITY_CALL_SUBJECT"); _CAPABILITY_CALL_SUBJECTReady = true; } return _CAPABILITY_CALL_SUBJECTContent; } }
        private static int _CAPABILITY_CALL_SUBJECTContent = default;
        private static bool _CAPABILITY_CALL_SUBJECTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#CAPABILITY_CONNECTION_MANAGER"/>
        /// </summary>
        public static int CAPABILITY_CONNECTION_MANAGER { get { if (!_CAPABILITY_CONNECTION_MANAGERReady) { _CAPABILITY_CONNECTION_MANAGERContent = SGetField<int>(LocalBridgeClazz, "CAPABILITY_CONNECTION_MANAGER"); _CAPABILITY_CONNECTION_MANAGERReady = true; } return _CAPABILITY_CONNECTION_MANAGERContent; } }
        private static int _CAPABILITY_CONNECTION_MANAGERContent = default;
        private static bool _CAPABILITY_CONNECTION_MANAGERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#CAPABILITY_PLACE_EMERGENCY_CALLS"/>
        /// </summary>
        public static int CAPABILITY_PLACE_EMERGENCY_CALLS { get { if (!_CAPABILITY_PLACE_EMERGENCY_CALLSReady) { _CAPABILITY_PLACE_EMERGENCY_CALLSContent = SGetField<int>(LocalBridgeClazz, "CAPABILITY_PLACE_EMERGENCY_CALLS"); _CAPABILITY_PLACE_EMERGENCY_CALLSReady = true; } return _CAPABILITY_PLACE_EMERGENCY_CALLSContent; } }
        private static int _CAPABILITY_PLACE_EMERGENCY_CALLSContent = default;
        private static bool _CAPABILITY_PLACE_EMERGENCY_CALLSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#CAPABILITY_RTT"/>
        /// </summary>
        public static int CAPABILITY_RTT { get { if (!_CAPABILITY_RTTReady) { _CAPABILITY_RTTContent = SGetField<int>(LocalBridgeClazz, "CAPABILITY_RTT"); _CAPABILITY_RTTReady = true; } return _CAPABILITY_RTTContent; } }
        private static int _CAPABILITY_RTTContent = default;
        private static bool _CAPABILITY_RTTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#CAPABILITY_SELF_MANAGED"/>
        /// </summary>
        public static int CAPABILITY_SELF_MANAGED { get { if (!_CAPABILITY_SELF_MANAGEDReady) { _CAPABILITY_SELF_MANAGEDContent = SGetField<int>(LocalBridgeClazz, "CAPABILITY_SELF_MANAGED"); _CAPABILITY_SELF_MANAGEDReady = true; } return _CAPABILITY_SELF_MANAGEDContent; } }
        private static int _CAPABILITY_SELF_MANAGEDContent = default;
        private static bool _CAPABILITY_SELF_MANAGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#CAPABILITY_SIM_SUBSCRIPTION"/>
        /// </summary>
        public static int CAPABILITY_SIM_SUBSCRIPTION { get { if (!_CAPABILITY_SIM_SUBSCRIPTIONReady) { _CAPABILITY_SIM_SUBSCRIPTIONContent = SGetField<int>(LocalBridgeClazz, "CAPABILITY_SIM_SUBSCRIPTION"); _CAPABILITY_SIM_SUBSCRIPTIONReady = true; } return _CAPABILITY_SIM_SUBSCRIPTIONContent; } }
        private static int _CAPABILITY_SIM_SUBSCRIPTIONContent = default;
        private static bool _CAPABILITY_SIM_SUBSCRIPTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#CAPABILITY_SUPPORTS_CALL_STREAMING"/>
        /// </summary>
        public static int CAPABILITY_SUPPORTS_CALL_STREAMING { get { if (!_CAPABILITY_SUPPORTS_CALL_STREAMINGReady) { _CAPABILITY_SUPPORTS_CALL_STREAMINGContent = SGetField<int>(LocalBridgeClazz, "CAPABILITY_SUPPORTS_CALL_STREAMING"); _CAPABILITY_SUPPORTS_CALL_STREAMINGReady = true; } return _CAPABILITY_SUPPORTS_CALL_STREAMINGContent; } }
        private static int _CAPABILITY_SUPPORTS_CALL_STREAMINGContent = default;
        private static bool _CAPABILITY_SUPPORTS_CALL_STREAMINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#CAPABILITY_SUPPORTS_TRANSACTIONAL_OPERATIONS"/>
        /// </summary>
        public static int CAPABILITY_SUPPORTS_TRANSACTIONAL_OPERATIONS { get { if (!_CAPABILITY_SUPPORTS_TRANSACTIONAL_OPERATIONSReady) { _CAPABILITY_SUPPORTS_TRANSACTIONAL_OPERATIONSContent = SGetField<int>(LocalBridgeClazz, "CAPABILITY_SUPPORTS_TRANSACTIONAL_OPERATIONS"); _CAPABILITY_SUPPORTS_TRANSACTIONAL_OPERATIONSReady = true; } return _CAPABILITY_SUPPORTS_TRANSACTIONAL_OPERATIONSContent; } }
        private static int _CAPABILITY_SUPPORTS_TRANSACTIONAL_OPERATIONSContent = default;
        private static bool _CAPABILITY_SUPPORTS_TRANSACTIONAL_OPERATIONSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#CAPABILITY_SUPPORTS_VIDEO_CALLING"/>
        /// </summary>
        public static int CAPABILITY_SUPPORTS_VIDEO_CALLING { get { if (!_CAPABILITY_SUPPORTS_VIDEO_CALLINGReady) { _CAPABILITY_SUPPORTS_VIDEO_CALLINGContent = SGetField<int>(LocalBridgeClazz, "CAPABILITY_SUPPORTS_VIDEO_CALLING"); _CAPABILITY_SUPPORTS_VIDEO_CALLINGReady = true; } return _CAPABILITY_SUPPORTS_VIDEO_CALLINGContent; } }
        private static int _CAPABILITY_SUPPORTS_VIDEO_CALLINGContent = default;
        private static bool _CAPABILITY_SUPPORTS_VIDEO_CALLINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#CAPABILITY_SUPPORTS_VOICE_CALLING_INDICATIONS"/>
        /// </summary>
        public static int CAPABILITY_SUPPORTS_VOICE_CALLING_INDICATIONS { get { if (!_CAPABILITY_SUPPORTS_VOICE_CALLING_INDICATIONSReady) { _CAPABILITY_SUPPORTS_VOICE_CALLING_INDICATIONSContent = SGetField<int>(LocalBridgeClazz, "CAPABILITY_SUPPORTS_VOICE_CALLING_INDICATIONS"); _CAPABILITY_SUPPORTS_VOICE_CALLING_INDICATIONSReady = true; } return _CAPABILITY_SUPPORTS_VOICE_CALLING_INDICATIONSContent; } }
        private static int _CAPABILITY_SUPPORTS_VOICE_CALLING_INDICATIONSContent = default;
        private static bool _CAPABILITY_SUPPORTS_VOICE_CALLING_INDICATIONSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#CAPABILITY_VIDEO_CALLING"/>
        /// </summary>
        public static int CAPABILITY_VIDEO_CALLING { get { if (!_CAPABILITY_VIDEO_CALLINGReady) { _CAPABILITY_VIDEO_CALLINGContent = SGetField<int>(LocalBridgeClazz, "CAPABILITY_VIDEO_CALLING"); _CAPABILITY_VIDEO_CALLINGReady = true; } return _CAPABILITY_VIDEO_CALLINGContent; } }
        private static int _CAPABILITY_VIDEO_CALLINGContent = default;
        private static bool _CAPABILITY_VIDEO_CALLINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#CAPABILITY_VIDEO_CALLING_RELIES_ON_PRESENCE"/>
        /// </summary>
        public static int CAPABILITY_VIDEO_CALLING_RELIES_ON_PRESENCE { get { if (!_CAPABILITY_VIDEO_CALLING_RELIES_ON_PRESENCEReady) { _CAPABILITY_VIDEO_CALLING_RELIES_ON_PRESENCEContent = SGetField<int>(LocalBridgeClazz, "CAPABILITY_VIDEO_CALLING_RELIES_ON_PRESENCE"); _CAPABILITY_VIDEO_CALLING_RELIES_ON_PRESENCEReady = true; } return _CAPABILITY_VIDEO_CALLING_RELIES_ON_PRESENCEContent; } }
        private static int _CAPABILITY_VIDEO_CALLING_RELIES_ON_PRESENCEContent = default;
        private static bool _CAPABILITY_VIDEO_CALLING_RELIES_ON_PRESENCEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#CAPABILITY_VOICE_CALLING_AVAILABLE"/>
        /// </summary>
        public static int CAPABILITY_VOICE_CALLING_AVAILABLE { get { if (!_CAPABILITY_VOICE_CALLING_AVAILABLEReady) { _CAPABILITY_VOICE_CALLING_AVAILABLEContent = SGetField<int>(LocalBridgeClazz, "CAPABILITY_VOICE_CALLING_AVAILABLE"); _CAPABILITY_VOICE_CALLING_AVAILABLEReady = true; } return _CAPABILITY_VOICE_CALLING_AVAILABLEContent; } }
        private static int _CAPABILITY_VOICE_CALLING_AVAILABLEContent = default;
        private static bool _CAPABILITY_VOICE_CALLING_AVAILABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#NO_HIGHLIGHT_COLOR"/>
        /// </summary>
        public static int NO_HIGHLIGHT_COLOR { get { if (!_NO_HIGHLIGHT_COLORReady) { _NO_HIGHLIGHT_COLORContent = SGetField<int>(LocalBridgeClazz, "NO_HIGHLIGHT_COLOR"); _NO_HIGHLIGHT_COLORReady = true; } return _NO_HIGHLIGHT_COLORContent; } }
        private static int _NO_HIGHLIGHT_COLORContent = default;
        private static bool _NO_HIGHLIGHT_COLORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#NO_RESOURCE_ID"/>
        /// </summary>
        public static int NO_RESOURCE_ID { get { if (!_NO_RESOURCE_IDReady) { _NO_RESOURCE_IDContent = SGetField<int>(LocalBridgeClazz, "NO_RESOURCE_ID"); _NO_RESOURCE_IDReady = true; } return _NO_RESOURCE_IDContent; } }
        private static int _NO_RESOURCE_IDContent = default;
        private static bool _NO_RESOURCE_IDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#EXTRA_ADD_SELF_MANAGED_CALLS_TO_INCALLSERVICE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_ADD_SELF_MANAGED_CALLS_TO_INCALLSERVICE { get { if (!_EXTRA_ADD_SELF_MANAGED_CALLS_TO_INCALLSERVICEReady) { _EXTRA_ADD_SELF_MANAGED_CALLS_TO_INCALLSERVICEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_ADD_SELF_MANAGED_CALLS_TO_INCALLSERVICE"); _EXTRA_ADD_SELF_MANAGED_CALLS_TO_INCALLSERVICEReady = true; } return _EXTRA_ADD_SELF_MANAGED_CALLS_TO_INCALLSERVICEContent; } }
        private static Java.Lang.String _EXTRA_ADD_SELF_MANAGED_CALLS_TO_INCALLSERVICEContent = default;
        private static bool _EXTRA_ADD_SELF_MANAGED_CALLS_TO_INCALLSERVICEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#EXTRA_ALWAYS_USE_VOIP_AUDIO_MODE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_ALWAYS_USE_VOIP_AUDIO_MODE { get { if (!_EXTRA_ALWAYS_USE_VOIP_AUDIO_MODEReady) { _EXTRA_ALWAYS_USE_VOIP_AUDIO_MODEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_ALWAYS_USE_VOIP_AUDIO_MODE"); _EXTRA_ALWAYS_USE_VOIP_AUDIO_MODEReady = true; } return _EXTRA_ALWAYS_USE_VOIP_AUDIO_MODEContent; } }
        private static Java.Lang.String _EXTRA_ALWAYS_USE_VOIP_AUDIO_MODEContent = default;
        private static bool _EXTRA_ALWAYS_USE_VOIP_AUDIO_MODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#EXTRA_CALL_SUBJECT_CHARACTER_ENCODING"/>
        /// </summary>
        public static Java.Lang.String EXTRA_CALL_SUBJECT_CHARACTER_ENCODING { get { if (!_EXTRA_CALL_SUBJECT_CHARACTER_ENCODINGReady) { _EXTRA_CALL_SUBJECT_CHARACTER_ENCODINGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_CALL_SUBJECT_CHARACTER_ENCODING"); _EXTRA_CALL_SUBJECT_CHARACTER_ENCODINGReady = true; } return _EXTRA_CALL_SUBJECT_CHARACTER_ENCODINGContent; } }
        private static Java.Lang.String _EXTRA_CALL_SUBJECT_CHARACTER_ENCODINGContent = default;
        private static bool _EXTRA_CALL_SUBJECT_CHARACTER_ENCODINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#EXTRA_CALL_SUBJECT_MAX_LENGTH"/>
        /// </summary>
        public static Java.Lang.String EXTRA_CALL_SUBJECT_MAX_LENGTH { get { if (!_EXTRA_CALL_SUBJECT_MAX_LENGTHReady) { _EXTRA_CALL_SUBJECT_MAX_LENGTHContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_CALL_SUBJECT_MAX_LENGTH"); _EXTRA_CALL_SUBJECT_MAX_LENGTHReady = true; } return _EXTRA_CALL_SUBJECT_MAX_LENGTHContent; } }
        private static Java.Lang.String _EXTRA_CALL_SUBJECT_MAX_LENGTHContent = default;
        private static bool _EXTRA_CALL_SUBJECT_MAX_LENGTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#EXTRA_LOG_SELF_MANAGED_CALLS"/>
        /// </summary>
        public static Java.Lang.String EXTRA_LOG_SELF_MANAGED_CALLS { get { if (!_EXTRA_LOG_SELF_MANAGED_CALLSReady) { _EXTRA_LOG_SELF_MANAGED_CALLSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_LOG_SELF_MANAGED_CALLS"); _EXTRA_LOG_SELF_MANAGED_CALLSReady = true; } return _EXTRA_LOG_SELF_MANAGED_CALLSContent; } }
        private static Java.Lang.String _EXTRA_LOG_SELF_MANAGED_CALLSContent = default;
        private static bool _EXTRA_LOG_SELF_MANAGED_CALLSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#EXTRA_SUPPORTS_HANDOVER_FROM"/>
        /// </summary>
        public static Java.Lang.String EXTRA_SUPPORTS_HANDOVER_FROM { get { if (!_EXTRA_SUPPORTS_HANDOVER_FROMReady) { _EXTRA_SUPPORTS_HANDOVER_FROMContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_SUPPORTS_HANDOVER_FROM"); _EXTRA_SUPPORTS_HANDOVER_FROMReady = true; } return _EXTRA_SUPPORTS_HANDOVER_FROMContent; } }
        private static Java.Lang.String _EXTRA_SUPPORTS_HANDOVER_FROMContent = default;
        private static bool _EXTRA_SUPPORTS_HANDOVER_FROMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#EXTRA_SUPPORTS_HANDOVER_TO"/>
        /// </summary>
        public static Java.Lang.String EXTRA_SUPPORTS_HANDOVER_TO { get { if (!_EXTRA_SUPPORTS_HANDOVER_TOReady) { _EXTRA_SUPPORTS_HANDOVER_TOContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_SUPPORTS_HANDOVER_TO"); _EXTRA_SUPPORTS_HANDOVER_TOReady = true; } return _EXTRA_SUPPORTS_HANDOVER_TOContent; } }
        private static Java.Lang.String _EXTRA_SUPPORTS_HANDOVER_TOContent = default;
        private static bool _EXTRA_SUPPORTS_HANDOVER_TOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#SCHEME_SIP"/>
        /// </summary>
        public static Java.Lang.String SCHEME_SIP { get { if (!_SCHEME_SIPReady) { _SCHEME_SIPContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SCHEME_SIP"); _SCHEME_SIPReady = true; } return _SCHEME_SIPContent; } }
        private static Java.Lang.String _SCHEME_SIPContent = default;
        private static bool _SCHEME_SIPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#SCHEME_TEL"/>
        /// </summary>
        public static Java.Lang.String SCHEME_TEL { get { if (!_SCHEME_TELReady) { _SCHEME_TELContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SCHEME_TEL"); _SCHEME_TELReady = true; } return _SCHEME_TELContent; } }
        private static Java.Lang.String _SCHEME_TELContent = default;
        private static bool _SCHEME_TELReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#SCHEME_VOICEMAIL"/>
        /// </summary>
        public static Java.Lang.String SCHEME_VOICEMAIL { get { if (!_SCHEME_VOICEMAILReady) { _SCHEME_VOICEMAILContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SCHEME_VOICEMAIL"); _SCHEME_VOICEMAILReady = true; } return _SCHEME_VOICEMAILContent; } }
        private static Java.Lang.String _SCHEME_VOICEMAILContent = default;
        private static bool _SCHEME_VOICEMAILReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#builder(android.telecom.PhoneAccountHandle,java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.PhoneAccountHandle"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Android.Telecom.PhoneAccount.Builder"/></returns>
        public static Android.Telecom.PhoneAccount.Builder BuilderMethod(Android.Telecom.PhoneAccountHandle arg0, Java.Lang.CharSequence arg1)
        {
            return SExecute<Android.Telecom.PhoneAccount.Builder>(LocalBridgeClazz, "builder", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#getAccountHandle()"/> 
        /// </summary>
        public Android.Telecom.PhoneAccountHandle AccountHandle
        {
            get { return IExecuteWithSignature<Android.Telecom.PhoneAccountHandle>("getAccountHandle", "()Landroid/telecom/PhoneAccountHandle;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#getAddress()"/> 
        /// </summary>
        public Android.Net.Uri Address
        {
            get { return IExecuteWithSignature<Android.Net.Uri>("getAddress", "()Landroid/net/Uri;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#getCapabilities()"/> 
        /// </summary>
        public int Capabilities
        {
            get { return IExecuteWithSignature<int>("getCapabilities", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#getExtras()"/> 
        /// </summary>
        public Android.Os.Bundle Extras
        {
            get { return IExecuteWithSignature<Android.Os.Bundle>("getExtras", "()Landroid/os/Bundle;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#getHighlightColor()"/> 
        /// </summary>
        public int HighlightColor
        {
            get { return IExecuteWithSignature<int>("getHighlightColor", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#getIcon()"/> 
        /// </summary>
        public Android.Graphics.Drawable.Icon Icon
        {
            get { return IExecuteWithSignature<Android.Graphics.Drawable.Icon>("getIcon", "()Landroid/graphics/drawable/Icon;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#getLabel()"/> 
        /// </summary>
        public Java.Lang.CharSequence Label
        {
            get { return IExecuteWithSignature<Java.Lang.CharSequence>("getLabel", "()Ljava/lang/CharSequence;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#getShortDescription()"/> 
        /// </summary>
        public Java.Lang.CharSequence ShortDescription
        {
            get { return IExecuteWithSignature<Java.Lang.CharSequence>("getShortDescription", "()Ljava/lang/CharSequence;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#getSubscriptionAddress()"/> 
        /// </summary>
        public Android.Net.Uri SubscriptionAddress
        {
            get { return IExecuteWithSignature<Android.Net.Uri>("getSubscriptionAddress", "()Landroid/net/Uri;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#getSupportedUriSchemes()"/> 
        /// </summary>
        public Java.Util.List<Java.Lang.String> SupportedUriSchemes
        {
            get { return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("getSupportedUriSchemes", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#toBuilder()"/>
        /// </summary>
        /// <returns><see cref="Android.Telecom.PhoneAccount.Builder"/></returns>
        public Android.Telecom.PhoneAccount.Builder ToBuilder()
        {
            return IExecuteWithSignature<Android.Telecom.PhoneAccount.Builder>("toBuilder", "()Landroid/telecom/PhoneAccount$Builder;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#hasCapabilities(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasCapabilities(int arg0)
        {
            return IExecuteWithSignature<bool>("hasCapabilities", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#isEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEnabled()
        {
            return IExecuteWithSignature<bool>("isEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#supportsUriScheme(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SupportsUriScheme(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("supportsUriScheme", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.Builder.html#%3Cinit%3E(android.telecom.PhoneAccount)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.PhoneAccount"/></param>
            public Builder(Android.Telecom.PhoneAccount arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.Builder.html#%3Cinit%3E(android.telecom.PhoneAccountHandle,java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.PhoneAccountHandle"/></param>
            /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
            public Builder(Android.Telecom.PhoneAccountHandle arg0, Java.Lang.CharSequence arg1)
                : base(arg0, arg1)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Telecom.PhoneAccount"/></returns>
            public Android.Telecom.PhoneAccount Build()
            {
                return IExecuteWithSignature<Android.Telecom.PhoneAccount>("build", "()Landroid/telecom/PhoneAccount;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.Builder.html#addSupportedUriScheme(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Telecom.PhoneAccount.Builder"/></returns>
            public Android.Telecom.PhoneAccount.Builder AddSupportedUriScheme(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Telecom.PhoneAccount.Builder>("addSupportedUriScheme", "(Ljava/lang/String;)Landroid/telecom/PhoneAccount$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.Builder.html#setAddress(android.net.Uri)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
            /// <returns><see cref="Android.Telecom.PhoneAccount.Builder"/></returns>
            public Android.Telecom.PhoneAccount.Builder SetAddress(Android.Net.Uri arg0)
            {
                return IExecuteWithSignature<Android.Telecom.PhoneAccount.Builder>("setAddress", "(Landroid/net/Uri;)Landroid/telecom/PhoneAccount$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.Builder.html#setCapabilities(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Telecom.PhoneAccount.Builder"/></returns>
            public Android.Telecom.PhoneAccount.Builder SetCapabilities(int arg0)
            {
                return IExecuteWithSignature<Android.Telecom.PhoneAccount.Builder>("setCapabilities", "(I)Landroid/telecom/PhoneAccount$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.Builder.html#setExtras(android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
            /// <returns><see cref="Android.Telecom.PhoneAccount.Builder"/></returns>
            public Android.Telecom.PhoneAccount.Builder SetExtras(Android.Os.Bundle arg0)
            {
                return IExecuteWithSignature<Android.Telecom.PhoneAccount.Builder>("setExtras", "(Landroid/os/Bundle;)Landroid/telecom/PhoneAccount$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.Builder.html#setHighlightColor(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Telecom.PhoneAccount.Builder"/></returns>
            public Android.Telecom.PhoneAccount.Builder SetHighlightColor(int arg0)
            {
                return IExecuteWithSignature<Android.Telecom.PhoneAccount.Builder>("setHighlightColor", "(I)Landroid/telecom/PhoneAccount$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.Builder.html#setIcon(android.graphics.drawable.Icon)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Drawable.Icon"/></param>
            /// <returns><see cref="Android.Telecom.PhoneAccount.Builder"/></returns>
            public Android.Telecom.PhoneAccount.Builder SetIcon(Android.Graphics.Drawable.Icon arg0)
            {
                return IExecuteWithSignature<Android.Telecom.PhoneAccount.Builder>("setIcon", "(Landroid/graphics/drawable/Icon;)Landroid/telecom/PhoneAccount$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.Builder.html#setShortDescription(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.Telecom.PhoneAccount.Builder"/></returns>
            public Android.Telecom.PhoneAccount.Builder SetShortDescription(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<Android.Telecom.PhoneAccount.Builder>("setShortDescription", "(Ljava/lang/CharSequence;)Landroid/telecom/PhoneAccount$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.Builder.html#setSubscriptionAddress(android.net.Uri)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
            /// <returns><see cref="Android.Telecom.PhoneAccount.Builder"/></returns>
            public Android.Telecom.PhoneAccount.Builder SetSubscriptionAddress(Android.Net.Uri arg0)
            {
                return IExecuteWithSignature<Android.Telecom.PhoneAccount.Builder>("setSubscriptionAddress", "(Landroid/net/Uri;)Landroid/telecom/PhoneAccount$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccount.Builder.html#setSupportedUriSchemes(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.Telecom.PhoneAccount.Builder"/></returns>
            public Android.Telecom.PhoneAccount.Builder SetSupportedUriSchemes(Java.Util.List<Java.Lang.String> arg0)
            {
                return IExecuteWithSignature<Android.Telecom.PhoneAccount.Builder>("setSupportedUriSchemes", "(Ljava/util/List;)Landroid/telecom/PhoneAccount$Builder;", arg0);
            }

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