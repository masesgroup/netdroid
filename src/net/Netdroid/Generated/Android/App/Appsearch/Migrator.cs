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

namespace Android.App.Appsearch
{
    #region Migrator
    public partial class Migrator
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
        /// <see href="https://developer.android.com/reference/android/app/appsearch/Migrator.html#onDowngrade(int,int,android.app.appsearch.GenericDocument)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.App.Appsearch.GenericDocument"/></param>
        /// <returns><see cref="Android.App.Appsearch.GenericDocument"/></returns>
        public Android.App.Appsearch.GenericDocument OnDowngrade(int arg0, int arg1, Android.App.Appsearch.GenericDocument arg2)
        {
            return IExecute<Android.App.Appsearch.GenericDocument>("onDowngrade", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/Migrator.html#onUpgrade(int,int,android.app.appsearch.GenericDocument)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.App.Appsearch.GenericDocument"/></param>
        /// <returns><see cref="Android.App.Appsearch.GenericDocument"/></returns>
        public Android.App.Appsearch.GenericDocument OnUpgrade(int arg0, int arg1, Android.App.Appsearch.GenericDocument arg2)
        {
            return IExecute<Android.App.Appsearch.GenericDocument>("onUpgrade", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/Migrator.html#shouldMigrate(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ShouldMigrate(int arg0, int arg1)
        {
            return IExecute<bool>("shouldMigrate", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}