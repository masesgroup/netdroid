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

namespace Android.Service.Notification
{
    #region StatusBarNotification declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/service/notification/StatusBarNotification.html"/>
    /// </summary>
    public partial class StatusBarNotification : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.service.notification.StatusBarNotification";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public StatusBarNotification() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public StatusBarNotification(params object[] args) : base(args) { }
    
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

    #region StatusBarNotification implementation
    public partial class StatusBarNotification
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/StatusBarNotification.html#%3Cinit%3E(android.os.Parcel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        public StatusBarNotification(Android.Os.Parcel arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/StatusBarNotification.html#%3Cinit%3E(java.lang.String,java.lang.String,int,java.lang.String,int,int,int,android.app.Notification,android.os.UserHandle,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="Android.App.Notification"/></param>
        /// <param name="arg8"><see cref="Android.Os.UserHandle"/></param>
        /// <param name="arg9"><see cref="long"/></param>
        [global::System.Obsolete()]
        public StatusBarNotification(Java.Lang.String arg0, Java.Lang.String arg1, int arg2, Java.Lang.String arg3, int arg4, int arg5, int arg6, Android.App.Notification arg7, Android.Os.UserHandle arg8, long arg9)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/StatusBarNotification.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/StatusBarNotification.html#getNotification()"/>
        /// </summary>
        /// <returns><see cref="Android.App.Notification"/></returns>
        public Android.App.Notification GetNotification()
        {
            return IExecuteWithSignature<Android.App.Notification>("getNotification", "()Landroid/app/Notification;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/StatusBarNotification.html#getUser()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.UserHandle"/></returns>
        public Android.Os.UserHandle GetUser()
        {
            return IExecuteWithSignature<Android.Os.UserHandle>("getUser", "()Landroid/os/UserHandle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/StatusBarNotification.html#clone()"/>
        /// </summary>
        /// <returns><see cref="Android.Service.Notification.StatusBarNotification"/></returns>
        public Android.Service.Notification.StatusBarNotification Clone()
        {
            return IExecuteWithSignature<Android.Service.Notification.StatusBarNotification>("clone", "()Landroid/service/notification/StatusBarNotification;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/StatusBarNotification.html#isAppGroup()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAppGroup()
        {
            return IExecuteWithSignature<bool>("isAppGroup", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/StatusBarNotification.html#isClearable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsClearable()
        {
            return IExecuteWithSignature<bool>("isClearable", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/StatusBarNotification.html#isGroup()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsGroup()
        {
            return IExecuteWithSignature<bool>("isGroup", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/StatusBarNotification.html#isOngoing()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOngoing()
        {
            return IExecuteWithSignature<bool>("isOngoing", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/StatusBarNotification.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/StatusBarNotification.html#getId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetId()
        {
            return IExecuteWithSignature<int>("getId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/StatusBarNotification.html#getUid()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetUid()
        {
            return IExecuteWithSignature<int>("getUid", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/StatusBarNotification.html#getUserId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetUserId()
        {
            return IExecuteWithSignature<int>("getUserId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/StatusBarNotification.html#getGroupKey()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetGroupKey()
        {
            return IExecuteWithSignature<Java.Lang.String>("getGroupKey", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/StatusBarNotification.html#getKey()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetKey()
        {
            return IExecuteWithSignature<Java.Lang.String>("getKey", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/StatusBarNotification.html#getOpPkg()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetOpPkg()
        {
            return IExecuteWithSignature<Java.Lang.String>("getOpPkg", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/StatusBarNotification.html#getOverrideGroupKey()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetOverrideGroupKey()
        {
            return IExecuteWithSignature<Java.Lang.String>("getOverrideGroupKey", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/StatusBarNotification.html#getPackageName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPackageName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPackageName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/StatusBarNotification.html#getTag()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetTag()
        {
            return IExecuteWithSignature<Java.Lang.String>("getTag", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/StatusBarNotification.html#getPostTime()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetPostTime()
        {
            return IExecuteWithSignature<long>("getPostTime", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/StatusBarNotification.html#setOverrideGroupKey(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetOverrideGroupKey(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setOverrideGroupKey", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/StatusBarNotification.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}