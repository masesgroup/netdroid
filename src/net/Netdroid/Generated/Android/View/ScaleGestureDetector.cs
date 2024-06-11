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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.View
{
    #region ScaleGestureDetector
    public partial class ScaleGestureDetector
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.html#%3Cinit%3E(android.content.Context,android.view.ScaleGestureDetector.OnScaleGestureListener,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.View.ScaleGestureDetector.OnScaleGestureListener"/></param>
        /// <param name="arg2"><see cref="Android.Os.Handler"/></param>
        public ScaleGestureDetector(Android.Content.Context arg0, Android.View.ScaleGestureDetector.OnScaleGestureListener arg1, Android.Os.Handler arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.html#%3Cinit%3E(android.content.Context,android.view.ScaleGestureDetector.OnScaleGestureListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.View.ScaleGestureDetector.OnScaleGestureListener"/></param>
        public ScaleGestureDetector(Android.Content.Context arg0, Android.View.ScaleGestureDetector.OnScaleGestureListener arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.html#isInProgress()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsInProgress()
        {
            return IExecuteWithSignature<bool>("isInProgress", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.html#isQuickScaleEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsQuickScaleEnabled()
        {
            return IExecuteWithSignature<bool>("isQuickScaleEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.html#isStylusScaleEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsStylusScaleEnabled()
        {
            return IExecuteWithSignature<bool>("isStylusScaleEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.html#onTouchEvent(android.view.MotionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.MotionEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnTouchEvent(Android.View.MotionEvent arg0)
        {
            return IExecuteWithSignature<bool>("onTouchEvent", "(Landroid/view/MotionEvent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.html#getCurrentSpan()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetCurrentSpan()
        {
            return IExecuteWithSignature<float>("getCurrentSpan", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.html#getCurrentSpanX()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetCurrentSpanX()
        {
            return IExecuteWithSignature<float>("getCurrentSpanX", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.html#getCurrentSpanY()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetCurrentSpanY()
        {
            return IExecuteWithSignature<float>("getCurrentSpanY", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.html#getFocusX()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetFocusX()
        {
            return IExecuteWithSignature<float>("getFocusX", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.html#getFocusY()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetFocusY()
        {
            return IExecuteWithSignature<float>("getFocusY", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.html#getPreviousSpan()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetPreviousSpan()
        {
            return IExecuteWithSignature<float>("getPreviousSpan", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.html#getPreviousSpanX()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetPreviousSpanX()
        {
            return IExecuteWithSignature<float>("getPreviousSpanX", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.html#getPreviousSpanY()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetPreviousSpanY()
        {
            return IExecuteWithSignature<float>("getPreviousSpanY", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.html#getScaleFactor()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetScaleFactor()
        {
            return IExecuteWithSignature<float>("getScaleFactor", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.html#getEventTime()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetEventTime()
        {
            return IExecuteWithSignature<long>("getEventTime", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.html#getTimeDelta()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetTimeDelta()
        {
            return IExecuteWithSignature<long>("getTimeDelta", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.html#setQuickScaleEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetQuickScaleEnabled(bool arg0)
        {
            IExecuteWithSignature("setQuickScaleEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.html#setStylusScaleEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetStylusScaleEnabled(bool arg0)
        {
            IExecuteWithSignature("setStylusScaleEnabled", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes
        #region OnScaleGestureListener
        public partial class OnScaleGestureListener
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
            /// Handlers initializer for <see cref="OnScaleGestureListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onScale", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.View.ScaleGestureDetector>>>(OnScaleEventHandler));
                AddEventHandler("onScaleBegin", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.View.ScaleGestureDetector>>>(OnScaleBeginEventHandler));
                AddEventHandler("onScaleEnd", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.View.ScaleGestureDetector>>>(OnScaleEndEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.OnScaleGestureListener.html#onScale(android.view.ScaleGestureDetector)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnScale"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Func<Android.View.ScaleGestureDetector, bool> OnOnScale { get; set; } = null;

            void OnScaleEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.View.ScaleGestureDetector>> data)
            {
                var methodToExecute = (OnOnScale != null) ? OnOnScale : OnScale;
                var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
                data.SetReturnValue(executionResult);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.OnScaleGestureListener.html#onScale(android.view.ScaleGestureDetector)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.ScaleGestureDetector"/></param>
            /// <returns><see cref="bool"/></returns>
            public virtual bool OnScale(Android.View.ScaleGestureDetector arg0)
            {
                return default;
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.OnScaleGestureListener.html#onScaleBegin(android.view.ScaleGestureDetector)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnScaleBegin"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Func<Android.View.ScaleGestureDetector, bool> OnOnScaleBegin { get; set; } = null;

            void OnScaleBeginEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.View.ScaleGestureDetector>> data)
            {
                var methodToExecute = (OnOnScaleBegin != null) ? OnOnScaleBegin : OnScaleBegin;
                var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
                data.SetReturnValue(executionResult);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.OnScaleGestureListener.html#onScaleBegin(android.view.ScaleGestureDetector)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.ScaleGestureDetector"/></param>
            /// <returns><see cref="bool"/></returns>
            public virtual bool OnScaleBegin(Android.View.ScaleGestureDetector arg0)
            {
                return default;
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.OnScaleGestureListener.html#onScaleEnd(android.view.ScaleGestureDetector)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnScaleEnd"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.View.ScaleGestureDetector> OnOnScaleEnd { get; set; } = null;

            void OnScaleEndEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.View.ScaleGestureDetector>> data)
            {
                var methodToExecute = (OnOnScaleEnd != null) ? OnOnScaleEnd : OnScaleEnd;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.OnScaleGestureListener.html#onScaleEnd(android.view.ScaleGestureDetector)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.ScaleGestureDetector"/></param>
            public virtual void OnScaleEnd(Android.View.ScaleGestureDetector arg0)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnScaleGestureListenerDirect
        public partial class OnScaleGestureListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.OnScaleGestureListener.html#onScale(android.view.ScaleGestureDetector)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.ScaleGestureDetector"/></param>
            /// <returns><see cref="bool"/></returns>
            public override bool OnScale(Android.View.ScaleGestureDetector arg0)
            {
                return IExecuteWithSignature<bool>("onScale", "(Landroid/view/ScaleGestureDetector;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.OnScaleGestureListener.html#onScaleBegin(android.view.ScaleGestureDetector)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.ScaleGestureDetector"/></param>
            /// <returns><see cref="bool"/></returns>
            public override bool OnScaleBegin(Android.View.ScaleGestureDetector arg0)
            {
                return IExecuteWithSignature<bool>("onScaleBegin", "(Landroid/view/ScaleGestureDetector;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.OnScaleGestureListener.html#onScaleEnd(android.view.ScaleGestureDetector)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.ScaleGestureDetector"/></param>
            public override void OnScaleEnd(Android.View.ScaleGestureDetector arg0)
            {
                IExecuteWithSignature("onScaleEnd", "(Landroid/view/ScaleGestureDetector;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region SimpleOnScaleGestureListener
        public partial class SimpleOnScaleGestureListener
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
            /// Handlers initializer for <see cref="SimpleOnScaleGestureListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onScale", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.View.ScaleGestureDetector>>>(OnScaleEventHandler));
                AddEventHandler("onScaleBegin", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.View.ScaleGestureDetector>>>(OnScaleBeginEventHandler));
                AddEventHandler("onScaleEnd", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.View.ScaleGestureDetector>>>(OnScaleEndEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.SimpleOnScaleGestureListener.html#onScale(android.view.ScaleGestureDetector)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnScale"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Func<Android.View.ScaleGestureDetector, bool> OnOnScale { get; set; } = null;

            void OnScaleEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.View.ScaleGestureDetector>> data)
            {
                var methodToExecute = (OnOnScale != null) ? OnOnScale : OnScale;
                var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
                data.SetReturnValue(executionResult);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.SimpleOnScaleGestureListener.html#onScale(android.view.ScaleGestureDetector)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.ScaleGestureDetector"/></param>
            /// <returns><see cref="bool"/></returns>
            public virtual bool OnScale(Android.View.ScaleGestureDetector arg0)
            {
                return default;
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.SimpleOnScaleGestureListener.html#onScaleBegin(android.view.ScaleGestureDetector)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnScaleBegin"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Func<Android.View.ScaleGestureDetector, bool> OnOnScaleBegin { get; set; } = null;

            void OnScaleBeginEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.View.ScaleGestureDetector>> data)
            {
                var methodToExecute = (OnOnScaleBegin != null) ? OnOnScaleBegin : OnScaleBegin;
                var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
                data.SetReturnValue(executionResult);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.SimpleOnScaleGestureListener.html#onScaleBegin(android.view.ScaleGestureDetector)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.ScaleGestureDetector"/></param>
            /// <returns><see cref="bool"/></returns>
            public virtual bool OnScaleBegin(Android.View.ScaleGestureDetector arg0)
            {
                return default;
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.SimpleOnScaleGestureListener.html#onScaleEnd(android.view.ScaleGestureDetector)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnScaleEnd"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.View.ScaleGestureDetector> OnOnScaleEnd { get; set; } = null;

            void OnScaleEndEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.View.ScaleGestureDetector>> data)
            {
                var methodToExecute = (OnOnScaleEnd != null) ? OnOnScaleEnd : OnScaleEnd;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.SimpleOnScaleGestureListener.html#onScaleEnd(android.view.ScaleGestureDetector)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.ScaleGestureDetector"/></param>
            public virtual void OnScaleEnd(Android.View.ScaleGestureDetector arg0)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region SimpleOnScaleGestureListenerDirect
        public partial class SimpleOnScaleGestureListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.SimpleOnScaleGestureListener.html#onScale(android.view.ScaleGestureDetector)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.ScaleGestureDetector"/></param>
            /// <returns><see cref="bool"/></returns>
            public override bool OnScale(Android.View.ScaleGestureDetector arg0)
            {
                return IExecuteWithSignature<bool>("onScale", "(Landroid/view/ScaleGestureDetector;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.SimpleOnScaleGestureListener.html#onScaleBegin(android.view.ScaleGestureDetector)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.ScaleGestureDetector"/></param>
            /// <returns><see cref="bool"/></returns>
            public override bool OnScaleBegin(Android.View.ScaleGestureDetector arg0)
            {
                return IExecuteWithSignature<bool>("onScaleBegin", "(Landroid/view/ScaleGestureDetector;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/ScaleGestureDetector.SimpleOnScaleGestureListener.html#onScaleEnd(android.view.ScaleGestureDetector)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.ScaleGestureDetector"/></param>
            public override void OnScaleEnd(Android.View.ScaleGestureDetector arg0)
            {
                IExecuteWithSignature("onScaleEnd", "(Landroid/view/ScaleGestureDetector;)V", arg0);
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