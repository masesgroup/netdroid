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

namespace Android.Health.Connect
{
    #region AggregateRecordsGroupedByDurationResponse declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/health/connect/AggregateRecordsGroupedByDurationResponse.html"/>
    /// </summary>
    public partial class AggregateRecordsGroupedByDurationResponse : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AggregateRecordsGroupedByDurationResponse>
    {
        const string _bridgeClassName = "android.health.connect.AggregateRecordsGroupedByDurationResponse";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AggregateRecordsGroupedByDurationResponse() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AggregateRecordsGroupedByDurationResponse(params object[] args) : base(args) { }
    
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
    
    }
    #endregion

    #region AggregateRecordsGroupedByDurationResponse<T> declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/health/connect/AggregateRecordsGroupedByDurationResponse.html"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public partial class AggregateRecordsGroupedByDurationResponse<T> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AggregateRecordsGroupedByDurationResponse<T>>
    {
        const string _bridgeClassName = "android.health.connect.AggregateRecordsGroupedByDurationResponse";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AggregateRecordsGroupedByDurationResponse() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AggregateRecordsGroupedByDurationResponse(params object[] args) : base(args) { }
    
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
    
    }
    #endregion

    #region AggregateRecordsGroupedByDurationResponse implementation
    public partial class AggregateRecordsGroupedByDurationResponse
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
        /// <see href="https://developer.android.com/reference/android/health/connect/AggregateRecordsGroupedByDurationResponse.html#getEndTime()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Instant"/></returns>
        public Java.Time.Instant GetEndTime()
        {
            return IExecuteWithSignature<Java.Time.Instant>("getEndTime", "()Ljava/time/Instant;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/AggregateRecordsGroupedByDurationResponse.html#getStartTime()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Instant"/></returns>
        public Java.Time.Instant GetStartTime()
        {
            return IExecuteWithSignature<Java.Time.Instant>("getStartTime", "()Ljava/time/Instant;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/AggregateRecordsGroupedByDurationResponse.html#getZoneOffset(android.health.connect.datatypes.AggregationType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Health.Connect.Datatypes.AggregationType"/></param>
        /// <returns><see cref="Java.Time.ZoneOffset"/></returns>
        public Java.Time.ZoneOffset GetZoneOffset(Android.Health.Connect.Datatypes.AggregationType arg0)
        {
            return IExecuteWithSignature<Java.Time.ZoneOffset>("getZoneOffset", "(Landroid/health/connect/datatypes/AggregationType;)Ljava/time/ZoneOffset;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/AggregateRecordsGroupedByDurationResponse.html#getDataOrigins(android.health.connect.datatypes.AggregationType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Health.Connect.Datatypes.AggregationType"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set GetDataOrigins(Android.Health.Connect.Datatypes.AggregationType arg0)
        {
            return IExecuteWithSignature<Java.Util.Set>("getDataOrigins", "(Landroid/health/connect/datatypes/AggregationType;)Ljava/util/Set;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/AggregateRecordsGroupedByDurationResponse.html#get(android.health.connect.datatypes.AggregationType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Health.Connect.Datatypes.AggregationType"/></param>
        /// <returns><see cref="object"/></returns>
        public object Get(Android.Health.Connect.Datatypes.AggregationType arg0)
        {
            return IExecuteWithSignature("get", "(Landroid/health/connect/datatypes/AggregationType;)Ljava/lang/Object;", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region AggregateRecordsGroupedByDurationResponse<T> implementation
    public partial class AggregateRecordsGroupedByDurationResponse<T>
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Health.Connect.AggregateRecordsGroupedByDurationResponse{T}"/> to <see cref="Android.Health.Connect.AggregateRecordsGroupedByDurationResponse"/>
        /// </summary>
        public static implicit operator Android.Health.Connect.AggregateRecordsGroupedByDurationResponse(Android.Health.Connect.AggregateRecordsGroupedByDurationResponse<T> t) => t.Cast<Android.Health.Connect.AggregateRecordsGroupedByDurationResponse>();
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/AggregateRecordsGroupedByDurationResponse.html#getEndTime()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Instant"/></returns>
        public Java.Time.Instant GetEndTime()
        {
            return IExecuteWithSignature<Java.Time.Instant>("getEndTime", "()Ljava/time/Instant;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/AggregateRecordsGroupedByDurationResponse.html#getStartTime()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Instant"/></returns>
        public Java.Time.Instant GetStartTime()
        {
            return IExecuteWithSignature<Java.Time.Instant>("getStartTime", "()Ljava/time/Instant;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/AggregateRecordsGroupedByDurationResponse.html#getZoneOffset(android.health.connect.datatypes.AggregationType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Health.Connect.Datatypes.AggregationType"/></param>
        /// <returns><see cref="Java.Time.ZoneOffset"/></returns>
        public Java.Time.ZoneOffset GetZoneOffset(Android.Health.Connect.Datatypes.AggregationType<T> arg0)
        {
            return IExecuteWithSignature<Java.Time.ZoneOffset>("getZoneOffset", "(Landroid/health/connect/datatypes/AggregationType;)Ljava/time/ZoneOffset;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/AggregateRecordsGroupedByDurationResponse.html#getDataOrigins(android.health.connect.datatypes.AggregationType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Health.Connect.Datatypes.AggregationType"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Android.Health.Connect.Datatypes.DataOrigin> GetDataOrigins(Android.Health.Connect.Datatypes.AggregationType<T> arg0)
        {
            return IExecuteWithSignature<Java.Util.Set<Android.Health.Connect.Datatypes.DataOrigin>>("getDataOrigins", "(Landroid/health/connect/datatypes/AggregationType;)Ljava/util/Set;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/AggregateRecordsGroupedByDurationResponse.html#get(android.health.connect.datatypes.AggregationType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Health.Connect.Datatypes.AggregationType"/></param>
        /// <returns><typeparamref name="T"/></returns>
        public T Get(Android.Health.Connect.Datatypes.AggregationType<T> arg0)
        {
            return IExecuteWithSignature<T>("get", "(Landroid/health/connect/datatypes/AggregationType;)Ljava/lang/Object;", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}