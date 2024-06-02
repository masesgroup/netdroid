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

namespace Android.Appwidget
{
    #region AppWidgetProviderInfo
    public partial class AppWidgetProviderInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#%3Cinit%3E(android.os.Parcel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        public AppWidgetProviderInfo(Android.Os.Parcel arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#configure"/>
        /// </summary>
        public Android.Content.ComponentName configure { get { return IGetField<Android.Content.ComponentName>("configure"); } set { ISetField("configure", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#provider"/>
        /// </summary>
        public Android.Content.ComponentName provider { get { return IGetField<Android.Content.ComponentName>("provider"); } set { ISetField("provider", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#autoAdvanceViewId"/>
        /// </summary>
        public int autoAdvanceViewId { get { return IGetField<int>("autoAdvanceViewId"); } set { ISetField("autoAdvanceViewId", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#descriptionRes"/>
        /// </summary>
        public int descriptionRes { get { return IGetField<int>("descriptionRes"); } set { ISetField("descriptionRes", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#icon"/>
        /// </summary>
        public int icon { get { return IGetField<int>("icon"); } set { ISetField("icon", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#initialKeyguardLayout"/>
        /// </summary>
        public int initialKeyguardLayout { get { return IGetField<int>("initialKeyguardLayout"); } set { ISetField("initialKeyguardLayout", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#initialLayout"/>
        /// </summary>
        public int initialLayout { get { return IGetField<int>("initialLayout"); } set { ISetField("initialLayout", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#maxResizeHeight"/>
        /// </summary>
        public int maxResizeHeight { get { return IGetField<int>("maxResizeHeight"); } set { ISetField("maxResizeHeight", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#maxResizeWidth"/>
        /// </summary>
        public int maxResizeWidth { get { return IGetField<int>("maxResizeWidth"); } set { ISetField("maxResizeWidth", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#minHeight"/>
        /// </summary>
        public int minHeight { get { return IGetField<int>("minHeight"); } set { ISetField("minHeight", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#minResizeHeight"/>
        /// </summary>
        public int minResizeHeight { get { return IGetField<int>("minResizeHeight"); } set { ISetField("minResizeHeight", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#minResizeWidth"/>
        /// </summary>
        public int minResizeWidth { get { return IGetField<int>("minResizeWidth"); } set { ISetField("minResizeWidth", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#minWidth"/>
        /// </summary>
        public int minWidth { get { return IGetField<int>("minWidth"); } set { ISetField("minWidth", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#previewImage"/>
        /// </summary>
        public int previewImage { get { return IGetField<int>("previewImage"); } set { ISetField("previewImage", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#previewLayout"/>
        /// </summary>
        public int previewLayout { get { return IGetField<int>("previewLayout"); } set { ISetField("previewLayout", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#resizeMode"/>
        /// </summary>
        public int resizeMode { get { return IGetField<int>("resizeMode"); } set { ISetField("resizeMode", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#targetCellHeight"/>
        /// </summary>
        public int targetCellHeight { get { return IGetField<int>("targetCellHeight"); } set { ISetField("targetCellHeight", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#targetCellWidth"/>
        /// </summary>
        public int targetCellWidth { get { return IGetField<int>("targetCellWidth"); } set { ISetField("targetCellWidth", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#updatePeriodMillis"/>
        /// </summary>
        public int updatePeriodMillis { get { return IGetField<int>("updatePeriodMillis"); } set { ISetField("updatePeriodMillis", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#widgetCategory"/>
        /// </summary>
        public int widgetCategory { get { return IGetField<int>("widgetCategory"); } set { ISetField("widgetCategory", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#widgetFeatures"/>
        /// </summary>
        public int widgetFeatures { get { return IGetField<int>("widgetFeatures"); } set { ISetField("widgetFeatures", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#label"/>
        /// </summary>
        [global::System.Obsolete()]
        public Java.Lang.String label { get { return IGetField<Java.Lang.String>("label"); } set { ISetField("label", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#RESIZE_BOTH"/>
        /// </summary>
        public static int RESIZE_BOTH { get { if (!_RESIZE_BOTHReady) { _RESIZE_BOTHContent = SGetField<int>(LocalBridgeClazz, "RESIZE_BOTH"); _RESIZE_BOTHReady = true; } return _RESIZE_BOTHContent; } }
        private static int _RESIZE_BOTHContent = default;
        private static bool _RESIZE_BOTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#RESIZE_HORIZONTAL"/>
        /// </summary>
        public static int RESIZE_HORIZONTAL { get { if (!_RESIZE_HORIZONTALReady) { _RESIZE_HORIZONTALContent = SGetField<int>(LocalBridgeClazz, "RESIZE_HORIZONTAL"); _RESIZE_HORIZONTALReady = true; } return _RESIZE_HORIZONTALContent; } }
        private static int _RESIZE_HORIZONTALContent = default;
        private static bool _RESIZE_HORIZONTALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#RESIZE_NONE"/>
        /// </summary>
        public static int RESIZE_NONE { get { if (!_RESIZE_NONEReady) { _RESIZE_NONEContent = SGetField<int>(LocalBridgeClazz, "RESIZE_NONE"); _RESIZE_NONEReady = true; } return _RESIZE_NONEContent; } }
        private static int _RESIZE_NONEContent = default;
        private static bool _RESIZE_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#RESIZE_VERTICAL"/>
        /// </summary>
        public static int RESIZE_VERTICAL { get { if (!_RESIZE_VERTICALReady) { _RESIZE_VERTICALContent = SGetField<int>(LocalBridgeClazz, "RESIZE_VERTICAL"); _RESIZE_VERTICALReady = true; } return _RESIZE_VERTICALContent; } }
        private static int _RESIZE_VERTICALContent = default;
        private static bool _RESIZE_VERTICALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#WIDGET_CATEGORY_HOME_SCREEN"/>
        /// </summary>
        public static int WIDGET_CATEGORY_HOME_SCREEN { get { if (!_WIDGET_CATEGORY_HOME_SCREENReady) { _WIDGET_CATEGORY_HOME_SCREENContent = SGetField<int>(LocalBridgeClazz, "WIDGET_CATEGORY_HOME_SCREEN"); _WIDGET_CATEGORY_HOME_SCREENReady = true; } return _WIDGET_CATEGORY_HOME_SCREENContent; } }
        private static int _WIDGET_CATEGORY_HOME_SCREENContent = default;
        private static bool _WIDGET_CATEGORY_HOME_SCREENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#WIDGET_CATEGORY_KEYGUARD"/>
        /// </summary>
        public static int WIDGET_CATEGORY_KEYGUARD { get { if (!_WIDGET_CATEGORY_KEYGUARDReady) { _WIDGET_CATEGORY_KEYGUARDContent = SGetField<int>(LocalBridgeClazz, "WIDGET_CATEGORY_KEYGUARD"); _WIDGET_CATEGORY_KEYGUARDReady = true; } return _WIDGET_CATEGORY_KEYGUARDContent; } }
        private static int _WIDGET_CATEGORY_KEYGUARDContent = default;
        private static bool _WIDGET_CATEGORY_KEYGUARDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#WIDGET_CATEGORY_SEARCHBOX"/>
        /// </summary>
        public static int WIDGET_CATEGORY_SEARCHBOX { get { if (!_WIDGET_CATEGORY_SEARCHBOXReady) { _WIDGET_CATEGORY_SEARCHBOXContent = SGetField<int>(LocalBridgeClazz, "WIDGET_CATEGORY_SEARCHBOX"); _WIDGET_CATEGORY_SEARCHBOXReady = true; } return _WIDGET_CATEGORY_SEARCHBOXContent; } }
        private static int _WIDGET_CATEGORY_SEARCHBOXContent = default;
        private static bool _WIDGET_CATEGORY_SEARCHBOXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#WIDGET_FEATURE_CONFIGURATION_OPTIONAL"/>
        /// </summary>
        public static int WIDGET_FEATURE_CONFIGURATION_OPTIONAL { get { if (!_WIDGET_FEATURE_CONFIGURATION_OPTIONALReady) { _WIDGET_FEATURE_CONFIGURATION_OPTIONALContent = SGetField<int>(LocalBridgeClazz, "WIDGET_FEATURE_CONFIGURATION_OPTIONAL"); _WIDGET_FEATURE_CONFIGURATION_OPTIONALReady = true; } return _WIDGET_FEATURE_CONFIGURATION_OPTIONALContent; } }
        private static int _WIDGET_FEATURE_CONFIGURATION_OPTIONALContent = default;
        private static bool _WIDGET_FEATURE_CONFIGURATION_OPTIONALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#WIDGET_FEATURE_HIDE_FROM_PICKER"/>
        /// </summary>
        public static int WIDGET_FEATURE_HIDE_FROM_PICKER { get { if (!_WIDGET_FEATURE_HIDE_FROM_PICKERReady) { _WIDGET_FEATURE_HIDE_FROM_PICKERContent = SGetField<int>(LocalBridgeClazz, "WIDGET_FEATURE_HIDE_FROM_PICKER"); _WIDGET_FEATURE_HIDE_FROM_PICKERReady = true; } return _WIDGET_FEATURE_HIDE_FROM_PICKERContent; } }
        private static int _WIDGET_FEATURE_HIDE_FROM_PICKERContent = default;
        private static bool _WIDGET_FEATURE_HIDE_FROM_PICKERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#WIDGET_FEATURE_RECONFIGURABLE"/>
        /// </summary>
        public static int WIDGET_FEATURE_RECONFIGURABLE { get { if (!_WIDGET_FEATURE_RECONFIGURABLEReady) { _WIDGET_FEATURE_RECONFIGURABLEContent = SGetField<int>(LocalBridgeClazz, "WIDGET_FEATURE_RECONFIGURABLE"); _WIDGET_FEATURE_RECONFIGURABLEReady = true; } return _WIDGET_FEATURE_RECONFIGURABLEContent; } }
        private static int _WIDGET_FEATURE_RECONFIGURABLEContent = default;
        private static bool _WIDGET_FEATURE_RECONFIGURABLEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#clone()"/>
        /// </summary>
        /// <returns><see cref="Android.Appwidget.AppWidgetProviderInfo"/></returns>
        public Android.Appwidget.AppWidgetProviderInfo Clone()
        {
            return IExecuteWithSignature<Android.Appwidget.AppWidgetProviderInfo>("clone", "()Landroid/appwidget/AppWidgetProviderInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#getActivityInfo()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Pm.ActivityInfo"/></returns>
        public Android.Content.Pm.ActivityInfo GetActivityInfo()
        {
            return IExecuteWithSignature<Android.Content.Pm.ActivityInfo>("getActivityInfo", "()Landroid/content/pm/ActivityInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#loadIcon(android.content.Context,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable LoadIcon(Android.Content.Context arg0, int arg1)
        {
            return IExecute<Android.Graphics.Drawable.Drawable>("loadIcon", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#loadPreviewImage(android.content.Context,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable LoadPreviewImage(Android.Content.Context arg0, int arg1)
        {
            return IExecute<Android.Graphics.Drawable.Drawable>("loadPreviewImage", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#getProfile()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.UserHandle"/></returns>
        public Android.Os.UserHandle GetProfile()
        {
            return IExecuteWithSignature<Android.Os.UserHandle>("getProfile", "()Landroid/os/UserHandle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#loadDescription(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence LoadDescription(Android.Content.Context arg0)
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("loadDescription", "(Landroid/content/Context;)Ljava/lang/CharSequence;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#loadLabel(android.content.pm.PackageManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Pm.PackageManager"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String LoadLabel(Android.Content.Pm.PackageManager arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProviderInfo.html#writeToParcel(android.os.Parcel,int)"/>
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