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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Content.Pm
{
    #region ArchivedActivityInfo
    public partial class ArchivedActivityInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ArchivedActivityInfo.html#%3Cinit%3E(java.lang.CharSequence,android.content.ComponentName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Android.Content.ComponentName"/></param>
        public ArchivedActivityInfo(Java.Lang.CharSequence arg0, Android.Content.ComponentName arg1)
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
        /// <see href="https://developer.android.com/reference/android/content/pm/ArchivedActivityInfo.html#getComponentName()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.ComponentName"/></returns>
        public Android.Content.ComponentName GetComponentName()
        {
            return IExecuteWithSignature<Android.Content.ComponentName>("getComponentName", "()Landroid/content/ComponentName;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ArchivedActivityInfo.html#setComponentName(android.content.ComponentName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        /// <returns><see cref="Android.Content.Pm.ArchivedActivityInfo"/></returns>
        public Android.Content.Pm.ArchivedActivityInfo SetComponentName(Android.Content.ComponentName arg0)
        {
            return IExecuteWithSignature<Android.Content.Pm.ArchivedActivityInfo>("setComponentName", "(Landroid/content/ComponentName;)Landroid/content/pm/ArchivedActivityInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ArchivedActivityInfo.html#setIcon(android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        /// <returns><see cref="Android.Content.Pm.ArchivedActivityInfo"/></returns>
        public Android.Content.Pm.ArchivedActivityInfo SetIcon(Android.Graphics.Drawable.Drawable arg0)
        {
            return IExecuteWithSignature<Android.Content.Pm.ArchivedActivityInfo>("setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/content/pm/ArchivedActivityInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ArchivedActivityInfo.html#setLabel(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Android.Content.Pm.ArchivedActivityInfo"/></returns>
        public Android.Content.Pm.ArchivedActivityInfo SetLabel(Java.Lang.CharSequence arg0)
        {
            return IExecuteWithSignature<Android.Content.Pm.ArchivedActivityInfo>("setLabel", "(Ljava/lang/CharSequence;)Landroid/content/pm/ArchivedActivityInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ArchivedActivityInfo.html#setMonochromeIcon(android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        /// <returns><see cref="Android.Content.Pm.ArchivedActivityInfo"/></returns>
        public Android.Content.Pm.ArchivedActivityInfo SetMonochromeIcon(Android.Graphics.Drawable.Drawable arg0)
        {
            return IExecuteWithSignature<Android.Content.Pm.ArchivedActivityInfo>("setMonochromeIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/content/pm/ArchivedActivityInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ArchivedActivityInfo.html#getIcon()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable GetIcon()
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getIcon", "()Landroid/graphics/drawable/Drawable;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ArchivedActivityInfo.html#getMonochromeIcon()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable GetMonochromeIcon()
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getMonochromeIcon", "()Landroid/graphics/drawable/Drawable;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ArchivedActivityInfo.html#getLabel()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetLabel()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getLabel", "()Ljava/lang/CharSequence;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}