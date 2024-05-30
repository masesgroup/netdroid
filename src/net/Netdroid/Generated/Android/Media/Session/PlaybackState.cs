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

namespace Android.Media.Session
{
    #region PlaybackState
    public partial class PlaybackState
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#STATE_BUFFERING"/>
        /// </summary>
        public static int STATE_BUFFERING { get { if (!_STATE_BUFFERINGReady) { _STATE_BUFFERINGContent = SGetField<int>(LocalBridgeClazz, "STATE_BUFFERING"); _STATE_BUFFERINGReady = true; } return _STATE_BUFFERINGContent; } }
        private static int _STATE_BUFFERINGContent = default;
        private static bool _STATE_BUFFERINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#STATE_CONNECTING"/>
        /// </summary>
        public static int STATE_CONNECTING { get { if (!_STATE_CONNECTINGReady) { _STATE_CONNECTINGContent = SGetField<int>(LocalBridgeClazz, "STATE_CONNECTING"); _STATE_CONNECTINGReady = true; } return _STATE_CONNECTINGContent; } }
        private static int _STATE_CONNECTINGContent = default;
        private static bool _STATE_CONNECTINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#STATE_ERROR"/>
        /// </summary>
        public static int STATE_ERROR { get { if (!_STATE_ERRORReady) { _STATE_ERRORContent = SGetField<int>(LocalBridgeClazz, "STATE_ERROR"); _STATE_ERRORReady = true; } return _STATE_ERRORContent; } }
        private static int _STATE_ERRORContent = default;
        private static bool _STATE_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#STATE_FAST_FORWARDING"/>
        /// </summary>
        public static int STATE_FAST_FORWARDING { get { if (!_STATE_FAST_FORWARDINGReady) { _STATE_FAST_FORWARDINGContent = SGetField<int>(LocalBridgeClazz, "STATE_FAST_FORWARDING"); _STATE_FAST_FORWARDINGReady = true; } return _STATE_FAST_FORWARDINGContent; } }
        private static int _STATE_FAST_FORWARDINGContent = default;
        private static bool _STATE_FAST_FORWARDINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#STATE_NONE"/>
        /// </summary>
        public static int STATE_NONE { get { if (!_STATE_NONEReady) { _STATE_NONEContent = SGetField<int>(LocalBridgeClazz, "STATE_NONE"); _STATE_NONEReady = true; } return _STATE_NONEContent; } }
        private static int _STATE_NONEContent = default;
        private static bool _STATE_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#STATE_PAUSED"/>
        /// </summary>
        public static int STATE_PAUSED { get { if (!_STATE_PAUSEDReady) { _STATE_PAUSEDContent = SGetField<int>(LocalBridgeClazz, "STATE_PAUSED"); _STATE_PAUSEDReady = true; } return _STATE_PAUSEDContent; } }
        private static int _STATE_PAUSEDContent = default;
        private static bool _STATE_PAUSEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#STATE_PLAYING"/>
        /// </summary>
        public static int STATE_PLAYING { get { if (!_STATE_PLAYINGReady) { _STATE_PLAYINGContent = SGetField<int>(LocalBridgeClazz, "STATE_PLAYING"); _STATE_PLAYINGReady = true; } return _STATE_PLAYINGContent; } }
        private static int _STATE_PLAYINGContent = default;
        private static bool _STATE_PLAYINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#STATE_REWINDING"/>
        /// </summary>
        public static int STATE_REWINDING { get { if (!_STATE_REWINDINGReady) { _STATE_REWINDINGContent = SGetField<int>(LocalBridgeClazz, "STATE_REWINDING"); _STATE_REWINDINGReady = true; } return _STATE_REWINDINGContent; } }
        private static int _STATE_REWINDINGContent = default;
        private static bool _STATE_REWINDINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#STATE_SKIPPING_TO_NEXT"/>
        /// </summary>
        public static int STATE_SKIPPING_TO_NEXT { get { if (!_STATE_SKIPPING_TO_NEXTReady) { _STATE_SKIPPING_TO_NEXTContent = SGetField<int>(LocalBridgeClazz, "STATE_SKIPPING_TO_NEXT"); _STATE_SKIPPING_TO_NEXTReady = true; } return _STATE_SKIPPING_TO_NEXTContent; } }
        private static int _STATE_SKIPPING_TO_NEXTContent = default;
        private static bool _STATE_SKIPPING_TO_NEXTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#STATE_SKIPPING_TO_PREVIOUS"/>
        /// </summary>
        public static int STATE_SKIPPING_TO_PREVIOUS { get { if (!_STATE_SKIPPING_TO_PREVIOUSReady) { _STATE_SKIPPING_TO_PREVIOUSContent = SGetField<int>(LocalBridgeClazz, "STATE_SKIPPING_TO_PREVIOUS"); _STATE_SKIPPING_TO_PREVIOUSReady = true; } return _STATE_SKIPPING_TO_PREVIOUSContent; } }
        private static int _STATE_SKIPPING_TO_PREVIOUSContent = default;
        private static bool _STATE_SKIPPING_TO_PREVIOUSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#STATE_SKIPPING_TO_QUEUE_ITEM"/>
        /// </summary>
        public static int STATE_SKIPPING_TO_QUEUE_ITEM { get { if (!_STATE_SKIPPING_TO_QUEUE_ITEMReady) { _STATE_SKIPPING_TO_QUEUE_ITEMContent = SGetField<int>(LocalBridgeClazz, "STATE_SKIPPING_TO_QUEUE_ITEM"); _STATE_SKIPPING_TO_QUEUE_ITEMReady = true; } return _STATE_SKIPPING_TO_QUEUE_ITEMContent; } }
        private static int _STATE_SKIPPING_TO_QUEUE_ITEMContent = default;
        private static bool _STATE_SKIPPING_TO_QUEUE_ITEMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#STATE_STOPPED"/>
        /// </summary>
        public static int STATE_STOPPED { get { if (!_STATE_STOPPEDReady) { _STATE_STOPPEDContent = SGetField<int>(LocalBridgeClazz, "STATE_STOPPED"); _STATE_STOPPEDReady = true; } return _STATE_STOPPEDContent; } }
        private static int _STATE_STOPPEDContent = default;
        private static bool _STATE_STOPPEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#ACTION_FAST_FORWARD"/>
        /// </summary>
        public static long ACTION_FAST_FORWARD { get { if (!_ACTION_FAST_FORWARDReady) { _ACTION_FAST_FORWARDContent = SGetField<long>(LocalBridgeClazz, "ACTION_FAST_FORWARD"); _ACTION_FAST_FORWARDReady = true; } return _ACTION_FAST_FORWARDContent; } }
        private static long _ACTION_FAST_FORWARDContent = default;
        private static bool _ACTION_FAST_FORWARDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#ACTION_PAUSE"/>
        /// </summary>
        public static long ACTION_PAUSE { get { if (!_ACTION_PAUSEReady) { _ACTION_PAUSEContent = SGetField<long>(LocalBridgeClazz, "ACTION_PAUSE"); _ACTION_PAUSEReady = true; } return _ACTION_PAUSEContent; } }
        private static long _ACTION_PAUSEContent = default;
        private static bool _ACTION_PAUSEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#ACTION_PLAY"/>
        /// </summary>
        public static long ACTION_PLAY { get { if (!_ACTION_PLAYReady) { _ACTION_PLAYContent = SGetField<long>(LocalBridgeClazz, "ACTION_PLAY"); _ACTION_PLAYReady = true; } return _ACTION_PLAYContent; } }
        private static long _ACTION_PLAYContent = default;
        private static bool _ACTION_PLAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#ACTION_PLAY_FROM_MEDIA_ID"/>
        /// </summary>
        public static long ACTION_PLAY_FROM_MEDIA_ID { get { if (!_ACTION_PLAY_FROM_MEDIA_IDReady) { _ACTION_PLAY_FROM_MEDIA_IDContent = SGetField<long>(LocalBridgeClazz, "ACTION_PLAY_FROM_MEDIA_ID"); _ACTION_PLAY_FROM_MEDIA_IDReady = true; } return _ACTION_PLAY_FROM_MEDIA_IDContent; } }
        private static long _ACTION_PLAY_FROM_MEDIA_IDContent = default;
        private static bool _ACTION_PLAY_FROM_MEDIA_IDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#ACTION_PLAY_FROM_SEARCH"/>
        /// </summary>
        public static long ACTION_PLAY_FROM_SEARCH { get { if (!_ACTION_PLAY_FROM_SEARCHReady) { _ACTION_PLAY_FROM_SEARCHContent = SGetField<long>(LocalBridgeClazz, "ACTION_PLAY_FROM_SEARCH"); _ACTION_PLAY_FROM_SEARCHReady = true; } return _ACTION_PLAY_FROM_SEARCHContent; } }
        private static long _ACTION_PLAY_FROM_SEARCHContent = default;
        private static bool _ACTION_PLAY_FROM_SEARCHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#ACTION_PLAY_FROM_URI"/>
        /// </summary>
        public static long ACTION_PLAY_FROM_URI { get { if (!_ACTION_PLAY_FROM_URIReady) { _ACTION_PLAY_FROM_URIContent = SGetField<long>(LocalBridgeClazz, "ACTION_PLAY_FROM_URI"); _ACTION_PLAY_FROM_URIReady = true; } return _ACTION_PLAY_FROM_URIContent; } }
        private static long _ACTION_PLAY_FROM_URIContent = default;
        private static bool _ACTION_PLAY_FROM_URIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#ACTION_PLAY_PAUSE"/>
        /// </summary>
        public static long ACTION_PLAY_PAUSE { get { if (!_ACTION_PLAY_PAUSEReady) { _ACTION_PLAY_PAUSEContent = SGetField<long>(LocalBridgeClazz, "ACTION_PLAY_PAUSE"); _ACTION_PLAY_PAUSEReady = true; } return _ACTION_PLAY_PAUSEContent; } }
        private static long _ACTION_PLAY_PAUSEContent = default;
        private static bool _ACTION_PLAY_PAUSEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#ACTION_PREPARE"/>
        /// </summary>
        public static long ACTION_PREPARE { get { if (!_ACTION_PREPAREReady) { _ACTION_PREPAREContent = SGetField<long>(LocalBridgeClazz, "ACTION_PREPARE"); _ACTION_PREPAREReady = true; } return _ACTION_PREPAREContent; } }
        private static long _ACTION_PREPAREContent = default;
        private static bool _ACTION_PREPAREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#ACTION_PREPARE_FROM_MEDIA_ID"/>
        /// </summary>
        public static long ACTION_PREPARE_FROM_MEDIA_ID { get { if (!_ACTION_PREPARE_FROM_MEDIA_IDReady) { _ACTION_PREPARE_FROM_MEDIA_IDContent = SGetField<long>(LocalBridgeClazz, "ACTION_PREPARE_FROM_MEDIA_ID"); _ACTION_PREPARE_FROM_MEDIA_IDReady = true; } return _ACTION_PREPARE_FROM_MEDIA_IDContent; } }
        private static long _ACTION_PREPARE_FROM_MEDIA_IDContent = default;
        private static bool _ACTION_PREPARE_FROM_MEDIA_IDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#ACTION_PREPARE_FROM_SEARCH"/>
        /// </summary>
        public static long ACTION_PREPARE_FROM_SEARCH { get { if (!_ACTION_PREPARE_FROM_SEARCHReady) { _ACTION_PREPARE_FROM_SEARCHContent = SGetField<long>(LocalBridgeClazz, "ACTION_PREPARE_FROM_SEARCH"); _ACTION_PREPARE_FROM_SEARCHReady = true; } return _ACTION_PREPARE_FROM_SEARCHContent; } }
        private static long _ACTION_PREPARE_FROM_SEARCHContent = default;
        private static bool _ACTION_PREPARE_FROM_SEARCHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#ACTION_PREPARE_FROM_URI"/>
        /// </summary>
        public static long ACTION_PREPARE_FROM_URI { get { if (!_ACTION_PREPARE_FROM_URIReady) { _ACTION_PREPARE_FROM_URIContent = SGetField<long>(LocalBridgeClazz, "ACTION_PREPARE_FROM_URI"); _ACTION_PREPARE_FROM_URIReady = true; } return _ACTION_PREPARE_FROM_URIContent; } }
        private static long _ACTION_PREPARE_FROM_URIContent = default;
        private static bool _ACTION_PREPARE_FROM_URIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#ACTION_REWIND"/>
        /// </summary>
        public static long ACTION_REWIND { get { if (!_ACTION_REWINDReady) { _ACTION_REWINDContent = SGetField<long>(LocalBridgeClazz, "ACTION_REWIND"); _ACTION_REWINDReady = true; } return _ACTION_REWINDContent; } }
        private static long _ACTION_REWINDContent = default;
        private static bool _ACTION_REWINDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#ACTION_SEEK_TO"/>
        /// </summary>
        public static long ACTION_SEEK_TO { get { if (!_ACTION_SEEK_TOReady) { _ACTION_SEEK_TOContent = SGetField<long>(LocalBridgeClazz, "ACTION_SEEK_TO"); _ACTION_SEEK_TOReady = true; } return _ACTION_SEEK_TOContent; } }
        private static long _ACTION_SEEK_TOContent = default;
        private static bool _ACTION_SEEK_TOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#ACTION_SET_PLAYBACK_SPEED"/>
        /// </summary>
        public static long ACTION_SET_PLAYBACK_SPEED { get { if (!_ACTION_SET_PLAYBACK_SPEEDReady) { _ACTION_SET_PLAYBACK_SPEEDContent = SGetField<long>(LocalBridgeClazz, "ACTION_SET_PLAYBACK_SPEED"); _ACTION_SET_PLAYBACK_SPEEDReady = true; } return _ACTION_SET_PLAYBACK_SPEEDContent; } }
        private static long _ACTION_SET_PLAYBACK_SPEEDContent = default;
        private static bool _ACTION_SET_PLAYBACK_SPEEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#ACTION_SET_RATING"/>
        /// </summary>
        public static long ACTION_SET_RATING { get { if (!_ACTION_SET_RATINGReady) { _ACTION_SET_RATINGContent = SGetField<long>(LocalBridgeClazz, "ACTION_SET_RATING"); _ACTION_SET_RATINGReady = true; } return _ACTION_SET_RATINGContent; } }
        private static long _ACTION_SET_RATINGContent = default;
        private static bool _ACTION_SET_RATINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#ACTION_SKIP_TO_NEXT"/>
        /// </summary>
        public static long ACTION_SKIP_TO_NEXT { get { if (!_ACTION_SKIP_TO_NEXTReady) { _ACTION_SKIP_TO_NEXTContent = SGetField<long>(LocalBridgeClazz, "ACTION_SKIP_TO_NEXT"); _ACTION_SKIP_TO_NEXTReady = true; } return _ACTION_SKIP_TO_NEXTContent; } }
        private static long _ACTION_SKIP_TO_NEXTContent = default;
        private static bool _ACTION_SKIP_TO_NEXTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#ACTION_SKIP_TO_PREVIOUS"/>
        /// </summary>
        public static long ACTION_SKIP_TO_PREVIOUS { get { if (!_ACTION_SKIP_TO_PREVIOUSReady) { _ACTION_SKIP_TO_PREVIOUSContent = SGetField<long>(LocalBridgeClazz, "ACTION_SKIP_TO_PREVIOUS"); _ACTION_SKIP_TO_PREVIOUSReady = true; } return _ACTION_SKIP_TO_PREVIOUSContent; } }
        private static long _ACTION_SKIP_TO_PREVIOUSContent = default;
        private static bool _ACTION_SKIP_TO_PREVIOUSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#ACTION_SKIP_TO_QUEUE_ITEM"/>
        /// </summary>
        public static long ACTION_SKIP_TO_QUEUE_ITEM { get { if (!_ACTION_SKIP_TO_QUEUE_ITEMReady) { _ACTION_SKIP_TO_QUEUE_ITEMContent = SGetField<long>(LocalBridgeClazz, "ACTION_SKIP_TO_QUEUE_ITEM"); _ACTION_SKIP_TO_QUEUE_ITEMReady = true; } return _ACTION_SKIP_TO_QUEUE_ITEMContent; } }
        private static long _ACTION_SKIP_TO_QUEUE_ITEMContent = default;
        private static bool _ACTION_SKIP_TO_QUEUE_ITEMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#ACTION_STOP"/>
        /// </summary>
        public static long ACTION_STOP { get { if (!_ACTION_STOPReady) { _ACTION_STOPContent = SGetField<long>(LocalBridgeClazz, "ACTION_STOP"); _ACTION_STOPReady = true; } return _ACTION_STOPContent; } }
        private static long _ACTION_STOPContent = default;
        private static bool _ACTION_STOPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#PLAYBACK_POSITION_UNKNOWN"/>
        /// </summary>
        public static long PLAYBACK_POSITION_UNKNOWN { get { if (!_PLAYBACK_POSITION_UNKNOWNReady) { _PLAYBACK_POSITION_UNKNOWNContent = SGetField<long>(LocalBridgeClazz, "PLAYBACK_POSITION_UNKNOWN"); _PLAYBACK_POSITION_UNKNOWNReady = true; } return _PLAYBACK_POSITION_UNKNOWNContent; } }
        private static long _PLAYBACK_POSITION_UNKNOWNContent = default;
        private static bool _PLAYBACK_POSITION_UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#getActions()"/> 
        /// </summary>
        public long Actions
        {
            get { return IExecuteWithSignature<long>("getActions", "()J"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#getActiveQueueItemId()"/> 
        /// </summary>
        public long ActiveQueueItemId
        {
            get { return IExecuteWithSignature<long>("getActiveQueueItemId", "()J"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#getBufferedPosition()"/> 
        /// </summary>
        public long BufferedPosition
        {
            get { return IExecuteWithSignature<long>("getBufferedPosition", "()J"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#getCustomActions()"/> 
        /// </summary>
        public Java.Util.List<Android.Media.Session.PlaybackState.CustomAction> CustomActions
        {
            get { return IExecuteWithSignature<Java.Util.List<Android.Media.Session.PlaybackState.CustomAction>>("getCustomActions", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#getErrorMessage()"/> 
        /// </summary>
        public Java.Lang.CharSequence ErrorMessage
        {
            get { return IExecuteWithSignature<Java.Lang.CharSequence>("getErrorMessage", "()Ljava/lang/CharSequence;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#getExtras()"/> 
        /// </summary>
        public Android.Os.Bundle Extras
        {
            get { return IExecuteWithSignature<Android.Os.Bundle>("getExtras", "()Landroid/os/Bundle;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#getLastPositionUpdateTime()"/> 
        /// </summary>
        public long LastPositionUpdateTime
        {
            get { return IExecuteWithSignature<long>("getLastPositionUpdateTime", "()J"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#getPlaybackSpeed()"/> 
        /// </summary>
        public float PlaybackSpeed
        {
            get { return IExecuteWithSignature<float>("getPlaybackSpeed", "()F"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#getPosition()"/> 
        /// </summary>
        public long Position
        {
            get { return IExecuteWithSignature<long>("getPosition", "()J"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#getState()"/> 
        /// </summary>
        public int State
        {
            get { return IExecuteWithSignature<int>("getState", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#isActive()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsActive()
        {
            return IExecuteWithSignature<bool>("isActive", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.Builder.html#%3Cinit%3E(android.media.session.PlaybackState)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.Session.PlaybackState"/></param>
            public Builder(Android.Media.Session.PlaybackState arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Media.Session.PlaybackState"/></returns>
            public Android.Media.Session.PlaybackState Build()
            {
                return IExecuteWithSignature<Android.Media.Session.PlaybackState>("build", "()Landroid/media/session/PlaybackState;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.Builder.html#addCustomAction(android.media.session.PlaybackState.CustomAction)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.Session.PlaybackState.CustomAction"/></param>
            /// <returns><see cref="Android.Media.Session.PlaybackState.Builder"/></returns>
            public Android.Media.Session.PlaybackState.Builder AddCustomAction(Android.Media.Session.PlaybackState.CustomAction arg0)
            {
                return IExecuteWithSignature<Android.Media.Session.PlaybackState.Builder>("addCustomAction", "(Landroid/media/session/PlaybackState$CustomAction;)Landroid/media/session/PlaybackState$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.Builder.html#addCustomAction(java.lang.String,java.lang.String,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <returns><see cref="Android.Media.Session.PlaybackState.Builder"/></returns>
            public Android.Media.Session.PlaybackState.Builder AddCustomAction(Java.Lang.String arg0, Java.Lang.String arg1, int arg2)
            {
                return IExecute<Android.Media.Session.PlaybackState.Builder>("addCustomAction", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.Builder.html#setActions(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Media.Session.PlaybackState.Builder"/></returns>
            public Android.Media.Session.PlaybackState.Builder SetActions(long arg0)
            {
                return IExecuteWithSignature<Android.Media.Session.PlaybackState.Builder>("setActions", "(J)Landroid/media/session/PlaybackState$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.Builder.html#setActiveQueueItemId(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Media.Session.PlaybackState.Builder"/></returns>
            public Android.Media.Session.PlaybackState.Builder SetActiveQueueItemId(long arg0)
            {
                return IExecuteWithSignature<Android.Media.Session.PlaybackState.Builder>("setActiveQueueItemId", "(J)Landroid/media/session/PlaybackState$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.Builder.html#setBufferedPosition(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Media.Session.PlaybackState.Builder"/></returns>
            public Android.Media.Session.PlaybackState.Builder SetBufferedPosition(long arg0)
            {
                return IExecuteWithSignature<Android.Media.Session.PlaybackState.Builder>("setBufferedPosition", "(J)Landroid/media/session/PlaybackState$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.Builder.html#setErrorMessage(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.Media.Session.PlaybackState.Builder"/></returns>
            public Android.Media.Session.PlaybackState.Builder SetErrorMessage(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<Android.Media.Session.PlaybackState.Builder>("setErrorMessage", "(Ljava/lang/CharSequence;)Landroid/media/session/PlaybackState$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.Builder.html#setExtras(android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
            /// <returns><see cref="Android.Media.Session.PlaybackState.Builder"/></returns>
            public Android.Media.Session.PlaybackState.Builder SetExtras(Android.Os.Bundle arg0)
            {
                return IExecuteWithSignature<Android.Media.Session.PlaybackState.Builder>("setExtras", "(Landroid/os/Bundle;)Landroid/media/session/PlaybackState$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.Builder.html#setState(int,long,float,long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            /// <param name="arg2"><see cref="float"/></param>
            /// <param name="arg3"><see cref="long"/></param>
            /// <returns><see cref="Android.Media.Session.PlaybackState.Builder"/></returns>
            public Android.Media.Session.PlaybackState.Builder SetState(int arg0, long arg1, float arg2, long arg3)
            {
                return IExecute<Android.Media.Session.PlaybackState.Builder>("setState", arg0, arg1, arg2, arg3);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.Builder.html#setState(int,long,float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            /// <param name="arg2"><see cref="float"/></param>
            /// <returns><see cref="Android.Media.Session.PlaybackState.Builder"/></returns>
            public Android.Media.Session.PlaybackState.Builder SetState(int arg0, long arg1, float arg2)
            {
                return IExecute<Android.Media.Session.PlaybackState.Builder>("setState", arg0, arg1, arg2);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region CustomAction
        public partial class CustomAction
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.CustomAction.html#CREATOR"/>
            /// </summary>
            public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
            private static Android.Os.Parcelable.Creator _CREATORContent = default;
            private static bool _CREATORReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.CustomAction.html#getAction()"/> 
            /// </summary>
            public Java.Lang.String Action
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getAction", "()Ljava/lang/String;"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.CustomAction.html#getExtras()"/> 
            /// </summary>
            public Android.Os.Bundle Extras
            {
                get { return IExecuteWithSignature<Android.Os.Bundle>("getExtras", "()Landroid/os/Bundle;"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.CustomAction.html#getIcon()"/> 
            /// </summary>
            public int Icon
            {
                get { return IExecuteWithSignature<int>("getIcon", "()I"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.CustomAction.html#getName()"/> 
            /// </summary>
            public Java.Lang.CharSequence Name
            {
                get { return IExecuteWithSignature<Java.Lang.CharSequence>("getName", "()Ljava/lang/CharSequence;"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.CustomAction.html#describeContents()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int DescribeContents()
            {
                return IExecuteWithSignature<int>("describeContents", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.CustomAction.html#writeToParcel(android.os.Parcel,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
            {
                IExecute("writeToParcel", arg0, arg1);
            }

            #endregion

            #region Nested classes
            #region Builder
            public partial class Builder
            {
                #region Constructors
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.CustomAction.Builder.html#%3Cinit%3E(java.lang.String,java.lang.CharSequence,int)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Java.Lang.String"/></param>
                /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
                /// <param name="arg2"><see cref="int"/></param>
                public Builder(Java.Lang.String arg0, Java.Lang.CharSequence arg1, int arg2)
                    : base(arg0, arg1, arg2)
                {
                }

                #endregion

                #region Class/Interface conversion operators

                #endregion

                #region Fields

                #endregion

                #region Static methods

                #endregion

                #region Instance methods
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.CustomAction.Builder.html#build()"/>
                /// </summary>
                /// <returns><see cref="Android.Media.Session.PlaybackState.CustomAction"/></returns>
                public Android.Media.Session.PlaybackState.CustomAction Build()
                {
                    return IExecuteWithSignature<Android.Media.Session.PlaybackState.CustomAction>("build", "()Landroid/media/session/PlaybackState$CustomAction;");
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/media/session/PlaybackState.CustomAction.Builder.html#setExtras(android.os.Bundle)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
                /// <returns><see cref="Android.Media.Session.PlaybackState.CustomAction.Builder"/></returns>
                public Android.Media.Session.PlaybackState.CustomAction.Builder SetExtras(Android.Os.Bundle arg0)
                {
                    return IExecuteWithSignature<Android.Media.Session.PlaybackState.CustomAction.Builder>("setExtras", "(Landroid/os/Bundle;)Landroid/media/session/PlaybackState$CustomAction$Builder;", arg0);
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

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}