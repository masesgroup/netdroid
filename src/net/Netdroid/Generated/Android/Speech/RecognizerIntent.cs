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

namespace Android.Speech
{
    #region RecognizerIntent
    public partial class RecognizerIntent
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#RESULT_AUDIO_ERROR"/>
        /// </summary>
        public static int RESULT_AUDIO_ERROR { get { if (!_RESULT_AUDIO_ERRORReady) { _RESULT_AUDIO_ERRORContent = SGetField<int>(LocalBridgeClazz, "RESULT_AUDIO_ERROR"); _RESULT_AUDIO_ERRORReady = true; } return _RESULT_AUDIO_ERRORContent; } }
        private static int _RESULT_AUDIO_ERRORContent = default;
        private static bool _RESULT_AUDIO_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#RESULT_CLIENT_ERROR"/>
        /// </summary>
        public static int RESULT_CLIENT_ERROR { get { if (!_RESULT_CLIENT_ERRORReady) { _RESULT_CLIENT_ERRORContent = SGetField<int>(LocalBridgeClazz, "RESULT_CLIENT_ERROR"); _RESULT_CLIENT_ERRORReady = true; } return _RESULT_CLIENT_ERRORContent; } }
        private static int _RESULT_CLIENT_ERRORContent = default;
        private static bool _RESULT_CLIENT_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#RESULT_NETWORK_ERROR"/>
        /// </summary>
        public static int RESULT_NETWORK_ERROR { get { if (!_RESULT_NETWORK_ERRORReady) { _RESULT_NETWORK_ERRORContent = SGetField<int>(LocalBridgeClazz, "RESULT_NETWORK_ERROR"); _RESULT_NETWORK_ERRORReady = true; } return _RESULT_NETWORK_ERRORContent; } }
        private static int _RESULT_NETWORK_ERRORContent = default;
        private static bool _RESULT_NETWORK_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#RESULT_NO_MATCH"/>
        /// </summary>
        public static int RESULT_NO_MATCH { get { if (!_RESULT_NO_MATCHReady) { _RESULT_NO_MATCHContent = SGetField<int>(LocalBridgeClazz, "RESULT_NO_MATCH"); _RESULT_NO_MATCHReady = true; } return _RESULT_NO_MATCHContent; } }
        private static int _RESULT_NO_MATCHContent = default;
        private static bool _RESULT_NO_MATCHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#RESULT_SERVER_ERROR"/>
        /// </summary>
        public static int RESULT_SERVER_ERROR { get { if (!_RESULT_SERVER_ERRORReady) { _RESULT_SERVER_ERRORContent = SGetField<int>(LocalBridgeClazz, "RESULT_SERVER_ERROR"); _RESULT_SERVER_ERRORReady = true; } return _RESULT_SERVER_ERRORContent; } }
        private static int _RESULT_SERVER_ERRORContent = default;
        private static bool _RESULT_SERVER_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#ACTION_GET_LANGUAGE_DETAILS"/>
        /// </summary>
        public static Java.Lang.String ACTION_GET_LANGUAGE_DETAILS { get { if (!_ACTION_GET_LANGUAGE_DETAILSReady) { _ACTION_GET_LANGUAGE_DETAILSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_GET_LANGUAGE_DETAILS"); _ACTION_GET_LANGUAGE_DETAILSReady = true; } return _ACTION_GET_LANGUAGE_DETAILSContent; } }
        private static Java.Lang.String _ACTION_GET_LANGUAGE_DETAILSContent = default;
        private static bool _ACTION_GET_LANGUAGE_DETAILSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#ACTION_RECOGNIZE_SPEECH"/>
        /// </summary>
        public static Java.Lang.String ACTION_RECOGNIZE_SPEECH { get { if (!_ACTION_RECOGNIZE_SPEECHReady) { _ACTION_RECOGNIZE_SPEECHContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_RECOGNIZE_SPEECH"); _ACTION_RECOGNIZE_SPEECHReady = true; } return _ACTION_RECOGNIZE_SPEECHContent; } }
        private static Java.Lang.String _ACTION_RECOGNIZE_SPEECHContent = default;
        private static bool _ACTION_RECOGNIZE_SPEECHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#ACTION_VOICE_SEARCH_HANDS_FREE"/>
        /// </summary>
        public static Java.Lang.String ACTION_VOICE_SEARCH_HANDS_FREE { get { if (!_ACTION_VOICE_SEARCH_HANDS_FREEReady) { _ACTION_VOICE_SEARCH_HANDS_FREEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_VOICE_SEARCH_HANDS_FREE"); _ACTION_VOICE_SEARCH_HANDS_FREEReady = true; } return _ACTION_VOICE_SEARCH_HANDS_FREEContent; } }
        private static Java.Lang.String _ACTION_VOICE_SEARCH_HANDS_FREEContent = default;
        private static bool _ACTION_VOICE_SEARCH_HANDS_FREEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#ACTION_WEB_SEARCH"/>
        /// </summary>
        public static Java.Lang.String ACTION_WEB_SEARCH { get { if (!_ACTION_WEB_SEARCHReady) { _ACTION_WEB_SEARCHContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_WEB_SEARCH"); _ACTION_WEB_SEARCHReady = true; } return _ACTION_WEB_SEARCHContent; } }
        private static Java.Lang.String _ACTION_WEB_SEARCHContent = default;
        private static bool _ACTION_WEB_SEARCHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#DETAILS_META_DATA"/>
        /// </summary>
        public static Java.Lang.String DETAILS_META_DATA { get { if (!_DETAILS_META_DATAReady) { _DETAILS_META_DATAContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DETAILS_META_DATA"); _DETAILS_META_DATAReady = true; } return _DETAILS_META_DATAContent; } }
        private static Java.Lang.String _DETAILS_META_DATAContent = default;
        private static bool _DETAILS_META_DATAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_AUDIO_INJECT_SOURCE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String EXTRA_AUDIO_INJECT_SOURCE { get { if (!_EXTRA_AUDIO_INJECT_SOURCEReady) { _EXTRA_AUDIO_INJECT_SOURCEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_AUDIO_INJECT_SOURCE"); _EXTRA_AUDIO_INJECT_SOURCEReady = true; } return _EXTRA_AUDIO_INJECT_SOURCEContent; } }
        private static Java.Lang.String _EXTRA_AUDIO_INJECT_SOURCEContent = default;
        private static bool _EXTRA_AUDIO_INJECT_SOURCEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_AUDIO_SOURCE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_AUDIO_SOURCE { get { if (!_EXTRA_AUDIO_SOURCEReady) { _EXTRA_AUDIO_SOURCEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_AUDIO_SOURCE"); _EXTRA_AUDIO_SOURCEReady = true; } return _EXTRA_AUDIO_SOURCEContent; } }
        private static Java.Lang.String _EXTRA_AUDIO_SOURCEContent = default;
        private static bool _EXTRA_AUDIO_SOURCEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_AUDIO_SOURCE_CHANNEL_COUNT"/>
        /// </summary>
        public static Java.Lang.String EXTRA_AUDIO_SOURCE_CHANNEL_COUNT { get { if (!_EXTRA_AUDIO_SOURCE_CHANNEL_COUNTReady) { _EXTRA_AUDIO_SOURCE_CHANNEL_COUNTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_AUDIO_SOURCE_CHANNEL_COUNT"); _EXTRA_AUDIO_SOURCE_CHANNEL_COUNTReady = true; } return _EXTRA_AUDIO_SOURCE_CHANNEL_COUNTContent; } }
        private static Java.Lang.String _EXTRA_AUDIO_SOURCE_CHANNEL_COUNTContent = default;
        private static bool _EXTRA_AUDIO_SOURCE_CHANNEL_COUNTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_AUDIO_SOURCE_ENCODING"/>
        /// </summary>
        public static Java.Lang.String EXTRA_AUDIO_SOURCE_ENCODING { get { if (!_EXTRA_AUDIO_SOURCE_ENCODINGReady) { _EXTRA_AUDIO_SOURCE_ENCODINGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_AUDIO_SOURCE_ENCODING"); _EXTRA_AUDIO_SOURCE_ENCODINGReady = true; } return _EXTRA_AUDIO_SOURCE_ENCODINGContent; } }
        private static Java.Lang.String _EXTRA_AUDIO_SOURCE_ENCODINGContent = default;
        private static bool _EXTRA_AUDIO_SOURCE_ENCODINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_AUDIO_SOURCE_SAMPLING_RATE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_AUDIO_SOURCE_SAMPLING_RATE { get { if (!_EXTRA_AUDIO_SOURCE_SAMPLING_RATEReady) { _EXTRA_AUDIO_SOURCE_SAMPLING_RATEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_AUDIO_SOURCE_SAMPLING_RATE"); _EXTRA_AUDIO_SOURCE_SAMPLING_RATEReady = true; } return _EXTRA_AUDIO_SOURCE_SAMPLING_RATEContent; } }
        private static Java.Lang.String _EXTRA_AUDIO_SOURCE_SAMPLING_RATEContent = default;
        private static bool _EXTRA_AUDIO_SOURCE_SAMPLING_RATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_BIASING_STRINGS"/>
        /// </summary>
        public static Java.Lang.String EXTRA_BIASING_STRINGS { get { if (!_EXTRA_BIASING_STRINGSReady) { _EXTRA_BIASING_STRINGSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_BIASING_STRINGS"); _EXTRA_BIASING_STRINGSReady = true; } return _EXTRA_BIASING_STRINGSContent; } }
        private static Java.Lang.String _EXTRA_BIASING_STRINGSContent = default;
        private static bool _EXTRA_BIASING_STRINGSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_CALLING_PACKAGE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_CALLING_PACKAGE { get { if (!_EXTRA_CALLING_PACKAGEReady) { _EXTRA_CALLING_PACKAGEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_CALLING_PACKAGE"); _EXTRA_CALLING_PACKAGEReady = true; } return _EXTRA_CALLING_PACKAGEContent; } }
        private static Java.Lang.String _EXTRA_CALLING_PACKAGEContent = default;
        private static bool _EXTRA_CALLING_PACKAGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_CONFIDENCE_SCORES"/>
        /// </summary>
        public static Java.Lang.String EXTRA_CONFIDENCE_SCORES { get { if (!_EXTRA_CONFIDENCE_SCORESReady) { _EXTRA_CONFIDENCE_SCORESContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_CONFIDENCE_SCORES"); _EXTRA_CONFIDENCE_SCORESReady = true; } return _EXTRA_CONFIDENCE_SCORESContent; } }
        private static Java.Lang.String _EXTRA_CONFIDENCE_SCORESContent = default;
        private static bool _EXTRA_CONFIDENCE_SCORESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_ENABLE_BIASING_DEVICE_CONTEXT"/>
        /// </summary>
        public static Java.Lang.String EXTRA_ENABLE_BIASING_DEVICE_CONTEXT { get { if (!_EXTRA_ENABLE_BIASING_DEVICE_CONTEXTReady) { _EXTRA_ENABLE_BIASING_DEVICE_CONTEXTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_ENABLE_BIASING_DEVICE_CONTEXT"); _EXTRA_ENABLE_BIASING_DEVICE_CONTEXTReady = true; } return _EXTRA_ENABLE_BIASING_DEVICE_CONTEXTContent; } }
        private static Java.Lang.String _EXTRA_ENABLE_BIASING_DEVICE_CONTEXTContent = default;
        private static bool _EXTRA_ENABLE_BIASING_DEVICE_CONTEXTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_ENABLE_FORMATTING"/>
        /// </summary>
        public static Java.Lang.String EXTRA_ENABLE_FORMATTING { get { if (!_EXTRA_ENABLE_FORMATTINGReady) { _EXTRA_ENABLE_FORMATTINGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_ENABLE_FORMATTING"); _EXTRA_ENABLE_FORMATTINGReady = true; } return _EXTRA_ENABLE_FORMATTINGContent; } }
        private static Java.Lang.String _EXTRA_ENABLE_FORMATTINGContent = default;
        private static bool _EXTRA_ENABLE_FORMATTINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_ENABLE_LANGUAGE_DETECTION"/>
        /// </summary>
        public static Java.Lang.String EXTRA_ENABLE_LANGUAGE_DETECTION { get { if (!_EXTRA_ENABLE_LANGUAGE_DETECTIONReady) { _EXTRA_ENABLE_LANGUAGE_DETECTIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_ENABLE_LANGUAGE_DETECTION"); _EXTRA_ENABLE_LANGUAGE_DETECTIONReady = true; } return _EXTRA_ENABLE_LANGUAGE_DETECTIONContent; } }
        private static Java.Lang.String _EXTRA_ENABLE_LANGUAGE_DETECTIONContent = default;
        private static bool _EXTRA_ENABLE_LANGUAGE_DETECTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_ENABLE_LANGUAGE_SWITCH"/>
        /// </summary>
        public static Java.Lang.String EXTRA_ENABLE_LANGUAGE_SWITCH { get { if (!_EXTRA_ENABLE_LANGUAGE_SWITCHReady) { _EXTRA_ENABLE_LANGUAGE_SWITCHContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_ENABLE_LANGUAGE_SWITCH"); _EXTRA_ENABLE_LANGUAGE_SWITCHReady = true; } return _EXTRA_ENABLE_LANGUAGE_SWITCHContent; } }
        private static Java.Lang.String _EXTRA_ENABLE_LANGUAGE_SWITCHContent = default;
        private static bool _EXTRA_ENABLE_LANGUAGE_SWITCHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_HIDE_PARTIAL_TRAILING_PUNCTUATION"/>
        /// </summary>
        public static Java.Lang.String EXTRA_HIDE_PARTIAL_TRAILING_PUNCTUATION { get { if (!_EXTRA_HIDE_PARTIAL_TRAILING_PUNCTUATIONReady) { _EXTRA_HIDE_PARTIAL_TRAILING_PUNCTUATIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_HIDE_PARTIAL_TRAILING_PUNCTUATION"); _EXTRA_HIDE_PARTIAL_TRAILING_PUNCTUATIONReady = true; } return _EXTRA_HIDE_PARTIAL_TRAILING_PUNCTUATIONContent; } }
        private static Java.Lang.String _EXTRA_HIDE_PARTIAL_TRAILING_PUNCTUATIONContent = default;
        private static bool _EXTRA_HIDE_PARTIAL_TRAILING_PUNCTUATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_LANGUAGE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_LANGUAGE { get { if (!_EXTRA_LANGUAGEReady) { _EXTRA_LANGUAGEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_LANGUAGE"); _EXTRA_LANGUAGEReady = true; } return _EXTRA_LANGUAGEContent; } }
        private static Java.Lang.String _EXTRA_LANGUAGEContent = default;
        private static bool _EXTRA_LANGUAGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_LANGUAGE_DETECTION_ALLOWED_LANGUAGES"/>
        /// </summary>
        public static Java.Lang.String EXTRA_LANGUAGE_DETECTION_ALLOWED_LANGUAGES { get { if (!_EXTRA_LANGUAGE_DETECTION_ALLOWED_LANGUAGESReady) { _EXTRA_LANGUAGE_DETECTION_ALLOWED_LANGUAGESContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_LANGUAGE_DETECTION_ALLOWED_LANGUAGES"); _EXTRA_LANGUAGE_DETECTION_ALLOWED_LANGUAGESReady = true; } return _EXTRA_LANGUAGE_DETECTION_ALLOWED_LANGUAGESContent; } }
        private static Java.Lang.String _EXTRA_LANGUAGE_DETECTION_ALLOWED_LANGUAGESContent = default;
        private static bool _EXTRA_LANGUAGE_DETECTION_ALLOWED_LANGUAGESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_LANGUAGE_MODEL"/>
        /// </summary>
        public static Java.Lang.String EXTRA_LANGUAGE_MODEL { get { if (!_EXTRA_LANGUAGE_MODELReady) { _EXTRA_LANGUAGE_MODELContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_LANGUAGE_MODEL"); _EXTRA_LANGUAGE_MODELReady = true; } return _EXTRA_LANGUAGE_MODELContent; } }
        private static Java.Lang.String _EXTRA_LANGUAGE_MODELContent = default;
        private static bool _EXTRA_LANGUAGE_MODELReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_LANGUAGE_PREFERENCE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_LANGUAGE_PREFERENCE { get { if (!_EXTRA_LANGUAGE_PREFERENCEReady) { _EXTRA_LANGUAGE_PREFERENCEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_LANGUAGE_PREFERENCE"); _EXTRA_LANGUAGE_PREFERENCEReady = true; } return _EXTRA_LANGUAGE_PREFERENCEContent; } }
        private static Java.Lang.String _EXTRA_LANGUAGE_PREFERENCEContent = default;
        private static bool _EXTRA_LANGUAGE_PREFERENCEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_LANGUAGE_SWITCH_ALLOWED_LANGUAGES"/>
        /// </summary>
        public static Java.Lang.String EXTRA_LANGUAGE_SWITCH_ALLOWED_LANGUAGES { get { if (!_EXTRA_LANGUAGE_SWITCH_ALLOWED_LANGUAGESReady) { _EXTRA_LANGUAGE_SWITCH_ALLOWED_LANGUAGESContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_LANGUAGE_SWITCH_ALLOWED_LANGUAGES"); _EXTRA_LANGUAGE_SWITCH_ALLOWED_LANGUAGESReady = true; } return _EXTRA_LANGUAGE_SWITCH_ALLOWED_LANGUAGESContent; } }
        private static Java.Lang.String _EXTRA_LANGUAGE_SWITCH_ALLOWED_LANGUAGESContent = default;
        private static bool _EXTRA_LANGUAGE_SWITCH_ALLOWED_LANGUAGESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_MASK_OFFENSIVE_WORDS"/>
        /// </summary>
        public static Java.Lang.String EXTRA_MASK_OFFENSIVE_WORDS { get { if (!_EXTRA_MASK_OFFENSIVE_WORDSReady) { _EXTRA_MASK_OFFENSIVE_WORDSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_MASK_OFFENSIVE_WORDS"); _EXTRA_MASK_OFFENSIVE_WORDSReady = true; } return _EXTRA_MASK_OFFENSIVE_WORDSContent; } }
        private static Java.Lang.String _EXTRA_MASK_OFFENSIVE_WORDSContent = default;
        private static bool _EXTRA_MASK_OFFENSIVE_WORDSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_MAX_RESULTS"/>
        /// </summary>
        public static Java.Lang.String EXTRA_MAX_RESULTS { get { if (!_EXTRA_MAX_RESULTSReady) { _EXTRA_MAX_RESULTSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_MAX_RESULTS"); _EXTRA_MAX_RESULTSReady = true; } return _EXTRA_MAX_RESULTSContent; } }
        private static Java.Lang.String _EXTRA_MAX_RESULTSContent = default;
        private static bool _EXTRA_MAX_RESULTSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_ONLY_RETURN_LANGUAGE_PREFERENCE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_ONLY_RETURN_LANGUAGE_PREFERENCE { get { if (!_EXTRA_ONLY_RETURN_LANGUAGE_PREFERENCEReady) { _EXTRA_ONLY_RETURN_LANGUAGE_PREFERENCEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_ONLY_RETURN_LANGUAGE_PREFERENCE"); _EXTRA_ONLY_RETURN_LANGUAGE_PREFERENCEReady = true; } return _EXTRA_ONLY_RETURN_LANGUAGE_PREFERENCEContent; } }
        private static Java.Lang.String _EXTRA_ONLY_RETURN_LANGUAGE_PREFERENCEContent = default;
        private static bool _EXTRA_ONLY_RETURN_LANGUAGE_PREFERENCEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_ORIGIN"/>
        /// </summary>
        public static Java.Lang.String EXTRA_ORIGIN { get { if (!_EXTRA_ORIGINReady) { _EXTRA_ORIGINContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_ORIGIN"); _EXTRA_ORIGINReady = true; } return _EXTRA_ORIGINContent; } }
        private static Java.Lang.String _EXTRA_ORIGINContent = default;
        private static bool _EXTRA_ORIGINReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_PARTIAL_RESULTS"/>
        /// </summary>
        public static Java.Lang.String EXTRA_PARTIAL_RESULTS { get { if (!_EXTRA_PARTIAL_RESULTSReady) { _EXTRA_PARTIAL_RESULTSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_PARTIAL_RESULTS"); _EXTRA_PARTIAL_RESULTSReady = true; } return _EXTRA_PARTIAL_RESULTSContent; } }
        private static Java.Lang.String _EXTRA_PARTIAL_RESULTSContent = default;
        private static bool _EXTRA_PARTIAL_RESULTSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_PREFER_OFFLINE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_PREFER_OFFLINE { get { if (!_EXTRA_PREFER_OFFLINEReady) { _EXTRA_PREFER_OFFLINEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_PREFER_OFFLINE"); _EXTRA_PREFER_OFFLINEReady = true; } return _EXTRA_PREFER_OFFLINEContent; } }
        private static Java.Lang.String _EXTRA_PREFER_OFFLINEContent = default;
        private static bool _EXTRA_PREFER_OFFLINEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_PROMPT"/>
        /// </summary>
        public static Java.Lang.String EXTRA_PROMPT { get { if (!_EXTRA_PROMPTReady) { _EXTRA_PROMPTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_PROMPT"); _EXTRA_PROMPTReady = true; } return _EXTRA_PROMPTContent; } }
        private static Java.Lang.String _EXTRA_PROMPTContent = default;
        private static bool _EXTRA_PROMPTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_REQUEST_WORD_CONFIDENCE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_REQUEST_WORD_CONFIDENCE { get { if (!_EXTRA_REQUEST_WORD_CONFIDENCEReady) { _EXTRA_REQUEST_WORD_CONFIDENCEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_REQUEST_WORD_CONFIDENCE"); _EXTRA_REQUEST_WORD_CONFIDENCEReady = true; } return _EXTRA_REQUEST_WORD_CONFIDENCEContent; } }
        private static Java.Lang.String _EXTRA_REQUEST_WORD_CONFIDENCEContent = default;
        private static bool _EXTRA_REQUEST_WORD_CONFIDENCEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_REQUEST_WORD_TIMING"/>
        /// </summary>
        public static Java.Lang.String EXTRA_REQUEST_WORD_TIMING { get { if (!_EXTRA_REQUEST_WORD_TIMINGReady) { _EXTRA_REQUEST_WORD_TIMINGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_REQUEST_WORD_TIMING"); _EXTRA_REQUEST_WORD_TIMINGReady = true; } return _EXTRA_REQUEST_WORD_TIMINGContent; } }
        private static Java.Lang.String _EXTRA_REQUEST_WORD_TIMINGContent = default;
        private static bool _EXTRA_REQUEST_WORD_TIMINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_RESULTS"/>
        /// </summary>
        public static Java.Lang.String EXTRA_RESULTS { get { if (!_EXTRA_RESULTSReady) { _EXTRA_RESULTSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_RESULTS"); _EXTRA_RESULTSReady = true; } return _EXTRA_RESULTSContent; } }
        private static Java.Lang.String _EXTRA_RESULTSContent = default;
        private static bool _EXTRA_RESULTSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_RESULTS_PENDINGINTENT"/>
        /// </summary>
        public static Java.Lang.String EXTRA_RESULTS_PENDINGINTENT { get { if (!_EXTRA_RESULTS_PENDINGINTENTReady) { _EXTRA_RESULTS_PENDINGINTENTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_RESULTS_PENDINGINTENT"); _EXTRA_RESULTS_PENDINGINTENTReady = true; } return _EXTRA_RESULTS_PENDINGINTENTContent; } }
        private static Java.Lang.String _EXTRA_RESULTS_PENDINGINTENTContent = default;
        private static bool _EXTRA_RESULTS_PENDINGINTENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_RESULTS_PENDINGINTENT_BUNDLE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_RESULTS_PENDINGINTENT_BUNDLE { get { if (!_EXTRA_RESULTS_PENDINGINTENT_BUNDLEReady) { _EXTRA_RESULTS_PENDINGINTENT_BUNDLEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_RESULTS_PENDINGINTENT_BUNDLE"); _EXTRA_RESULTS_PENDINGINTENT_BUNDLEReady = true; } return _EXTRA_RESULTS_PENDINGINTENT_BUNDLEContent; } }
        private static Java.Lang.String _EXTRA_RESULTS_PENDINGINTENT_BUNDLEContent = default;
        private static bool _EXTRA_RESULTS_PENDINGINTENT_BUNDLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_SECURE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_SECURE { get { if (!_EXTRA_SECUREReady) { _EXTRA_SECUREContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_SECURE"); _EXTRA_SECUREReady = true; } return _EXTRA_SECUREContent; } }
        private static Java.Lang.String _EXTRA_SECUREContent = default;
        private static bool _EXTRA_SECUREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_SEGMENTED_SESSION"/>
        /// </summary>
        public static Java.Lang.String EXTRA_SEGMENTED_SESSION { get { if (!_EXTRA_SEGMENTED_SESSIONReady) { _EXTRA_SEGMENTED_SESSIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_SEGMENTED_SESSION"); _EXTRA_SEGMENTED_SESSIONReady = true; } return _EXTRA_SEGMENTED_SESSIONContent; } }
        private static Java.Lang.String _EXTRA_SEGMENTED_SESSIONContent = default;
        private static bool _EXTRA_SEGMENTED_SESSIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_SPEECH_INPUT_COMPLETE_SILENCE_LENGTH_MILLIS"/>
        /// </summary>
        public static Java.Lang.String EXTRA_SPEECH_INPUT_COMPLETE_SILENCE_LENGTH_MILLIS { get { if (!_EXTRA_SPEECH_INPUT_COMPLETE_SILENCE_LENGTH_MILLISReady) { _EXTRA_SPEECH_INPUT_COMPLETE_SILENCE_LENGTH_MILLISContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_SPEECH_INPUT_COMPLETE_SILENCE_LENGTH_MILLIS"); _EXTRA_SPEECH_INPUT_COMPLETE_SILENCE_LENGTH_MILLISReady = true; } return _EXTRA_SPEECH_INPUT_COMPLETE_SILENCE_LENGTH_MILLISContent; } }
        private static Java.Lang.String _EXTRA_SPEECH_INPUT_COMPLETE_SILENCE_LENGTH_MILLISContent = default;
        private static bool _EXTRA_SPEECH_INPUT_COMPLETE_SILENCE_LENGTH_MILLISReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_SPEECH_INPUT_MINIMUM_LENGTH_MILLIS"/>
        /// </summary>
        public static Java.Lang.String EXTRA_SPEECH_INPUT_MINIMUM_LENGTH_MILLIS { get { if (!_EXTRA_SPEECH_INPUT_MINIMUM_LENGTH_MILLISReady) { _EXTRA_SPEECH_INPUT_MINIMUM_LENGTH_MILLISContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_SPEECH_INPUT_MINIMUM_LENGTH_MILLIS"); _EXTRA_SPEECH_INPUT_MINIMUM_LENGTH_MILLISReady = true; } return _EXTRA_SPEECH_INPUT_MINIMUM_LENGTH_MILLISContent; } }
        private static Java.Lang.String _EXTRA_SPEECH_INPUT_MINIMUM_LENGTH_MILLISContent = default;
        private static bool _EXTRA_SPEECH_INPUT_MINIMUM_LENGTH_MILLISReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_SPEECH_INPUT_POSSIBLY_COMPLETE_SILENCE_LENGTH_MILLIS"/>
        /// </summary>
        public static Java.Lang.String EXTRA_SPEECH_INPUT_POSSIBLY_COMPLETE_SILENCE_LENGTH_MILLIS { get { if (!_EXTRA_SPEECH_INPUT_POSSIBLY_COMPLETE_SILENCE_LENGTH_MILLISReady) { _EXTRA_SPEECH_INPUT_POSSIBLY_COMPLETE_SILENCE_LENGTH_MILLISContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_SPEECH_INPUT_POSSIBLY_COMPLETE_SILENCE_LENGTH_MILLIS"); _EXTRA_SPEECH_INPUT_POSSIBLY_COMPLETE_SILENCE_LENGTH_MILLISReady = true; } return _EXTRA_SPEECH_INPUT_POSSIBLY_COMPLETE_SILENCE_LENGTH_MILLISContent; } }
        private static Java.Lang.String _EXTRA_SPEECH_INPUT_POSSIBLY_COMPLETE_SILENCE_LENGTH_MILLISContent = default;
        private static bool _EXTRA_SPEECH_INPUT_POSSIBLY_COMPLETE_SILENCE_LENGTH_MILLISReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_SUPPORTED_LANGUAGES"/>
        /// </summary>
        public static Java.Lang.String EXTRA_SUPPORTED_LANGUAGES { get { if (!_EXTRA_SUPPORTED_LANGUAGESReady) { _EXTRA_SUPPORTED_LANGUAGESContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_SUPPORTED_LANGUAGES"); _EXTRA_SUPPORTED_LANGUAGESReady = true; } return _EXTRA_SUPPORTED_LANGUAGESContent; } }
        private static Java.Lang.String _EXTRA_SUPPORTED_LANGUAGESContent = default;
        private static bool _EXTRA_SUPPORTED_LANGUAGESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#EXTRA_WEB_SEARCH_ONLY"/>
        /// </summary>
        public static Java.Lang.String EXTRA_WEB_SEARCH_ONLY { get { if (!_EXTRA_WEB_SEARCH_ONLYReady) { _EXTRA_WEB_SEARCH_ONLYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_WEB_SEARCH_ONLY"); _EXTRA_WEB_SEARCH_ONLYReady = true; } return _EXTRA_WEB_SEARCH_ONLYContent; } }
        private static Java.Lang.String _EXTRA_WEB_SEARCH_ONLYContent = default;
        private static bool _EXTRA_WEB_SEARCH_ONLYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#FORMATTING_OPTIMIZE_LATENCY"/>
        /// </summary>
        public static Java.Lang.String FORMATTING_OPTIMIZE_LATENCY { get { if (!_FORMATTING_OPTIMIZE_LATENCYReady) { _FORMATTING_OPTIMIZE_LATENCYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FORMATTING_OPTIMIZE_LATENCY"); _FORMATTING_OPTIMIZE_LATENCYReady = true; } return _FORMATTING_OPTIMIZE_LATENCYContent; } }
        private static Java.Lang.String _FORMATTING_OPTIMIZE_LATENCYContent = default;
        private static bool _FORMATTING_OPTIMIZE_LATENCYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#FORMATTING_OPTIMIZE_QUALITY"/>
        /// </summary>
        public static Java.Lang.String FORMATTING_OPTIMIZE_QUALITY { get { if (!_FORMATTING_OPTIMIZE_QUALITYReady) { _FORMATTING_OPTIMIZE_QUALITYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FORMATTING_OPTIMIZE_QUALITY"); _FORMATTING_OPTIMIZE_QUALITYReady = true; } return _FORMATTING_OPTIMIZE_QUALITYContent; } }
        private static Java.Lang.String _FORMATTING_OPTIMIZE_QUALITYContent = default;
        private static bool _FORMATTING_OPTIMIZE_QUALITYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#LANGUAGE_MODEL_FREE_FORM"/>
        /// </summary>
        public static Java.Lang.String LANGUAGE_MODEL_FREE_FORM { get { if (!_LANGUAGE_MODEL_FREE_FORMReady) { _LANGUAGE_MODEL_FREE_FORMContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "LANGUAGE_MODEL_FREE_FORM"); _LANGUAGE_MODEL_FREE_FORMReady = true; } return _LANGUAGE_MODEL_FREE_FORMContent; } }
        private static Java.Lang.String _LANGUAGE_MODEL_FREE_FORMContent = default;
        private static bool _LANGUAGE_MODEL_FREE_FORMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#LANGUAGE_MODEL_WEB_SEARCH"/>
        /// </summary>
        public static Java.Lang.String LANGUAGE_MODEL_WEB_SEARCH { get { if (!_LANGUAGE_MODEL_WEB_SEARCHReady) { _LANGUAGE_MODEL_WEB_SEARCHContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "LANGUAGE_MODEL_WEB_SEARCH"); _LANGUAGE_MODEL_WEB_SEARCHReady = true; } return _LANGUAGE_MODEL_WEB_SEARCHContent; } }
        private static Java.Lang.String _LANGUAGE_MODEL_WEB_SEARCHContent = default;
        private static bool _LANGUAGE_MODEL_WEB_SEARCHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#LANGUAGE_SWITCH_BALANCED"/>
        /// </summary>
        public static Java.Lang.String LANGUAGE_SWITCH_BALANCED { get { if (!_LANGUAGE_SWITCH_BALANCEDReady) { _LANGUAGE_SWITCH_BALANCEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "LANGUAGE_SWITCH_BALANCED"); _LANGUAGE_SWITCH_BALANCEDReady = true; } return _LANGUAGE_SWITCH_BALANCEDContent; } }
        private static Java.Lang.String _LANGUAGE_SWITCH_BALANCEDContent = default;
        private static bool _LANGUAGE_SWITCH_BALANCEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#LANGUAGE_SWITCH_HIGH_PRECISION"/>
        /// </summary>
        public static Java.Lang.String LANGUAGE_SWITCH_HIGH_PRECISION { get { if (!_LANGUAGE_SWITCH_HIGH_PRECISIONReady) { _LANGUAGE_SWITCH_HIGH_PRECISIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "LANGUAGE_SWITCH_HIGH_PRECISION"); _LANGUAGE_SWITCH_HIGH_PRECISIONReady = true; } return _LANGUAGE_SWITCH_HIGH_PRECISIONContent; } }
        private static Java.Lang.String _LANGUAGE_SWITCH_HIGH_PRECISIONContent = default;
        private static bool _LANGUAGE_SWITCH_HIGH_PRECISIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#LANGUAGE_SWITCH_QUICK_RESPONSE"/>
        /// </summary>
        public static Java.Lang.String LANGUAGE_SWITCH_QUICK_RESPONSE { get { if (!_LANGUAGE_SWITCH_QUICK_RESPONSEReady) { _LANGUAGE_SWITCH_QUICK_RESPONSEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "LANGUAGE_SWITCH_QUICK_RESPONSE"); _LANGUAGE_SWITCH_QUICK_RESPONSEReady = true; } return _LANGUAGE_SWITCH_QUICK_RESPONSEContent; } }
        private static Java.Lang.String _LANGUAGE_SWITCH_QUICK_RESPONSEContent = default;
        private static bool _LANGUAGE_SWITCH_QUICK_RESPONSEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerIntent.html#getVoiceDetailsIntent(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <returns><see cref="Android.Content.Intent"/></returns>
        public static Android.Content.Intent GetVoiceDetailsIntent(Android.Content.Context arg0)
        {
            return SExecuteWithSignature<Android.Content.Intent>(LocalBridgeClazz, "getVoiceDetailsIntent", "(Landroid/content/Context;)Landroid/content/Intent;", arg0);
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