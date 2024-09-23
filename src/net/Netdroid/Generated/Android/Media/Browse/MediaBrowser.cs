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

namespace Android.Media.Browse
{
    #region MediaBrowser declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.html"/>
    /// </summary>
    public partial class MediaBrowser : MASES.JCOBridge.C2JBridge.JVMBridgeBase<MediaBrowser>
    {
        const string _bridgeClassName = "android.media.browse.MediaBrowser";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MediaBrowser() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public MediaBrowser(params object[] args) : base(args) { }
    
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
        #region ConnectionCallback declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.ConnectionCallback.html"/>
        /// </summary>
        public partial class ConnectionCallback : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ConnectionCallback>
        {
            const string _bridgeClassName = "android.media.browse.MediaBrowser$ConnectionCallback";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public ConnectionCallback() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public ConnectionCallback(params object[] args) : base(args) { }
        
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

        #region ItemCallback declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.ItemCallback.html"/>
        /// </summary>
        public partial class ItemCallback : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ItemCallback>
        {
            const string _bridgeClassName = "android.media.browse.MediaBrowser$ItemCallback";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("ItemCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public ItemCallback() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("ItemCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public ItemCallback(params object[] args) : base(args) { }
        
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
            public override bool IsBridgeInterface => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

        #region MediaItem declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.MediaItem.html"/>
        /// </summary>
        public partial class MediaItem : Android.Os.Parcelable
        {
            const string _bridgeClassName = "android.media.browse.MediaBrowser$MediaItem";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public MediaItem() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public MediaItem(params object[] args) : base(args) { }
        
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

        #region SubscriptionCallback declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.SubscriptionCallback.html"/>
        /// </summary>
        public partial class SubscriptionCallback : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SubscriptionCallback>
        {
            const string _bridgeClassName = "android.media.browse.MediaBrowser$SubscriptionCallback";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("SubscriptionCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public SubscriptionCallback() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("SubscriptionCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public SubscriptionCallback(params object[] args) : base(args) { }
        
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

    #region MediaBrowser implementation
    public partial class MediaBrowser
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.html#%3Cinit%3E(android.content.Context,android.content.ComponentName,android.media.browse.MediaBrowser.ConnectionCallback,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Content.ComponentName"/></param>
        /// <param name="arg2"><see cref="Android.Media.Browse.MediaBrowser.ConnectionCallback"/></param>
        /// <param name="arg3"><see cref="Android.Os.Bundle"/></param>
        public MediaBrowser(Android.Content.Context arg0, Android.Content.ComponentName arg1, Android.Media.Browse.MediaBrowser.ConnectionCallback arg2, Android.Os.Bundle arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.html#EXTRA_PAGE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_PAGE { get { if (!_EXTRA_PAGEReady) { _EXTRA_PAGEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_PAGE"); _EXTRA_PAGEReady = true; } return _EXTRA_PAGEContent; } }
        private static Java.Lang.String _EXTRA_PAGEContent = default;
        private static bool _EXTRA_PAGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.html#EXTRA_PAGE_SIZE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_PAGE_SIZE { get { if (!_EXTRA_PAGE_SIZEReady) { _EXTRA_PAGE_SIZEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_PAGE_SIZE"); _EXTRA_PAGE_SIZEReady = true; } return _EXTRA_PAGE_SIZEContent; } }
        private static Java.Lang.String _EXTRA_PAGE_SIZEContent = default;
        private static bool _EXTRA_PAGE_SIZEReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.html#getServiceComponent()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.ComponentName"/></returns>
        public Android.Content.ComponentName GetServiceComponent()
        {
            return IExecuteWithSignature<Android.Content.ComponentName>("getServiceComponent", "()Landroid/content/ComponentName;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.html#getSessionToken()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.Session.MediaSession.Token"/></returns>
        public Android.Media.Session.MediaSession.Token GetSessionToken()
        {
            return IExecuteWithSignature<Android.Media.Session.MediaSession.Token>("getSessionToken", "()Landroid/media/session/MediaSession$Token;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.html#getExtras()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle GetExtras()
        {
            return IExecuteWithSignature<Android.Os.Bundle>("getExtras", "()Landroid/os/Bundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.html#isConnected()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsConnected()
        {
            return IExecuteWithSignature<bool>("isConnected", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.html#getRoot()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetRoot()
        {
            return IExecuteWithSignature<Java.Lang.String>("getRoot", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.html#connect()"/>
        /// </summary>
        public void Connect()
        {
            IExecuteWithSignature("connect", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.html#disconnect()"/>
        /// </summary>
        public void Disconnect()
        {
            IExecuteWithSignature("disconnect", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.html#getItem(java.lang.String,android.media.browse.MediaBrowser.ItemCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Media.Browse.MediaBrowser.ItemCallback"/></param>
        public void GetItem(Java.Lang.String arg0, Android.Media.Browse.MediaBrowser.ItemCallback arg1)
        {
            IExecute("getItem", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.html#subscribe(java.lang.String,android.media.browse.MediaBrowser.SubscriptionCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Media.Browse.MediaBrowser.SubscriptionCallback"/></param>
        public void Subscribe(Java.Lang.String arg0, Android.Media.Browse.MediaBrowser.SubscriptionCallback arg1)
        {
            IExecute("subscribe", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.html#subscribe(java.lang.String,android.os.Bundle,android.media.browse.MediaBrowser.SubscriptionCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
        /// <param name="arg2"><see cref="Android.Media.Browse.MediaBrowser.SubscriptionCallback"/></param>
        public void Subscribe(Java.Lang.String arg0, Android.Os.Bundle arg1, Android.Media.Browse.MediaBrowser.SubscriptionCallback arg2)
        {
            IExecute("subscribe", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.html#unsubscribe(java.lang.String,android.media.browse.MediaBrowser.SubscriptionCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Media.Browse.MediaBrowser.SubscriptionCallback"/></param>
        public void Unsubscribe(Java.Lang.String arg0, Android.Media.Browse.MediaBrowser.SubscriptionCallback arg1)
        {
            IExecute("unsubscribe", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.html#unsubscribe(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void Unsubscribe(Java.Lang.String arg0)
        {
            IExecuteWithSignature("unsubscribe", "(Ljava/lang/String;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
        #region ConnectionCallback implementation
        public partial class ConnectionCallback
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
            /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.ConnectionCallback.html#onConnected()"/>
            /// </summary>
            public void OnConnected()
            {
                IExecuteWithSignature("onConnected", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.ConnectionCallback.html#onConnectionFailed()"/>
            /// </summary>
            public void OnConnectionFailed()
            {
                IExecuteWithSignature("onConnectionFailed", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.ConnectionCallback.html#onConnectionSuspended()"/>
            /// </summary>
            public void OnConnectionSuspended()
            {
                IExecuteWithSignature("onConnectionSuspended", "()V");
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region ItemCallback implementation
        public partial class ItemCallback
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
            /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.ItemCallback.html#onError(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            public void OnError(Java.Lang.String arg0)
            {
                IExecuteWithSignature("onError", "(Ljava/lang/String;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.ItemCallback.html#onItemLoaded(android.media.browse.MediaBrowser.MediaItem)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.Browse.MediaBrowser.MediaItem"/></param>
            public void OnItemLoaded(Android.Media.Browse.MediaBrowser.MediaItem arg0)
            {
                IExecuteWithSignature("onItemLoaded", "(Landroid/media/browse/MediaBrowser$MediaItem;)V", arg0);
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region MediaItem implementation
        public partial class MediaItem
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.MediaItem.html#%3Cinit%3E(android.media.MediaDescription,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.MediaDescription"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public MediaItem(Android.Media.MediaDescription arg0, int arg1)
                : base(arg0, arg1)
            {
            }
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.MediaItem.html#CREATOR"/>
            /// </summary>
            public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
            private static Android.Os.Parcelable.Creator _CREATORContent = default;
            private static bool _CREATORReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.MediaItem.html#FLAG_BROWSABLE"/>
            /// </summary>
            public static int FLAG_BROWSABLE { get { if (!_FLAG_BROWSABLEReady) { _FLAG_BROWSABLEContent = SGetField<int>(LocalBridgeClazz, "FLAG_BROWSABLE"); _FLAG_BROWSABLEReady = true; } return _FLAG_BROWSABLEContent; } }
            private static int _FLAG_BROWSABLEContent = default;
            private static bool _FLAG_BROWSABLEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.MediaItem.html#FLAG_PLAYABLE"/>
            /// </summary>
            public static int FLAG_PLAYABLE { get { if (!_FLAG_PLAYABLEReady) { _FLAG_PLAYABLEContent = SGetField<int>(LocalBridgeClazz, "FLAG_PLAYABLE"); _FLAG_PLAYABLEReady = true; } return _FLAG_PLAYABLEContent; } }
            private static int _FLAG_PLAYABLEContent = default;
            private static bool _FLAG_PLAYABLEReady = false; // this is used because in case of generics 
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.MediaItem.html#getDescription()"/>
            /// </summary>
            /// <returns><see cref="Android.Media.MediaDescription"/></returns>
            public Android.Media.MediaDescription GetDescription()
            {
                return IExecuteWithSignature<Android.Media.MediaDescription>("getDescription", "()Landroid/media/MediaDescription;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.MediaItem.html#isBrowsable()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsBrowsable()
            {
                return IExecuteWithSignature<bool>("isBrowsable", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.MediaItem.html#isPlayable()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsPlayable()
            {
                return IExecuteWithSignature<bool>("isPlayable", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.MediaItem.html#describeContents()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int DescribeContents()
            {
                return IExecuteWithSignature<int>("describeContents", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.MediaItem.html#getFlags()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetFlags()
            {
                return IExecuteWithSignature<int>("getFlags", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.MediaItem.html#getMediaId()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetMediaId()
            {
                return IExecuteWithSignature<Java.Lang.String>("getMediaId", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.MediaItem.html#writeToParcel(android.os.Parcel,int)"/>
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

        #region SubscriptionCallback implementation
        public partial class SubscriptionCallback
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
            /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.SubscriptionCallback.html#onChildrenLoaded(java.lang.String,java.util.List,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Util.List"/></param>
            /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
            public void OnChildrenLoaded(Java.Lang.String arg0, Java.Util.List<Android.Media.Browse.MediaBrowser.MediaItem> arg1, Android.Os.Bundle arg2)
            {
                IExecute("onChildrenLoaded", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.SubscriptionCallback.html#onChildrenLoaded(java.lang.String,java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Util.List"/></param>
            public void OnChildrenLoaded(Java.Lang.String arg0, Java.Util.List<Android.Media.Browse.MediaBrowser.MediaItem> arg1)
            {
                IExecute("onChildrenLoaded", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.SubscriptionCallback.html#onError(java.lang.String,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
            public void OnError(Java.Lang.String arg0, Android.Os.Bundle arg1)
            {
                IExecute("onError", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/browse/MediaBrowser.SubscriptionCallback.html#onError(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            public void OnError(Java.Lang.String arg0)
            {
                IExecuteWithSignature("onError", "(Ljava/lang/String;)V", arg0);
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