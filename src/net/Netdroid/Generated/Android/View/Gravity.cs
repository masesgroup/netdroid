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

namespace Android.View
{
    #region Gravity declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/view/Gravity.html"/>
    /// </summary>
    public partial class Gravity : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Gravity>
    {
        const string _bridgeClassName = "android.view.Gravity";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Gravity() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Gravity(params object[] args) : base(args) { }
    
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

    #region Gravity implementation
    public partial class Gravity
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Gravity.html#AXIS_CLIP"/>
        /// </summary>
        public static int AXIS_CLIP { get { if (!_AXIS_CLIPReady) { _AXIS_CLIPContent = SGetField<int>(LocalBridgeClazz, "AXIS_CLIP"); _AXIS_CLIPReady = true; } return _AXIS_CLIPContent; } }
        private static int _AXIS_CLIPContent = default;
        private static bool _AXIS_CLIPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Gravity.html#AXIS_PULL_AFTER"/>
        /// </summary>
        public static int AXIS_PULL_AFTER { get { if (!_AXIS_PULL_AFTERReady) { _AXIS_PULL_AFTERContent = SGetField<int>(LocalBridgeClazz, "AXIS_PULL_AFTER"); _AXIS_PULL_AFTERReady = true; } return _AXIS_PULL_AFTERContent; } }
        private static int _AXIS_PULL_AFTERContent = default;
        private static bool _AXIS_PULL_AFTERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Gravity.html#AXIS_PULL_BEFORE"/>
        /// </summary>
        public static int AXIS_PULL_BEFORE { get { if (!_AXIS_PULL_BEFOREReady) { _AXIS_PULL_BEFOREContent = SGetField<int>(LocalBridgeClazz, "AXIS_PULL_BEFORE"); _AXIS_PULL_BEFOREReady = true; } return _AXIS_PULL_BEFOREContent; } }
        private static int _AXIS_PULL_BEFOREContent = default;
        private static bool _AXIS_PULL_BEFOREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Gravity.html#AXIS_SPECIFIED"/>
        /// </summary>
        public static int AXIS_SPECIFIED { get { if (!_AXIS_SPECIFIEDReady) { _AXIS_SPECIFIEDContent = SGetField<int>(LocalBridgeClazz, "AXIS_SPECIFIED"); _AXIS_SPECIFIEDReady = true; } return _AXIS_SPECIFIEDContent; } }
        private static int _AXIS_SPECIFIEDContent = default;
        private static bool _AXIS_SPECIFIEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Gravity.html#AXIS_X_SHIFT"/>
        /// </summary>
        public static int AXIS_X_SHIFT { get { if (!_AXIS_X_SHIFTReady) { _AXIS_X_SHIFTContent = SGetField<int>(LocalBridgeClazz, "AXIS_X_SHIFT"); _AXIS_X_SHIFTReady = true; } return _AXIS_X_SHIFTContent; } }
        private static int _AXIS_X_SHIFTContent = default;
        private static bool _AXIS_X_SHIFTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Gravity.html#AXIS_Y_SHIFT"/>
        /// </summary>
        public static int AXIS_Y_SHIFT { get { if (!_AXIS_Y_SHIFTReady) { _AXIS_Y_SHIFTContent = SGetField<int>(LocalBridgeClazz, "AXIS_Y_SHIFT"); _AXIS_Y_SHIFTReady = true; } return _AXIS_Y_SHIFTContent; } }
        private static int _AXIS_Y_SHIFTContent = default;
        private static bool _AXIS_Y_SHIFTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Gravity.html#BOTTOM"/>
        /// </summary>
        public static int BOTTOM { get { if (!_BOTTOMReady) { _BOTTOMContent = SGetField<int>(LocalBridgeClazz, "BOTTOM"); _BOTTOMReady = true; } return _BOTTOMContent; } }
        private static int _BOTTOMContent = default;
        private static bool _BOTTOMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Gravity.html#CENTER"/>
        /// </summary>
        public static int CENTER { get { if (!_CENTERReady) { _CENTERContent = SGetField<int>(LocalBridgeClazz, "CENTER"); _CENTERReady = true; } return _CENTERContent; } }
        private static int _CENTERContent = default;
        private static bool _CENTERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Gravity.html#CENTER_HORIZONTAL"/>
        /// </summary>
        public static int CENTER_HORIZONTAL { get { if (!_CENTER_HORIZONTALReady) { _CENTER_HORIZONTALContent = SGetField<int>(LocalBridgeClazz, "CENTER_HORIZONTAL"); _CENTER_HORIZONTALReady = true; } return _CENTER_HORIZONTALContent; } }
        private static int _CENTER_HORIZONTALContent = default;
        private static bool _CENTER_HORIZONTALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Gravity.html#CENTER_VERTICAL"/>
        /// </summary>
        public static int CENTER_VERTICAL { get { if (!_CENTER_VERTICALReady) { _CENTER_VERTICALContent = SGetField<int>(LocalBridgeClazz, "CENTER_VERTICAL"); _CENTER_VERTICALReady = true; } return _CENTER_VERTICALContent; } }
        private static int _CENTER_VERTICALContent = default;
        private static bool _CENTER_VERTICALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Gravity.html#CLIP_HORIZONTAL"/>
        /// </summary>
        public static int CLIP_HORIZONTAL { get { if (!_CLIP_HORIZONTALReady) { _CLIP_HORIZONTALContent = SGetField<int>(LocalBridgeClazz, "CLIP_HORIZONTAL"); _CLIP_HORIZONTALReady = true; } return _CLIP_HORIZONTALContent; } }
        private static int _CLIP_HORIZONTALContent = default;
        private static bool _CLIP_HORIZONTALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Gravity.html#CLIP_VERTICAL"/>
        /// </summary>
        public static int CLIP_VERTICAL { get { if (!_CLIP_VERTICALReady) { _CLIP_VERTICALContent = SGetField<int>(LocalBridgeClazz, "CLIP_VERTICAL"); _CLIP_VERTICALReady = true; } return _CLIP_VERTICALContent; } }
        private static int _CLIP_VERTICALContent = default;
        private static bool _CLIP_VERTICALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Gravity.html#DISPLAY_CLIP_HORIZONTAL"/>
        /// </summary>
        public static int DISPLAY_CLIP_HORIZONTAL { get { if (!_DISPLAY_CLIP_HORIZONTALReady) { _DISPLAY_CLIP_HORIZONTALContent = SGetField<int>(LocalBridgeClazz, "DISPLAY_CLIP_HORIZONTAL"); _DISPLAY_CLIP_HORIZONTALReady = true; } return _DISPLAY_CLIP_HORIZONTALContent; } }
        private static int _DISPLAY_CLIP_HORIZONTALContent = default;
        private static bool _DISPLAY_CLIP_HORIZONTALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Gravity.html#DISPLAY_CLIP_VERTICAL"/>
        /// </summary>
        public static int DISPLAY_CLIP_VERTICAL { get { if (!_DISPLAY_CLIP_VERTICALReady) { _DISPLAY_CLIP_VERTICALContent = SGetField<int>(LocalBridgeClazz, "DISPLAY_CLIP_VERTICAL"); _DISPLAY_CLIP_VERTICALReady = true; } return _DISPLAY_CLIP_VERTICALContent; } }
        private static int _DISPLAY_CLIP_VERTICALContent = default;
        private static bool _DISPLAY_CLIP_VERTICALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Gravity.html#END"/>
        /// </summary>
        public static int END { get { if (!_ENDReady) { _ENDContent = SGetField<int>(LocalBridgeClazz, "END"); _ENDReady = true; } return _ENDContent; } }
        private static int _ENDContent = default;
        private static bool _ENDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Gravity.html#FILL"/>
        /// </summary>
        public static int FILL { get { if (!_FILLReady) { _FILLContent = SGetField<int>(LocalBridgeClazz, "FILL"); _FILLReady = true; } return _FILLContent; } }
        private static int _FILLContent = default;
        private static bool _FILLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Gravity.html#FILL_HORIZONTAL"/>
        /// </summary>
        public static int FILL_HORIZONTAL { get { if (!_FILL_HORIZONTALReady) { _FILL_HORIZONTALContent = SGetField<int>(LocalBridgeClazz, "FILL_HORIZONTAL"); _FILL_HORIZONTALReady = true; } return _FILL_HORIZONTALContent; } }
        private static int _FILL_HORIZONTALContent = default;
        private static bool _FILL_HORIZONTALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Gravity.html#FILL_VERTICAL"/>
        /// </summary>
        public static int FILL_VERTICAL { get { if (!_FILL_VERTICALReady) { _FILL_VERTICALContent = SGetField<int>(LocalBridgeClazz, "FILL_VERTICAL"); _FILL_VERTICALReady = true; } return _FILL_VERTICALContent; } }
        private static int _FILL_VERTICALContent = default;
        private static bool _FILL_VERTICALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Gravity.html#HORIZONTAL_GRAVITY_MASK"/>
        /// </summary>
        public static int HORIZONTAL_GRAVITY_MASK { get { if (!_HORIZONTAL_GRAVITY_MASKReady) { _HORIZONTAL_GRAVITY_MASKContent = SGetField<int>(LocalBridgeClazz, "HORIZONTAL_GRAVITY_MASK"); _HORIZONTAL_GRAVITY_MASKReady = true; } return _HORIZONTAL_GRAVITY_MASKContent; } }
        private static int _HORIZONTAL_GRAVITY_MASKContent = default;
        private static bool _HORIZONTAL_GRAVITY_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Gravity.html#LEFT"/>
        /// </summary>
        public static int LEFT { get { if (!_LEFTReady) { _LEFTContent = SGetField<int>(LocalBridgeClazz, "LEFT"); _LEFTReady = true; } return _LEFTContent; } }
        private static int _LEFTContent = default;
        private static bool _LEFTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Gravity.html#NO_GRAVITY"/>
        /// </summary>
        public static int NO_GRAVITY { get { if (!_NO_GRAVITYReady) { _NO_GRAVITYContent = SGetField<int>(LocalBridgeClazz, "NO_GRAVITY"); _NO_GRAVITYReady = true; } return _NO_GRAVITYContent; } }
        private static int _NO_GRAVITYContent = default;
        private static bool _NO_GRAVITYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Gravity.html#RELATIVE_HORIZONTAL_GRAVITY_MASK"/>
        /// </summary>
        public static int RELATIVE_HORIZONTAL_GRAVITY_MASK { get { if (!_RELATIVE_HORIZONTAL_GRAVITY_MASKReady) { _RELATIVE_HORIZONTAL_GRAVITY_MASKContent = SGetField<int>(LocalBridgeClazz, "RELATIVE_HORIZONTAL_GRAVITY_MASK"); _RELATIVE_HORIZONTAL_GRAVITY_MASKReady = true; } return _RELATIVE_HORIZONTAL_GRAVITY_MASKContent; } }
        private static int _RELATIVE_HORIZONTAL_GRAVITY_MASKContent = default;
        private static bool _RELATIVE_HORIZONTAL_GRAVITY_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Gravity.html#RELATIVE_LAYOUT_DIRECTION"/>
        /// </summary>
        public static int RELATIVE_LAYOUT_DIRECTION { get { if (!_RELATIVE_LAYOUT_DIRECTIONReady) { _RELATIVE_LAYOUT_DIRECTIONContent = SGetField<int>(LocalBridgeClazz, "RELATIVE_LAYOUT_DIRECTION"); _RELATIVE_LAYOUT_DIRECTIONReady = true; } return _RELATIVE_LAYOUT_DIRECTIONContent; } }
        private static int _RELATIVE_LAYOUT_DIRECTIONContent = default;
        private static bool _RELATIVE_LAYOUT_DIRECTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Gravity.html#RIGHT"/>
        /// </summary>
        public static int RIGHT { get { if (!_RIGHTReady) { _RIGHTContent = SGetField<int>(LocalBridgeClazz, "RIGHT"); _RIGHTReady = true; } return _RIGHTContent; } }
        private static int _RIGHTContent = default;
        private static bool _RIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Gravity.html#START"/>
        /// </summary>
        public static int START { get { if (!_STARTReady) { _STARTContent = SGetField<int>(LocalBridgeClazz, "START"); _STARTReady = true; } return _STARTContent; } }
        private static int _STARTContent = default;
        private static bool _STARTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Gravity.html#TOP"/>
        /// </summary>
        public static int TOP { get { if (!_TOPReady) { _TOPContent = SGetField<int>(LocalBridgeClazz, "TOP"); _TOPReady = true; } return _TOPContent; } }
        private static int _TOPContent = default;
        private static bool _TOPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Gravity.html#VERTICAL_GRAVITY_MASK"/>
        /// </summary>
        public static int VERTICAL_GRAVITY_MASK { get { if (!_VERTICAL_GRAVITY_MASKReady) { _VERTICAL_GRAVITY_MASKContent = SGetField<int>(LocalBridgeClazz, "VERTICAL_GRAVITY_MASK"); _VERTICAL_GRAVITY_MASKReady = true; } return _VERTICAL_GRAVITY_MASKContent; } }
        private static int _VERTICAL_GRAVITY_MASKContent = default;
        private static bool _VERTICAL_GRAVITY_MASKReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Gravity.html#isHorizontal(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsHorizontal(int arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isHorizontal", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Gravity.html#isVertical(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsVertical(int arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isVertical", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Gravity.html#getAbsoluteGravity(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetAbsoluteGravity(int arg0, int arg1)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getAbsoluteGravity", "(II)I", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Gravity.html#apply(int,int,int,android.graphics.Rect,android.graphics.Rect,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.Graphics.Rect"/></param>
        /// <param name="arg4"><see cref="Android.Graphics.Rect"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        public static void Apply(int arg0, int arg1, int arg2, Android.Graphics.Rect arg3, Android.Graphics.Rect arg4, int arg5)
        {
            SExecuteWithSignature(LocalBridgeClazz, "apply", "(IIILandroid/graphics/Rect;Landroid/graphics/Rect;I)V", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Gravity.html#apply(int,int,int,android.graphics.Rect,android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.Graphics.Rect"/></param>
        /// <param name="arg4"><see cref="Android.Graphics.Rect"/></param>
        public static void Apply(int arg0, int arg1, int arg2, Android.Graphics.Rect arg3, Android.Graphics.Rect arg4)
        {
            SExecuteWithSignature(LocalBridgeClazz, "apply", "(IIILandroid/graphics/Rect;Landroid/graphics/Rect;)V", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Gravity.html#apply(int,int,int,android.graphics.Rect,int,int,android.graphics.Rect,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.Graphics.Rect"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="Android.Graphics.Rect"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        public static void Apply(int arg0, int arg1, int arg2, Android.Graphics.Rect arg3, int arg4, int arg5, Android.Graphics.Rect arg6, int arg7)
        {
            SExecuteWithSignature(LocalBridgeClazz, "apply", "(IIILandroid/graphics/Rect;IILandroid/graphics/Rect;I)V", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Gravity.html#apply(int,int,int,android.graphics.Rect,int,int,android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.Graphics.Rect"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="Android.Graphics.Rect"/></param>
        public static void Apply(int arg0, int arg1, int arg2, Android.Graphics.Rect arg3, int arg4, int arg5, Android.Graphics.Rect arg6)
        {
            SExecuteWithSignature(LocalBridgeClazz, "apply", "(IIILandroid/graphics/Rect;IILandroid/graphics/Rect;)V", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Gravity.html#applyDisplay(int,android.graphics.Rect,android.graphics.Rect,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Rect"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.Rect"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public static void ApplyDisplay(int arg0, Android.Graphics.Rect arg1, Android.Graphics.Rect arg2, int arg3)
        {
            SExecuteWithSignature(LocalBridgeClazz, "applyDisplay", "(ILandroid/graphics/Rect;Landroid/graphics/Rect;I)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/Gravity.html#applyDisplay(int,android.graphics.Rect,android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Rect"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.Rect"/></param>
        public static void ApplyDisplay(int arg0, Android.Graphics.Rect arg1, Android.Graphics.Rect arg2)
        {
            SExecuteWithSignature(LocalBridgeClazz, "applyDisplay", "(ILandroid/graphics/Rect;Landroid/graphics/Rect;)V", arg0, arg1, arg2);
        }
    
        #endregion
    
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}