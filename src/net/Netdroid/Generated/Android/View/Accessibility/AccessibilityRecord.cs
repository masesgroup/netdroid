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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.View.Accessibility
{
    #region AccessibilityRecord declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html"/>
    /// </summary>
    public partial class AccessibilityRecord : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AccessibilityRecord>
    {
        const string _bridgeClassName = "android.view.accessibility.AccessibilityRecord";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AccessibilityRecord() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AccessibilityRecord(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region AccessibilityRecord implementation
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
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#obtain()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Accessibility.AccessibilityRecord"/></returns>
        [global::System.Obsolete()]
        public static Android.View.Accessibility.AccessibilityRecord Obtain()
        {
            return SExecuteWithSignature<Android.View.Accessibility.AccessibilityRecord>(LocalBridgeClazz, "obtain", "()Landroid/view/accessibility/AccessibilityRecord;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#obtain(android.view.accessibility.AccessibilityRecord)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Accessibility.AccessibilityRecord"/></param>
        /// <returns><see cref="Android.View.Accessibility.AccessibilityRecord"/></returns>
        [global::System.Obsolete()]
        public static Android.View.Accessibility.AccessibilityRecord Obtain(Android.View.Accessibility.AccessibilityRecord arg0)
        {
            return SExecuteWithSignature<Android.View.Accessibility.AccessibilityRecord>(LocalBridgeClazz, "obtain", "(Landroid/view/accessibility/AccessibilityRecord;)Landroid/view/accessibility/AccessibilityRecord;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getParcelableData()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Parcelable"/></returns>
        public Android.Os.Parcelable GetParcelableData()
        {
            return IExecuteWithSignature<Android.Os.Parcelable>("getParcelableData", "()Landroid/os/Parcelable;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getSource()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Accessibility.AccessibilityNodeInfo"/></returns>
        public Android.View.Accessibility.AccessibilityNodeInfo GetSource()
        {
            return IExecuteWithSignature<Android.View.Accessibility.AccessibilityNodeInfo>("getSource", "()Landroid/view/accessibility/AccessibilityNodeInfo;");
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
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getAddedCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetAddedCount()
        {
            return IExecuteWithSignature<int>("getAddedCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getCurrentItemIndex()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCurrentItemIndex()
        {
            return IExecuteWithSignature<int>("getCurrentItemIndex", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getDisplayId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDisplayId()
        {
            return IExecuteWithSignature<int>("getDisplayId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getFromIndex()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetFromIndex()
        {
            return IExecuteWithSignature<int>("getFromIndex", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getItemCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetItemCount()
        {
            return IExecuteWithSignature<int>("getItemCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getMaxScrollX()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaxScrollX()
        {
            return IExecuteWithSignature<int>("getMaxScrollX", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getMaxScrollY()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaxScrollY()
        {
            return IExecuteWithSignature<int>("getMaxScrollY", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getRemovedCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetRemovedCount()
        {
            return IExecuteWithSignature<int>("getRemovedCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getScrollDeltaX()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetScrollDeltaX()
        {
            return IExecuteWithSignature<int>("getScrollDeltaX", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getScrollDeltaY()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetScrollDeltaY()
        {
            return IExecuteWithSignature<int>("getScrollDeltaY", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getScrollX()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetScrollX()
        {
            return IExecuteWithSignature<int>("getScrollX", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getScrollY()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetScrollY()
        {
            return IExecuteWithSignature<int>("getScrollY", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getToIndex()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetToIndex()
        {
            return IExecuteWithSignature<int>("getToIndex", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getWindowId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetWindowId()
        {
            return IExecuteWithSignature<int>("getWindowId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getBeforeText()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetBeforeText()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getBeforeText", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getClassName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetClassName()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getClassName", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getContentDescription()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetContentDescription()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getContentDescription", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#getText()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Lang.CharSequence> GetText()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Lang.CharSequence>>("getText", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#recycle()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void Recycle()
        {
            IExecuteWithSignature("recycle", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setAddedCount(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetAddedCount(int arg0)
        {
            IExecuteWithSignature("setAddedCount", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setBeforeText(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        public void SetBeforeText(Java.Lang.CharSequence arg0)
        {
            IExecuteWithSignature("setBeforeText", "(Ljava/lang/CharSequence;)V", arg0);
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
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setClassName(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        public void SetClassName(Java.Lang.CharSequence arg0)
        {
            IExecuteWithSignature("setClassName", "(Ljava/lang/CharSequence;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setContentDescription(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        public void SetContentDescription(Java.Lang.CharSequence arg0)
        {
            IExecuteWithSignature("setContentDescription", "(Ljava/lang/CharSequence;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setCurrentItemIndex(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetCurrentItemIndex(int arg0)
        {
            IExecuteWithSignature("setCurrentItemIndex", "(I)V", arg0);
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
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setFromIndex(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetFromIndex(int arg0)
        {
            IExecuteWithSignature("setFromIndex", "(I)V", arg0);
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
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setItemCount(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetItemCount(int arg0)
        {
            IExecuteWithSignature("setItemCount", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setMaxScrollX(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetMaxScrollX(int arg0)
        {
            IExecuteWithSignature("setMaxScrollX", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setMaxScrollY(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetMaxScrollY(int arg0)
        {
            IExecuteWithSignature("setMaxScrollY", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setParcelableData(android.os.Parcelable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcelable"/></param>
        public void SetParcelableData(Android.Os.Parcelable arg0)
        {
            IExecuteWithSignature("setParcelableData", "(Landroid/os/Parcelable;)V", arg0);
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
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setRemovedCount(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetRemovedCount(int arg0)
        {
            IExecuteWithSignature("setRemovedCount", "(I)V", arg0);
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
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setScrollDeltaX(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetScrollDeltaX(int arg0)
        {
            IExecuteWithSignature("setScrollDeltaX", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setScrollDeltaY(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetScrollDeltaY(int arg0)
        {
            IExecuteWithSignature("setScrollDeltaY", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setScrollX(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetScrollX(int arg0)
        {
            IExecuteWithSignature("setScrollX", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setScrollY(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetScrollY(int arg0)
        {
            IExecuteWithSignature("setScrollY", "(I)V", arg0);
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
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setSource(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        public void SetSource(Android.View.View arg0)
        {
            IExecuteWithSignature("setSource", "(Landroid/view/View;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityRecord.html#setToIndex(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetToIndex(int arg0)
        {
            IExecuteWithSignature("setToIndex", "(I)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}