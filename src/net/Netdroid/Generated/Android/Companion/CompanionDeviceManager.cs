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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Companion
{
    #region CompanionDeviceManager
    public partial class CompanionDeviceManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceManager.html#FLAG_CALL_METADATA"/>
        /// </summary>
        public static int FLAG_CALL_METADATA { get { if (!_FLAG_CALL_METADATAReady) { _FLAG_CALL_METADATAContent = SGetField<int>(LocalBridgeClazz, "FLAG_CALL_METADATA"); _FLAG_CALL_METADATAReady = true; } return _FLAG_CALL_METADATAContent; } }
        private static int _FLAG_CALL_METADATAContent = default;
        private static bool _FLAG_CALL_METADATAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceManager.html#RESULT_CANCELED"/>
        /// </summary>
        public static int RESULT_CANCELED { get { if (!_RESULT_CANCELEDReady) { _RESULT_CANCELEDContent = SGetField<int>(LocalBridgeClazz, "RESULT_CANCELED"); _RESULT_CANCELEDReady = true; } return _RESULT_CANCELEDContent; } }
        private static int _RESULT_CANCELEDContent = default;
        private static bool _RESULT_CANCELEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceManager.html#RESULT_DISCOVERY_TIMEOUT"/>
        /// </summary>
        public static int RESULT_DISCOVERY_TIMEOUT { get { if (!_RESULT_DISCOVERY_TIMEOUTReady) { _RESULT_DISCOVERY_TIMEOUTContent = SGetField<int>(LocalBridgeClazz, "RESULT_DISCOVERY_TIMEOUT"); _RESULT_DISCOVERY_TIMEOUTReady = true; } return _RESULT_DISCOVERY_TIMEOUTContent; } }
        private static int _RESULT_DISCOVERY_TIMEOUTContent = default;
        private static bool _RESULT_DISCOVERY_TIMEOUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceManager.html#RESULT_INTERNAL_ERROR"/>
        /// </summary>
        public static int RESULT_INTERNAL_ERROR { get { if (!_RESULT_INTERNAL_ERRORReady) { _RESULT_INTERNAL_ERRORContent = SGetField<int>(LocalBridgeClazz, "RESULT_INTERNAL_ERROR"); _RESULT_INTERNAL_ERRORReady = true; } return _RESULT_INTERNAL_ERRORContent; } }
        private static int _RESULT_INTERNAL_ERRORContent = default;
        private static bool _RESULT_INTERNAL_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceManager.html#RESULT_OK"/>
        /// </summary>
        public static int RESULT_OK { get { if (!_RESULT_OKReady) { _RESULT_OKContent = SGetField<int>(LocalBridgeClazz, "RESULT_OK"); _RESULT_OKReady = true; } return _RESULT_OKContent; } }
        private static int _RESULT_OKContent = default;
        private static bool _RESULT_OKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceManager.html#RESULT_USER_REJECTED"/>
        /// </summary>
        public static int RESULT_USER_REJECTED { get { if (!_RESULT_USER_REJECTEDReady) { _RESULT_USER_REJECTEDContent = SGetField<int>(LocalBridgeClazz, "RESULT_USER_REJECTED"); _RESULT_USER_REJECTEDReady = true; } return _RESULT_USER_REJECTEDContent; } }
        private static int _RESULT_USER_REJECTEDContent = default;
        private static bool _RESULT_USER_REJECTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceManager.html#EXTRA_ASSOCIATION"/>
        /// </summary>
        public static Java.Lang.String EXTRA_ASSOCIATION { get { if (!_EXTRA_ASSOCIATIONReady) { _EXTRA_ASSOCIATIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_ASSOCIATION"); _EXTRA_ASSOCIATIONReady = true; } return _EXTRA_ASSOCIATIONContent; } }
        private static Java.Lang.String _EXTRA_ASSOCIATIONContent = default;
        private static bool _EXTRA_ASSOCIATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceManager.html#EXTRA_DEVICE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String EXTRA_DEVICE { get { if (!_EXTRA_DEVICEReady) { _EXTRA_DEVICEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_DEVICE"); _EXTRA_DEVICEReady = true; } return _EXTRA_DEVICEContent; } }
        private static Java.Lang.String _EXTRA_DEVICEContent = default;
        private static bool _EXTRA_DEVICEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceManager.html#buildAssociationCancellationIntent()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.IntentSender"/></returns>
        public Android.Content.IntentSender BuildAssociationCancellationIntent()
        {
            return IExecuteWithSignature<Android.Content.IntentSender>("buildAssociationCancellationIntent", "()Landroid/content/IntentSender;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceManager.html#buildPermissionTransferUserConsentIntent(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Content.IntentSender"/></returns>
        /// <exception cref="Android.Companion.DeviceNotAssociatedException"/>
        public Android.Content.IntentSender BuildPermissionTransferUserConsentIntent(int arg0)
        {
            return IExecuteWithSignature<Android.Content.IntentSender>("buildPermissionTransferUserConsentIntent", "(I)Landroid/content/IntentSender;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceManager.html#hasNotificationAccess(android.content.ComponentName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool HasNotificationAccess(Android.Content.ComponentName arg0)
        {
            return IExecuteWithSignature<bool>("hasNotificationAccess", "(Landroid/content/ComponentName;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceManager.html#isPermissionTransferUserConsented(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsPermissionTransferUserConsented(int arg0)
        {
            return IExecuteWithSignature<bool>("isPermissionTransferUserConsented", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceManager.html#getMyAssociations()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Companion.AssociationInfo> GetMyAssociations()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Companion.AssociationInfo>>("getMyAssociations", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceManager.html#getAssociations()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        [global::System.Obsolete()]
        public Java.Util.List<Java.Lang.String> GetAssociations()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("getAssociations", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceManager.html#associate(android.companion.AssociationRequest,android.companion.CompanionDeviceManager.Callback,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Companion.AssociationRequest"/></param>
        /// <param name="arg1"><see cref="Android.Companion.CompanionDeviceManager.Callback"/></param>
        /// <param name="arg2"><see cref="Android.Os.Handler"/></param>
        public void Associate(Android.Companion.AssociationRequest arg0, Android.Companion.CompanionDeviceManager.Callback arg1, Android.Os.Handler arg2)
        {
            IExecute("associate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceManager.html#associate(android.companion.AssociationRequest,java.util.concurrent.Executor,android.companion.CompanionDeviceManager.Callback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Companion.AssociationRequest"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Companion.CompanionDeviceManager.Callback"/></param>
        public void Associate(Android.Companion.AssociationRequest arg0, Java.Util.Concurrent.Executor arg1, Android.Companion.CompanionDeviceManager.Callback arg2)
        {
            IExecute("associate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceManager.html#attachSystemDataTransport(int,java.io.InputStream,java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg2"><see cref="Java.Io.OutputStream"/></param>
        /// <exception cref="Android.Companion.DeviceNotAssociatedException"/>
        public void AttachSystemDataTransport(int arg0, Java.Io.InputStream arg1, Java.Io.OutputStream arg2)
        {
            IExecute("attachSystemDataTransport", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceManager.html#detachSystemDataTransport(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Android.Companion.DeviceNotAssociatedException"/>
        public void DetachSystemDataTransport(int arg0)
        {
            IExecuteWithSignature("detachSystemDataTransport", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceManager.html#disableSystemDataSyncForTypes(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void DisableSystemDataSyncForTypes(int arg0, int arg1)
        {
            IExecute("disableSystemDataSyncForTypes", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceManager.html#disassociate(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Disassociate(int arg0)
        {
            IExecuteWithSignature("disassociate", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceManager.html#disassociate(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public void Disassociate(Java.Lang.String arg0)
        {
            IExecuteWithSignature("disassociate", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceManager.html#enableSystemDataSyncForTypes(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void EnableSystemDataSyncForTypes(int arg0, int arg1)
        {
            IExecute("enableSystemDataSyncForTypes", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceManager.html#requestNotificationAccess(android.content.ComponentName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        public void RequestNotificationAccess(Android.Content.ComponentName arg0)
        {
            IExecuteWithSignature("requestNotificationAccess", "(Landroid/content/ComponentName;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceManager.html#startObservingDevicePresence(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Android.Companion.DeviceNotAssociatedException"/>
        public void StartObservingDevicePresence(Java.Lang.String arg0)
        {
            IExecuteWithSignature("startObservingDevicePresence", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceManager.html#startSystemDataTransfer(int,java.util.concurrent.Executor,android.os.OutcomeReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Os.OutcomeReceiver"/></param>
        /// <exception cref="Android.Companion.DeviceNotAssociatedException"/>
        public void StartSystemDataTransfer(int arg0, Java.Util.Concurrent.Executor arg1, Android.Os.OutcomeReceiver<Java.Lang.Void, Android.Companion.CompanionException> arg2)
        {
            IExecute("startSystemDataTransfer", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceManager.html#stopObservingDevicePresence(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Android.Companion.DeviceNotAssociatedException"/>
        public void StopObservingDevicePresence(Java.Lang.String arg0)
        {
            IExecuteWithSignature("stopObservingDevicePresence", "(Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region Callback
        public partial class Callback
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
            /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceManager.Callback.html#onFailure(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            public void OnFailure(Java.Lang.CharSequence arg0)
            {
                IExecuteWithSignature("onFailure", "(Ljava/lang/CharSequence;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceManager.Callback.html#onAssociationCreated(android.companion.AssociationInfo)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Companion.AssociationInfo"/></param>
            public void OnAssociationCreated(Android.Companion.AssociationInfo arg0)
            {
                IExecuteWithSignature("onAssociationCreated", "(Landroid/companion/AssociationInfo;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceManager.Callback.html#onAssociationPending(android.content.IntentSender)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.IntentSender"/></param>
            public void OnAssociationPending(Android.Content.IntentSender arg0)
            {
                IExecuteWithSignature("onAssociationPending", "(Landroid/content/IntentSender;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceManager.Callback.html#onDeviceFound(android.content.IntentSender)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.IntentSender"/></param>
            [global::System.Obsolete()]
            public void OnDeviceFound(Android.Content.IntentSender arg0)
            {
                IExecuteWithSignature("onDeviceFound", "(Landroid/content/IntentSender;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}