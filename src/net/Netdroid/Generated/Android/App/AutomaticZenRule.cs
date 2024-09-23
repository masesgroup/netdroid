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

namespace Android.App
{
    #region AutomaticZenRule declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.html"/>
    /// </summary>
    public partial class AutomaticZenRule : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.app.AutomaticZenRule";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AutomaticZenRule() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AutomaticZenRule(params object[] args) : base(args) { }
    
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
        /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.app.AutomaticZenRule$Builder";
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

    #region AutomaticZenRule implementation
    public partial class AutomaticZenRule
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.html#%3Cinit%3E(android.os.Parcel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        public AutomaticZenRule(Android.Os.Parcel arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.html#%3Cinit%3E(java.lang.String,android.content.ComponentName,android.content.ComponentName,android.net.Uri,android.service.notification.ZenPolicy,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Content.ComponentName"/></param>
        /// <param name="arg2"><see cref="Android.Content.ComponentName"/></param>
        /// <param name="arg3"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg4"><see cref="Android.Service.Notification.ZenPolicy"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="bool"/></param>
        public AutomaticZenRule(Java.Lang.String arg0, Android.Content.ComponentName arg1, Android.Content.ComponentName arg2, Android.Net.Uri arg3, Android.Service.Notification.ZenPolicy arg4, int arg5, bool arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.html#%3Cinit%3E(java.lang.String,android.content.ComponentName,android.net.Uri,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Content.ComponentName"/></param>
        /// <param name="arg2"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public AutomaticZenRule(Java.Lang.String arg0, Android.Content.ComponentName arg1, Android.Net.Uri arg2, int arg3, bool arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.html#TYPE_BEDTIME"/>
        /// </summary>
        public static int TYPE_BEDTIME { get { if (!_TYPE_BEDTIMEReady) { _TYPE_BEDTIMEContent = SGetField<int>(LocalBridgeClazz, "TYPE_BEDTIME"); _TYPE_BEDTIMEReady = true; } return _TYPE_BEDTIMEContent; } }
        private static int _TYPE_BEDTIMEContent = default;
        private static bool _TYPE_BEDTIMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.html#TYPE_DRIVING"/>
        /// </summary>
        public static int TYPE_DRIVING { get { if (!_TYPE_DRIVINGReady) { _TYPE_DRIVINGContent = SGetField<int>(LocalBridgeClazz, "TYPE_DRIVING"); _TYPE_DRIVINGReady = true; } return _TYPE_DRIVINGContent; } }
        private static int _TYPE_DRIVINGContent = default;
        private static bool _TYPE_DRIVINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.html#TYPE_IMMERSIVE"/>
        /// </summary>
        public static int TYPE_IMMERSIVE { get { if (!_TYPE_IMMERSIVEReady) { _TYPE_IMMERSIVEContent = SGetField<int>(LocalBridgeClazz, "TYPE_IMMERSIVE"); _TYPE_IMMERSIVEReady = true; } return _TYPE_IMMERSIVEContent; } }
        private static int _TYPE_IMMERSIVEContent = default;
        private static bool _TYPE_IMMERSIVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.html#TYPE_MANAGED"/>
        /// </summary>
        public static int TYPE_MANAGED { get { if (!_TYPE_MANAGEDReady) { _TYPE_MANAGEDContent = SGetField<int>(LocalBridgeClazz, "TYPE_MANAGED"); _TYPE_MANAGEDReady = true; } return _TYPE_MANAGEDContent; } }
        private static int _TYPE_MANAGEDContent = default;
        private static bool _TYPE_MANAGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.html#TYPE_OTHER"/>
        /// </summary>
        public static int TYPE_OTHER { get { if (!_TYPE_OTHERReady) { _TYPE_OTHERContent = SGetField<int>(LocalBridgeClazz, "TYPE_OTHER"); _TYPE_OTHERReady = true; } return _TYPE_OTHERContent; } }
        private static int _TYPE_OTHERContent = default;
        private static bool _TYPE_OTHERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.html#TYPE_SCHEDULE_CALENDAR"/>
        /// </summary>
        public static int TYPE_SCHEDULE_CALENDAR { get { if (!_TYPE_SCHEDULE_CALENDARReady) { _TYPE_SCHEDULE_CALENDARContent = SGetField<int>(LocalBridgeClazz, "TYPE_SCHEDULE_CALENDAR"); _TYPE_SCHEDULE_CALENDARReady = true; } return _TYPE_SCHEDULE_CALENDARContent; } }
        private static int _TYPE_SCHEDULE_CALENDARContent = default;
        private static bool _TYPE_SCHEDULE_CALENDARReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.html#TYPE_SCHEDULE_TIME"/>
        /// </summary>
        public static int TYPE_SCHEDULE_TIME { get { if (!_TYPE_SCHEDULE_TIMEReady) { _TYPE_SCHEDULE_TIMEContent = SGetField<int>(LocalBridgeClazz, "TYPE_SCHEDULE_TIME"); _TYPE_SCHEDULE_TIMEReady = true; } return _TYPE_SCHEDULE_TIMEContent; } }
        private static int _TYPE_SCHEDULE_TIMEContent = default;
        private static bool _TYPE_SCHEDULE_TIMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.html#TYPE_THEATER"/>
        /// </summary>
        public static int TYPE_THEATER { get { if (!_TYPE_THEATERReady) { _TYPE_THEATERContent = SGetField<int>(LocalBridgeClazz, "TYPE_THEATER"); _TYPE_THEATERReady = true; } return _TYPE_THEATERContent; } }
        private static int _TYPE_THEATERContent = default;
        private static bool _TYPE_THEATERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.html#TYPE_UNKNOWN"/>
        /// </summary>
        public static int TYPE_UNKNOWN { get { if (!_TYPE_UNKNOWNReady) { _TYPE_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "TYPE_UNKNOWN"); _TYPE_UNKNOWNReady = true; } return _TYPE_UNKNOWNContent; } }
        private static int _TYPE_UNKNOWNContent = default;
        private static bool _TYPE_UNKNOWNReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.html#getConfigurationActivity()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.ComponentName"/></returns>
        public Android.Content.ComponentName GetConfigurationActivity()
        {
            return IExecuteWithSignature<Android.Content.ComponentName>("getConfigurationActivity", "()Landroid/content/ComponentName;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.html#getOwner()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.ComponentName"/></returns>
        public Android.Content.ComponentName GetOwner()
        {
            return IExecuteWithSignature<Android.Content.ComponentName>("getOwner", "()Landroid/content/ComponentName;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.html#getConditionId()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        public Android.Net.Uri GetConditionId()
        {
            return IExecuteWithSignature<Android.Net.Uri>("getConditionId", "()Landroid/net/Uri;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.html#getDeviceEffects()"/>
        /// </summary>
        /// <returns><see cref="Android.Service.Notification.ZenDeviceEffects"/></returns>
        public Android.Service.Notification.ZenDeviceEffects GetDeviceEffects()
        {
            return IExecuteWithSignature<Android.Service.Notification.ZenDeviceEffects>("getDeviceEffects", "()Landroid/service/notification/ZenDeviceEffects;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.html#getZenPolicy()"/>
        /// </summary>
        /// <returns><see cref="Android.Service.Notification.ZenPolicy"/></returns>
        public Android.Service.Notification.ZenPolicy GetZenPolicy()
        {
            return IExecuteWithSignature<Android.Service.Notification.ZenPolicy>("getZenPolicy", "()Landroid/service/notification/ZenPolicy;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.html#isEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEnabled()
        {
            return IExecuteWithSignature<bool>("isEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.html#isManualInvocationAllowed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsManualInvocationAllowed()
        {
            return IExecuteWithSignature<bool>("isManualInvocationAllowed", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.html#getIconResId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetIconResId()
        {
            return IExecuteWithSignature<int>("getIconResId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.html#getInterruptionFilter()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetInterruptionFilter()
        {
            return IExecuteWithSignature<int>("getInterruptionFilter", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.html#getType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetType()
        {
            return IExecuteWithSignature<int>("getType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.html#getName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.html#getTriggerDescription()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetTriggerDescription()
        {
            return IExecuteWithSignature<Java.Lang.String>("getTriggerDescription", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.html#getCreationTime()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetCreationTime()
        {
            return IExecuteWithSignature<long>("getCreationTime", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.html#setConditionId(android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        public void SetConditionId(Android.Net.Uri arg0)
        {
            IExecuteWithSignature("setConditionId", "(Landroid/net/Uri;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.html#setConfigurationActivity(android.content.ComponentName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        public void SetConfigurationActivity(Android.Content.ComponentName arg0)
        {
            IExecuteWithSignature("setConfigurationActivity", "(Landroid/content/ComponentName;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.html#setDeviceEffects(android.service.notification.ZenDeviceEffects)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Service.Notification.ZenDeviceEffects"/></param>
        public void SetDeviceEffects(Android.Service.Notification.ZenDeviceEffects arg0)
        {
            IExecuteWithSignature("setDeviceEffects", "(Landroid/service/notification/ZenDeviceEffects;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.html#setEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetEnabled(bool arg0)
        {
            IExecuteWithSignature("setEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.html#setInterruptionFilter(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetInterruptionFilter(int arg0)
        {
            IExecuteWithSignature("setInterruptionFilter", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.html#setName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetName(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setName", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.html#setZenPolicy(android.service.notification.ZenPolicy)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Service.Notification.ZenPolicy"/></param>
        public void SetZenPolicy(Android.Service.Notification.ZenPolicy arg0)
        {
            IExecuteWithSignature("setZenPolicy", "(Landroid/service/notification/ZenPolicy;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.Builder.html#%3Cinit%3E(android.app.AutomaticZenRule)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.AutomaticZenRule"/></param>
            public Builder(Android.App.AutomaticZenRule arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.Builder.html#%3Cinit%3E(java.lang.String,android.net.Uri)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.Net.Uri"/></param>
            public Builder(Java.Lang.String arg0, Android.Net.Uri arg1)
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
            /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.App.AutomaticZenRule"/></returns>
            public Android.App.AutomaticZenRule Build()
            {
                return IExecuteWithSignature<Android.App.AutomaticZenRule>("build", "()Landroid/app/AutomaticZenRule;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.Builder.html#setConditionId(android.net.Uri)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
            /// <returns><see cref="Android.App.AutomaticZenRule.Builder"/></returns>
            public Android.App.AutomaticZenRule.Builder SetConditionId(Android.Net.Uri arg0)
            {
                return IExecuteWithSignature<Android.App.AutomaticZenRule.Builder>("setConditionId", "(Landroid/net/Uri;)Landroid/app/AutomaticZenRule$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.Builder.html#setConfigurationActivity(android.content.ComponentName)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
            /// <returns><see cref="Android.App.AutomaticZenRule.Builder"/></returns>
            public Android.App.AutomaticZenRule.Builder SetConfigurationActivity(Android.Content.ComponentName arg0)
            {
                return IExecuteWithSignature<Android.App.AutomaticZenRule.Builder>("setConfigurationActivity", "(Landroid/content/ComponentName;)Landroid/app/AutomaticZenRule$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.Builder.html#setDeviceEffects(android.service.notification.ZenDeviceEffects)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Service.Notification.ZenDeviceEffects"/></param>
            /// <returns><see cref="Android.App.AutomaticZenRule.Builder"/></returns>
            public Android.App.AutomaticZenRule.Builder SetDeviceEffects(Android.Service.Notification.ZenDeviceEffects arg0)
            {
                return IExecuteWithSignature<Android.App.AutomaticZenRule.Builder>("setDeviceEffects", "(Landroid/service/notification/ZenDeviceEffects;)Landroid/app/AutomaticZenRule$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.Builder.html#setEnabled(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.App.AutomaticZenRule.Builder"/></returns>
            public Android.App.AutomaticZenRule.Builder SetEnabled(bool arg0)
            {
                return IExecuteWithSignature<Android.App.AutomaticZenRule.Builder>("setEnabled", "(Z)Landroid/app/AutomaticZenRule$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.Builder.html#setIconResId(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.App.AutomaticZenRule.Builder"/></returns>
            public Android.App.AutomaticZenRule.Builder SetIconResId(int arg0)
            {
                return IExecuteWithSignature<Android.App.AutomaticZenRule.Builder>("setIconResId", "(I)Landroid/app/AutomaticZenRule$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.Builder.html#setInterruptionFilter(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.App.AutomaticZenRule.Builder"/></returns>
            public Android.App.AutomaticZenRule.Builder SetInterruptionFilter(int arg0)
            {
                return IExecuteWithSignature<Android.App.AutomaticZenRule.Builder>("setInterruptionFilter", "(I)Landroid/app/AutomaticZenRule$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.Builder.html#setManualInvocationAllowed(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.App.AutomaticZenRule.Builder"/></returns>
            public Android.App.AutomaticZenRule.Builder SetManualInvocationAllowed(bool arg0)
            {
                return IExecuteWithSignature<Android.App.AutomaticZenRule.Builder>("setManualInvocationAllowed", "(Z)Landroid/app/AutomaticZenRule$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.Builder.html#setName(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.App.AutomaticZenRule.Builder"/></returns>
            public Android.App.AutomaticZenRule.Builder SetName(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.App.AutomaticZenRule.Builder>("setName", "(Ljava/lang/String;)Landroid/app/AutomaticZenRule$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.Builder.html#setOwner(android.content.ComponentName)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
            /// <returns><see cref="Android.App.AutomaticZenRule.Builder"/></returns>
            public Android.App.AutomaticZenRule.Builder SetOwner(Android.Content.ComponentName arg0)
            {
                return IExecuteWithSignature<Android.App.AutomaticZenRule.Builder>("setOwner", "(Landroid/content/ComponentName;)Landroid/app/AutomaticZenRule$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.Builder.html#setTriggerDescription(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.App.AutomaticZenRule.Builder"/></returns>
            public Android.App.AutomaticZenRule.Builder SetTriggerDescription(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.App.AutomaticZenRule.Builder>("setTriggerDescription", "(Ljava/lang/String;)Landroid/app/AutomaticZenRule$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.Builder.html#setType(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.App.AutomaticZenRule.Builder"/></returns>
            public Android.App.AutomaticZenRule.Builder SetType(int arg0)
            {
                return IExecuteWithSignature<Android.App.AutomaticZenRule.Builder>("setType", "(I)Landroid/app/AutomaticZenRule$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/AutomaticZenRule.Builder.html#setZenPolicy(android.service.notification.ZenPolicy)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Service.Notification.ZenPolicy"/></param>
            /// <returns><see cref="Android.App.AutomaticZenRule.Builder"/></returns>
            public Android.App.AutomaticZenRule.Builder SetZenPolicy(Android.Service.Notification.ZenPolicy arg0)
            {
                return IExecuteWithSignature<Android.App.AutomaticZenRule.Builder>("setZenPolicy", "(Landroid/service/notification/ZenPolicy;)Landroid/app/AutomaticZenRule$Builder;", arg0);
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