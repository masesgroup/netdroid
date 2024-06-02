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

namespace Android.View.Inputmethod
{
    #region InputBinding
    public partial class InputBinding
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputBinding.html#%3Cinit%3E(android.view.inputmethod.InputConnection,android.os.IBinder,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Inputmethod.InputConnection"/></param>
        /// <param name="arg1"><see cref="Android.Os.IBinder"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public InputBinding(Android.View.Inputmethod.InputConnection arg0, Android.Os.IBinder arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputBinding.html#%3Cinit%3E(android.view.inputmethod.InputConnection,android.view.inputmethod.InputBinding)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Inputmethod.InputConnection"/></param>
        /// <param name="arg1"><see cref="Android.View.Inputmethod.InputBinding"/></param>
        public InputBinding(Android.View.Inputmethod.InputConnection arg0, Android.View.Inputmethod.InputBinding arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputBinding.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputBinding.html#getConnectionToken()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.IBinder"/></returns>
        public Android.Os.IBinder GetConnectionToken()
        {
            return IExecuteWithSignature<Android.Os.IBinder>("getConnectionToken", "()Landroid/os/IBinder;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputBinding.html#getConnection()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Inputmethod.InputConnection"/></returns>
        public Android.View.Inputmethod.InputConnection GetConnection()
        {
            return IExecuteWithSignature<Android.View.Inputmethod.InputConnection>("getConnection", "()Landroid/view/inputmethod/InputConnection;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputBinding.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputBinding.html#getPid()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPid()
        {
            return IExecuteWithSignature<int>("getPid", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputBinding.html#getUid()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetUid()
        {
            return IExecuteWithSignature<int>("getUid", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputBinding.html#writeToParcel(android.os.Parcel,int)"/>
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