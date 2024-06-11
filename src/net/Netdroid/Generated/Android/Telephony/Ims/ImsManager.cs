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

namespace Android.Telephony.Ims
{
    #region ImsManager
    public partial class ImsManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/ImsManager.html#ACTION_WFC_IMS_REGISTRATION_ERROR"/>
        /// </summary>
        public static Java.Lang.String ACTION_WFC_IMS_REGISTRATION_ERROR { get { if (!_ACTION_WFC_IMS_REGISTRATION_ERRORReady) { _ACTION_WFC_IMS_REGISTRATION_ERRORContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_WFC_IMS_REGISTRATION_ERROR"); _ACTION_WFC_IMS_REGISTRATION_ERRORReady = true; } return _ACTION_WFC_IMS_REGISTRATION_ERRORContent; } }
        private static Java.Lang.String _ACTION_WFC_IMS_REGISTRATION_ERRORContent = default;
        private static bool _ACTION_WFC_IMS_REGISTRATION_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/ImsManager.html#EXTRA_WFC_REGISTRATION_FAILURE_MESSAGE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_WFC_REGISTRATION_FAILURE_MESSAGE { get { if (!_EXTRA_WFC_REGISTRATION_FAILURE_MESSAGEReady) { _EXTRA_WFC_REGISTRATION_FAILURE_MESSAGEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_WFC_REGISTRATION_FAILURE_MESSAGE"); _EXTRA_WFC_REGISTRATION_FAILURE_MESSAGEReady = true; } return _EXTRA_WFC_REGISTRATION_FAILURE_MESSAGEContent; } }
        private static Java.Lang.String _EXTRA_WFC_REGISTRATION_FAILURE_MESSAGEContent = default;
        private static bool _EXTRA_WFC_REGISTRATION_FAILURE_MESSAGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/ImsManager.html#EXTRA_WFC_REGISTRATION_FAILURE_TITLE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_WFC_REGISTRATION_FAILURE_TITLE { get { if (!_EXTRA_WFC_REGISTRATION_FAILURE_TITLEReady) { _EXTRA_WFC_REGISTRATION_FAILURE_TITLEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_WFC_REGISTRATION_FAILURE_TITLE"); _EXTRA_WFC_REGISTRATION_FAILURE_TITLEReady = true; } return _EXTRA_WFC_REGISTRATION_FAILURE_TITLEContent; } }
        private static Java.Lang.String _EXTRA_WFC_REGISTRATION_FAILURE_TITLEContent = default;
        private static bool _EXTRA_WFC_REGISTRATION_FAILURE_TITLEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/ImsManager.html#getImsMmTelManager(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Telephony.Ims.ImsMmTelManager"/></returns>
        public Android.Telephony.Ims.ImsMmTelManager GetImsMmTelManager(int arg0)
        {
            return IExecuteWithSignature<Android.Telephony.Ims.ImsMmTelManager>("getImsMmTelManager", "(I)Landroid/telephony/ims/ImsMmTelManager;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/ImsManager.html#getImsRcsManager(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Telephony.Ims.ImsRcsManager"/></returns>
        public Android.Telephony.Ims.ImsRcsManager GetImsRcsManager(int arg0)
        {
            return IExecuteWithSignature<Android.Telephony.Ims.ImsRcsManager>("getImsRcsManager", "(I)Landroid/telephony/ims/ImsRcsManager;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/ImsManager.html#getProvisioningManager(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Telephony.Ims.ProvisioningManager"/></returns>
        public Android.Telephony.Ims.ProvisioningManager GetProvisioningManager(int arg0)
        {
            return IExecuteWithSignature<Android.Telephony.Ims.ProvisioningManager>("getProvisioningManager", "(I)Landroid/telephony/ims/ProvisioningManager;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}