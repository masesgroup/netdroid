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

namespace Java.Util.Prefs
{
    #region IPreferencesFactory
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IPreferencesFactory
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region PreferencesFactory
    public partial class PreferencesFactory : Java.Util.Prefs.IPreferencesFactory
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
        /// <see href="https://developer.android.com/reference/java/util/prefs/PreferencesFactory.html#systemRoot()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Prefs.Preferences"/></returns>
        public Java.Util.Prefs.Preferences SystemRoot()
        {
            return IExecuteWithSignature<Java.Util.Prefs.Preferences>("systemRoot", "()Ljava/util/prefs/Preferences;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/prefs/PreferencesFactory.html#userRoot()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Prefs.Preferences"/></returns>
        public Java.Util.Prefs.Preferences UserRoot()
        {
            return IExecuteWithSignature<Java.Util.Prefs.Preferences>("userRoot", "()Ljava/util/prefs/Preferences;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}