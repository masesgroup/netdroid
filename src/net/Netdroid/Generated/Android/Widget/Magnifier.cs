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
    #region Magnifier declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/widget/Magnifier.html"/>
    /// </summary>
    public partial class Magnifier : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Magnifier>
    {
        const string _bridgeClassName = "android.widget.Magnifier";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Magnifier() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Magnifier(params object[] args) : base(args) { }

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
        #region Builder declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Magnifier.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.widget.Magnifier$Builder";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Builder() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Builder(params object[] args) : base(args) { }

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

    #region Magnifier implementation
    public partial class Magnifier
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Magnifier.html#%3Cinit%3E(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        [global::System.Obsolete()]
        public Magnifier(Android.View.View arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Magnifier.html#SOURCE_BOUND_MAX_IN_SURFACE"/>
        /// </summary>
        public static int SOURCE_BOUND_MAX_IN_SURFACE { get { if (!_SOURCE_BOUND_MAX_IN_SURFACEReady) { _SOURCE_BOUND_MAX_IN_SURFACEContent = SGetField<int>(LocalBridgeClazz, "SOURCE_BOUND_MAX_IN_SURFACE"); _SOURCE_BOUND_MAX_IN_SURFACEReady = true; } return _SOURCE_BOUND_MAX_IN_SURFACEContent; } }
        private static int _SOURCE_BOUND_MAX_IN_SURFACEContent = default;
        private static bool _SOURCE_BOUND_MAX_IN_SURFACEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Magnifier.html#SOURCE_BOUND_MAX_VISIBLE"/>
        /// </summary>
        public static int SOURCE_BOUND_MAX_VISIBLE { get { if (!_SOURCE_BOUND_MAX_VISIBLEReady) { _SOURCE_BOUND_MAX_VISIBLEContent = SGetField<int>(LocalBridgeClazz, "SOURCE_BOUND_MAX_VISIBLE"); _SOURCE_BOUND_MAX_VISIBLEReady = true; } return _SOURCE_BOUND_MAX_VISIBLEContent; } }
        private static int _SOURCE_BOUND_MAX_VISIBLEContent = default;
        private static bool _SOURCE_BOUND_MAX_VISIBLEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Magnifier.html#getOverlay()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable GetOverlay()
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getOverlay", "()Landroid/graphics/drawable/Drawable;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Magnifier.html#getPosition()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Point"/></returns>
        public Android.Graphics.Point GetPosition()
        {
            return IExecuteWithSignature<Android.Graphics.Point>("getPosition", "()Landroid/graphics/Point;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Magnifier.html#getSourcePosition()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Point"/></returns>
        public Android.Graphics.Point GetSourcePosition()
        {
            return IExecuteWithSignature<Android.Graphics.Point>("getSourcePosition", "()Landroid/graphics/Point;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Magnifier.html#isClippingEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsClippingEnabled()
        {
            return IExecuteWithSignature<bool>("isClippingEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Magnifier.html#getCornerRadius()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetCornerRadius()
        {
            return IExecuteWithSignature<float>("getCornerRadius", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Magnifier.html#getElevation()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetElevation()
        {
            return IExecuteWithSignature<float>("getElevation", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Magnifier.html#getZoom()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetZoom()
        {
            return IExecuteWithSignature<float>("getZoom", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Magnifier.html#getDefaultHorizontalSourceToMagnifierOffset()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDefaultHorizontalSourceToMagnifierOffset()
        {
            return IExecuteWithSignature<int>("getDefaultHorizontalSourceToMagnifierOffset", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Magnifier.html#getDefaultVerticalSourceToMagnifierOffset()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDefaultVerticalSourceToMagnifierOffset()
        {
            return IExecuteWithSignature<int>("getDefaultVerticalSourceToMagnifierOffset", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Magnifier.html#getHeight()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetHeight()
        {
            return IExecuteWithSignature<int>("getHeight", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Magnifier.html#getSourceHeight()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSourceHeight()
        {
            return IExecuteWithSignature<int>("getSourceHeight", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Magnifier.html#getSourceWidth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSourceWidth()
        {
            return IExecuteWithSignature<int>("getSourceWidth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Magnifier.html#getWidth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetWidth()
        {
            return IExecuteWithSignature<int>("getWidth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Magnifier.html#dismiss()"/>
        /// </summary>
        public void Dismiss()
        {
            IExecuteWithSignature("dismiss", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Magnifier.html#setZoom(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetZoom(float arg0)
        {
            IExecuteWithSignature("setZoom", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Magnifier.html#show(float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        public void Show(float arg0, float arg1, float arg2, float arg3)
        {
            IExecute("show", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Magnifier.html#show(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public void Show(float arg0, float arg1)
        {
            IExecute("show", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Magnifier.html#update()"/>
        /// </summary>
        public void Update()
        {
            IExecuteWithSignature("update", "()V");
        }

        #endregion

        #region Nested classes
        #region Builder implementation
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/Magnifier.Builder.html#%3Cinit%3E(android.view.View)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.View"/></param>
            public Builder(Android.View.View arg0)
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
            /// <see href="https://developer.android.com/reference/android/widget/Magnifier.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Widget.Magnifier"/></returns>
            public Android.Widget.Magnifier Build()
            {
                return IExecuteWithSignature<Android.Widget.Magnifier>("build", "()Landroid/widget/Magnifier;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/Magnifier.Builder.html#setClippingEnabled(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Widget.Magnifier.Builder"/></returns>
            public Android.Widget.Magnifier.Builder SetClippingEnabled(bool arg0)
            {
                return IExecuteWithSignature<Android.Widget.Magnifier.Builder>("setClippingEnabled", "(Z)Landroid/widget/Magnifier$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/Magnifier.Builder.html#setCornerRadius(float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <returns><see cref="Android.Widget.Magnifier.Builder"/></returns>
            public Android.Widget.Magnifier.Builder SetCornerRadius(float arg0)
            {
                return IExecuteWithSignature<Android.Widget.Magnifier.Builder>("setCornerRadius", "(F)Landroid/widget/Magnifier$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/Magnifier.Builder.html#setDefaultSourceToMagnifierOffset(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="Android.Widget.Magnifier.Builder"/></returns>
            public Android.Widget.Magnifier.Builder SetDefaultSourceToMagnifierOffset(int arg0, int arg1)
            {
                return IExecute<Android.Widget.Magnifier.Builder>("setDefaultSourceToMagnifierOffset", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/Magnifier.Builder.html#setElevation(float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <returns><see cref="Android.Widget.Magnifier.Builder"/></returns>
            public Android.Widget.Magnifier.Builder SetElevation(float arg0)
            {
                return IExecuteWithSignature<Android.Widget.Magnifier.Builder>("setElevation", "(F)Landroid/widget/Magnifier$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/Magnifier.Builder.html#setInitialZoom(float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <returns><see cref="Android.Widget.Magnifier.Builder"/></returns>
            public Android.Widget.Magnifier.Builder SetInitialZoom(float arg0)
            {
                return IExecuteWithSignature<Android.Widget.Magnifier.Builder>("setInitialZoom", "(F)Landroid/widget/Magnifier$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/Magnifier.Builder.html#setOverlay(android.graphics.drawable.Drawable)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
            /// <returns><see cref="Android.Widget.Magnifier.Builder"/></returns>
            public Android.Widget.Magnifier.Builder SetOverlay(Android.Graphics.Drawable.Drawable arg0)
            {
                return IExecuteWithSignature<Android.Widget.Magnifier.Builder>("setOverlay", "(Landroid/graphics/drawable/Drawable;)Landroid/widget/Magnifier$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/Magnifier.Builder.html#setSize(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="Android.Widget.Magnifier.Builder"/></returns>
            public Android.Widget.Magnifier.Builder SetSize(int arg0, int arg1)
            {
                return IExecute<Android.Widget.Magnifier.Builder>("setSize", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/Magnifier.Builder.html#setSourceBounds(int,int,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            /// <returns><see cref="Android.Widget.Magnifier.Builder"/></returns>
            public Android.Widget.Magnifier.Builder SetSourceBounds(int arg0, int arg1, int arg2, int arg3)
            {
                return IExecute<Android.Widget.Magnifier.Builder>("setSourceBounds", arg0, arg1, arg2, arg3);
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