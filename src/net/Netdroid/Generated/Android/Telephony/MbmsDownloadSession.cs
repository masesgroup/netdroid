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

namespace Android.Telephony
{
    #region MbmsDownloadSession
    public partial class MbmsDownloadSession
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsDownloadSession.html#RESULT_CANCELLED"/>
        /// </summary>
        public static int RESULT_CANCELLED { get { if (!_RESULT_CANCELLEDReady) { _RESULT_CANCELLEDContent = SGetField<int>(LocalBridgeClazz, "RESULT_CANCELLED"); _RESULT_CANCELLEDReady = true; } return _RESULT_CANCELLEDContent; } }
        private static int _RESULT_CANCELLEDContent = default;
        private static bool _RESULT_CANCELLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsDownloadSession.html#RESULT_DOWNLOAD_FAILURE"/>
        /// </summary>
        public static int RESULT_DOWNLOAD_FAILURE { get { if (!_RESULT_DOWNLOAD_FAILUREReady) { _RESULT_DOWNLOAD_FAILUREContent = SGetField<int>(LocalBridgeClazz, "RESULT_DOWNLOAD_FAILURE"); _RESULT_DOWNLOAD_FAILUREReady = true; } return _RESULT_DOWNLOAD_FAILUREContent; } }
        private static int _RESULT_DOWNLOAD_FAILUREContent = default;
        private static bool _RESULT_DOWNLOAD_FAILUREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsDownloadSession.html#RESULT_EXPIRED"/>
        /// </summary>
        public static int RESULT_EXPIRED { get { if (!_RESULT_EXPIREDReady) { _RESULT_EXPIREDContent = SGetField<int>(LocalBridgeClazz, "RESULT_EXPIRED"); _RESULT_EXPIREDReady = true; } return _RESULT_EXPIREDContent; } }
        private static int _RESULT_EXPIREDContent = default;
        private static bool _RESULT_EXPIREDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsDownloadSession.html#RESULT_FILE_ROOT_UNREACHABLE"/>
        /// </summary>
        public static int RESULT_FILE_ROOT_UNREACHABLE { get { if (!_RESULT_FILE_ROOT_UNREACHABLEReady) { _RESULT_FILE_ROOT_UNREACHABLEContent = SGetField<int>(LocalBridgeClazz, "RESULT_FILE_ROOT_UNREACHABLE"); _RESULT_FILE_ROOT_UNREACHABLEReady = true; } return _RESULT_FILE_ROOT_UNREACHABLEContent; } }
        private static int _RESULT_FILE_ROOT_UNREACHABLEContent = default;
        private static bool _RESULT_FILE_ROOT_UNREACHABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsDownloadSession.html#RESULT_IO_ERROR"/>
        /// </summary>
        public static int RESULT_IO_ERROR { get { if (!_RESULT_IO_ERRORReady) { _RESULT_IO_ERRORContent = SGetField<int>(LocalBridgeClazz, "RESULT_IO_ERROR"); _RESULT_IO_ERRORReady = true; } return _RESULT_IO_ERRORContent; } }
        private static int _RESULT_IO_ERRORContent = default;
        private static bool _RESULT_IO_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsDownloadSession.html#RESULT_OUT_OF_STORAGE"/>
        /// </summary>
        public static int RESULT_OUT_OF_STORAGE { get { if (!_RESULT_OUT_OF_STORAGEReady) { _RESULT_OUT_OF_STORAGEContent = SGetField<int>(LocalBridgeClazz, "RESULT_OUT_OF_STORAGE"); _RESULT_OUT_OF_STORAGEReady = true; } return _RESULT_OUT_OF_STORAGEContent; } }
        private static int _RESULT_OUT_OF_STORAGEContent = default;
        private static bool _RESULT_OUT_OF_STORAGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsDownloadSession.html#RESULT_SERVICE_ID_NOT_DEFINED"/>
        /// </summary>
        public static int RESULT_SERVICE_ID_NOT_DEFINED { get { if (!_RESULT_SERVICE_ID_NOT_DEFINEDReady) { _RESULT_SERVICE_ID_NOT_DEFINEDContent = SGetField<int>(LocalBridgeClazz, "RESULT_SERVICE_ID_NOT_DEFINED"); _RESULT_SERVICE_ID_NOT_DEFINEDReady = true; } return _RESULT_SERVICE_ID_NOT_DEFINEDContent; } }
        private static int _RESULT_SERVICE_ID_NOT_DEFINEDContent = default;
        private static bool _RESULT_SERVICE_ID_NOT_DEFINEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsDownloadSession.html#RESULT_SUCCESSFUL"/>
        /// </summary>
        public static int RESULT_SUCCESSFUL { get { if (!_RESULT_SUCCESSFULReady) { _RESULT_SUCCESSFULContent = SGetField<int>(LocalBridgeClazz, "RESULT_SUCCESSFUL"); _RESULT_SUCCESSFULReady = true; } return _RESULT_SUCCESSFULContent; } }
        private static int _RESULT_SUCCESSFULContent = default;
        private static bool _RESULT_SUCCESSFULReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsDownloadSession.html#STATUS_ACTIVELY_DOWNLOADING"/>
        /// </summary>
        public static int STATUS_ACTIVELY_DOWNLOADING { get { if (!_STATUS_ACTIVELY_DOWNLOADINGReady) { _STATUS_ACTIVELY_DOWNLOADINGContent = SGetField<int>(LocalBridgeClazz, "STATUS_ACTIVELY_DOWNLOADING"); _STATUS_ACTIVELY_DOWNLOADINGReady = true; } return _STATUS_ACTIVELY_DOWNLOADINGContent; } }
        private static int _STATUS_ACTIVELY_DOWNLOADINGContent = default;
        private static bool _STATUS_ACTIVELY_DOWNLOADINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsDownloadSession.html#STATUS_PENDING_DOWNLOAD"/>
        /// </summary>
        public static int STATUS_PENDING_DOWNLOAD { get { if (!_STATUS_PENDING_DOWNLOADReady) { _STATUS_PENDING_DOWNLOADContent = SGetField<int>(LocalBridgeClazz, "STATUS_PENDING_DOWNLOAD"); _STATUS_PENDING_DOWNLOADReady = true; } return _STATUS_PENDING_DOWNLOADContent; } }
        private static int _STATUS_PENDING_DOWNLOADContent = default;
        private static bool _STATUS_PENDING_DOWNLOADReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsDownloadSession.html#STATUS_PENDING_DOWNLOAD_WINDOW"/>
        /// </summary>
        public static int STATUS_PENDING_DOWNLOAD_WINDOW { get { if (!_STATUS_PENDING_DOWNLOAD_WINDOWReady) { _STATUS_PENDING_DOWNLOAD_WINDOWContent = SGetField<int>(LocalBridgeClazz, "STATUS_PENDING_DOWNLOAD_WINDOW"); _STATUS_PENDING_DOWNLOAD_WINDOWReady = true; } return _STATUS_PENDING_DOWNLOAD_WINDOWContent; } }
        private static int _STATUS_PENDING_DOWNLOAD_WINDOWContent = default;
        private static bool _STATUS_PENDING_DOWNLOAD_WINDOWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsDownloadSession.html#STATUS_PENDING_REPAIR"/>
        /// </summary>
        public static int STATUS_PENDING_REPAIR { get { if (!_STATUS_PENDING_REPAIRReady) { _STATUS_PENDING_REPAIRContent = SGetField<int>(LocalBridgeClazz, "STATUS_PENDING_REPAIR"); _STATUS_PENDING_REPAIRReady = true; } return _STATUS_PENDING_REPAIRContent; } }
        private static int _STATUS_PENDING_REPAIRContent = default;
        private static bool _STATUS_PENDING_REPAIRReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsDownloadSession.html#STATUS_UNKNOWN"/>
        /// </summary>
        public static int STATUS_UNKNOWN { get { if (!_STATUS_UNKNOWNReady) { _STATUS_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "STATUS_UNKNOWN"); _STATUS_UNKNOWNReady = true; } return _STATUS_UNKNOWNContent; } }
        private static int _STATUS_UNKNOWNContent = default;
        private static bool _STATUS_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsDownloadSession.html#DEFAULT_TOP_LEVEL_TEMP_DIRECTORY"/>
        /// </summary>
        public static Java.Lang.String DEFAULT_TOP_LEVEL_TEMP_DIRECTORY { get { if (!_DEFAULT_TOP_LEVEL_TEMP_DIRECTORYReady) { _DEFAULT_TOP_LEVEL_TEMP_DIRECTORYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DEFAULT_TOP_LEVEL_TEMP_DIRECTORY"); _DEFAULT_TOP_LEVEL_TEMP_DIRECTORYReady = true; } return _DEFAULT_TOP_LEVEL_TEMP_DIRECTORYContent; } }
        private static Java.Lang.String _DEFAULT_TOP_LEVEL_TEMP_DIRECTORYContent = default;
        private static bool _DEFAULT_TOP_LEVEL_TEMP_DIRECTORYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsDownloadSession.html#EXTRA_MBMS_COMPLETED_FILE_URI"/>
        /// </summary>
        public static Java.Lang.String EXTRA_MBMS_COMPLETED_FILE_URI { get { if (!_EXTRA_MBMS_COMPLETED_FILE_URIReady) { _EXTRA_MBMS_COMPLETED_FILE_URIContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_MBMS_COMPLETED_FILE_URI"); _EXTRA_MBMS_COMPLETED_FILE_URIReady = true; } return _EXTRA_MBMS_COMPLETED_FILE_URIContent; } }
        private static Java.Lang.String _EXTRA_MBMS_COMPLETED_FILE_URIContent = default;
        private static bool _EXTRA_MBMS_COMPLETED_FILE_URIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsDownloadSession.html#EXTRA_MBMS_DOWNLOAD_REQUEST"/>
        /// </summary>
        public static Java.Lang.String EXTRA_MBMS_DOWNLOAD_REQUEST { get { if (!_EXTRA_MBMS_DOWNLOAD_REQUESTReady) { _EXTRA_MBMS_DOWNLOAD_REQUESTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_MBMS_DOWNLOAD_REQUEST"); _EXTRA_MBMS_DOWNLOAD_REQUESTReady = true; } return _EXTRA_MBMS_DOWNLOAD_REQUESTContent; } }
        private static Java.Lang.String _EXTRA_MBMS_DOWNLOAD_REQUESTContent = default;
        private static bool _EXTRA_MBMS_DOWNLOAD_REQUESTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsDownloadSession.html#EXTRA_MBMS_DOWNLOAD_RESULT"/>
        /// </summary>
        public static Java.Lang.String EXTRA_MBMS_DOWNLOAD_RESULT { get { if (!_EXTRA_MBMS_DOWNLOAD_RESULTReady) { _EXTRA_MBMS_DOWNLOAD_RESULTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_MBMS_DOWNLOAD_RESULT"); _EXTRA_MBMS_DOWNLOAD_RESULTReady = true; } return _EXTRA_MBMS_DOWNLOAD_RESULTContent; } }
        private static Java.Lang.String _EXTRA_MBMS_DOWNLOAD_RESULTContent = default;
        private static bool _EXTRA_MBMS_DOWNLOAD_RESULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsDownloadSession.html#EXTRA_MBMS_FILE_INFO"/>
        /// </summary>
        public static Java.Lang.String EXTRA_MBMS_FILE_INFO { get { if (!_EXTRA_MBMS_FILE_INFOReady) { _EXTRA_MBMS_FILE_INFOContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_MBMS_FILE_INFO"); _EXTRA_MBMS_FILE_INFOReady = true; } return _EXTRA_MBMS_FILE_INFOContent; } }
        private static Java.Lang.String _EXTRA_MBMS_FILE_INFOContent = default;
        private static bool _EXTRA_MBMS_FILE_INFOReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsDownloadSession.html#create(android.content.Context,java.util.concurrent.Executor,android.telephony.mbms.MbmsDownloadSessionCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Telephony.Mbms.MbmsDownloadSessionCallback"/></param>
        /// <returns><see cref="Android.Telephony.MbmsDownloadSession"/></returns>
        public static Android.Telephony.MbmsDownloadSession Create(Android.Content.Context arg0, Java.Util.Concurrent.Executor arg1, Android.Telephony.Mbms.MbmsDownloadSessionCallback arg2)
        {
            return SExecute<Android.Telephony.MbmsDownloadSession>(LocalBridgeClazz, "create", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsDownloadSession.html#create(android.content.Context,java.util.concurrent.Executor,int,android.telephony.mbms.MbmsDownloadSessionCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.Telephony.Mbms.MbmsDownloadSessionCallback"/></param>
        /// <returns><see cref="Android.Telephony.MbmsDownloadSession"/></returns>
        public static Android.Telephony.MbmsDownloadSession Create(Android.Content.Context arg0, Java.Util.Concurrent.Executor arg1, int arg2, Android.Telephony.Mbms.MbmsDownloadSessionCallback arg3)
        {
            return SExecute<Android.Telephony.MbmsDownloadSession>(LocalBridgeClazz, "create", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsDownloadSession.html#getMaximumServiceAnnouncementSize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int GetMaximumServiceAnnouncementSize()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getMaximumServiceAnnouncementSize", "()I");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsDownloadSession.html#getTempFileRootDirectory()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.File"/></returns>
        public Java.Io.File GetTempFileRootDirectory()
        {
            return IExecuteWithSignature<Java.Io.File>("getTempFileRootDirectory", "()Ljava/io/File;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsDownloadSession.html#listPendingDownloads()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Telephony.Mbms.DownloadRequest> ListPendingDownloads()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Telephony.Mbms.DownloadRequest>>("listPendingDownloads", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsDownloadSession.html#addProgressListener(android.telephony.mbms.DownloadRequest,java.util.concurrent.Executor,android.telephony.mbms.DownloadProgressListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telephony.Mbms.DownloadRequest"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Telephony.Mbms.DownloadProgressListener"/></param>
        public void AddProgressListener(Android.Telephony.Mbms.DownloadRequest arg0, Java.Util.Concurrent.Executor arg1, Android.Telephony.Mbms.DownloadProgressListener arg2)
        {
            IExecute("addProgressListener", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsDownloadSession.html#addServiceAnnouncement(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        public void AddServiceAnnouncement(byte[] arg0)
        {
            IExecuteWithSignature("addServiceAnnouncement", "([B)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsDownloadSession.html#addStatusListener(android.telephony.mbms.DownloadRequest,java.util.concurrent.Executor,android.telephony.mbms.DownloadStatusListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telephony.Mbms.DownloadRequest"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Telephony.Mbms.DownloadStatusListener"/></param>
        public void AddStatusListener(Android.Telephony.Mbms.DownloadRequest arg0, Java.Util.Concurrent.Executor arg1, Android.Telephony.Mbms.DownloadStatusListener arg2)
        {
            IExecute("addStatusListener", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsDownloadSession.html#cancelDownload(android.telephony.mbms.DownloadRequest)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telephony.Mbms.DownloadRequest"/></param>
        public void CancelDownload(Android.Telephony.Mbms.DownloadRequest arg0)
        {
            IExecuteWithSignature("cancelDownload", "(Landroid/telephony/mbms/DownloadRequest;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsDownloadSession.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsDownloadSession.html#download(android.telephony.mbms.DownloadRequest)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telephony.Mbms.DownloadRequest"/></param>
        public void Download(Android.Telephony.Mbms.DownloadRequest arg0)
        {
            IExecuteWithSignature("download", "(Landroid/telephony/mbms/DownloadRequest;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsDownloadSession.html#removeProgressListener(android.telephony.mbms.DownloadRequest,android.telephony.mbms.DownloadProgressListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telephony.Mbms.DownloadRequest"/></param>
        /// <param name="arg1"><see cref="Android.Telephony.Mbms.DownloadProgressListener"/></param>
        public void RemoveProgressListener(Android.Telephony.Mbms.DownloadRequest arg0, Android.Telephony.Mbms.DownloadProgressListener arg1)
        {
            IExecute("removeProgressListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsDownloadSession.html#removeStatusListener(android.telephony.mbms.DownloadRequest,android.telephony.mbms.DownloadStatusListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telephony.Mbms.DownloadRequest"/></param>
        /// <param name="arg1"><see cref="Android.Telephony.Mbms.DownloadStatusListener"/></param>
        public void RemoveStatusListener(Android.Telephony.Mbms.DownloadRequest arg0, Android.Telephony.Mbms.DownloadStatusListener arg1)
        {
            IExecute("removeStatusListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsDownloadSession.html#requestDownloadState(android.telephony.mbms.DownloadRequest,android.telephony.mbms.FileInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telephony.Mbms.DownloadRequest"/></param>
        /// <param name="arg1"><see cref="Android.Telephony.Mbms.FileInfo"/></param>
        public void RequestDownloadState(Android.Telephony.Mbms.DownloadRequest arg0, Android.Telephony.Mbms.FileInfo arg1)
        {
            IExecute("requestDownloadState", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsDownloadSession.html#requestUpdateFileServices(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public void RequestUpdateFileServices(Java.Util.List<Java.Lang.String> arg0)
        {
            IExecuteWithSignature("requestUpdateFileServices", "(Ljava/util/List;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsDownloadSession.html#resetDownloadKnowledge(android.telephony.mbms.DownloadRequest)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telephony.Mbms.DownloadRequest"/></param>
        public void ResetDownloadKnowledge(Android.Telephony.Mbms.DownloadRequest arg0)
        {
            IExecuteWithSignature("resetDownloadKnowledge", "(Landroid/telephony/mbms/DownloadRequest;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsDownloadSession.html#setTempFileRootDirectory(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        public void SetTempFileRootDirectory(Java.Io.File arg0)
        {
            IExecuteWithSignature("setTempFileRootDirectory", "(Ljava/io/File;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}