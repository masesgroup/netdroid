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

namespace Android.Webkit
{
    #region ServiceWorkerWebSettings
    public partial class ServiceWorkerWebSettings
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
        /// <see href="https://developer.android.com/reference/android/webkit/ServiceWorkerWebSettings.html#getAllowContentAccess()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetAllowContentAccess()
        {
            return IExecuteWithSignature<bool>("getAllowContentAccess", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/ServiceWorkerWebSettings.html#getAllowFileAccess()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetAllowFileAccess()
        {
            return IExecuteWithSignature<bool>("getAllowFileAccess", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/ServiceWorkerWebSettings.html#getBlockNetworkLoads()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetBlockNetworkLoads()
        {
            return IExecuteWithSignature<bool>("getBlockNetworkLoads", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/ServiceWorkerWebSettings.html#getCacheMode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCacheMode()
        {
            return IExecuteWithSignature<int>("getCacheMode", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/ServiceWorkerWebSettings.html#setAllowContentAccess(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetAllowContentAccess(bool arg0)
        {
            IExecuteWithSignature("setAllowContentAccess", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/ServiceWorkerWebSettings.html#setAllowFileAccess(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetAllowFileAccess(bool arg0)
        {
            IExecuteWithSignature("setAllowFileAccess", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/ServiceWorkerWebSettings.html#setBlockNetworkLoads(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetBlockNetworkLoads(bool arg0)
        {
            IExecuteWithSignature("setBlockNetworkLoads", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/ServiceWorkerWebSettings.html#setCacheMode(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetCacheMode(int arg0)
        {
            IExecuteWithSignature("setCacheMode", "(I)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}