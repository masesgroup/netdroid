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

namespace Android.View
{
    #region Choreographer declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/view/Choreographer.html"/>
    /// </summary>
    public partial class Choreographer : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Choreographer>
    {
        const string _bridgeClassName = "android.view.Choreographer";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Choreographer() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Choreographer(params object[] args) : base(args) { }
    
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
        #region FrameCallback declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Choreographer.FrameCallback.html"/>
        /// </summary>
        public partial class FrameCallback : MASES.JCOBridge.C2JBridge.JVMBridgeBase<FrameCallback>
        {
            const string _bridgeClassName = "android.view.Choreographer$FrameCallback";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("FrameCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public FrameCallback() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("FrameCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public FrameCallback(params object[] args) : base(args) { }
        
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

        #region FrameData declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Choreographer.FrameData.html"/>
        /// </summary>
        public partial class FrameData : MASES.JCOBridge.C2JBridge.JVMBridgeBase<FrameData>
        {
            const string _bridgeClassName = "android.view.Choreographer$FrameData";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public FrameData() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public FrameData(params object[] args) : base(args) { }
        
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

        #region FrameTimeline declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Choreographer.FrameTimeline.html"/>
        /// </summary>
        public partial class FrameTimeline : MASES.JCOBridge.C2JBridge.JVMBridgeBase<FrameTimeline>
        {
            const string _bridgeClassName = "android.view.Choreographer$FrameTimeline";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public FrameTimeline() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public FrameTimeline(params object[] args) : base(args) { }
        
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

        #region VsyncCallback declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Choreographer.VsyncCallback.html"/>
        /// </summary>
        public partial class VsyncCallback : MASES.JCOBridge.C2JBridge.JVMBridgeBase<VsyncCallback>
        {
            const string _bridgeClassName = "android.view.Choreographer$VsyncCallback";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("VsyncCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public VsyncCallback() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("VsyncCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public VsyncCallback(params object[] args) : base(args) { }
        
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

    
    }
    #endregion

    #region Choreographer implementation
    public partial class Choreographer
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Choreographer.html#getInstance()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Choreographer"/></returns>
        public static Android.View.Choreographer GetInstance()
        {
            return SExecuteWithSignature<Android.View.Choreographer>(LocalBridgeClazz, "getInstance", "()Landroid/view/Choreographer;");
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Choreographer.html#postFrameCallback(android.view.Choreographer.FrameCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Choreographer.FrameCallback"/></param>
        public void PostFrameCallback(Android.View.Choreographer.FrameCallback arg0)
        {
            IExecuteWithSignature("postFrameCallback", "(Landroid/view/Choreographer$FrameCallback;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Choreographer.html#postFrameCallbackDelayed(android.view.Choreographer.FrameCallback,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Choreographer.FrameCallback"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public void PostFrameCallbackDelayed(Android.View.Choreographer.FrameCallback arg0, long arg1)
        {
            IExecuteWithSignature("postFrameCallbackDelayed", "(Landroid/view/Choreographer$FrameCallback;J)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Choreographer.html#postVsyncCallback(android.view.Choreographer.VsyncCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Choreographer.VsyncCallback"/></param>
        public void PostVsyncCallback(Android.View.Choreographer.VsyncCallback arg0)
        {
            IExecuteWithSignature("postVsyncCallback", "(Landroid/view/Choreographer$VsyncCallback;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Choreographer.html#removeFrameCallback(android.view.Choreographer.FrameCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Choreographer.FrameCallback"/></param>
        public void RemoveFrameCallback(Android.View.Choreographer.FrameCallback arg0)
        {
            IExecuteWithSignature("removeFrameCallback", "(Landroid/view/Choreographer$FrameCallback;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Choreographer.html#removeVsyncCallback(android.view.Choreographer.VsyncCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Choreographer.VsyncCallback"/></param>
        public void RemoveVsyncCallback(Android.View.Choreographer.VsyncCallback arg0)
        {
            IExecuteWithSignature("removeVsyncCallback", "(Landroid/view/Choreographer$VsyncCallback;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
        #region FrameCallback implementation
        public partial class FrameCallback
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
            /// <see href="https://developer.android.com/reference/android/view/Choreographer.FrameCallback.html#doFrame(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            public void DoFrame(long arg0)
            {
                IExecuteWithSignature("doFrame", "(J)V", arg0);
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region FrameData implementation
        public partial class FrameData
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
            /// <see href="https://developer.android.com/reference/android/view/Choreographer.FrameData.html#getPreferredFrameTimeline()"/>
            /// </summary>
            /// <returns><see cref="Android.View.Choreographer.FrameTimeline"/></returns>
            public Android.View.Choreographer.FrameTimeline GetPreferredFrameTimeline()
            {
                return IExecuteWithSignature<Android.View.Choreographer.FrameTimeline>("getPreferredFrameTimeline", "()Landroid/view/Choreographer$FrameTimeline;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/Choreographer.FrameData.html#getFrameTimelines()"/>
            /// </summary>
            /// <returns><see cref="Android.View.Choreographer.FrameTimeline"/></returns>
            public Android.View.Choreographer.FrameTimeline[] GetFrameTimelines()
            {
                return IExecuteWithSignatureArray<Android.View.Choreographer.FrameTimeline>("getFrameTimelines", "()[Landroid/view/Choreographer$FrameTimeline;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/Choreographer.FrameData.html#getFrameTimeNanos()"/>
            /// </summary>
            /// <returns><see cref="long"/></returns>
            public long GetFrameTimeNanos()
            {
                return IExecuteWithSignature<long>("getFrameTimeNanos", "()J");
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region FrameTimeline implementation
        public partial class FrameTimeline
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
            /// <see href="https://developer.android.com/reference/android/view/Choreographer.FrameTimeline.html#getDeadlineNanos()"/>
            /// </summary>
            /// <returns><see cref="long"/></returns>
            public long GetDeadlineNanos()
            {
                return IExecuteWithSignature<long>("getDeadlineNanos", "()J");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/Choreographer.FrameTimeline.html#getExpectedPresentationTimeNanos()"/>
            /// </summary>
            /// <returns><see cref="long"/></returns>
            public long GetExpectedPresentationTimeNanos()
            {
                return IExecuteWithSignature<long>("getExpectedPresentationTimeNanos", "()J");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/Choreographer.FrameTimeline.html#getVsyncId()"/>
            /// </summary>
            /// <returns><see cref="long"/></returns>
            public long GetVsyncId()
            {
                return IExecuteWithSignature<long>("getVsyncId", "()J");
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region VsyncCallback implementation
        public partial class VsyncCallback
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
            /// <see href="https://developer.android.com/reference/android/view/Choreographer.VsyncCallback.html#onVsync(android.view.Choreographer.FrameData)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Choreographer.FrameData"/></param>
            public void OnVsync(Android.View.Choreographer.FrameData arg0)
            {
                IExecuteWithSignature("onVsync", "(Landroid/view/Choreographer$FrameData;)V", arg0);
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