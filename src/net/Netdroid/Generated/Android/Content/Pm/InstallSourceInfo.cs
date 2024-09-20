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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Content.Pm
{
    #region InstallSourceInfo
    public partial class InstallSourceInfo
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/InstallSourceInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/InstallSourceInfo.html#getInitiatingPackageSigningInfo()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Pm.SigningInfo"/></returns>
        public Android.Content.Pm.SigningInfo GetInitiatingPackageSigningInfo()
        {
            return IExecuteWithSignature<Android.Content.Pm.SigningInfo>("getInitiatingPackageSigningInfo", "()Landroid/content/pm/SigningInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/InstallSourceInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/InstallSourceInfo.html#getPackageSource()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPackageSource()
        {
            return IExecuteWithSignature<int>("getPackageSource", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/InstallSourceInfo.html#getInitiatingPackageName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetInitiatingPackageName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getInitiatingPackageName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/InstallSourceInfo.html#getInstallingPackageName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetInstallingPackageName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getInstallingPackageName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/InstallSourceInfo.html#getOriginatingPackageName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetOriginatingPackageName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getOriginatingPackageName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/InstallSourceInfo.html#getUpdateOwnerPackageName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetUpdateOwnerPackageName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getUpdateOwnerPackageName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/InstallSourceInfo.html#writeToParcel(android.os.Parcel,int)"/>
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