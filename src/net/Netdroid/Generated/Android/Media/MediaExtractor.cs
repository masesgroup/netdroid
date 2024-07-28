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

namespace Android.Media
{
    #region MediaExtractor
    public partial class MediaExtractor
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.html#SAMPLE_FLAG_ENCRYPTED"/>
        /// </summary>
        public static int SAMPLE_FLAG_ENCRYPTED { get { if (!_SAMPLE_FLAG_ENCRYPTEDReady) { _SAMPLE_FLAG_ENCRYPTEDContent = SGetField<int>(LocalBridgeClazz, "SAMPLE_FLAG_ENCRYPTED"); _SAMPLE_FLAG_ENCRYPTEDReady = true; } return _SAMPLE_FLAG_ENCRYPTEDContent; } }
        private static int _SAMPLE_FLAG_ENCRYPTEDContent = default;
        private static bool _SAMPLE_FLAG_ENCRYPTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.html#SAMPLE_FLAG_PARTIAL_FRAME"/>
        /// </summary>
        public static int SAMPLE_FLAG_PARTIAL_FRAME { get { if (!_SAMPLE_FLAG_PARTIAL_FRAMEReady) { _SAMPLE_FLAG_PARTIAL_FRAMEContent = SGetField<int>(LocalBridgeClazz, "SAMPLE_FLAG_PARTIAL_FRAME"); _SAMPLE_FLAG_PARTIAL_FRAMEReady = true; } return _SAMPLE_FLAG_PARTIAL_FRAMEContent; } }
        private static int _SAMPLE_FLAG_PARTIAL_FRAMEContent = default;
        private static bool _SAMPLE_FLAG_PARTIAL_FRAMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.html#SAMPLE_FLAG_SYNC"/>
        /// </summary>
        public static int SAMPLE_FLAG_SYNC { get { if (!_SAMPLE_FLAG_SYNCReady) { _SAMPLE_FLAG_SYNCContent = SGetField<int>(LocalBridgeClazz, "SAMPLE_FLAG_SYNC"); _SAMPLE_FLAG_SYNCReady = true; } return _SAMPLE_FLAG_SYNCContent; } }
        private static int _SAMPLE_FLAG_SYNCContent = default;
        private static bool _SAMPLE_FLAG_SYNCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.html#SEEK_TO_CLOSEST_SYNC"/>
        /// </summary>
        public static int SEEK_TO_CLOSEST_SYNC { get { if (!_SEEK_TO_CLOSEST_SYNCReady) { _SEEK_TO_CLOSEST_SYNCContent = SGetField<int>(LocalBridgeClazz, "SEEK_TO_CLOSEST_SYNC"); _SEEK_TO_CLOSEST_SYNCReady = true; } return _SEEK_TO_CLOSEST_SYNCContent; } }
        private static int _SEEK_TO_CLOSEST_SYNCContent = default;
        private static bool _SEEK_TO_CLOSEST_SYNCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.html#SEEK_TO_NEXT_SYNC"/>
        /// </summary>
        public static int SEEK_TO_NEXT_SYNC { get { if (!_SEEK_TO_NEXT_SYNCReady) { _SEEK_TO_NEXT_SYNCContent = SGetField<int>(LocalBridgeClazz, "SEEK_TO_NEXT_SYNC"); _SEEK_TO_NEXT_SYNCReady = true; } return _SEEK_TO_NEXT_SYNCContent; } }
        private static int _SEEK_TO_NEXT_SYNCContent = default;
        private static bool _SEEK_TO_NEXT_SYNCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.html#SEEK_TO_PREVIOUS_SYNC"/>
        /// </summary>
        public static int SEEK_TO_PREVIOUS_SYNC { get { if (!_SEEK_TO_PREVIOUS_SYNCReady) { _SEEK_TO_PREVIOUS_SYNCContent = SGetField<int>(LocalBridgeClazz, "SEEK_TO_PREVIOUS_SYNC"); _SEEK_TO_PREVIOUS_SYNCReady = true; } return _SEEK_TO_PREVIOUS_SYNCContent; } }
        private static int _SEEK_TO_PREVIOUS_SYNCContent = default;
        private static bool _SEEK_TO_PREVIOUS_SYNCReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.html#getDrmInitData()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.DrmInitData"/></returns>
        public Android.Media.DrmInitData GetDrmInitData()
        {
            return IExecuteWithSignature<Android.Media.DrmInitData>("getDrmInitData", "()Landroid/media/DrmInitData;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.html#getCasInfo(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Media.MediaExtractor.CasInfo"/></returns>
        public Android.Media.MediaExtractor.CasInfo GetCasInfo(int arg0)
        {
            return IExecuteWithSignature<Android.Media.MediaExtractor.CasInfo>("getCasInfo", "(I)Landroid/media/MediaExtractor$CasInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.html#getTrackFormat(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Media.MediaFormat"/></returns>
        public Android.Media.MediaFormat GetTrackFormat(int arg0)
        {
            return IExecuteWithSignature<Android.Media.MediaFormat>("getTrackFormat", "(I)Landroid/media/MediaFormat;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.html#getLogSessionId()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.Metrics.LogSessionId"/></returns>
        public Android.Media.Metrics.LogSessionId GetLogSessionId()
        {
            return IExecuteWithSignature<Android.Media.Metrics.LogSessionId>("getLogSessionId", "()Landroid/media/metrics/LogSessionId;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.html#getMetrics()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.PersistableBundle"/></returns>
        public Android.Os.PersistableBundle GetMetrics()
        {
            return IExecuteWithSignature<Android.Os.PersistableBundle>("getMetrics", "()Landroid/os/PersistableBundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.html#getAudioPresentations(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Media.AudioPresentation> GetAudioPresentations(int arg0)
        {
            return IExecuteWithSignature<Java.Util.List<Android.Media.AudioPresentation>>("getAudioPresentations", "(I)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.html#getPsshInfo()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Util.UUID, byte[]> GetPsshInfo()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Util.UUID, byte[]>>("getPsshInfo", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.html#advance()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Advance()
        {
            return IExecuteWithSignature<bool>("advance", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.html#getSampleCryptoInfo(android.media.MediaCodec.CryptoInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.MediaCodec.CryptoInfo"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool GetSampleCryptoInfo(Android.Media.MediaCodec.CryptoInfo arg0)
        {
            return IExecuteWithSignature<bool>("getSampleCryptoInfo", "(Landroid/media/MediaCodec$CryptoInfo;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.html#hasCacheReachedEndOfStream()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasCacheReachedEndOfStream()
        {
            return IExecuteWithSignature<bool>("hasCacheReachedEndOfStream", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.html#getSampleFlags()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSampleFlags()
        {
            return IExecuteWithSignature<int>("getSampleFlags", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.html#getSampleTrackIndex()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSampleTrackIndex()
        {
            return IExecuteWithSignature<int>("getSampleTrackIndex", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.html#getTrackCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTrackCount()
        {
            return IExecuteWithSignature<int>("getTrackCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.html#readSampleData(java.nio.ByteBuffer,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int ReadSampleData(Java.Nio.ByteBuffer arg0, int arg1)
        {
            return IExecute<int>("readSampleData", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.html#getCachedDuration()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetCachedDuration()
        {
            return IExecuteWithSignature<long>("getCachedDuration", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.html#getSampleSize()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetSampleSize()
        {
            return IExecuteWithSignature<long>("getSampleSize", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.html#getSampleTime()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetSampleTime()
        {
            return IExecuteWithSignature<long>("getSampleTime", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.html#release()"/>
        /// </summary>
        public void Release()
        {
            IExecuteWithSignature("release", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.html#seekTo(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SeekTo(long arg0, int arg1)
        {
            IExecute("seekTo", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.html#selectTrack(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SelectTrack(int arg0)
        {
            IExecuteWithSignature("selectTrack", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.html#setDataSource(android.media.MediaDataSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.MediaDataSource"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetDataSource(Android.Media.MediaDataSource arg0)
        {
            IExecuteWithSignature("setDataSource", "(Landroid/media/MediaDataSource;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.html#setDataSource(java.io.FileDescriptor,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.FileDescriptor"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetDataSource(Java.Io.FileDescriptor arg0, long arg1, long arg2)
        {
            IExecute("setDataSource", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.html#unselectTrack(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void UnselectTrack(int arg0)
        {
            IExecuteWithSignature("unselectTrack", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.html#setDataSource(android.content.Context,android.net.Uri,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg2"><see cref="Java.Util.Map"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetDataSource(Android.Content.Context arg0, Android.Net.Uri arg1, Java.Util.Map<Java.Lang.String, Java.Lang.String> arg2)
        {
            IExecute("setDataSource", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.html#setDataSource(android.content.res.AssetFileDescriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Res.AssetFileDescriptor"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        public void SetDataSource(Android.Content.Res.AssetFileDescriptor arg0)
        {
            IExecuteWithSignature("setDataSource", "(Landroid/content/res/AssetFileDescriptor;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.html#setDataSource(java.io.FileDescriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.FileDescriptor"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetDataSource(Java.Io.FileDescriptor arg0)
        {
            IExecuteWithSignature("setDataSource", "(Ljava/io/FileDescriptor;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.html#setDataSource(java.lang.String,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetDataSource(Java.Lang.String arg0, Java.Util.Map<Java.Lang.String, Java.Lang.String> arg1)
        {
            IExecute("setDataSource", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.html#setDataSource(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetDataSource(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setDataSource", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.html#setLogSessionId(android.media.metrics.LogSessionId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Metrics.LogSessionId"/></param>
        public void SetLogSessionId(Android.Media.Metrics.LogSessionId arg0)
        {
            IExecuteWithSignature("setLogSessionId", "(Landroid/media/metrics/LogSessionId;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.html#setMediaCas(android.media.MediaCas)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.MediaCas"/></param>
        [global::System.Obsolete()]
        public void SetMediaCas(Android.Media.MediaCas arg0)
        {
            IExecuteWithSignature("setMediaCas", "(Landroid/media/MediaCas;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region CasInfo
        public partial class CasInfo
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
            /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.CasInfo.html#getSession()"/>
            /// </summary>
            /// <returns><see cref="Android.Media.MediaCas.Session"/></returns>
            public Android.Media.MediaCas.Session GetSession()
            {
                return IExecuteWithSignature<Android.Media.MediaCas.Session>("getSession", "()Landroid/media/MediaCas$Session;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.CasInfo.html#getPrivateData()"/>
            /// </summary>
            /// <returns><see cref="byte"/></returns>
            public byte[] GetPrivateData()
            {
                return IExecuteWithSignatureArray<byte>("getPrivateData", "()[B");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.CasInfo.html#getSystemId()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetSystemId()
            {
                return IExecuteWithSignature<int>("getSystemId", "()I");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region MetricsConstants
        public partial class MetricsConstants
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.MetricsConstants.html#FORMAT"/>
            /// </summary>
            public static Java.Lang.String FORMAT { get { if (!_FORMATReady) { _FORMATContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FORMAT"); _FORMATReady = true; } return _FORMATContent; } }
            private static Java.Lang.String _FORMATContent = default;
            private static bool _FORMATReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.MetricsConstants.html#MIME_TYPE"/>
            /// </summary>
            public static Java.Lang.String MIME_TYPE { get { if (!_MIME_TYPEReady) { _MIME_TYPEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MIME_TYPE"); _MIME_TYPEReady = true; } return _MIME_TYPEContent; } }
            private static Java.Lang.String _MIME_TYPEContent = default;
            private static bool _MIME_TYPEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/MediaExtractor.MetricsConstants.html#TRACKS"/>
            /// </summary>
            public static Java.Lang.String TRACKS { get { if (!_TRACKSReady) { _TRACKSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TRACKS"); _TRACKSReady = true; } return _TRACKSContent; } }
            private static Java.Lang.String _TRACKSContent = default;
            private static bool _TRACKSReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

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