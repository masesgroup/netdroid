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
    #region ReadRecordsRequestUsingFilters declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingFilters.html"/>
    /// </summary>
    public partial class ReadRecordsRequestUsingFilters : Android.Health.Connect.ReadRecordsRequest
    {
        const string _bridgeClassName = "android.health.connect.ReadRecordsRequestUsingFilters";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ReadRecordsRequestUsingFilters() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ReadRecordsRequestUsingFilters(params object[] args) : base(args) { }
    
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
        /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingFilters.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.health.connect.ReadRecordsRequestUsingFilters$Builder";
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

        #region Builder<T> declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingFilters.Builder.html"/>
        /// </summary>
        /// <typeparam name="T"><see cref="Android.Health.Connect.Datatypes.Record"/></typeparam>
        public partial class Builder<T> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder<T>> where T : Android.Health.Connect.Datatypes.Record
        {
            const string _bridgeClassName = "android.health.connect.ReadRecordsRequestUsingFilters$Builder";
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

    #region ReadRecordsRequestUsingFilters<T> declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingFilters.html"/>
    /// </summary>
    /// <typeparam name="T"><see cref="Android.Health.Connect.Datatypes.Record"/></typeparam>
    public partial class ReadRecordsRequestUsingFilters<T> : Android.Health.Connect.ReadRecordsRequest<T> where T : Android.Health.Connect.Datatypes.Record
    {
        const string _bridgeClassName = "android.health.connect.ReadRecordsRequestUsingFilters";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ReadRecordsRequestUsingFilters() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ReadRecordsRequestUsingFilters(params object[] args) : base(args) { }
    
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

    #region ReadRecordsRequestUsingFilters implementation
    public partial class ReadRecordsRequestUsingFilters
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
        /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingFilters.html#getTimeRangeFilter()"/>
        /// </summary>
        /// <returns><see cref="Android.Health.Connect.TimeRangeFilter"/></returns>
        public Android.Health.Connect.TimeRangeFilter GetTimeRangeFilter()
        {
            return IExecuteWithSignature<Android.Health.Connect.TimeRangeFilter>("getTimeRangeFilter", "()Landroid/health/connect/TimeRangeFilter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingFilters.html#isAscending()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAscending()
        {
            return IExecuteWithSignature<bool>("isAscending", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingFilters.html#getPageSize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPageSize()
        {
            return IExecuteWithSignature<int>("getPageSize", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingFilters.html#getDataOrigins()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set GetDataOrigins()
        {
            return IExecuteWithSignature<Java.Util.Set>("getDataOrigins", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingFilters.html#getPageToken()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetPageToken()
        {
            return IExecuteWithSignature<long>("getPageToken", "()J");
        }
    
        #endregion
    
        #region Nested classes
        #region Builder implementation
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingFilters.Builder.html#%3Cinit%3E(java.lang.Class)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
            public Builder(Java.Lang.Class arg0)
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
            /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingFilters.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.ReadRecordsRequestUsingFilters"/></returns>
            public Android.Health.Connect.ReadRecordsRequestUsingFilters Build()
            {
                return IExecuteWithSignature<Android.Health.Connect.ReadRecordsRequestUsingFilters>("build", "()Landroid/health/connect/ReadRecordsRequestUsingFilters;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingFilters.Builder.html#addDataOrigins(android.health.connect.datatypes.DataOrigin)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Health.Connect.Datatypes.DataOrigin"/></param>
            /// <returns><see cref="Android.Health.Connect.ReadRecordsRequestUsingFilters.Builder"/></returns>
            public Android.Health.Connect.ReadRecordsRequestUsingFilters.Builder AddDataOrigins(Android.Health.Connect.Datatypes.DataOrigin arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.ReadRecordsRequestUsingFilters.Builder>("addDataOrigins", "(Landroid/health/connect/datatypes/DataOrigin;)Landroid/health/connect/ReadRecordsRequestUsingFilters$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingFilters.Builder.html#setAscending(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Health.Connect.ReadRecordsRequestUsingFilters.Builder"/></returns>
            public Android.Health.Connect.ReadRecordsRequestUsingFilters.Builder SetAscending(bool arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.ReadRecordsRequestUsingFilters.Builder>("setAscending", "(Z)Landroid/health/connect/ReadRecordsRequestUsingFilters$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingFilters.Builder.html#setPageSize(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Health.Connect.ReadRecordsRequestUsingFilters.Builder"/></returns>
            public Android.Health.Connect.ReadRecordsRequestUsingFilters.Builder SetPageSize(int arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.ReadRecordsRequestUsingFilters.Builder>("setPageSize", "(I)Landroid/health/connect/ReadRecordsRequestUsingFilters$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingFilters.Builder.html#setPageToken(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Health.Connect.ReadRecordsRequestUsingFilters.Builder"/></returns>
            public Android.Health.Connect.ReadRecordsRequestUsingFilters.Builder SetPageToken(long arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.ReadRecordsRequestUsingFilters.Builder>("setPageToken", "(J)Landroid/health/connect/ReadRecordsRequestUsingFilters$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingFilters.Builder.html#setTimeRangeFilter(android.health.connect.TimeRangeFilter)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Health.Connect.TimeRangeFilter"/></param>
            /// <returns><see cref="Android.Health.Connect.ReadRecordsRequestUsingFilters.Builder"/></returns>
            public Android.Health.Connect.ReadRecordsRequestUsingFilters.Builder SetTimeRangeFilter(Android.Health.Connect.TimeRangeFilter arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.ReadRecordsRequestUsingFilters.Builder>("setTimeRangeFilter", "(Landroid/health/connect/TimeRangeFilter;)Landroid/health/connect/ReadRecordsRequestUsingFilters$Builder;", arg0);
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region Builder<T> implementation
        public partial class Builder<T>
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingFilters.Builder.html#%3Cinit%3E(java.lang.Class)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
            public Builder(Java.Lang.Class arg0)
                : base(arg0)
            {
            }
        
            #endregion
        
            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Android.Health.Connect.ReadRecordsRequestUsingFilters.Builder{T}"/> to <see cref="Android.Health.Connect.ReadRecordsRequestUsingFilters.Builder"/>
            /// </summary>
            public static implicit operator Android.Health.Connect.ReadRecordsRequestUsingFilters.Builder(Android.Health.Connect.ReadRecordsRequestUsingFilters.Builder<T> t) => t.Cast<Android.Health.Connect.ReadRecordsRequestUsingFilters.Builder>();
        
            #endregion
        
            #region Fields
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingFilters.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.ReadRecordsRequestUsingFilters"/></returns>
            public Android.Health.Connect.ReadRecordsRequestUsingFilters<T> Build()
            {
                return IExecuteWithSignature<Android.Health.Connect.ReadRecordsRequestUsingFilters<T>>("build", "()Landroid/health/connect/ReadRecordsRequestUsingFilters;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingFilters.Builder.html#addDataOrigins(android.health.connect.datatypes.DataOrigin)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Health.Connect.Datatypes.DataOrigin"/></param>
            /// <returns><see cref="Android.Health.Connect.ReadRecordsRequestUsingFilters.Builder"/></returns>
            public Android.Health.Connect.ReadRecordsRequestUsingFilters.Builder<T> AddDataOrigins(Android.Health.Connect.Datatypes.DataOrigin arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.ReadRecordsRequestUsingFilters.Builder<T>>("addDataOrigins", "(Landroid/health/connect/datatypes/DataOrigin;)Landroid/health/connect/ReadRecordsRequestUsingFilters$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingFilters.Builder.html#setAscending(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Health.Connect.ReadRecordsRequestUsingFilters.Builder"/></returns>
            public Android.Health.Connect.ReadRecordsRequestUsingFilters.Builder<T> SetAscending(bool arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.ReadRecordsRequestUsingFilters.Builder<T>>("setAscending", "(Z)Landroid/health/connect/ReadRecordsRequestUsingFilters$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingFilters.Builder.html#setPageSize(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Health.Connect.ReadRecordsRequestUsingFilters.Builder"/></returns>
            public Android.Health.Connect.ReadRecordsRequestUsingFilters.Builder<T> SetPageSize(int arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.ReadRecordsRequestUsingFilters.Builder<T>>("setPageSize", "(I)Landroid/health/connect/ReadRecordsRequestUsingFilters$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingFilters.Builder.html#setPageToken(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Health.Connect.ReadRecordsRequestUsingFilters.Builder"/></returns>
            public Android.Health.Connect.ReadRecordsRequestUsingFilters.Builder<T> SetPageToken(long arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.ReadRecordsRequestUsingFilters.Builder<T>>("setPageToken", "(J)Landroid/health/connect/ReadRecordsRequestUsingFilters$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingFilters.Builder.html#setTimeRangeFilter(android.health.connect.TimeRangeFilter)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Health.Connect.TimeRangeFilter"/></param>
            /// <returns><see cref="Android.Health.Connect.ReadRecordsRequestUsingFilters.Builder"/></returns>
            public Android.Health.Connect.ReadRecordsRequestUsingFilters.Builder<T> SetTimeRangeFilter(Android.Health.Connect.TimeRangeFilter arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.ReadRecordsRequestUsingFilters.Builder<T>>("setTimeRangeFilter", "(Landroid/health/connect/TimeRangeFilter;)Landroid/health/connect/ReadRecordsRequestUsingFilters$Builder;", arg0);
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

    #region ReadRecordsRequestUsingFilters<T> implementation
    public partial class ReadRecordsRequestUsingFilters<T>
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Health.Connect.ReadRecordsRequestUsingFilters{T}"/> to <see cref="Android.Health.Connect.ReadRecordsRequestUsingFilters"/>
        /// </summary>
        public static implicit operator Android.Health.Connect.ReadRecordsRequestUsingFilters(Android.Health.Connect.ReadRecordsRequestUsingFilters<T> t) => t.Cast<Android.Health.Connect.ReadRecordsRequestUsingFilters>();
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingFilters.html#getTimeRangeFilter()"/>
        /// </summary>
        /// <returns><see cref="Android.Health.Connect.TimeRangeFilter"/></returns>
        public Android.Health.Connect.TimeRangeFilter GetTimeRangeFilter()
        {
            return IExecuteWithSignature<Android.Health.Connect.TimeRangeFilter>("getTimeRangeFilter", "()Landroid/health/connect/TimeRangeFilter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingFilters.html#isAscending()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAscending()
        {
            return IExecuteWithSignature<bool>("isAscending", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingFilters.html#getPageSize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPageSize()
        {
            return IExecuteWithSignature<int>("getPageSize", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingFilters.html#getDataOrigins()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Android.Health.Connect.Datatypes.DataOrigin> GetDataOrigins()
        {
            return IExecuteWithSignature<Java.Util.Set<Android.Health.Connect.Datatypes.DataOrigin>>("getDataOrigins", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingFilters.html#getPageToken()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetPageToken()
        {
            return IExecuteWithSignature<long>("getPageToken", "()J");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}