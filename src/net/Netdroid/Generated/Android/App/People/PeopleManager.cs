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

namespace Android.App.People
{
    #region PeopleManager
    public partial class PeopleManager
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
        /// <see href="https://developer.android.com/reference/android/app/people/PeopleManager.html#getStatuses(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.App.People.ConversationStatus> GetStatuses(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.List<Android.App.People.ConversationStatus>>("getStatuses", "(Ljava/lang/String;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/people/PeopleManager.html#addOrUpdateStatus(java.lang.String,android.app.people.ConversationStatus)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.App.People.ConversationStatus"/></param>
        public void AddOrUpdateStatus(Java.Lang.String arg0, Android.App.People.ConversationStatus arg1)
        {
            IExecute("addOrUpdateStatus", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/people/PeopleManager.html#clearStatus(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void ClearStatus(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecute("clearStatus", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/people/PeopleManager.html#clearStatuses(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void ClearStatuses(Java.Lang.String arg0)
        {
            IExecuteWithSignature("clearStatuses", "(Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}