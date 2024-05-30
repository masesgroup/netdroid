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

namespace Android.Adservices.Adselection
{
    #region TestAdSelectionManager
    public partial class TestAdSelectionManager
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
        /// <see href="https://developer.android.com/reference/android/adservices/adselection/TestAdSelectionManager.html#overrideAdSelectionConfigRemoteInfo(android.adservices.adselection.AddAdSelectionOverrideRequest,java.util.concurrent.Executor,android.os.OutcomeReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Adservices.Adselection.AddAdSelectionOverrideRequest"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Os.OutcomeReceiver"/></param>
        public void OverrideAdSelectionConfigRemoteInfo(Android.Adservices.Adselection.AddAdSelectionOverrideRequest arg0, Java.Util.Concurrent.Executor arg1, Android.Os.OutcomeReceiver<object, Java.Lang.Exception> arg2)
        {
            IExecute("overrideAdSelectionConfigRemoteInfo", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/adselection/TestAdSelectionManager.html#removeAdSelectionConfigRemoteInfoOverride(android.adservices.adselection.RemoveAdSelectionOverrideRequest,java.util.concurrent.Executor,android.os.OutcomeReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Adservices.Adselection.RemoveAdSelectionOverrideRequest"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Os.OutcomeReceiver"/></param>
        public void RemoveAdSelectionConfigRemoteInfoOverride(Android.Adservices.Adselection.RemoveAdSelectionOverrideRequest arg0, Java.Util.Concurrent.Executor arg1, Android.Os.OutcomeReceiver<object, Java.Lang.Exception> arg2)
        {
            IExecute("removeAdSelectionConfigRemoteInfoOverride", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/adselection/TestAdSelectionManager.html#resetAllAdSelectionConfigRemoteOverrides(java.util.concurrent.Executor,android.os.OutcomeReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Android.Os.OutcomeReceiver"/></param>
        public void ResetAllAdSelectionConfigRemoteOverrides(Java.Util.Concurrent.Executor arg0, Android.Os.OutcomeReceiver<object, Java.Lang.Exception> arg1)
        {
            IExecute("resetAllAdSelectionConfigRemoteOverrides", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}