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

namespace Android.Adservices.Ondevicepersonalization
{
    #region IsolatedService
    public partial class IsolatedService
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
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/IsolatedService.html#onRequest(android.adservices.ondevicepersonalization.RequestToken)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Adservices.Ondevicepersonalization.RequestToken"/></param>
        /// <returns><see cref="Android.Adservices.Ondevicepersonalization.IsolatedWorker"/></returns>
        public Android.Adservices.Ondevicepersonalization.IsolatedWorker OnRequest(Android.Adservices.Ondevicepersonalization.RequestToken arg0)
        {
            return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.IsolatedWorker>("onRequest", "(Landroid/adservices/ondevicepersonalization/RequestToken;)Landroid/adservices/ondevicepersonalization/IsolatedWorker;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/IsolatedService.html#getEventUrlProvider(android.adservices.ondevicepersonalization.RequestToken)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Adservices.Ondevicepersonalization.RequestToken"/></param>
        /// <returns><see cref="Android.Adservices.Ondevicepersonalization.EventUrlProvider"/></returns>
        public Android.Adservices.Ondevicepersonalization.EventUrlProvider GetEventUrlProvider(Android.Adservices.Ondevicepersonalization.RequestToken arg0)
        {
            return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.EventUrlProvider>("getEventUrlProvider", "(Landroid/adservices/ondevicepersonalization/RequestToken;)Landroid/adservices/ondevicepersonalization/EventUrlProvider;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/IsolatedService.html#getFederatedComputeScheduler(android.adservices.ondevicepersonalization.RequestToken)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Adservices.Ondevicepersonalization.RequestToken"/></param>
        /// <returns><see cref="Android.Adservices.Ondevicepersonalization.FederatedComputeScheduler"/></returns>
        public Android.Adservices.Ondevicepersonalization.FederatedComputeScheduler GetFederatedComputeScheduler(Android.Adservices.Ondevicepersonalization.RequestToken arg0)
        {
            return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.FederatedComputeScheduler>("getFederatedComputeScheduler", "(Landroid/adservices/ondevicepersonalization/RequestToken;)Landroid/adservices/ondevicepersonalization/FederatedComputeScheduler;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/IsolatedService.html#getRemoteData(android.adservices.ondevicepersonalization.RequestToken)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Adservices.Ondevicepersonalization.RequestToken"/></param>
        /// <returns><see cref="Android.Adservices.Ondevicepersonalization.KeyValueStore"/></returns>
        public Android.Adservices.Ondevicepersonalization.KeyValueStore GetRemoteData(Android.Adservices.Ondevicepersonalization.RequestToken arg0)
        {
            return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.KeyValueStore>("getRemoteData", "(Landroid/adservices/ondevicepersonalization/RequestToken;)Landroid/adservices/ondevicepersonalization/KeyValueStore;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/IsolatedService.html#getLogReader(android.adservices.ondevicepersonalization.RequestToken)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Adservices.Ondevicepersonalization.RequestToken"/></param>
        /// <returns><see cref="Android.Adservices.Ondevicepersonalization.LogReader"/></returns>
        public Android.Adservices.Ondevicepersonalization.LogReader GetLogReader(Android.Adservices.Ondevicepersonalization.RequestToken arg0)
        {
            return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.LogReader>("getLogReader", "(Landroid/adservices/ondevicepersonalization/RequestToken;)Landroid/adservices/ondevicepersonalization/LogReader;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/IsolatedService.html#getModelManager(android.adservices.ondevicepersonalization.RequestToken)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Adservices.Ondevicepersonalization.RequestToken"/></param>
        /// <returns><see cref="Android.Adservices.Ondevicepersonalization.ModelManager"/></returns>
        public Android.Adservices.Ondevicepersonalization.ModelManager GetModelManager(Android.Adservices.Ondevicepersonalization.RequestToken arg0)
        {
            return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.ModelManager>("getModelManager", "(Landroid/adservices/ondevicepersonalization/RequestToken;)Landroid/adservices/ondevicepersonalization/ModelManager;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/IsolatedService.html#getLocalData(android.adservices.ondevicepersonalization.RequestToken)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Adservices.Ondevicepersonalization.RequestToken"/></param>
        /// <returns><see cref="Android.Adservices.Ondevicepersonalization.MutableKeyValueStore"/></returns>
        public Android.Adservices.Ondevicepersonalization.MutableKeyValueStore GetLocalData(Android.Adservices.Ondevicepersonalization.RequestToken arg0)
        {
            return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.MutableKeyValueStore>("getLocalData", "(Landroid/adservices/ondevicepersonalization/RequestToken;)Landroid/adservices/ondevicepersonalization/MutableKeyValueStore;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/IsolatedService.html#getUserData(android.adservices.ondevicepersonalization.RequestToken)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Adservices.Ondevicepersonalization.RequestToken"/></param>
        /// <returns><see cref="Android.Adservices.Ondevicepersonalization.UserData"/></returns>
        public Android.Adservices.Ondevicepersonalization.UserData GetUserData(Android.Adservices.Ondevicepersonalization.RequestToken arg0)
        {
            return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.UserData>("getUserData", "(Landroid/adservices/ondevicepersonalization/RequestToken;)Landroid/adservices/ondevicepersonalization/UserData;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}