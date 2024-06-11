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

namespace Android.Content.Pm
{
    #region ShortcutInfo
    public partial class ShortcutInfo
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#DISABLED_REASON_APP_CHANGED"/>
        /// </summary>
        public static int DISABLED_REASON_APP_CHANGED { get { if (!_DISABLED_REASON_APP_CHANGEDReady) { _DISABLED_REASON_APP_CHANGEDContent = SGetField<int>(LocalBridgeClazz, "DISABLED_REASON_APP_CHANGED"); _DISABLED_REASON_APP_CHANGEDReady = true; } return _DISABLED_REASON_APP_CHANGEDContent; } }
        private static int _DISABLED_REASON_APP_CHANGEDContent = default;
        private static bool _DISABLED_REASON_APP_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#DISABLED_REASON_BACKUP_NOT_SUPPORTED"/>
        /// </summary>
        public static int DISABLED_REASON_BACKUP_NOT_SUPPORTED { get { if (!_DISABLED_REASON_BACKUP_NOT_SUPPORTEDReady) { _DISABLED_REASON_BACKUP_NOT_SUPPORTEDContent = SGetField<int>(LocalBridgeClazz, "DISABLED_REASON_BACKUP_NOT_SUPPORTED"); _DISABLED_REASON_BACKUP_NOT_SUPPORTEDReady = true; } return _DISABLED_REASON_BACKUP_NOT_SUPPORTEDContent; } }
        private static int _DISABLED_REASON_BACKUP_NOT_SUPPORTEDContent = default;
        private static bool _DISABLED_REASON_BACKUP_NOT_SUPPORTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#DISABLED_REASON_BY_APP"/>
        /// </summary>
        public static int DISABLED_REASON_BY_APP { get { if (!_DISABLED_REASON_BY_APPReady) { _DISABLED_REASON_BY_APPContent = SGetField<int>(LocalBridgeClazz, "DISABLED_REASON_BY_APP"); _DISABLED_REASON_BY_APPReady = true; } return _DISABLED_REASON_BY_APPContent; } }
        private static int _DISABLED_REASON_BY_APPContent = default;
        private static bool _DISABLED_REASON_BY_APPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#DISABLED_REASON_NOT_DISABLED"/>
        /// </summary>
        public static int DISABLED_REASON_NOT_DISABLED { get { if (!_DISABLED_REASON_NOT_DISABLEDReady) { _DISABLED_REASON_NOT_DISABLEDContent = SGetField<int>(LocalBridgeClazz, "DISABLED_REASON_NOT_DISABLED"); _DISABLED_REASON_NOT_DISABLEDReady = true; } return _DISABLED_REASON_NOT_DISABLEDContent; } }
        private static int _DISABLED_REASON_NOT_DISABLEDContent = default;
        private static bool _DISABLED_REASON_NOT_DISABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#DISABLED_REASON_OTHER_RESTORE_ISSUE"/>
        /// </summary>
        public static int DISABLED_REASON_OTHER_RESTORE_ISSUE { get { if (!_DISABLED_REASON_OTHER_RESTORE_ISSUEReady) { _DISABLED_REASON_OTHER_RESTORE_ISSUEContent = SGetField<int>(LocalBridgeClazz, "DISABLED_REASON_OTHER_RESTORE_ISSUE"); _DISABLED_REASON_OTHER_RESTORE_ISSUEReady = true; } return _DISABLED_REASON_OTHER_RESTORE_ISSUEContent; } }
        private static int _DISABLED_REASON_OTHER_RESTORE_ISSUEContent = default;
        private static bool _DISABLED_REASON_OTHER_RESTORE_ISSUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#DISABLED_REASON_SIGNATURE_MISMATCH"/>
        /// </summary>
        public static int DISABLED_REASON_SIGNATURE_MISMATCH { get { if (!_DISABLED_REASON_SIGNATURE_MISMATCHReady) { _DISABLED_REASON_SIGNATURE_MISMATCHContent = SGetField<int>(LocalBridgeClazz, "DISABLED_REASON_SIGNATURE_MISMATCH"); _DISABLED_REASON_SIGNATURE_MISMATCHReady = true; } return _DISABLED_REASON_SIGNATURE_MISMATCHContent; } }
        private static int _DISABLED_REASON_SIGNATURE_MISMATCHContent = default;
        private static bool _DISABLED_REASON_SIGNATURE_MISMATCHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#DISABLED_REASON_UNKNOWN"/>
        /// </summary>
        public static int DISABLED_REASON_UNKNOWN { get { if (!_DISABLED_REASON_UNKNOWNReady) { _DISABLED_REASON_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "DISABLED_REASON_UNKNOWN"); _DISABLED_REASON_UNKNOWNReady = true; } return _DISABLED_REASON_UNKNOWNContent; } }
        private static int _DISABLED_REASON_UNKNOWNContent = default;
        private static bool _DISABLED_REASON_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#DISABLED_REASON_VERSION_LOWER"/>
        /// </summary>
        public static int DISABLED_REASON_VERSION_LOWER { get { if (!_DISABLED_REASON_VERSION_LOWERReady) { _DISABLED_REASON_VERSION_LOWERContent = SGetField<int>(LocalBridgeClazz, "DISABLED_REASON_VERSION_LOWER"); _DISABLED_REASON_VERSION_LOWERReady = true; } return _DISABLED_REASON_VERSION_LOWERContent; } }
        private static int _DISABLED_REASON_VERSION_LOWERContent = default;
        private static bool _DISABLED_REASON_VERSION_LOWERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#SURFACE_LAUNCHER"/>
        /// </summary>
        public static int SURFACE_LAUNCHER { get { if (!_SURFACE_LAUNCHERReady) { _SURFACE_LAUNCHERContent = SGetField<int>(LocalBridgeClazz, "SURFACE_LAUNCHER"); _SURFACE_LAUNCHERReady = true; } return _SURFACE_LAUNCHERContent; } }
        private static int _SURFACE_LAUNCHERContent = default;
        private static bool _SURFACE_LAUNCHERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#SHORTCUT_CATEGORY_CONVERSATION"/>
        /// </summary>
        public static Java.Lang.String SHORTCUT_CATEGORY_CONVERSATION { get { if (!_SHORTCUT_CATEGORY_CONVERSATIONReady) { _SHORTCUT_CATEGORY_CONVERSATIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SHORTCUT_CATEGORY_CONVERSATION"); _SHORTCUT_CATEGORY_CONVERSATIONReady = true; } return _SHORTCUT_CATEGORY_CONVERSATIONContent; } }
        private static Java.Lang.String _SHORTCUT_CATEGORY_CONVERSATIONContent = default;
        private static bool _SHORTCUT_CATEGORY_CONVERSATIONReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#createFromGenericDocument(android.content.Context,android.app.appsearch.GenericDocument)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.App.Appsearch.GenericDocument"/></param>
        /// <returns><see cref="Android.Content.Pm.ShortcutInfo"/></returns>
        public static Android.Content.Pm.ShortcutInfo CreateFromGenericDocument(Android.Content.Context arg0, Android.App.Appsearch.GenericDocument arg1)
        {
            return SExecute<Android.Content.Pm.ShortcutInfo>(LocalBridgeClazz, "createFromGenericDocument", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#getActivity()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.ComponentName"/></returns>
        public Android.Content.ComponentName GetActivity()
        {
            return IExecuteWithSignature<Android.Content.ComponentName>("getActivity", "()Landroid/content/ComponentName;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#getIntent()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Intent"/></returns>
        public Android.Content.Intent GetIntent()
        {
            return IExecuteWithSignature<Android.Content.Intent>("getIntent", "()Landroid/content/Intent;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#getIntents()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Intent"/></returns>
        public Android.Content.Intent[] GetIntents()
        {
            return IExecuteWithSignatureArray<Android.Content.Intent>("getIntents", "()[Landroid/content/Intent;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#getLocusId()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.LocusId"/></returns>
        public Android.Content.LocusId GetLocusId()
        {
            return IExecuteWithSignature<Android.Content.LocusId>("getLocusId", "()Landroid/content/LocusId;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#getExtras()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.PersistableBundle"/></returns>
        public Android.Os.PersistableBundle GetExtras()
        {
            return IExecuteWithSignature<Android.Os.PersistableBundle>("getExtras", "()Landroid/os/PersistableBundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#getUserHandle()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.UserHandle"/></returns>
        public Android.Os.UserHandle GetUserHandle()
        {
            return IExecuteWithSignature<Android.Os.UserHandle>("getUserHandle", "()Landroid/os/UserHandle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#hasKeyFieldsOnly()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasKeyFieldsOnly()
        {
            return IExecuteWithSignature<bool>("hasKeyFieldsOnly", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#isCached()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCached()
        {
            return IExecuteWithSignature<bool>("isCached", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#isDeclaredInManifest()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDeclaredInManifest()
        {
            return IExecuteWithSignature<bool>("isDeclaredInManifest", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#isDynamic()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDynamic()
        {
            return IExecuteWithSignature<bool>("isDynamic", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#isEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEnabled()
        {
            return IExecuteWithSignature<bool>("isEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#isExcludedFromSurfaces(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsExcludedFromSurfaces(int arg0)
        {
            return IExecuteWithSignature<bool>("isExcludedFromSurfaces", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#isImmutable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsImmutable()
        {
            return IExecuteWithSignature<bool>("isImmutable", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#isPinned()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPinned()
        {
            return IExecuteWithSignature<bool>("isPinned", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#getDisabledReason()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDisabledReason()
        {
            return IExecuteWithSignature<int>("getDisabledReason", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#getExcludedFromSurfaces()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetExcludedFromSurfaces()
        {
            return IExecuteWithSignature<int>("getExcludedFromSurfaces", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#getRank()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetRank()
        {
            return IExecuteWithSignature<int>("getRank", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#getDisabledMessage()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetDisabledMessage()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getDisabledMessage", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#getLongLabel()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetLongLabel()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getLongLabel", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#getShortLabel()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetShortLabel()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getShortLabel", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#getId()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetId()
        {
            return IExecuteWithSignature<Java.Lang.String>("getId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#getPackage()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPackage()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPackage", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#getCapabilities()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Content.Pm.Capability> GetCapabilities()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Content.Pm.Capability>>("getCapabilities", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#getCapabilityParams(android.content.pm.Capability)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Pm.Capability"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Content.Pm.CapabilityParams> GetCapabilityParams(Android.Content.Pm.Capability arg0)
        {
            return IExecuteWithSignature<Java.Util.List<Android.Content.Pm.CapabilityParams>>("getCapabilityParams", "(Landroid/content/pm/Capability;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#getCategories()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> GetCategories()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getCategories", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#getLastChangedTimestamp()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetLastChangedTimestamp()
        {
            return IExecuteWithSignature<long>("getLastChangedTimestamp", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.Builder.html#%3Cinit%3E(android.content.Context,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Context"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            public Builder(Android.Content.Context arg0, Java.Lang.String arg1)
                : base(arg0, arg1)
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
            /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Content.Pm.ShortcutInfo"/></returns>
            public Android.Content.Pm.ShortcutInfo Build()
            {
                return IExecuteWithSignature<Android.Content.Pm.ShortcutInfo>("build", "()Landroid/content/pm/ShortcutInfo;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.Builder.html#addCapabilityBinding(android.content.pm.Capability,android.content.pm.CapabilityParams)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Pm.Capability"/></param>
            /// <param name="arg1"><see cref="Android.Content.Pm.CapabilityParams"/></param>
            /// <returns><see cref="Android.Content.Pm.ShortcutInfo.Builder"/></returns>
            public Android.Content.Pm.ShortcutInfo.Builder AddCapabilityBinding(Android.Content.Pm.Capability arg0, Android.Content.Pm.CapabilityParams arg1)
            {
                return IExecute<Android.Content.Pm.ShortcutInfo.Builder>("addCapabilityBinding", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.Builder.html#setActivity(android.content.ComponentName)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
            /// <returns><see cref="Android.Content.Pm.ShortcutInfo.Builder"/></returns>
            public Android.Content.Pm.ShortcutInfo.Builder SetActivity(Android.Content.ComponentName arg0)
            {
                return IExecuteWithSignature<Android.Content.Pm.ShortcutInfo.Builder>("setActivity", "(Landroid/content/ComponentName;)Landroid/content/pm/ShortcutInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.Builder.html#setCategories(java.util.Set)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Set"/></param>
            /// <returns><see cref="Android.Content.Pm.ShortcutInfo.Builder"/></returns>
            public Android.Content.Pm.ShortcutInfo.Builder SetCategories(Java.Util.Set<Java.Lang.String> arg0)
            {
                return IExecuteWithSignature<Android.Content.Pm.ShortcutInfo.Builder>("setCategories", "(Ljava/util/Set;)Landroid/content/pm/ShortcutInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.Builder.html#setDisabledMessage(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.Content.Pm.ShortcutInfo.Builder"/></returns>
            public Android.Content.Pm.ShortcutInfo.Builder SetDisabledMessage(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<Android.Content.Pm.ShortcutInfo.Builder>("setDisabledMessage", "(Ljava/lang/CharSequence;)Landroid/content/pm/ShortcutInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.Builder.html#setExcludedFromSurfaces(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Content.Pm.ShortcutInfo.Builder"/></returns>
            public Android.Content.Pm.ShortcutInfo.Builder SetExcludedFromSurfaces(int arg0)
            {
                return IExecuteWithSignature<Android.Content.Pm.ShortcutInfo.Builder>("setExcludedFromSurfaces", "(I)Landroid/content/pm/ShortcutInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.Builder.html#setExtras(android.os.PersistableBundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.PersistableBundle"/></param>
            /// <returns><see cref="Android.Content.Pm.ShortcutInfo.Builder"/></returns>
            public Android.Content.Pm.ShortcutInfo.Builder SetExtras(Android.Os.PersistableBundle arg0)
            {
                return IExecuteWithSignature<Android.Content.Pm.ShortcutInfo.Builder>("setExtras", "(Landroid/os/PersistableBundle;)Landroid/content/pm/ShortcutInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.Builder.html#setIcon(android.graphics.drawable.Icon)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Drawable.Icon"/></param>
            /// <returns><see cref="Android.Content.Pm.ShortcutInfo.Builder"/></returns>
            public Android.Content.Pm.ShortcutInfo.Builder SetIcon(Android.Graphics.Drawable.Icon arg0)
            {
                return IExecuteWithSignature<Android.Content.Pm.ShortcutInfo.Builder>("setIcon", "(Landroid/graphics/drawable/Icon;)Landroid/content/pm/ShortcutInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.Builder.html#setIntent(android.content.Intent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
            /// <returns><see cref="Android.Content.Pm.ShortcutInfo.Builder"/></returns>
            public Android.Content.Pm.ShortcutInfo.Builder SetIntent(Android.Content.Intent arg0)
            {
                return IExecuteWithSignature<Android.Content.Pm.ShortcutInfo.Builder>("setIntent", "(Landroid/content/Intent;)Landroid/content/pm/ShortcutInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.Builder.html#setIntents(android.content.Intent[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
            /// <returns><see cref="Android.Content.Pm.ShortcutInfo.Builder"/></returns>
            public Android.Content.Pm.ShortcutInfo.Builder SetIntents(Android.Content.Intent[] arg0)
            {
                return IExecuteWithSignature<Android.Content.Pm.ShortcutInfo.Builder>("setIntents", "([Landroid/content/Intent;)Landroid/content/pm/ShortcutInfo$Builder;", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.Builder.html#setLocusId(android.content.LocusId)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.LocusId"/></param>
            /// <returns><see cref="Android.Content.Pm.ShortcutInfo.Builder"/></returns>
            public Android.Content.Pm.ShortcutInfo.Builder SetLocusId(Android.Content.LocusId arg0)
            {
                return IExecuteWithSignature<Android.Content.Pm.ShortcutInfo.Builder>("setLocusId", "(Landroid/content/LocusId;)Landroid/content/pm/ShortcutInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.Builder.html#setLongLabel(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.Content.Pm.ShortcutInfo.Builder"/></returns>
            public Android.Content.Pm.ShortcutInfo.Builder SetLongLabel(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<Android.Content.Pm.ShortcutInfo.Builder>("setLongLabel", "(Ljava/lang/CharSequence;)Landroid/content/pm/ShortcutInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.Builder.html#setLongLived(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Content.Pm.ShortcutInfo.Builder"/></returns>
            public Android.Content.Pm.ShortcutInfo.Builder SetLongLived(bool arg0)
            {
                return IExecuteWithSignature<Android.Content.Pm.ShortcutInfo.Builder>("setLongLived", "(Z)Landroid/content/pm/ShortcutInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.Builder.html#setPerson(android.app.Person)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.Person"/></param>
            /// <returns><see cref="Android.Content.Pm.ShortcutInfo.Builder"/></returns>
            public Android.Content.Pm.ShortcutInfo.Builder SetPerson(Android.App.Person arg0)
            {
                return IExecuteWithSignature<Android.Content.Pm.ShortcutInfo.Builder>("setPerson", "(Landroid/app/Person;)Landroid/content/pm/ShortcutInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.Builder.html#setPersons(android.app.Person[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.Person"/></param>
            /// <returns><see cref="Android.Content.Pm.ShortcutInfo.Builder"/></returns>
            public Android.Content.Pm.ShortcutInfo.Builder SetPersons(Android.App.Person[] arg0)
            {
                return IExecuteWithSignature<Android.Content.Pm.ShortcutInfo.Builder>("setPersons", "([Landroid/app/Person;)Landroid/content/pm/ShortcutInfo$Builder;", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.Builder.html#setRank(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Content.Pm.ShortcutInfo.Builder"/></returns>
            public Android.Content.Pm.ShortcutInfo.Builder SetRank(int arg0)
            {
                return IExecuteWithSignature<Android.Content.Pm.ShortcutInfo.Builder>("setRank", "(I)Landroid/content/pm/ShortcutInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.Builder.html#setShortLabel(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.Content.Pm.ShortcutInfo.Builder"/></returns>
            public Android.Content.Pm.ShortcutInfo.Builder SetShortLabel(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<Android.Content.Pm.ShortcutInfo.Builder>("setShortLabel", "(Ljava/lang/CharSequence;)Landroid/content/pm/ShortcutInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/pm/ShortcutInfo.Builder.html#setStartingTheme(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Content.Pm.ShortcutInfo.Builder"/></returns>
            public Android.Content.Pm.ShortcutInfo.Builder SetStartingTheme(int arg0)
            {
                return IExecuteWithSignature<Android.Content.Pm.ShortcutInfo.Builder>("setStartingTheme", "(I)Landroid/content/pm/ShortcutInfo$Builder;", arg0);
            }

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