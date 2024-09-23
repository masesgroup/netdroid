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

namespace Android.Animation
{
    #region LayoutTransition declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.html"/>
    /// </summary>
    public partial class LayoutTransition : MASES.JCOBridge.C2JBridge.JVMBridgeBase<LayoutTransition>
    {
        const string _bridgeClassName = "android.animation.LayoutTransition";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public LayoutTransition() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public LayoutTransition(params object[] args) : base(args) { }
    
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
        #region TransitionListener declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.TransitionListener.html"/>
        /// </summary>
        public partial class TransitionListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public TransitionListener() { InitializeHandlers(); }
        
            const string _bridgeClassName = "org.mases.netdroid.generated.android.animation.LayoutTransition_TransitionListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
            
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
        
        
            // TODO: complete the class
        
        }
        #endregion
        
        #region TransitionListenerDirect declaration
        /// <summary>
        /// Direct override of <see cref="TransitionListener"/> or its generic type if there is one
        /// </summary>
        public partial class TransitionListenerDirect : TransitionListener
        {
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
            /// </summary>
            public override bool AutoInit => false;
        
            /// <inheritdoc />
            protected override void InitializeHandlers() { }
        
            const string _bridgeClassName = "android.animation.LayoutTransition$TransitionListener";
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

    #region LayoutTransition implementation
    public partial class LayoutTransition
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.html#APPEARING"/>
        /// </summary>
        public static int APPEARING { get { if (!_APPEARINGReady) { _APPEARINGContent = SGetField<int>(LocalBridgeClazz, "APPEARING"); _APPEARINGReady = true; } return _APPEARINGContent; } }
        private static int _APPEARINGContent = default;
        private static bool _APPEARINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.html#CHANGE_APPEARING"/>
        /// </summary>
        public static int CHANGE_APPEARING { get { if (!_CHANGE_APPEARINGReady) { _CHANGE_APPEARINGContent = SGetField<int>(LocalBridgeClazz, "CHANGE_APPEARING"); _CHANGE_APPEARINGReady = true; } return _CHANGE_APPEARINGContent; } }
        private static int _CHANGE_APPEARINGContent = default;
        private static bool _CHANGE_APPEARINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.html#CHANGE_DISAPPEARING"/>
        /// </summary>
        public static int CHANGE_DISAPPEARING { get { if (!_CHANGE_DISAPPEARINGReady) { _CHANGE_DISAPPEARINGContent = SGetField<int>(LocalBridgeClazz, "CHANGE_DISAPPEARING"); _CHANGE_DISAPPEARINGReady = true; } return _CHANGE_DISAPPEARINGContent; } }
        private static int _CHANGE_DISAPPEARINGContent = default;
        private static bool _CHANGE_DISAPPEARINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.html#CHANGING"/>
        /// </summary>
        public static int CHANGING { get { if (!_CHANGINGReady) { _CHANGINGContent = SGetField<int>(LocalBridgeClazz, "CHANGING"); _CHANGINGReady = true; } return _CHANGINGContent; } }
        private static int _CHANGINGContent = default;
        private static bool _CHANGINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.html#DISAPPEARING"/>
        /// </summary>
        public static int DISAPPEARING { get { if (!_DISAPPEARINGReady) { _DISAPPEARINGContent = SGetField<int>(LocalBridgeClazz, "DISAPPEARING"); _DISAPPEARINGReady = true; } return _DISAPPEARINGContent; } }
        private static int _DISAPPEARINGContent = default;
        private static bool _DISAPPEARINGReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.html#getAnimator(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Animation.Animator"/></returns>
        public Android.Animation.Animator GetAnimator(int arg0)
        {
            return IExecuteWithSignature<Android.Animation.Animator>("getAnimator", "(I)Landroid/animation/Animator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.html#getInterpolator(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Animation.TimeInterpolator"/></returns>
        public Android.Animation.TimeInterpolator GetInterpolator(int arg0)
        {
            return IExecuteWithSignature<Android.Animation.TimeInterpolator>("getInterpolator", "(I)Landroid/animation/TimeInterpolator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.html#isChangingLayout()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsChangingLayout()
        {
            return IExecuteWithSignature<bool>("isChangingLayout", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.html#isRunning()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRunning()
        {
            return IExecuteWithSignature<bool>("isRunning", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.html#isTransitionTypeEnabled(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsTransitionTypeEnabled(int arg0)
        {
            return IExecuteWithSignature<bool>("isTransitionTypeEnabled", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.html#getTransitionListeners()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Animation.LayoutTransition.TransitionListener> GetTransitionListeners()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Animation.LayoutTransition.TransitionListener>>("getTransitionListeners", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.html#getDuration(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetDuration(int arg0)
        {
            return IExecuteWithSignature<long>("getDuration", "(I)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.html#getStagger(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetStagger(int arg0)
        {
            return IExecuteWithSignature<long>("getStagger", "(I)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.html#getStartDelay(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetStartDelay(int arg0)
        {
            return IExecuteWithSignature<long>("getStartDelay", "(I)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.html#addChild(android.view.ViewGroup,android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.ViewGroup"/></param>
        /// <param name="arg1"><see cref="Android.View.View"/></param>
        public void AddChild(Android.View.ViewGroup arg0, Android.View.View arg1)
        {
            IExecute("addChild", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.html#addTransitionListener(android.animation.LayoutTransition.TransitionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Animation.LayoutTransition.TransitionListener"/></param>
        public void AddTransitionListener(Android.Animation.LayoutTransition.TransitionListener arg0)
        {
            IExecuteWithSignature("addTransitionListener", "(Landroid/animation/LayoutTransition$TransitionListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.html#disableTransitionType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void DisableTransitionType(int arg0)
        {
            IExecuteWithSignature("disableTransitionType", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.html#enableTransitionType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void EnableTransitionType(int arg0)
        {
            IExecuteWithSignature("enableTransitionType", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.html#hideChild(android.view.ViewGroup,android.view.View,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.ViewGroup"/></param>
        /// <param name="arg1"><see cref="Android.View.View"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void HideChild(Android.View.ViewGroup arg0, Android.View.View arg1, int arg2)
        {
            IExecute("hideChild", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.html#hideChild(android.view.ViewGroup,android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.ViewGroup"/></param>
        /// <param name="arg1"><see cref="Android.View.View"/></param>
        [global::System.Obsolete()]
        public void HideChild(Android.View.ViewGroup arg0, Android.View.View arg1)
        {
            IExecute("hideChild", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.html#removeChild(android.view.ViewGroup,android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.ViewGroup"/></param>
        /// <param name="arg1"><see cref="Android.View.View"/></param>
        public void RemoveChild(Android.View.ViewGroup arg0, Android.View.View arg1)
        {
            IExecute("removeChild", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.html#removeTransitionListener(android.animation.LayoutTransition.TransitionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Animation.LayoutTransition.TransitionListener"/></param>
        public void RemoveTransitionListener(Android.Animation.LayoutTransition.TransitionListener arg0)
        {
            IExecuteWithSignature("removeTransitionListener", "(Landroid/animation/LayoutTransition$TransitionListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.html#setAnimateParentHierarchy(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetAnimateParentHierarchy(bool arg0)
        {
            IExecuteWithSignature("setAnimateParentHierarchy", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.html#setAnimator(int,android.animation.Animator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Animation.Animator"/></param>
        public void SetAnimator(int arg0, Android.Animation.Animator arg1)
        {
            IExecute("setAnimator", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.html#setDuration(int,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public void SetDuration(int arg0, long arg1)
        {
            IExecute("setDuration", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.html#setDuration(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetDuration(long arg0)
        {
            IExecuteWithSignature("setDuration", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.html#setInterpolator(int,android.animation.TimeInterpolator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Animation.TimeInterpolator"/></param>
        public void SetInterpolator(int arg0, Android.Animation.TimeInterpolator arg1)
        {
            IExecute("setInterpolator", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.html#setStagger(int,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public void SetStagger(int arg0, long arg1)
        {
            IExecute("setStagger", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.html#setStartDelay(int,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public void SetStartDelay(int arg0, long arg1)
        {
            IExecute("setStartDelay", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.html#showChild(android.view.ViewGroup,android.view.View,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.ViewGroup"/></param>
        /// <param name="arg1"><see cref="Android.View.View"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void ShowChild(Android.View.ViewGroup arg0, Android.View.View arg1, int arg2)
        {
            IExecute("showChild", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.html#showChild(android.view.ViewGroup,android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.ViewGroup"/></param>
        /// <param name="arg1"><see cref="Android.View.View"/></param>
        [global::System.Obsolete()]
        public void ShowChild(Android.View.ViewGroup arg0, Android.View.View arg1)
        {
            IExecute("showChild", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
        #region TransitionListener implementation
        public partial class TransitionListener
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
            /// Handlers initializer for <see cref="TransitionListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("endTransition", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(EndTransitionEventHandler));
                AddEventHandler("startTransition", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(StartTransitionEventHandler));

            }
            
            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/animation/LayoutTransition.TransitionListener.html#endTransition(android.animation.LayoutTransition,android.view.ViewGroup,android.view.View,int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnEndTransition"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Animation.LayoutTransition, Android.View.ViewGroup, Android.View.View, int> OnEndTransition { get; set; } = null;
            
            bool hasOverrideEndTransition = true;
            void EndTransitionEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideEndTransition = true;
                var methodToExecute = (OnEndTransition != null) ? OnEndTransition : EndTransition;
                methodToExecute.Invoke(data.EventData.GetAt<Android.Animation.LayoutTransition>(0), data.EventData.GetAt<Android.View.ViewGroup>(1), data.EventData.GetAt<Android.View.View>(2), data.EventData.GetAt<int>(3));
                data.EventData.TypedEventData.HasOverride = hasOverrideEndTransition;
            }
            
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.TransitionListener.html#endTransition(android.animation.LayoutTransition,android.view.ViewGroup,android.view.View,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Animation.LayoutTransition"/></param>
            /// <param name="arg1"><see cref="Android.View.ViewGroup"/></param>
            /// <param name="arg2"><see cref="Android.View.View"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            public virtual void EndTransition(Android.Animation.LayoutTransition arg0, Android.View.ViewGroup arg1, Android.View.View arg2, int arg3)
            {
                hasOverrideEndTransition = false;
            }
            
            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/animation/LayoutTransition.TransitionListener.html#startTransition(android.animation.LayoutTransition,android.view.ViewGroup,android.view.View,int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnStartTransition"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Animation.LayoutTransition, Android.View.ViewGroup, Android.View.View, int> OnStartTransition { get; set; } = null;
            
            bool hasOverrideStartTransition = true;
            void StartTransitionEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideStartTransition = true;
                var methodToExecute = (OnStartTransition != null) ? OnStartTransition : StartTransition;
                methodToExecute.Invoke(data.EventData.GetAt<Android.Animation.LayoutTransition>(0), data.EventData.GetAt<Android.View.ViewGroup>(1), data.EventData.GetAt<Android.View.View>(2), data.EventData.GetAt<int>(3));
                data.EventData.TypedEventData.HasOverride = hasOverrideStartTransition;
            }
            
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.TransitionListener.html#startTransition(android.animation.LayoutTransition,android.view.ViewGroup,android.view.View,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Animation.LayoutTransition"/></param>
            /// <param name="arg1"><see cref="Android.View.ViewGroup"/></param>
            /// <param name="arg2"><see cref="Android.View.View"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            public virtual void StartTransition(Android.Animation.LayoutTransition arg0, Android.View.ViewGroup arg1, Android.View.View arg2, int arg3)
            {
                hasOverrideStartTransition = false;
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region TransitionListenerDirect implementation
        public partial class TransitionListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.TransitionListener.html#endTransition(android.animation.LayoutTransition,android.view.ViewGroup,android.view.View,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Animation.LayoutTransition"/></param>
            /// <param name="arg1"><see cref="Android.View.ViewGroup"/></param>
            /// <param name="arg2"><see cref="Android.View.View"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            public override void EndTransition(Android.Animation.LayoutTransition arg0, Android.View.ViewGroup arg1, Android.View.View arg2, int arg3)
            {
                IExecute("endTransition", arg0, arg1, arg2, arg3);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/animation/LayoutTransition.TransitionListener.html#startTransition(android.animation.LayoutTransition,android.view.ViewGroup,android.view.View,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Animation.LayoutTransition"/></param>
            /// <param name="arg1"><see cref="Android.View.ViewGroup"/></param>
            /// <param name="arg2"><see cref="Android.View.View"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            public override void StartTransition(Android.Animation.LayoutTransition arg0, Android.View.ViewGroup arg1, Android.View.View arg2, int arg3)
            {
                IExecute("startTransition", arg0, arg1, arg2, arg3);
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