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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Animation
{
    #region Animator
    public partial class Animator
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Animator.html#DURATION_INFINITE"/>
        /// </summary>
        public static long DURATION_INFINITE { get { if (!_DURATION_INFINITEReady) { _DURATION_INFINITEContent = SGetField<long>(LocalBridgeClazz, "DURATION_INFINITE"); _DURATION_INFINITEReady = true; } return _DURATION_INFINITEContent; } }
        private static long _DURATION_INFINITEContent = default;
        private static bool _DURATION_INFINITEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Animator.html#setDuration(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Android.Animation.Animator"/></returns>
        public Android.Animation.Animator SetDuration(long arg0)
        {
            return IExecuteWithSignature<Android.Animation.Animator>("setDuration", "(J)Landroid/animation/Animator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Animator.html#isRunning()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRunning()
        {
            return IExecuteWithSignature<bool>("isRunning", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Animator.html#getDuration()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetDuration()
        {
            return IExecuteWithSignature<long>("getDuration", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Animator.html#getStartDelay()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetStartDelay()
        {
            return IExecuteWithSignature<long>("getStartDelay", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Animator.html#setInterpolator(android.animation.TimeInterpolator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Animation.TimeInterpolator"/></param>
        public void SetInterpolator(Android.Animation.TimeInterpolator arg0)
        {
            IExecuteWithSignature("setInterpolator", "(Landroid/animation/TimeInterpolator;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Animator.html#setStartDelay(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetStartDelay(long arg0)
        {
            IExecuteWithSignature("setStartDelay", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Animator.html#clone()"/>
        /// </summary>
        /// <returns><see cref="Android.Animation.Animator"/></returns>
        public Android.Animation.Animator Clone()
        {
            return IExecuteWithSignature<Android.Animation.Animator>("clone", "()Landroid/animation/Animator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Animator.html#getInterpolator()"/>
        /// </summary>
        /// <returns><see cref="Android.Animation.TimeInterpolator"/></returns>
        public Android.Animation.TimeInterpolator GetInterpolator()
        {
            return IExecuteWithSignature<Android.Animation.TimeInterpolator>("getInterpolator", "()Landroid/animation/TimeInterpolator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Animator.html#isPaused()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPaused()
        {
            return IExecuteWithSignature<bool>("isPaused", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Animator.html#isStarted()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsStarted()
        {
            return IExecuteWithSignature<bool>("isStarted", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Animator.html#getListeners()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.ArrayList"/></returns>
        public Java.Util.ArrayList<Android.Animation.Animator.AnimatorListener> GetListeners()
        {
            return IExecuteWithSignature<Java.Util.ArrayList<Android.Animation.Animator.AnimatorListener>>("getListeners", "()Ljava/util/ArrayList;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Animator.html#getTotalDuration()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetTotalDuration()
        {
            return IExecuteWithSignature<long>("getTotalDuration", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Animator.html#addListener(android.animation.Animator.AnimatorListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Animation.Animator.AnimatorListener"/></param>
        public void AddListener(Android.Animation.Animator.AnimatorListener arg0)
        {
            IExecuteWithSignature("addListener", "(Landroid/animation/Animator$AnimatorListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Animator.html#addPauseListener(android.animation.Animator.AnimatorPauseListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Animation.Animator.AnimatorPauseListener"/></param>
        public void AddPauseListener(Android.Animation.Animator.AnimatorPauseListener arg0)
        {
            IExecuteWithSignature("addPauseListener", "(Landroid/animation/Animator$AnimatorPauseListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Animator.html#cancel()"/>
        /// </summary>
        public void Cancel()
        {
            IExecuteWithSignature("cancel", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Animator.html#end()"/>
        /// </summary>
        public void End()
        {
            IExecuteWithSignature("end", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Animator.html#pause()"/>
        /// </summary>
        public void Pause()
        {
            IExecuteWithSignature("pause", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Animator.html#removeAllListeners()"/>
        /// </summary>
        public void RemoveAllListeners()
        {
            IExecuteWithSignature("removeAllListeners", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Animator.html#removeListener(android.animation.Animator.AnimatorListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Animation.Animator.AnimatorListener"/></param>
        public void RemoveListener(Android.Animation.Animator.AnimatorListener arg0)
        {
            IExecuteWithSignature("removeListener", "(Landroid/animation/Animator$AnimatorListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Animator.html#removePauseListener(android.animation.Animator.AnimatorPauseListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Animation.Animator.AnimatorPauseListener"/></param>
        public void RemovePauseListener(Android.Animation.Animator.AnimatorPauseListener arg0)
        {
            IExecuteWithSignature("removePauseListener", "(Landroid/animation/Animator$AnimatorPauseListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Animator.html#resume()"/>
        /// </summary>
        public void Resume()
        {
            IExecuteWithSignature("resume", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Animator.html#setTarget(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void SetTarget(object arg0)
        {
            IExecuteWithSignature("setTarget", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Animator.html#setupEndValues()"/>
        /// </summary>
        public void SetupEndValues()
        {
            IExecuteWithSignature("setupEndValues", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Animator.html#setupStartValues()"/>
        /// </summary>
        public void SetupStartValues()
        {
            IExecuteWithSignature("setupStartValues", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Animator.html#start()"/>
        /// </summary>
        public void Start()
        {
            IExecuteWithSignature("start", "()V");
        }

        #endregion

        #region Nested classes
        #region AnimatorListener
        public partial class AnimatorListener
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
            /// Handlers initializer for <see cref="AnimatorListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onAnimationCancel", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Animation.Animator>>>(OnAnimationCancelEventHandler));
                AddEventHandler("onAnimationEnd", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Animation.Animator>>>(OnAnimationEndEventHandler));
                AddEventHandler("onAnimationRepeat", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Animation.Animator>>>(OnAnimationRepeatEventHandler));
                AddEventHandler("onAnimationStart", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Animation.Animator>>>(OnAnimationStartEventHandler));
                AddEventHandler("onAnimationEnd2", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Animation.Animator>>>(OnAnimationEnd2EventHandler));
                AddEventHandler("onAnimationStart2", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Animation.Animator>>>(OnAnimationStart2EventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/animation/Animator.AnimatorListener.html#onAnimationCancel(android.animation.Animator)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnAnimationCancel"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Animation.Animator> OnOnAnimationCancel { get; set; } = null;

            void OnAnimationCancelEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Animation.Animator>> data)
            {
                var methodToExecute = (OnOnAnimationCancel != null) ? OnOnAnimationCancel : OnAnimationCancel;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/animation/Animator.AnimatorListener.html#onAnimationCancel(android.animation.Animator)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Animation.Animator"/></param>
            public virtual void OnAnimationCancel(Android.Animation.Animator arg0)
            {
                
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/animation/Animator.AnimatorListener.html#onAnimationEnd(android.animation.Animator)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnAnimationEnd"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Animation.Animator> OnOnAnimationEnd { get; set; } = null;

            void OnAnimationEndEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Animation.Animator>> data)
            {
                var methodToExecute = (OnOnAnimationEnd != null) ? OnOnAnimationEnd : OnAnimationEnd;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/animation/Animator.AnimatorListener.html#onAnimationEnd(android.animation.Animator)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Animation.Animator"/></param>
            public virtual void OnAnimationEnd(Android.Animation.Animator arg0)
            {
                
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/animation/Animator.AnimatorListener.html#onAnimationRepeat(android.animation.Animator)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnAnimationRepeat"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Animation.Animator> OnOnAnimationRepeat { get; set; } = null;

            void OnAnimationRepeatEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Animation.Animator>> data)
            {
                var methodToExecute = (OnOnAnimationRepeat != null) ? OnOnAnimationRepeat : OnAnimationRepeat;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/animation/Animator.AnimatorListener.html#onAnimationRepeat(android.animation.Animator)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Animation.Animator"/></param>
            public virtual void OnAnimationRepeat(Android.Animation.Animator arg0)
            {
                
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/animation/Animator.AnimatorListener.html#onAnimationStart(android.animation.Animator)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnAnimationStart"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Animation.Animator> OnOnAnimationStart { get; set; } = null;

            void OnAnimationStartEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Animation.Animator>> data)
            {
                var methodToExecute = (OnOnAnimationStart != null) ? OnOnAnimationStart : OnAnimationStart;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/animation/Animator.AnimatorListener.html#onAnimationStart(android.animation.Animator)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Animation.Animator"/></param>
            public virtual void OnAnimationStart(Android.Animation.Animator arg0)
            {
                
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/animation/Animator.AnimatorListener.html#onAnimationEnd(android.animation.Animator,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Animation.Animator"/></param>
            /// <param name="arg1"><see cref="bool"/></param>
            /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
            public void OnAnimationEndDefault(Android.Animation.Animator arg0, bool arg1)
            {
                IExecute("onAnimationEndDefault", arg0, arg1);
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/animation/Animator.AnimatorListener.html#onAnimationEnd(android.animation.Animator,boolean)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnAnimationEnd2"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Animation.Animator, bool> OnOnAnimationEnd2 { get; set; } = null;

            void OnAnimationEnd2EventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Animation.Animator>> data)
            {
                var methodToExecute = (OnOnAnimationEnd2 != null) ? OnOnAnimationEnd2 : OnAnimationEnd;
                methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<bool>(0));
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/animation/Animator.AnimatorListener.html#onAnimationEnd(android.animation.Animator,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Animation.Animator"/></param>
            /// <param name="arg1"><see cref="bool"/></param>
            /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="OnAnimationEndDefault"/>; override the method to implement a different behavior</remarks>
            public virtual void OnAnimationEnd(Android.Animation.Animator arg0, bool arg1)
            {
                OnAnimationEndDefault(arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/animation/Animator.AnimatorListener.html#onAnimationStart(android.animation.Animator,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Animation.Animator"/></param>
            /// <param name="arg1"><see cref="bool"/></param>
            /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
            public void OnAnimationStartDefault(Android.Animation.Animator arg0, bool arg1)
            {
                IExecute("onAnimationStartDefault", arg0, arg1);
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/animation/Animator.AnimatorListener.html#onAnimationStart(android.animation.Animator,boolean)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnAnimationStart2"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Animation.Animator, bool> OnOnAnimationStart2 { get; set; } = null;

            void OnAnimationStart2EventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Animation.Animator>> data)
            {
                var methodToExecute = (OnOnAnimationStart2 != null) ? OnOnAnimationStart2 : OnAnimationStart;
                methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<bool>(0));
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/animation/Animator.AnimatorListener.html#onAnimationStart(android.animation.Animator,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Animation.Animator"/></param>
            /// <param name="arg1"><see cref="bool"/></param>
            /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="OnAnimationStartDefault"/>; override the method to implement a different behavior</remarks>
            public virtual void OnAnimationStart(Android.Animation.Animator arg0, bool arg1)
            {
                OnAnimationStartDefault(arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region AnimatorListenerDirect
        public partial class AnimatorListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/animation/Animator.AnimatorListener.html#onAnimationCancel(android.animation.Animator)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Animation.Animator"/></param>
            public override void OnAnimationCancel(Android.Animation.Animator arg0)
            {
                IExecuteWithSignature("onAnimationCancel", "(Landroid/animation/Animator;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/animation/Animator.AnimatorListener.html#onAnimationEnd(android.animation.Animator)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Animation.Animator"/></param>
            public override void OnAnimationEnd(Android.Animation.Animator arg0)
            {
                IExecuteWithSignature("onAnimationEnd", "(Landroid/animation/Animator;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/animation/Animator.AnimatorListener.html#onAnimationRepeat(android.animation.Animator)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Animation.Animator"/></param>
            public override void OnAnimationRepeat(Android.Animation.Animator arg0)
            {
                IExecuteWithSignature("onAnimationRepeat", "(Landroid/animation/Animator;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/animation/Animator.AnimatorListener.html#onAnimationStart(android.animation.Animator)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Animation.Animator"/></param>
            public override void OnAnimationStart(Android.Animation.Animator arg0)
            {
                IExecuteWithSignature("onAnimationStart", "(Landroid/animation/Animator;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/animation/Animator.AnimatorListener.html#onAnimationEnd(android.animation.Animator,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Animation.Animator"/></param>
            /// <param name="arg1"><see cref="bool"/></param>
            public override void OnAnimationEnd(Android.Animation.Animator arg0, bool arg1)
            {
                IExecute("onAnimationEnd", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/animation/Animator.AnimatorListener.html#onAnimationStart(android.animation.Animator,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Animation.Animator"/></param>
            /// <param name="arg1"><see cref="bool"/></param>
            public override void OnAnimationStart(Android.Animation.Animator arg0, bool arg1)
            {
                IExecute("onAnimationStart", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region AnimatorPauseListener
        public partial class AnimatorPauseListener
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
            /// Handlers initializer for <see cref="AnimatorPauseListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onAnimationPause", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Animation.Animator>>>(OnAnimationPauseEventHandler));
                AddEventHandler("onAnimationResume", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Animation.Animator>>>(OnAnimationResumeEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/animation/Animator.AnimatorPauseListener.html#onAnimationPause(android.animation.Animator)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnAnimationPause"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Animation.Animator> OnOnAnimationPause { get; set; } = null;

            void OnAnimationPauseEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Animation.Animator>> data)
            {
                var methodToExecute = (OnOnAnimationPause != null) ? OnOnAnimationPause : OnAnimationPause;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/animation/Animator.AnimatorPauseListener.html#onAnimationPause(android.animation.Animator)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Animation.Animator"/></param>
            public virtual void OnAnimationPause(Android.Animation.Animator arg0)
            {
                
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/animation/Animator.AnimatorPauseListener.html#onAnimationResume(android.animation.Animator)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnAnimationResume"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Animation.Animator> OnOnAnimationResume { get; set; } = null;

            void OnAnimationResumeEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Animation.Animator>> data)
            {
                var methodToExecute = (OnOnAnimationResume != null) ? OnOnAnimationResume : OnAnimationResume;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/animation/Animator.AnimatorPauseListener.html#onAnimationResume(android.animation.Animator)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Animation.Animator"/></param>
            public virtual void OnAnimationResume(Android.Animation.Animator arg0)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region AnimatorPauseListenerDirect
        public partial class AnimatorPauseListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/animation/Animator.AnimatorPauseListener.html#onAnimationPause(android.animation.Animator)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Animation.Animator"/></param>
            public override void OnAnimationPause(Android.Animation.Animator arg0)
            {
                IExecuteWithSignature("onAnimationPause", "(Landroid/animation/Animator;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/animation/Animator.AnimatorPauseListener.html#onAnimationResume(android.animation.Animator)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Animation.Animator"/></param>
            public override void OnAnimationResume(Android.Animation.Animator arg0)
            {
                IExecuteWithSignature("onAnimationResume", "(Landroid/animation/Animator;)V", arg0);
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