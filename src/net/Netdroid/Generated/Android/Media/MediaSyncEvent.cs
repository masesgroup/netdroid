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

namespace Android.Media
{
    #region MediaSyncEvent
    public partial class MediaSyncEvent
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaSyncEvent.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaSyncEvent.html#SYNC_EVENT_NONE"/>
        /// </summary>
        public static int SYNC_EVENT_NONE { get { if (!_SYNC_EVENT_NONEReady) { _SYNC_EVENT_NONEContent = SGetField<int>(LocalBridgeClazz, "SYNC_EVENT_NONE"); _SYNC_EVENT_NONEReady = true; } return _SYNC_EVENT_NONEContent; } }
        private static int _SYNC_EVENT_NONEContent = default;
        private static bool _SYNC_EVENT_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaSyncEvent.html#SYNC_EVENT_PRESENTATION_COMPLETE"/>
        /// </summary>
        public static int SYNC_EVENT_PRESENTATION_COMPLETE { get { if (!_SYNC_EVENT_PRESENTATION_COMPLETEReady) { _SYNC_EVENT_PRESENTATION_COMPLETEContent = SGetField<int>(LocalBridgeClazz, "SYNC_EVENT_PRESENTATION_COMPLETE"); _SYNC_EVENT_PRESENTATION_COMPLETEReady = true; } return _SYNC_EVENT_PRESENTATION_COMPLETEContent; } }
        private static int _SYNC_EVENT_PRESENTATION_COMPLETEContent = default;
        private static bool _SYNC_EVENT_PRESENTATION_COMPLETEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaSyncEvent.html#createEvent(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Media.MediaSyncEvent"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public static Android.Media.MediaSyncEvent CreateEvent(int arg0)
        {
            return SExecuteWithSignature<Android.Media.MediaSyncEvent>(LocalBridgeClazz, "createEvent", "(I)Landroid/media/MediaSyncEvent;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaSyncEvent.html#getAudioSessionId()"/> 
        /// </summary>
        public int AudioSessionId
        {
            get { return IExecuteWithSignature<int>("getAudioSessionId", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaSyncEvent.html#getType()"/> 
        /// </summary>
        public int Type
        {
            get { return IExecuteWithSignature<int>("getType", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaSyncEvent.html#setAudioSessionId(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Media.MediaSyncEvent"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public Android.Media.MediaSyncEvent SetAudioSessionId(int arg0)
        {
            return IExecuteWithSignature<Android.Media.MediaSyncEvent>("setAudioSessionId", "(I)Landroid/media/MediaSyncEvent;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaSyncEvent.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaSyncEvent.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}