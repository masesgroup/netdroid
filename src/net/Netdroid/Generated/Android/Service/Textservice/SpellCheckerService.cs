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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Service.Textservice
{
    #region SpellCheckerService declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/service/textservice/SpellCheckerService.html"/>
    /// </summary>
    public partial class SpellCheckerService : Android.App.Service
    {
        const string _bridgeClassName = "android.service.textservice.SpellCheckerService";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("SpellCheckerService class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SpellCheckerService() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("SpellCheckerService class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SpellCheckerService(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
        #region Session declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/textservice/SpellCheckerService.Session.html"/>
        /// </summary>
        public partial class Session : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Session>
        {
            const string _bridgeClassName = "android.service.textservice.SpellCheckerService$Session";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("Session class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public Session() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("Session class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public Session(params object[] args) : base(args) { }

            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
            /// </summary>
            public override bool IsBridgeCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
            /// </summary>
            public override bool IsBridgeInterface => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region SpellCheckerService implementation
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
        #region Session implementation
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
            /// <see href="https://developer.android.com/reference/android/service/textservice/SpellCheckerService.Session.html#onGetSuggestions(android.view.textservice.TextInfo,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Textservice.TextInfo"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="Android.View.Textservice.SuggestionsInfo"/></returns>
            public Android.View.Textservice.SuggestionsInfo OnGetSuggestions(Android.View.Textservice.TextInfo arg0, int arg1)
            {
                return IExecuteWithSignature<Android.View.Textservice.SuggestionsInfo>("onGetSuggestions", "(Landroid/view/textservice/TextInfo;I)Landroid/view/textservice/SuggestionsInfo;", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/textservice/SpellCheckerService.Session.html#onCreate()"/>
            /// </summary>
            public void OnCreate()
            {
                IExecuteWithSignature("onCreate", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/textservice/SpellCheckerService.Session.html#getBundle()"/>
            /// </summary>
            /// <returns><see cref="Android.Os.Bundle"/></returns>
            public Android.Os.Bundle GetBundle()
            {
                return IExecuteWithSignature<Android.Os.Bundle>("getBundle", "()Landroid/os/Bundle;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/textservice/SpellCheckerService.Session.html#onGetSentenceSuggestionsMultiple(android.view.textservice.TextInfo[],int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Textservice.TextInfo"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="Android.View.Textservice.SentenceSuggestionsInfo"/></returns>
            public Android.View.Textservice.SentenceSuggestionsInfo[] OnGetSentenceSuggestionsMultiple(Android.View.Textservice.TextInfo[] arg0, int arg1)
            {
                return IExecuteWithSignatureArray<Android.View.Textservice.SentenceSuggestionsInfo>("onGetSentenceSuggestionsMultiple", "([Landroid/view/textservice/TextInfo;I)[Landroid/view/textservice/SentenceSuggestionsInfo;", arg0, arg1);
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
                return IExecuteWithSignatureArray<Android.View.Textservice.SuggestionsInfo>("onGetSuggestionsMultiple", "([Landroid/view/textservice/TextInfo;IZ)[Landroid/view/textservice/SuggestionsInfo;", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/textservice/SpellCheckerService.Session.html#getSupportedAttributes()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetSupportedAttributes()
            {
                return IExecuteWithSignature<int>("getSupportedAttributes", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/textservice/SpellCheckerService.Session.html#getLocale()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetLocale()
            {
                return IExecuteWithSignature<Java.Lang.String>("getLocale", "()Ljava/lang/String;");
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