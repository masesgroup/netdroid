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

namespace Android.View.Accessibility
{
    #region AccessibilityRecord
    public partial class AccessibilityRecord
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#%3Cinit%3E(android.view.accessibility.AccessibilityRecord)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Accessibility.AccessibilityRecord"/></param>
        public AccessibilityRecord(Android.View.Accessibility.AccessibilityRecord arg0)
            : base(arg0)
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
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getAddedCount()"/> <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setAddedCount(int)"/>
        /// </summary>
        public int AddedCount
        {
            get { return IExecuteWithSignature<int>("getAddedCount", "()I"); } set { IExecuteWithSignature("setAddedCount", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getBeforeText()"/> <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setBeforeText(java.lang.CharSequence)"/>
        /// </summary>
        public Java.Lang.CharSequence BeforeText
        {
            get { return IExecuteWithSignature<Java.Lang.CharSequence>("getBeforeText", "()Ljava/lang/CharSequence;"); } set { IExecuteWithSignature("setBeforeText", "(Ljava/lang/CharSequence;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getClassName()"/> <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setClassName(java.lang.CharSequence)"/>
        /// </summary>
        public Java.Lang.CharSequence ClassName
        {
            get { return IExecuteWithSignature<Java.Lang.CharSequence>("getClassName", "()Ljava/lang/CharSequence;"); } set { IExecuteWithSignature("setClassName", "(Ljava/lang/CharSequence;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getContentDescription()"/> <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setContentDescription(java.lang.CharSequence)"/>
        /// </summary>
        public Java.Lang.CharSequence ContentDescription
        {
            get { return IExecuteWithSignature<Java.Lang.CharSequence>("getContentDescription", "()Ljava/lang/CharSequence;"); } set { IExecuteWithSignature("setContentDescription", "(Ljava/lang/CharSequence;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getCurrentItemIndex()"/> <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setCurrentItemIndex(int)"/>
        /// </summary>
        public int CurrentItemIndex
        {
            get { return IExecuteWithSignature<int>("getCurrentItemIndex", "()I"); } set { IExecuteWithSignature("setCurrentItemIndex", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getDisplayId()"/> 
        /// </summary>
        public int DisplayId
        {
            get { return IExecuteWithSignature<int>("getDisplayId", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getFromIndex()"/> <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setFromIndex(int)"/>
        /// </summary>
        public int FromIndex
        {
            get { return IExecuteWithSignature<int>("getFromIndex", "()I"); } set { IExecuteWithSignature("setFromIndex", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getItemCount()"/> <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setItemCount(int)"/>
        /// </summary>
        public int ItemCount
        {
            get { return IExecuteWithSignature<int>("getItemCount", "()I"); } set { IExecuteWithSignature("setItemCount", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getMaxScrollX()"/> <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setMaxScrollX(int)"/>
        /// </summary>
        public int MaxScrollX
        {
            get { return IExecuteWithSignature<int>("getMaxScrollX", "()I"); } set { IExecuteWithSignature("setMaxScrollX", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getMaxScrollY()"/> <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setMaxScrollY(int)"/>
        /// </summary>
        public int MaxScrollY
        {
            get { return IExecuteWithSignature<int>("getMaxScrollY", "()I"); } set { IExecuteWithSignature("setMaxScrollY", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getParcelableData()"/> <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setParcelableData(android.os.Parcelable)"/>
        /// </summary>
        public Android.Os.Parcelable ParcelableData
        {
            get { return IExecuteWithSignature<Android.Os.Parcelable>("getParcelableData", "()Landroid/os/Parcelable;"); } set { IExecuteWithSignature("setParcelableData", "(Landroid/os/Parcelable;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getRemovedCount()"/> <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setRemovedCount(int)"/>
        /// </summary>
        public int RemovedCount
        {
            get { return IExecuteWithSignature<int>("getRemovedCount", "()I"); } set { IExecuteWithSignature("setRemovedCount", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getScrollDeltaX()"/> <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setScrollDeltaX(int)"/>
        /// </summary>
        public int ScrollDeltaX
        {
            get { return IExecuteWithSignature<int>("getScrollDeltaX", "()I"); } set { IExecuteWithSignature("setScrollDeltaX", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getScrollDeltaY()"/> <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setScrollDeltaY(int)"/>
        /// </summary>
        public int ScrollDeltaY
        {
            get { return IExecuteWithSignature<int>("getScrollDeltaY", "()I"); } set { IExecuteWithSignature("setScrollDeltaY", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getScrollX()"/> <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setScrollX(int)"/>
        /// </summary>
        public int ScrollX
        {
            get { return IExecuteWithSignature<int>("getScrollX", "()I"); } set { IExecuteWithSignature("setScrollX", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getScrollY()"/> <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setScrollY(int)"/>
        /// </summary>
        public int ScrollY
        {
            get { return IExecuteWithSignature<int>("getScrollY", "()I"); } set { IExecuteWithSignature("setScrollY", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getSource()"/> <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setSource(android.view.View)"/>
        /// </summary>
        public Android.View.Accessibility.AccessibilityNodeInfo Source
        {
            get { return IExecuteWithSignature<Android.View.Accessibility.AccessibilityNodeInfo>("getSource", "()Landroid/view/accessibility/AccessibilityNodeInfo;"); } set { IExecuteWithSignature("setSource", "(Landroid/view/View;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getText()"/> 
        /// </summary>
        public Java.Util.List<Java.Lang.CharSequence> Text
        {
            get { return IExecuteWithSignature<Java.Util.List<Java.Lang.CharSequence>>("getText", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getToIndex()"/> <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setToIndex(int)"/>
        /// </summary>
        public int ToIndex
        {
            get { return IExecuteWithSignature<int>("getToIndex", "()I"); } set { IExecuteWithSignature("setToIndex", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getWindowId()"/> 
        /// </summary>
        public int WindowId
        {
            get { return IExecuteWithSignature<int>("getWindowId", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getSource(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.View.Accessibility.AccessibilityNodeInfo"/></returns>
        public Android.View.Accessibility.AccessibilityNodeInfo GetSource(int arg0)
        {
            return IExecuteWithSignature<Android.View.Accessibility.AccessibilityNodeInfo>("getSource", "(I)Landroid/view/accessibility/AccessibilityNodeInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#isChecked()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsChecked()
        {
            return IExecuteWithSignature<bool>("isChecked", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#isEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEnabled()
        {
            return IExecuteWithSignature<bool>("isEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#isFullScreen()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFullScreen()
        {
            return IExecuteWithSignature<bool>("isFullScreen", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#isPassword()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPassword()
        {
            return IExecuteWithSignature<bool>("isPassword", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#isScrollable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsScrollable()
        {
            return IExecuteWithSignature<bool>("isScrollable", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setChecked(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetChecked(bool arg0)
        {
            IExecuteWithSignature("setChecked", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetEnabled(bool arg0)
        {
            IExecuteWithSignature("setEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setFullScreen(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetFullScreen(bool arg0)
        {
            IExecuteWithSignature("setFullScreen", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setPassword(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetPassword(bool arg0)
        {
            IExecuteWithSignature("setPassword", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setScrollable(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetScrollable(bool arg0)
        {
            IExecuteWithSignature("setScrollable", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setSource(android.view.View,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetSource(Android.View.View arg0, int arg1)
        {
            IExecute("setSource", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}