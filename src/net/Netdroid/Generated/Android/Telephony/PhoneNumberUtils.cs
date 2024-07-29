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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Telephony
{
    #region PhoneNumberUtils
    public partial class PhoneNumberUtils
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#PAUSE"/>
        /// </summary>
        public static char PAUSE { get { if (!_PAUSEReady) { _PAUSEContent = SGetField<char>(LocalBridgeClazz, "PAUSE"); _PAUSEReady = true; } return _PAUSEContent; } }
        private static char _PAUSEContent = default;
        private static bool _PAUSEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#WAIT"/>
        /// </summary>
        public static char WAIT { get { if (!_WAITReady) { _WAITContent = SGetField<char>(LocalBridgeClazz, "WAIT"); _WAITReady = true; } return _WAITContent; } }
        private static char _WAITContent = default;
        private static bool _WAITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#WILD"/>
        /// </summary>
        public static char WILD { get { if (!_WILDReady) { _WILDContent = SGetField<char>(LocalBridgeClazz, "WILD"); _WILDReady = true; } return _WILDContent; } }
        private static char _WILDContent = default;
        private static bool _WILDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#BCD_EXTENDED_TYPE_CALLED_PARTY"/>
        /// </summary>
        public static int BCD_EXTENDED_TYPE_CALLED_PARTY { get { if (!_BCD_EXTENDED_TYPE_CALLED_PARTYReady) { _BCD_EXTENDED_TYPE_CALLED_PARTYContent = SGetField<int>(LocalBridgeClazz, "BCD_EXTENDED_TYPE_CALLED_PARTY"); _BCD_EXTENDED_TYPE_CALLED_PARTYReady = true; } return _BCD_EXTENDED_TYPE_CALLED_PARTYContent; } }
        private static int _BCD_EXTENDED_TYPE_CALLED_PARTYContent = default;
        private static bool _BCD_EXTENDED_TYPE_CALLED_PARTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#BCD_EXTENDED_TYPE_EF_ADN"/>
        /// </summary>
        public static int BCD_EXTENDED_TYPE_EF_ADN { get { if (!_BCD_EXTENDED_TYPE_EF_ADNReady) { _BCD_EXTENDED_TYPE_EF_ADNContent = SGetField<int>(LocalBridgeClazz, "BCD_EXTENDED_TYPE_EF_ADN"); _BCD_EXTENDED_TYPE_EF_ADNReady = true; } return _BCD_EXTENDED_TYPE_EF_ADNContent; } }
        private static int _BCD_EXTENDED_TYPE_EF_ADNContent = default;
        private static bool _BCD_EXTENDED_TYPE_EF_ADNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#FORMAT_JAPAN"/>
        /// </summary>
        public static int FORMAT_JAPAN { get { if (!_FORMAT_JAPANReady) { _FORMAT_JAPANContent = SGetField<int>(LocalBridgeClazz, "FORMAT_JAPAN"); _FORMAT_JAPANReady = true; } return _FORMAT_JAPANContent; } }
        private static int _FORMAT_JAPANContent = default;
        private static bool _FORMAT_JAPANReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#FORMAT_NANP"/>
        /// </summary>
        public static int FORMAT_NANP { get { if (!_FORMAT_NANPReady) { _FORMAT_NANPContent = SGetField<int>(LocalBridgeClazz, "FORMAT_NANP"); _FORMAT_NANPReady = true; } return _FORMAT_NANPContent; } }
        private static int _FORMAT_NANPContent = default;
        private static bool _FORMAT_NANPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#FORMAT_UNKNOWN"/>
        /// </summary>
        public static int FORMAT_UNKNOWN { get { if (!_FORMAT_UNKNOWNReady) { _FORMAT_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "FORMAT_UNKNOWN"); _FORMAT_UNKNOWNReady = true; } return _FORMAT_UNKNOWNContent; } }
        private static int _FORMAT_UNKNOWNContent = default;
        private static bool _FORMAT_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#TOA_International"/>
        /// </summary>
        public static int TOA_International { get { if (!_TOA_InternationalReady) { _TOA_InternationalContent = SGetField<int>(LocalBridgeClazz, "TOA_International"); _TOA_InternationalReady = true; } return _TOA_InternationalContent; } }
        private static int _TOA_InternationalContent = default;
        private static bool _TOA_InternationalReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#TOA_Unknown"/>
        /// </summary>
        public static int TOA_Unknown { get { if (!_TOA_UnknownReady) { _TOA_UnknownContent = SGetField<int>(LocalBridgeClazz, "TOA_Unknown"); _TOA_UnknownReady = true; } return _TOA_UnknownContent; } }
        private static int _TOA_UnknownContent = default;
        private static bool _TOA_UnknownReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#createTtsSpan(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Text.Style.TtsSpan"/></returns>
        public static Android.Text.Style.TtsSpan CreateTtsSpan(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Android.Text.Style.TtsSpan>(LocalBridgeClazz, "createTtsSpan", "(Ljava/lang/String;)Landroid/text/style/TtsSpan;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#areSamePhoneNumber(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool AreSamePhoneNumber(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            return SExecute<bool>(LocalBridgeClazz, "areSamePhoneNumber", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#compare(android.content.Context,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public static bool Compare(Android.Content.Context arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            return SExecute<bool>(LocalBridgeClazz, "compare", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#compare(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public static bool Compare(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "compare", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#isEmergencyNumber(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public static bool IsEmergencyNumber(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isEmergencyNumber", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#isGlobalPhoneNumber(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsGlobalPhoneNumber(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isGlobalPhoneNumber", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#isISODigit(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsISODigit(char arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isISODigit", "(C)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#isLocalEmergencyNumber(android.content.Context,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public static bool IsLocalEmergencyNumber(Android.Content.Context arg0, Java.Lang.String arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "isLocalEmergencyNumber", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#isVoiceMailNumber(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsVoiceMailNumber(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isVoiceMailNumber", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#isWellFormedSmsAddress(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsWellFormedSmsAddress(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isWellFormedSmsAddress", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#isWpsCallNumber(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsWpsCallNumber(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isWpsCallNumber", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#networkPortionToCalledPartyBCD(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="byte"/></returns>
        public static byte[] NetworkPortionToCalledPartyBCD(Java.Lang.String arg0)
        {
            return SExecuteWithSignatureArray<byte>(LocalBridgeClazz, "networkPortionToCalledPartyBCD", "(Ljava/lang/String;)[B", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#networkPortionToCalledPartyBCDWithLength(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="byte"/></returns>
        public static byte[] NetworkPortionToCalledPartyBCDWithLength(Java.Lang.String arg0)
        {
            return SExecuteWithSignatureArray<byte>(LocalBridgeClazz, "networkPortionToCalledPartyBCDWithLength", "(Ljava/lang/String;)[B", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#numberToCalledPartyBCD(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        public static byte[] NumberToCalledPartyBCD(Java.Lang.String arg0, int arg1)
        {
            return SExecuteArray<byte>(LocalBridgeClazz, "numberToCalledPartyBCD", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#numberToCalledPartyBCD(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="byte"/></returns>
        [global::System.Obsolete()]
        public static byte[] NumberToCalledPartyBCD(Java.Lang.String arg0)
        {
            return SExecuteWithSignatureArray<byte>(LocalBridgeClazz, "numberToCalledPartyBCD", "(Ljava/lang/String;)[B", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#is12Key(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool Is12Key(char arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "is12Key", "(C)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#isDialable(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsDialable(char arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isDialable", "(C)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#isNonSeparator(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsNonSeparator(char arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isNonSeparator", "(C)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#isReallyDialable(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsReallyDialable(char arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isReallyDialable", "(C)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#isStartsPostDial(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsStartsPostDial(char arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isStartsPostDial", "(C)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#getFormatTypeForLocale(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public static int GetFormatTypeForLocale(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getFormatTypeForLocale", "(Ljava/util/Locale;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#toaFromString(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public static int ToaFromString(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "toaFromString", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#createTtsSpannable(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public static Java.Lang.CharSequence CreateTtsSpannable(Java.Lang.CharSequence arg0)
        {
            return SExecuteWithSignature<Java.Lang.CharSequence>(LocalBridgeClazz, "createTtsSpannable", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#calledPartyBCDFragmentToString(byte[],int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String CalledPartyBCDFragmentToString(byte[] arg0, int arg1, int arg2, int arg3)
        {
            return SExecute<Java.Lang.String>(LocalBridgeClazz, "calledPartyBCDFragmentToString", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#calledPartyBCDFragmentToString(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public static Java.Lang.String CalledPartyBCDFragmentToString(byte[] arg0, int arg1, int arg2)
        {
            return SExecute<Java.Lang.String>(LocalBridgeClazz, "calledPartyBCDFragmentToString", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#calledPartyBCDToString(byte[],int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String CalledPartyBCDToString(byte[] arg0, int arg1, int arg2, int arg3)
        {
            return SExecute<Java.Lang.String>(LocalBridgeClazz, "calledPartyBCDToString", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#calledPartyBCDToString(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public static Java.Lang.String CalledPartyBCDToString(byte[] arg0, int arg1, int arg2)
        {
            return SExecute<Java.Lang.String>(LocalBridgeClazz, "calledPartyBCDToString", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#convertKeypadLettersToDigits(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ConvertKeypadLettersToDigits(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "convertKeypadLettersToDigits", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#extractNetworkPortion(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ExtractNetworkPortion(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "extractNetworkPortion", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#extractPostDialPortion(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ExtractPostDialPortion(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "extractPostDialPortion", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#formatNumber(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String FormatNumber(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            return SExecute<Java.Lang.String>(LocalBridgeClazz, "formatNumber", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#formatNumber(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String FormatNumber(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecute<Java.Lang.String>(LocalBridgeClazz, "formatNumber", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#formatNumber(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public static Java.Lang.String FormatNumber(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "formatNumber", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#formatNumberToE164(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String FormatNumberToE164(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecute<Java.Lang.String>(LocalBridgeClazz, "formatNumberToE164", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#formatNumberToRFC3966(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String FormatNumberToRFC3966(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecute<Java.Lang.String>(LocalBridgeClazz, "formatNumberToRFC3966", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#getNumberFromIntent(android.content.Intent,android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        /// <param name="arg1"><see cref="Android.Content.Context"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetNumberFromIntent(Android.Content.Intent arg0, Android.Content.Context arg1)
        {
            return SExecute<Java.Lang.String>(LocalBridgeClazz, "getNumberFromIntent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#getStrippedReversed(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetStrippedReversed(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getStrippedReversed", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#normalizeNumber(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String NormalizeNumber(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "normalizeNumber", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#replaceUnicodeDigits(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ReplaceUnicodeDigits(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "replaceUnicodeDigits", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#stringFromStringAndTOA(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String StringFromStringAndTOA(Java.Lang.String arg0, int arg1)
        {
            return SExecute<Java.Lang.String>(LocalBridgeClazz, "stringFromStringAndTOA", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#stripSeparators(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String StripSeparators(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "stripSeparators", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#toCallerIDMinMatch(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ToCallerIDMinMatch(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "toCallerIDMinMatch", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#addTtsSpan(android.text.Spannable,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Spannable"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public static void AddTtsSpan(Android.Text.Spannable arg0, int arg1, int arg2)
        {
            SExecute(LocalBridgeClazz, "addTtsSpan", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#formatJapaneseNumber(android.text.Editable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Editable"/></param>
        [global::System.Obsolete()]
        public static void FormatJapaneseNumber(Android.Text.Editable arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "formatJapaneseNumber", "(Landroid/text/Editable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#formatNanpNumber(android.text.Editable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Editable"/></param>
        [global::System.Obsolete()]
        public static void FormatNanpNumber(Android.Text.Editable arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "formatNanpNumber", "(Landroid/text/Editable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/PhoneNumberUtils.html#formatNumber(android.text.Editable,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Editable"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        [global::System.Obsolete()]
        public static void FormatNumber(Android.Text.Editable arg0, int arg1)
        {
            SExecute(LocalBridgeClazz, "formatNumber", arg0, arg1);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}