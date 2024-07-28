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

namespace Android.Content
{
    #region PeriodicSync
    public partial class PeriodicSync
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/PeriodicSync.html#%3Cinit%3E(android.accounts.Account,java.lang.String,android.os.Bundle,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Accounts.Account"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        public PeriodicSync(Android.Accounts.Account arg0, Java.Lang.String arg1, Android.Os.Bundle arg2, long arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/PeriodicSync.html#account"/>
        /// </summary>
        public Android.Accounts.Account account { get { if (!_accountReady) { _accountContent = IGetField<Android.Accounts.Account>("account"); _accountReady = true; } return _accountContent; } }
        private Android.Accounts.Account _accountContent = default;
        private bool _accountReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/PeriodicSync.html#extras"/>
        /// </summary>
        public Android.Os.Bundle extras { get { if (!_extrasReady) { _extrasContent = IGetField<Android.Os.Bundle>("extras"); _extrasReady = true; } return _extrasContent; } }
        private Android.Os.Bundle _extrasContent = default;
        private bool _extrasReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/PeriodicSync.html#authority"/>
        /// </summary>
        public Java.Lang.String authority { get { if (!_authorityReady) { _authorityContent = IGetField<Java.Lang.String>("authority"); _authorityReady = true; } return _authorityContent; } }
        private Java.Lang.String _authorityContent = default;
        private bool _authorityReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/PeriodicSync.html#period"/>
        /// </summary>
        public long period { get { if (!_periodReady) { _periodContent = IGetField<long>("period"); _periodReady = true; } return _periodContent; } }
        private long _periodContent = default;
        private bool _periodReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/PeriodicSync.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/PeriodicSync.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/PeriodicSync.html#writeToParcel(android.os.Parcel,int)"/>
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