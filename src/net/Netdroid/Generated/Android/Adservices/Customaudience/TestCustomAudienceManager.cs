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

namespace Android.Adservices.Customaudience
{
    #region TestCustomAudienceManager
    public partial class TestCustomAudienceManager
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
        /// <see href="https://developer.android.com/reference/android/adservices/customaudience/TestCustomAudienceManager.html#overrideCustomAudienceRemoteInfo(android.adservices.customaudience.AddCustomAudienceOverrideRequest,java.util.concurrent.Executor,android.os.OutcomeReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Adservices.Customaudience.AddCustomAudienceOverrideRequest"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Os.OutcomeReceiver"/></param>
        public void OverrideCustomAudienceRemoteInfo(Android.Adservices.Customaudience.AddCustomAudienceOverrideRequest arg0, Java.Util.Concurrent.Executor arg1, Android.Os.OutcomeReceiver<object, Java.Lang.Exception> arg2)
        {
            IExecute("overrideCustomAudienceRemoteInfo", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/customaudience/TestCustomAudienceManager.html#removeCustomAudienceRemoteInfoOverride(android.adservices.customaudience.RemoveCustomAudienceOverrideRequest,java.util.concurrent.Executor,android.os.OutcomeReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Adservices.Customaudience.RemoveCustomAudienceOverrideRequest"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Os.OutcomeReceiver"/></param>
        public void RemoveCustomAudienceRemoteInfoOverride(Android.Adservices.Customaudience.RemoveCustomAudienceOverrideRequest arg0, Java.Util.Concurrent.Executor arg1, Android.Os.OutcomeReceiver<object, Java.Lang.Exception> arg2)
        {
            IExecute("removeCustomAudienceRemoteInfoOverride", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/customaudience/TestCustomAudienceManager.html#resetAllCustomAudienceOverrides(java.util.concurrent.Executor,android.os.OutcomeReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Android.Os.OutcomeReceiver"/></param>
        public void ResetAllCustomAudienceOverrides(Java.Util.Concurrent.Executor arg0, Android.Os.OutcomeReceiver<object, Java.Lang.Exception> arg1)
        {
            IExecute("resetAllCustomAudienceOverrides", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}