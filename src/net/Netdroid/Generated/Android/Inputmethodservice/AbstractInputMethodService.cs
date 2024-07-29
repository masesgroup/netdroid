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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Inputmethodservice
{
    #region AbstractInputMethodService
    public partial class AbstractInputMethodService
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
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/AbstractInputMethodService.html#onCreateInputMethodInterface()"/>
        /// </summary>
        /// <returns><see cref="Android.Inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl"/></returns>
        public Android.Inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl OnCreateInputMethodInterface()
        {
            return IExecuteWithSignature<Android.Inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl>("onCreateInputMethodInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodImpl;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/AbstractInputMethodService.html#onCreateInputMethodSessionInterface()"/>
        /// </summary>
        /// <returns><see cref="Android.Inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl"/></returns>
        public Android.Inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl OnCreateInputMethodSessionInterface()
        {
            return IExecuteWithSignature<Android.Inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl>("onCreateInputMethodSessionInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodSessionImpl;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/AbstractInputMethodService.html#getKeyDispatcherState()"/>
        /// </summary>
        /// <returns><see cref="Android.View.KeyEvent.DispatcherState"/></returns>
        public Android.View.KeyEvent.DispatcherState GetKeyDispatcherState()
        {
            return IExecuteWithSignature<Android.View.KeyEvent.DispatcherState>("getKeyDispatcherState", "()Landroid/view/KeyEvent$DispatcherState;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/AbstractInputMethodService.html#onGenericMotionEvent(android.view.MotionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.MotionEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnGenericMotionEvent(Android.View.MotionEvent arg0)
        {
            return IExecuteWithSignature<bool>("onGenericMotionEvent", "(Landroid/view/MotionEvent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/inputmethodservice/AbstractInputMethodService.html#onTrackballEvent(android.view.MotionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.MotionEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnTrackballEvent(Android.View.MotionEvent arg0)
        {
            return IExecuteWithSignature<bool>("onTrackballEvent", "(Landroid/view/MotionEvent;)Z", arg0);
        }

        #endregion

        #region Nested classes
        #region AbstractInputMethodImpl
        public partial class AbstractInputMethodImpl
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/AbstractInputMethodService.AbstractInputMethodImpl.html#%3Cinit%3E(android.inputmethodservice.AbstractInputMethodService)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Inputmethodservice.AbstractInputMethodService"/></param>
            public AbstractInputMethodImpl(Android.Inputmethodservice.AbstractInputMethodService arg0)
                : base(arg0)
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
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/AbstractInputMethodService.AbstractInputMethodImpl.html#createSession(android.view.inputmethod.InputMethod.SessionCallback)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Inputmethod.InputMethod.SessionCallback"/></param>
            public void CreateSession(Android.View.Inputmethod.InputMethod.SessionCallback arg0)
            {
                IExecuteWithSignature("createSession", "(Landroid/view/inputmethod/InputMethod$SessionCallback;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/AbstractInputMethodService.AbstractInputMethodImpl.html#revokeSession(android.view.inputmethod.InputMethodSession)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Inputmethod.InputMethodSession"/></param>
            public void RevokeSession(Android.View.Inputmethod.InputMethodSession arg0)
            {
                IExecuteWithSignature("revokeSession", "(Landroid/view/inputmethod/InputMethodSession;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/AbstractInputMethodService.AbstractInputMethodImpl.html#setSessionEnabled(android.view.inputmethod.InputMethodSession,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Inputmethod.InputMethodSession"/></param>
            /// <param name="arg1"><see cref="bool"/></param>
            public void SetSessionEnabled(Android.View.Inputmethod.InputMethodSession arg0, bool arg1)
            {
                IExecute("setSessionEnabled", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region AbstractInputMethodSessionImpl
        public partial class AbstractInputMethodSessionImpl
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/AbstractInputMethodService.AbstractInputMethodSessionImpl.html#%3Cinit%3E(android.inputmethodservice.AbstractInputMethodService)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Inputmethodservice.AbstractInputMethodService"/></param>
            public AbstractInputMethodSessionImpl(Android.Inputmethodservice.AbstractInputMethodService arg0)
                : base(arg0)
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
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/AbstractInputMethodService.AbstractInputMethodSessionImpl.html#isEnabled()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsEnabled()
            {
                return IExecuteWithSignature<bool>("isEnabled", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/AbstractInputMethodService.AbstractInputMethodSessionImpl.html#isRevoked()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsRevoked()
            {
                return IExecuteWithSignature<bool>("isRevoked", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/AbstractInputMethodService.AbstractInputMethodSessionImpl.html#dispatchGenericMotionEvent(int,android.view.MotionEvent,android.view.inputmethod.InputMethodSession.EventCallback)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="Android.View.MotionEvent"/></param>
            /// <param name="arg2"><see cref="Android.View.Inputmethod.InputMethodSession.EventCallback"/></param>
            public void DispatchGenericMotionEvent(int arg0, Android.View.MotionEvent arg1, Android.View.Inputmethod.InputMethodSession.EventCallback arg2)
            {
                IExecute("dispatchGenericMotionEvent", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/AbstractInputMethodService.AbstractInputMethodSessionImpl.html#dispatchKeyEvent(int,android.view.KeyEvent,android.view.inputmethod.InputMethodSession.EventCallback)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="Android.View.KeyEvent"/></param>
            /// <param name="arg2"><see cref="Android.View.Inputmethod.InputMethodSession.EventCallback"/></param>
            public void DispatchKeyEvent(int arg0, Android.View.KeyEvent arg1, Android.View.Inputmethod.InputMethodSession.EventCallback arg2)
            {
                IExecute("dispatchKeyEvent", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/AbstractInputMethodService.AbstractInputMethodSessionImpl.html#dispatchTrackballEvent(int,android.view.MotionEvent,android.view.inputmethod.InputMethodSession.EventCallback)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="Android.View.MotionEvent"/></param>
            /// <param name="arg2"><see cref="Android.View.Inputmethod.InputMethodSession.EventCallback"/></param>
            public void DispatchTrackballEvent(int arg0, Android.View.MotionEvent arg1, Android.View.Inputmethod.InputMethodSession.EventCallback arg2)
            {
                IExecute("dispatchTrackballEvent", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/AbstractInputMethodService.AbstractInputMethodSessionImpl.html#revokeSelf()"/>
            /// </summary>
            public void RevokeSelf()
            {
                IExecuteWithSignature("revokeSelf", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/inputmethodservice/AbstractInputMethodService.AbstractInputMethodSessionImpl.html#setEnabled(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            public void SetEnabled(bool arg0)
            {
                IExecuteWithSignature("setEnabled", "(Z)V", arg0);
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