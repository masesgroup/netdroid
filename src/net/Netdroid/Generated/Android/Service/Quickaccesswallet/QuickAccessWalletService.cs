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

namespace Android.Service.Quickaccesswallet
{
    #region QuickAccessWalletService
    public partial class QuickAccessWalletService
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quickaccesswallet/QuickAccessWalletService.html#ACTION_VIEW_WALLET"/>
        /// </summary>
        public static Java.Lang.String ACTION_VIEW_WALLET { get { if (!_ACTION_VIEW_WALLETReady) { _ACTION_VIEW_WALLETContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_VIEW_WALLET"); _ACTION_VIEW_WALLETReady = true; } return _ACTION_VIEW_WALLETContent; } }
        private static Java.Lang.String _ACTION_VIEW_WALLETContent = default;
        private static bool _ACTION_VIEW_WALLETReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quickaccesswallet/QuickAccessWalletService.html#ACTION_VIEW_WALLET_SETTINGS"/>
        /// </summary>
        public static Java.Lang.String ACTION_VIEW_WALLET_SETTINGS { get { if (!_ACTION_VIEW_WALLET_SETTINGSReady) { _ACTION_VIEW_WALLET_SETTINGSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_VIEW_WALLET_SETTINGS"); _ACTION_VIEW_WALLET_SETTINGSReady = true; } return _ACTION_VIEW_WALLET_SETTINGSContent; } }
        private static Java.Lang.String _ACTION_VIEW_WALLET_SETTINGSContent = default;
        private static bool _ACTION_VIEW_WALLET_SETTINGSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quickaccesswallet/QuickAccessWalletService.html#SERVICE_INTERFACE"/>
        /// </summary>
        public static Java.Lang.String SERVICE_INTERFACE { get { if (!_SERVICE_INTERFACEReady) { _SERVICE_INTERFACEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SERVICE_INTERFACE"); _SERVICE_INTERFACEReady = true; } return _SERVICE_INTERFACEContent; } }
        private static Java.Lang.String _SERVICE_INTERFACEContent = default;
        private static bool _SERVICE_INTERFACEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quickaccesswallet/QuickAccessWalletService.html#SERVICE_META_DATA"/>
        /// </summary>
        public static Java.Lang.String SERVICE_META_DATA { get { if (!_SERVICE_META_DATAReady) { _SERVICE_META_DATAContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SERVICE_META_DATA"); _SERVICE_META_DATAReady = true; } return _SERVICE_META_DATAContent; } }
        private static Java.Lang.String _SERVICE_META_DATAContent = default;
        private static bool _SERVICE_META_DATAReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quickaccesswallet/QuickAccessWalletService.html#onWalletCardSelected(android.service.quickaccesswallet.SelectWalletCardRequest)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Service.Quickaccesswallet.SelectWalletCardRequest"/></param>
        public void OnWalletCardSelected(Android.Service.Quickaccesswallet.SelectWalletCardRequest arg0)
        {
            IExecuteWithSignature("onWalletCardSelected", "(Landroid/service/quickaccesswallet/SelectWalletCardRequest;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quickaccesswallet/QuickAccessWalletService.html#onWalletCardsRequested(android.service.quickaccesswallet.GetWalletCardsRequest,android.service.quickaccesswallet.GetWalletCardsCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Service.Quickaccesswallet.GetWalletCardsRequest"/></param>
        /// <param name="arg1"><see cref="Android.Service.Quickaccesswallet.GetWalletCardsCallback"/></param>
        public void OnWalletCardsRequested(Android.Service.Quickaccesswallet.GetWalletCardsRequest arg0, Android.Service.Quickaccesswallet.GetWalletCardsCallback arg1)
        {
            IExecute("onWalletCardsRequested", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quickaccesswallet/QuickAccessWalletService.html#onWalletDismissed()"/>
        /// </summary>
        public void OnWalletDismissed()
        {
            IExecuteWithSignature("onWalletDismissed", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quickaccesswallet/QuickAccessWalletService.html#getTargetActivityPendingIntent()"/>
        /// </summary>
        /// <returns><see cref="Android.App.PendingIntent"/></returns>
        public Android.App.PendingIntent GetTargetActivityPendingIntent()
        {
            return IExecuteWithSignature<Android.App.PendingIntent>("getTargetActivityPendingIntent", "()Landroid/app/PendingIntent;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quickaccesswallet/QuickAccessWalletService.html#sendWalletServiceEvent(android.service.quickaccesswallet.WalletServiceEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Service.Quickaccesswallet.WalletServiceEvent"/></param>
        public void SendWalletServiceEvent(Android.Service.Quickaccesswallet.WalletServiceEvent arg0)
        {
            IExecuteWithSignature("sendWalletServiceEvent", "(Landroid/service/quickaccesswallet/WalletServiceEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}