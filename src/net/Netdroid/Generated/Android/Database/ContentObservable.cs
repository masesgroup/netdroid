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

namespace Android.Database
{
    #region ContentObservable
    public partial class ContentObservable
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
        /// <see href="https://developer.android.com/reference/android/database/ContentObservable.html#dispatchChange(boolean,android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="Android.Net.Uri"/></param>
        public void DispatchChange(bool arg0, Android.Net.Uri arg1)
        {
            IExecute("dispatchChange", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/ContentObservable.html#dispatchChange(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void DispatchChange(bool arg0)
        {
            IExecuteWithSignature("dispatchChange", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/ContentObservable.html#notifyChange(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void NotifyChange(bool arg0)
        {
            IExecuteWithSignature("notifyChange", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/ContentObservable.html#registerObserver(android.database.ContentObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.ContentObserver"/></param>
        public void RegisterObserver(Android.Database.ContentObserver arg0)
        {
            IExecuteWithSignature("registerObserver", "(Landroid/database/ContentObserver;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}