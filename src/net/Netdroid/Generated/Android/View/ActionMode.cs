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

namespace Android.View
{
    #region ActionMode
    public partial class ActionMode
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ActionMode.html#DEFAULT_HIDE_DURATION"/>
        /// </summary>
        public static int DEFAULT_HIDE_DURATION { get { if (!_DEFAULT_HIDE_DURATIONReady) { _DEFAULT_HIDE_DURATIONContent = SGetField<int>(LocalBridgeClazz, "DEFAULT_HIDE_DURATION"); _DEFAULT_HIDE_DURATIONReady = true; } return _DEFAULT_HIDE_DURATIONContent; } }
        private static int _DEFAULT_HIDE_DURATIONContent = default;
        private static bool _DEFAULT_HIDE_DURATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ActionMode.html#TYPE_FLOATING"/>
        /// </summary>
        public static int TYPE_FLOATING { get { if (!_TYPE_FLOATINGReady) { _TYPE_FLOATINGContent = SGetField<int>(LocalBridgeClazz, "TYPE_FLOATING"); _TYPE_FLOATINGReady = true; } return _TYPE_FLOATINGContent; } }
        private static int _TYPE_FLOATINGContent = default;
        private static bool _TYPE_FLOATINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ActionMode.html#TYPE_PRIMARY"/>
        /// </summary>
        public static int TYPE_PRIMARY { get { if (!_TYPE_PRIMARYReady) { _TYPE_PRIMARYContent = SGetField<int>(LocalBridgeClazz, "TYPE_PRIMARY"); _TYPE_PRIMARYReady = true; } return _TYPE_PRIMARYContent; } }
        private static int _TYPE_PRIMARYContent = default;
        private static bool _TYPE_PRIMARYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ActionMode.html#getMenu()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Menu"/></returns>
        public Android.View.Menu GetMenu()
        {
            return IExecuteWithSignature<Android.View.Menu>("getMenu", "()Landroid/view/Menu;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ActionMode.html#getMenuInflater()"/>
        /// </summary>
        /// <returns><see cref="Android.View.MenuInflater"/></returns>
        public Android.View.MenuInflater GetMenuInflater()
        {
            return IExecuteWithSignature<Android.View.MenuInflater>("getMenuInflater", "()Landroid/view/MenuInflater;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ActionMode.html#getCustomView()"/>
        /// </summary>
        /// <returns><see cref="Android.View.View"/></returns>
        public Android.View.View GetCustomView()
        {
            return IExecuteWithSignature<Android.View.View>("getCustomView", "()Landroid/view/View;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ActionMode.html#getSubtitle()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetSubtitle()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getSubtitle", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ActionMode.html#getTitle()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetTitle()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getTitle", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ActionMode.html#finish()"/>
        /// </summary>
        public void Finish()
        {
            IExecuteWithSignature("finish", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ActionMode.html#invalidate()"/>
        /// </summary>
        public void Invalidate()
        {
            IExecuteWithSignature("invalidate", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ActionMode.html#setCustomView(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        public void SetCustomView(Android.View.View arg0)
        {
            IExecuteWithSignature("setCustomView", "(Landroid/view/View;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ActionMode.html#setSubtitle(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetSubtitle(int arg0)
        {
            IExecuteWithSignature("setSubtitle", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ActionMode.html#setSubtitle(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        public void SetSubtitle(Java.Lang.CharSequence arg0)
        {
            IExecuteWithSignature("setSubtitle", "(Ljava/lang/CharSequence;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ActionMode.html#setTitle(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetTitle(int arg0)
        {
            IExecuteWithSignature("setTitle", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ActionMode.html#setTitle(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        public void SetTitle(Java.Lang.CharSequence arg0)
        {
            IExecuteWithSignature("setTitle", "(Ljava/lang/CharSequence;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ActionMode.html#getTitleOptionalHint()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetTitleOptionalHint()
        {
            return IExecuteWithSignature<bool>("getTitleOptionalHint", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ActionMode.html#isTitleOptional()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsTitleOptional()
        {
            return IExecuteWithSignature<bool>("isTitleOptional", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ActionMode.html#getType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetType()
        {
            return IExecuteWithSignature<int>("getType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ActionMode.html#getTag()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object GetTag()
        {
            return IExecuteWithSignature("getTag", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ActionMode.html#hide(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void Hide(long arg0)
        {
            IExecuteWithSignature("hide", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ActionMode.html#invalidateContentRect()"/>
        /// </summary>
        public void InvalidateContentRect()
        {
            IExecuteWithSignature("invalidateContentRect", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ActionMode.html#onWindowFocusChanged(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void OnWindowFocusChanged(bool arg0)
        {
            IExecuteWithSignature("onWindowFocusChanged", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ActionMode.html#setTag(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void SetTag(object arg0)
        {
            IExecuteWithSignature("setTag", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ActionMode.html#setTitleOptionalHint(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetTitleOptionalHint(bool arg0)
        {
            IExecuteWithSignature("setTitleOptionalHint", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ActionMode.html#setType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetType(int arg0)
        {
            IExecuteWithSignature("setType", "(I)V", arg0);
        }

        #endregion

        #region Nested classes
        #region Callback
        public partial class Callback
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
            /// <see href="https://developer.android.com/reference/android/view/ActionMode.Callback.html#onActionItemClicked(android.view.ActionMode,android.view.MenuItem)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.ActionMode"/></param>
            /// <param name="arg1"><see cref="Android.View.MenuItem"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool OnActionItemClicked(Android.View.ActionMode arg0, Android.View.MenuItem arg1)
            {
                return IExecute<bool>("onActionItemClicked", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/ActionMode.Callback.html#onCreateActionMode(android.view.ActionMode,android.view.Menu)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.ActionMode"/></param>
            /// <param name="arg1"><see cref="Android.View.Menu"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool OnCreateActionMode(Android.View.ActionMode arg0, Android.View.Menu arg1)
            {
                return IExecute<bool>("onCreateActionMode", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/ActionMode.Callback.html#onPrepareActionMode(android.view.ActionMode,android.view.Menu)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.ActionMode"/></param>
            /// <param name="arg1"><see cref="Android.View.Menu"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool OnPrepareActionMode(Android.View.ActionMode arg0, Android.View.Menu arg1)
            {
                return IExecute<bool>("onPrepareActionMode", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/ActionMode.Callback.html#onDestroyActionMode(android.view.ActionMode)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.ActionMode"/></param>
            public void OnDestroyActionMode(Android.View.ActionMode arg0)
            {
                IExecuteWithSignature("onDestroyActionMode", "(Landroid/view/ActionMode;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Callback2
        public partial class Callback2
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
            /// <see href="https://developer.android.com/reference/android/view/ActionMode.Callback2.html#onGetContentRect(android.view.ActionMode,android.view.View,android.graphics.Rect)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.ActionMode"/></param>
            /// <param name="arg1"><see cref="Android.View.View"/></param>
            /// <param name="arg2"><see cref="Android.Graphics.Rect"/></param>
            public void OnGetContentRect(Android.View.ActionMode arg0, Android.View.View arg1, Android.Graphics.Rect arg2)
            {
                IExecute("onGetContentRect", arg0, arg1, arg2);
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