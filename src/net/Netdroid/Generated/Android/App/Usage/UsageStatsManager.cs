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

namespace Android.App.Usage
{
    #region UsageStatsManager declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/app/usage/UsageStatsManager.html"/>
    /// </summary>
    public partial class UsageStatsManager : MASES.JCOBridge.C2JBridge.JVMBridgeBase<UsageStatsManager>
    {
        const string _bridgeClassName = "android.app.usage.UsageStatsManager";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public UsageStatsManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public UsageStatsManager(params object[] args) : base(args) { }

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

    #region UsageStatsManager implementation
    public partial class UsageStatsManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/UsageStatsManager.html#INTERVAL_BEST"/>
        /// </summary>
        public static int INTERVAL_BEST { get { if (!_INTERVAL_BESTReady) { _INTERVAL_BESTContent = SGetField<int>(LocalBridgeClazz, "INTERVAL_BEST"); _INTERVAL_BESTReady = true; } return _INTERVAL_BESTContent; } }
        private static int _INTERVAL_BESTContent = default;
        private static bool _INTERVAL_BESTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/UsageStatsManager.html#INTERVAL_DAILY"/>
        /// </summary>
        public static int INTERVAL_DAILY { get { if (!_INTERVAL_DAILYReady) { _INTERVAL_DAILYContent = SGetField<int>(LocalBridgeClazz, "INTERVAL_DAILY"); _INTERVAL_DAILYReady = true; } return _INTERVAL_DAILYContent; } }
        private static int _INTERVAL_DAILYContent = default;
        private static bool _INTERVAL_DAILYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/UsageStatsManager.html#INTERVAL_MONTHLY"/>
        /// </summary>
        public static int INTERVAL_MONTHLY { get { if (!_INTERVAL_MONTHLYReady) { _INTERVAL_MONTHLYContent = SGetField<int>(LocalBridgeClazz, "INTERVAL_MONTHLY"); _INTERVAL_MONTHLYReady = true; } return _INTERVAL_MONTHLYContent; } }
        private static int _INTERVAL_MONTHLYContent = default;
        private static bool _INTERVAL_MONTHLYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/UsageStatsManager.html#INTERVAL_WEEKLY"/>
        /// </summary>
        public static int INTERVAL_WEEKLY { get { if (!_INTERVAL_WEEKLYReady) { _INTERVAL_WEEKLYContent = SGetField<int>(LocalBridgeClazz, "INTERVAL_WEEKLY"); _INTERVAL_WEEKLYReady = true; } return _INTERVAL_WEEKLYContent; } }
        private static int _INTERVAL_WEEKLYContent = default;
        private static bool _INTERVAL_WEEKLYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/UsageStatsManager.html#INTERVAL_YEARLY"/>
        /// </summary>
        public static int INTERVAL_YEARLY { get { if (!_INTERVAL_YEARLYReady) { _INTERVAL_YEARLYContent = SGetField<int>(LocalBridgeClazz, "INTERVAL_YEARLY"); _INTERVAL_YEARLYReady = true; } return _INTERVAL_YEARLYContent; } }
        private static int _INTERVAL_YEARLYContent = default;
        private static bool _INTERVAL_YEARLYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/UsageStatsManager.html#STANDBY_BUCKET_ACTIVE"/>
        /// </summary>
        public static int STANDBY_BUCKET_ACTIVE { get { if (!_STANDBY_BUCKET_ACTIVEReady) { _STANDBY_BUCKET_ACTIVEContent = SGetField<int>(LocalBridgeClazz, "STANDBY_BUCKET_ACTIVE"); _STANDBY_BUCKET_ACTIVEReady = true; } return _STANDBY_BUCKET_ACTIVEContent; } }
        private static int _STANDBY_BUCKET_ACTIVEContent = default;
        private static bool _STANDBY_BUCKET_ACTIVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/UsageStatsManager.html#STANDBY_BUCKET_FREQUENT"/>
        /// </summary>
        public static int STANDBY_BUCKET_FREQUENT { get { if (!_STANDBY_BUCKET_FREQUENTReady) { _STANDBY_BUCKET_FREQUENTContent = SGetField<int>(LocalBridgeClazz, "STANDBY_BUCKET_FREQUENT"); _STANDBY_BUCKET_FREQUENTReady = true; } return _STANDBY_BUCKET_FREQUENTContent; } }
        private static int _STANDBY_BUCKET_FREQUENTContent = default;
        private static bool _STANDBY_BUCKET_FREQUENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/UsageStatsManager.html#STANDBY_BUCKET_RARE"/>
        /// </summary>
        public static int STANDBY_BUCKET_RARE { get { if (!_STANDBY_BUCKET_RAREReady) { _STANDBY_BUCKET_RAREContent = SGetField<int>(LocalBridgeClazz, "STANDBY_BUCKET_RARE"); _STANDBY_BUCKET_RAREReady = true; } return _STANDBY_BUCKET_RAREContent; } }
        private static int _STANDBY_BUCKET_RAREContent = default;
        private static bool _STANDBY_BUCKET_RAREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/UsageStatsManager.html#STANDBY_BUCKET_RESTRICTED"/>
        /// </summary>
        public static int STANDBY_BUCKET_RESTRICTED { get { if (!_STANDBY_BUCKET_RESTRICTEDReady) { _STANDBY_BUCKET_RESTRICTEDContent = SGetField<int>(LocalBridgeClazz, "STANDBY_BUCKET_RESTRICTED"); _STANDBY_BUCKET_RESTRICTEDReady = true; } return _STANDBY_BUCKET_RESTRICTEDContent; } }
        private static int _STANDBY_BUCKET_RESTRICTEDContent = default;
        private static bool _STANDBY_BUCKET_RESTRICTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/UsageStatsManager.html#STANDBY_BUCKET_WORKING_SET"/>
        /// </summary>
        public static int STANDBY_BUCKET_WORKING_SET { get { if (!_STANDBY_BUCKET_WORKING_SETReady) { _STANDBY_BUCKET_WORKING_SETContent = SGetField<int>(LocalBridgeClazz, "STANDBY_BUCKET_WORKING_SET"); _STANDBY_BUCKET_WORKING_SETReady = true; } return _STANDBY_BUCKET_WORKING_SETContent; } }
        private static int _STANDBY_BUCKET_WORKING_SETContent = default;
        private static bool _STANDBY_BUCKET_WORKING_SETReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/UsageStatsManager.html#EXTRA_EVENT_ACTION"/>
        /// </summary>
        public static Java.Lang.String EXTRA_EVENT_ACTION { get { if (!_EXTRA_EVENT_ACTIONReady) { _EXTRA_EVENT_ACTIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_EVENT_ACTION"); _EXTRA_EVENT_ACTIONReady = true; } return _EXTRA_EVENT_ACTIONContent; } }
        private static Java.Lang.String _EXTRA_EVENT_ACTIONContent = default;
        private static bool _EXTRA_EVENT_ACTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/UsageStatsManager.html#EXTRA_EVENT_CATEGORY"/>
        /// </summary>
        public static Java.Lang.String EXTRA_EVENT_CATEGORY { get { if (!_EXTRA_EVENT_CATEGORYReady) { _EXTRA_EVENT_CATEGORYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_EVENT_CATEGORY"); _EXTRA_EVENT_CATEGORYReady = true; } return _EXTRA_EVENT_CATEGORYContent; } }
        private static Java.Lang.String _EXTRA_EVENT_CATEGORYContent = default;
        private static bool _EXTRA_EVENT_CATEGORYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/UsageStatsManager.html#queryEvents(android.app.usage.UsageEventsQuery)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Usage.UsageEventsQuery"/></param>
        /// <returns><see cref="Android.App.Usage.UsageEvents"/></returns>
        public Android.App.Usage.UsageEvents QueryEvents(Android.App.Usage.UsageEventsQuery arg0)
        {
            return IExecuteWithSignature<Android.App.Usage.UsageEvents>("queryEvents", "(Landroid/app/usage/UsageEventsQuery;)Landroid/app/usage/UsageEvents;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/UsageStatsManager.html#queryEvents(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Android.App.Usage.UsageEvents"/></returns>
        public Android.App.Usage.UsageEvents QueryEvents(long arg0, long arg1)
        {
            return IExecute<Android.App.Usage.UsageEvents>("queryEvents", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/UsageStatsManager.html#queryEventsForSelf(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Android.App.Usage.UsageEvents"/></returns>
        public Android.App.Usage.UsageEvents QueryEventsForSelf(long arg0, long arg1)
        {
            return IExecute<Android.App.Usage.UsageEvents>("queryEventsForSelf", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/UsageStatsManager.html#isAppInactive(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAppInactive(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("isAppInactive", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/UsageStatsManager.html#getAppStandbyBucket()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetAppStandbyBucket()
        {
            return IExecuteWithSignature<int>("getAppStandbyBucket", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/UsageStatsManager.html#queryConfigurations(int,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.App.Usage.ConfigurationStats> QueryConfigurations(int arg0, long arg1, long arg2)
        {
            return IExecute<Java.Util.List<Android.App.Usage.ConfigurationStats>>("queryConfigurations", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/UsageStatsManager.html#queryEventStats(int,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.App.Usage.EventStats> QueryEventStats(int arg0, long arg1, long arg2)
        {
            return IExecute<Java.Util.List<Android.App.Usage.EventStats>>("queryEventStats", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/UsageStatsManager.html#queryUsageStats(int,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.App.Usage.UsageStats> QueryUsageStats(int arg0, long arg1, long arg2)
        {
            return IExecute<Java.Util.List<Android.App.Usage.UsageStats>>("queryUsageStats", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/UsageStatsManager.html#queryAndAggregateUsageStats(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Android.App.Usage.UsageStats> QueryAndAggregateUsageStats(long arg0, long arg1)
        {
            return IExecute<Java.Util.Map<Java.Lang.String, Android.App.Usage.UsageStats>>("queryAndAggregateUsageStats", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}