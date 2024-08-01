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

namespace Android.View
{
    #region ViewConfiguration
    public partial class ViewConfiguration
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#get(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <returns><see cref="Android.View.ViewConfiguration"/></returns>
        public static Android.View.ViewConfiguration Get(Android.Content.Context arg0)
        {
            return SExecuteWithSignature<Android.View.ViewConfiguration>(LocalBridgeClazz, "get", "(Landroid/content/Context;)Landroid/view/ViewConfiguration;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getAmbiguousGestureMultiplier()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        [global::System.Obsolete()]
        public static float GetAmbiguousGestureMultiplier()
        {
            return SExecuteWithSignature<float>(LocalBridgeClazz, "getAmbiguousGestureMultiplier", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScrollFriction()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public static float GetScrollFriction()
        {
            return SExecuteWithSignature<float>(LocalBridgeClazz, "getScrollFriction", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getDoubleTapTimeout()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int GetDoubleTapTimeout()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getDoubleTapTimeout", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getEdgeSlop()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public static int GetEdgeSlop()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getEdgeSlop", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getFadingEdgeLength()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public static int GetFadingEdgeLength()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getFadingEdgeLength", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getJumpTapTimeout()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int GetJumpTapTimeout()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getJumpTapTimeout", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getKeyRepeatDelay()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int GetKeyRepeatDelay()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getKeyRepeatDelay", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getKeyRepeatTimeout()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int GetKeyRepeatTimeout()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getKeyRepeatTimeout", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getLongPressTimeout()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int GetLongPressTimeout()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getLongPressTimeout", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getMaximumDrawingCacheSize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public static int GetMaximumDrawingCacheSize()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getMaximumDrawingCacheSize", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getMaximumFlingVelocity()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public static int GetMaximumFlingVelocity()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getMaximumFlingVelocity", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getMinimumFlingVelocity()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public static int GetMinimumFlingVelocity()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getMinimumFlingVelocity", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getMultiPressTimeout()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int GetMultiPressTimeout()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getMultiPressTimeout", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getPressedStateDuration()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int GetPressedStateDuration()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getPressedStateDuration", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScrollBarFadeDuration()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int GetScrollBarFadeDuration()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getScrollBarFadeDuration", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScrollBarSize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public static int GetScrollBarSize()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getScrollBarSize", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScrollDefaultDelay()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int GetScrollDefaultDelay()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getScrollDefaultDelay", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getTapTimeout()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int GetTapTimeout()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getTapTimeout", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getTouchSlop()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public static int GetTouchSlop()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getTouchSlop", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getWindowTouchSlop()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public static int GetWindowTouchSlop()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getWindowTouchSlop", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getDefaultActionModeHideDuration()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public static long GetDefaultActionModeHideDuration()
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "getDefaultActionModeHideDuration", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getGlobalActionKeyTimeout()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        [global::System.Obsolete()]
        public static long GetGlobalActionKeyTimeout()
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "getGlobalActionKeyTimeout", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getZoomControlsTimeout()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public static long GetZoomControlsTimeout()
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "getZoomControlsTimeout", "()J");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#hasPermanentMenuKey()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasPermanentMenuKey()
        {
            return IExecuteWithSignature<bool>("hasPermanentMenuKey", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#shouldShowMenuShortcutsWhenKeyboardPresent()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool ShouldShowMenuShortcutsWhenKeyboardPresent()
        {
            return IExecuteWithSignature<bool>("shouldShowMenuShortcutsWhenKeyboardPresent", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledAmbiguousGestureMultiplier()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetScaledAmbiguousGestureMultiplier()
        {
            return IExecuteWithSignature<float>("getScaledAmbiguousGestureMultiplier", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledHorizontalScrollFactor()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetScaledHorizontalScrollFactor()
        {
            return IExecuteWithSignature<float>("getScaledHorizontalScrollFactor", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledVerticalScrollFactor()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetScaledVerticalScrollFactor()
        {
            return IExecuteWithSignature<float>("getScaledVerticalScrollFactor", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledDoubleTapSlop()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetScaledDoubleTapSlop()
        {
            return IExecuteWithSignature<int>("getScaledDoubleTapSlop", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledEdgeSlop()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetScaledEdgeSlop()
        {
            return IExecuteWithSignature<int>("getScaledEdgeSlop", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledFadingEdgeLength()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetScaledFadingEdgeLength()
        {
            return IExecuteWithSignature<int>("getScaledFadingEdgeLength", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledHandwritingGestureLineMargin()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetScaledHandwritingGestureLineMargin()
        {
            return IExecuteWithSignature<int>("getScaledHandwritingGestureLineMargin", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledHandwritingSlop()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetScaledHandwritingSlop()
        {
            return IExecuteWithSignature<int>("getScaledHandwritingSlop", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledHoverSlop()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetScaledHoverSlop()
        {
            return IExecuteWithSignature<int>("getScaledHoverSlop", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledMaximumDrawingCacheSize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetScaledMaximumDrawingCacheSize()
        {
            return IExecuteWithSignature<int>("getScaledMaximumDrawingCacheSize", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledMaximumFlingVelocity()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetScaledMaximumFlingVelocity()
        {
            return IExecuteWithSignature<int>("getScaledMaximumFlingVelocity", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledMaximumFlingVelocity(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetScaledMaximumFlingVelocity(int arg0, int arg1, int arg2)
        {
            return IExecute<int>("getScaledMaximumFlingVelocity", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledMinimumFlingVelocity()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetScaledMinimumFlingVelocity()
        {
            return IExecuteWithSignature<int>("getScaledMinimumFlingVelocity", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledMinimumFlingVelocity(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetScaledMinimumFlingVelocity(int arg0, int arg1, int arg2)
        {
            return IExecute<int>("getScaledMinimumFlingVelocity", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledMinimumScalingSpan()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetScaledMinimumScalingSpan()
        {
            return IExecuteWithSignature<int>("getScaledMinimumScalingSpan", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledOverflingDistance()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetScaledOverflingDistance()
        {
            return IExecuteWithSignature<int>("getScaledOverflingDistance", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledOverscrollDistance()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetScaledOverscrollDistance()
        {
            return IExecuteWithSignature<int>("getScaledOverscrollDistance", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledPagingTouchSlop()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetScaledPagingTouchSlop()
        {
            return IExecuteWithSignature<int>("getScaledPagingTouchSlop", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledScrollBarSize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetScaledScrollBarSize()
        {
            return IExecuteWithSignature<int>("getScaledScrollBarSize", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledTouchSlop()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetScaledTouchSlop()
        {
            return IExecuteWithSignature<int>("getScaledTouchSlop", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledWindowTouchSlop()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetScaledWindowTouchSlop()
        {
            return IExecuteWithSignature<int>("getScaledWindowTouchSlop", "()I");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}