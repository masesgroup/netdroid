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

namespace Android.Nfc.Cardemulation
{
    #region CardEmulation
    public partial class CardEmulation
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/CardEmulation.html#SELECTION_MODE_ALWAYS_ASK"/>
        /// </summary>
        public static int SELECTION_MODE_ALWAYS_ASK { get { if (!_SELECTION_MODE_ALWAYS_ASKReady) { _SELECTION_MODE_ALWAYS_ASKContent = SGetField<int>(LocalBridgeClazz, "SELECTION_MODE_ALWAYS_ASK"); _SELECTION_MODE_ALWAYS_ASKReady = true; } return _SELECTION_MODE_ALWAYS_ASKContent; } }
        private static int _SELECTION_MODE_ALWAYS_ASKContent = default;
        private static bool _SELECTION_MODE_ALWAYS_ASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/CardEmulation.html#SELECTION_MODE_ASK_IF_CONFLICT"/>
        /// </summary>
        public static int SELECTION_MODE_ASK_IF_CONFLICT { get { if (!_SELECTION_MODE_ASK_IF_CONFLICTReady) { _SELECTION_MODE_ASK_IF_CONFLICTContent = SGetField<int>(LocalBridgeClazz, "SELECTION_MODE_ASK_IF_CONFLICT"); _SELECTION_MODE_ASK_IF_CONFLICTReady = true; } return _SELECTION_MODE_ASK_IF_CONFLICTContent; } }
        private static int _SELECTION_MODE_ASK_IF_CONFLICTContent = default;
        private static bool _SELECTION_MODE_ASK_IF_CONFLICTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/CardEmulation.html#SELECTION_MODE_PREFER_DEFAULT"/>
        /// </summary>
        public static int SELECTION_MODE_PREFER_DEFAULT { get { if (!_SELECTION_MODE_PREFER_DEFAULTReady) { _SELECTION_MODE_PREFER_DEFAULTContent = SGetField<int>(LocalBridgeClazz, "SELECTION_MODE_PREFER_DEFAULT"); _SELECTION_MODE_PREFER_DEFAULTReady = true; } return _SELECTION_MODE_PREFER_DEFAULTContent; } }
        private static int _SELECTION_MODE_PREFER_DEFAULTContent = default;
        private static bool _SELECTION_MODE_PREFER_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/CardEmulation.html#ACTION_CHANGE_DEFAULT"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String ACTION_CHANGE_DEFAULT { get { if (!_ACTION_CHANGE_DEFAULTReady) { _ACTION_CHANGE_DEFAULTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_CHANGE_DEFAULT"); _ACTION_CHANGE_DEFAULTReady = true; } return _ACTION_CHANGE_DEFAULTContent; } }
        private static Java.Lang.String _ACTION_CHANGE_DEFAULTContent = default;
        private static bool _ACTION_CHANGE_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/CardEmulation.html#CATEGORY_OTHER"/>
        /// </summary>
        public static Java.Lang.String CATEGORY_OTHER { get { if (!_CATEGORY_OTHERReady) { _CATEGORY_OTHERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CATEGORY_OTHER"); _CATEGORY_OTHERReady = true; } return _CATEGORY_OTHERContent; } }
        private static Java.Lang.String _CATEGORY_OTHERContent = default;
        private static bool _CATEGORY_OTHERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/CardEmulation.html#CATEGORY_PAYMENT"/>
        /// </summary>
        public static Java.Lang.String CATEGORY_PAYMENT { get { if (!_CATEGORY_PAYMENTReady) { _CATEGORY_PAYMENTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CATEGORY_PAYMENT"); _CATEGORY_PAYMENTReady = true; } return _CATEGORY_PAYMENTContent; } }
        private static Java.Lang.String _CATEGORY_PAYMENTContent = default;
        private static bool _CATEGORY_PAYMENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/CardEmulation.html#EXTRA_CATEGORY"/>
        /// </summary>
        public static Java.Lang.String EXTRA_CATEGORY { get { if (!_EXTRA_CATEGORYReady) { _EXTRA_CATEGORYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_CATEGORY"); _EXTRA_CATEGORYReady = true; } return _EXTRA_CATEGORYContent; } }
        private static Java.Lang.String _EXTRA_CATEGORYContent = default;
        private static bool _EXTRA_CATEGORYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/CardEmulation.html#EXTRA_SERVICE_COMPONENT"/>
        /// </summary>
        public static Java.Lang.String EXTRA_SERVICE_COMPONENT { get { if (!_EXTRA_SERVICE_COMPONENTReady) { _EXTRA_SERVICE_COMPONENTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_SERVICE_COMPONENT"); _EXTRA_SERVICE_COMPONENTReady = true; } return _EXTRA_SERVICE_COMPONENTContent; } }
        private static Java.Lang.String _EXTRA_SERVICE_COMPONENTContent = default;
        private static bool _EXTRA_SERVICE_COMPONENTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/CardEmulation.html#getInstance(android.nfc.NfcAdapter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Nfc.NfcAdapter"/></param>
        /// <returns><see cref="Android.Nfc.Cardemulation.CardEmulation"/></returns>
        public static Android.Nfc.Cardemulation.CardEmulation GetInstance(Android.Nfc.NfcAdapter arg0)
        {
            return SExecuteWithSignature<Android.Nfc.Cardemulation.CardEmulation>(LocalBridgeClazz, "getInstance", "(Landroid/nfc/NfcAdapter;)Landroid/nfc/cardemulation/CardEmulation;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/CardEmulation.html#categoryAllowsForegroundPreference(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CategoryAllowsForegroundPreference(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("categoryAllowsForegroundPreference", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/CardEmulation.html#isDefaultServiceForAid(android.content.ComponentName,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsDefaultServiceForAid(Android.Content.ComponentName arg0, Java.Lang.String arg1)
        {
            return IExecute<bool>("isDefaultServiceForAid", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/CardEmulation.html#isDefaultServiceForCategory(android.content.ComponentName,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsDefaultServiceForCategory(Android.Content.ComponentName arg0, Java.Lang.String arg1)
        {
            return IExecute<bool>("isDefaultServiceForCategory", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/CardEmulation.html#registerAidsForService(android.content.ComponentName,java.lang.String,java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RegisterAidsForService(Android.Content.ComponentName arg0, Java.Lang.String arg1, Java.Util.List<Java.Lang.String> arg2)
        {
            return IExecute<bool>("registerAidsForService", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/CardEmulation.html#registerPollingLoopFilterForService(android.content.ComponentName,java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RegisterPollingLoopFilterForService(Android.Content.ComponentName arg0, Java.Lang.String arg1, bool arg2)
        {
            return IExecute<bool>("registerPollingLoopFilterForService", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/CardEmulation.html#registerPollingLoopPatternFilterForService(android.content.ComponentName,java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RegisterPollingLoopPatternFilterForService(Android.Content.ComponentName arg0, Java.Lang.String arg1, bool arg2)
        {
            return IExecute<bool>("registerPollingLoopPatternFilterForService", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/CardEmulation.html#removeAidsForService(android.content.ComponentName,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveAidsForService(Android.Content.ComponentName arg0, Java.Lang.String arg1)
        {
            return IExecute<bool>("removeAidsForService", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/CardEmulation.html#removePollingLoopFilterForService(android.content.ComponentName,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemovePollingLoopFilterForService(Android.Content.ComponentName arg0, Java.Lang.String arg1)
        {
            return IExecute<bool>("removePollingLoopFilterForService", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/CardEmulation.html#removePollingLoopPatternFilterForService(android.content.ComponentName,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemovePollingLoopPatternFilterForService(Android.Content.ComponentName arg0, Java.Lang.String arg1)
        {
            return IExecute<bool>("removePollingLoopPatternFilterForService", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/CardEmulation.html#setOffHostForService(android.content.ComponentName,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetOffHostForService(Android.Content.ComponentName arg0, Java.Lang.String arg1)
        {
            return IExecute<bool>("setOffHostForService", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/CardEmulation.html#setPreferredService(android.app.Activity,android.content.ComponentName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Activity"/></param>
        /// <param name="arg1"><see cref="Android.Content.ComponentName"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetPreferredService(Android.App.Activity arg0, Android.Content.ComponentName arg1)
        {
            return IExecute<bool>("setPreferredService", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/CardEmulation.html#setShouldDefaultToObserveModeForService(android.content.ComponentName,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetShouldDefaultToObserveModeForService(Android.Content.ComponentName arg0, bool arg1)
        {
            return IExecute<bool>("setShouldDefaultToObserveModeForService", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/CardEmulation.html#supportsAidPrefixRegistration()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool SupportsAidPrefixRegistration()
        {
            return IExecuteWithSignature<bool>("supportsAidPrefixRegistration", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/CardEmulation.html#unsetOffHostForService(android.content.ComponentName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool UnsetOffHostForService(Android.Content.ComponentName arg0)
        {
            return IExecuteWithSignature<bool>("unsetOffHostForService", "(Landroid/content/ComponentName;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/CardEmulation.html#unsetPreferredService(android.app.Activity)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Activity"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool UnsetPreferredService(Android.App.Activity arg0)
        {
            return IExecuteWithSignature<bool>("unsetPreferredService", "(Landroid/app/Activity;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/CardEmulation.html#getSelectionModeForCategory(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetSelectionModeForCategory(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<int>("getSelectionModeForCategory", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/CardEmulation.html#getDescriptionForPreferredPaymentService()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetDescriptionForPreferredPaymentService()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getDescriptionForPreferredPaymentService", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/CardEmulation.html#getRouteDestinationForPreferredPaymentService()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetRouteDestinationForPreferredPaymentService()
        {
            return IExecuteWithSignature<Java.Lang.String>("getRouteDestinationForPreferredPaymentService", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/CardEmulation.html#getAidsForPreferredPaymentService()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Lang.String> GetAidsForPreferredPaymentService()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("getAidsForPreferredPaymentService", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/CardEmulation.html#getAidsForService(android.content.ComponentName,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Lang.String> GetAidsForService(Android.Content.ComponentName arg0, Java.Lang.String arg1)
        {
            return IExecute<Java.Util.List<Java.Lang.String>>("getAidsForService", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}