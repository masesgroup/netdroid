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

namespace Android.View.Translation
{
    #region TranslationRequest declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/view/translation/TranslationRequest.html"/>
    /// </summary>
    public partial class TranslationRequest : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.view.translation.TranslationRequest";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TranslationRequest() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TranslationRequest(params object[] args) : base(args) { }
    
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
        #region Builder declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationRequest.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.view.translation.TranslationRequest$Builder";
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

    #region TranslationRequest implementation
    public partial class TranslationRequest
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationRequest.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationRequest.html#FLAG_DICTIONARY_RESULT"/>
        /// </summary>
        public static int FLAG_DICTIONARY_RESULT { get { if (!_FLAG_DICTIONARY_RESULTReady) { _FLAG_DICTIONARY_RESULTContent = SGetField<int>(LocalBridgeClazz, "FLAG_DICTIONARY_RESULT"); _FLAG_DICTIONARY_RESULTReady = true; } return _FLAG_DICTIONARY_RESULTContent; } }
        private static int _FLAG_DICTIONARY_RESULTContent = default;
        private static bool _FLAG_DICTIONARY_RESULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationRequest.html#FLAG_PARTIAL_RESPONSES"/>
        /// </summary>
        public static int FLAG_PARTIAL_RESPONSES { get { if (!_FLAG_PARTIAL_RESPONSESReady) { _FLAG_PARTIAL_RESPONSESContent = SGetField<int>(LocalBridgeClazz, "FLAG_PARTIAL_RESPONSES"); _FLAG_PARTIAL_RESPONSESReady = true; } return _FLAG_PARTIAL_RESPONSESContent; } }
        private static int _FLAG_PARTIAL_RESPONSESContent = default;
        private static bool _FLAG_PARTIAL_RESPONSESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationRequest.html#FLAG_TRANSLATION_RESULT"/>
        /// </summary>
        public static int FLAG_TRANSLATION_RESULT { get { if (!_FLAG_TRANSLATION_RESULTReady) { _FLAG_TRANSLATION_RESULTContent = SGetField<int>(LocalBridgeClazz, "FLAG_TRANSLATION_RESULT"); _FLAG_TRANSLATION_RESULTReady = true; } return _FLAG_TRANSLATION_RESULTContent; } }
        private static int _FLAG_TRANSLATION_RESULTContent = default;
        private static bool _FLAG_TRANSLATION_RESULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationRequest.html#FLAG_TRANSLITERATION_RESULT"/>
        /// </summary>
        public static int FLAG_TRANSLITERATION_RESULT { get { if (!_FLAG_TRANSLITERATION_RESULTReady) { _FLAG_TRANSLITERATION_RESULTContent = SGetField<int>(LocalBridgeClazz, "FLAG_TRANSLITERATION_RESULT"); _FLAG_TRANSLITERATION_RESULTReady = true; } return _FLAG_TRANSLITERATION_RESULTContent; } }
        private static int _FLAG_TRANSLITERATION_RESULTContent = default;
        private static bool _FLAG_TRANSLITERATION_RESULTReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationRequest.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationRequest.html#getFlags()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetFlags()
        {
            return IExecuteWithSignature<int>("getFlags", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationRequest.html#getTranslationRequestValues()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.View.Translation.TranslationRequestValue> GetTranslationRequestValues()
        {
            return IExecuteWithSignature<Java.Util.List<Android.View.Translation.TranslationRequestValue>>("getTranslationRequestValues", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationRequest.html#getViewTranslationRequests()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.View.Translation.ViewTranslationRequest> GetViewTranslationRequests()
        {
            return IExecuteWithSignature<Java.Util.List<Android.View.Translation.ViewTranslationRequest>>("getViewTranslationRequests", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationRequest.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
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
            /// <see href="https://developer.android.com/reference/android/view/translation/TranslationRequest.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.View.Translation.TranslationRequest"/></returns>
            public Android.View.Translation.TranslationRequest Build()
            {
                return IExecuteWithSignature<Android.View.Translation.TranslationRequest>("build", "()Landroid/view/translation/TranslationRequest;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/translation/TranslationRequest.Builder.html#setFlags(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.View.Translation.TranslationRequest.Builder"/></returns>
            public Android.View.Translation.TranslationRequest.Builder SetFlags(int arg0)
            {
                return IExecuteWithSignature<Android.View.Translation.TranslationRequest.Builder>("setFlags", "(I)Landroid/view/translation/TranslationRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/translation/TranslationRequest.Builder.html#setTranslationRequestValues(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.View.Translation.TranslationRequest.Builder"/></returns>
            public Android.View.Translation.TranslationRequest.Builder SetTranslationRequestValues(Java.Util.List<Android.View.Translation.TranslationRequestValue> arg0)
            {
                return IExecuteWithSignature<Android.View.Translation.TranslationRequest.Builder>("setTranslationRequestValues", "(Ljava/util/List;)Landroid/view/translation/TranslationRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/translation/TranslationRequest.Builder.html#setViewTranslationRequests(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.View.Translation.TranslationRequest.Builder"/></returns>
            public Android.View.Translation.TranslationRequest.Builder SetViewTranslationRequests(Java.Util.List<Android.View.Translation.ViewTranslationRequest> arg0)
            {
                return IExecuteWithSignature<Android.View.Translation.TranslationRequest.Builder>("setViewTranslationRequests", "(Ljava/util/List;)Landroid/view/translation/TranslationRequest$Builder;", arg0);
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