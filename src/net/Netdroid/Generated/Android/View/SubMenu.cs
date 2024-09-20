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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.View
{
    #region ISubMenu
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISubMenu : Android.View.IMenu
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SubMenu
    public partial class SubMenu : Android.View.ISubMenu
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
        /// <see href="https://developer.android.com/reference/android/view/SubMenu.html#getItem()"/>
        /// </summary>
        /// <returns><see cref="Android.View.MenuItem"/></returns>
        public Android.View.MenuItem GetItem()
        {
            return IExecuteWithSignature<Android.View.MenuItem>("getItem", "()Landroid/view/MenuItem;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/SubMenu.html#setHeaderIcon(android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        /// <returns><see cref="Android.View.SubMenu"/></returns>
        public Android.View.SubMenu SetHeaderIcon(Android.Graphics.Drawable.Drawable arg0)
        {
            return IExecuteWithSignature<Android.View.SubMenu>("setHeaderIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/SubMenu;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/SubMenu.html#setHeaderIcon(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.View.SubMenu"/></returns>
        public Android.View.SubMenu SetHeaderIcon(int arg0)
        {
            return IExecuteWithSignature<Android.View.SubMenu>("setHeaderIcon", "(I)Landroid/view/SubMenu;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/SubMenu.html#setHeaderTitle(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.View.SubMenu"/></returns>
        public Android.View.SubMenu SetHeaderTitle(int arg0)
        {
            return IExecuteWithSignature<Android.View.SubMenu>("setHeaderTitle", "(I)Landroid/view/SubMenu;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/SubMenu.html#setHeaderTitle(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Android.View.SubMenu"/></returns>
        public Android.View.SubMenu SetHeaderTitle(Java.Lang.CharSequence arg0)
        {
            return IExecuteWithSignature<Android.View.SubMenu>("setHeaderTitle", "(Ljava/lang/CharSequence;)Landroid/view/SubMenu;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/SubMenu.html#setHeaderView(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <returns><see cref="Android.View.SubMenu"/></returns>
        public Android.View.SubMenu SetHeaderView(Android.View.View arg0)
        {
            return IExecuteWithSignature<Android.View.SubMenu>("setHeaderView", "(Landroid/view/View;)Landroid/view/SubMenu;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/SubMenu.html#setIcon(android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        /// <returns><see cref="Android.View.SubMenu"/></returns>
        public Android.View.SubMenu SetIcon(Android.Graphics.Drawable.Drawable arg0)
        {
            return IExecuteWithSignature<Android.View.SubMenu>("setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/SubMenu;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/SubMenu.html#setIcon(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.View.SubMenu"/></returns>
        public Android.View.SubMenu SetIcon(int arg0)
        {
            return IExecuteWithSignature<Android.View.SubMenu>("setIcon", "(I)Landroid/view/SubMenu;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/SubMenu.html#clearHeader()"/>
        /// </summary>
        public void ClearHeader()
        {
            IExecuteWithSignature("clearHeader", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}