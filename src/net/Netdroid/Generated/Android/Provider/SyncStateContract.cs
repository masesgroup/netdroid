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

namespace Android.Provider
{
    #region SyncStateContract
    public partial class SyncStateContract
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

        #endregion

        #region Nested classes
        #region Columns
        public partial class Columns
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/SyncStateContract.Columns.html#ACCOUNT_NAME"/>
            /// </summary>
            public static Java.Lang.String ACCOUNT_NAME { get { if (!_ACCOUNT_NAMEReady) { _ACCOUNT_NAMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACCOUNT_NAME"); _ACCOUNT_NAMEReady = true; } return _ACCOUNT_NAMEContent; } }
            private static Java.Lang.String _ACCOUNT_NAMEContent = default;
            private static bool _ACCOUNT_NAMEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/SyncStateContract.Columns.html#ACCOUNT_TYPE"/>
            /// </summary>
            public static Java.Lang.String ACCOUNT_TYPE { get { if (!_ACCOUNT_TYPEReady) { _ACCOUNT_TYPEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACCOUNT_TYPE"); _ACCOUNT_TYPEReady = true; } return _ACCOUNT_TYPEContent; } }
            private static Java.Lang.String _ACCOUNT_TYPEContent = default;
            private static bool _ACCOUNT_TYPEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/SyncStateContract.Columns.html#DATA"/>
            /// </summary>
            public static Java.Lang.String DATA { get { if (!_DATAReady) { _DATAContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DATA"); _DATAReady = true; } return _DATAContent; } }
            private static Java.Lang.String _DATAContent = default;
            private static bool _DATAReady = false; // this is used because in case of generics 

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

        #region Constants
        public partial class Constants
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/SyncStateContract.Constants.html#CONTENT_DIRECTORY"/>
            /// </summary>
            public static Java.Lang.String CONTENT_DIRECTORY { get { if (!_CONTENT_DIRECTORYReady) { _CONTENT_DIRECTORYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CONTENT_DIRECTORY"); _CONTENT_DIRECTORYReady = true; } return _CONTENT_DIRECTORYContent; } }
            private static Java.Lang.String _CONTENT_DIRECTORYContent = default;
            private static bool _CONTENT_DIRECTORYReady = false; // this is used because in case of generics 

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

        #region Helpers
        public partial class Helpers
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/SyncStateContract.Helpers.html#newSetOperation(android.net.Uri,android.accounts.Account,byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
            /// <param name="arg1"><see cref="Android.Accounts.Account"/></param>
            /// <param name="arg2"><see cref="byte"/></param>
            /// <returns><see cref="Android.Content.ContentProviderOperation"/></returns>
            public static Android.Content.ContentProviderOperation NewSetOperation(Android.Net.Uri arg0, Android.Accounts.Account arg1, byte[] arg2)
            {
                return SExecute<Android.Content.ContentProviderOperation>(LocalBridgeClazz, "newSetOperation", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/SyncStateContract.Helpers.html#newUpdateOperation(android.net.Uri,byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
            /// <param name="arg1"><see cref="byte"/></param>
            /// <returns><see cref="Android.Content.ContentProviderOperation"/></returns>
            public static Android.Content.ContentProviderOperation NewUpdateOperation(Android.Net.Uri arg0, byte[] arg1)
            {
                return SExecute<Android.Content.ContentProviderOperation>(LocalBridgeClazz, "newUpdateOperation", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/SyncStateContract.Helpers.html#insert(android.content.ContentProviderClient,android.net.Uri,android.accounts.Account,byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.ContentProviderClient"/></param>
            /// <param name="arg1"><see cref="Android.Net.Uri"/></param>
            /// <param name="arg2"><see cref="Android.Accounts.Account"/></param>
            /// <param name="arg3"><see cref="byte"/></param>
            /// <returns><see cref="Android.Net.Uri"/></returns>
            /// <exception cref="Android.Os.RemoteException"/>
            public static Android.Net.Uri Insert(Android.Content.ContentProviderClient arg0, Android.Net.Uri arg1, Android.Accounts.Account arg2, byte[] arg3)
            {
                return SExecute<Android.Net.Uri>(LocalBridgeClazz, "insert", arg0, arg1, arg2, arg3);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/SyncStateContract.Helpers.html#getWithUri(android.content.ContentProviderClient,android.net.Uri,android.accounts.Account)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.ContentProviderClient"/></param>
            /// <param name="arg1"><see cref="Android.Net.Uri"/></param>
            /// <param name="arg2"><see cref="Android.Accounts.Account"/></param>
            /// <returns><see cref="Android.Util.Pair"/></returns>
            /// <exception cref="Android.Os.RemoteException"/>
            public static Android.Util.Pair<Android.Net.Uri, byte[]> GetWithUri(Android.Content.ContentProviderClient arg0, Android.Net.Uri arg1, Android.Accounts.Account arg2)
            {
                return SExecute<Android.Util.Pair<Android.Net.Uri, byte[]>>(LocalBridgeClazz, "getWithUri", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/SyncStateContract.Helpers.html#get(android.content.ContentProviderClient,android.net.Uri,android.accounts.Account)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.ContentProviderClient"/></param>
            /// <param name="arg1"><see cref="Android.Net.Uri"/></param>
            /// <param name="arg2"><see cref="Android.Accounts.Account"/></param>
            /// <returns><see cref="byte"/></returns>
            /// <exception cref="Android.Os.RemoteException"/>
            public static byte[] Get(Android.Content.ContentProviderClient arg0, Android.Net.Uri arg1, Android.Accounts.Account arg2)
            {
                return SExecuteArray<byte>(LocalBridgeClazz, "get", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/SyncStateContract.Helpers.html#set(android.content.ContentProviderClient,android.net.Uri,android.accounts.Account,byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.ContentProviderClient"/></param>
            /// <param name="arg1"><see cref="Android.Net.Uri"/></param>
            /// <param name="arg2"><see cref="Android.Accounts.Account"/></param>
            /// <param name="arg3"><see cref="byte"/></param>
            /// <exception cref="Android.Os.RemoteException"/>
            public static void Set(Android.Content.ContentProviderClient arg0, Android.Net.Uri arg1, Android.Accounts.Account arg2, byte[] arg3)
            {
                SExecute(LocalBridgeClazz, "set", arg0, arg1, arg2, arg3);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/SyncStateContract.Helpers.html#update(android.content.ContentProviderClient,android.net.Uri,byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.ContentProviderClient"/></param>
            /// <param name="arg1"><see cref="Android.Net.Uri"/></param>
            /// <param name="arg2"><see cref="byte"/></param>
            /// <exception cref="Android.Os.RemoteException"/>
            public static void Update(Android.Content.ContentProviderClient arg0, Android.Net.Uri arg1, byte[] arg2)
            {
                SExecute(LocalBridgeClazz, "update", arg0, arg1, arg2);
            }

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