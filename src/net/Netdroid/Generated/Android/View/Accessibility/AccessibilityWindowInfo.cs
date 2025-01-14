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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.View.Accessibility
{
    #region AccessibilityWindowInfo declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityWindowInfo.html"/>
    /// </summary>
    public partial class AccessibilityWindowInfo : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.view.accessibility.AccessibilityWindowInfo";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AccessibilityWindowInfo() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AccessibilityWindowInfo(params object[] args) : base(args) { }
    
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

    #region AccessibilityWindowInfo implementation
    public partial class AccessibilityWindowInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityWindowInfo.html#%3Cinit%3E(android.view.accessibility.AccessibilityWindowInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Accessibility.AccessibilityWindowInfo"/></param>
        public AccessibilityWindowInfo(Android.View.Accessibility.AccessibilityWindowInfo arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityWindowInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityWindowInfo.html#TYPE_ACCESSIBILITY_OVERLAY"/>
        /// </summary>
        public static int TYPE_ACCESSIBILITY_OVERLAY { get { if (!_TYPE_ACCESSIBILITY_OVERLAYReady) { _TYPE_ACCESSIBILITY_OVERLAYContent = SGetField<int>(LocalBridgeClazz, "TYPE_ACCESSIBILITY_OVERLAY"); _TYPE_ACCESSIBILITY_OVERLAYReady = true; } return _TYPE_ACCESSIBILITY_OVERLAYContent; } }
        private static int _TYPE_ACCESSIBILITY_OVERLAYContent = default;
        private static bool _TYPE_ACCESSIBILITY_OVERLAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityWindowInfo.html#TYPE_APPLICATION"/>
        /// </summary>
        public static int TYPE_APPLICATION { get { if (!_TYPE_APPLICATIONReady) { _TYPE_APPLICATIONContent = SGetField<int>(LocalBridgeClazz, "TYPE_APPLICATION"); _TYPE_APPLICATIONReady = true; } return _TYPE_APPLICATIONContent; } }
        private static int _TYPE_APPLICATIONContent = default;
        private static bool _TYPE_APPLICATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityWindowInfo.html#TYPE_INPUT_METHOD"/>
        /// </summary>
        public static int TYPE_INPUT_METHOD { get { if (!_TYPE_INPUT_METHODReady) { _TYPE_INPUT_METHODContent = SGetField<int>(LocalBridgeClazz, "TYPE_INPUT_METHOD"); _TYPE_INPUT_METHODReady = true; } return _TYPE_INPUT_METHODContent; } }
        private static int _TYPE_INPUT_METHODContent = default;
        private static bool _TYPE_INPUT_METHODReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityWindowInfo.html#TYPE_MAGNIFICATION_OVERLAY"/>
        /// </summary>
        public static int TYPE_MAGNIFICATION_OVERLAY { get { if (!_TYPE_MAGNIFICATION_OVERLAYReady) { _TYPE_MAGNIFICATION_OVERLAYContent = SGetField<int>(LocalBridgeClazz, "TYPE_MAGNIFICATION_OVERLAY"); _TYPE_MAGNIFICATION_OVERLAYReady = true; } return _TYPE_MAGNIFICATION_OVERLAYContent; } }
        private static int _TYPE_MAGNIFICATION_OVERLAYContent = default;
        private static bool _TYPE_MAGNIFICATION_OVERLAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityWindowInfo.html#TYPE_SPLIT_SCREEN_DIVIDER"/>
        /// </summary>
        public static int TYPE_SPLIT_SCREEN_DIVIDER { get { if (!_TYPE_SPLIT_SCREEN_DIVIDERReady) { _TYPE_SPLIT_SCREEN_DIVIDERContent = SGetField<int>(LocalBridgeClazz, "TYPE_SPLIT_SCREEN_DIVIDER"); _TYPE_SPLIT_SCREEN_DIVIDERReady = true; } return _TYPE_SPLIT_SCREEN_DIVIDERContent; } }
        private static int _TYPE_SPLIT_SCREEN_DIVIDERContent = default;
        private static bool _TYPE_SPLIT_SCREEN_DIVIDERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityWindowInfo.html#TYPE_SYSTEM"/>
        /// </summary>
        public static int TYPE_SYSTEM { get { if (!_TYPE_SYSTEMReady) { _TYPE_SYSTEMContent = SGetField<int>(LocalBridgeClazz, "TYPE_SYSTEM"); _TYPE_SYSTEMReady = true; } return _TYPE_SYSTEMContent; } }
        private static int _TYPE_SYSTEMContent = default;
        private static bool _TYPE_SYSTEMReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityWindowInfo.html#obtain()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Accessibility.AccessibilityWindowInfo"/></returns>
        public static Android.View.Accessibility.AccessibilityWindowInfo Obtain()
        {
            return SExecuteWithSignature<Android.View.Accessibility.AccessibilityWindowInfo>(LocalBridgeClazz, "obtain", "()Landroid/view/accessibility/AccessibilityWindowInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityWindowInfo.html#obtain(android.view.accessibility.AccessibilityWindowInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Accessibility.AccessibilityWindowInfo"/></param>
        /// <returns><see cref="Android.View.Accessibility.AccessibilityWindowInfo"/></returns>
        public static Android.View.Accessibility.AccessibilityWindowInfo Obtain(Android.View.Accessibility.AccessibilityWindowInfo arg0)
        {
            return SExecuteWithSignature<Android.View.Accessibility.AccessibilityWindowInfo>(LocalBridgeClazz, "obtain", "(Landroid/view/accessibility/AccessibilityWindowInfo;)Landroid/view/accessibility/AccessibilityWindowInfo;", arg0);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityWindowInfo.html#getLocales()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.LocaleList"/></returns>
        public Android.Os.LocaleList GetLocales()
        {
            return IExecuteWithSignature<Android.Os.LocaleList>("getLocales", "()Landroid/os/LocaleList;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityWindowInfo.html#getAnchor()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Accessibility.AccessibilityNodeInfo"/></returns>
        public Android.View.Accessibility.AccessibilityNodeInfo GetAnchor()
        {
            return IExecuteWithSignature<Android.View.Accessibility.AccessibilityNodeInfo>("getAnchor", "()Landroid/view/accessibility/AccessibilityNodeInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityWindowInfo.html#getRoot()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Accessibility.AccessibilityNodeInfo"/></returns>
        public Android.View.Accessibility.AccessibilityNodeInfo GetRoot()
        {
            return IExecuteWithSignature<Android.View.Accessibility.AccessibilityNodeInfo>("getRoot", "()Landroid/view/accessibility/AccessibilityNodeInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityWindowInfo.html#getRoot(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.View.Accessibility.AccessibilityNodeInfo"/></returns>
        public Android.View.Accessibility.AccessibilityNodeInfo GetRoot(int arg0)
        {
            return IExecuteWithSignature<Android.View.Accessibility.AccessibilityNodeInfo>("getRoot", "(I)Landroid/view/accessibility/AccessibilityNodeInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityWindowInfo.html#getChild(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.View.Accessibility.AccessibilityWindowInfo"/></returns>
        public Android.View.Accessibility.AccessibilityWindowInfo GetChild(int arg0)
        {
            return IExecuteWithSignature<Android.View.Accessibility.AccessibilityWindowInfo>("getChild", "(I)Landroid/view/accessibility/AccessibilityWindowInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityWindowInfo.html#getParent()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Accessibility.AccessibilityWindowInfo"/></returns>
        public Android.View.Accessibility.AccessibilityWindowInfo GetParent()
        {
            return IExecuteWithSignature<Android.View.Accessibility.AccessibilityWindowInfo>("getParent", "()Landroid/view/accessibility/AccessibilityWindowInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityWindowInfo.html#isAccessibilityFocused()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAccessibilityFocused()
        {
            return IExecuteWithSignature<bool>("isAccessibilityFocused", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityWindowInfo.html#isActive()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsActive()
        {
            return IExecuteWithSignature<bool>("isActive", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityWindowInfo.html#isFocused()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFocused()
        {
            return IExecuteWithSignature<bool>("isFocused", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityWindowInfo.html#isInPictureInPictureMode()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsInPictureInPictureMode()
        {
            return IExecuteWithSignature<bool>("isInPictureInPictureMode", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityWindowInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityWindowInfo.html#getChildCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetChildCount()
        {
            return IExecuteWithSignature<int>("getChildCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityWindowInfo.html#getDisplayId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDisplayId()
        {
            return IExecuteWithSignature<int>("getDisplayId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityWindowInfo.html#getId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetId()
        {
            return IExecuteWithSignature<int>("getId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityWindowInfo.html#getLayer()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetLayer()
        {
            return IExecuteWithSignature<int>("getLayer", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityWindowInfo.html#getType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetType()
        {
            return IExecuteWithSignature<int>("getType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityWindowInfo.html#getTitle()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetTitle()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getTitle", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityWindowInfo.html#getTransitionTimeMillis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetTransitionTimeMillis()
        {
            return IExecuteWithSignature<long>("getTransitionTimeMillis", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityWindowInfo.html#getBoundsInScreen(android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Rect"/></param>
        public void GetBoundsInScreen(Android.Graphics.Rect arg0)
        {
            IExecuteWithSignature("getBoundsInScreen", "(Landroid/graphics/Rect;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityWindowInfo.html#getRegionInScreen(android.graphics.Region)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Region"/></param>
        public void GetRegionInScreen(Android.Graphics.Region arg0)
        {
            IExecuteWithSignature("getRegionInScreen", "(Landroid/graphics/Region;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityWindowInfo.html#recycle()"/>
        /// </summary>
        public void Recycle()
        {
            IExecuteWithSignature("recycle", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityWindowInfo.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecuteWithSignature("writeToParcel", "(Landroid/os/Parcel;I)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}