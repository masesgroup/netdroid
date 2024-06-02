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

namespace Android.View
{
    #region VerifiedMotionEvent
    public partial class VerifiedMotionEvent
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/VerifiedMotionEvent.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/VerifiedMotionEvent.html#getRawX()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetRawX()
        {
            return IExecuteWithSignature<float>("getRawX", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/VerifiedMotionEvent.html#getRawY()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetRawY()
        {
            return IExecuteWithSignature<float>("getRawY", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/VerifiedMotionEvent.html#getActionMasked()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetActionMasked()
        {
            return IExecuteWithSignature<int>("getActionMasked", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/VerifiedMotionEvent.html#getButtonState()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetButtonState()
        {
            return IExecuteWithSignature<int>("getButtonState", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/VerifiedMotionEvent.html#getMetaState()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMetaState()
        {
            return IExecuteWithSignature<int>("getMetaState", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/VerifiedMotionEvent.html#getFlag(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Boolean"/></returns>
        public Java.Lang.Boolean GetFlag(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.Boolean>("getFlag", "(I)Ljava/lang/Boolean;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/VerifiedMotionEvent.html#getDownTimeNanos()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetDownTimeNanos()
        {
            return IExecuteWithSignature<long>("getDownTimeNanos", "()J");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}