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

namespace Android.Content
{
    #region IntentSender declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/content/IntentSender.html"/>
    /// </summary>
    public partial class IntentSender : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.content.IntentSender";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public IntentSender() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public IntentSender(params object[] args) : base(args) { }
    
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
        #region OnFinished declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/IntentSender.OnFinished.html"/>
        /// </summary>
        public partial class OnFinished : MASES.JCOBridge.C2JBridge.JVMBridgeBase<OnFinished>
        {
            const string _bridgeClassName = "android.content.IntentSender$OnFinished";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("OnFinished class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public OnFinished() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("OnFinished class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public OnFinished(params object[] args) : base(args) { }
        
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
            /// </summary>
            public override bool IsBridgeCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
            /// </summary>
            public override bool IsBridgeInterface => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

        #region SendIntentException declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/IntentSender.SendIntentException.html"/>
        /// </summary>
        public partial class SendIntentException : Android.Util.AndroidException
        {
            const string _bridgeClassName = "android.content.IntentSender$SendIntentException";
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
        
            // TODO: complete the class
        
        }
        #endregion

    
    }
    #endregion

    #region IntentSender implementation
    public partial class IntentSender
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/IntentSender.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/IntentSender.html#readIntentSenderOrNullFromParcel(android.os.Parcel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <returns><see cref="Android.Content.IntentSender"/></returns>
        public static Android.Content.IntentSender ReadIntentSenderOrNullFromParcel(Android.Os.Parcel arg0)
        {
            return SExecuteWithSignature<Android.Content.IntentSender>(LocalBridgeClazz, "readIntentSenderOrNullFromParcel", "(Landroid/os/Parcel;)Landroid/content/IntentSender;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/IntentSender.html#writeIntentSenderOrNullToParcel(android.content.IntentSender,android.os.Parcel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.IntentSender"/></param>
        /// <param name="arg1"><see cref="Android.Os.Parcel"/></param>
        public static void WriteIntentSenderOrNullToParcel(Android.Content.IntentSender arg0, Android.Os.Parcel arg1)
        {
            SExecute(LocalBridgeClazz, "writeIntentSenderOrNullToParcel", arg0, arg1);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/IntentSender.html#getCreatorUserHandle()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.UserHandle"/></returns>
        public Android.Os.UserHandle GetCreatorUserHandle()
        {
            return IExecuteWithSignature<Android.Os.UserHandle>("getCreatorUserHandle", "()Landroid/os/UserHandle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/IntentSender.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/IntentSender.html#getCreatorUid()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCreatorUid()
        {
            return IExecuteWithSignature<int>("getCreatorUid", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/IntentSender.html#getCreatorPackage()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetCreatorPackage()
        {
            return IExecuteWithSignature<Java.Lang.String>("getCreatorPackage", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/IntentSender.html#getTargetPackage()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetTargetPackage()
        {
            return IExecuteWithSignature<Java.Lang.String>("getTargetPackage", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/IntentSender.html#sendIntent(android.content.Context,int,android.content.Intent,android.content.IntentSender.OnFinished,android.os.Handler,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Content.Intent"/></param>
        /// <param name="arg3"><see cref="Android.Content.IntentSender.OnFinished"/></param>
        /// <param name="arg4"><see cref="Android.Os.Handler"/></param>
        /// <param name="arg5"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Android.Content.IntentSender.SendIntentException"/>
        public void SendIntent(Android.Content.Context arg0, int arg1, Android.Content.Intent arg2, Android.Content.IntentSender.OnFinished arg3, Android.Os.Handler arg4, Java.Lang.String arg5)
        {
            IExecute("sendIntent", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/IntentSender.html#sendIntent(android.content.Context,int,android.content.Intent,android.content.IntentSender.OnFinished,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Content.Intent"/></param>
        /// <param name="arg3"><see cref="Android.Content.IntentSender.OnFinished"/></param>
        /// <param name="arg4"><see cref="Android.Os.Handler"/></param>
        /// <exception cref="Android.Content.IntentSender.SendIntentException"/>
        public void SendIntent(Android.Content.Context arg0, int arg1, Android.Content.Intent arg2, Android.Content.IntentSender.OnFinished arg3, Android.Os.Handler arg4)
        {
            IExecute("sendIntent", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/IntentSender.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
        #region OnFinished implementation
        public partial class OnFinished
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
            /// <see href="https://developer.android.com/reference/android/content/IntentSender.OnFinished.html#onSendFinished(android.content.IntentSender,android.content.Intent,int,java.lang.String,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.IntentSender"/></param>
            /// <param name="arg1"><see cref="Android.Content.Intent"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="Java.Lang.String"/></param>
            /// <param name="arg4"><see cref="Android.Os.Bundle"/></param>
            public void OnSendFinished(Android.Content.IntentSender arg0, Android.Content.Intent arg1, int arg2, Java.Lang.String arg3, Android.Os.Bundle arg4)
            {
                IExecute("onSendFinished", arg0, arg1, arg2, arg3, arg4);
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region SendIntentException implementation
        public partial class SendIntentException
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