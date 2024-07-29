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

namespace Android.App
{
    #region LauncherActivity
    public partial class LauncherActivity
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
        /// <see href="https://developer.android.com/reference/android/app/LauncherActivity.html#makeListItems()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        [global::System.Obsolete()]
        public Java.Util.List<Android.App.LauncherActivity.ListItem> MakeListItems()
        {
            return IExecuteWithSignature<Java.Util.List<Android.App.LauncherActivity.ListItem>>("makeListItems", "()Ljava/util/List;");
        }

        #endregion

        #region Nested classes
        #region IconResizer
        public partial class IconResizer
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/LauncherActivity.IconResizer.html#%3Cinit%3E(android.app.LauncherActivity)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.LauncherActivity"/></param>
            [global::System.Obsolete()]
            public IconResizer(Android.App.LauncherActivity arg0)
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
            /// <see href="https://developer.android.com/reference/android/app/LauncherActivity.IconResizer.html#createIconThumbnail(android.graphics.drawable.Drawable)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
            /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
            [global::System.Obsolete()]
            public Android.Graphics.Drawable.Drawable CreateIconThumbnail(Android.Graphics.Drawable.Drawable arg0)
            {
                return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("createIconThumbnail", "(Landroid/graphics/drawable/Drawable;)Landroid/graphics/drawable/Drawable;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ListItem
        public partial class ListItem
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/LauncherActivity.ListItem.html#resolveInfo"/>
            /// </summary>
            [global::System.Obsolete()]
            public Android.Content.Pm.ResolveInfo resolveInfo { get { return IGetField<Android.Content.Pm.ResolveInfo>("resolveInfo"); } set { ISetField("resolveInfo", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/LauncherActivity.ListItem.html#icon"/>
            /// </summary>
            [global::System.Obsolete()]
            public Android.Graphics.Drawable.Drawable icon { get { return IGetField<Android.Graphics.Drawable.Drawable>("icon"); } set { ISetField("icon", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/LauncherActivity.ListItem.html#extras"/>
            /// </summary>
            [global::System.Obsolete()]
            public Android.Os.Bundle extras { get { return IGetField<Android.Os.Bundle>("extras"); } set { ISetField("extras", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/LauncherActivity.ListItem.html#label"/>
            /// </summary>
            [global::System.Obsolete()]
            public Java.Lang.CharSequence label { get { return IGetField<Java.Lang.CharSequence>("label"); } set { ISetField("label", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/LauncherActivity.ListItem.html#className"/>
            /// </summary>
            [global::System.Obsolete()]
            public Java.Lang.String className { get { return IGetField<Java.Lang.String>("className"); } set { ISetField("className", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/LauncherActivity.ListItem.html#packageName"/>
            /// </summary>
            [global::System.Obsolete()]
            public Java.Lang.String packageName { get { return IGetField<Java.Lang.String>("packageName"); } set { ISetField("packageName", value); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

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