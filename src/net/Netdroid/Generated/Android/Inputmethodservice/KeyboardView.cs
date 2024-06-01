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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Inputmethodservice
{
    #region KeyboardView
    public partial class KeyboardView
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        [System.Obsolete()]
        public KeyboardView(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        [System.Obsolete()]
        public KeyboardView(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        [System.Obsolete()]
        public KeyboardView(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
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
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.html#getKeyboard()"/> <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.html#setKeyboard(android.inputmethodservice.Keyboard)"/>
        /// </summary>
        [System.Obsolete()]
        public Android.Inputmethodservice.Keyboard Keyboard
        {
            get { return IExecuteWithSignature<Android.Inputmethodservice.Keyboard>("getKeyboard", "()Landroid/inputmethodservice/Keyboard;"); } set { IExecuteWithSignature("setKeyboard", "(Landroid/inputmethodservice/Keyboard;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.html#handleBack()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [System.Obsolete()]
        public bool HandleBack()
        {
            return IExecuteWithSignature<bool>("handleBack", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.html#isPreviewEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [System.Obsolete()]
        public bool IsPreviewEnabled()
        {
            return IExecuteWithSignature<bool>("isPreviewEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.html#isProximityCorrectionEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [System.Obsolete()]
        public bool IsProximityCorrectionEnabled()
        {
            return IExecuteWithSignature<bool>("isProximityCorrectionEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.html#isShifted()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [System.Obsolete()]
        public bool IsShifted()
        {
            return IExecuteWithSignature<bool>("isShifted", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.html#setShifted(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        [System.Obsolete()]
        public bool SetShifted(bool arg0)
        {
            return IExecuteWithSignature<bool>("setShifted", "(Z)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.html#closing()"/>
        /// </summary>
        [System.Obsolete()]
        public void Closing()
        {
            IExecuteWithSignature("closing", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.html#invalidateAllKeys()"/>
        /// </summary>
        [System.Obsolete()]
        public void InvalidateAllKeys()
        {
            IExecuteWithSignature("invalidateAllKeys", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.html#invalidateKey(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [System.Obsolete()]
        public void InvalidateKey(int arg0)
        {
            IExecuteWithSignature("invalidateKey", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.html#onClick(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        public void OnClick(Android.View.View arg0)
        {
            IExecuteWithSignature("onClick", "(Landroid/view/View;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.html#onDetachedFromWindow()"/>
        /// </summary>
        [System.Obsolete()]
        public void OnDetachedFromWindow()
        {
            IExecuteWithSignature("onDetachedFromWindow", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.html#onDraw(android.graphics.Canvas)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Canvas"/></param>
        [System.Obsolete()]
        public void OnDraw(Android.Graphics.Canvas arg0)
        {
            IExecuteWithSignature("onDraw", "(Landroid/graphics/Canvas;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.html#onMeasure(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        [System.Obsolete()]
        public void OnMeasure(int arg0, int arg1)
        {
            IExecute("onMeasure", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.html#onSizeChanged(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        [System.Obsolete()]
        public void OnSizeChanged(int arg0, int arg1, int arg2, int arg3)
        {
            IExecute("onSizeChanged", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.html#setOnKeyboardActionListener(android.inputmethodservice.KeyboardView.OnKeyboardActionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Inputmethodservice.KeyboardView.OnKeyboardActionListener"/></param>
        [System.Obsolete()]
        public void SetOnKeyboardActionListener(Android.Inputmethodservice.KeyboardView.OnKeyboardActionListener arg0)
        {
            IExecuteWithSignature("setOnKeyboardActionListener", "(Landroid/inputmethodservice/KeyboardView$OnKeyboardActionListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.html#setPopupOffset(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        [System.Obsolete()]
        public void SetPopupOffset(int arg0, int arg1)
        {
            IExecute("setPopupOffset", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.html#setPopupParent(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        [System.Obsolete()]
        public void SetPopupParent(Android.View.View arg0)
        {
            IExecuteWithSignature("setPopupParent", "(Landroid/view/View;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.html#setPreviewEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [System.Obsolete()]
        public void SetPreviewEnabled(bool arg0)
        {
            IExecuteWithSignature("setPreviewEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.html#setProximityCorrectionEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [System.Obsolete()]
        public void SetProximityCorrectionEnabled(bool arg0)
        {
            IExecuteWithSignature("setProximityCorrectionEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.html#setVerticalCorrection(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [System.Obsolete()]
        public void SetVerticalCorrection(int arg0)
        {
            IExecuteWithSignature("setVerticalCorrection", "(I)V", arg0);
        }

        #endregion

        #region Nested classes
        #region OnKeyboardActionListener
        public partial class OnKeyboardActionListener
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
            /// Handlers initializer for <see cref="OnKeyboardActionListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onKey", new System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(OnKeyEventHandler));
                AddEventHandler("onPress", new System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(OnPressEventHandler));
                AddEventHandler("onRelease", new System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(OnReleaseEventHandler));
                AddEventHandler("onText", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.CharSequence>>>(OnTextEventHandler));
                AddEventHandler("swipeDown", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(SwipeDownEventHandler));
                AddEventHandler("swipeLeft", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(SwipeLeftEventHandler));
                AddEventHandler("swipeRight", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(SwipeRightEventHandler));
                AddEventHandler("swipeUp", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(SwipeUpEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.OnKeyboardActionListener.html#onKey(int,int[])"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnKey"/> has a value it takes precedence over corresponding class method</remarks>
            public System.Action<int, int[]> OnOnKey { get; set; } = null;

            void OnKeyEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
            {
                var methodToExecute = (OnOnKey != null) ? OnOnKey : OnKey;
                methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<int[]>(0));
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.OnKeyboardActionListener.html#onKey(int,int[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            [System.Obsolete()]
            public virtual void OnKey(int arg0, int[] arg1)
            {
                
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.OnKeyboardActionListener.html#onPress(int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnPress"/> has a value it takes precedence over corresponding class method</remarks>
            public System.Action<int> OnOnPress { get; set; } = null;

            void OnPressEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
            {
                var methodToExecute = (OnOnPress != null) ? OnOnPress : OnPress;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.OnKeyboardActionListener.html#onPress(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            [System.Obsolete()]
            public virtual void OnPress(int arg0)
            {
                
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.OnKeyboardActionListener.html#onRelease(int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnRelease"/> has a value it takes precedence over corresponding class method</remarks>
            public System.Action<int> OnOnRelease { get; set; } = null;

            void OnReleaseEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
            {
                var methodToExecute = (OnOnRelease != null) ? OnOnRelease : OnRelease;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.OnKeyboardActionListener.html#onRelease(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            [System.Obsolete()]
            public virtual void OnRelease(int arg0)
            {
                
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.OnKeyboardActionListener.html#onText(java.lang.CharSequence)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnText"/> has a value it takes precedence over corresponding class method</remarks>
            public System.Action<Java.Lang.CharSequence> OnOnText { get; set; } = null;

            void OnTextEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.CharSequence>> data)
            {
                var methodToExecute = (OnOnText != null) ? OnOnText : OnText;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.OnKeyboardActionListener.html#onText(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            [System.Obsolete()]
            public virtual void OnText(Java.Lang.CharSequence arg0)
            {
                
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.OnKeyboardActionListener.html#swipeDown()"/>
            /// </summary>
            /// <remarks>If <see cref="OnSwipeDown"/> has a value it takes precedence over corresponding class method</remarks>
            public System.Action OnSwipeDown { get; set; } = null;

            void SwipeDownEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
            {
                var methodToExecute = (OnSwipeDown != null) ? OnSwipeDown : SwipeDown;
                methodToExecute.Invoke();
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.OnKeyboardActionListener.html#swipeDown()"/>
            /// </summary>
            [System.Obsolete()]
            public virtual void SwipeDown()
            {
                
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.OnKeyboardActionListener.html#swipeLeft()"/>
            /// </summary>
            /// <remarks>If <see cref="OnSwipeLeft"/> has a value it takes precedence over corresponding class method</remarks>
            public System.Action OnSwipeLeft { get; set; } = null;

            void SwipeLeftEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
            {
                var methodToExecute = (OnSwipeLeft != null) ? OnSwipeLeft : SwipeLeft;
                methodToExecute.Invoke();
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.OnKeyboardActionListener.html#swipeLeft()"/>
            /// </summary>
            [System.Obsolete()]
            public virtual void SwipeLeft()
            {
                
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.OnKeyboardActionListener.html#swipeRight()"/>
            /// </summary>
            /// <remarks>If <see cref="OnSwipeRight"/> has a value it takes precedence over corresponding class method</remarks>
            public System.Action OnSwipeRight { get; set; } = null;

            void SwipeRightEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
            {
                var methodToExecute = (OnSwipeRight != null) ? OnSwipeRight : SwipeRight;
                methodToExecute.Invoke();
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.OnKeyboardActionListener.html#swipeRight()"/>
            /// </summary>
            [System.Obsolete()]
            public virtual void SwipeRight()
            {
                
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.OnKeyboardActionListener.html#swipeUp()"/>
            /// </summary>
            /// <remarks>If <see cref="OnSwipeUp"/> has a value it takes precedence over corresponding class method</remarks>
            public System.Action OnSwipeUp { get; set; } = null;

            void SwipeUpEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
            {
                var methodToExecute = (OnSwipeUp != null) ? OnSwipeUp : SwipeUp;
                methodToExecute.Invoke();
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.OnKeyboardActionListener.html#swipeUp()"/>
            /// </summary>
            [System.Obsolete()]
            public virtual void SwipeUp()
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnKeyboardActionListenerDirect
        public partial class OnKeyboardActionListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.OnKeyboardActionListener.html#onKey(int,int[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            [System.Obsolete()]
            public override void OnKey(int arg0, int[] arg1)
            {
                IExecute("onKey", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.OnKeyboardActionListener.html#onPress(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            [System.Obsolete()]
            public override void OnPress(int arg0)
            {
                IExecuteWithSignature("onPress", "(I)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.OnKeyboardActionListener.html#onRelease(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            [System.Obsolete()]
            public override void OnRelease(int arg0)
            {
                IExecuteWithSignature("onRelease", "(I)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.OnKeyboardActionListener.html#onText(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            [System.Obsolete()]
            public override void OnText(Java.Lang.CharSequence arg0)
            {
                IExecuteWithSignature("onText", "(Ljava/lang/CharSequence;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.OnKeyboardActionListener.html#swipeDown()"/>
            /// </summary>
            [System.Obsolete()]
            public override void SwipeDown()
            {
                IExecuteWithSignature("swipeDown", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.OnKeyboardActionListener.html#swipeLeft()"/>
            /// </summary>
            [System.Obsolete()]
            public override void SwipeLeft()
            {
                IExecuteWithSignature("swipeLeft", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.OnKeyboardActionListener.html#swipeRight()"/>
            /// </summary>
            [System.Obsolete()]
            public override void SwipeRight()
            {
                IExecuteWithSignature("swipeRight", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/KeyboardView.OnKeyboardActionListener.html#swipeUp()"/>
            /// </summary>
            [System.Obsolete()]
            public override void SwipeUp()
            {
                IExecuteWithSignature("swipeUp", "()V");
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