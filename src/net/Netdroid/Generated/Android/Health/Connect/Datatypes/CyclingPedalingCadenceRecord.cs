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

namespace Android.Health.Connect.Datatypes
{
    #region CyclingPedalingCadenceRecord declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/CyclingPedalingCadenceRecord.html"/>
    /// </summary>
    public partial class CyclingPedalingCadenceRecord : Android.Health.Connect.Datatypes.IntervalRecord
    {
        const string _bridgeClassName = "android.health.connect.datatypes.CyclingPedalingCadenceRecord";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public CyclingPedalingCadenceRecord() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public CyclingPedalingCadenceRecord(params object[] args) : base(args) { }
    
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
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/CyclingPedalingCadenceRecord.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.health.connect.datatypes.CyclingPedalingCadenceRecord$Builder";
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

        #region CyclingPedalingCadenceRecordSample declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/CyclingPedalingCadenceRecord.CyclingPedalingCadenceRecordSample.html"/>
        /// </summary>
        public partial class CyclingPedalingCadenceRecordSample : MASES.JCOBridge.C2JBridge.JVMBridgeBase<CyclingPedalingCadenceRecordSample>
        {
            const string _bridgeClassName = "android.health.connect.datatypes.CyclingPedalingCadenceRecord$CyclingPedalingCadenceRecordSample";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public CyclingPedalingCadenceRecordSample() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public CyclingPedalingCadenceRecordSample(params object[] args) : base(args) { }
        
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

    #region CyclingPedalingCadenceRecord implementation
    public partial class CyclingPedalingCadenceRecord
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/CyclingPedalingCadenceRecord.html#RPM_AVG"/>
        /// </summary>
        public static Android.Health.Connect.Datatypes.AggregationType RPM_AVG { get { if (!_RPM_AVGReady) { _RPM_AVGContent = SGetField<Android.Health.Connect.Datatypes.AggregationType>(LocalBridgeClazz, "RPM_AVG"); _RPM_AVGReady = true; } return _RPM_AVGContent; } }
        private static Android.Health.Connect.Datatypes.AggregationType _RPM_AVGContent = default;
        private static bool _RPM_AVGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/CyclingPedalingCadenceRecord.html#RPM_MAX"/>
        /// </summary>
        public static Android.Health.Connect.Datatypes.AggregationType RPM_MAX { get { if (!_RPM_MAXReady) { _RPM_MAXContent = SGetField<Android.Health.Connect.Datatypes.AggregationType>(LocalBridgeClazz, "RPM_MAX"); _RPM_MAXReady = true; } return _RPM_MAXContent; } }
        private static Android.Health.Connect.Datatypes.AggregationType _RPM_MAXContent = default;
        private static bool _RPM_MAXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/CyclingPedalingCadenceRecord.html#RPM_MIN"/>
        /// </summary>
        public static Android.Health.Connect.Datatypes.AggregationType RPM_MIN { get { if (!_RPM_MINReady) { _RPM_MINContent = SGetField<Android.Health.Connect.Datatypes.AggregationType>(LocalBridgeClazz, "RPM_MIN"); _RPM_MINReady = true; } return _RPM_MINContent; } }
        private static Android.Health.Connect.Datatypes.AggregationType _RPM_MINContent = default;
        private static bool _RPM_MINReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/CyclingPedalingCadenceRecord.html#getSamples()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Health.Connect.Datatypes.CyclingPedalingCadenceRecord.CyclingPedalingCadenceRecordSample> GetSamples()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Health.Connect.Datatypes.CyclingPedalingCadenceRecord.CyclingPedalingCadenceRecordSample>>("getSamples", "()Ljava/util/List;");
        }
    
        #endregion
    
