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
    #region SharedElementCallback declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/app/SharedElementCallback.html"/>
    /// </summary>
    public partial class SharedElementCallback : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SharedElementCallback>
    {
        const string _bridgeClassName = "android.app.SharedElementCallback";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("SharedElementCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SharedElementCallback() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("SharedElementCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SharedElementCallback(params object[] args) : base(args) { }

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
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
        #region OnSharedElementsReadyListener declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/SharedElementCallback.OnSharedElementsReadyListener.html"/>
        /// </summary>
        public partial class OnSharedElementsReadyListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public OnSharedElementsReadyListener() { InitializeHandlers(); }

            const string _bridgeClassName = "org.mases.netdroid.generated.android.app.SharedElementCallback_OnSharedElementsReadyListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
            
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;

        
            // TODO: complete the class

        }
        #endregion

        #region OnSharedElementsReadyListenerDirect declaration
        /// <summary>
        /// Direct override of <see cref="OnSharedElementsReadyListener"/> or its generic type if there is one
        /// </summary>
        public partial class OnSharedElementsReadyListenerDirect : OnSharedElementsReadyListener
        {
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
            /// </summary>
            public override bool AutoInit => false;

            /// <inheritdoc />
            protected override void InitializeHandlers() { }

            const string _bridgeClassName = "android.app.SharedElementCallback$OnSharedElementsReadyListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
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
        }
        #endregion

    
    }
    #endregion

    #region SharedElementCallback implementation
    public partial class SharedElementCallback
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
        /// <see href="https://developer.android.com/reference/android/app/SharedElementCallback.html#onCaptureSharedElementSnapshot(android.view.View,android.graphics.Matrix,android.graphics.RectF)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Matrix"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.RectF"/></param>
        /// <returns><see cref="Android.Os.Parcelable"/></returns>
        public Android.Os.Parcelable OnCaptureSharedElementSnapshot(Android.View.View arg0, Android.Graphics.Matrix arg1, Android.Graphics.RectF arg2)
        {
            return IExecute<Android.Os.Parcelable>("onCaptureSharedElementSnapshot", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/SharedElementCallback.html#onCreateSnapshotView(android.content.Context,android.os.Parcelable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Os.Parcelable"/></param>
        /// <returns><see cref="Android.View.View"/></returns>
        public Android.View.View OnCreateSnapshotView(Android.Content.Context arg0, Android.Os.Parcelable arg1)
        {
            return IExecute<Android.View.View>("onCreateSnapshotView", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/SharedElementCallback.html#onMapSharedElements(java.util.List,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        public void OnMapSharedElements(Java.Util.List<Java.Lang.String> arg0, Java.Util.Map<Java.Lang.String, Android.View.View> arg1)
        {
            IExecute("onMapSharedElements", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/SharedElementCallback.html#onRejectSharedElements(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public void OnRejectSharedElements(Java.Util.List<Android.View.View> arg0)
        {
            IExecuteWithSignature("onRejectSharedElements", "(Ljava/util/List;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/SharedElementCallback.html#onSharedElementEnd(java.util.List,java.util.List,java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <param name="arg2"><see cref="Java.Util.List"/></param>
        public void OnSharedElementEnd(Java.Util.List<Java.Lang.String> arg0, Java.Util.List<Android.View.View> arg1, Java.Util.List<Android.View.View> arg2)
        {
            IExecute("onSharedElementEnd", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/SharedElementCallback.html#onSharedElementsArrived(java.util.List,java.util.List,android.app.SharedElementCallback.OnSharedElementsReadyListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <param name="arg2"><see cref="Android.App.SharedElementCallback.OnSharedElementsReadyListener"/></param>
        public void OnSharedElementsArrived(Java.Util.List<Java.Lang.String> arg0, Java.Util.List<Android.View.View> arg1, Android.App.SharedElementCallback.OnSharedElementsReadyListener arg2)
        {
            IExecute("onSharedElementsArrived", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/SharedElementCallback.html#onSharedElementStart(java.util.List,java.util.List,java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <param name="arg2"><see cref="Java.Util.List"/></param>
        public void OnSharedElementStart(Java.Util.List<Java.Lang.String> arg0, Java.Util.List<Android.View.View> arg1, Java.Util.List<Android.View.View> arg2)
        {
            IExecute("onSharedElementStart", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes
        #region OnSharedElementsReadyListener implementation
        public partial class OnSharedElementsReadyListener
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
            /// Handlers initializer for <see cref="OnSharedElementsReadyListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onSharedElementsReady", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnSharedElementsReadyEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/app/SharedElementCallback.OnSharedElementsReadyListener.html#onSharedElementsReady()"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnSharedElementsReady"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action OnOnSharedElementsReady { get; set; } = null;

            bool hasOverrideOnSharedElementsReady = true;
            void OnSharedElementsReadyEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnSharedElementsReady = true;
                var methodToExecute = (OnOnSharedElementsReady != null) ? OnOnSharedElementsReady : OnSharedElementsReady;
                methodToExecute.Invoke();
                data.EventData.TypedEventData.HasOverride = hasOverrideOnSharedElementsReady;
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/SharedElementCallback.OnSharedElementsReadyListener.html#onSharedElementsReady()"/>
            /// </summary>
            public virtual void OnSharedElementsReady()
            {
                hasOverrideOnSharedElementsReady = false;
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnSharedElementsReadyListenerDirect implementation
        public partial class OnSharedElementsReadyListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/app/SharedElementCallback.OnSharedElementsReadyListener.html#onSharedElementsReady()"/>
            /// </summary>
            public override void OnSharedElementsReady()
            {
                IExecuteWithSignature("onSharedElementsReady", "()V");
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