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
    #region NotificationChannel declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html"/>
    /// </summary>
    public partial class NotificationChannel : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.app.NotificationChannel";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public NotificationChannel() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public NotificationChannel(params object[] args) : base(args) { }
    
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

    #region NotificationChannel implementation
    public partial class NotificationChannel
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#%3Cinit%3E(java.lang.String,java.lang.CharSequence,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public NotificationChannel(Java.Lang.String arg0, Java.Lang.CharSequence arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#DEFAULT_CHANNEL_ID"/>
        /// </summary>
        public static Java.Lang.String DEFAULT_CHANNEL_ID { get { if (!_DEFAULT_CHANNEL_IDReady) { _DEFAULT_CHANNEL_IDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DEFAULT_CHANNEL_ID"); _DEFAULT_CHANNEL_IDReady = true; } return _DEFAULT_CHANNEL_IDContent; } }
        private static Java.Lang.String _DEFAULT_CHANNEL_IDContent = default;
        private static bool _DEFAULT_CHANNEL_IDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#EDIT_CONVERSATION"/>
        /// </summary>
        public static Java.Lang.String EDIT_CONVERSATION { get { if (!_EDIT_CONVERSATIONReady) { _EDIT_CONVERSATIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EDIT_CONVERSATION"); _EDIT_CONVERSATIONReady = true; } return _EDIT_CONVERSATIONContent; } }
        private static Java.Lang.String _EDIT_CONVERSATIONContent = default;
        private static bool _EDIT_CONVERSATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#EDIT_IMPORTANCE"/>
        /// </summary>
        public static Java.Lang.String EDIT_IMPORTANCE { get { if (!_EDIT_IMPORTANCEReady) { _EDIT_IMPORTANCEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EDIT_IMPORTANCE"); _EDIT_IMPORTANCEReady = true; } return _EDIT_IMPORTANCEContent; } }
        private static Java.Lang.String _EDIT_IMPORTANCEContent = default;
        private static bool _EDIT_IMPORTANCEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#EDIT_LAUNCHER"/>
        /// </summary>
        public static Java.Lang.String EDIT_LAUNCHER { get { if (!_EDIT_LAUNCHERReady) { _EDIT_LAUNCHERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EDIT_LAUNCHER"); _EDIT_LAUNCHERReady = true; } return _EDIT_LAUNCHERContent; } }
        private static Java.Lang.String _EDIT_LAUNCHERContent = default;
        private static bool _EDIT_LAUNCHERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#EDIT_LOCKED_DEVICE"/>
        /// </summary>
        public static Java.Lang.String EDIT_LOCKED_DEVICE { get { if (!_EDIT_LOCKED_DEVICEReady) { _EDIT_LOCKED_DEVICEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EDIT_LOCKED_DEVICE"); _EDIT_LOCKED_DEVICEReady = true; } return _EDIT_LOCKED_DEVICEContent; } }
        private static Java.Lang.String _EDIT_LOCKED_DEVICEContent = default;
        private static bool _EDIT_LOCKED_DEVICEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#EDIT_SOUND"/>
        /// </summary>
        public static Java.Lang.String EDIT_SOUND { get { if (!_EDIT_SOUNDReady) { _EDIT_SOUNDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EDIT_SOUND"); _EDIT_SOUNDReady = true; } return _EDIT_SOUNDContent; } }
        private static Java.Lang.String _EDIT_SOUNDContent = default;
        private static bool _EDIT_SOUNDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#EDIT_VIBRATION"/>
        /// </summary>
        public static Java.Lang.String EDIT_VIBRATION { get { if (!_EDIT_VIBRATIONReady) { _EDIT_VIBRATIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EDIT_VIBRATION"); _EDIT_VIBRATIONReady = true; } return _EDIT_VIBRATIONContent; } }
        private static Java.Lang.String _EDIT_VIBRATIONContent = default;
        private static bool _EDIT_VIBRATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#EDIT_ZEN"/>
        /// </summary>
        public static Java.Lang.String EDIT_ZEN { get { if (!_EDIT_ZENReady) { _EDIT_ZENContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EDIT_ZEN"); _EDIT_ZENReady = true; } return _EDIT_ZENContent; } }
        private static Java.Lang.String _EDIT_ZENContent = default;
        private static bool _EDIT_ZENReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#getAudioAttributes()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.AudioAttributes"/></returns>
        public Android.Media.AudioAttributes GetAudioAttributes()
        {
            return IExecuteWithSignature<Android.Media.AudioAttributes>("getAudioAttributes", "()Landroid/media/AudioAttributes;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#getSound()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        public Android.Net.Uri GetSound()
        {
            return IExecuteWithSignature<Android.Net.Uri>("getSound", "()Landroid/net/Uri;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#getVibrationEffect()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.VibrationEffect"/></returns>
        public Android.Os.VibrationEffect GetVibrationEffect()
        {
            return IExecuteWithSignature<Android.Os.VibrationEffect>("getVibrationEffect", "()Landroid/os/VibrationEffect;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#canBubble()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CanBubble()
        {
            return IExecuteWithSignature<bool>("canBubble", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#canBypassDnd()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CanBypassDnd()
        {
            return IExecuteWithSignature<bool>("canBypassDnd", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#canShowBadge()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CanShowBadge()
        {
            return IExecuteWithSignature<bool>("canShowBadge", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#hasUserSetImportance()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasUserSetImportance()
        {
            return IExecuteWithSignature<bool>("hasUserSetImportance", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#hasUserSetSound()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasUserSetSound()
        {
            return IExecuteWithSignature<bool>("hasUserSetSound", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#isBlockable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsBlockable()
        {
            return IExecuteWithSignature<bool>("isBlockable", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#isConversation()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsConversation()
        {
            return IExecuteWithSignature<bool>("isConversation", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#isDemoted()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDemoted()
        {
            return IExecuteWithSignature<bool>("isDemoted", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#isImportantConversation()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsImportantConversation()
        {
            return IExecuteWithSignature<bool>("isImportantConversation", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#shouldShowLights()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool ShouldShowLights()
        {
            return IExecuteWithSignature<bool>("shouldShowLights", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#shouldVibrate()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool ShouldVibrate()
        {
            return IExecuteWithSignature<bool>("shouldVibrate", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#getImportance()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetImportance()
        {
            return IExecuteWithSignature<int>("getImportance", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#getLightColor()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetLightColor()
        {
            return IExecuteWithSignature<int>("getLightColor", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#getLockscreenVisibility()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetLockscreenVisibility()
        {
            return IExecuteWithSignature<int>("getLockscreenVisibility", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#getName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetName()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getName", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#getConversationId()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetConversationId()
        {
            return IExecuteWithSignature<Java.Lang.String>("getConversationId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#getDescription()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDescription()
        {
            return IExecuteWithSignature<Java.Lang.String>("getDescription", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#getGroup()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetGroup()
        {
            return IExecuteWithSignature<Java.Lang.String>("getGroup", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#getId()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetId()
        {
            return IExecuteWithSignature<Java.Lang.String>("getId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#getParentChannelId()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetParentChannelId()
        {
            return IExecuteWithSignature<Java.Lang.String>("getParentChannelId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#getVibrationPattern()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long[] GetVibrationPattern()
        {
            return IExecuteWithSignatureArray<long>("getVibrationPattern", "()[J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#enableLights(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void EnableLights(bool arg0)
        {
            IExecuteWithSignature("enableLights", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#enableVibration(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void EnableVibration(bool arg0)
        {
            IExecuteWithSignature("enableVibration", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#setAllowBubbles(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetAllowBubbles(bool arg0)
        {
            IExecuteWithSignature("setAllowBubbles", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#setBlockable(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetBlockable(bool arg0)
        {
            IExecuteWithSignature("setBlockable", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#setBypassDnd(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetBypassDnd(bool arg0)
        {
            IExecuteWithSignature("setBypassDnd", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#setConversationId(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void SetConversationId(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecute("setConversationId", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#setDescription(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetDescription(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setDescription", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#setGroup(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetGroup(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setGroup", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#setImportance(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetImportance(int arg0)
        {
            IExecuteWithSignature("setImportance", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#setLightColor(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetLightColor(int arg0)
        {
            IExecuteWithSignature("setLightColor", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#setLockscreenVisibility(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetLockscreenVisibility(int arg0)
        {
            IExecuteWithSignature("setLockscreenVisibility", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#setName(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        public void SetName(Java.Lang.CharSequence arg0)
        {
            IExecuteWithSignature("setName", "(Ljava/lang/CharSequence;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#setShowBadge(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetShowBadge(bool arg0)
        {
            IExecuteWithSignature("setShowBadge", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#setSound(android.net.Uri,android.media.AudioAttributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Android.Media.AudioAttributes"/></param>
        public void SetSound(Android.Net.Uri arg0, Android.Media.AudioAttributes arg1)
        {
            IExecute("setSound", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#setVibrationEffect(android.os.VibrationEffect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.VibrationEffect"/></param>
        public void SetVibrationEffect(Android.Os.VibrationEffect arg0)
        {
            IExecuteWithSignature("setVibrationEffect", "(Landroid/os/VibrationEffect;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#setVibrationPattern(long[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetVibrationPattern(long[] arg0)
        {
            IExecuteWithSignature("setVibrationPattern", "([J)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NotificationChannel.html#writeToParcel(android.os.Parcel,int)"/>
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