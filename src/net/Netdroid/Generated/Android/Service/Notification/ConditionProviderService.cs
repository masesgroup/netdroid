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

namespace Android.Service.Notification
{
    #region ConditionProviderService
    public partial class ConditionProviderService
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ConditionProviderService.html#EXTRA_RULE_ID"/>
        /// </summary>
        [System.Obsolete()]
        public static Java.Lang.String EXTRA_RULE_ID { get { if (!_EXTRA_RULE_IDReady) { _EXTRA_RULE_IDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_RULE_ID"); _EXTRA_RULE_IDReady = true; } return _EXTRA_RULE_IDContent; } }
        private static Java.Lang.String _EXTRA_RULE_IDContent = default;
        private static bool _EXTRA_RULE_IDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ConditionProviderService.html#META_DATA_CONFIGURATION_ACTIVITY"/>
        /// </summary>
        [System.Obsolete()]
        public static Java.Lang.String META_DATA_CONFIGURATION_ACTIVITY { get { if (!_META_DATA_CONFIGURATION_ACTIVITYReady) { _META_DATA_CONFIGURATION_ACTIVITYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "META_DATA_CONFIGURATION_ACTIVITY"); _META_DATA_CONFIGURATION_ACTIVITYReady = true; } return _META_DATA_CONFIGURATION_ACTIVITYContent; } }
        private static Java.Lang.String _META_DATA_CONFIGURATION_ACTIVITYContent = default;
        private static bool _META_DATA_CONFIGURATION_ACTIVITYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ConditionProviderService.html#META_DATA_RULE_INSTANCE_LIMIT"/>
        /// </summary>
        [System.Obsolete()]
        public static Java.Lang.String META_DATA_RULE_INSTANCE_LIMIT { get { if (!_META_DATA_RULE_INSTANCE_LIMITReady) { _META_DATA_RULE_INSTANCE_LIMITContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "META_DATA_RULE_INSTANCE_LIMIT"); _META_DATA_RULE_INSTANCE_LIMITReady = true; } return _META_DATA_RULE_INSTANCE_LIMITContent; } }
        private static Java.Lang.String _META_DATA_RULE_INSTANCE_LIMITContent = default;
        private static bool _META_DATA_RULE_INSTANCE_LIMITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ConditionProviderService.html#META_DATA_RULE_TYPE"/>
        /// </summary>
        [System.Obsolete()]
        public static Java.Lang.String META_DATA_RULE_TYPE { get { if (!_META_DATA_RULE_TYPEReady) { _META_DATA_RULE_TYPEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "META_DATA_RULE_TYPE"); _META_DATA_RULE_TYPEReady = true; } return _META_DATA_RULE_TYPEContent; } }
        private static Java.Lang.String _META_DATA_RULE_TYPEContent = default;
        private static bool _META_DATA_RULE_TYPEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ConditionProviderService.html#SERVICE_INTERFACE"/>
        /// </summary>
        [System.Obsolete()]
        public static Java.Lang.String SERVICE_INTERFACE { get { if (!_SERVICE_INTERFACEReady) { _SERVICE_INTERFACEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SERVICE_INTERFACE"); _SERVICE_INTERFACEReady = true; } return _SERVICE_INTERFACEContent; } }
        private static Java.Lang.String _SERVICE_INTERFACEContent = default;
        private static bool _SERVICE_INTERFACEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ConditionProviderService.html#requestRebind(android.content.ComponentName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        [System.Obsolete()]
        public static void RequestRebind(Android.Content.ComponentName arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "requestRebind", "(Landroid/content/ComponentName;)V", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ConditionProviderService.html#onConnected()"/>
        /// </summary>
        [System.Obsolete()]
        public void OnConnected()
        {
            IExecuteWithSignature("onConnected", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ConditionProviderService.html#onSubscribe(android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        [System.Obsolete()]
        public void OnSubscribe(Android.Net.Uri arg0)
        {
            IExecuteWithSignature("onSubscribe", "(Landroid/net/Uri;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ConditionProviderService.html#onUnsubscribe(android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        [System.Obsolete()]
        public void OnUnsubscribe(Android.Net.Uri arg0)
        {
            IExecuteWithSignature("onUnsubscribe", "(Landroid/net/Uri;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ConditionProviderService.html#notifyCondition(android.service.notification.Condition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Service.Notification.Condition"/></param>
        [System.Obsolete()]
        public void NotifyCondition(Android.Service.Notification.Condition arg0)
        {
            IExecuteWithSignature("notifyCondition", "(Landroid/service/notification/Condition;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ConditionProviderService.html#notifyConditions(android.service.notification.Condition[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Service.Notification.Condition"/></param>
        [System.Obsolete()]
        public void NotifyConditions(params Android.Service.Notification.Condition[] arg0)
        {
            if (arg0.Length == 0) IExecuteWithSignature("notifyConditions", "([Landroid/service/notification/Condition;)V"); else IExecuteWithSignature("notifyConditions", "([Landroid/service/notification/Condition;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ConditionProviderService.html#requestUnbind()"/>
        /// </summary>
        [System.Obsolete()]
        public void RequestUnbind()
        {
            IExecuteWithSignature("requestUnbind", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/ConditionProviderService.html#onRequestConditions(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [System.Obsolete()]
        public void OnRequestConditions(int arg0)
        {
            IExecuteWithSignature("onRequestConditions", "(I)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}