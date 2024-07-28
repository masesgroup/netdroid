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

namespace Android.View.Textservice
{
    #region SpellCheckerInfo
    public partial class SpellCheckerInfo
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerInfo.html#getComponent()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.ComponentName"/></returns>
        public Android.Content.ComponentName GetComponent()
        {
            return IExecuteWithSignature<Android.Content.ComponentName>("getComponent", "()Landroid/content/ComponentName;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerInfo.html#getServiceInfo()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Pm.ServiceInfo"/></returns>
        public Android.Content.Pm.ServiceInfo GetServiceInfo()
        {
            return IExecuteWithSignature<Android.Content.Pm.ServiceInfo>("getServiceInfo", "()Landroid/content/pm/ServiceInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerInfo.html#loadIcon(android.content.pm.PackageManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Pm.PackageManager"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable LoadIcon(Android.Content.Pm.PackageManager arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerInfo.html#getSubtypeAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.View.Textservice.SpellCheckerSubtype"/></returns>
        public Android.View.Textservice.SpellCheckerSubtype GetSubtypeAt(int arg0)
        {
            return IExecuteWithSignature<Android.View.Textservice.SpellCheckerSubtype>("getSubtypeAt", "(I)Landroid/view/textservice/SpellCheckerSubtype;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerInfo.html#getSubtypeCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSubtypeCount()
        {
            return IExecuteWithSignature<int>("getSubtypeCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerInfo.html#loadLabel(android.content.pm.PackageManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Pm.PackageManager"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence LoadLabel(Android.Content.Pm.PackageManager arg0)
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerInfo.html#getId()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetId()
        {
            return IExecuteWithSignature<Java.Lang.String>("getId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerInfo.html#getPackageName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPackageName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPackageName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerInfo.html#getSettingsActivity()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSettingsActivity()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSettingsActivity", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SpellCheckerInfo.html#writeToParcel(android.os.Parcel,int)"/>
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