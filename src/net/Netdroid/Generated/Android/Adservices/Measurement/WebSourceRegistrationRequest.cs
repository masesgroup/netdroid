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

namespace Android.Adservices.Measurement
{
    #region WebSourceRegistrationRequest declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/adservices/measurement/WebSourceRegistrationRequest.html"/>
    /// </summary>
    public partial class WebSourceRegistrationRequest : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.adservices.measurement.WebSourceRegistrationRequest";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public WebSourceRegistrationRequest() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public WebSourceRegistrationRequest(params object[] args) : base(args) { }
    
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
        /// <see href="https://developer.android.com/reference/android/adservices/measurement/WebSourceRegistrationRequest.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.adservices.measurement.WebSourceRegistrationRequest$Builder";
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

    #region WebSourceRegistrationRequest implementation
    public partial class WebSourceRegistrationRequest
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/measurement/WebSourceRegistrationRequest.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/measurement/WebSourceRegistrationRequest.html#getAppDestination()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        public Android.Net.Uri GetAppDestination()
        {
            return IExecuteWithSignature<Android.Net.Uri>("getAppDestination", "()Landroid/net/Uri;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/measurement/WebSourceRegistrationRequest.html#getTopOriginUri()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        public Android.Net.Uri GetTopOriginUri()
        {
            return IExecuteWithSignature<Android.Net.Uri>("getTopOriginUri", "()Landroid/net/Uri;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/measurement/WebSourceRegistrationRequest.html#getVerifiedDestination()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        public Android.Net.Uri GetVerifiedDestination()
        {
            return IExecuteWithSignature<Android.Net.Uri>("getVerifiedDestination", "()Landroid/net/Uri;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/measurement/WebSourceRegistrationRequest.html#getWebDestination()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        public Android.Net.Uri GetWebDestination()
        {
            return IExecuteWithSignature<Android.Net.Uri>("getWebDestination", "()Landroid/net/Uri;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/measurement/WebSourceRegistrationRequest.html#getInputEvent()"/>
        /// </summary>
        /// <returns><see cref="Android.View.InputEvent"/></returns>
        public Android.View.InputEvent GetInputEvent()
        {
            return IExecuteWithSignature<Android.View.InputEvent>("getInputEvent", "()Landroid/view/InputEvent;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/measurement/WebSourceRegistrationRequest.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/measurement/WebSourceRegistrationRequest.html#getSourceParams()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Adservices.Measurement.WebSourceParams> GetSourceParams()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Adservices.Measurement.WebSourceParams>>("getSourceParams", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/measurement/WebSourceRegistrationRequest.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/adservices/measurement/WebSourceRegistrationRequest.Builder.html#%3Cinit%3E(java.util.List,android.net.Uri)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <param name="arg1"><see cref="Android.Net.Uri"/></param>
            public Builder(Java.Util.List<Android.Adservices.Measurement.WebSourceParams> arg0, Android.Net.Uri arg1)
                : base(arg0, arg1)
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
            /// <see href="https://developer.android.com/reference/android/adservices/measurement/WebSourceRegistrationRequest.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Adservices.Measurement.WebSourceRegistrationRequest"/></returns>
            public Android.Adservices.Measurement.WebSourceRegistrationRequest Build()
            {
                return IExecuteWithSignature<Android.Adservices.Measurement.WebSourceRegistrationRequest>("build", "()Landroid/adservices/measurement/WebSourceRegistrationRequest;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/measurement/WebSourceRegistrationRequest.Builder.html#setAppDestination(android.net.Uri)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
            /// <returns><see cref="Android.Adservices.Measurement.WebSourceRegistrationRequest.Builder"/></returns>
            public Android.Adservices.Measurement.WebSourceRegistrationRequest.Builder SetAppDestination(Android.Net.Uri arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Measurement.WebSourceRegistrationRequest.Builder>("setAppDestination", "(Landroid/net/Uri;)Landroid/adservices/measurement/WebSourceRegistrationRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/measurement/WebSourceRegistrationRequest.Builder.html#setInputEvent(android.view.InputEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.InputEvent"/></param>
            /// <returns><see cref="Android.Adservices.Measurement.WebSourceRegistrationRequest.Builder"/></returns>
            public Android.Adservices.Measurement.WebSourceRegistrationRequest.Builder SetInputEvent(Android.View.InputEvent arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Measurement.WebSourceRegistrationRequest.Builder>("setInputEvent", "(Landroid/view/InputEvent;)Landroid/adservices/measurement/WebSourceRegistrationRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/measurement/WebSourceRegistrationRequest.Builder.html#setVerifiedDestination(android.net.Uri)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
            /// <returns><see cref="Android.Adservices.Measurement.WebSourceRegistrationRequest.Builder"/></returns>
            public Android.Adservices.Measurement.WebSourceRegistrationRequest.Builder SetVerifiedDestination(Android.Net.Uri arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Measurement.WebSourceRegistrationRequest.Builder>("setVerifiedDestination", "(Landroid/net/Uri;)Landroid/adservices/measurement/WebSourceRegistrationRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/measurement/WebSourceRegistrationRequest.Builder.html#setWebDestination(android.net.Uri)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
            /// <returns><see cref="Android.Adservices.Measurement.WebSourceRegistrationRequest.Builder"/></returns>
            public Android.Adservices.Measurement.WebSourceRegistrationRequest.Builder SetWebDestination(Android.Net.Uri arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Measurement.WebSourceRegistrationRequest.Builder>("setWebDestination", "(Landroid/net/Uri;)Landroid/adservices/measurement/WebSourceRegistrationRequest$Builder;", arg0);
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