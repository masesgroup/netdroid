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
    #region SyncAdapterType
    public partial class SyncAdapterType
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncAdapterType.html#%3Cinit%3E(android.os.Parcel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        public SyncAdapterType(Android.Os.Parcel arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncAdapterType.html#%3Cinit%3E(java.lang.String,java.lang.String,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        public SyncAdapterType(Java.Lang.String arg0, Java.Lang.String arg1, bool arg2, bool arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncAdapterType.html#isKey"/>
        /// </summary>
        public bool isKey { get { if (!_isKeyReady) { _isKeyContent = IGetField<bool>("isKey"); _isKeyReady = true; } return _isKeyContent; } }
        private bool _isKeyContent = default;
        private bool _isKeyReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncAdapterType.html#accountType"/>
        /// </summary>
        public Java.Lang.String accountType { get { if (!_accountTypeReady) { _accountTypeContent = IGetField<Java.Lang.String>("accountType"); _accountTypeReady = true; } return _accountTypeContent; } }
        private Java.Lang.String _accountTypeContent = default;
        private bool _accountTypeReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncAdapterType.html#authority"/>
        /// </summary>
        public Java.Lang.String authority { get { if (!_authorityReady) { _authorityContent = IGetField<Java.Lang.String>("authority"); _authorityReady = true; } return _authorityContent; } }
        private Java.Lang.String _authorityContent = default;
        private bool _authorityReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncAdapterType.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncAdapterType.html#newKey(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Content.SyncAdapterType"/></returns>
        public static Android.Content.SyncAdapterType NewKey(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecute<Android.Content.SyncAdapterType>(LocalBridgeClazz, "newKey", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncAdapterType.html#allowParallelSyncs()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool AllowParallelSyncs()
        {
            return IExecuteWithSignature<bool>("allowParallelSyncs", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncAdapterType.html#isAlwaysSyncable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAlwaysSyncable()
        {
            return IExecuteWithSignature<bool>("isAlwaysSyncable", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncAdapterType.html#isUserVisible()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUserVisible()
        {
            return IExecuteWithSignature<bool>("isUserVisible", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncAdapterType.html#supportsUploading()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool SupportsUploading()
        {
            return IExecuteWithSignature<bool>("supportsUploading", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncAdapterType.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncAdapterType.html#getSettingsActivity()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSettingsActivity()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSettingsActivity", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncAdapterType.html#writeToParcel(android.os.Parcel,int)"/>
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