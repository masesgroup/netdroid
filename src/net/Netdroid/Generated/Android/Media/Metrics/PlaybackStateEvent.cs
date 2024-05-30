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

namespace Android.Media.Metrics
{
    #region PlaybackStateEvent
    public partial class PlaybackStateEvent
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Media.Metrics.PlaybackStateEvent"/> to <see cref="Android.Os.Parcelable"/>
        /// </summary>
        public static implicit operator Android.Os.Parcelable(Android.Media.Metrics.PlaybackStateEvent t) => t.Cast<Android.Os.Parcelable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackStateEvent.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackStateEvent.html#STATE_ABANDONED"/>
        /// </summary>
        public static int STATE_ABANDONED { get { if (!_STATE_ABANDONEDReady) { _STATE_ABANDONEDContent = SGetField<int>(LocalBridgeClazz, "STATE_ABANDONED"); _STATE_ABANDONEDReady = true; } return _STATE_ABANDONEDContent; } }
        private static int _STATE_ABANDONEDContent = default;
        private static bool _STATE_ABANDONEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackStateEvent.html#STATE_BUFFERING"/>
        /// </summary>
        public static int STATE_BUFFERING { get { if (!_STATE_BUFFERINGReady) { _STATE_BUFFERINGContent = SGetField<int>(LocalBridgeClazz, "STATE_BUFFERING"); _STATE_BUFFERINGReady = true; } return _STATE_BUFFERINGContent; } }
        private static int _STATE_BUFFERINGContent = default;
        private static bool _STATE_BUFFERINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackStateEvent.html#STATE_ENDED"/>
        /// </summary>
        public static int STATE_ENDED { get { if (!_STATE_ENDEDReady) { _STATE_ENDEDContent = SGetField<int>(LocalBridgeClazz, "STATE_ENDED"); _STATE_ENDEDReady = true; } return _STATE_ENDEDContent; } }
        private static int _STATE_ENDEDContent = default;
        private static bool _STATE_ENDEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackStateEvent.html#STATE_FAILED"/>
        /// </summary>
        public static int STATE_FAILED { get { if (!_STATE_FAILEDReady) { _STATE_FAILEDContent = SGetField<int>(LocalBridgeClazz, "STATE_FAILED"); _STATE_FAILEDReady = true; } return _STATE_FAILEDContent; } }
        private static int _STATE_FAILEDContent = default;
        private static bool _STATE_FAILEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackStateEvent.html#STATE_INTERRUPTED_BY_AD"/>
        /// </summary>
        public static int STATE_INTERRUPTED_BY_AD { get { if (!_STATE_INTERRUPTED_BY_ADReady) { _STATE_INTERRUPTED_BY_ADContent = SGetField<int>(LocalBridgeClazz, "STATE_INTERRUPTED_BY_AD"); _STATE_INTERRUPTED_BY_ADReady = true; } return _STATE_INTERRUPTED_BY_ADContent; } }
        private static int _STATE_INTERRUPTED_BY_ADContent = default;
        private static bool _STATE_INTERRUPTED_BY_ADReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackStateEvent.html#STATE_JOINING_BACKGROUND"/>
        /// </summary>
        public static int STATE_JOINING_BACKGROUND { get { if (!_STATE_JOINING_BACKGROUNDReady) { _STATE_JOINING_BACKGROUNDContent = SGetField<int>(LocalBridgeClazz, "STATE_JOINING_BACKGROUND"); _STATE_JOINING_BACKGROUNDReady = true; } return _STATE_JOINING_BACKGROUNDContent; } }
        private static int _STATE_JOINING_BACKGROUNDContent = default;
        private static bool _STATE_JOINING_BACKGROUNDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackStateEvent.html#STATE_JOINING_FOREGROUND"/>
        /// </summary>
        public static int STATE_JOINING_FOREGROUND { get { if (!_STATE_JOINING_FOREGROUNDReady) { _STATE_JOINING_FOREGROUNDContent = SGetField<int>(LocalBridgeClazz, "STATE_JOINING_FOREGROUND"); _STATE_JOINING_FOREGROUNDReady = true; } return _STATE_JOINING_FOREGROUNDContent; } }
        private static int _STATE_JOINING_FOREGROUNDContent = default;
        private static bool _STATE_JOINING_FOREGROUNDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackStateEvent.html#STATE_NOT_STARTED"/>
        /// </summary>
        public static int STATE_NOT_STARTED { get { if (!_STATE_NOT_STARTEDReady) { _STATE_NOT_STARTEDContent = SGetField<int>(LocalBridgeClazz, "STATE_NOT_STARTED"); _STATE_NOT_STARTEDReady = true; } return _STATE_NOT_STARTEDContent; } }
        private static int _STATE_NOT_STARTEDContent = default;
        private static bool _STATE_NOT_STARTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackStateEvent.html#STATE_PAUSED"/>
        /// </summary>
        public static int STATE_PAUSED { get { if (!_STATE_PAUSEDReady) { _STATE_PAUSEDContent = SGetField<int>(LocalBridgeClazz, "STATE_PAUSED"); _STATE_PAUSEDReady = true; } return _STATE_PAUSEDContent; } }
        private static int _STATE_PAUSEDContent = default;
        private static bool _STATE_PAUSEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackStateEvent.html#STATE_PAUSED_BUFFERING"/>
        /// </summary>
        public static int STATE_PAUSED_BUFFERING { get { if (!_STATE_PAUSED_BUFFERINGReady) { _STATE_PAUSED_BUFFERINGContent = SGetField<int>(LocalBridgeClazz, "STATE_PAUSED_BUFFERING"); _STATE_PAUSED_BUFFERINGReady = true; } return _STATE_PAUSED_BUFFERINGContent; } }
        private static int _STATE_PAUSED_BUFFERINGContent = default;
        private static bool _STATE_PAUSED_BUFFERINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackStateEvent.html#STATE_PLAYING"/>
        /// </summary>
        public static int STATE_PLAYING { get { if (!_STATE_PLAYINGReady) { _STATE_PLAYINGContent = SGetField<int>(LocalBridgeClazz, "STATE_PLAYING"); _STATE_PLAYINGReady = true; } return _STATE_PLAYINGContent; } }
        private static int _STATE_PLAYINGContent = default;
        private static bool _STATE_PLAYINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackStateEvent.html#STATE_SEEKING"/>
        /// </summary>
        public static int STATE_SEEKING { get { if (!_STATE_SEEKINGReady) { _STATE_SEEKINGContent = SGetField<int>(LocalBridgeClazz, "STATE_SEEKING"); _STATE_SEEKINGReady = true; } return _STATE_SEEKINGContent; } }
        private static int _STATE_SEEKINGContent = default;
        private static bool _STATE_SEEKINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackStateEvent.html#STATE_STOPPED"/>
        /// </summary>
        public static int STATE_STOPPED { get { if (!_STATE_STOPPEDReady) { _STATE_STOPPEDContent = SGetField<int>(LocalBridgeClazz, "STATE_STOPPED"); _STATE_STOPPEDReady = true; } return _STATE_STOPPEDContent; } }
        private static int _STATE_STOPPEDContent = default;
        private static bool _STATE_STOPPEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackStateEvent.html#STATE_SUPPRESSED"/>
        /// </summary>
        public static int STATE_SUPPRESSED { get { if (!_STATE_SUPPRESSEDReady) { _STATE_SUPPRESSEDContent = SGetField<int>(LocalBridgeClazz, "STATE_SUPPRESSED"); _STATE_SUPPRESSEDReady = true; } return _STATE_SUPPRESSEDContent; } }
        private static int _STATE_SUPPRESSEDContent = default;
        private static bool _STATE_SUPPRESSEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackStateEvent.html#STATE_SUPPRESSED_BUFFERING"/>
        /// </summary>
        public static int STATE_SUPPRESSED_BUFFERING { get { if (!_STATE_SUPPRESSED_BUFFERINGReady) { _STATE_SUPPRESSED_BUFFERINGContent = SGetField<int>(LocalBridgeClazz, "STATE_SUPPRESSED_BUFFERING"); _STATE_SUPPRESSED_BUFFERINGReady = true; } return _STATE_SUPPRESSED_BUFFERINGContent; } }
        private static int _STATE_SUPPRESSED_BUFFERINGContent = default;
        private static bool _STATE_SUPPRESSED_BUFFERINGReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackStateEvent.html#getState()"/> 
        /// </summary>
        public int State
        {
            get { return IExecuteWithSignature<int>("getState", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackStateEvent.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackStateEvent.html#writeToParcel(android.os.Parcel,int)"/>
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

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackStateEvent.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Media.Metrics.PlaybackStateEvent"/></returns>
            public Android.Media.Metrics.PlaybackStateEvent Build()
            {
                return IExecuteWithSignature<Android.Media.Metrics.PlaybackStateEvent>("build", "()Landroid/media/metrics/PlaybackStateEvent;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackStateEvent.Builder.html#setMetricsBundle(android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
            /// <returns><see cref="Android.Media.Metrics.PlaybackStateEvent.Builder"/></returns>
            public Android.Media.Metrics.PlaybackStateEvent.Builder SetMetricsBundle(Android.Os.Bundle arg0)
            {
                return IExecuteWithSignature<Android.Media.Metrics.PlaybackStateEvent.Builder>("setMetricsBundle", "(Landroid/os/Bundle;)Landroid/media/metrics/PlaybackStateEvent$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackStateEvent.Builder.html#setState(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Media.Metrics.PlaybackStateEvent.Builder"/></returns>
            public Android.Media.Metrics.PlaybackStateEvent.Builder SetState(int arg0)
            {
                return IExecuteWithSignature<Android.Media.Metrics.PlaybackStateEvent.Builder>("setState", "(I)Landroid/media/metrics/PlaybackStateEvent$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackStateEvent.Builder.html#setTimeSinceCreatedMillis(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Media.Metrics.PlaybackStateEvent.Builder"/></returns>
            public Android.Media.Metrics.PlaybackStateEvent.Builder SetTimeSinceCreatedMillis(long arg0)
            {
                return IExecuteWithSignature<Android.Media.Metrics.PlaybackStateEvent.Builder>("setTimeSinceCreatedMillis", "(J)Landroid/media/metrics/PlaybackStateEvent$Builder;", arg0);
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