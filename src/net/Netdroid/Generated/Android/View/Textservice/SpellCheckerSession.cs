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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.View.Textservice
{
    #region SpellCheckerSession declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerSession.html"/>
    /// </summary>
    public partial class SpellCheckerSession : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SpellCheckerSession>
    {
        const string _bridgeClassName = "android.view.textservice.SpellCheckerSession";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SpellCheckerSession() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SpellCheckerSession(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
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
        #region SpellCheckerSessionListener declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerSession.SpellCheckerSessionListener.html"/>
        /// </summary>
        public partial class SpellCheckerSessionListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public SpellCheckerSessionListener() { InitializeHandlers(); }
        
            const string _bridgeClassName = "org.mases.netdroid.generated.android.view.textservice.SpellCheckerSession_SpellCheckerSessionListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
            
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
        
        
            // TODO: complete the class
        
        }
        #endregion
        
        #region SpellCheckerSessionListenerDirect declaration
        /// <summary>
        /// Direct override of <see cref="SpellCheckerSessionListener"/> or its generic type if there is one
        /// </summary>
        public partial class SpellCheckerSessionListenerDirect : SpellCheckerSessionListener
        {
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
            /// </summary>
            public override bool AutoInit => false;
        
            /// <inheritdoc />
            protected override void InitializeHandlers() { }
        
            const string _bridgeClassName = "android.view.textservice.SpellCheckerSession$SpellCheckerSessionListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
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
            public override bool IsBridgeInterface => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;
        }
        #endregion

        #region SpellCheckerSessionParams declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerSession.SpellCheckerSessionParams.html"/>
        /// </summary>
        public partial class SpellCheckerSessionParams : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SpellCheckerSessionParams>
        {
            const string _bridgeClassName = "android.view.textservice.SpellCheckerSession$SpellCheckerSessionParams";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public SpellCheckerSessionParams() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public SpellCheckerSessionParams(params object[] args) : base(args) { }
        
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => false;
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
            #region Builder declaration
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerSession.SpellCheckerSessionParams.Builder.html"/>
            /// </summary>
            public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
            {
                const string _bridgeClassName = "android.view.textservice.SpellCheckerSession$SpellCheckerSessionParams$Builder";
                /// <summary>
                /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
                /// </summary>
                public Builder() { }
                /// <summary>
                /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
                /// </summary>
                public Builder(params object[] args) : base(args) { }
            
                private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
                private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
            
                /// <summary>
                /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
                /// </summary>
                public override string BridgeClassName => _bridgeClassName;
                /// <summary>
                /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
                /// </summary>
                public override bool IsBridgeAbstract => false;
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

    
    }
    #endregion

    #region SpellCheckerSession implementation
    public partial class SpellCheckerSession
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerSession.html#SERVICE_META_DATA"/>
        /// </summary>
        public static Java.Lang.String SERVICE_META_DATA { get { if (!_SERVICE_META_DATAReady) { _SERVICE_META_DATAContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SERVICE_META_DATA"); _SERVICE_META_DATAReady = true; } return _SERVICE_META_DATAContent; } }
        private static Java.Lang.String _SERVICE_META_DATAContent = default;
        private static bool _SERVICE_META_DATAReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerSession.html#getSpellChecker()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Textservice.SpellCheckerInfo"/></returns>
        public Android.View.Textservice.SpellCheckerInfo GetSpellChecker()
        {
            return IExecuteWithSignature<Android.View.Textservice.SpellCheckerInfo>("getSpellChecker", "()Landroid/view/textservice/SpellCheckerInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerSession.html#isSessionDisconnected()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSessionDisconnected()
        {
            return IExecuteWithSignature<bool>("isSessionDisconnected", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerSession.html#cancel()"/>
        /// </summary>
        public void Cancel()
        {
            IExecuteWithSignature("cancel", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerSession.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerSession.html#getSentenceSuggestions(android.view.textservice.TextInfo[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Textservice.TextInfo"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void GetSentenceSuggestions(Android.View.Textservice.TextInfo[] arg0, int arg1)
        {
            IExecuteWithSignature("getSentenceSuggestions", "([Landroid/view/textservice/TextInfo;I)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerSession.html#getSuggestions(android.view.textservice.TextInfo,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Textservice.TextInfo"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void GetSuggestions(Android.View.Textservice.TextInfo arg0, int arg1)
        {
            IExecuteWithSignature("getSuggestions", "(Landroid/view/textservice/TextInfo;I)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerSession.html#getSuggestions(android.view.textservice.TextInfo[],int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Textservice.TextInfo"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void GetSuggestions(Android.View.Textservice.TextInfo[] arg0, int arg1, bool arg2)
        {
            IExecuteWithSignature("getSuggestions", "([Landroid/view/textservice/TextInfo;IZ)V", arg0, arg1, arg2);
        }
    
        #endregion
    
        #region Nested classes
        #region SpellCheckerSessionListener implementation
        public partial class SpellCheckerSessionListener
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
            /// Handlers initializer for <see cref="SpellCheckerSessionListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onGetSentenceSuggestions", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnGetSentenceSuggestionsEventHandler));
                AddEventHandler("onGetSuggestions", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnGetSuggestionsEventHandler));

            }
            
            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerSession.SpellCheckerSessionListener.html#onGetSentenceSuggestions(android.view.textservice.SentenceSuggestionsInfo[])"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnGetSentenceSuggestions"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.View.Textservice.SentenceSuggestionsInfo[]> OnOnGetSentenceSuggestions { get; set; } = null;
            
            bool hasOverrideOnGetSentenceSuggestions = true;
            void OnGetSentenceSuggestionsEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnGetSentenceSuggestions = true;
                var methodToExecute = (OnOnGetSentenceSuggestions != null) ? OnOnGetSentenceSuggestions : OnGetSentenceSuggestions;
                methodToExecute.Invoke(data.EventData.GetAt<Android.View.Textservice.SentenceSuggestionsInfo[]>(0));
                data.EventData.TypedEventData.HasOverride = hasOverrideOnGetSentenceSuggestions;
            }
            
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerSession.SpellCheckerSessionListener.html#onGetSentenceSuggestions(android.view.textservice.SentenceSuggestionsInfo[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Textservice.SentenceSuggestionsInfo"/></param>
            public virtual void OnGetSentenceSuggestions(Android.View.Textservice.SentenceSuggestionsInfo[] arg0)
            {
                hasOverrideOnGetSentenceSuggestions = false;
            }
            
            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerSession.SpellCheckerSessionListener.html#onGetSuggestions(android.view.textservice.SuggestionsInfo[])"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnGetSuggestions"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.View.Textservice.SuggestionsInfo[]> OnOnGetSuggestions { get; set; } = null;
            
            bool hasOverrideOnGetSuggestions = true;
            void OnGetSuggestionsEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnGetSuggestions = true;
                var methodToExecute = (OnOnGetSuggestions != null) ? OnOnGetSuggestions : OnGetSuggestions;
                methodToExecute.Invoke(data.EventData.GetAt<Android.View.Textservice.SuggestionsInfo[]>(0));
                data.EventData.TypedEventData.HasOverride = hasOverrideOnGetSuggestions;
            }
            
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerSession.SpellCheckerSessionListener.html#onGetSuggestions(android.view.textservice.SuggestionsInfo[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Textservice.SuggestionsInfo"/></param>
            public virtual void OnGetSuggestions(Android.View.Textservice.SuggestionsInfo[] arg0)
            {
                hasOverrideOnGetSuggestions = false;
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region SpellCheckerSessionListenerDirect implementation
        public partial class SpellCheckerSessionListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerSession.SpellCheckerSessionListener.html#onGetSentenceSuggestions(android.view.textservice.SentenceSuggestionsInfo[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Textservice.SentenceSuggestionsInfo"/></param>
            public override void OnGetSentenceSuggestions(Android.View.Textservice.SentenceSuggestionsInfo[] arg0)
            {
                IExecuteWithSignature("onGetSentenceSuggestions", "([Landroid/view/textservice/SentenceSuggestionsInfo;)V", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerSession.SpellCheckerSessionListener.html#onGetSuggestions(android.view.textservice.SuggestionsInfo[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Textservice.SuggestionsInfo"/></param>
            public override void OnGetSuggestions(Android.View.Textservice.SuggestionsInfo[] arg0)
            {
                IExecuteWithSignature("onGetSuggestions", "([Landroid/view/textservice/SuggestionsInfo;)V", new object[] { arg0 });
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region SpellCheckerSessionParams implementation
        public partial class SpellCheckerSessionParams
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
            /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerSession.SpellCheckerSessionParams.html#getExtras()"/>
            /// </summary>
            /// <returns><see cref="Android.Os.Bundle"/></returns>
            public Android.Os.Bundle GetExtras()
            {
                return IExecuteWithSignature<Android.Os.Bundle>("getExtras", "()Landroid/os/Bundle;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerSession.SpellCheckerSessionParams.html#shouldReferToSpellCheckerLanguageSettings()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool ShouldReferToSpellCheckerLanguageSettings()
            {
                return IExecuteWithSignature<bool>("shouldReferToSpellCheckerLanguageSettings", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerSession.SpellCheckerSessionParams.html#getSupportedAttributes()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetSupportedAttributes()
            {
                return IExecuteWithSignature<int>("getSupportedAttributes", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerSession.SpellCheckerSessionParams.html#getLocale()"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Locale"/></returns>
            public Java.Util.Locale GetLocale()
            {
                return IExecuteWithSignature<Java.Util.Locale>("getLocale", "()Ljava/util/Locale;");
            }
        
            #endregion
        
            #region Nested classes
            #region Builder implementation
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
                /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerSession.SpellCheckerSessionParams.Builder.html#build()"/>
                /// </summary>
                /// <returns><see cref="Android.View.Textservice.SpellCheckerSession.SpellCheckerSessionParams"/></returns>
                public Android.View.Textservice.SpellCheckerSession.SpellCheckerSessionParams Build()
                {
                    return IExecute<Android.View.Textservice.SpellCheckerSession.SpellCheckerSessionParams>("build");
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerSession.SpellCheckerSessionParams.Builder.html#setExtras(android.os.Bundle)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
                /// <returns><see cref="Android.View.Textservice.SpellCheckerSession.SpellCheckerSessionParams.Builder"/></returns>
                public Android.View.Textservice.SpellCheckerSession.SpellCheckerSessionParams.Builder SetExtras(Android.Os.Bundle arg0)
                {
                    return IExecute<Android.View.Textservice.SpellCheckerSession.SpellCheckerSessionParams.Builder>("setExtras", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerSession.SpellCheckerSessionParams.Builder.html#setLocale(java.util.Locale)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
                /// <returns><see cref="Android.View.Textservice.SpellCheckerSession.SpellCheckerSessionParams.Builder"/></returns>
                public Android.View.Textservice.SpellCheckerSession.SpellCheckerSessionParams.Builder SetLocale(Java.Util.Locale arg0)
                {
                    return IExecute<Android.View.Textservice.SpellCheckerSession.SpellCheckerSessionParams.Builder>("setLocale", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerSession.SpellCheckerSessionParams.Builder.html#setShouldReferToSpellCheckerLanguageSettings(boolean)"/>
                /// </summary>
                /// <param name="arg0"><see cref="bool"/></param>
                /// <returns><see cref="Android.View.Textservice.SpellCheckerSession.SpellCheckerSessionParams.Builder"/></returns>
                public Android.View.Textservice.SpellCheckerSession.SpellCheckerSessionParams.Builder SetShouldReferToSpellCheckerLanguageSettings(bool arg0)
                {
                    return IExecute<Android.View.Textservice.SpellCheckerSession.SpellCheckerSessionParams.Builder>("setShouldReferToSpellCheckerLanguageSettings", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerSession.SpellCheckerSessionParams.Builder.html#setSupportedAttributes(int)"/>
                /// </summary>
                /// <param name="arg0"><see cref="int"/></param>
                /// <returns><see cref="Android.View.Textservice.SpellCheckerSession.SpellCheckerSessionParams.Builder"/></returns>
                public Android.View.Textservice.SpellCheckerSession.SpellCheckerSessionParams.Builder SetSupportedAttributes(int arg0)
                {
                    return IExecute<Android.View.Textservice.SpellCheckerSession.SpellCheckerSessionParams.Builder>("setSupportedAttributes", arg0);
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