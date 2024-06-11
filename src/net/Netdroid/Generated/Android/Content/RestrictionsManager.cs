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

namespace Android.Content
{
    #region RestrictionsManager
    public partial class RestrictionsManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#RESULT_APPROVED"/>
        /// </summary>
        public static int RESULT_APPROVED { get { if (!_RESULT_APPROVEDReady) { _RESULT_APPROVEDContent = SGetField<int>(LocalBridgeClazz, "RESULT_APPROVED"); _RESULT_APPROVEDReady = true; } return _RESULT_APPROVEDContent; } }
        private static int _RESULT_APPROVEDContent = default;
        private static bool _RESULT_APPROVEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#RESULT_DENIED"/>
        /// </summary>
        public static int RESULT_DENIED { get { if (!_RESULT_DENIEDReady) { _RESULT_DENIEDContent = SGetField<int>(LocalBridgeClazz, "RESULT_DENIED"); _RESULT_DENIEDReady = true; } return _RESULT_DENIEDContent; } }
        private static int _RESULT_DENIEDContent = default;
        private static bool _RESULT_DENIEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#RESULT_ERROR"/>
        /// </summary>
        public static int RESULT_ERROR { get { if (!_RESULT_ERRORReady) { _RESULT_ERRORContent = SGetField<int>(LocalBridgeClazz, "RESULT_ERROR"); _RESULT_ERRORReady = true; } return _RESULT_ERRORContent; } }
        private static int _RESULT_ERRORContent = default;
        private static bool _RESULT_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#RESULT_ERROR_BAD_REQUEST"/>
        /// </summary>
        public static int RESULT_ERROR_BAD_REQUEST { get { if (!_RESULT_ERROR_BAD_REQUESTReady) { _RESULT_ERROR_BAD_REQUESTContent = SGetField<int>(LocalBridgeClazz, "RESULT_ERROR_BAD_REQUEST"); _RESULT_ERROR_BAD_REQUESTReady = true; } return _RESULT_ERROR_BAD_REQUESTContent; } }
        private static int _RESULT_ERROR_BAD_REQUESTContent = default;
        private static bool _RESULT_ERROR_BAD_REQUESTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#RESULT_ERROR_INTERNAL"/>
        /// </summary>
        public static int RESULT_ERROR_INTERNAL { get { if (!_RESULT_ERROR_INTERNALReady) { _RESULT_ERROR_INTERNALContent = SGetField<int>(LocalBridgeClazz, "RESULT_ERROR_INTERNAL"); _RESULT_ERROR_INTERNALReady = true; } return _RESULT_ERROR_INTERNALContent; } }
        private static int _RESULT_ERROR_INTERNALContent = default;
        private static bool _RESULT_ERROR_INTERNALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#RESULT_ERROR_NETWORK"/>
        /// </summary>
        public static int RESULT_ERROR_NETWORK { get { if (!_RESULT_ERROR_NETWORKReady) { _RESULT_ERROR_NETWORKContent = SGetField<int>(LocalBridgeClazz, "RESULT_ERROR_NETWORK"); _RESULT_ERROR_NETWORKReady = true; } return _RESULT_ERROR_NETWORKContent; } }
        private static int _RESULT_ERROR_NETWORKContent = default;
        private static bool _RESULT_ERROR_NETWORKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#RESULT_NO_RESPONSE"/>
        /// </summary>
        public static int RESULT_NO_RESPONSE { get { if (!_RESULT_NO_RESPONSEReady) { _RESULT_NO_RESPONSEContent = SGetField<int>(LocalBridgeClazz, "RESULT_NO_RESPONSE"); _RESULT_NO_RESPONSEReady = true; } return _RESULT_NO_RESPONSEContent; } }
        private static int _RESULT_NO_RESPONSEContent = default;
        private static bool _RESULT_NO_RESPONSEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#RESULT_UNKNOWN_REQUEST"/>
        /// </summary>
        public static int RESULT_UNKNOWN_REQUEST { get { if (!_RESULT_UNKNOWN_REQUESTReady) { _RESULT_UNKNOWN_REQUESTContent = SGetField<int>(LocalBridgeClazz, "RESULT_UNKNOWN_REQUEST"); _RESULT_UNKNOWN_REQUESTReady = true; } return _RESULT_UNKNOWN_REQUESTContent; } }
        private static int _RESULT_UNKNOWN_REQUESTContent = default;
        private static bool _RESULT_UNKNOWN_REQUESTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#ACTION_PERMISSION_RESPONSE_RECEIVED"/>
        /// </summary>
        public static Java.Lang.String ACTION_PERMISSION_RESPONSE_RECEIVED { get { if (!_ACTION_PERMISSION_RESPONSE_RECEIVEDReady) { _ACTION_PERMISSION_RESPONSE_RECEIVEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_PERMISSION_RESPONSE_RECEIVED"); _ACTION_PERMISSION_RESPONSE_RECEIVEDReady = true; } return _ACTION_PERMISSION_RESPONSE_RECEIVEDContent; } }
        private static Java.Lang.String _ACTION_PERMISSION_RESPONSE_RECEIVEDContent = default;
        private static bool _ACTION_PERMISSION_RESPONSE_RECEIVEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#ACTION_REQUEST_LOCAL_APPROVAL"/>
        /// </summary>
        public static Java.Lang.String ACTION_REQUEST_LOCAL_APPROVAL { get { if (!_ACTION_REQUEST_LOCAL_APPROVALReady) { _ACTION_REQUEST_LOCAL_APPROVALContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_REQUEST_LOCAL_APPROVAL"); _ACTION_REQUEST_LOCAL_APPROVALReady = true; } return _ACTION_REQUEST_LOCAL_APPROVALContent; } }
        private static Java.Lang.String _ACTION_REQUEST_LOCAL_APPROVALContent = default;
        private static bool _ACTION_REQUEST_LOCAL_APPROVALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#ACTION_REQUEST_PERMISSION"/>
        /// </summary>
        public static Java.Lang.String ACTION_REQUEST_PERMISSION { get { if (!_ACTION_REQUEST_PERMISSIONReady) { _ACTION_REQUEST_PERMISSIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_REQUEST_PERMISSION"); _ACTION_REQUEST_PERMISSIONReady = true; } return _ACTION_REQUEST_PERMISSIONContent; } }
        private static Java.Lang.String _ACTION_REQUEST_PERMISSIONContent = default;
        private static bool _ACTION_REQUEST_PERMISSIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#EXTRA_PACKAGE_NAME"/>
        /// </summary>
        public static Java.Lang.String EXTRA_PACKAGE_NAME { get { if (!_EXTRA_PACKAGE_NAMEReady) { _EXTRA_PACKAGE_NAMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_PACKAGE_NAME"); _EXTRA_PACKAGE_NAMEReady = true; } return _EXTRA_PACKAGE_NAMEContent; } }
        private static Java.Lang.String _EXTRA_PACKAGE_NAMEContent = default;
        private static bool _EXTRA_PACKAGE_NAMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#EXTRA_REQUEST_BUNDLE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_REQUEST_BUNDLE { get { if (!_EXTRA_REQUEST_BUNDLEReady) { _EXTRA_REQUEST_BUNDLEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_REQUEST_BUNDLE"); _EXTRA_REQUEST_BUNDLEReady = true; } return _EXTRA_REQUEST_BUNDLEContent; } }
        private static Java.Lang.String _EXTRA_REQUEST_BUNDLEContent = default;
        private static bool _EXTRA_REQUEST_BUNDLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#EXTRA_REQUEST_ID"/>
        /// </summary>
        public static Java.Lang.String EXTRA_REQUEST_ID { get { if (!_EXTRA_REQUEST_IDReady) { _EXTRA_REQUEST_IDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_REQUEST_ID"); _EXTRA_REQUEST_IDReady = true; } return _EXTRA_REQUEST_IDContent; } }
        private static Java.Lang.String _EXTRA_REQUEST_IDContent = default;
        private static bool _EXTRA_REQUEST_IDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#EXTRA_REQUEST_TYPE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_REQUEST_TYPE { get { if (!_EXTRA_REQUEST_TYPEReady) { _EXTRA_REQUEST_TYPEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_REQUEST_TYPE"); _EXTRA_REQUEST_TYPEReady = true; } return _EXTRA_REQUEST_TYPEContent; } }
        private static Java.Lang.String _EXTRA_REQUEST_TYPEContent = default;
        private static bool _EXTRA_REQUEST_TYPEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#EXTRA_RESPONSE_BUNDLE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_RESPONSE_BUNDLE { get { if (!_EXTRA_RESPONSE_BUNDLEReady) { _EXTRA_RESPONSE_BUNDLEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_RESPONSE_BUNDLE"); _EXTRA_RESPONSE_BUNDLEReady = true; } return _EXTRA_RESPONSE_BUNDLEContent; } }
        private static Java.Lang.String _EXTRA_RESPONSE_BUNDLEContent = default;
        private static bool _EXTRA_RESPONSE_BUNDLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#META_DATA_APP_RESTRICTIONS"/>
        /// </summary>
        public static Java.Lang.String META_DATA_APP_RESTRICTIONS { get { if (!_META_DATA_APP_RESTRICTIONSReady) { _META_DATA_APP_RESTRICTIONSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "META_DATA_APP_RESTRICTIONS"); _META_DATA_APP_RESTRICTIONSReady = true; } return _META_DATA_APP_RESTRICTIONSContent; } }
        private static Java.Lang.String _META_DATA_APP_RESTRICTIONSContent = default;
        private static bool _META_DATA_APP_RESTRICTIONSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#REQUEST_KEY_APPROVE_LABEL"/>
        /// </summary>
        public static Java.Lang.String REQUEST_KEY_APPROVE_LABEL { get { if (!_REQUEST_KEY_APPROVE_LABELReady) { _REQUEST_KEY_APPROVE_LABELContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "REQUEST_KEY_APPROVE_LABEL"); _REQUEST_KEY_APPROVE_LABELReady = true; } return _REQUEST_KEY_APPROVE_LABELContent; } }
        private static Java.Lang.String _REQUEST_KEY_APPROVE_LABELContent = default;
        private static bool _REQUEST_KEY_APPROVE_LABELReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#REQUEST_KEY_DATA"/>
        /// </summary>
        public static Java.Lang.String REQUEST_KEY_DATA { get { if (!_REQUEST_KEY_DATAReady) { _REQUEST_KEY_DATAContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "REQUEST_KEY_DATA"); _REQUEST_KEY_DATAReady = true; } return _REQUEST_KEY_DATAContent; } }
        private static Java.Lang.String _REQUEST_KEY_DATAContent = default;
        private static bool _REQUEST_KEY_DATAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#REQUEST_KEY_DENY_LABEL"/>
        /// </summary>
        public static Java.Lang.String REQUEST_KEY_DENY_LABEL { get { if (!_REQUEST_KEY_DENY_LABELReady) { _REQUEST_KEY_DENY_LABELContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "REQUEST_KEY_DENY_LABEL"); _REQUEST_KEY_DENY_LABELReady = true; } return _REQUEST_KEY_DENY_LABELContent; } }
        private static Java.Lang.String _REQUEST_KEY_DENY_LABELContent = default;
        private static bool _REQUEST_KEY_DENY_LABELReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#REQUEST_KEY_ICON"/>
        /// </summary>
        public static Java.Lang.String REQUEST_KEY_ICON { get { if (!_REQUEST_KEY_ICONReady) { _REQUEST_KEY_ICONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "REQUEST_KEY_ICON"); _REQUEST_KEY_ICONReady = true; } return _REQUEST_KEY_ICONContent; } }
        private static Java.Lang.String _REQUEST_KEY_ICONContent = default;
        private static bool _REQUEST_KEY_ICONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#REQUEST_KEY_ID"/>
        /// </summary>
        public static Java.Lang.String REQUEST_KEY_ID { get { if (!_REQUEST_KEY_IDReady) { _REQUEST_KEY_IDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "REQUEST_KEY_ID"); _REQUEST_KEY_IDReady = true; } return _REQUEST_KEY_IDContent; } }
        private static Java.Lang.String _REQUEST_KEY_IDContent = default;
        private static bool _REQUEST_KEY_IDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#REQUEST_KEY_MESSAGE"/>
        /// </summary>
        public static Java.Lang.String REQUEST_KEY_MESSAGE { get { if (!_REQUEST_KEY_MESSAGEReady) { _REQUEST_KEY_MESSAGEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "REQUEST_KEY_MESSAGE"); _REQUEST_KEY_MESSAGEReady = true; } return _REQUEST_KEY_MESSAGEContent; } }
        private static Java.Lang.String _REQUEST_KEY_MESSAGEContent = default;
        private static bool _REQUEST_KEY_MESSAGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#REQUEST_KEY_NEW_REQUEST"/>
        /// </summary>
        public static Java.Lang.String REQUEST_KEY_NEW_REQUEST { get { if (!_REQUEST_KEY_NEW_REQUESTReady) { _REQUEST_KEY_NEW_REQUESTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "REQUEST_KEY_NEW_REQUEST"); _REQUEST_KEY_NEW_REQUESTReady = true; } return _REQUEST_KEY_NEW_REQUESTContent; } }
        private static Java.Lang.String _REQUEST_KEY_NEW_REQUESTContent = default;
        private static bool _REQUEST_KEY_NEW_REQUESTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#REQUEST_KEY_TITLE"/>
        /// </summary>
        public static Java.Lang.String REQUEST_KEY_TITLE { get { if (!_REQUEST_KEY_TITLEReady) { _REQUEST_KEY_TITLEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "REQUEST_KEY_TITLE"); _REQUEST_KEY_TITLEReady = true; } return _REQUEST_KEY_TITLEContent; } }
        private static Java.Lang.String _REQUEST_KEY_TITLEContent = default;
        private static bool _REQUEST_KEY_TITLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#REQUEST_TYPE_APPROVAL"/>
        /// </summary>
        public static Java.Lang.String REQUEST_TYPE_APPROVAL { get { if (!_REQUEST_TYPE_APPROVALReady) { _REQUEST_TYPE_APPROVALContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "REQUEST_TYPE_APPROVAL"); _REQUEST_TYPE_APPROVALReady = true; } return _REQUEST_TYPE_APPROVALContent; } }
        private static Java.Lang.String _REQUEST_TYPE_APPROVALContent = default;
        private static bool _REQUEST_TYPE_APPROVALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#RESPONSE_KEY_ERROR_CODE"/>
        /// </summary>
        public static Java.Lang.String RESPONSE_KEY_ERROR_CODE { get { if (!_RESPONSE_KEY_ERROR_CODEReady) { _RESPONSE_KEY_ERROR_CODEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "RESPONSE_KEY_ERROR_CODE"); _RESPONSE_KEY_ERROR_CODEReady = true; } return _RESPONSE_KEY_ERROR_CODEContent; } }
        private static Java.Lang.String _RESPONSE_KEY_ERROR_CODEContent = default;
        private static bool _RESPONSE_KEY_ERROR_CODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#RESPONSE_KEY_MESSAGE"/>
        /// </summary>
        public static Java.Lang.String RESPONSE_KEY_MESSAGE { get { if (!_RESPONSE_KEY_MESSAGEReady) { _RESPONSE_KEY_MESSAGEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "RESPONSE_KEY_MESSAGE"); _RESPONSE_KEY_MESSAGEReady = true; } return _RESPONSE_KEY_MESSAGEContent; } }
        private static Java.Lang.String _RESPONSE_KEY_MESSAGEContent = default;
        private static bool _RESPONSE_KEY_MESSAGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#RESPONSE_KEY_RESPONSE_TIMESTAMP"/>
        /// </summary>
        public static Java.Lang.String RESPONSE_KEY_RESPONSE_TIMESTAMP { get { if (!_RESPONSE_KEY_RESPONSE_TIMESTAMPReady) { _RESPONSE_KEY_RESPONSE_TIMESTAMPContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "RESPONSE_KEY_RESPONSE_TIMESTAMP"); _RESPONSE_KEY_RESPONSE_TIMESTAMPReady = true; } return _RESPONSE_KEY_RESPONSE_TIMESTAMPContent; } }
        private static Java.Lang.String _RESPONSE_KEY_RESPONSE_TIMESTAMPContent = default;
        private static bool _RESPONSE_KEY_RESPONSE_TIMESTAMPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#RESPONSE_KEY_RESULT"/>
        /// </summary>
        public static Java.Lang.String RESPONSE_KEY_RESULT { get { if (!_RESPONSE_KEY_RESULTReady) { _RESPONSE_KEY_RESULTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "RESPONSE_KEY_RESULT"); _RESPONSE_KEY_RESULTReady = true; } return _RESPONSE_KEY_RESULTContent; } }
        private static Java.Lang.String _RESPONSE_KEY_RESULTContent = default;
        private static bool _RESPONSE_KEY_RESULTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#convertRestrictionsToBundle(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public static Android.Os.Bundle ConvertRestrictionsToBundle(Java.Util.List<Android.Content.RestrictionEntry> arg0)
        {
            return SExecuteWithSignature<Android.Os.Bundle>(LocalBridgeClazz, "convertRestrictionsToBundle", "(Ljava/util/List;)Landroid/os/Bundle;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#createLocalApprovalIntent()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Intent"/></returns>
        public Android.Content.Intent CreateLocalApprovalIntent()
        {
            return IExecuteWithSignature<Android.Content.Intent>("createLocalApprovalIntent", "()Landroid/content/Intent;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#getApplicationRestrictions()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle GetApplicationRestrictions()
        {
            return IExecuteWithSignature<Android.Os.Bundle>("getApplicationRestrictions", "()Landroid/os/Bundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#hasRestrictionsProvider()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasRestrictionsProvider()
        {
            return IExecuteWithSignature<bool>("hasRestrictionsProvider", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#getManifestRestrictions(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Content.RestrictionEntry> GetManifestRestrictions(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.List<Android.Content.RestrictionEntry>>("getManifestRestrictions", "(Ljava/lang/String;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#getApplicationRestrictionsPerAdmin()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Os.Bundle> GetApplicationRestrictionsPerAdmin()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Os.Bundle>>("getApplicationRestrictionsPerAdmin", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#notifyPermissionResponse(java.lang.String,android.os.PersistableBundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Os.PersistableBundle"/></param>
        public void NotifyPermissionResponse(Java.Lang.String arg0, Android.Os.PersistableBundle arg1)
        {
            IExecute("notifyPermissionResponse", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionsManager.html#requestPermission(java.lang.String,java.lang.String,android.os.PersistableBundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Os.PersistableBundle"/></param>
        public void RequestPermission(Java.Lang.String arg0, Java.Lang.String arg1, Android.Os.PersistableBundle arg2)
        {
            IExecute("requestPermission", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}