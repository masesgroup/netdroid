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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.App.Admin
{
    #region DelegatedAdminReceiver
    public partial class DelegatedAdminReceiver
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
        /// <see href="https://developer.android.com/reference/android/app/admin/DelegatedAdminReceiver.html#onChoosePrivateKeyAlias(android.content.Context,android.content.Intent,int,android.net.Uri,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Content.Intent"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg4"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String OnChoosePrivateKeyAlias(Android.Content.Context arg0, Android.Content.Intent arg1, int arg2, Android.Net.Uri arg3, Java.Lang.String arg4)
        {
            return IExecute<Java.Lang.String>("onChoosePrivateKeyAlias", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DelegatedAdminReceiver.html#onNetworkLogsAvailable(android.content.Context,android.content.Intent,long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Content.Intent"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void OnNetworkLogsAvailable(Android.Content.Context arg0, Android.Content.Intent arg1, long arg2, int arg3)
        {
            IExecute("onNetworkLogsAvailable", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DelegatedAdminReceiver.html#onSecurityLogsAvailable(android.content.Context,android.content.Intent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Content.Intent"/></param>
        public void OnSecurityLogsAvailable(Android.Content.Context arg0, Android.Content.Intent arg1)
        {
            IExecute("onSecurityLogsAvailable", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}