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

namespace Android.View.Textclassifier
{
    #region ITextClassifier
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ITextClassifier
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TextClassifier
    public partial class TextClassifier : Android.View.Textclassifier.ITextClassifier
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.html#NO_OP"/>
        /// </summary>
        public static Android.View.Textclassifier.TextClassifier NO_OP { get { if (!_NO_OPReady) { _NO_OPContent = SGetField<Android.View.Textclassifier.TextClassifier>(LocalBridgeClazz, "NO_OP"); _NO_OPReady = true; } return _NO_OPContent; } }
        private static Android.View.Textclassifier.TextClassifier _NO_OPContent = default;
        private static bool _NO_OPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.html#EXTRA_FROM_TEXT_CLASSIFIER"/>
        /// </summary>
        public static Java.Lang.String EXTRA_FROM_TEXT_CLASSIFIER { get { if (!_EXTRA_FROM_TEXT_CLASSIFIERReady) { _EXTRA_FROM_TEXT_CLASSIFIERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_FROM_TEXT_CLASSIFIER"); _EXTRA_FROM_TEXT_CLASSIFIERReady = true; } return _EXTRA_FROM_TEXT_CLASSIFIERContent; } }
        private static Java.Lang.String _EXTRA_FROM_TEXT_CLASSIFIERContent = default;
        private static bool _EXTRA_FROM_TEXT_CLASSIFIERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.html#HINT_TEXT_IS_EDITABLE"/>
        /// </summary>
        public static Java.Lang.String HINT_TEXT_IS_EDITABLE { get { if (!_HINT_TEXT_IS_EDITABLEReady) { _HINT_TEXT_IS_EDITABLEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "HINT_TEXT_IS_EDITABLE"); _HINT_TEXT_IS_EDITABLEReady = true; } return _HINT_TEXT_IS_EDITABLEContent; } }
        private static Java.Lang.String _HINT_TEXT_IS_EDITABLEContent = default;
        private static bool _HINT_TEXT_IS_EDITABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.html#HINT_TEXT_IS_NOT_EDITABLE"/>
        /// </summary>
        public static Java.Lang.String HINT_TEXT_IS_NOT_EDITABLE { get { if (!_HINT_TEXT_IS_NOT_EDITABLEReady) { _HINT_TEXT_IS_NOT_EDITABLEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "HINT_TEXT_IS_NOT_EDITABLE"); _HINT_TEXT_IS_NOT_EDITABLEReady = true; } return _HINT_TEXT_IS_NOT_EDITABLEContent; } }
        private static Java.Lang.String _HINT_TEXT_IS_NOT_EDITABLEContent = default;
        private static bool _HINT_TEXT_IS_NOT_EDITABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.html#TYPE_ADDRESS"/>
        /// </summary>
        public static Java.Lang.String TYPE_ADDRESS { get { if (!_TYPE_ADDRESSReady) { _TYPE_ADDRESSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TYPE_ADDRESS"); _TYPE_ADDRESSReady = true; } return _TYPE_ADDRESSContent; } }
        private static Java.Lang.String _TYPE_ADDRESSContent = default;
        private static bool _TYPE_ADDRESSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.html#TYPE_DATE"/>
        /// </summary>
        public static Java.Lang.String TYPE_DATE { get { if (!_TYPE_DATEReady) { _TYPE_DATEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TYPE_DATE"); _TYPE_DATEReady = true; } return _TYPE_DATEContent; } }
        private static Java.Lang.String _TYPE_DATEContent = default;
        private static bool _TYPE_DATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.html#TYPE_DATE_TIME"/>
        /// </summary>
        public static Java.Lang.String TYPE_DATE_TIME { get { if (!_TYPE_DATE_TIMEReady) { _TYPE_DATE_TIMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TYPE_DATE_TIME"); _TYPE_DATE_TIMEReady = true; } return _TYPE_DATE_TIMEContent; } }
        private static Java.Lang.String _TYPE_DATE_TIMEContent = default;
        private static bool _TYPE_DATE_TIMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.html#TYPE_EMAIL"/>
        /// </summary>
        public static Java.Lang.String TYPE_EMAIL { get { if (!_TYPE_EMAILReady) { _TYPE_EMAILContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TYPE_EMAIL"); _TYPE_EMAILReady = true; } return _TYPE_EMAILContent; } }
        private static Java.Lang.String _TYPE_EMAILContent = default;
        private static bool _TYPE_EMAILReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.html#TYPE_FLIGHT_NUMBER"/>
        /// </summary>
        public static Java.Lang.String TYPE_FLIGHT_NUMBER { get { if (!_TYPE_FLIGHT_NUMBERReady) { _TYPE_FLIGHT_NUMBERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TYPE_FLIGHT_NUMBER"); _TYPE_FLIGHT_NUMBERReady = true; } return _TYPE_FLIGHT_NUMBERContent; } }
        private static Java.Lang.String _TYPE_FLIGHT_NUMBERContent = default;
        private static bool _TYPE_FLIGHT_NUMBERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.html#TYPE_OTHER"/>
        /// </summary>
        public static Java.Lang.String TYPE_OTHER { get { if (!_TYPE_OTHERReady) { _TYPE_OTHERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TYPE_OTHER"); _TYPE_OTHERReady = true; } return _TYPE_OTHERContent; } }
        private static Java.Lang.String _TYPE_OTHERContent = default;
        private static bool _TYPE_OTHERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.html#TYPE_PHONE"/>
        /// </summary>
        public static Java.Lang.String TYPE_PHONE { get { if (!_TYPE_PHONEReady) { _TYPE_PHONEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TYPE_PHONE"); _TYPE_PHONEReady = true; } return _TYPE_PHONEContent; } }
        private static Java.Lang.String _TYPE_PHONEContent = default;
        private static bool _TYPE_PHONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.html#TYPE_UNKNOWN"/>
        /// </summary>
        public static Java.Lang.String TYPE_UNKNOWN { get { if (!_TYPE_UNKNOWNReady) { _TYPE_UNKNOWNContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TYPE_UNKNOWN"); _TYPE_UNKNOWNReady = true; } return _TYPE_UNKNOWNContent; } }
        private static Java.Lang.String _TYPE_UNKNOWNContent = default;
        private static bool _TYPE_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.html#TYPE_URL"/>
        /// </summary>
        public static Java.Lang.String TYPE_URL { get { if (!_TYPE_URLReady) { _TYPE_URLContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TYPE_URL"); _TYPE_URLReady = true; } return _TYPE_URLContent; } }
        private static Java.Lang.String _TYPE_URLContent = default;
        private static bool _TYPE_URLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.html#WIDGET_TYPE_CLIPBOARD"/>
        /// </summary>
        public static Java.Lang.String WIDGET_TYPE_CLIPBOARD { get { if (!_WIDGET_TYPE_CLIPBOARDReady) { _WIDGET_TYPE_CLIPBOARDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "WIDGET_TYPE_CLIPBOARD"); _WIDGET_TYPE_CLIPBOARDReady = true; } return _WIDGET_TYPE_CLIPBOARDContent; } }
        private static Java.Lang.String _WIDGET_TYPE_CLIPBOARDContent = default;
        private static bool _WIDGET_TYPE_CLIPBOARDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.html#WIDGET_TYPE_CUSTOM_EDITTEXT"/>
        /// </summary>
        public static Java.Lang.String WIDGET_TYPE_CUSTOM_EDITTEXT { get { if (!_WIDGET_TYPE_CUSTOM_EDITTEXTReady) { _WIDGET_TYPE_CUSTOM_EDITTEXTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "WIDGET_TYPE_CUSTOM_EDITTEXT"); _WIDGET_TYPE_CUSTOM_EDITTEXTReady = true; } return _WIDGET_TYPE_CUSTOM_EDITTEXTContent; } }
        private static Java.Lang.String _WIDGET_TYPE_CUSTOM_EDITTEXTContent = default;
        private static bool _WIDGET_TYPE_CUSTOM_EDITTEXTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.html#WIDGET_TYPE_CUSTOM_TEXTVIEW"/>
        /// </summary>
        public static Java.Lang.String WIDGET_TYPE_CUSTOM_TEXTVIEW { get { if (!_WIDGET_TYPE_CUSTOM_TEXTVIEWReady) { _WIDGET_TYPE_CUSTOM_TEXTVIEWContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "WIDGET_TYPE_CUSTOM_TEXTVIEW"); _WIDGET_TYPE_CUSTOM_TEXTVIEWReady = true; } return _WIDGET_TYPE_CUSTOM_TEXTVIEWContent; } }
        private static Java.Lang.String _WIDGET_TYPE_CUSTOM_TEXTVIEWContent = default;
        private static bool _WIDGET_TYPE_CUSTOM_TEXTVIEWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.html#WIDGET_TYPE_CUSTOM_UNSELECTABLE_TEXTVIEW"/>
        /// </summary>
        public static Java.Lang.String WIDGET_TYPE_CUSTOM_UNSELECTABLE_TEXTVIEW { get { if (!_WIDGET_TYPE_CUSTOM_UNSELECTABLE_TEXTVIEWReady) { _WIDGET_TYPE_CUSTOM_UNSELECTABLE_TEXTVIEWContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "WIDGET_TYPE_CUSTOM_UNSELECTABLE_TEXTVIEW"); _WIDGET_TYPE_CUSTOM_UNSELECTABLE_TEXTVIEWReady = true; } return _WIDGET_TYPE_CUSTOM_UNSELECTABLE_TEXTVIEWContent; } }
        private static Java.Lang.String _WIDGET_TYPE_CUSTOM_UNSELECTABLE_TEXTVIEWContent = default;
        private static bool _WIDGET_TYPE_CUSTOM_UNSELECTABLE_TEXTVIEWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.html#WIDGET_TYPE_EDIT_WEBVIEW"/>
        /// </summary>
        public static Java.Lang.String WIDGET_TYPE_EDIT_WEBVIEW { get { if (!_WIDGET_TYPE_EDIT_WEBVIEWReady) { _WIDGET_TYPE_EDIT_WEBVIEWContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "WIDGET_TYPE_EDIT_WEBVIEW"); _WIDGET_TYPE_EDIT_WEBVIEWReady = true; } return _WIDGET_TYPE_EDIT_WEBVIEWContent; } }
        private static Java.Lang.String _WIDGET_TYPE_EDIT_WEBVIEWContent = default;
        private static bool _WIDGET_TYPE_EDIT_WEBVIEWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.html#WIDGET_TYPE_EDITTEXT"/>
        /// </summary>
        public static Java.Lang.String WIDGET_TYPE_EDITTEXT { get { if (!_WIDGET_TYPE_EDITTEXTReady) { _WIDGET_TYPE_EDITTEXTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "WIDGET_TYPE_EDITTEXT"); _WIDGET_TYPE_EDITTEXTReady = true; } return _WIDGET_TYPE_EDITTEXTContent; } }
        private static Java.Lang.String _WIDGET_TYPE_EDITTEXTContent = default;
        private static bool _WIDGET_TYPE_EDITTEXTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.html#WIDGET_TYPE_NOTIFICATION"/>
        /// </summary>
        public static Java.Lang.String WIDGET_TYPE_NOTIFICATION { get { if (!_WIDGET_TYPE_NOTIFICATIONReady) { _WIDGET_TYPE_NOTIFICATIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "WIDGET_TYPE_NOTIFICATION"); _WIDGET_TYPE_NOTIFICATIONReady = true; } return _WIDGET_TYPE_NOTIFICATIONContent; } }
        private static Java.Lang.String _WIDGET_TYPE_NOTIFICATIONContent = default;
        private static bool _WIDGET_TYPE_NOTIFICATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.html#WIDGET_TYPE_TEXTVIEW"/>
        /// </summary>
        public static Java.Lang.String WIDGET_TYPE_TEXTVIEW { get { if (!_WIDGET_TYPE_TEXTVIEWReady) { _WIDGET_TYPE_TEXTVIEWContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "WIDGET_TYPE_TEXTVIEW"); _WIDGET_TYPE_TEXTVIEWReady = true; } return _WIDGET_TYPE_TEXTVIEWContent; } }
        private static Java.Lang.String _WIDGET_TYPE_TEXTVIEWContent = default;
        private static bool _WIDGET_TYPE_TEXTVIEWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.html#WIDGET_TYPE_UNKNOWN"/>
        /// </summary>
        public static Java.Lang.String WIDGET_TYPE_UNKNOWN { get { if (!_WIDGET_TYPE_UNKNOWNReady) { _WIDGET_TYPE_UNKNOWNContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "WIDGET_TYPE_UNKNOWN"); _WIDGET_TYPE_UNKNOWNReady = true; } return _WIDGET_TYPE_UNKNOWNContent; } }
        private static Java.Lang.String _WIDGET_TYPE_UNKNOWNContent = default;
        private static bool _WIDGET_TYPE_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.html#WIDGET_TYPE_UNSELECTABLE_TEXTVIEW"/>
        /// </summary>
        public static Java.Lang.String WIDGET_TYPE_UNSELECTABLE_TEXTVIEW { get { if (!_WIDGET_TYPE_UNSELECTABLE_TEXTVIEWReady) { _WIDGET_TYPE_UNSELECTABLE_TEXTVIEWContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "WIDGET_TYPE_UNSELECTABLE_TEXTVIEW"); _WIDGET_TYPE_UNSELECTABLE_TEXTVIEWReady = true; } return _WIDGET_TYPE_UNSELECTABLE_TEXTVIEWContent; } }
        private static Java.Lang.String _WIDGET_TYPE_UNSELECTABLE_TEXTVIEWContent = default;
        private static bool _WIDGET_TYPE_UNSELECTABLE_TEXTVIEWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.html#WIDGET_TYPE_WEBVIEW"/>
        /// </summary>
        public static Java.Lang.String WIDGET_TYPE_WEBVIEW { get { if (!_WIDGET_TYPE_WEBVIEWReady) { _WIDGET_TYPE_WEBVIEWContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "WIDGET_TYPE_WEBVIEW"); _WIDGET_TYPE_WEBVIEWReady = true; } return _WIDGET_TYPE_WEBVIEWContent; } }
        private static Java.Lang.String _WIDGET_TYPE_WEBVIEWContent = default;
        private static bool _WIDGET_TYPE_WEBVIEWReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.html#suggestConversationActions(android.view.textclassifier.ConversationActions.Request)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Textclassifier.ConversationActions.Request"/></param>
        /// <returns><see cref="Android.View.Textclassifier.ConversationActions"/></returns>
        public Android.View.Textclassifier.ConversationActions SuggestConversationActions(Android.View.Textclassifier.ConversationActions.Request arg0)
        {
            return IExecute<Android.View.Textclassifier.ConversationActions>("suggestConversationActions", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.html#classifyText(android.view.textclassifier.TextClassification.Request)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Textclassifier.TextClassification.Request"/></param>
        /// <returns><see cref="Android.View.Textclassifier.TextClassification"/></returns>
        public Android.View.Textclassifier.TextClassification ClassifyText(Android.View.Textclassifier.TextClassification.Request arg0)
        {
            return IExecute<Android.View.Textclassifier.TextClassification>("classifyText", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.html#classifyText(java.lang.CharSequence,int,int,android.os.LocaleList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.Os.LocaleList"/></param>
        /// <returns><see cref="Android.View.Textclassifier.TextClassification"/></returns>
        public Android.View.Textclassifier.TextClassification ClassifyText(Java.Lang.CharSequence arg0, int arg1, int arg2, Android.Os.LocaleList arg3)
        {
            return IExecute<Android.View.Textclassifier.TextClassification>("classifyText", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.html#detectLanguage(android.view.textclassifier.TextLanguage.Request)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Textclassifier.TextLanguage.Request"/></param>
        /// <returns><see cref="Android.View.Textclassifier.TextLanguage"/></returns>
        public Android.View.Textclassifier.TextLanguage DetectLanguage(Android.View.Textclassifier.TextLanguage.Request arg0)
        {
            return IExecute<Android.View.Textclassifier.TextLanguage>("detectLanguage", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.html#generateLinks(android.view.textclassifier.TextLinks.Request)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Textclassifier.TextLinks.Request"/></param>
        /// <returns><see cref="Android.View.Textclassifier.TextLinks"/></returns>
        public Android.View.Textclassifier.TextLinks GenerateLinks(Android.View.Textclassifier.TextLinks.Request arg0)
        {
            return IExecute<Android.View.Textclassifier.TextLinks>("generateLinks", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.html#suggestSelection(android.view.textclassifier.TextSelection.Request)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Textclassifier.TextSelection.Request"/></param>
        /// <returns><see cref="Android.View.Textclassifier.TextSelection"/></returns>
        public Android.View.Textclassifier.TextSelection SuggestSelection(Android.View.Textclassifier.TextSelection.Request arg0)
        {
            return IExecute<Android.View.Textclassifier.TextSelection>("suggestSelection", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.html#suggestSelection(java.lang.CharSequence,int,int,android.os.LocaleList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.Os.LocaleList"/></param>
        /// <returns><see cref="Android.View.Textclassifier.TextSelection"/></returns>
        public Android.View.Textclassifier.TextSelection SuggestSelection(Java.Lang.CharSequence arg0, int arg1, int arg2, Android.Os.LocaleList arg3)
        {
            return IExecute<Android.View.Textclassifier.TextSelection>("suggestSelection", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.html#isDestroyed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDestroyed()
        {
            return IExecuteWithSignature<bool>("isDestroyed", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.html#getMaxGenerateLinksTextLength()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaxGenerateLinksTextLength()
        {
            return IExecuteWithSignature<int>("getMaxGenerateLinksTextLength", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.html#destroy()"/>
        /// </summary>
        public void Destroy()
        {
            IExecuteWithSignature("destroy", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.html#onSelectionEvent(android.view.textclassifier.SelectionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Textclassifier.SelectionEvent"/></param>
        public void OnSelectionEvent(Android.View.Textclassifier.SelectionEvent arg0)
        {
            IExecute("onSelectionEvent", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.html#onTextClassifierEvent(android.view.textclassifier.TextClassifierEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Textclassifier.TextClassifierEvent"/></param>
        public void OnTextClassifierEvent(Android.View.Textclassifier.TextClassifierEvent arg0)
        {
            IExecute("onTextClassifierEvent", arg0);
        }

        #endregion

        #region Nested classes
        #region EntityConfig
        public partial class EntityConfig
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.EntityConfig.html#CREATOR"/>
            /// </summary>
            public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
            private static Android.Os.Parcelable.Creator _CREATORContent = default;
            private static bool _CREATORReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.EntityConfig.html#create(java.util.Collection,java.util.Collection,java.util.Collection)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
            /// <param name="arg1"><see cref="Java.Util.Collection"/></param>
            /// <param name="arg2"><see cref="Java.Util.Collection"/></param>
            /// <returns><see cref="Android.View.Textclassifier.TextClassifier.EntityConfig"/></returns>
            [global::System.Obsolete()]
            public static Android.View.Textclassifier.TextClassifier.EntityConfig Create(Java.Util.Collection<Java.Lang.String> arg0, Java.Util.Collection<Java.Lang.String> arg1, Java.Util.Collection<Java.Lang.String> arg2)
            {
                return SExecute<Android.View.Textclassifier.TextClassifier.EntityConfig>(LocalBridgeClazz, "create", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.EntityConfig.html#createWithExplicitEntityList(java.util.Collection)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
            /// <returns><see cref="Android.View.Textclassifier.TextClassifier.EntityConfig"/></returns>
            [global::System.Obsolete()]
            public static Android.View.Textclassifier.TextClassifier.EntityConfig CreateWithExplicitEntityList(Java.Util.Collection<Java.Lang.String> arg0)
            {
                return SExecute<Android.View.Textclassifier.TextClassifier.EntityConfig>(LocalBridgeClazz, "createWithExplicitEntityList", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.EntityConfig.html#createWithHints(java.util.Collection)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
            /// <returns><see cref="Android.View.Textclassifier.TextClassifier.EntityConfig"/></returns>
            [global::System.Obsolete()]
            public static Android.View.Textclassifier.TextClassifier.EntityConfig CreateWithHints(Java.Util.Collection<Java.Lang.String> arg0)
            {
                return SExecute<Android.View.Textclassifier.TextClassifier.EntityConfig>(LocalBridgeClazz, "createWithHints", arg0);
            }

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.EntityConfig.html#shouldIncludeTypesFromTextClassifier()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool ShouldIncludeTypesFromTextClassifier()
            {
                return IExecuteWithSignature<bool>("shouldIncludeTypesFromTextClassifier", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.EntityConfig.html#describeContents()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int DescribeContents()
            {
                return IExecuteWithSignature<int>("describeContents", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.EntityConfig.html#getHints()"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Collection"/></returns>
            public Java.Util.Collection<Java.Lang.String> GetHints()
            {
                return IExecuteWithSignature<Java.Util.Collection<Java.Lang.String>>("getHints", "()Ljava/util/Collection;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.EntityConfig.html#resolveEntityListModifications(java.util.Collection)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
            /// <returns><see cref="Java.Util.Collection"/></returns>
            public Java.Util.Collection<Java.Lang.String> ResolveEntityListModifications(Java.Util.Collection<Java.Lang.String> arg0)
            {
                return IExecuteWithSignature<Java.Util.Collection<Java.Lang.String>>("resolveEntityListModifications", "(Ljava/util/Collection;)Ljava/util/Collection;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.EntityConfig.html#writeToParcel(android.os.Parcel,int)"/>
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

                #endregion

                #region Class/Interface conversion operators

                #endregion

                #region Fields

                #endregion

                #region Static methods

                #endregion

                #region Instance methods
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.EntityConfig.Builder.html#build()"/>
                /// </summary>
                /// <returns><see cref="Android.View.Textclassifier.TextClassifier.EntityConfig"/></returns>
                public Android.View.Textclassifier.TextClassifier.EntityConfig Build()
                {
                    return IExecute<Android.View.Textclassifier.TextClassifier.EntityConfig>("build");
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.EntityConfig.Builder.html#includeTypesFromTextClassifier(boolean)"/>
                /// </summary>
                /// <param name="arg0"><see cref="bool"/></param>
                /// <returns><see cref="Android.View.Textclassifier.TextClassifier.EntityConfig.Builder"/></returns>
                public Android.View.Textclassifier.TextClassifier.EntityConfig.Builder IncludeTypesFromTextClassifier(bool arg0)
                {
                    return IExecute<Android.View.Textclassifier.TextClassifier.EntityConfig.Builder>("includeTypesFromTextClassifier", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.EntityConfig.Builder.html#setExcludedTypes(java.util.Collection)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
                /// <returns><see cref="Android.View.Textclassifier.TextClassifier.EntityConfig.Builder"/></returns>
                public Android.View.Textclassifier.TextClassifier.EntityConfig.Builder SetExcludedTypes(Java.Util.Collection<Java.Lang.String> arg0)
                {
                    return IExecute<Android.View.Textclassifier.TextClassifier.EntityConfig.Builder>("setExcludedTypes", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.EntityConfig.Builder.html#setHints(java.util.Collection)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
                /// <returns><see cref="Android.View.Textclassifier.TextClassifier.EntityConfig.Builder"/></returns>
                public Android.View.Textclassifier.TextClassifier.EntityConfig.Builder SetHints(Java.Util.Collection<Java.Lang.String> arg0)
                {
                    return IExecute<Android.View.Textclassifier.TextClassifier.EntityConfig.Builder>("setHints", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassifier.EntityConfig.Builder.html#setIncludedTypes(java.util.Collection)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
                /// <returns><see cref="Android.View.Textclassifier.TextClassifier.EntityConfig.Builder"/></returns>
                public Android.View.Textclassifier.TextClassifier.EntityConfig.Builder SetIncludedTypes(Java.Util.Collection<Java.Lang.String> arg0)
                {
                    return IExecute<Android.View.Textclassifier.TextClassifier.EntityConfig.Builder>("setIncludedTypes", arg0);
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

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}