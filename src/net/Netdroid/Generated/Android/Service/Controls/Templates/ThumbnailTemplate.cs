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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Service.Controls.Templates
{
    #region ThumbnailTemplate
    public partial class ThumbnailTemplate
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/templates/ThumbnailTemplate.html#%3Cinit%3E(java.lang.String,boolean,android.graphics.drawable.Icon,java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.Drawable.Icon"/></param>
        /// <param name="arg3"><see cref="Java.Lang.CharSequence"/></param>
        public ThumbnailTemplate(Java.Lang.String arg0, bool arg1, Android.Graphics.Drawable.Icon arg2, Java.Lang.CharSequence arg3)
            : base(arg0, arg1, arg2, arg3)
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
        /// <see href="https://developer.android.com/reference/android/service/controls/templates/ThumbnailTemplate.html#getThumbnail()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Drawable.Icon"/></returns>
        public Android.Graphics.Drawable.Icon GetThumbnail()
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Icon>("getThumbnail", "()Landroid/graphics/drawable/Icon;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/templates/ThumbnailTemplate.html#isActive()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsActive()
        {
            return IExecuteWithSignature<bool>("isActive", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/templates/ThumbnailTemplate.html#getContentDescription()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetContentDescription()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getContentDescription", "()Ljava/lang/CharSequence;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}