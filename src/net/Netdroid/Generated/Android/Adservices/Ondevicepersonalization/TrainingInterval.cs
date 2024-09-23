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

namespace Android.Adservices.Ondevicepersonalization
{
    #region TrainingInterval declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/TrainingInterval.html"/>
    /// </summary>
    public partial class TrainingInterval : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TrainingInterval>
    {
        const string _bridgeClassName = "android.adservices.ondevicepersonalization.TrainingInterval";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TrainingInterval() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TrainingInterval(params object[] args) : base(args) { }
    
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
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/TrainingInterval.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.adservices.ondevicepersonalization.TrainingInterval$Builder";
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

    #region TrainingInterval implementation
    public partial class TrainingInterval
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/TrainingInterval.html#SCHEDULING_MODE_ONE_TIME"/>
        /// </summary>
        public static int SCHEDULING_MODE_ONE_TIME { get { if (!_SCHEDULING_MODE_ONE_TIMEReady) { _SCHEDULING_MODE_ONE_TIMEContent = SGetField<int>(LocalBridgeClazz, "SCHEDULING_MODE_ONE_TIME"); _SCHEDULING_MODE_ONE_TIMEReady = true; } return _SCHEDULING_MODE_ONE_TIMEContent; } }
        private static int _SCHEDULING_MODE_ONE_TIMEContent = default;
        private static bool _SCHEDULING_MODE_ONE_TIMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/TrainingInterval.html#SCHEDULING_MODE_RECURRENT"/>
        /// </summary>
        public static int SCHEDULING_MODE_RECURRENT { get { if (!_SCHEDULING_MODE_RECURRENTReady) { _SCHEDULING_MODE_RECURRENTContent = SGetField<int>(LocalBridgeClazz, "SCHEDULING_MODE_RECURRENT"); _SCHEDULING_MODE_RECURRENTReady = true; } return _SCHEDULING_MODE_RECURRENTContent; } }
        private static int _SCHEDULING_MODE_RECURRENTContent = default;
        private static bool _SCHEDULING_MODE_RECURRENTReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/TrainingInterval.html#getSchedulingMode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSchedulingMode()
        {
            return IExecuteWithSignature<int>("getSchedulingMode", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/TrainingInterval.html#getMinimumInterval()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public Java.Time.Duration GetMinimumInterval()
        {
            return IExecuteWithSignature<Java.Time.Duration>("getMinimumInterval", "()Ljava/time/Duration;");
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
            /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/TrainingInterval.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Adservices.Ondevicepersonalization.TrainingInterval"/></returns>
            public Android.Adservices.Ondevicepersonalization.TrainingInterval Build()
            {
                return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.TrainingInterval>("build", "()Landroid/adservices/ondevicepersonalization/TrainingInterval;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/TrainingInterval.Builder.html#setMinimumInterval(java.time.Duration)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.Duration"/></param>
            /// <returns><see cref="Android.Adservices.Ondevicepersonalization.TrainingInterval.Builder"/></returns>
            public Android.Adservices.Ondevicepersonalization.TrainingInterval.Builder SetMinimumInterval(Java.Time.Duration arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.TrainingInterval.Builder>("setMinimumInterval", "(Ljava/time/Duration;)Landroid/adservices/ondevicepersonalization/TrainingInterval$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/TrainingInterval.Builder.html#setSchedulingMode(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Adservices.Ondevicepersonalization.TrainingInterval.Builder"/></returns>
            public Android.Adservices.Ondevicepersonalization.TrainingInterval.Builder SetSchedulingMode(int arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.TrainingInterval.Builder>("setSchedulingMode", "(I)Landroid/adservices/ondevicepersonalization/TrainingInterval$Builder;", arg0);
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