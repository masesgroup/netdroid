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

namespace Android.Telephony.Mbms
{
    #region IGroupCallCallback
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IGroupCallCallback
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region GroupCallCallback
    public partial class GroupCallCallback : Android.Telephony.Mbms.IGroupCallCallback
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/mbms/GroupCallCallback.html#SIGNAL_STRENGTH_UNAVAILABLE"/>
        /// </summary>
        public static int SIGNAL_STRENGTH_UNAVAILABLE { get { if (!_SIGNAL_STRENGTH_UNAVAILABLEReady) { _SIGNAL_STRENGTH_UNAVAILABLEContent = SGetField<int>(LocalBridgeClazz, "SIGNAL_STRENGTH_UNAVAILABLE"); _SIGNAL_STRENGTH_UNAVAILABLEReady = true; } return _SIGNAL_STRENGTH_UNAVAILABLEContent; } }
        private static int _SIGNAL_STRENGTH_UNAVAILABLEContent = default;
        private static bool _SIGNAL_STRENGTH_UNAVAILABLEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/mbms/GroupCallCallback.html#onBroadcastSignalStrengthUpdated(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void OnBroadcastSignalStrengthUpdated(int arg0)
        {
            IExecuteWithSignature("onBroadcastSignalStrengthUpdated", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/mbms/GroupCallCallback.html#onError(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void OnError(int arg0, Java.Lang.String arg1)
        {
            IExecute("onError", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/mbms/GroupCallCallback.html#onGroupCallStateChanged(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void OnGroupCallStateChanged(int arg0, int arg1)
        {
            IExecute("onGroupCallStateChanged", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}