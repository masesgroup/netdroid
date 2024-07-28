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

namespace Android.App
{
    #region LocaleManager
    public partial class LocaleManager
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
        /// <see href="https://developer.android.com/reference/android/app/LocaleManager.html#getOverrideLocaleConfig()"/>
        /// </summary>
        /// <returns><see cref="Android.App.LocaleConfig"/></returns>
        public Android.App.LocaleConfig GetOverrideLocaleConfig()
        {
            return IExecuteWithSignature<Android.App.LocaleConfig>("getOverrideLocaleConfig", "()Landroid/app/LocaleConfig;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/LocaleManager.html#getApplicationLocales()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.LocaleList"/></returns>
        public Android.Os.LocaleList GetApplicationLocales()
        {
            return IExecuteWithSignature<Android.Os.LocaleList>("getApplicationLocales", "()Landroid/os/LocaleList;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/LocaleManager.html#getApplicationLocales(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Os.LocaleList"/></returns>
        public Android.Os.LocaleList GetApplicationLocales(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Os.LocaleList>("getApplicationLocales", "(Ljava/lang/String;)Landroid/os/LocaleList;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/LocaleManager.html#getSystemLocales()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.LocaleList"/></returns>
        public Android.Os.LocaleList GetSystemLocales()
        {
            return IExecuteWithSignature<Android.Os.LocaleList>("getSystemLocales", "()Landroid/os/LocaleList;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/LocaleManager.html#setApplicationLocales(android.os.LocaleList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.LocaleList"/></param>
        public void SetApplicationLocales(Android.Os.LocaleList arg0)
        {
            IExecuteWithSignature("setApplicationLocales", "(Landroid/os/LocaleList;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/LocaleManager.html#setOverrideLocaleConfig(android.app.LocaleConfig)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.LocaleConfig"/></param>
        public void SetOverrideLocaleConfig(Android.App.LocaleConfig arg0)
        {
            IExecuteWithSignature("setOverrideLocaleConfig", "(Landroid/app/LocaleConfig;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}