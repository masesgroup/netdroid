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

namespace Android.View
{
    #region ContextThemeWrapper
    public partial class ContextThemeWrapper
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ContextThemeWrapper.html#%3Cinit%3E(android.content.Context,android.content.res.Resources.Theme)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Content.Res.Resources.Theme"/></param>
        public ContextThemeWrapper(Android.Content.Context arg0, Android.Content.Res.Resources.Theme arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ContextThemeWrapper.html#%3Cinit%3E(android.content.Context,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public ContextThemeWrapper(Android.Content.Context arg0, int arg1)
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
        /// <see href="https://developer.android.com/reference/android/view/ContextThemeWrapper.html#applyOverrideConfiguration(android.content.res.Configuration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Res.Configuration"/></param>
        public void ApplyOverrideConfiguration(Android.Content.Res.Configuration arg0)
        {
            IExecuteWithSignature("applyOverrideConfiguration", "(Landroid/content/res/Configuration;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ContextThemeWrapper.html#setTheme(android.content.res.Resources.Theme)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Res.Resources.Theme"/></param>
        public void SetTheme(Android.Content.Res.Resources.Theme arg0)
        {
            IExecuteWithSignature("setTheme", "(Landroid/content/res/Resources$Theme;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}