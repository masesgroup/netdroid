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

namespace Android.Service.Textservice
{
    #region SpellCheckerService
    public partial class SpellCheckerService
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/textservice/SpellCheckerService.html#SERVICE_INTERFACE"/>
        /// </summary>
        public static Java.Lang.String SERVICE_INTERFACE { get { if (!_SERVICE_INTERFACEReady) { _SERVICE_INTERFACEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SERVICE_INTERFACE"); _SERVICE_INTERFACEReady = true; } return _SERVICE_INTERFACEContent; } }
        private static Java.Lang.String _SERVICE_INTERFACEContent = default;
        private static bool _SERVICE_INTERFACEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/textservice/SpellCheckerService.html#createSession()"/>
        /// </summary>
        /// <returns><see cref="Android.Service.Textservice.SpellCheckerService.Session"/></returns>
        public Android.Service.Textservice.SpellCheckerService.Session CreateSession()
        {
            return IExecuteWithSignature<Android.Service.Textservice.SpellCheckerService.Session>("createSession", "()Landroid/service/textservice/SpellCheckerService$Session;");
        }

        #endregion

        #region Nested classes
        #region Session
        public partial class Session
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
            /// <see href="https://developer.android.com/reference/android/service/textservice/SpellCheckerService.Session.html#getBundle()"/> 
            /// </summary>
            public Android.Os.Bundle Bundle
            {
                get { return IExecuteWithSignature<Android.Os.Bundle>("getBundle", "()Landroid/os/Bundle;"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/textservice/SpellCheckerService.Session.html#getLocale()"/> 
            /// </summary>
            public Java.Lang.String Locale
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getLocale", "()Ljava/lang/String;"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/textservice/SpellCheckerService.Session.html#getSupportedAttributes()"/> 
            /// </summary>
            public int SupportedAttributes
            {
                get { return IExecuteWithSignature<int>("getSupportedAttributes", "()I"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/textservice/SpellCheckerService.Session.html#onGetSuggestions(android.view.textservice.TextInfo,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Textservice.TextInfo"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="Android.View.Textservice.SuggestionsInfo"/></returns>
            public Android.View.Textservice.SuggestionsInfo OnGetSuggestions(Android.View.Textservice.TextInfo arg0, int arg1)
            {
                return IExecute<Android.View.Textservice.SuggestionsInfo>("onGetSuggestions", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/textservice/SpellCheckerService.Session.html#onCreate()"/>
            /// </summary>
            public void OnCreate()
            {
                IExecuteWithSignature("onCreate", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/textservice/SpellCheckerService.Session.html#onGetSentenceSuggestionsMultiple(android.view.textservice.TextInfo[],int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Textservice.TextInfo"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="Android.View.Textservice.SentenceSuggestionsInfo"/></returns>
            public Android.View.Textservice.SentenceSuggestionsInfo[] OnGetSentenceSuggestionsMultiple(Android.View.Textservice.TextInfo[] arg0, int arg1)
            {
                return IExecuteArray<Android.View.Textservice.SentenceSuggestionsInfo>("onGetSentenceSuggestionsMultiple", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/textservice/SpellCheckerService.Session.html#onGetSuggestionsMultiple(android.view.textservice.TextInfo[],int,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Textservice.TextInfo"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="bool"/></param>
            /// <returns><see cref="Android.View.Textservice.SuggestionsInfo"/></returns>
            public Android.View.Textservice.SuggestionsInfo[] OnGetSuggestionsMultiple(Android.View.Textservice.TextInfo[] arg0, int arg1, bool arg2)
            {
                return IExecuteArray<Android.View.Textservice.SuggestionsInfo>("onGetSuggestionsMultiple", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/textservice/SpellCheckerService.Session.html#onCancel()"/>
            /// </summary>
            public void OnCancel()
            {
                IExecuteWithSignature("onCancel", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/textservice/SpellCheckerService.Session.html#onClose()"/>
            /// </summary>
            public void OnClose()
            {
                IExecuteWithSignature("onClose", "()V");
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