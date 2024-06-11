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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Preference
{
    #region PreferenceActivity
    public partial class PreferenceActivity
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.html#EXTRA_NO_HEADERS"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String EXTRA_NO_HEADERS { get { if (!_EXTRA_NO_HEADERSReady) { _EXTRA_NO_HEADERSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_NO_HEADERS"); _EXTRA_NO_HEADERSReady = true; } return _EXTRA_NO_HEADERSContent; } }
        private static Java.Lang.String _EXTRA_NO_HEADERSContent = default;
        private static bool _EXTRA_NO_HEADERSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.html#EXTRA_SHOW_FRAGMENT"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String EXTRA_SHOW_FRAGMENT { get { if (!_EXTRA_SHOW_FRAGMENTReady) { _EXTRA_SHOW_FRAGMENTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_SHOW_FRAGMENT"); _EXTRA_SHOW_FRAGMENTReady = true; } return _EXTRA_SHOW_FRAGMENTContent; } }
        private static Java.Lang.String _EXTRA_SHOW_FRAGMENTContent = default;
        private static bool _EXTRA_SHOW_FRAGMENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.html#EXTRA_SHOW_FRAGMENT_ARGUMENTS"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String EXTRA_SHOW_FRAGMENT_ARGUMENTS { get { if (!_EXTRA_SHOW_FRAGMENT_ARGUMENTSReady) { _EXTRA_SHOW_FRAGMENT_ARGUMENTSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_SHOW_FRAGMENT_ARGUMENTS"); _EXTRA_SHOW_FRAGMENT_ARGUMENTSReady = true; } return _EXTRA_SHOW_FRAGMENT_ARGUMENTSContent; } }
        private static Java.Lang.String _EXTRA_SHOW_FRAGMENT_ARGUMENTSContent = default;
        private static bool _EXTRA_SHOW_FRAGMENT_ARGUMENTSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.html#EXTRA_SHOW_FRAGMENT_SHORT_TITLE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String EXTRA_SHOW_FRAGMENT_SHORT_TITLE { get { if (!_EXTRA_SHOW_FRAGMENT_SHORT_TITLEReady) { _EXTRA_SHOW_FRAGMENT_SHORT_TITLEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_SHOW_FRAGMENT_SHORT_TITLE"); _EXTRA_SHOW_FRAGMENT_SHORT_TITLEReady = true; } return _EXTRA_SHOW_FRAGMENT_SHORT_TITLEContent; } }
        private static Java.Lang.String _EXTRA_SHOW_FRAGMENT_SHORT_TITLEContent = default;
        private static bool _EXTRA_SHOW_FRAGMENT_SHORT_TITLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.html#EXTRA_SHOW_FRAGMENT_TITLE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String EXTRA_SHOW_FRAGMENT_TITLE { get { if (!_EXTRA_SHOW_FRAGMENT_TITLEReady) { _EXTRA_SHOW_FRAGMENT_TITLEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_SHOW_FRAGMENT_TITLE"); _EXTRA_SHOW_FRAGMENT_TITLEReady = true; } return _EXTRA_SHOW_FRAGMENT_TITLEContent; } }
        private static Java.Lang.String _EXTRA_SHOW_FRAGMENT_TITLEContent = default;
        private static bool _EXTRA_SHOW_FRAGMENT_TITLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.html#HEADER_ID_UNDEFINED"/>
        /// </summary>
        [global::System.Obsolete()]
        public static long HEADER_ID_UNDEFINED { get { if (!_HEADER_ID_UNDEFINEDReady) { _HEADER_ID_UNDEFINEDContent = SGetField<long>(LocalBridgeClazz, "HEADER_ID_UNDEFINED"); _HEADER_ID_UNDEFINEDReady = true; } return _HEADER_ID_UNDEFINEDContent; } }
        private static long _HEADER_ID_UNDEFINEDContent = default;
        private static bool _HEADER_ID_UNDEFINEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.html#onBuildStartFragmentIntent(java.lang.String,android.os.Bundle,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Android.Content.Intent"/></returns>
        [global::System.Obsolete()]
        public Android.Content.Intent OnBuildStartFragmentIntent(Java.Lang.String arg0, Android.Os.Bundle arg1, int arg2, int arg3)
        {
            return IExecute<Android.Content.Intent>("onBuildStartFragmentIntent", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.html#findPreference(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Android.Preference.Preference"/></returns>
        [global::System.Obsolete()]
        public Android.Preference.Preference FindPreference(Java.Lang.CharSequence arg0)
        {
            return IExecuteWithSignature<Android.Preference.Preference>("findPreference", "(Ljava/lang/CharSequence;)Landroid/preference/Preference;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.html#onGetInitialHeader()"/>
        /// </summary>
        /// <returns><see cref="Android.Preference.PreferenceActivity.Header"/></returns>
        [global::System.Obsolete()]
        public Android.Preference.PreferenceActivity.Header OnGetInitialHeader()
        {
            return IExecuteWithSignature<Android.Preference.PreferenceActivity.Header>("onGetInitialHeader", "()Landroid/preference/PreferenceActivity$Header;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.html#onGetNewHeader()"/>
        /// </summary>
        /// <returns><see cref="Android.Preference.PreferenceActivity.Header"/></returns>
        [global::System.Obsolete()]
        public Android.Preference.PreferenceActivity.Header OnGetNewHeader()
        {
            return IExecuteWithSignature<Android.Preference.PreferenceActivity.Header>("onGetNewHeader", "()Landroid/preference/PreferenceActivity$Header;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.html#getPreferenceManager()"/>
        /// </summary>
        /// <returns><see cref="Android.Preference.PreferenceManager"/></returns>
        [global::System.Obsolete()]
        public Android.Preference.PreferenceManager GetPreferenceManager()
        {
            return IExecuteWithSignature<Android.Preference.PreferenceManager>("getPreferenceManager", "()Landroid/preference/PreferenceManager;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.html#getPreferenceScreen()"/>
        /// </summary>
        /// <returns><see cref="Android.Preference.PreferenceScreen"/></returns>
        [global::System.Obsolete()]
        public Android.Preference.PreferenceScreen GetPreferenceScreen()
        {
            return IExecuteWithSignature<Android.Preference.PreferenceScreen>("getPreferenceScreen", "()Landroid/preference/PreferenceScreen;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.html#hasHeaders()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool HasHeaders()
        {
            return IExecuteWithSignature<bool>("hasHeaders", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.html#isMultiPane()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsMultiPane()
        {
            return IExecuteWithSignature<bool>("isMultiPane", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.html#onIsHidingHeaders()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool OnIsHidingHeaders()
        {
            return IExecuteWithSignature<bool>("onIsHidingHeaders", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.html#onIsMultiPane()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool OnIsMultiPane()
        {
            return IExecuteWithSignature<bool>("onIsMultiPane", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.html#onPreferenceStartFragment(android.preference.PreferenceFragment,android.preference.Preference)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Preference.PreferenceFragment"/></param>
        /// <param name="arg1"><see cref="Android.Preference.Preference"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool OnPreferenceStartFragment(Android.Preference.PreferenceFragment arg0, Android.Preference.Preference arg1)
        {
            return IExecute<bool>("onPreferenceStartFragment", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.html#onPreferenceTreeClick(android.preference.PreferenceScreen,android.preference.Preference)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Preference.PreferenceScreen"/></param>
        /// <param name="arg1"><see cref="Android.Preference.Preference"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool OnPreferenceTreeClick(Android.Preference.PreferenceScreen arg0, Android.Preference.Preference arg1)
        {
            return IExecute<bool>("onPreferenceTreeClick", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.html#addPreferencesFromIntent(android.content.Intent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        [global::System.Obsolete()]
        public void AddPreferencesFromIntent(Android.Content.Intent arg0)
        {
            IExecuteWithSignature("addPreferencesFromIntent", "(Landroid/content/Intent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.html#addPreferencesFromResource(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void AddPreferencesFromResource(int arg0)
        {
            IExecuteWithSignature("addPreferencesFromResource", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.html#finishPreferencePanel(android.app.Fragment,int,android.content.Intent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Fragment"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Content.Intent"/></param>
        [global::System.Obsolete()]
        public void FinishPreferencePanel(Android.App.Fragment arg0, int arg1, Android.Content.Intent arg2)
        {
            IExecute("finishPreferencePanel", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.html#invalidateHeaders()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void InvalidateHeaders()
        {
            IExecuteWithSignature("invalidateHeaders", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.html#loadHeadersFromResource(int,java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        [global::System.Obsolete()]
        public void LoadHeadersFromResource(int arg0, Java.Util.List<Android.Preference.PreferenceActivity.Header> arg1)
        {
            IExecute("loadHeadersFromResource", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.html#onBuildHeaders(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        [global::System.Obsolete()]
        public void OnBuildHeaders(Java.Util.List<Android.Preference.PreferenceActivity.Header> arg0)
        {
            IExecuteWithSignature("onBuildHeaders", "(Ljava/util/List;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.html#onHeaderClick(android.preference.PreferenceActivity.Header,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Preference.PreferenceActivity.Header"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void OnHeaderClick(Android.Preference.PreferenceActivity.Header arg0, int arg1)
        {
            IExecute("onHeaderClick", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.html#setListFooter(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        [global::System.Obsolete()]
        public void SetListFooter(Android.View.View arg0)
        {
            IExecuteWithSignature("setListFooter", "(Landroid/view/View;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.html#setParentTitle(java.lang.CharSequence,java.lang.CharSequence,android.view.View.OnClickListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg2"><see cref="Android.View.View.OnClickListener"/></param>
        [global::System.Obsolete()]
        public void SetParentTitle(Java.Lang.CharSequence arg0, Java.Lang.CharSequence arg1, Android.View.View.OnClickListener arg2)
        {
            IExecute("setParentTitle", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.html#setPreferenceScreen(android.preference.PreferenceScreen)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Preference.PreferenceScreen"/></param>
        [global::System.Obsolete()]
        public void SetPreferenceScreen(Android.Preference.PreferenceScreen arg0)
        {
            IExecuteWithSignature("setPreferenceScreen", "(Landroid/preference/PreferenceScreen;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.html#showBreadCrumbs(java.lang.CharSequence,java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        [global::System.Obsolete()]
        public void ShowBreadCrumbs(Java.Lang.CharSequence arg0, Java.Lang.CharSequence arg1)
        {
            IExecute("showBreadCrumbs", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.html#startPreferenceFragment(android.app.Fragment,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Fragment"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void StartPreferenceFragment(Android.App.Fragment arg0, bool arg1)
        {
            IExecute("startPreferenceFragment", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.html#startPreferencePanel(java.lang.String,android.os.Bundle,int,java.lang.CharSequence,android.app.Fragment,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg4"><see cref="Android.App.Fragment"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void StartPreferencePanel(Java.Lang.String arg0, Android.Os.Bundle arg1, int arg2, Java.Lang.CharSequence arg3, Android.App.Fragment arg4, int arg5)
        {
            IExecute("startPreferencePanel", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.html#startWithFragment(java.lang.String,android.os.Bundle,android.app.Fragment,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
        /// <param name="arg2"><see cref="Android.App.Fragment"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void StartWithFragment(Java.Lang.String arg0, Android.Os.Bundle arg1, Android.App.Fragment arg2, int arg3, int arg4, int arg5)
        {
            IExecute("startWithFragment", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.html#startWithFragment(java.lang.String,android.os.Bundle,android.app.Fragment,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
        /// <param name="arg2"><see cref="Android.App.Fragment"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void StartWithFragment(Java.Lang.String arg0, Android.Os.Bundle arg1, Android.App.Fragment arg2, int arg3)
        {
            IExecute("startWithFragment", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.html#switchToHeader(android.preference.PreferenceActivity.Header)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Preference.PreferenceActivity.Header"/></param>
        [global::System.Obsolete()]
        public void SwitchToHeader(Android.Preference.PreferenceActivity.Header arg0)
        {
            IExecuteWithSignature("switchToHeader", "(Landroid/preference/PreferenceActivity$Header;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.html#switchToHeader(java.lang.String,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
        [global::System.Obsolete()]
        public void SwitchToHeader(Java.Lang.String arg0, Android.Os.Bundle arg1)
        {
            IExecute("switchToHeader", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Header
        public partial class Header
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.Header.html#intent"/>
            /// </summary>
            [global::System.Obsolete()]
            public Android.Content.Intent intent { get { return IGetField<Android.Content.Intent>("intent"); } set { ISetField("intent", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.Header.html#extras"/>
            /// </summary>
            [global::System.Obsolete()]
            public Android.Os.Bundle extras { get { return IGetField<Android.Os.Bundle>("extras"); } set { ISetField("extras", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.Header.html#fragmentArguments"/>
            /// </summary>
            [global::System.Obsolete()]
            public Android.Os.Bundle fragmentArguments { get { return IGetField<Android.Os.Bundle>("fragmentArguments"); } set { ISetField("fragmentArguments", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.Header.html#breadCrumbShortTitleRes"/>
            /// </summary>
            [global::System.Obsolete()]
            public int breadCrumbShortTitleRes { get { return IGetField<int>("breadCrumbShortTitleRes"); } set { ISetField("breadCrumbShortTitleRes", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.Header.html#breadCrumbTitleRes"/>
            /// </summary>
            [global::System.Obsolete()]
            public int breadCrumbTitleRes { get { return IGetField<int>("breadCrumbTitleRes"); } set { ISetField("breadCrumbTitleRes", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.Header.html#iconRes"/>
            /// </summary>
            [global::System.Obsolete()]
            public int iconRes { get { return IGetField<int>("iconRes"); } set { ISetField("iconRes", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.Header.html#summaryRes"/>
            /// </summary>
            [global::System.Obsolete()]
            public int summaryRes { get { return IGetField<int>("summaryRes"); } set { ISetField("summaryRes", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.Header.html#titleRes"/>
            /// </summary>
            [global::System.Obsolete()]
            public int titleRes { get { return IGetField<int>("titleRes"); } set { ISetField("titleRes", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.Header.html#breadCrumbShortTitle"/>
            /// </summary>
            [global::System.Obsolete()]
            public Java.Lang.CharSequence breadCrumbShortTitle { get { return IGetField<Java.Lang.CharSequence>("breadCrumbShortTitle"); } set { ISetField("breadCrumbShortTitle", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.Header.html#breadCrumbTitle"/>
            /// </summary>
            [global::System.Obsolete()]
            public Java.Lang.CharSequence breadCrumbTitle { get { return IGetField<Java.Lang.CharSequence>("breadCrumbTitle"); } set { ISetField("breadCrumbTitle", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.Header.html#summary"/>
            /// </summary>
            [global::System.Obsolete()]
            public Java.Lang.CharSequence summary { get { return IGetField<Java.Lang.CharSequence>("summary"); } set { ISetField("summary", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.Header.html#title"/>
            /// </summary>
            [global::System.Obsolete()]
            public Java.Lang.CharSequence title { get { return IGetField<Java.Lang.CharSequence>("title"); } set { ISetField("title", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.Header.html#fragment"/>
            /// </summary>
            [global::System.Obsolete()]
            public Java.Lang.String fragment { get { return IGetField<Java.Lang.String>("fragment"); } set { ISetField("fragment", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.Header.html#id"/>
            /// </summary>
            [global::System.Obsolete()]
            public long id { get { return IGetField<long>("id"); } set { ISetField("id", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.Header.html#CREATOR"/>
            /// </summary>
            [global::System.Obsolete()]
            public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
            private static Android.Os.Parcelable.Creator _CREATORContent = default;
            private static bool _CREATORReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.Header.html#describeContents()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            [global::System.Obsolete()]
            public int DescribeContents()
            {
                return IExecuteWithSignature<int>("describeContents", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.Header.html#getBreadCrumbShortTitle(android.content.res.Resources)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Res.Resources"/></param>
            /// <returns><see cref="Java.Lang.CharSequence"/></returns>
            [global::System.Obsolete()]
            public Java.Lang.CharSequence GetBreadCrumbShortTitle(Android.Content.Res.Resources arg0)
            {
                return IExecuteWithSignature<Java.Lang.CharSequence>("getBreadCrumbShortTitle", "(Landroid/content/res/Resources;)Ljava/lang/CharSequence;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.Header.html#getBreadCrumbTitle(android.content.res.Resources)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Res.Resources"/></param>
            /// <returns><see cref="Java.Lang.CharSequence"/></returns>
            [global::System.Obsolete()]
            public Java.Lang.CharSequence GetBreadCrumbTitle(Android.Content.Res.Resources arg0)
            {
                return IExecuteWithSignature<Java.Lang.CharSequence>("getBreadCrumbTitle", "(Landroid/content/res/Resources;)Ljava/lang/CharSequence;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.Header.html#getSummary(android.content.res.Resources)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Res.Resources"/></param>
            /// <returns><see cref="Java.Lang.CharSequence"/></returns>
            [global::System.Obsolete()]
            public Java.Lang.CharSequence GetSummary(Android.Content.Res.Resources arg0)
            {
                return IExecuteWithSignature<Java.Lang.CharSequence>("getSummary", "(Landroid/content/res/Resources;)Ljava/lang/CharSequence;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.Header.html#getTitle(android.content.res.Resources)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Res.Resources"/></param>
            /// <returns><see cref="Java.Lang.CharSequence"/></returns>
            [global::System.Obsolete()]
            public Java.Lang.CharSequence GetTitle(Android.Content.Res.Resources arg0)
            {
                return IExecuteWithSignature<Java.Lang.CharSequence>("getTitle", "(Landroid/content/res/Resources;)Ljava/lang/CharSequence;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.Header.html#readFromParcel(android.os.Parcel)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
            [global::System.Obsolete()]
            public void ReadFromParcel(Android.Os.Parcel arg0)
            {
                IExecuteWithSignature("readFromParcel", "(Landroid/os/Parcel;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/preference/PreferenceActivity.Header.html#writeToParcel(android.os.Parcel,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            [global::System.Obsolete()]
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

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}