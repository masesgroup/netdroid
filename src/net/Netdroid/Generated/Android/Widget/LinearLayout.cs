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

namespace Android.Widget
{
    #region LinearLayout declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.html"/>
    /// </summary>
    public partial class LinearLayout : Android.View.ViewGroup
    {
        const string _bridgeClassName = "android.widget.LinearLayout";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public LinearLayout() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public LinearLayout(params object[] args) : base(args) { }
    
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
        #region LayoutParams declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.LayoutParams.html"/>
        /// </summary>
        public partial class LayoutParams : Android.View.ViewGroup.MarginLayoutParams
        {
            const string _bridgeClassName = "android.widget.LinearLayout$LayoutParams";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public LayoutParams() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public LayoutParams(params object[] args) : base(args) { }
        
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
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

    
    }
    #endregion

    #region LinearLayout implementation
    public partial class LinearLayout
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public LinearLayout(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public LinearLayout(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public LinearLayout(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public LinearLayout(Android.Content.Context arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.html#HORIZONTAL"/>
        /// </summary>
        public static int HORIZONTAL { get { if (!_HORIZONTALReady) { _HORIZONTALContent = SGetField<int>(LocalBridgeClazz, "HORIZONTAL"); _HORIZONTALReady = true; } return _HORIZONTALContent; } }
        private static int _HORIZONTALContent = default;
        private static bool _HORIZONTALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.html#SHOW_DIVIDER_BEGINNING"/>
        /// </summary>
        public static int SHOW_DIVIDER_BEGINNING { get { if (!_SHOW_DIVIDER_BEGINNINGReady) { _SHOW_DIVIDER_BEGINNINGContent = SGetField<int>(LocalBridgeClazz, "SHOW_DIVIDER_BEGINNING"); _SHOW_DIVIDER_BEGINNINGReady = true; } return _SHOW_DIVIDER_BEGINNINGContent; } }
        private static int _SHOW_DIVIDER_BEGINNINGContent = default;
        private static bool _SHOW_DIVIDER_BEGINNINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.html#SHOW_DIVIDER_END"/>
        /// </summary>
        public static int SHOW_DIVIDER_END { get { if (!_SHOW_DIVIDER_ENDReady) { _SHOW_DIVIDER_ENDContent = SGetField<int>(LocalBridgeClazz, "SHOW_DIVIDER_END"); _SHOW_DIVIDER_ENDReady = true; } return _SHOW_DIVIDER_ENDContent; } }
        private static int _SHOW_DIVIDER_ENDContent = default;
        private static bool _SHOW_DIVIDER_ENDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.html#SHOW_DIVIDER_MIDDLE"/>
        /// </summary>
        public static int SHOW_DIVIDER_MIDDLE { get { if (!_SHOW_DIVIDER_MIDDLEReady) { _SHOW_DIVIDER_MIDDLEContent = SGetField<int>(LocalBridgeClazz, "SHOW_DIVIDER_MIDDLE"); _SHOW_DIVIDER_MIDDLEReady = true; } return _SHOW_DIVIDER_MIDDLEContent; } }
        private static int _SHOW_DIVIDER_MIDDLEContent = default;
        private static bool _SHOW_DIVIDER_MIDDLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.html#SHOW_DIVIDER_NONE"/>
        /// </summary>
        public static int SHOW_DIVIDER_NONE { get { if (!_SHOW_DIVIDER_NONEReady) { _SHOW_DIVIDER_NONEContent = SGetField<int>(LocalBridgeClazz, "SHOW_DIVIDER_NONE"); _SHOW_DIVIDER_NONEReady = true; } return _SHOW_DIVIDER_NONEContent; } }
        private static int _SHOW_DIVIDER_NONEContent = default;
        private static bool _SHOW_DIVIDER_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.html#VERTICAL"/>
        /// </summary>
        public static int VERTICAL { get { if (!_VERTICALReady) { _VERTICALContent = SGetField<int>(LocalBridgeClazz, "VERTICAL"); _VERTICALReady = true; } return _VERTICALContent; } }
        private static int _VERTICALContent = default;
        private static bool _VERTICALReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.html#getDividerDrawable()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable GetDividerDrawable()
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getDividerDrawable", "()Landroid/graphics/drawable/Drawable;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.html#isBaselineAligned()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsBaselineAligned()
        {
            return IExecuteWithSignature<bool>("isBaselineAligned", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.html#isMeasureWithLargestChildEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsMeasureWithLargestChildEnabled()
        {
            return IExecuteWithSignature<bool>("isMeasureWithLargestChildEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.html#getWeightSum()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetWeightSum()
        {
            return IExecuteWithSignature<float>("getWeightSum", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.html#getBaselineAlignedChildIndex()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetBaselineAlignedChildIndex()
        {
            return IExecuteWithSignature<int>("getBaselineAlignedChildIndex", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.html#getDividerPadding()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDividerPadding()
        {
            return IExecuteWithSignature<int>("getDividerPadding", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.html#getGravity()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetGravity()
        {
            return IExecuteWithSignature<int>("getGravity", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.html#getOrientation()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetOrientation()
        {
            return IExecuteWithSignature<int>("getOrientation", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.html#getShowDividers()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetShowDividers()
        {
            return IExecuteWithSignature<int>("getShowDividers", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.html#setBaselineAligned(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetBaselineAligned(bool arg0)
        {
            IExecuteWithSignature("setBaselineAligned", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.html#setBaselineAlignedChildIndex(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetBaselineAlignedChildIndex(int arg0)
        {
            IExecuteWithSignature("setBaselineAlignedChildIndex", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.html#setDividerDrawable(android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        public void SetDividerDrawable(Android.Graphics.Drawable.Drawable arg0)
        {
            IExecuteWithSignature("setDividerDrawable", "(Landroid/graphics/drawable/Drawable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.html#setDividerPadding(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetDividerPadding(int arg0)
        {
            IExecuteWithSignature("setDividerPadding", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.html#setGravity(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetGravity(int arg0)
        {
            IExecuteWithSignature("setGravity", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.html#setHorizontalGravity(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetHorizontalGravity(int arg0)
        {
            IExecuteWithSignature("setHorizontalGravity", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.html#setMeasureWithLargestChildEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetMeasureWithLargestChildEnabled(bool arg0)
        {
            IExecuteWithSignature("setMeasureWithLargestChildEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.html#setOrientation(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetOrientation(int arg0)
        {
            IExecuteWithSignature("setOrientation", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.html#setShowDividers(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetShowDividers(int arg0)
        {
            IExecuteWithSignature("setShowDividers", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.html#setVerticalGravity(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetVerticalGravity(int arg0)
        {
            IExecuteWithSignature("setVerticalGravity", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.html#setWeightSum(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetWeightSum(float arg0)
        {
            IExecuteWithSignature("setWeightSum", "(F)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
        #region LayoutParams implementation
        public partial class LayoutParams
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.LayoutParams.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Context"/></param>
            /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
            public LayoutParams(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
                : base(arg0, arg1)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.LayoutParams.html#%3Cinit%3E(android.view.ViewGroup.LayoutParams)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.ViewGroup.LayoutParams"/></param>
            public LayoutParams(Android.View.ViewGroup.LayoutParams arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.LayoutParams.html#%3Cinit%3E(android.view.ViewGroup.MarginLayoutParams)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.ViewGroup.MarginLayoutParams"/></param>
            public LayoutParams(Android.View.ViewGroup.MarginLayoutParams arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.LayoutParams.html#%3Cinit%3E(android.widget.LinearLayout.LayoutParams)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.LinearLayout.LayoutParams"/></param>
            public LayoutParams(Android.Widget.LinearLayout.LayoutParams arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.LayoutParams.html#%3Cinit%3E(int,int,float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="float"/></param>
            public LayoutParams(int arg0, int arg1, float arg2)
                : base(arg0, arg1, arg2)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.LayoutParams.html#%3Cinit%3E(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public LayoutParams(int arg0, int arg1)
                : base(arg0, arg1)
            {
            }
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.LayoutParams.html#weight"/>
            /// </summary>
            public float weight { get { return IGetField<float>("weight"); } set { ISetField("weight", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.LayoutParams.html#gravity"/>
            /// </summary>
            public int gravity { get { return IGetField<int>("gravity"); } set { ISetField("gravity", value); } }
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/LinearLayout.LayoutParams.html#debug(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String Debug(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Java.Lang.String>("debug", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
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