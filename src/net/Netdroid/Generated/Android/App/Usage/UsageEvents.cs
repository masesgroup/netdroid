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
    #region UsageEvents declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/app/usage/UsageEvents.html"/>
    /// </summary>
    public partial class UsageEvents : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.app.usage.UsageEvents";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public UsageEvents() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public UsageEvents(params object[] args) : base(args) { }
    
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
        #region Event declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/UsageEvents.Event.html"/>
        /// </summary>
        public partial class Event : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Event>
        {
            const string _bridgeClassName = "android.app.usage.UsageEvents$Event";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Event() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Event(params object[] args) : base(args) { }
        
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

    #region UsageEvents implementation
    public partial class UsageEvents
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/UsageEvents.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/UsageEvents.html#getNextEvent(android.app.usage.UsageEvents.Event)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Usage.UsageEvents.Event"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool GetNextEvent(Android.App.Usage.UsageEvents.Event arg0)
        {
            return IExecuteWithSignature<bool>("getNextEvent", "(Landroid/app/usage/UsageEvents$Event;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/UsageEvents.html#hasNextEvent()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasNextEvent()
        {
            return IExecuteWithSignature<bool>("hasNextEvent", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/UsageEvents.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/UsageEvents.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
        #region Event implementation
        public partial class Event
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/usage/UsageEvents.Event.html#ACTIVITY_PAUSED"/>
            /// </summary>
            public static int ACTIVITY_PAUSED { get { if (!_ACTIVITY_PAUSEDReady) { _ACTIVITY_PAUSEDContent = SGetField<int>(LocalBridgeClazz, "ACTIVITY_PAUSED"); _ACTIVITY_PAUSEDReady = true; } return _ACTIVITY_PAUSEDContent; } }
            private static int _ACTIVITY_PAUSEDContent = default;
            private static bool _ACTIVITY_PAUSEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/usage/UsageEvents.Event.html#ACTIVITY_RESUMED"/>
            /// </summary>
            public static int ACTIVITY_RESUMED { get { if (!_ACTIVITY_RESUMEDReady) { _ACTIVITY_RESUMEDContent = SGetField<int>(LocalBridgeClazz, "ACTIVITY_RESUMED"); _ACTIVITY_RESUMEDReady = true; } return _ACTIVITY_RESUMEDContent; } }
            private static int _ACTIVITY_RESUMEDContent = default;
            private static bool _ACTIVITY_RESUMEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/usage/UsageEvents.Event.html#ACTIVITY_STOPPED"/>
            /// </summary>
            public static int ACTIVITY_STOPPED { get { if (!_ACTIVITY_STOPPEDReady) { _ACTIVITY_STOPPEDContent = SGetField<int>(LocalBridgeClazz, "ACTIVITY_STOPPED"); _ACTIVITY_STOPPEDReady = true; } return _ACTIVITY_STOPPEDContent; } }
            private static int _ACTIVITY_STOPPEDContent = default;
            private static bool _ACTIVITY_STOPPEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/usage/UsageEvents.Event.html#CONFIGURATION_CHANGE"/>
            /// </summary>
            public static int CONFIGURATION_CHANGE { get { if (!_CONFIGURATION_CHANGEReady) { _CONFIGURATION_CHANGEContent = SGetField<int>(LocalBridgeClazz, "CONFIGURATION_CHANGE"); _CONFIGURATION_CHANGEReady = true; } return _CONFIGURATION_CHANGEContent; } }
            private static int _CONFIGURATION_CHANGEContent = default;
            private static bool _CONFIGURATION_CHANGEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/usage/UsageEvents.Event.html#DEVICE_SHUTDOWN"/>
            /// </summary>
            public static int DEVICE_SHUTDOWN { get { if (!_DEVICE_SHUTDOWNReady) { _DEVICE_SHUTDOWNContent = SGetField<int>(LocalBridgeClazz, "DEVICE_SHUTDOWN"); _DEVICE_SHUTDOWNReady = true; } return _DEVICE_SHUTDOWNContent; } }
            private static int _DEVICE_SHUTDOWNContent = default;
            private static bool _DEVICE_SHUTDOWNReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/usage/UsageEvents.Event.html#DEVICE_STARTUP"/>
            /// </summary>
            public static int DEVICE_STARTUP { get { if (!_DEVICE_STARTUPReady) { _DEVICE_STARTUPContent = SGetField<int>(LocalBridgeClazz, "DEVICE_STARTUP"); _DEVICE_STARTUPReady = true; } return _DEVICE_STARTUPContent; } }
            private static int _DEVICE_STARTUPContent = default;
            private static bool _DEVICE_STARTUPReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/usage/UsageEvents.Event.html#FOREGROUND_SERVICE_START"/>
            /// </summary>
            public static int FOREGROUND_SERVICE_START { get { if (!_FOREGROUND_SERVICE_STARTReady) { _FOREGROUND_SERVICE_STARTContent = SGetField<int>(LocalBridgeClazz, "FOREGROUND_SERVICE_START"); _FOREGROUND_SERVICE_STARTReady = true; } return _FOREGROUND_SERVICE_STARTContent; } }
            private static int _FOREGROUND_SERVICE_STARTContent = default;
            private static bool _FOREGROUND_SERVICE_STARTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/usage/UsageEvents.Event.html#FOREGROUND_SERVICE_STOP"/>
            /// </summary>
            public static int FOREGROUND_SERVICE_STOP { get { if (!_FOREGROUND_SERVICE_STOPReady) { _FOREGROUND_SERVICE_STOPContent = SGetField<int>(LocalBridgeClazz, "FOREGROUND_SERVICE_STOP"); _FOREGROUND_SERVICE_STOPReady = true; } return _FOREGROUND_SERVICE_STOPContent; } }
            private static int _FOREGROUND_SERVICE_STOPContent = default;
            private static bool _FOREGROUND_SERVICE_STOPReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/usage/UsageEvents.Event.html#KEYGUARD_HIDDEN"/>
            /// </summary>
            public static int KEYGUARD_HIDDEN { get { if (!_KEYGUARD_HIDDENReady) { _KEYGUARD_HIDDENContent = SGetField<int>(LocalBridgeClazz, "KEYGUARD_HIDDEN"); _KEYGUARD_HIDDENReady = true; } return _KEYGUARD_HIDDENContent; } }
            private static int _KEYGUARD_HIDDENContent = default;
            private static bool _KEYGUARD_HIDDENReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/usage/UsageEvents.Event.html#KEYGUARD_SHOWN"/>
            /// </summary>
            public static int KEYGUARD_SHOWN { get { if (!_KEYGUARD_SHOWNReady) { _KEYGUARD_SHOWNContent = SGetField<int>(LocalBridgeClazz, "KEYGUARD_SHOWN"); _KEYGUARD_SHOWNReady = true; } return _KEYGUARD_SHOWNContent; } }
            private static int _KEYGUARD_SHOWNContent = default;
            private static bool _KEYGUARD_SHOWNReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/usage/UsageEvents.Event.html#MOVE_TO_BACKGROUND"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int MOVE_TO_BACKGROUND { get { if (!_MOVE_TO_BACKGROUNDReady) { _MOVE_TO_BACKGROUNDContent = SGetField<int>(LocalBridgeClazz, "MOVE_TO_BACKGROUND"); _MOVE_TO_BACKGROUNDReady = true; } return _MOVE_TO_BACKGROUNDContent; } }
            private static int _MOVE_TO_BACKGROUNDContent = default;
            private static bool _MOVE_TO_BACKGROUNDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/usage/UsageEvents.Event.html#MOVE_TO_FOREGROUND"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int MOVE_TO_FOREGROUND { get { if (!_MOVE_TO_FOREGROUNDReady) { _MOVE_TO_FOREGROUNDContent = SGetField<int>(LocalBridgeClazz, "MOVE_TO_FOREGROUND"); _MOVE_TO_FOREGROUNDReady = true; } return _MOVE_TO_FOREGROUNDContent; } }
            private static int _MOVE_TO_FOREGROUNDContent = default;
            private static bool _MOVE_TO_FOREGROUNDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/usage/UsageEvents.Event.html#NONE"/>
            /// </summary>
            public static int NONE { get { if (!_NONEReady) { _NONEContent = SGetField<int>(LocalBridgeClazz, "NONE"); _NONEReady = true; } return _NONEContent; } }
            private static int _NONEContent = default;
            private static bool _NONEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/usage/UsageEvents.Event.html#SCREEN_INTERACTIVE"/>
            /// </summary>
            public static int SCREEN_INTERACTIVE { get { if (!_SCREEN_INTERACTIVEReady) { _SCREEN_INTERACTIVEContent = SGetField<int>(LocalBridgeClazz, "SCREEN_INTERACTIVE"); _SCREEN_INTERACTIVEReady = true; } return _SCREEN_INTERACTIVEContent; } }
            private static int _SCREEN_INTERACTIVEContent = default;
            private static bool _SCREEN_INTERACTIVEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/usage/UsageEvents.Event.html#SCREEN_NON_INTERACTIVE"/>
            /// </summary>
            public static int SCREEN_NON_INTERACTIVE { get { if (!_SCREEN_NON_INTERACTIVEReady) { _SCREEN_NON_INTERACTIVEContent = SGetField<int>(LocalBridgeClazz, "SCREEN_NON_INTERACTIVE"); _SCREEN_NON_INTERACTIVEReady = true; } return _SCREEN_NON_INTERACTIVEContent; } }
            private static int _SCREEN_NON_INTERACTIVEContent = default;
            private static bool _SCREEN_NON_INTERACTIVEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/usage/UsageEvents.Event.html#SHORTCUT_INVOCATION"/>
            /// </summary>
            public static int SHORTCUT_INVOCATION { get { if (!_SHORTCUT_INVOCATIONReady) { _SHORTCUT_INVOCATIONContent = SGetField<int>(LocalBridgeClazz, "SHORTCUT_INVOCATION"); _SHORTCUT_INVOCATIONReady = true; } return _SHORTCUT_INVOCATIONContent; } }
            private static int _SHORTCUT_INVOCATIONContent = default;
            private static bool _SHORTCUT_INVOCATIONReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/usage/UsageEvents.Event.html#STANDBY_BUCKET_CHANGED"/>
            /// </summary>
            public static int STANDBY_BUCKET_CHANGED { get { if (!_STANDBY_BUCKET_CHANGEDReady) { _STANDBY_BUCKET_CHANGEDContent = SGetField<int>(LocalBridgeClazz, "STANDBY_BUCKET_CHANGED"); _STANDBY_BUCKET_CHANGEDReady = true; } return _STANDBY_BUCKET_CHANGEDContent; } }
            private static int _STANDBY_BUCKET_CHANGEDContent = default;
            private static bool _STANDBY_BUCKET_CHANGEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/usage/UsageEvents.Event.html#USER_INTERACTION"/>
            /// </summary>
            public static int USER_INTERACTION { get { if (!_USER_INTERACTIONReady) { _USER_INTERACTIONContent = SGetField<int>(LocalBridgeClazz, "USER_INTERACTION"); _USER_INTERACTIONReady = true; } return _USER_INTERACTIONContent; } }
            private static int _USER_INTERACTIONContent = default;
            private static bool _USER_INTERACTIONReady = false; // this is used because in case of generics 
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/usage/UsageEvents.Event.html#getConfiguration()"/>
            /// </summary>
            /// <returns><see cref="Android.Content.Res.Configuration"/></returns>
            public Android.Content.Res.Configuration GetConfiguration()
            {
                return IExecuteWithSignature<Android.Content.Res.Configuration>("getConfiguration", "()Landroid/content/res/Configuration;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/usage/UsageEvents.Event.html#getExtras()"/>
            /// </summary>
            /// <returns><see cref="Android.Os.PersistableBundle"/></returns>
            public Android.Os.PersistableBundle GetExtras()
            {
                return IExecuteWithSignature<Android.Os.PersistableBundle>("getExtras", "()Landroid/os/PersistableBundle;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/usage/UsageEvents.Event.html#getAppStandbyBucket()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetAppStandbyBucket()
            {
                return IExecuteWithSignature<int>("getAppStandbyBucket", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/usage/UsageEvents.Event.html#getEventType()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetEventType()
            {
                return IExecuteWithSignature<int>("getEventType", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/usage/UsageEvents.Event.html#getClassName()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetClassName()
            {
                return IExecuteWithSignature<Java.Lang.String>("getClassName", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/usage/UsageEvents.Event.html#getPackageName()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetPackageName()
            {
                return IExecuteWithSignature<Java.Lang.String>("getPackageName", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/usage/UsageEvents.Event.html#getShortcutId()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetShortcutId()
            {
                return IExecuteWithSignature<Java.Lang.String>("getShortcutId", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/usage/UsageEvents.Event.html#getTimeStamp()"/>
            /// </summary>
            /// <returns><see cref="long"/></returns>
            public long GetTimeStamp()
            {
                return IExecuteWithSignature<long>("getTimeStamp", "()J");
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