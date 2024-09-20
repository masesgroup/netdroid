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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.View.Accessibility
{
    #region AccessibilityNodeProvider
    public partial class AccessibilityNodeProvider
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityNodeProvider.html#HOST_VIEW_ID"/>
        /// </summary>
        public static int HOST_VIEW_ID { get { if (!_HOST_VIEW_IDReady) { _HOST_VIEW_IDContent = SGetField<int>(LocalBridgeClazz, "HOST_VIEW_ID"); _HOST_VIEW_IDReady = true; } return _HOST_VIEW_IDContent; } }
        private static int _HOST_VIEW_IDContent = default;
        private static bool _HOST_VIEW_IDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityNodeProvider.html#createAccessibilityNodeInfo(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.View.Accessibility.AccessibilityNodeInfo"/></returns>
        public Android.View.Accessibility.AccessibilityNodeInfo CreateAccessibilityNodeInfo(int arg0)
        {
            return IExecuteWithSignature<Android.View.Accessibility.AccessibilityNodeInfo>("createAccessibilityNodeInfo", "(I)Landroid/view/accessibility/AccessibilityNodeInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityNodeProvider.html#findFocus(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.View.Accessibility.AccessibilityNodeInfo"/></returns>
        public Android.View.Accessibility.AccessibilityNodeInfo FindFocus(int arg0)
        {
            return IExecuteWithSignature<Android.View.Accessibility.AccessibilityNodeInfo>("findFocus", "(I)Landroid/view/accessibility/AccessibilityNodeInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityNodeProvider.html#performAction(int,int,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool PerformAction(int arg0, int arg1, Android.Os.Bundle arg2)
        {
            return IExecute<bool>("performAction", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityNodeProvider.html#findAccessibilityNodeInfosByText(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.View.Accessibility.AccessibilityNodeInfo> FindAccessibilityNodeInfosByText(Java.Lang.String arg0, int arg1)
        {
            return IExecute<Java.Util.List<Android.View.Accessibility.AccessibilityNodeInfo>>("findAccessibilityNodeInfosByText", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityNodeProvider.html#addExtraDataToAccessibilityNodeInfo(int,android.view.accessibility.AccessibilityNodeInfo,java.lang.String,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.View.Accessibility.AccessibilityNodeInfo"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Android.Os.Bundle"/></param>
        public void AddExtraDataToAccessibilityNodeInfo(int arg0, Android.View.Accessibility.AccessibilityNodeInfo arg1, Java.Lang.String arg2, Android.Os.Bundle arg3)
        {
            IExecute("addExtraDataToAccessibilityNodeInfo", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}