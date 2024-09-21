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

namespace Android.Os
{
    #region MessageQueue declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/os/MessageQueue.html"/>
    /// </summary>
    public partial class MessageQueue : MASES.JCOBridge.C2JBridge.JVMBridgeBase<MessageQueue>
    {
        const string _bridgeClassName = "android.os.MessageQueue";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MessageQueue() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public MessageQueue(params object[] args) : base(args) { }

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
        #region IdleHandler declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/MessageQueue.IdleHandler.html"/>
        /// </summary>
        public partial class IdleHandler : MASES.JCOBridge.C2JBridge.JVMBridgeBase<IdleHandler>
        {
            const string _bridgeClassName = "android.os.MessageQueue$IdleHandler";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("IdleHandler class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public IdleHandler() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("IdleHandler class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public IdleHandler(params object[] args) : base(args) { }

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

        #region OnFileDescriptorEventListener declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/MessageQueue.OnFileDescriptorEventListener.html"/>
        /// </summary>
        public partial class OnFileDescriptorEventListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public OnFileDescriptorEventListener() { InitializeHandlers(); }

            const string _bridgeClassName = "org.mases.netdroid.generated.android.os.MessageQueue_OnFileDescriptorEventListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
            
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;

        
            // TODO: complete the class

        }
        #endregion

        #region OnFileDescriptorEventListenerDirect declaration
        /// <summary>
        /// Direct override of <see cref="OnFileDescriptorEventListener"/> or its generic type if there is one
        /// </summary>
        public partial class OnFileDescriptorEventListenerDirect : OnFileDescriptorEventListener
        {
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
            /// </summary>
            public override bool AutoInit => false;

            /// <inheritdoc />
            protected override void InitializeHandlers() { }

            const string _bridgeClassName = "android.os.MessageQueue$OnFileDescriptorEventListener";
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

    #region MessageQueue implementation
    public partial class MessageQueue
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
        /// <see href="https://developer.android.com/reference/android/os/MessageQueue.html#isIdle()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsIdle()
        {
            return IExecuteWithSignature<bool>("isIdle", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/MessageQueue.html#addIdleHandler(android.os.MessageQueue.IdleHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.MessageQueue.IdleHandler"/></param>
        public void AddIdleHandler(Android.Os.MessageQueue.IdleHandler arg0)
        {
            IExecuteWithSignature("addIdleHandler", "(Landroid/os/MessageQueue$IdleHandler;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/MessageQueue.html#addOnFileDescriptorEventListener(java.io.FileDescriptor,int,android.os.MessageQueue.OnFileDescriptorEventListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.FileDescriptor"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Os.MessageQueue.OnFileDescriptorEventListener"/></param>
        public void AddOnFileDescriptorEventListener(Java.Io.FileDescriptor arg0, int arg1, Android.Os.MessageQueue.OnFileDescriptorEventListener arg2)
        {
            IExecute("addOnFileDescriptorEventListener", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/MessageQueue.html#removeIdleHandler(android.os.MessageQueue.IdleHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.MessageQueue.IdleHandler"/></param>
        public void RemoveIdleHandler(Android.Os.MessageQueue.IdleHandler arg0)
        {
            IExecuteWithSignature("removeIdleHandler", "(Landroid/os/MessageQueue$IdleHandler;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/MessageQueue.html#removeOnFileDescriptorEventListener(java.io.FileDescriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.FileDescriptor"/></param>
        public void RemoveOnFileDescriptorEventListener(Java.Io.FileDescriptor arg0)
        {
            IExecuteWithSignature("removeOnFileDescriptorEventListener", "(Ljava/io/FileDescriptor;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region IdleHandler implementation
        public partial class IdleHandler
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
            /// <see href="https://developer.android.com/reference/android/os/MessageQueue.IdleHandler.html#queueIdle()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool QueueIdle()
            {
                return IExecuteWithSignature<bool>("queueIdle", "()Z");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnFileDescriptorEventListener implementation
        public partial class OnFileDescriptorEventListener
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
            /// Handlers initializer for <see cref="OnFileDescriptorEventListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onFileDescriptorEvents", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnFileDescriptorEventsEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/os/MessageQueue.OnFileDescriptorEventListener.html#onFileDescriptorEvents(java.io.FileDescriptor,int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnFileDescriptorEvents"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Func<Java.Io.FileDescriptor, int, int> OnOnFileDescriptorEvents { get; set; } = null;

            bool hasOverrideOnFileDescriptorEvents = true;
            void OnFileDescriptorEventsEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnFileDescriptorEvents = true;
                var methodToExecute = (OnOnFileDescriptorEvents != null) ? OnOnFileDescriptorEvents : OnFileDescriptorEvents;
                var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Java.Io.FileDescriptor>(0), data.EventData.GetAt<int>(1));
                data.EventData.TypedEventData.SetReturnData(hasOverrideOnFileDescriptorEvents, executionResult);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/MessageQueue.OnFileDescriptorEventListener.html#onFileDescriptorEvents(java.io.FileDescriptor,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Io.FileDescriptor"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="int"/></returns>
            public virtual int OnFileDescriptorEvents(Java.Io.FileDescriptor arg0, int arg1)
            {
                hasOverrideOnFileDescriptorEvents = false; return default;
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnFileDescriptorEventListenerDirect implementation
        public partial class OnFileDescriptorEventListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/os/MessageQueue.OnFileDescriptorEventListener.html#onFileDescriptorEvents(java.io.FileDescriptor,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Io.FileDescriptor"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="int"/></returns>
            public override int OnFileDescriptorEvents(Java.Io.FileDescriptor arg0, int arg1)
            {
                return IExecute<int>("onFileDescriptorEvents", arg0, arg1);
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