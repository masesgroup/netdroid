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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.App.Backup
{
    #region IBackupHelper
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IBackupHelper
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BackupHelper
    public partial class BackupHelper : Android.App.Backup.IBackupHelper
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
        /// <see href="https://developer.android.com/reference/android/app/backup/BackupHelper.html#performBackup(android.os.ParcelFileDescriptor,android.app.backup.BackupDataOutput,android.os.ParcelFileDescriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.ParcelFileDescriptor"/></param>
        /// <param name="arg1"><see cref="Android.App.Backup.BackupDataOutput"/></param>
        /// <param name="arg2"><see cref="Android.Os.ParcelFileDescriptor"/></param>
        public void PerformBackup(Android.Os.ParcelFileDescriptor arg0, Android.App.Backup.BackupDataOutput arg1, Android.Os.ParcelFileDescriptor arg2)
        {
            IExecute("performBackup", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/backup/BackupHelper.html#restoreEntity(android.app.backup.BackupDataInputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Backup.BackupDataInputStream"/></param>
        public void RestoreEntity(Android.App.Backup.BackupDataInputStream arg0)
        {
            IExecuteWithSignature("restoreEntity", "(Landroid/app/backup/BackupDataInputStream;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/backup/BackupHelper.html#writeNewStateDescription(android.os.ParcelFileDescriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.ParcelFileDescriptor"/></param>
        public void WriteNewStateDescription(Android.Os.ParcelFileDescriptor arg0)
        {
            IExecuteWithSignature("writeNewStateDescription", "(Landroid/os/ParcelFileDescriptor;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}