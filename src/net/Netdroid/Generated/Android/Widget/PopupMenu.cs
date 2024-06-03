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

namespace Android.Widget
{
    #region PopupMenu
    public partial class PopupMenu
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/PopupMenu.html#%3Cinit%3E(android.content.Context,android.view.View,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.View.View"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public PopupMenu(Android.Content.Context arg0, Android.View.View arg1, int arg2, int arg3, int arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/PopupMenu.html#%3Cinit%3E(android.content.Context,android.view.View,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.View.View"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public PopupMenu(Android.Content.Context arg0, Android.View.View arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/PopupMenu.html#%3Cinit%3E(android.content.Context,android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.View.View"/></param>
        public PopupMenu(Android.Content.Context arg0, Android.View.View arg1)
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
        /// <see href="https://developer.android.com/reference/android/widget/PopupMenu.html#getMenu()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Menu"/></returns>
        public Android.View.Menu GetMenu()
        {
            return IExecuteWithSignature<Android.View.Menu>("getMenu", "()Landroid/view/Menu;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/PopupMenu.html#getMenuInflater()"/>
        /// </summary>
        /// <returns><see cref="Android.View.MenuInflater"/></returns>
        public Android.View.MenuInflater GetMenuInflater()
        {
            return IExecuteWithSignature<Android.View.MenuInflater>("getMenuInflater", "()Landroid/view/MenuInflater;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/PopupMenu.html#getDragToOpenListener()"/>
        /// </summary>
        /// <returns><see cref="Android.View.View.OnTouchListener"/></returns>
        public Android.View.View.OnTouchListener GetDragToOpenListener()
        {
            return IExecuteWithSignature<Android.View.View.OnTouchListener>("getDragToOpenListener", "()Landroid/view/View$OnTouchListener;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/PopupMenu.html#getDragToOpenListener()"/>
        /// </summary>
        /// <returns><see cref="Android.View.View.OnTouchListener"/></returns>
        public Android.View.View.OnTouchListener GetDragToOpenListenerDirect()
        {
            return IExecuteWithSignature<Android.View.View.OnTouchListenerDirect, Android.View.View.OnTouchListener>("getDragToOpenListener", "()Landroid/view/View$OnTouchListener;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/PopupMenu.html#getGravity()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetGravity()
        {
            return IExecuteWithSignature<int>("getGravity", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/PopupMenu.html#dismiss()"/>
        /// </summary>
        public void Dismiss()
        {
            IExecuteWithSignature("dismiss", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/PopupMenu.html#inflate(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Inflate(int arg0)
        {
            IExecuteWithSignature("inflate", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/PopupMenu.html#setForceShowIcon(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetForceShowIcon(bool arg0)
        {
            IExecuteWithSignature("setForceShowIcon", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/PopupMenu.html#setGravity(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetGravity(int arg0)
        {
            IExecuteWithSignature("setGravity", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/PopupMenu.html#setOnDismissListener(android.widget.PopupMenu.OnDismissListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.PopupMenu.OnDismissListener"/></param>
        public void SetOnDismissListener(Android.Widget.PopupMenu.OnDismissListener arg0)
        {
            IExecuteWithSignature("setOnDismissListener", "(Landroid/widget/PopupMenu$OnDismissListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/PopupMenu.html#setOnMenuItemClickListener(android.widget.PopupMenu.OnMenuItemClickListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.PopupMenu.OnMenuItemClickListener"/></param>
        public void SetOnMenuItemClickListener(Android.Widget.PopupMenu.OnMenuItemClickListener arg0)
        {
            IExecuteWithSignature("setOnMenuItemClickListener", "(Landroid/widget/PopupMenu$OnMenuItemClickListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/PopupMenu.html#show()"/>
        /// </summary>
        public void Show()
        {
            IExecuteWithSignature("show", "()V");
        }

        #endregion

        #region Nested classes
        #region OnDismissListener
        public partial class OnDismissListener
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
            /// Handlers initializer for <see cref="OnDismissListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onDismiss", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Widget.PopupMenu>>>(OnDismissEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/widget/PopupMenu.OnDismissListener.html#onDismiss(android.widget.PopupMenu)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnDismiss"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Widget.PopupMenu> OnOnDismiss { get; set; } = null;

            void OnDismissEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Widget.PopupMenu>> data)
            {
                var methodToExecute = (OnOnDismiss != null) ? OnOnDismiss : OnDismiss;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/PopupMenu.OnDismissListener.html#onDismiss(android.widget.PopupMenu)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.PopupMenu"/></param>
            public virtual void OnDismiss(Android.Widget.PopupMenu arg0)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnDismissListenerDirect
        public partial class OnDismissListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/widget/PopupMenu.OnDismissListener.html#onDismiss(android.widget.PopupMenu)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.PopupMenu"/></param>
            public override void OnDismiss(Android.Widget.PopupMenu arg0)
            {
                IExecuteWithSignature("onDismiss", "(Landroid/widget/PopupMenu;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnMenuItemClickListener
        public partial class OnMenuItemClickListener
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
            /// Handlers initializer for <see cref="OnMenuItemClickListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onMenuItemClick", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.View.MenuItem>>>(OnMenuItemClickEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/widget/PopupMenu.OnMenuItemClickListener.html#onMenuItemClick(android.view.MenuItem)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnMenuItemClick"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Func<Android.View.MenuItem, bool> OnOnMenuItemClick { get; set; } = null;

            void OnMenuItemClickEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.View.MenuItem>> data)
            {
                var methodToExecute = (OnOnMenuItemClick != null) ? OnOnMenuItemClick : OnMenuItemClick;
                var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
                data.SetReturnValue(executionResult);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/PopupMenu.OnMenuItemClickListener.html#onMenuItemClick(android.view.MenuItem)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.MenuItem"/></param>
            /// <returns><see cref="bool"/></returns>
            public virtual bool OnMenuItemClick(Android.View.MenuItem arg0)
            {
                return default;
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnMenuItemClickListenerDirect
        public partial class OnMenuItemClickListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/widget/PopupMenu.OnMenuItemClickListener.html#onMenuItemClick(android.view.MenuItem)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.MenuItem"/></param>
            /// <returns><see cref="bool"/></returns>
            public override bool OnMenuItemClick(Android.View.MenuItem arg0)
            {
                return IExecuteWithSignature<bool>("onMenuItemClick", "(Landroid/view/MenuItem;)Z", arg0);
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