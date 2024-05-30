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

namespace Android.Content.Pm
{
    #region PermissionGroupInfo
    public partial class PermissionGroupInfo
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Content.Pm.PermissionGroupInfo"/> to <see cref="Android.Os.Parcelable"/>
        /// </summary>
        public static implicit operator Android.Os.Parcelable(Android.Content.Pm.PermissionGroupInfo t) => t.Cast<Android.Os.Parcelable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionGroupInfo.html#descriptionRes"/>
        /// </summary>
        public int descriptionRes { get { return IGetField<int>("descriptionRes"); } set { ISetField("descriptionRes", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionGroupInfo.html#flags"/>
        /// </summary>
        public int flags { get { return IGetField<int>("flags"); } set { ISetField("flags", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionGroupInfo.html#priority"/>
        /// </summary>
        public int priority { get { return IGetField<int>("priority"); } set { ISetField("priority", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionGroupInfo.html#nonLocalizedDescription"/>
        /// </summary>
        public Java.Lang.CharSequence nonLocalizedDescription { get { return IGetField<Java.Lang.CharSequence>("nonLocalizedDescription"); } set { ISetField("nonLocalizedDescription", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionGroupInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionGroupInfo.html#FLAG_PERSONAL_INFO"/>
        /// </summary>
        public static int FLAG_PERSONAL_INFO { get { if (!_FLAG_PERSONAL_INFOReady) { _FLAG_PERSONAL_INFOContent = SGetField<int>(LocalBridgeClazz, "FLAG_PERSONAL_INFO"); _FLAG_PERSONAL_INFOReady = true; } return _FLAG_PERSONAL_INFOContent; } }
        private static int _FLAG_PERSONAL_INFOContent = default;
        private static bool _FLAG_PERSONAL_INFOReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionGroupInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionGroupInfo.html#loadDescription(android.content.pm.PackageManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Pm.PackageManager"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence LoadDescription(Android.Content.Pm.PackageManager arg0)
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}