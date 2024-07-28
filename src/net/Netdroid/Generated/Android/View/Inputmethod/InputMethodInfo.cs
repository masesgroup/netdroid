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

namespace Android.View.Inputmethod
{
    #region InputMethodInfo
    public partial class InputMethodInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodInfo.html#%3Cinit%3E(android.content.Context,android.content.pm.ResolveInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Content.Pm.ResolveInfo"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Org.Xmlpull.V1.XmlPullParserException"/>
        public InputMethodInfo(Android.Content.Context arg0, Android.Content.Pm.ResolveInfo arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodInfo.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.CharSequence,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        public InputMethodInfo(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.CharSequence arg2, Java.Lang.String arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodInfo.html#ACTION_STYLUS_HANDWRITING_SETTINGS"/>
        /// </summary>
        public static Java.Lang.String ACTION_STYLUS_HANDWRITING_SETTINGS { get { if (!_ACTION_STYLUS_HANDWRITING_SETTINGSReady) { _ACTION_STYLUS_HANDWRITING_SETTINGSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_STYLUS_HANDWRITING_SETTINGS"); _ACTION_STYLUS_HANDWRITING_SETTINGSReady = true; } return _ACTION_STYLUS_HANDWRITING_SETTINGSContent; } }
        private static Java.Lang.String _ACTION_STYLUS_HANDWRITING_SETTINGSContent = default;
        private static bool _ACTION_STYLUS_HANDWRITING_SETTINGSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodInfo.html#getComponent()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.ComponentName"/></returns>
        public Android.Content.ComponentName GetComponent()
        {
            return IExecuteWithSignature<Android.Content.ComponentName>("getComponent", "()Landroid/content/ComponentName;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodInfo.html#createStylusHandwritingSettingsActivityIntent()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Intent"/></returns>
        public Android.Content.Intent CreateStylusHandwritingSettingsActivityIntent()
        {
            return IExecuteWithSignature<Android.Content.Intent>("createStylusHandwritingSettingsActivityIntent", "()Landroid/content/Intent;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodInfo.html#getServiceInfo()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Pm.ServiceInfo"/></returns>
        public Android.Content.Pm.ServiceInfo GetServiceInfo()
        {
            return IExecuteWithSignature<Android.Content.Pm.ServiceInfo>("getServiceInfo", "()Landroid/content/pm/ServiceInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodInfo.html#loadIcon(android.content.pm.PackageManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Pm.PackageManager"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable LoadIcon(Android.Content.Pm.PackageManager arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodInfo.html#getSubtypeAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.View.Inputmethod.InputMethodSubtype"/></returns>
        public Android.View.Inputmethod.InputMethodSubtype GetSubtypeAt(int arg0)
        {
            return IExecuteWithSignature<Android.View.Inputmethod.InputMethodSubtype>("getSubtypeAt", "(I)Landroid/view/inputmethod/InputMethodSubtype;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodInfo.html#shouldShowInInputMethodPicker()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool ShouldShowInInputMethodPicker()
        {
            return IExecuteWithSignature<bool>("shouldShowInInputMethodPicker", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodInfo.html#supportsConnectionlessStylusHandwriting()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool SupportsConnectionlessStylusHandwriting()
        {
            return IExecuteWithSignature<bool>("supportsConnectionlessStylusHandwriting", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodInfo.html#supportsStylusHandwriting()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool SupportsStylusHandwriting()
        {
            return IExecuteWithSignature<bool>("supportsStylusHandwriting", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodInfo.html#suppressesSpellChecker()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool SuppressesSpellChecker()
        {
            return IExecuteWithSignature<bool>("suppressesSpellChecker", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodInfo.html#getConfigChanges()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetConfigChanges()
        {
            return IExecuteWithSignature<int>("getConfigChanges", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodInfo.html#getIsDefaultResourceId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetIsDefaultResourceId()
        {
            return IExecuteWithSignature<int>("getIsDefaultResourceId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodInfo.html#getSubtypeCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSubtypeCount()
        {
            return IExecuteWithSignature<int>("getSubtypeCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodInfo.html#loadLabel(android.content.pm.PackageManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Pm.PackageManager"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence LoadLabel(Android.Content.Pm.PackageManager arg0)
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodInfo.html#getId()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetId()
        {
            return IExecuteWithSignature<Java.Lang.String>("getId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodInfo.html#getPackageName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPackageName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPackageName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodInfo.html#getServiceName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetServiceName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getServiceName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodInfo.html#getSettingsActivity()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSettingsActivity()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSettingsActivity", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodInfo.html#dump(android.util.Printer,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Util.Printer"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void Dump(Android.Util.Printer arg0, Java.Lang.String arg1)
        {
            IExecute("dump", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodInfo.html#writeToParcel(android.os.Parcel,int)"/>
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