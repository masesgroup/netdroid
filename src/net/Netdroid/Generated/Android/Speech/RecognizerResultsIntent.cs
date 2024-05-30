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
    #region RecognizerResultsIntent
    public partial class RecognizerResultsIntent
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerResultsIntent.html#ACTION_VOICE_SEARCH_RESULTS"/>
        /// </summary>
        public static Java.Lang.String ACTION_VOICE_SEARCH_RESULTS { get { if (!_ACTION_VOICE_SEARCH_RESULTSReady) { _ACTION_VOICE_SEARCH_RESULTSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_VOICE_SEARCH_RESULTS"); _ACTION_VOICE_SEARCH_RESULTSReady = true; } return _ACTION_VOICE_SEARCH_RESULTSContent; } }
        private static Java.Lang.String _ACTION_VOICE_SEARCH_RESULTSContent = default;
        private static bool _ACTION_VOICE_SEARCH_RESULTSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerResultsIntent.html#EXTRA_VOICE_SEARCH_RESULT_HTML"/>
        /// </summary>
        public static Java.Lang.String EXTRA_VOICE_SEARCH_RESULT_HTML { get { if (!_EXTRA_VOICE_SEARCH_RESULT_HTMLReady) { _EXTRA_VOICE_SEARCH_RESULT_HTMLContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_VOICE_SEARCH_RESULT_HTML"); _EXTRA_VOICE_SEARCH_RESULT_HTMLReady = true; } return _EXTRA_VOICE_SEARCH_RESULT_HTMLContent; } }
        private static Java.Lang.String _EXTRA_VOICE_SEARCH_RESULT_HTMLContent = default;
        private static bool _EXTRA_VOICE_SEARCH_RESULT_HTMLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerResultsIntent.html#EXTRA_VOICE_SEARCH_RESULT_HTML_BASE_URLS"/>
        /// </summary>
        public static Java.Lang.String EXTRA_VOICE_SEARCH_RESULT_HTML_BASE_URLS { get { if (!_EXTRA_VOICE_SEARCH_RESULT_HTML_BASE_URLSReady) { _EXTRA_VOICE_SEARCH_RESULT_HTML_BASE_URLSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_VOICE_SEARCH_RESULT_HTML_BASE_URLS"); _EXTRA_VOICE_SEARCH_RESULT_HTML_BASE_URLSReady = true; } return _EXTRA_VOICE_SEARCH_RESULT_HTML_BASE_URLSContent; } }
        private static Java.Lang.String _EXTRA_VOICE_SEARCH_RESULT_HTML_BASE_URLSContent = default;
        private static bool _EXTRA_VOICE_SEARCH_RESULT_HTML_BASE_URLSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerResultsIntent.html#EXTRA_VOICE_SEARCH_RESULT_HTTP_HEADERS"/>
        /// </summary>
        public static Java.Lang.String EXTRA_VOICE_SEARCH_RESULT_HTTP_HEADERS { get { if (!_EXTRA_VOICE_SEARCH_RESULT_HTTP_HEADERSReady) { _EXTRA_VOICE_SEARCH_RESULT_HTTP_HEADERSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_VOICE_SEARCH_RESULT_HTTP_HEADERS"); _EXTRA_VOICE_SEARCH_RESULT_HTTP_HEADERSReady = true; } return _EXTRA_VOICE_SEARCH_RESULT_HTTP_HEADERSContent; } }
        private static Java.Lang.String _EXTRA_VOICE_SEARCH_RESULT_HTTP_HEADERSContent = default;
        private static bool _EXTRA_VOICE_SEARCH_RESULT_HTTP_HEADERSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerResultsIntent.html#EXTRA_VOICE_SEARCH_RESULT_STRINGS"/>
        /// </summary>
        public static Java.Lang.String EXTRA_VOICE_SEARCH_RESULT_STRINGS { get { if (!_EXTRA_VOICE_SEARCH_RESULT_STRINGSReady) { _EXTRA_VOICE_SEARCH_RESULT_STRINGSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_VOICE_SEARCH_RESULT_STRINGS"); _EXTRA_VOICE_SEARCH_RESULT_STRINGSReady = true; } return _EXTRA_VOICE_SEARCH_RESULT_STRINGSContent; } }
        private static Java.Lang.String _EXTRA_VOICE_SEARCH_RESULT_STRINGSContent = default;
        private static bool _EXTRA_VOICE_SEARCH_RESULT_STRINGSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerResultsIntent.html#EXTRA_VOICE_SEARCH_RESULT_URLS"/>
        /// </summary>
        public static Java.Lang.String EXTRA_VOICE_SEARCH_RESULT_URLS { get { if (!_EXTRA_VOICE_SEARCH_RESULT_URLSReady) { _EXTRA_VOICE_SEARCH_RESULT_URLSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_VOICE_SEARCH_RESULT_URLS"); _EXTRA_VOICE_SEARCH_RESULT_URLSReady = true; } return _EXTRA_VOICE_SEARCH_RESULT_URLSContent; } }
        private static Java.Lang.String _EXTRA_VOICE_SEARCH_RESULT_URLSContent = default;
        private static bool _EXTRA_VOICE_SEARCH_RESULT_URLSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognizerResultsIntent.html#URI_SCHEME_INLINE"/>
        /// </summary>
        public static Java.Lang.String URI_SCHEME_INLINE { get { if (!_URI_SCHEME_INLINEReady) { _URI_SCHEME_INLINEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "URI_SCHEME_INLINE"); _URI_SCHEME_INLINEReady = true; } return _URI_SCHEME_INLINEContent; } }
        private static Java.Lang.String _URI_SCHEME_INLINEContent = default;
        private static bool _URI_SCHEME_INLINEReady = false; // this is used because in case of generics 

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
}