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
    #region TabActivity
    public partial class TabActivity
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
        /// <see href="https://developer.android.com/reference/android/app/TabActivity.html#getTabHost()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.TabHost"/></returns>
        [global::System.Obsolete()]
        public Android.Widget.TabHost GetTabHost()
        {
            return IExecuteWithSignature<Android.Widget.TabHost>("getTabHost", "()Landroid/widget/TabHost;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/TabActivity.html#getTabWidget()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.TabWidget"/></returns>
        [global::System.Obsolete()]
        public Android.Widget.TabWidget GetTabWidget()
        {
            return IExecuteWithSignature<Android.Widget.TabWidget>("getTabWidget", "()Landroid/widget/TabWidget;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/TabActivity.html#setDefaultTab(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetDefaultTab(int arg0)
        {
            IExecuteWithSignature("setDefaultTab", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/TabActivity.html#setDefaultTab(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public void SetDefaultTab(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setDefaultTab", "(Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}