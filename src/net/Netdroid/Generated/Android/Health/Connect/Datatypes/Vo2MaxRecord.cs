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

namespace Android.Health.Connect.Datatypes
{
    #region Vo2MaxRecord declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/Vo2MaxRecord.html"/>
    /// </summary>
    public partial class Vo2MaxRecord : Android.Health.Connect.Datatypes.InstantRecord
    {
        const string _bridgeClassName = "android.health.connect.datatypes.Vo2MaxRecord";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Vo2MaxRecord() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Vo2MaxRecord(params object[] args) : base(args) { }
    
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
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/Vo2MaxRecord.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.health.connect.datatypes.Vo2MaxRecord$Builder";
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

        #region Vo2MaxMeasurementMethod declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/Vo2MaxRecord.Vo2MaxMeasurementMethod.html"/>
        /// </summary>
        public partial class Vo2MaxMeasurementMethod : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Vo2MaxMeasurementMethod>
        {
            const string _bridgeClassName = "android.health.connect.datatypes.Vo2MaxRecord$Vo2MaxMeasurementMethod";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Vo2MaxMeasurementMethod() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Vo2MaxMeasurementMethod(params object[] args) : base(args) { }
        
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

    #region Vo2MaxRecord implementation
    public partial class Vo2MaxRecord
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
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/Vo2MaxRecord.html#getVo2MillilitersPerMinuteKilogram()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double GetVo2MillilitersPerMinuteKilogram()
        {
            return IExecuteWithSignature<double>("getVo2MillilitersPerMinuteKilogram", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/Vo2MaxRecord.html#getMeasurementMethod()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMeasurementMethod()
        {
            return IExecuteWithSignature<int>("getMeasurementMethod", "()I");
        }
    
        #endregion
    
        #region Nested classes
        #region Builder implementation
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/Vo2MaxRecord.Builder.html#%3Cinit%3E(android.health.connect.datatypes.Metadata,java.time.Instant,int,double)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Health.Connect.Datatypes.Metadata"/></param>
            /// <param name="arg1"><see cref="Java.Time.Instant"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="double"/></param>
            public Builder(Android.Health.Connect.Datatypes.Metadata arg0, Java.Time.Instant arg1, int arg2, double arg3)
                : base(arg0, arg1, arg2, arg3)
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
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/Vo2MaxRecord.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.Vo2MaxRecord"/></returns>
            public Android.Health.Connect.Datatypes.Vo2MaxRecord Build()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.Vo2MaxRecord>("build", "()Landroid/health/connect/datatypes/Vo2MaxRecord;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/Vo2MaxRecord.Builder.html#clearZoneOffset()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.Vo2MaxRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.Vo2MaxRecord.Builder ClearZoneOffset()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.Vo2MaxRecord.Builder>("clearZoneOffset", "()Landroid/health/connect/datatypes/Vo2MaxRecord$Builder;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/Vo2MaxRecord.Builder.html#setZoneOffset(java.time.ZoneOffset)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.ZoneOffset"/></param>
            /// <returns><see cref="Android.Health.Connect.Datatypes.Vo2MaxRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.Vo2MaxRecord.Builder SetZoneOffset(Java.Time.ZoneOffset arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.Vo2MaxRecord.Builder>("setZoneOffset", "(Ljava/time/ZoneOffset;)Landroid/health/connect/datatypes/Vo2MaxRecord$Builder;", arg0);
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region Vo2MaxMeasurementMethod implementation
        public partial class Vo2MaxMeasurementMethod
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/Vo2MaxRecord.Vo2MaxMeasurementMethod.html#MEASUREMENT_METHOD_COOPER_TEST"/>
            /// </summary>
            public static int MEASUREMENT_METHOD_COOPER_TEST { get { if (!_MEASUREMENT_METHOD_COOPER_TESTReady) { _MEASUREMENT_METHOD_COOPER_TESTContent = SGetField<int>(LocalBridgeClazz, "MEASUREMENT_METHOD_COOPER_TEST"); _MEASUREMENT_METHOD_COOPER_TESTReady = true; } return _MEASUREMENT_METHOD_COOPER_TESTContent; } }
            private static int _MEASUREMENT_METHOD_COOPER_TESTContent = default;
            private static bool _MEASUREMENT_METHOD_COOPER_TESTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/Vo2MaxRecord.Vo2MaxMeasurementMethod.html#MEASUREMENT_METHOD_HEART_RATE_RATIO"/>
            /// </summary>
            public static int MEASUREMENT_METHOD_HEART_RATE_RATIO { get { if (!_MEASUREMENT_METHOD_HEART_RATE_RATIOReady) { _MEASUREMENT_METHOD_HEART_RATE_RATIOContent = SGetField<int>(LocalBridgeClazz, "MEASUREMENT_METHOD_HEART_RATE_RATIO"); _MEASUREMENT_METHOD_HEART_RATE_RATIOReady = true; } return _MEASUREMENT_METHOD_HEART_RATE_RATIOContent; } }
            private static int _MEASUREMENT_METHOD_HEART_RATE_RATIOContent = default;
            private static bool _MEASUREMENT_METHOD_HEART_RATE_RATIOReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/Vo2MaxRecord.Vo2MaxMeasurementMethod.html#MEASUREMENT_METHOD_METABOLIC_CART"/>
            /// </summary>
            public static int MEASUREMENT_METHOD_METABOLIC_CART { get { if (!_MEASUREMENT_METHOD_METABOLIC_CARTReady) { _MEASUREMENT_METHOD_METABOLIC_CARTContent = SGetField<int>(LocalBridgeClazz, "MEASUREMENT_METHOD_METABOLIC_CART"); _MEASUREMENT_METHOD_METABOLIC_CARTReady = true; } return _MEASUREMENT_METHOD_METABOLIC_CARTContent; } }
            private static int _MEASUREMENT_METHOD_METABOLIC_CARTContent = default;
            private static bool _MEASUREMENT_METHOD_METABOLIC_CARTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/Vo2MaxRecord.Vo2MaxMeasurementMethod.html#MEASUREMENT_METHOD_MULTISTAGE_FITNESS_TEST"/>
            /// </summary>
            public static int MEASUREMENT_METHOD_MULTISTAGE_FITNESS_TEST { get { if (!_MEASUREMENT_METHOD_MULTISTAGE_FITNESS_TESTReady) { _MEASUREMENT_METHOD_MULTISTAGE_FITNESS_TESTContent = SGetField<int>(LocalBridgeClazz, "MEASUREMENT_METHOD_MULTISTAGE_FITNESS_TEST"); _MEASUREMENT_METHOD_MULTISTAGE_FITNESS_TESTReady = true; } return _MEASUREMENT_METHOD_MULTISTAGE_FITNESS_TESTContent; } }
            private static int _MEASUREMENT_METHOD_MULTISTAGE_FITNESS_TESTContent = default;
            private static bool _MEASUREMENT_METHOD_MULTISTAGE_FITNESS_TESTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/Vo2MaxRecord.Vo2MaxMeasurementMethod.html#MEASUREMENT_METHOD_OTHER"/>
            /// </summary>
            public static int MEASUREMENT_METHOD_OTHER { get { if (!_MEASUREMENT_METHOD_OTHERReady) { _MEASUREMENT_METHOD_OTHERContent = SGetField<int>(LocalBridgeClazz, "MEASUREMENT_METHOD_OTHER"); _MEASUREMENT_METHOD_OTHERReady = true; } return _MEASUREMENT_METHOD_OTHERContent; } }
            private static int _MEASUREMENT_METHOD_OTHERContent = default;
            private static bool _MEASUREMENT_METHOD_OTHERReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/Vo2MaxRecord.Vo2MaxMeasurementMethod.html#MEASUREMENT_METHOD_ROCKPORT_FITNESS_TEST"/>
            /// </summary>
            public static int MEASUREMENT_METHOD_ROCKPORT_FITNESS_TEST { get { if (!_MEASUREMENT_METHOD_ROCKPORT_FITNESS_TESTReady) { _MEASUREMENT_METHOD_ROCKPORT_FITNESS_TESTContent = SGetField<int>(LocalBridgeClazz, "MEASUREMENT_METHOD_ROCKPORT_FITNESS_TEST"); _MEASUREMENT_METHOD_ROCKPORT_FITNESS_TESTReady = true; } return _MEASUREMENT_METHOD_ROCKPORT_FITNESS_TESTContent; } }
            private static int _MEASUREMENT_METHOD_ROCKPORT_FITNESS_TESTContent = default;
            private static bool _MEASUREMENT_METHOD_ROCKPORT_FITNESS_TESTReady = false; // this is used because in case of generics 
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
        
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