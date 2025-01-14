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

namespace Android.Service.Notification
{
    #region ZenPolicy declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.html"/>
    /// </summary>
    public partial class ZenPolicy : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.service.notification.ZenPolicy";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ZenPolicy() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ZenPolicy(params object[] args) : base(args) { }
    
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
        /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.service.notification.ZenPolicy$Builder";
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

    #region ZenPolicy implementation
    public partial class ZenPolicy
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.html#CONVERSATION_SENDERS_ANYONE"/>
        /// </summary>
        public static int CONVERSATION_SENDERS_ANYONE { get { if (!_CONVERSATION_SENDERS_ANYONEReady) { _CONVERSATION_SENDERS_ANYONEContent = SGetField<int>(LocalBridgeClazz, "CONVERSATION_SENDERS_ANYONE"); _CONVERSATION_SENDERS_ANYONEReady = true; } return _CONVERSATION_SENDERS_ANYONEContent; } }
        private static int _CONVERSATION_SENDERS_ANYONEContent = default;
        private static bool _CONVERSATION_SENDERS_ANYONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.html#CONVERSATION_SENDERS_IMPORTANT"/>
        /// </summary>
        public static int CONVERSATION_SENDERS_IMPORTANT { get { if (!_CONVERSATION_SENDERS_IMPORTANTReady) { _CONVERSATION_SENDERS_IMPORTANTContent = SGetField<int>(LocalBridgeClazz, "CONVERSATION_SENDERS_IMPORTANT"); _CONVERSATION_SENDERS_IMPORTANTReady = true; } return _CONVERSATION_SENDERS_IMPORTANTContent; } }
        private static int _CONVERSATION_SENDERS_IMPORTANTContent = default;
        private static bool _CONVERSATION_SENDERS_IMPORTANTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.html#CONVERSATION_SENDERS_NONE"/>
        /// </summary>
        public static int CONVERSATION_SENDERS_NONE { get { if (!_CONVERSATION_SENDERS_NONEReady) { _CONVERSATION_SENDERS_NONEContent = SGetField<int>(LocalBridgeClazz, "CONVERSATION_SENDERS_NONE"); _CONVERSATION_SENDERS_NONEReady = true; } return _CONVERSATION_SENDERS_NONEContent; } }
        private static int _CONVERSATION_SENDERS_NONEContent = default;
        private static bool _CONVERSATION_SENDERS_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.html#CONVERSATION_SENDERS_UNSET"/>
        /// </summary>
        public static int CONVERSATION_SENDERS_UNSET { get { if (!_CONVERSATION_SENDERS_UNSETReady) { _CONVERSATION_SENDERS_UNSETContent = SGetField<int>(LocalBridgeClazz, "CONVERSATION_SENDERS_UNSET"); _CONVERSATION_SENDERS_UNSETReady = true; } return _CONVERSATION_SENDERS_UNSETContent; } }
        private static int _CONVERSATION_SENDERS_UNSETContent = default;
        private static bool _CONVERSATION_SENDERS_UNSETReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.html#PEOPLE_TYPE_ANYONE"/>
        /// </summary>
        public static int PEOPLE_TYPE_ANYONE { get { if (!_PEOPLE_TYPE_ANYONEReady) { _PEOPLE_TYPE_ANYONEContent = SGetField<int>(LocalBridgeClazz, "PEOPLE_TYPE_ANYONE"); _PEOPLE_TYPE_ANYONEReady = true; } return _PEOPLE_TYPE_ANYONEContent; } }
        private static int _PEOPLE_TYPE_ANYONEContent = default;
        private static bool _PEOPLE_TYPE_ANYONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.html#PEOPLE_TYPE_CONTACTS"/>
        /// </summary>
        public static int PEOPLE_TYPE_CONTACTS { get { if (!_PEOPLE_TYPE_CONTACTSReady) { _PEOPLE_TYPE_CONTACTSContent = SGetField<int>(LocalBridgeClazz, "PEOPLE_TYPE_CONTACTS"); _PEOPLE_TYPE_CONTACTSReady = true; } return _PEOPLE_TYPE_CONTACTSContent; } }
        private static int _PEOPLE_TYPE_CONTACTSContent = default;
        private static bool _PEOPLE_TYPE_CONTACTSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.html#PEOPLE_TYPE_NONE"/>
        /// </summary>
        public static int PEOPLE_TYPE_NONE { get { if (!_PEOPLE_TYPE_NONEReady) { _PEOPLE_TYPE_NONEContent = SGetField<int>(LocalBridgeClazz, "PEOPLE_TYPE_NONE"); _PEOPLE_TYPE_NONEReady = true; } return _PEOPLE_TYPE_NONEContent; } }
        private static int _PEOPLE_TYPE_NONEContent = default;
        private static bool _PEOPLE_TYPE_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.html#PEOPLE_TYPE_STARRED"/>
        /// </summary>
        public static int PEOPLE_TYPE_STARRED { get { if (!_PEOPLE_TYPE_STARREDReady) { _PEOPLE_TYPE_STARREDContent = SGetField<int>(LocalBridgeClazz, "PEOPLE_TYPE_STARRED"); _PEOPLE_TYPE_STARREDReady = true; } return _PEOPLE_TYPE_STARREDContent; } }
        private static int _PEOPLE_TYPE_STARREDContent = default;
        private static bool _PEOPLE_TYPE_STARREDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.html#PEOPLE_TYPE_UNSET"/>
        /// </summary>
        public static int PEOPLE_TYPE_UNSET { get { if (!_PEOPLE_TYPE_UNSETReady) { _PEOPLE_TYPE_UNSETContent = SGetField<int>(LocalBridgeClazz, "PEOPLE_TYPE_UNSET"); _PEOPLE_TYPE_UNSETReady = true; } return _PEOPLE_TYPE_UNSETContent; } }
        private static int _PEOPLE_TYPE_UNSETContent = default;
        private static bool _PEOPLE_TYPE_UNSETReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.html#STATE_ALLOW"/>
        /// </summary>
        public static int STATE_ALLOW { get { if (!_STATE_ALLOWReady) { _STATE_ALLOWContent = SGetField<int>(LocalBridgeClazz, "STATE_ALLOW"); _STATE_ALLOWReady = true; } return _STATE_ALLOWContent; } }
        private static int _STATE_ALLOWContent = default;
        private static bool _STATE_ALLOWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.html#STATE_DISALLOW"/>
        /// </summary>
        public static int STATE_DISALLOW { get { if (!_STATE_DISALLOWReady) { _STATE_DISALLOWContent = SGetField<int>(LocalBridgeClazz, "STATE_DISALLOW"); _STATE_DISALLOWReady = true; } return _STATE_DISALLOWContent; } }
        private static int _STATE_DISALLOWContent = default;
        private static bool _STATE_DISALLOWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.html#STATE_UNSET"/>
        /// </summary>
        public static int STATE_UNSET { get { if (!_STATE_UNSETReady) { _STATE_UNSETContent = SGetField<int>(LocalBridgeClazz, "STATE_UNSET"); _STATE_UNSETReady = true; } return _STATE_UNSETContent; } }
        private static int _STATE_UNSETContent = default;
        private static bool _STATE_UNSETReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.html#getPriorityCallSenders()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPriorityCallSenders()
        {
            return IExecuteWithSignature<int>("getPriorityCallSenders", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.html#getPriorityCategoryAlarms()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPriorityCategoryAlarms()
        {
            return IExecuteWithSignature<int>("getPriorityCategoryAlarms", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.html#getPriorityCategoryCalls()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPriorityCategoryCalls()
        {
            return IExecuteWithSignature<int>("getPriorityCategoryCalls", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.html#getPriorityCategoryConversations()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPriorityCategoryConversations()
        {
            return IExecuteWithSignature<int>("getPriorityCategoryConversations", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.html#getPriorityCategoryEvents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPriorityCategoryEvents()
        {
            return IExecuteWithSignature<int>("getPriorityCategoryEvents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.html#getPriorityCategoryMedia()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPriorityCategoryMedia()
        {
            return IExecuteWithSignature<int>("getPriorityCategoryMedia", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.html#getPriorityCategoryMessages()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPriorityCategoryMessages()
        {
            return IExecuteWithSignature<int>("getPriorityCategoryMessages", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.html#getPriorityCategoryReminders()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPriorityCategoryReminders()
        {
            return IExecuteWithSignature<int>("getPriorityCategoryReminders", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.html#getPriorityCategoryRepeatCallers()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPriorityCategoryRepeatCallers()
        {
            return IExecuteWithSignature<int>("getPriorityCategoryRepeatCallers", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.html#getPriorityCategorySystem()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPriorityCategorySystem()
        {
            return IExecuteWithSignature<int>("getPriorityCategorySystem", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.html#getPriorityChannelsAllowed()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPriorityChannelsAllowed()
        {
            return IExecuteWithSignature<int>("getPriorityChannelsAllowed", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.html#getPriorityConversationSenders()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPriorityConversationSenders()
        {
            return IExecuteWithSignature<int>("getPriorityConversationSenders", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.html#getPriorityMessageSenders()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPriorityMessageSenders()
        {
            return IExecuteWithSignature<int>("getPriorityMessageSenders", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.html#getVisualEffectAmbient()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetVisualEffectAmbient()
        {
            return IExecuteWithSignature<int>("getVisualEffectAmbient", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.html#getVisualEffectBadge()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetVisualEffectBadge()
        {
            return IExecuteWithSignature<int>("getVisualEffectBadge", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.html#getVisualEffectFullScreenIntent()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetVisualEffectFullScreenIntent()
        {
            return IExecuteWithSignature<int>("getVisualEffectFullScreenIntent", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.html#getVisualEffectLights()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetVisualEffectLights()
        {
            return IExecuteWithSignature<int>("getVisualEffectLights", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.html#getVisualEffectNotificationList()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetVisualEffectNotificationList()
        {
            return IExecuteWithSignature<int>("getVisualEffectNotificationList", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.html#getVisualEffectPeek()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetVisualEffectPeek()
        {
            return IExecuteWithSignature<int>("getVisualEffectPeek", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.html#getVisualEffectStatusBar()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetVisualEffectStatusBar()
        {
            return IExecuteWithSignature<int>("getVisualEffectStatusBar", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecuteWithSignature("writeToParcel", "(Landroid/os/Parcel;I)V", arg0, arg1);
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
            /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Service.Notification.ZenPolicy"/></returns>
            public Android.Service.Notification.ZenPolicy Build()
            {
                return IExecuteWithSignature<Android.Service.Notification.ZenPolicy>("build", "()Landroid/service/notification/ZenPolicy;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.Builder.html#allowAlarms(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Service.Notification.ZenPolicy.Builder"/></returns>
            public Android.Service.Notification.ZenPolicy.Builder AllowAlarms(bool arg0)
            {
                return IExecuteWithSignature<Android.Service.Notification.ZenPolicy.Builder>("allowAlarms", "(Z)Landroid/service/notification/ZenPolicy$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.Builder.html#allowAllSounds()"/>
            /// </summary>
            /// <returns><see cref="Android.Service.Notification.ZenPolicy.Builder"/></returns>
            public Android.Service.Notification.ZenPolicy.Builder AllowAllSounds()
            {
                return IExecuteWithSignature<Android.Service.Notification.ZenPolicy.Builder>("allowAllSounds", "()Landroid/service/notification/ZenPolicy$Builder;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.Builder.html#allowCalls(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Service.Notification.ZenPolicy.Builder"/></returns>
            public Android.Service.Notification.ZenPolicy.Builder AllowCalls(int arg0)
            {
                return IExecuteWithSignature<Android.Service.Notification.ZenPolicy.Builder>("allowCalls", "(I)Landroid/service/notification/ZenPolicy$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.Builder.html#allowConversations(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Service.Notification.ZenPolicy.Builder"/></returns>
            public Android.Service.Notification.ZenPolicy.Builder AllowConversations(int arg0)
            {
                return IExecuteWithSignature<Android.Service.Notification.ZenPolicy.Builder>("allowConversations", "(I)Landroid/service/notification/ZenPolicy$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.Builder.html#allowEvents(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Service.Notification.ZenPolicy.Builder"/></returns>
            public Android.Service.Notification.ZenPolicy.Builder AllowEvents(bool arg0)
            {
                return IExecuteWithSignature<Android.Service.Notification.ZenPolicy.Builder>("allowEvents", "(Z)Landroid/service/notification/ZenPolicy$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.Builder.html#allowMedia(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Service.Notification.ZenPolicy.Builder"/></returns>
            public Android.Service.Notification.ZenPolicy.Builder AllowMedia(bool arg0)
            {
                return IExecuteWithSignature<Android.Service.Notification.ZenPolicy.Builder>("allowMedia", "(Z)Landroid/service/notification/ZenPolicy$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.Builder.html#allowMessages(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Service.Notification.ZenPolicy.Builder"/></returns>
            public Android.Service.Notification.ZenPolicy.Builder AllowMessages(int arg0)
            {
                return IExecuteWithSignature<Android.Service.Notification.ZenPolicy.Builder>("allowMessages", "(I)Landroid/service/notification/ZenPolicy$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.Builder.html#allowPriorityChannels(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Service.Notification.ZenPolicy.Builder"/></returns>
            public Android.Service.Notification.ZenPolicy.Builder AllowPriorityChannels(bool arg0)
            {
                return IExecuteWithSignature<Android.Service.Notification.ZenPolicy.Builder>("allowPriorityChannels", "(Z)Landroid/service/notification/ZenPolicy$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.Builder.html#allowReminders(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Service.Notification.ZenPolicy.Builder"/></returns>
            public Android.Service.Notification.ZenPolicy.Builder AllowReminders(bool arg0)
            {
                return IExecuteWithSignature<Android.Service.Notification.ZenPolicy.Builder>("allowReminders", "(Z)Landroid/service/notification/ZenPolicy$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.Builder.html#allowRepeatCallers(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Service.Notification.ZenPolicy.Builder"/></returns>
            public Android.Service.Notification.ZenPolicy.Builder AllowRepeatCallers(bool arg0)
            {
                return IExecuteWithSignature<Android.Service.Notification.ZenPolicy.Builder>("allowRepeatCallers", "(Z)Landroid/service/notification/ZenPolicy$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.Builder.html#allowSystem(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Service.Notification.ZenPolicy.Builder"/></returns>
            public Android.Service.Notification.ZenPolicy.Builder AllowSystem(bool arg0)
            {
                return IExecuteWithSignature<Android.Service.Notification.ZenPolicy.Builder>("allowSystem", "(Z)Landroid/service/notification/ZenPolicy$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.Builder.html#disallowAllSounds()"/>
            /// </summary>
            /// <returns><see cref="Android.Service.Notification.ZenPolicy.Builder"/></returns>
            public Android.Service.Notification.ZenPolicy.Builder DisallowAllSounds()
            {
                return IExecuteWithSignature<Android.Service.Notification.ZenPolicy.Builder>("disallowAllSounds", "()Landroid/service/notification/ZenPolicy$Builder;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.Builder.html#hideAllVisualEffects()"/>
            /// </summary>
            /// <returns><see cref="Android.Service.Notification.ZenPolicy.Builder"/></returns>
            public Android.Service.Notification.ZenPolicy.Builder HideAllVisualEffects()
            {
                return IExecuteWithSignature<Android.Service.Notification.ZenPolicy.Builder>("hideAllVisualEffects", "()Landroid/service/notification/ZenPolicy$Builder;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.Builder.html#showAllVisualEffects()"/>
            /// </summary>
            /// <returns><see cref="Android.Service.Notification.ZenPolicy.Builder"/></returns>
            public Android.Service.Notification.ZenPolicy.Builder ShowAllVisualEffects()
            {
                return IExecuteWithSignature<Android.Service.Notification.ZenPolicy.Builder>("showAllVisualEffects", "()Landroid/service/notification/ZenPolicy$Builder;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.Builder.html#showBadges(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Service.Notification.ZenPolicy.Builder"/></returns>
            public Android.Service.Notification.ZenPolicy.Builder ShowBadges(bool arg0)
            {
                return IExecuteWithSignature<Android.Service.Notification.ZenPolicy.Builder>("showBadges", "(Z)Landroid/service/notification/ZenPolicy$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.Builder.html#showFullScreenIntent(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Service.Notification.ZenPolicy.Builder"/></returns>
            public Android.Service.Notification.ZenPolicy.Builder ShowFullScreenIntent(bool arg0)
            {
                return IExecuteWithSignature<Android.Service.Notification.ZenPolicy.Builder>("showFullScreenIntent", "(Z)Landroid/service/notification/ZenPolicy$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.Builder.html#showInAmbientDisplay(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Service.Notification.ZenPolicy.Builder"/></returns>
            public Android.Service.Notification.ZenPolicy.Builder ShowInAmbientDisplay(bool arg0)
            {
                return IExecuteWithSignature<Android.Service.Notification.ZenPolicy.Builder>("showInAmbientDisplay", "(Z)Landroid/service/notification/ZenPolicy$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.Builder.html#showInNotificationList(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Service.Notification.ZenPolicy.Builder"/></returns>
            public Android.Service.Notification.ZenPolicy.Builder ShowInNotificationList(bool arg0)
            {
                return IExecuteWithSignature<Android.Service.Notification.ZenPolicy.Builder>("showInNotificationList", "(Z)Landroid/service/notification/ZenPolicy$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.Builder.html#showLights(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Service.Notification.ZenPolicy.Builder"/></returns>
            public Android.Service.Notification.ZenPolicy.Builder ShowLights(bool arg0)
            {
                return IExecuteWithSignature<Android.Service.Notification.ZenPolicy.Builder>("showLights", "(Z)Landroid/service/notification/ZenPolicy$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.Builder.html#showPeeking(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Service.Notification.ZenPolicy.Builder"/></returns>
            public Android.Service.Notification.ZenPolicy.Builder ShowPeeking(bool arg0)
            {
                return IExecuteWithSignature<Android.Service.Notification.ZenPolicy.Builder>("showPeeking", "(Z)Landroid/service/notification/ZenPolicy$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/notification/ZenPolicy.Builder.html#showStatusBarIcons(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Service.Notification.ZenPolicy.Builder"/></returns>
            public Android.Service.Notification.ZenPolicy.Builder ShowStatusBarIcons(bool arg0)
            {
                return IExecuteWithSignature<Android.Service.Notification.ZenPolicy.Builder>("showStatusBarIcons", "(Z)Landroid/service/notification/ZenPolicy$Builder;", arg0);
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