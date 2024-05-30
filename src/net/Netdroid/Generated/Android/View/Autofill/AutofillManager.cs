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

namespace Android.View.Autofill
{
    #region AutofillManager
    public partial class AutofillManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.html#EXTRA_ASSIST_STRUCTURE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_ASSIST_STRUCTURE { get { if (!_EXTRA_ASSIST_STRUCTUREReady) { _EXTRA_ASSIST_STRUCTUREContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_ASSIST_STRUCTURE"); _EXTRA_ASSIST_STRUCTUREReady = true; } return _EXTRA_ASSIST_STRUCTUREContent; } }
        private static Java.Lang.String _EXTRA_ASSIST_STRUCTUREContent = default;
        private static bool _EXTRA_ASSIST_STRUCTUREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.html#EXTRA_AUTHENTICATION_RESULT"/>
        /// </summary>
        public static Java.Lang.String EXTRA_AUTHENTICATION_RESULT { get { if (!_EXTRA_AUTHENTICATION_RESULTReady) { _EXTRA_AUTHENTICATION_RESULTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_AUTHENTICATION_RESULT"); _EXTRA_AUTHENTICATION_RESULTReady = true; } return _EXTRA_AUTHENTICATION_RESULTContent; } }
        private static Java.Lang.String _EXTRA_AUTHENTICATION_RESULTContent = default;
        private static bool _EXTRA_AUTHENTICATION_RESULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.html#EXTRA_AUTHENTICATION_RESULT_EPHEMERAL_DATASET"/>
        /// </summary>
        public static Java.Lang.String EXTRA_AUTHENTICATION_RESULT_EPHEMERAL_DATASET { get { if (!_EXTRA_AUTHENTICATION_RESULT_EPHEMERAL_DATASETReady) { _EXTRA_AUTHENTICATION_RESULT_EPHEMERAL_DATASETContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_AUTHENTICATION_RESULT_EPHEMERAL_DATASET"); _EXTRA_AUTHENTICATION_RESULT_EPHEMERAL_DATASETReady = true; } return _EXTRA_AUTHENTICATION_RESULT_EPHEMERAL_DATASETContent; } }
        private static Java.Lang.String _EXTRA_AUTHENTICATION_RESULT_EPHEMERAL_DATASETContent = default;
        private static bool _EXTRA_AUTHENTICATION_RESULT_EPHEMERAL_DATASETReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.html#EXTRA_CLIENT_STATE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_CLIENT_STATE { get { if (!_EXTRA_CLIENT_STATEReady) { _EXTRA_CLIENT_STATEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_CLIENT_STATE"); _EXTRA_CLIENT_STATEReady = true; } return _EXTRA_CLIENT_STATEContent; } }
        private static Java.Lang.String _EXTRA_CLIENT_STATEContent = default;
        private static bool _EXTRA_CLIENT_STATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.html#EXTRA_INLINE_SUGGESTIONS_REQUEST"/>
        /// </summary>
        public static Java.Lang.String EXTRA_INLINE_SUGGESTIONS_REQUEST { get { if (!_EXTRA_INLINE_SUGGESTIONS_REQUESTReady) { _EXTRA_INLINE_SUGGESTIONS_REQUESTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_INLINE_SUGGESTIONS_REQUEST"); _EXTRA_INLINE_SUGGESTIONS_REQUESTReady = true; } return _EXTRA_INLINE_SUGGESTIONS_REQUESTContent; } }
        private static Java.Lang.String _EXTRA_INLINE_SUGGESTIONS_REQUESTContent = default;
        private static bool _EXTRA_INLINE_SUGGESTIONS_REQUESTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.html#getAutofillServiceComponentName()"/> 
        /// </summary>
        public Android.Content.ComponentName AutofillServiceComponentName
        {
            get { return IExecuteWithSignature<Android.Content.ComponentName>("getAutofillServiceComponentName", "()Landroid/content/ComponentName;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.html#getAvailableFieldClassificationAlgorithms()"/> 
        /// </summary>
        public Java.Util.List<Java.Lang.String> AvailableFieldClassificationAlgorithms
        {
            get { return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("getAvailableFieldClassificationAlgorithms", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.html#getDefaultFieldClassificationAlgorithm()"/> 
        /// </summary>
        public Java.Lang.String DefaultFieldClassificationAlgorithm
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getDefaultFieldClassificationAlgorithm", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.html#getNextAutofillId()"/> 
        /// </summary>
        public Android.View.Autofill.AutofillId NextAutofillId
        {
            get { return IExecuteWithSignature<Android.View.Autofill.AutofillId>("getNextAutofillId", "()Landroid/view/autofill/AutofillId;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.html#getUserData()"/> <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.html#setUserData(android.service.autofill.UserData)"/>
        /// </summary>
        public Android.Service.Autofill.UserData UserData
        {
            get { return IExecuteWithSignature<Android.Service.Autofill.UserData>("getUserData", "()Landroid/service/autofill/UserData;"); } set { IExecuteWithSignature("setUserData", "(Landroid/service/autofill/UserData;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.html#getUserDataId()"/> 
        /// </summary>
        public Java.Lang.String UserDataId
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getUserDataId", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.html#hasEnabledAutofillServices()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasEnabledAutofillServices()
        {
            return IExecuteWithSignature<bool>("hasEnabledAutofillServices", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.html#isAutofillSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAutofillSupported()
        {
            return IExecuteWithSignature<bool>("isAutofillSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.html#isEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEnabled()
        {
            return IExecuteWithSignature<bool>("isEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.html#isFieldClassificationEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFieldClassificationEnabled()
        {
            return IExecuteWithSignature<bool>("isFieldClassificationEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.html#showAutofillDialog(android.view.View,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ShowAutofillDialog(Android.View.View arg0, int arg1)
        {
            return IExecute<bool>("showAutofillDialog", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.html#showAutofillDialog(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ShowAutofillDialog(Android.View.View arg0)
        {
            return IExecuteWithSignature<bool>("showAutofillDialog", "(Landroid/view/View;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.html#cancel()"/>
        /// </summary>
        public void Cancel()
        {
            IExecuteWithSignature("cancel", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.html#commit()"/>
        /// </summary>
        public void Commit()
        {
            IExecuteWithSignature("commit", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.html#disableAutofillServices()"/>
        /// </summary>
        public void DisableAutofillServices()
        {
            IExecuteWithSignature("disableAutofillServices", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.html#notifyValueChanged(android.view.View,int,android.view.autofill.AutofillValue)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.View.Autofill.AutofillValue"/></param>
        public void NotifyValueChanged(Android.View.View arg0, int arg1, Android.View.Autofill.AutofillValue arg2)
        {
            IExecute("notifyValueChanged", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.html#notifyValueChanged(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        public void NotifyValueChanged(Android.View.View arg0)
        {
            IExecuteWithSignature("notifyValueChanged", "(Landroid/view/View;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.html#notifyViewClicked(android.view.View,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void NotifyViewClicked(Android.View.View arg0, int arg1)
        {
            IExecute("notifyViewClicked", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.html#notifyViewClicked(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        public void NotifyViewClicked(Android.View.View arg0)
        {
            IExecuteWithSignature("notifyViewClicked", "(Landroid/view/View;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.html#notifyViewEntered(android.view.View,int,android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.Rect"/></param>
        public void NotifyViewEntered(Android.View.View arg0, int arg1, Android.Graphics.Rect arg2)
        {
            IExecute("notifyViewEntered", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.html#notifyViewEntered(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        public void NotifyViewEntered(Android.View.View arg0)
        {
            IExecuteWithSignature("notifyViewEntered", "(Landroid/view/View;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.html#notifyViewExited(android.view.View,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void NotifyViewExited(Android.View.View arg0, int arg1)
        {
            IExecute("notifyViewExited", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.html#notifyViewExited(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        public void NotifyViewExited(Android.View.View arg0)
        {
            IExecuteWithSignature("notifyViewExited", "(Landroid/view/View;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.html#notifyViewVisibilityChanged(android.view.View,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void NotifyViewVisibilityChanged(Android.View.View arg0, bool arg1)
        {
            IExecute("notifyViewVisibilityChanged", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.html#notifyViewVisibilityChanged(android.view.View,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public void NotifyViewVisibilityChanged(Android.View.View arg0, int arg1, bool arg2)
        {
            IExecute("notifyViewVisibilityChanged", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.html#notifyVirtualViewsReady(android.view.View,android.util.SparseArray)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Util.SparseArray"/></param>
        public void NotifyVirtualViewsReady(Android.View.View arg0, Android.Util.SparseArray<Android.View.Autofill.VirtualViewFillInfo> arg1)
        {
            IExecute("notifyVirtualViewsReady", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.html#registerCallback(android.view.autofill.AutofillManager.AutofillCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Autofill.AutofillManager.AutofillCallback"/></param>
        public void RegisterCallback(Android.View.Autofill.AutofillManager.AutofillCallback arg0)
        {
            IExecuteWithSignature("registerCallback", "(Landroid/view/autofill/AutofillManager$AutofillCallback;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.html#requestAutofill(android.view.View,int,android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.Rect"/></param>
        public void RequestAutofill(Android.View.View arg0, int arg1, Android.Graphics.Rect arg2)
        {
            IExecute("requestAutofill", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.html#requestAutofill(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        public void RequestAutofill(Android.View.View arg0)
        {
            IExecuteWithSignature("requestAutofill", "(Landroid/view/View;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.html#unregisterCallback(android.view.autofill.AutofillManager.AutofillCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Autofill.AutofillManager.AutofillCallback"/></param>
        public void UnregisterCallback(Android.View.Autofill.AutofillManager.AutofillCallback arg0)
        {
            IExecuteWithSignature("unregisterCallback", "(Landroid/view/autofill/AutofillManager$AutofillCallback;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region AutofillCallback
        public partial class AutofillCallback
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.AutofillCallback.html#EVENT_INPUT_HIDDEN"/>
            /// </summary>
            public static int EVENT_INPUT_HIDDEN { get { if (!_EVENT_INPUT_HIDDENReady) { _EVENT_INPUT_HIDDENContent = SGetField<int>(LocalBridgeClazz, "EVENT_INPUT_HIDDEN"); _EVENT_INPUT_HIDDENReady = true; } return _EVENT_INPUT_HIDDENContent; } }
            private static int _EVENT_INPUT_HIDDENContent = default;
            private static bool _EVENT_INPUT_HIDDENReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.AutofillCallback.html#EVENT_INPUT_SHOWN"/>
            /// </summary>
            public static int EVENT_INPUT_SHOWN { get { if (!_EVENT_INPUT_SHOWNReady) { _EVENT_INPUT_SHOWNContent = SGetField<int>(LocalBridgeClazz, "EVENT_INPUT_SHOWN"); _EVENT_INPUT_SHOWNReady = true; } return _EVENT_INPUT_SHOWNContent; } }
            private static int _EVENT_INPUT_SHOWNContent = default;
            private static bool _EVENT_INPUT_SHOWNReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.AutofillCallback.html#EVENT_INPUT_UNAVAILABLE"/>
            /// </summary>
            public static int EVENT_INPUT_UNAVAILABLE { get { if (!_EVENT_INPUT_UNAVAILABLEReady) { _EVENT_INPUT_UNAVAILABLEContent = SGetField<int>(LocalBridgeClazz, "EVENT_INPUT_UNAVAILABLE"); _EVENT_INPUT_UNAVAILABLEReady = true; } return _EVENT_INPUT_UNAVAILABLEContent; } }
            private static int _EVENT_INPUT_UNAVAILABLEContent = default;
            private static bool _EVENT_INPUT_UNAVAILABLEReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.AutofillCallback.html#onAutofillEvent(android.view.View,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.View"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            public void OnAutofillEvent(Android.View.View arg0, int arg1, int arg2)
            {
                IExecute("onAutofillEvent", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/autofill/AutofillManager.AutofillCallback.html#onAutofillEvent(android.view.View,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.View"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void OnAutofillEvent(Android.View.View arg0, int arg1)
            {
                IExecute("onAutofillEvent", arg0, arg1);
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