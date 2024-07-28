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

namespace Android.App.Assist
{
    #region AssistStructure
    public partial class AssistStructure
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.html#getWindowNodeAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.App.Assist.AssistStructure.WindowNode"/></returns>
        public Android.App.Assist.AssistStructure.WindowNode GetWindowNodeAt(int arg0)
        {
            return IExecuteWithSignature<Android.App.Assist.AssistStructure.WindowNode>("getWindowNodeAt", "(I)Landroid/app/assist/AssistStructure$WindowNode;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.html#getActivityComponent()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.ComponentName"/></returns>
        public Android.Content.ComponentName GetActivityComponent()
        {
            return IExecuteWithSignature<Android.Content.ComponentName>("getActivityComponent", "()Landroid/content/ComponentName;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.html#isHomeActivity()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsHomeActivity()
        {
            return IExecuteWithSignature<bool>("isHomeActivity", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.html#getWindowNodeCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetWindowNodeCount()
        {
            return IExecuteWithSignature<int>("getWindowNodeCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.html#getAcquisitionEndTime()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetAcquisitionEndTime()
        {
            return IExecuteWithSignature<long>("getAcquisitionEndTime", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.html#getAcquisitionStartTime()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetAcquisitionStartTime()
        {
            return IExecuteWithSignature<long>("getAcquisitionStartTime", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region ViewNode
        public partial class ViewNode
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#TEXT_COLOR_UNDEFINED"/>
            /// </summary>
            public static int TEXT_COLOR_UNDEFINED { get { if (!_TEXT_COLOR_UNDEFINEDReady) { _TEXT_COLOR_UNDEFINEDContent = SGetField<int>(LocalBridgeClazz, "TEXT_COLOR_UNDEFINED"); _TEXT_COLOR_UNDEFINEDReady = true; } return _TEXT_COLOR_UNDEFINEDContent; } }
            private static int _TEXT_COLOR_UNDEFINEDContent = default;
            private static bool _TEXT_COLOR_UNDEFINEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#TEXT_STYLE_BOLD"/>
            /// </summary>
            public static int TEXT_STYLE_BOLD { get { if (!_TEXT_STYLE_BOLDReady) { _TEXT_STYLE_BOLDContent = SGetField<int>(LocalBridgeClazz, "TEXT_STYLE_BOLD"); _TEXT_STYLE_BOLDReady = true; } return _TEXT_STYLE_BOLDContent; } }
            private static int _TEXT_STYLE_BOLDContent = default;
            private static bool _TEXT_STYLE_BOLDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#TEXT_STYLE_ITALIC"/>
            /// </summary>
            public static int TEXT_STYLE_ITALIC { get { if (!_TEXT_STYLE_ITALICReady) { _TEXT_STYLE_ITALICContent = SGetField<int>(LocalBridgeClazz, "TEXT_STYLE_ITALIC"); _TEXT_STYLE_ITALICReady = true; } return _TEXT_STYLE_ITALICContent; } }
            private static int _TEXT_STYLE_ITALICContent = default;
            private static bool _TEXT_STYLE_ITALICReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#TEXT_STYLE_STRIKE_THRU"/>
            /// </summary>
            public static int TEXT_STYLE_STRIKE_THRU { get { if (!_TEXT_STYLE_STRIKE_THRUReady) { _TEXT_STYLE_STRIKE_THRUContent = SGetField<int>(LocalBridgeClazz, "TEXT_STYLE_STRIKE_THRU"); _TEXT_STYLE_STRIKE_THRUReady = true; } return _TEXT_STYLE_STRIKE_THRUContent; } }
            private static int _TEXT_STYLE_STRIKE_THRUContent = default;
            private static bool _TEXT_STYLE_STRIKE_THRUReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#TEXT_STYLE_UNDERLINE"/>
            /// </summary>
            public static int TEXT_STYLE_UNDERLINE { get { if (!_TEXT_STYLE_UNDERLINEReady) { _TEXT_STYLE_UNDERLINEContent = SGetField<int>(LocalBridgeClazz, "TEXT_STYLE_UNDERLINE"); _TEXT_STYLE_UNDERLINEReady = true; } return _TEXT_STYLE_UNDERLINEContent; } }
            private static int _TEXT_STYLE_UNDERLINEContent = default;
            private static bool _TEXT_STYLE_UNDERLINEReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getChildAt(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.App.Assist.AssistStructure.ViewNode"/></returns>
            public Android.App.Assist.AssistStructure.ViewNode GetChildAt(int arg0)
            {
                return IExecuteWithSignature<Android.App.Assist.AssistStructure.ViewNode>("getChildAt", "(I)Landroid/app/assist/AssistStructure$ViewNode;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getTransformation()"/>
            /// </summary>
            /// <returns><see cref="Android.Graphics.Matrix"/></returns>
            public Android.Graphics.Matrix GetTransformation()
            {
                return IExecuteWithSignature<Android.Graphics.Matrix>("getTransformation", "()Landroid/graphics/Matrix;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getExtras()"/>
            /// </summary>
            /// <returns><see cref="Android.Os.Bundle"/></returns>
            public Android.Os.Bundle GetExtras()
            {
                return IExecuteWithSignature<Android.Os.Bundle>("getExtras", "()Landroid/os/Bundle;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getLocaleList()"/>
            /// </summary>
            /// <returns><see cref="Android.Os.LocaleList"/></returns>
            public Android.Os.LocaleList GetLocaleList()
            {
                return IExecuteWithSignature<Android.Os.LocaleList>("getLocaleList", "()Landroid/os/LocaleList;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getAutofillId()"/>
            /// </summary>
            /// <returns><see cref="Android.View.Autofill.AutofillId"/></returns>
            public Android.View.Autofill.AutofillId GetAutofillId()
            {
                return IExecuteWithSignature<Android.View.Autofill.AutofillId>("getAutofillId", "()Landroid/view/autofill/AutofillId;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getAutofillValue()"/>
            /// </summary>
            /// <returns><see cref="Android.View.Autofill.AutofillValue"/></returns>
            public Android.View.Autofill.AutofillValue GetAutofillValue()
            {
                return IExecuteWithSignature<Android.View.Autofill.AutofillValue>("getAutofillValue", "()Landroid/view/autofill/AutofillValue;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getHtmlInfo()"/>
            /// </summary>
            /// <returns><see cref="Android.View.ViewStructure.HtmlInfo"/></returns>
            public Android.View.ViewStructure.HtmlInfo GetHtmlInfo()
            {
                return IExecuteWithSignature<Android.View.ViewStructure.HtmlInfo>("getHtmlInfo", "()Landroid/view/ViewStructure$HtmlInfo;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#isAccessibilityFocused()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsAccessibilityFocused()
            {
                return IExecuteWithSignature<bool>("isAccessibilityFocused", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#isActivated()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsActivated()
            {
                return IExecuteWithSignature<bool>("isActivated", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#isAssistBlocked()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsAssistBlocked()
            {
                return IExecuteWithSignature<bool>("isAssistBlocked", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#isCheckable()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsCheckable()
            {
                return IExecuteWithSignature<bool>("isCheckable", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#isChecked()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsChecked()
            {
                return IExecuteWithSignature<bool>("isChecked", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#isClickable()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsClickable()
            {
                return IExecuteWithSignature<bool>("isClickable", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#isContextClickable()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsContextClickable()
            {
                return IExecuteWithSignature<bool>("isContextClickable", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#isEnabled()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsEnabled()
            {
                return IExecuteWithSignature<bool>("isEnabled", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#isFocusable()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsFocusable()
            {
                return IExecuteWithSignature<bool>("isFocusable", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#isFocused()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsFocused()
            {
                return IExecuteWithSignature<bool>("isFocused", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#isLongClickable()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsLongClickable()
            {
                return IExecuteWithSignature<bool>("isLongClickable", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#isOpaque()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsOpaque()
            {
                return IExecuteWithSignature<bool>("isOpaque", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#isSelected()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsSelected()
            {
                return IExecuteWithSignature<bool>("isSelected", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getAlpha()"/>
            /// </summary>
            /// <returns><see cref="float"/></returns>
            public float GetAlpha()
            {
                return IExecuteWithSignature<float>("getAlpha", "()F");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getElevation()"/>
            /// </summary>
            /// <returns><see cref="float"/></returns>
            public float GetElevation()
            {
                return IExecuteWithSignature<float>("getElevation", "()F");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getTextSize()"/>
            /// </summary>
            /// <returns><see cref="float"/></returns>
            public float GetTextSize()
            {
                return IExecuteWithSignature<float>("getTextSize", "()F");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getAutofillType()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetAutofillType()
            {
                return IExecuteWithSignature<int>("getAutofillType", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getChildCount()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetChildCount()
            {
                return IExecuteWithSignature<int>("getChildCount", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getHeight()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetHeight()
            {
                return IExecuteWithSignature<int>("getHeight", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getId()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetId()
            {
                return IExecuteWithSignature<int>("getId", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getImportantForAutofill()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetImportantForAutofill()
            {
                return IExecuteWithSignature<int>("getImportantForAutofill", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getInputType()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetInputType()
            {
                return IExecuteWithSignature<int>("getInputType", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getLeft()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetLeft()
            {
                return IExecuteWithSignature<int>("getLeft", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getMaxTextEms()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetMaxTextEms()
            {
                return IExecuteWithSignature<int>("getMaxTextEms", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getMaxTextLength()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetMaxTextLength()
            {
                return IExecuteWithSignature<int>("getMaxTextLength", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getMinTextEms()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetMinTextEms()
            {
                return IExecuteWithSignature<int>("getMinTextEms", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getScrollX()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetScrollX()
            {
                return IExecuteWithSignature<int>("getScrollX", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getScrollY()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetScrollY()
            {
                return IExecuteWithSignature<int>("getScrollY", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getTextBackgroundColor()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetTextBackgroundColor()
            {
                return IExecuteWithSignature<int>("getTextBackgroundColor", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getTextColor()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetTextColor()
            {
                return IExecuteWithSignature<int>("getTextColor", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getTextSelectionEnd()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetTextSelectionEnd()
            {
                return IExecuteWithSignature<int>("getTextSelectionEnd", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getTextSelectionStart()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetTextSelectionStart()
            {
                return IExecuteWithSignature<int>("getTextSelectionStart", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getTextStyle()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetTextStyle()
            {
                return IExecuteWithSignature<int>("getTextStyle", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getTop()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetTop()
            {
                return IExecuteWithSignature<int>("getTop", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getVisibility()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetVisibility()
            {
                return IExecuteWithSignature<int>("getVisibility", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getWidth()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetWidth()
            {
                return IExecuteWithSignature<int>("getWidth", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getTextLineBaselines()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int[] GetTextLineBaselines()
            {
                return IExecuteWithSignatureArray<int>("getTextLineBaselines", "()[I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getTextLineCharOffsets()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int[] GetTextLineCharOffsets()
            {
                return IExecuteWithSignatureArray<int>("getTextLineCharOffsets", "()[I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getContentDescription()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.CharSequence"/></returns>
            public Java.Lang.CharSequence GetContentDescription()
            {
                return IExecuteWithSignature<Java.Lang.CharSequence>("getContentDescription", "()Ljava/lang/CharSequence;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getText()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.CharSequence"/></returns>
            public Java.Lang.CharSequence GetText()
            {
                return IExecuteWithSignature<Java.Lang.CharSequence>("getText", "()Ljava/lang/CharSequence;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getAutofillOptions()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.CharSequence"/></returns>
            public Java.Lang.CharSequence[] GetAutofillOptions()
            {
                return IExecuteWithSignatureArray<Java.Lang.CharSequence>("getAutofillOptions", "()[Ljava/lang/CharSequence;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getClassName()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetClassName()
            {
                return IExecuteWithSignature<Java.Lang.String>("getClassName", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getHint()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetHint()
            {
                return IExecuteWithSignature<Java.Lang.String>("getHint", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getHintIdEntry()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetHintIdEntry()
            {
                return IExecuteWithSignature<Java.Lang.String>("getHintIdEntry", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getIdEntry()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetIdEntry()
            {
                return IExecuteWithSignature<Java.Lang.String>("getIdEntry", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getIdPackage()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetIdPackage()
            {
                return IExecuteWithSignature<Java.Lang.String>("getIdPackage", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getIdType()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetIdType()
            {
                return IExecuteWithSignature<Java.Lang.String>("getIdType", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getTextIdEntry()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetTextIdEntry()
            {
                return IExecuteWithSignature<Java.Lang.String>("getTextIdEntry", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getWebDomain()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetWebDomain()
            {
                return IExecuteWithSignature<Java.Lang.String>("getWebDomain", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getWebScheme()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetWebScheme()
            {
                return IExecuteWithSignature<Java.Lang.String>("getWebScheme", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getAutofillHints()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String[] GetAutofillHints()
            {
                return IExecuteWithSignatureArray<Java.Lang.String>("getAutofillHints", "()[Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.ViewNode.html#getReceiveContentMimeTypes()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String[] GetReceiveContentMimeTypes()
            {
                return IExecuteWithSignatureArray<Java.Lang.String>("getReceiveContentMimeTypes", "()[Ljava/lang/String;");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region WindowNode
        public partial class WindowNode
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
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.WindowNode.html#getRootViewNode()"/>
            /// </summary>
            /// <returns><see cref="Android.App.Assist.AssistStructure.ViewNode"/></returns>
            public Android.App.Assist.AssistStructure.ViewNode GetRootViewNode()
            {
                return IExecuteWithSignature<Android.App.Assist.AssistStructure.ViewNode>("getRootViewNode", "()Landroid/app/assist/AssistStructure$ViewNode;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.WindowNode.html#getDisplayId()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetDisplayId()
            {
                return IExecuteWithSignature<int>("getDisplayId", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.WindowNode.html#getHeight()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetHeight()
            {
                return IExecuteWithSignature<int>("getHeight", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.WindowNode.html#getLeft()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetLeft()
            {
                return IExecuteWithSignature<int>("getLeft", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.WindowNode.html#getTop()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetTop()
            {
                return IExecuteWithSignature<int>("getTop", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.WindowNode.html#getWidth()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetWidth()
            {
                return IExecuteWithSignature<int>("getWidth", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/assist/AssistStructure.WindowNode.html#getTitle()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.CharSequence"/></returns>
            public Java.Lang.CharSequence GetTitle()
            {
                return IExecuteWithSignature<Java.Lang.CharSequence>("getTitle", "()Ljava/lang/CharSequence;");
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