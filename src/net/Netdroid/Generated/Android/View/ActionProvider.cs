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
    #region ActionProvider
    public partial class ActionProvider
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ActionProvider.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public ActionProvider(Android.Content.Context arg0)
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
        /// <see href="https://developer.android.com/reference/android/view/ActionProvider.html#onCreateActionView()"/>
        /// </summary>
        /// <returns><see cref="Android.View.View"/></returns>
        [global::System.Obsolete()]
        public Android.View.View OnCreateActionView()
        {
            return IExecuteWithSignature<Android.View.View>("onCreateActionView", "()Landroid/view/View;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ActionProvider.html#onCreateActionView(android.view.MenuItem)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.MenuItem"/></param>
        /// <returns><see cref="Android.View.View"/></returns>
        public Android.View.View OnCreateActionView(Android.View.MenuItem arg0)
        {
            return IExecuteWithSignature<Android.View.View>("onCreateActionView", "(Landroid/view/MenuItem;)Landroid/view/View;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ActionProvider.html#hasSubMenu()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasSubMenu()
        {
            return IExecuteWithSignature<bool>("hasSubMenu", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ActionProvider.html#isVisible()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsVisible()
        {
            return IExecuteWithSignature<bool>("isVisible", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ActionProvider.html#onPerformDefaultAction()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool OnPerformDefaultAction()
        {
            return IExecuteWithSignature<bool>("onPerformDefaultAction", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ActionProvider.html#overridesItemVisibility()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool OverridesItemVisibility()
        {
            return IExecuteWithSignature<bool>("overridesItemVisibility", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ActionProvider.html#onPrepareSubMenu(android.view.SubMenu)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.SubMenu"/></param>
        public void OnPrepareSubMenu(Android.View.SubMenu arg0)
        {
            IExecuteWithSignature("onPrepareSubMenu", "(Landroid/view/SubMenu;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ActionProvider.html#refreshVisibility()"/>
        /// </summary>
        public void RefreshVisibility()
        {
            IExecuteWithSignature("refreshVisibility", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ActionProvider.html#setVisibilityListener(android.view.ActionProvider.VisibilityListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.ActionProvider.VisibilityListener"/></param>
        public void SetVisibilityListener(Android.View.ActionProvider.VisibilityListener arg0)
        {
            IExecuteWithSignature("setVisibilityListener", "(Landroid/view/ActionProvider$VisibilityListener;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region VisibilityListener
        public partial class VisibilityListener
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
            /// Handlers initializer for <see cref="VisibilityListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onActionProviderVisibilityChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<bool>>>(OnActionProviderVisibilityChangedEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/view/ActionProvider.VisibilityListener.html#onActionProviderVisibilityChanged(boolean)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnActionProviderVisibilityChanged"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<bool> OnOnActionProviderVisibilityChanged { get; set; } = null;

            void OnActionProviderVisibilityChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<bool>> data)
            {
                var methodToExecute = (OnOnActionProviderVisibilityChanged != null) ? OnOnActionProviderVisibilityChanged : OnActionProviderVisibilityChanged;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/ActionProvider.VisibilityListener.html#onActionProviderVisibilityChanged(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            public virtual void OnActionProviderVisibilityChanged(bool arg0)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region VisibilityListenerDirect
        public partial class VisibilityListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/view/ActionProvider.VisibilityListener.html#onActionProviderVisibilityChanged(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            public override void OnActionProviderVisibilityChanged(bool arg0)
            {
                IExecuteWithSignature("onActionProviderVisibilityChanged", "(Z)V", arg0);
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