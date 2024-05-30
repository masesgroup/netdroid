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

namespace Android.App.Backup
{
    #region BackupAgent
    public partial class BackupAgent
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/backup/BackupAgent.html#FLAG_CLIENT_SIDE_ENCRYPTION_ENABLED"/>
        /// </summary>
        public static int FLAG_CLIENT_SIDE_ENCRYPTION_ENABLED { get { if (!_FLAG_CLIENT_SIDE_ENCRYPTION_ENABLEDReady) { _FLAG_CLIENT_SIDE_ENCRYPTION_ENABLEDContent = SGetField<int>(LocalBridgeClazz, "FLAG_CLIENT_SIDE_ENCRYPTION_ENABLED"); _FLAG_CLIENT_SIDE_ENCRYPTION_ENABLEDReady = true; } return _FLAG_CLIENT_SIDE_ENCRYPTION_ENABLEDContent; } }
        private static int _FLAG_CLIENT_SIDE_ENCRYPTION_ENABLEDContent = default;
        private static bool _FLAG_CLIENT_SIDE_ENCRYPTION_ENABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/backup/BackupAgent.html#FLAG_DEVICE_TO_DEVICE_TRANSFER"/>
        /// </summary>
        public static int FLAG_DEVICE_TO_DEVICE_TRANSFER { get { if (!_FLAG_DEVICE_TO_DEVICE_TRANSFERReady) { _FLAG_DEVICE_TO_DEVICE_TRANSFERContent = SGetField<int>(LocalBridgeClazz, "FLAG_DEVICE_TO_DEVICE_TRANSFER"); _FLAG_DEVICE_TO_DEVICE_TRANSFERReady = true; } return _FLAG_DEVICE_TO_DEVICE_TRANSFERContent; } }
        private static int _FLAG_DEVICE_TO_DEVICE_TRANSFERContent = default;
        private static bool _FLAG_DEVICE_TO_DEVICE_TRANSFERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/backup/BackupAgent.html#TYPE_DIRECTORY"/>
        /// </summary>
        public static int TYPE_DIRECTORY { get { if (!_TYPE_DIRECTORYReady) { _TYPE_DIRECTORYContent = SGetField<int>(LocalBridgeClazz, "TYPE_DIRECTORY"); _TYPE_DIRECTORYReady = true; } return _TYPE_DIRECTORYContent; } }
        private static int _TYPE_DIRECTORYContent = default;
        private static bool _TYPE_DIRECTORYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/backup/BackupAgent.html#TYPE_FILE"/>
        /// </summary>
        public static int TYPE_FILE { get { if (!_TYPE_FILEReady) { _TYPE_FILEContent = SGetField<int>(LocalBridgeClazz, "TYPE_FILE"); _TYPE_FILEReady = true; } return _TYPE_FILEContent; } }
        private static int _TYPE_FILEContent = default;
        private static bool _TYPE_FILEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/backup/BackupAgent.html#onBackup(android.os.ParcelFileDescriptor,android.app.backup.BackupDataOutput,android.os.ParcelFileDescriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.ParcelFileDescriptor"/></param>
        /// <param name="arg1"><see cref="Android.App.Backup.BackupDataOutput"/></param>
        /// <param name="arg2"><see cref="Android.Os.ParcelFileDescriptor"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void OnBackup(Android.Os.ParcelFileDescriptor arg0, Android.App.Backup.BackupDataOutput arg1, Android.Os.ParcelFileDescriptor arg2)
        {
            IExecute("onBackup", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/backup/BackupAgent.html#onRestore(android.app.backup.BackupDataInput,int,android.os.ParcelFileDescriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Backup.BackupDataInput"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Os.ParcelFileDescriptor"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void OnRestore(Android.App.Backup.BackupDataInput arg0, int arg1, Android.Os.ParcelFileDescriptor arg2)
        {
            IExecute("onRestore", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/backup/BackupAgent.html#fullBackupFile(java.io.File,android.app.backup.FullBackupDataOutput)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see cref="Android.App.Backup.FullBackupDataOutput"/></param>
        public void FullBackupFile(Java.Io.File arg0, Android.App.Backup.FullBackupDataOutput arg1)
        {
            IExecute("fullBackupFile", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/backup/BackupAgent.html#onCreate()"/>
        /// </summary>
        public void OnCreate()
        {
            IExecuteWithSignature("onCreate", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/backup/BackupAgent.html#onDestroy()"/>
        /// </summary>
        public void OnDestroy()
        {
            IExecuteWithSignature("onDestroy", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/backup/BackupAgent.html#onFullBackup(android.app.backup.FullBackupDataOutput)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Backup.FullBackupDataOutput"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void OnFullBackup(Android.App.Backup.FullBackupDataOutput arg0)
        {
            IExecuteWithSignature("onFullBackup", "(Landroid/app/backup/FullBackupDataOutput;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/backup/BackupAgent.html#onQuotaExceeded(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public void OnQuotaExceeded(long arg0, long arg1)
        {
            IExecute("onQuotaExceeded", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/backup/BackupAgent.html#onRestore(android.app.backup.BackupDataInput,long,android.os.ParcelFileDescriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Backup.BackupDataInput"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Android.Os.ParcelFileDescriptor"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void OnRestore(Android.App.Backup.BackupDataInput arg0, long arg1, Android.Os.ParcelFileDescriptor arg2)
        {
            IExecute("onRestore", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/backup/BackupAgent.html#onRestoreFile(android.os.ParcelFileDescriptor,long,java.io.File,int,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.ParcelFileDescriptor"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Io.File"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        /// <param name="arg5"><see cref="long"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void OnRestoreFile(Android.Os.ParcelFileDescriptor arg0, long arg1, Java.Io.File arg2, int arg3, long arg4, long arg5)
        {
            IExecute("onRestoreFile", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/backup/BackupAgent.html#onRestoreFinished()"/>
        /// </summary>
        public void OnRestoreFinished()
        {
            IExecuteWithSignature("onRestoreFinished", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}