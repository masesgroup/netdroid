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
    #region TranslationResponse declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/view/translation/TranslationResponse.html"/>
    /// </summary>
    public partial class TranslationResponse : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.view.translation.TranslationResponse";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TranslationResponse() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TranslationResponse(params object[] args) : base(args) { }
    
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
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationResponse.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.view.translation.TranslationResponse$Builder";
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

    #region TranslationResponse implementation
    public partial class TranslationResponse
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationResponse.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationResponse.html#TRANSLATION_STATUS_CONTEXT_UNSUPPORTED"/>
        /// </summary>
        public static int TRANSLATION_STATUS_CONTEXT_UNSUPPORTED { get { if (!_TRANSLATION_STATUS_CONTEXT_UNSUPPORTEDReady) { _TRANSLATION_STATUS_CONTEXT_UNSUPPORTEDContent = SGetField<int>(LocalBridgeClazz, "TRANSLATION_STATUS_CONTEXT_UNSUPPORTED"); _TRANSLATION_STATUS_CONTEXT_UNSUPPORTEDReady = true; } return _TRANSLATION_STATUS_CONTEXT_UNSUPPORTEDContent; } }
        private static int _TRANSLATION_STATUS_CONTEXT_UNSUPPORTEDContent = default;
        private static bool _TRANSLATION_STATUS_CONTEXT_UNSUPPORTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationResponse.html#TRANSLATION_STATUS_SUCCESS"/>
        /// </summary>
        public static int TRANSLATION_STATUS_SUCCESS { get { if (!_TRANSLATION_STATUS_SUCCESSReady) { _TRANSLATION_STATUS_SUCCESSContent = SGetField<int>(LocalBridgeClazz, "TRANSLATION_STATUS_SUCCESS"); _TRANSLATION_STATUS_SUCCESSReady = true; } return _TRANSLATION_STATUS_SUCCESSContent; } }
        private static int _TRANSLATION_STATUS_SUCCESSContent = default;
        private static bool _TRANSLATION_STATUS_SUCCESSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationResponse.html#TRANSLATION_STATUS_UNKNOWN_ERROR"/>
        /// </summary>
        public static int TRANSLATION_STATUS_UNKNOWN_ERROR { get { if (!_TRANSLATION_STATUS_UNKNOWN_ERRORReady) { _TRANSLATION_STATUS_UNKNOWN_ERRORContent = SGetField<int>(LocalBridgeClazz, "TRANSLATION_STATUS_UNKNOWN_ERROR"); _TRANSLATION_STATUS_UNKNOWN_ERRORReady = true; } return _TRANSLATION_STATUS_UNKNOWN_ERRORContent; } }
        private static int _TRANSLATION_STATUS_UNKNOWN_ERRORContent = default;
        private static bool _TRANSLATION_STATUS_UNKNOWN_ERRORReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationResponse.html#getTranslationResponseValues()"/>
        /// </summary>
        /// <returns><see cref="Android.Util.SparseArray"/></returns>
        public Android.Util.SparseArray<Android.View.Translation.TranslationResponseValue> GetTranslationResponseValues()
        {
            return IExecuteWithSignature<Android.Util.SparseArray<Android.View.Translation.TranslationResponseValue>>("getTranslationResponseValues", "()Landroid/util/SparseArray;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationResponse.html#getViewTranslationResponses()"/>
        /// </summary>
        /// <returns><see cref="Android.Util.SparseArray"/></returns>
        public Android.Util.SparseArray<Android.View.Translation.ViewTranslationResponse> GetViewTranslationResponses()
        {
            return IExecuteWithSignature<Android.Util.SparseArray<Android.View.Translation.ViewTranslationResponse>>("getViewTranslationResponses", "()Landroid/util/SparseArray;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationResponse.html#isFinalResponse()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFinalResponse()
        {
            return IExecuteWithSignature<bool>("isFinalResponse", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationResponse.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationResponse.html#getTranslationStatus()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTranslationStatus()
        {
            return IExecuteWithSignature<int>("getTranslationStatus", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationResponse.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/translation/TranslationResponse.Builder.html#%3Cinit%3E(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public Builder(int arg0)
                : base(arg0)
            {
            }
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/translation/TranslationResponse.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.View.Translation.TranslationResponse"/></returns>
            public Android.View.Translation.TranslationResponse Build()
            {
                return IExecuteWithSignature<Android.View.Translation.TranslationResponse>("build", "()Landroid/view/translation/TranslationResponse;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/translation/TranslationResponse.Builder.html#setFinalResponse(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.View.Translation.TranslationResponse.Builder"/></returns>
            public Android.View.Translation.TranslationResponse.Builder SetFinalResponse(bool arg0)
            {
                return IExecuteWithSignature<Android.View.Translation.TranslationResponse.Builder>("setFinalResponse", "(Z)Landroid/view/translation/TranslationResponse$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/translation/TranslationResponse.Builder.html#setTranslationResponseValue(int,android.view.translation.TranslationResponseValue)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="Android.View.Translation.TranslationResponseValue"/></param>
            /// <returns><see cref="Android.View.Translation.TranslationResponse.Builder"/></returns>
            public Android.View.Translation.TranslationResponse.Builder SetTranslationResponseValue(int arg0, Android.View.Translation.TranslationResponseValue arg1)
            {
                return IExecute<Android.View.Translation.TranslationResponse.Builder>("setTranslationResponseValue", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/translation/TranslationResponse.Builder.html#setTranslationResponseValues(android.util.SparseArray)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Util.SparseArray"/></param>
            /// <returns><see cref="Android.View.Translation.TranslationResponse.Builder"/></returns>
            public Android.View.Translation.TranslationResponse.Builder SetTranslationResponseValues(Android.Util.SparseArray<Android.View.Translation.TranslationResponseValue> arg0)
            {
                return IExecuteWithSignature<Android.View.Translation.TranslationResponse.Builder>("setTranslationResponseValues", "(Landroid/util/SparseArray;)Landroid/view/translation/TranslationResponse$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/translation/TranslationResponse.Builder.html#setViewTranslationResponse(int,android.view.translation.ViewTranslationResponse)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="Android.View.Translation.ViewTranslationResponse"/></param>
            /// <returns><see cref="Android.View.Translation.TranslationResponse.Builder"/></returns>
            public Android.View.Translation.TranslationResponse.Builder SetViewTranslationResponse(int arg0, Android.View.Translation.ViewTranslationResponse arg1)
            {
                return IExecute<Android.View.Translation.TranslationResponse.Builder>("setViewTranslationResponse", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/translation/TranslationResponse.Builder.html#setViewTranslationResponses(android.util.SparseArray)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Util.SparseArray"/></param>
            /// <returns><see cref="Android.View.Translation.TranslationResponse.Builder"/></returns>
            public Android.View.Translation.TranslationResponse.Builder SetViewTranslationResponses(Android.Util.SparseArray<Android.View.Translation.ViewTranslationResponse> arg0)
            {
                return IExecuteWithSignature<Android.View.Translation.TranslationResponse.Builder>("setViewTranslationResponses", "(Landroid/util/SparseArray;)Landroid/view/translation/TranslationResponse$Builder;", arg0);
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