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

namespace Android.Adservices.Adselection
{
    #region UpdateAdCounterHistogramRequest declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/adservices/adselection/UpdateAdCounterHistogramRequest.html"/>
    /// </summary>
    public partial class UpdateAdCounterHistogramRequest : MASES.JCOBridge.C2JBridge.JVMBridgeBase<UpdateAdCounterHistogramRequest>
    {
        const string _bridgeClassName = "android.adservices.adselection.UpdateAdCounterHistogramRequest";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public UpdateAdCounterHistogramRequest() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public UpdateAdCounterHistogramRequest(params object[] args) : base(args) { }
    
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
        /// <see href="https://developer.android.com/reference/android/adservices/adselection/UpdateAdCounterHistogramRequest.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.adservices.adselection.UpdateAdCounterHistogramRequest$Builder";
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

    #region UpdateAdCounterHistogramRequest implementation
    public partial class UpdateAdCounterHistogramRequest
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
        /// <see href="https://developer.android.com/reference/android/adservices/adselection/UpdateAdCounterHistogramRequest.html#getCallerAdTech()"/>
        /// </summary>
        /// <returns><see cref="Android.Adservices.Common.AdTechIdentifier"/></returns>
        public Android.Adservices.Common.AdTechIdentifier GetCallerAdTech()
        {
            return IExecuteWithSignature<Android.Adservices.Common.AdTechIdentifier>("getCallerAdTech", "()Landroid/adservices/common/AdTechIdentifier;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/adselection/UpdateAdCounterHistogramRequest.html#getAdEventType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetAdEventType()
        {
            return IExecuteWithSignature<int>("getAdEventType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/adselection/UpdateAdCounterHistogramRequest.html#getAdSelectionId()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetAdSelectionId()
        {
            return IExecuteWithSignature<long>("getAdSelectionId", "()J");
        }
    
        #endregion
    
        #region Nested classes
        #region Builder implementation
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/adselection/UpdateAdCounterHistogramRequest.Builder.html#%3Cinit%3E(long,int,android.adservices.common.AdTechIdentifier)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="Android.Adservices.Common.AdTechIdentifier"/></param>
            public Builder(long arg0, int arg1, Android.Adservices.Common.AdTechIdentifier arg2)
                : base(arg0, arg1, arg2)
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
            /// <see href="https://developer.android.com/reference/android/adservices/adselection/UpdateAdCounterHistogramRequest.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Adservices.Adselection.UpdateAdCounterHistogramRequest"/></returns>
            public Android.Adservices.Adselection.UpdateAdCounterHistogramRequest Build()
            {
                return IExecuteWithSignature<Android.Adservices.Adselection.UpdateAdCounterHistogramRequest>("build", "()Landroid/adservices/adselection/UpdateAdCounterHistogramRequest;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/adselection/UpdateAdCounterHistogramRequest.Builder.html#setAdEventType(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Adservices.Adselection.UpdateAdCounterHistogramRequest.Builder"/></returns>
            public Android.Adservices.Adselection.UpdateAdCounterHistogramRequest.Builder SetAdEventType(int arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Adselection.UpdateAdCounterHistogramRequest.Builder>("setAdEventType", "(I)Landroid/adservices/adselection/UpdateAdCounterHistogramRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/adselection/UpdateAdCounterHistogramRequest.Builder.html#setAdSelectionId(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Adservices.Adselection.UpdateAdCounterHistogramRequest.Builder"/></returns>
            public Android.Adservices.Adselection.UpdateAdCounterHistogramRequest.Builder SetAdSelectionId(long arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Adselection.UpdateAdCounterHistogramRequest.Builder>("setAdSelectionId", "(J)Landroid/adservices/adselection/UpdateAdCounterHistogramRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/adselection/UpdateAdCounterHistogramRequest.Builder.html#setCallerAdTech(android.adservices.common.AdTechIdentifier)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Adservices.Common.AdTechIdentifier"/></param>
            /// <returns><see cref="Android.Adservices.Adselection.UpdateAdCounterHistogramRequest.Builder"/></returns>
            public Android.Adservices.Adselection.UpdateAdCounterHistogramRequest.Builder SetCallerAdTech(Android.Adservices.Common.AdTechIdentifier arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Adselection.UpdateAdCounterHistogramRequest.Builder>("setCallerAdTech", "(Landroid/adservices/common/AdTechIdentifier;)Landroid/adservices/adselection/UpdateAdCounterHistogramRequest$Builder;", arg0);
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