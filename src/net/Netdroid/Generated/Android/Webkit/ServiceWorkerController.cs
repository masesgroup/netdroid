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

namespace Android.Webkit
{
    #region ServiceWorkerController
    public partial class ServiceWorkerController
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/ServiceWorkerController.html#getInstance()"/>
        /// </summary>
        /// <returns><see cref="Android.Webkit.ServiceWorkerController"/></returns>
        public static Android.Webkit.ServiceWorkerController GetInstance()
        {
            return SExecuteWithSignature<Android.Webkit.ServiceWorkerController>(LocalBridgeClazz, "getInstance", "()Landroid/webkit/ServiceWorkerController;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/ServiceWorkerController.html#getServiceWorkerWebSettings()"/>
        /// </summary>
        /// <returns><see cref="Android.Webkit.ServiceWorkerWebSettings"/></returns>
        public Android.Webkit.ServiceWorkerWebSettings GetServiceWorkerWebSettings()
        {
            return IExecuteWithSignature<Android.Webkit.ServiceWorkerWebSettings>("getServiceWorkerWebSettings", "()Landroid/webkit/ServiceWorkerWebSettings;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/ServiceWorkerController.html#setServiceWorkerClient(android.webkit.ServiceWorkerClient)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.ServiceWorkerClient"/></param>
        public void SetServiceWorkerClient(Android.Webkit.ServiceWorkerClient arg0)
        {
            IExecuteWithSignature("setServiceWorkerClient", "(Landroid/webkit/ServiceWorkerClient;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}