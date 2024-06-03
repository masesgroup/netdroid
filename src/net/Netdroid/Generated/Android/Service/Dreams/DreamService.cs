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

namespace Android.Service.Dreams
{
    #region DreamService
    public partial class DreamService
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#DREAM_META_DATA"/>
        /// </summary>
        public static Java.Lang.String DREAM_META_DATA { get { if (!_DREAM_META_DATAReady) { _DREAM_META_DATAContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DREAM_META_DATA"); _DREAM_META_DATAReady = true; } return _DREAM_META_DATAContent; } }
        private static Java.Lang.String _DREAM_META_DATAContent = default;
        private static bool _DREAM_META_DATAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#SERVICE_INTERFACE"/>
        /// </summary>
        public static Java.Lang.String SERVICE_INTERFACE { get { if (!_SERVICE_INTERFACEReady) { _SERVICE_INTERFACEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SERVICE_INTERFACE"); _SERVICE_INTERFACEReady = true; } return _SERVICE_INTERFACEContent; } }
        private static Java.Lang.String _SERVICE_INTERFACEContent = default;
        private static bool _SERVICE_INTERFACEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#findViewById(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <typeparam name="T"><see cref="Android.View.View"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T FindViewById<T>(int arg0) where T : Android.View.View
        {
            return IExecuteWithSignature<T>("findViewById", "(I)Landroid/view/View;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#onWindowStartingActionMode(android.view.ActionMode.Callback,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.ActionMode.Callback"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.View.ActionMode"/></returns>
        public Android.View.ActionMode OnWindowStartingActionMode(Android.View.ActionMode.Callback arg0, int arg1)
        {
            return IExecute<Android.View.ActionMode>("onWindowStartingActionMode", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#onWindowStartingActionMode(android.view.ActionMode.Callback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.ActionMode.Callback"/></param>
        /// <returns><see cref="Android.View.ActionMode"/></returns>
        public Android.View.ActionMode OnWindowStartingActionMode(Android.View.ActionMode.Callback arg0)
        {
            return IExecuteWithSignature<Android.View.ActionMode>("onWindowStartingActionMode", "(Landroid/view/ActionMode$Callback;)Landroid/view/ActionMode;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#onCreatePanelView(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.View.View"/></returns>
        public Android.View.View OnCreatePanelView(int arg0)
        {
            return IExecuteWithSignature<Android.View.View>("onCreatePanelView", "(I)Landroid/view/View;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#getWindow()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Window"/></returns>
        public Android.View.Window GetWindow()
        {
            return IExecuteWithSignature<Android.View.Window>("getWindow", "()Landroid/view/Window;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#getWindowManager()"/>
        /// </summary>
        /// <returns><see cref="Android.View.WindowManager"/></returns>
        public Android.View.WindowManager GetWindowManager()
        {
            return IExecuteWithSignature<Android.View.WindowManager>("getWindowManager", "()Landroid/view/WindowManager;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#dispatchGenericMotionEvent(android.view.MotionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.MotionEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool DispatchGenericMotionEvent(Android.View.MotionEvent arg0)
        {
            return IExecuteWithSignature<bool>("dispatchGenericMotionEvent", "(Landroid/view/MotionEvent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#dispatchKeyEvent(android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool DispatchKeyEvent(Android.View.KeyEvent arg0)
        {
            return IExecuteWithSignature<bool>("dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#dispatchKeyShortcutEvent(android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool DispatchKeyShortcutEvent(Android.View.KeyEvent arg0)
        {
            return IExecuteWithSignature<bool>("dispatchKeyShortcutEvent", "(Landroid/view/KeyEvent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Accessibility.AccessibilityEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool DispatchPopulateAccessibilityEvent(Android.View.Accessibility.AccessibilityEvent arg0)
        {
            return IExecuteWithSignature<bool>("dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#dispatchTouchEvent(android.view.MotionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.MotionEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool DispatchTouchEvent(Android.View.MotionEvent arg0)
        {
            return IExecuteWithSignature<bool>("dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#dispatchTrackballEvent(android.view.MotionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.MotionEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool DispatchTrackballEvent(Android.View.MotionEvent arg0)
        {
            return IExecuteWithSignature<bool>("dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#isFullscreen()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFullscreen()
        {
            return IExecuteWithSignature<bool>("isFullscreen", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#isInteractive()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsInteractive()
        {
            return IExecuteWithSignature<bool>("isInteractive", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#isScreenBright()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsScreenBright()
        {
            return IExecuteWithSignature<bool>("isScreenBright", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#onCreatePanelMenu(int,android.view.Menu)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.View.Menu"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnCreatePanelMenu(int arg0, Android.View.Menu arg1)
        {
            return IExecute<bool>("onCreatePanelMenu", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#onMenuItemSelected(int,android.view.MenuItem)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.View.MenuItem"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnMenuItemSelected(int arg0, Android.View.MenuItem arg1)
        {
            return IExecute<bool>("onMenuItemSelected", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#onMenuOpened(int,android.view.Menu)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.View.Menu"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnMenuOpened(int arg0, Android.View.Menu arg1)
        {
            return IExecute<bool>("onMenuOpened", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#onPreparePanel(int,android.view.View,android.view.Menu)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.View.View"/></param>
        /// <param name="arg2"><see cref="Android.View.Menu"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnPreparePanel(int arg0, Android.View.View arg1, Android.View.Menu arg2)
        {
            return IExecute<bool>("onPreparePanel", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#onSearchRequested()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool OnSearchRequested()
        {
            return IExecuteWithSignature<bool>("onSearchRequested", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#onSearchRequested(android.view.SearchEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.SearchEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnSearchRequested(Android.View.SearchEvent arg0)
        {
            return IExecuteWithSignature<bool>("onSearchRequested", "(Landroid/view/SearchEvent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#requireViewById(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <typeparam name="T"><see cref="Android.View.View"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T RequireViewById<T>(int arg0) where T : Android.View.View
        {
            return IExecuteWithSignature<T>("requireViewById", "(I)Landroid/view/View;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#finish()"/>
        /// </summary>
        public void Finish()
        {
            IExecuteWithSignature("finish", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#wakeUp()"/>
        /// </summary>
        public void WakeUp()
        {
            IExecuteWithSignature("wakeUp", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#addContentView(android.view.View,android.view.ViewGroup.LayoutParams)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.View.ViewGroup.LayoutParams"/></param>
        public void AddContentView(Android.View.View arg0, Android.View.ViewGroup.LayoutParams arg1)
        {
            IExecute("addContentView", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#onActionModeFinished(android.view.ActionMode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.ActionMode"/></param>
        public void OnActionModeFinished(Android.View.ActionMode arg0)
        {
            IExecuteWithSignature("onActionModeFinished", "(Landroid/view/ActionMode;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#onActionModeStarted(android.view.ActionMode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.ActionMode"/></param>
        public void OnActionModeStarted(Android.View.ActionMode arg0)
        {
            IExecuteWithSignature("onActionModeStarted", "(Landroid/view/ActionMode;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#onAttachedToWindow()"/>
        /// </summary>
        public void OnAttachedToWindow()
        {
            IExecuteWithSignature("onAttachedToWindow", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#onContentChanged()"/>
        /// </summary>
        public void OnContentChanged()
        {
            IExecuteWithSignature("onContentChanged", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#onDetachedFromWindow()"/>
        /// </summary>
        public void OnDetachedFromWindow()
        {
            IExecuteWithSignature("onDetachedFromWindow", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#onDreamingStarted()"/>
        /// </summary>
        public void OnDreamingStarted()
        {
            IExecuteWithSignature("onDreamingStarted", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#onDreamingStopped()"/>
        /// </summary>
        public void OnDreamingStopped()
        {
            IExecuteWithSignature("onDreamingStopped", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#onPanelClosed(int,android.view.Menu)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.View.Menu"/></param>
        public void OnPanelClosed(int arg0, Android.View.Menu arg1)
        {
            IExecute("onPanelClosed", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#onWakeUp()"/>
        /// </summary>
        public void OnWakeUp()
        {
            IExecuteWithSignature("onWakeUp", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#onWindowAttributesChanged(android.view.WindowManager.LayoutParams)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.WindowManager.LayoutParams"/></param>
        public void OnWindowAttributesChanged(Android.View.WindowManager.LayoutParams arg0)
        {
            IExecuteWithSignature("onWindowAttributesChanged", "(Landroid/view/WindowManager$LayoutParams;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#onWindowFocusChanged(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void OnWindowFocusChanged(bool arg0)
        {
            IExecuteWithSignature("onWindowFocusChanged", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#setContentView(android.view.View,android.view.ViewGroup.LayoutParams)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.View.ViewGroup.LayoutParams"/></param>
        public void SetContentView(Android.View.View arg0, Android.View.ViewGroup.LayoutParams arg1)
        {
            IExecute("setContentView", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#setContentView(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        public void SetContentView(Android.View.View arg0)
        {
            IExecuteWithSignature("setContentView", "(Landroid/view/View;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#setContentView(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetContentView(int arg0)
        {
            IExecuteWithSignature("setContentView", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#setFullscreen(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetFullscreen(bool arg0)
        {
            IExecuteWithSignature("setFullscreen", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#setInteractive(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetInteractive(bool arg0)
        {
            IExecuteWithSignature("setInteractive", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/dreams/DreamService.html#setScreenBright(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetScreenBright(bool arg0)
        {
            IExecuteWithSignature("setScreenBright", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}