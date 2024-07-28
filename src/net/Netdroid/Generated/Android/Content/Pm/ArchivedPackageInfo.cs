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

namespace Android.Content.Pm
{
    #region ArchivedPackageInfo
    public partial class ArchivedPackageInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ArchivedPackageInfo.html#%3Cinit%3E(java.lang.String,android.content.pm.SigningInfo,java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Content.Pm.SigningInfo"/></param>
        /// <param name="arg2"><see cref="Java.Util.List"/></param>
        public ArchivedPackageInfo(Java.Lang.String arg0, Android.Content.Pm.SigningInfo arg1, Java.Util.List<Android.Content.Pm.ArchivedActivityInfo> arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ArchivedPackageInfo.html#setDefaultToDeviceProtectedStorage(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Content.Pm.ArchivedPackageInfo"/></returns>
        public Android.Content.Pm.ArchivedPackageInfo SetDefaultToDeviceProtectedStorage(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Content.Pm.ArchivedPackageInfo>("setDefaultToDeviceProtectedStorage", "(Ljava/lang/String;)Landroid/content/pm/ArchivedPackageInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ArchivedPackageInfo.html#setLauncherActivities(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Android.Content.Pm.ArchivedPackageInfo"/></returns>
        public Android.Content.Pm.ArchivedPackageInfo SetLauncherActivities(Java.Util.List<Android.Content.Pm.ArchivedActivityInfo> arg0)
        {
            return IExecuteWithSignature<Android.Content.Pm.ArchivedPackageInfo>("setLauncherActivities", "(Ljava/util/List;)Landroid/content/pm/ArchivedPackageInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ArchivedPackageInfo.html#setPackageName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Content.Pm.ArchivedPackageInfo"/></returns>
        public Android.Content.Pm.ArchivedPackageInfo SetPackageName(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Content.Pm.ArchivedPackageInfo>("setPackageName", "(Ljava/lang/String;)Landroid/content/pm/ArchivedPackageInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ArchivedPackageInfo.html#setRequestLegacyExternalStorage(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Content.Pm.ArchivedPackageInfo"/></returns>
        public Android.Content.Pm.ArchivedPackageInfo SetRequestLegacyExternalStorage(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Content.Pm.ArchivedPackageInfo>("setRequestLegacyExternalStorage", "(Ljava/lang/String;)Landroid/content/pm/ArchivedPackageInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ArchivedPackageInfo.html#setSigningInfo(android.content.pm.SigningInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Pm.SigningInfo"/></param>
        /// <returns><see cref="Android.Content.Pm.ArchivedPackageInfo"/></returns>
        public Android.Content.Pm.ArchivedPackageInfo SetSigningInfo(Android.Content.Pm.SigningInfo arg0)
        {
            return IExecuteWithSignature<Android.Content.Pm.ArchivedPackageInfo>("setSigningInfo", "(Landroid/content/pm/SigningInfo;)Landroid/content/pm/ArchivedPackageInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ArchivedPackageInfo.html#setTargetSdkVersion(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Content.Pm.ArchivedPackageInfo"/></returns>
        public Android.Content.Pm.ArchivedPackageInfo SetTargetSdkVersion(int arg0)
        {
            return IExecuteWithSignature<Android.Content.Pm.ArchivedPackageInfo>("setTargetSdkVersion", "(I)Landroid/content/pm/ArchivedPackageInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ArchivedPackageInfo.html#setUserDataFragile(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Content.Pm.ArchivedPackageInfo"/></returns>
        public Android.Content.Pm.ArchivedPackageInfo SetUserDataFragile(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Content.Pm.ArchivedPackageInfo>("setUserDataFragile", "(Ljava/lang/String;)Landroid/content/pm/ArchivedPackageInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ArchivedPackageInfo.html#setVersionCode(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Content.Pm.ArchivedPackageInfo"/></returns>
        public Android.Content.Pm.ArchivedPackageInfo SetVersionCode(int arg0)
        {
            return IExecuteWithSignature<Android.Content.Pm.ArchivedPackageInfo>("setVersionCode", "(I)Landroid/content/pm/ArchivedPackageInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ArchivedPackageInfo.html#setVersionCodeMajor(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Content.Pm.ArchivedPackageInfo"/></returns>
        public Android.Content.Pm.ArchivedPackageInfo SetVersionCodeMajor(int arg0)
        {
            return IExecuteWithSignature<Android.Content.Pm.ArchivedPackageInfo>("setVersionCodeMajor", "(I)Landroid/content/pm/ArchivedPackageInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ArchivedPackageInfo.html#getSigningInfo()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Pm.SigningInfo"/></returns>
        public Android.Content.Pm.SigningInfo GetSigningInfo()
        {
            return IExecuteWithSignature<Android.Content.Pm.SigningInfo>("getSigningInfo", "()Landroid/content/pm/SigningInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ArchivedPackageInfo.html#getTargetSdkVersion()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTargetSdkVersion()
        {
            return IExecuteWithSignature<int>("getTargetSdkVersion", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ArchivedPackageInfo.html#getVersionCode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetVersionCode()
        {
            return IExecuteWithSignature<int>("getVersionCode", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ArchivedPackageInfo.html#getVersionCodeMajor()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetVersionCodeMajor()
        {
            return IExecuteWithSignature<int>("getVersionCodeMajor", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ArchivedPackageInfo.html#getDefaultToDeviceProtectedStorage()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDefaultToDeviceProtectedStorage()
        {
            return IExecuteWithSignature<Java.Lang.String>("getDefaultToDeviceProtectedStorage", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ArchivedPackageInfo.html#getPackageName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPackageName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPackageName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ArchivedPackageInfo.html#getRequestLegacyExternalStorage()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetRequestLegacyExternalStorage()
        {
            return IExecuteWithSignature<Java.Lang.String>("getRequestLegacyExternalStorage", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ArchivedPackageInfo.html#getUserDataFragile()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetUserDataFragile()
        {
            return IExecuteWithSignature<Java.Lang.String>("getUserDataFragile", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ArchivedPackageInfo.html#getLauncherActivities()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Content.Pm.ArchivedActivityInfo> GetLauncherActivities()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Content.Pm.ArchivedActivityInfo>>("getLauncherActivities", "()Ljava/util/List;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}