        #region Nested classes
        #region Builder implementation
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/CyclingPedalingCadenceRecord.Builder.html#%3Cinit%3E(android.health.connect.datatypes.Metadata,java.time.Instant,java.time.Instant,java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Health.Connect.Datatypes.Metadata"/></param>
            /// <param name="arg1"><see cref="Java.Time.Instant"/></param>
            /// <param name="arg2"><see cref="Java.Time.Instant"/></param>
            /// <param name="arg3"><see cref="Java.Util.List"/></param>
            public Builder(Android.Health.Connect.Datatypes.Metadata arg0, Java.Time.Instant arg1, Java.Time.Instant arg2, Java.Util.List<Android.Health.Connect.Datatypes.CyclingPedalingCadenceRecord.CyclingPedalingCadenceRecordSample> arg3)
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
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/CyclingPedalingCadenceRecord.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.CyclingPedalingCadenceRecord"/></returns>
            public Android.Health.Connect.Datatypes.CyclingPedalingCadenceRecord Build()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.CyclingPedalingCadenceRecord>("build", "()Landroid/health/connect/datatypes/CyclingPedalingCadenceRecord;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/CyclingPedalingCadenceRecord.Builder.html#clearEndZoneOffset()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.CyclingPedalingCadenceRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.CyclingPedalingCadenceRecord.Builder ClearEndZoneOffset()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.CyclingPedalingCadenceRecord.Builder>("clearEndZoneOffset", "()Landroid/health/connect/datatypes/CyclingPedalingCadenceRecord$Builder;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/CyclingPedalingCadenceRecord.Builder.html#clearStartZoneOffset()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.CyclingPedalingCadenceRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.CyclingPedalingCadenceRecord.Builder ClearStartZoneOffset()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.CyclingPedalingCadenceRecord.Builder>("clearStartZoneOffset", "()Landroid/health/connect/datatypes/CyclingPedalingCadenceRecord$Builder;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/CyclingPedalingCadenceRecord.Builder.html#setEndZoneOffset(java.time.ZoneOffset)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.ZoneOffset"/></param>
            /// <returns><see cref="Android.Health.Connect.Datatypes.CyclingPedalingCadenceRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.CyclingPedalingCadenceRecord.Builder SetEndZoneOffset(Java.Time.ZoneOffset arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.CyclingPedalingCadenceRecord.Builder>("setEndZoneOffset", "(Ljava/time/ZoneOffset;)Landroid/health/connect/datatypes/CyclingPedalingCadenceRecord$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/CyclingPedalingCadenceRecord.Builder.html#setStartZoneOffset(java.time.ZoneOffset)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.ZoneOffset"/></param>
            /// <returns><see cref="Android.Health.Connect.Datatypes.CyclingPedalingCadenceRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.CyclingPedalingCadenceRecord.Builder SetStartZoneOffset(Java.Time.ZoneOffset arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.CyclingPedalingCadenceRecord.Builder>("setStartZoneOffset", "(Ljava/time/ZoneOffset;)Landroid/health/connect/datatypes/CyclingPedalingCadenceRecord$Builder;", arg0);
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region CyclingPedalingCadenceRecordSample implementation
        public partial class CyclingPedalingCadenceRecordSample
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/CyclingPedalingCadenceRecord.CyclingPedalingCadenceRecordSample.html#%3Cinit%3E(double,java.time.Instant)"/>
            /// </summary>
            /// <param name="arg0"><see cref="double"/></param>
            /// <param name="arg1"><see cref="Java.Time.Instant"/></param>
            public CyclingPedalingCadenceRecordSample(double arg0, Java.Time.Instant arg1)
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
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/CyclingPedalingCadenceRecord.CyclingPedalingCadenceRecordSample.html#getRevolutionsPerMinute()"/>
            /// </summary>
            /// <returns><see cref="double"/></returns>
            public double GetRevolutionsPerMinute()
            {
                return IExecuteWithSignature<double>("getRevolutionsPerMinute", "()D");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/CyclingPedalingCadenceRecord.CyclingPedalingCadenceRecordSample.html#getTime()"/>
            /// </summary>
            /// <returns><see cref="Java.Time.Instant"/></returns>
            public Java.Time.Instant GetTime()
            {
                return IExecuteWithSignature<Java.Time.Instant>("getTime", "()Ljava/time/Instant;");
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