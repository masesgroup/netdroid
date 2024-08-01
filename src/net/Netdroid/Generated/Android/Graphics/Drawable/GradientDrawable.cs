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

namespace Android.Graphics.Drawable
{
    #region GradientDrawable
    public partial class GradientDrawable
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#%3Cinit%3E(android.graphics.drawable.GradientDrawable.Orientation,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.GradientDrawable.Orientation"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public GradientDrawable(Android.Graphics.Drawable.GradientDrawable.Orientation arg0, int[] arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#LINE"/>
        /// </summary>
        public static int LINE { get { if (!_LINEReady) { _LINEContent = SGetField<int>(LocalBridgeClazz, "LINE"); _LINEReady = true; } return _LINEContent; } }
        private static int _LINEContent = default;
        private static bool _LINEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#LINEAR_GRADIENT"/>
        /// </summary>
        public static int LINEAR_GRADIENT { get { if (!_LINEAR_GRADIENTReady) { _LINEAR_GRADIENTContent = SGetField<int>(LocalBridgeClazz, "LINEAR_GRADIENT"); _LINEAR_GRADIENTReady = true; } return _LINEAR_GRADIENTContent; } }
        private static int _LINEAR_GRADIENTContent = default;
        private static bool _LINEAR_GRADIENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#OVAL"/>
        /// </summary>
        public static int OVAL { get { if (!_OVALReady) { _OVALContent = SGetField<int>(LocalBridgeClazz, "OVAL"); _OVALReady = true; } return _OVALContent; } }
        private static int _OVALContent = default;
        private static bool _OVALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#RADIAL_GRADIENT"/>
        /// </summary>
        public static int RADIAL_GRADIENT { get { if (!_RADIAL_GRADIENTReady) { _RADIAL_GRADIENTContent = SGetField<int>(LocalBridgeClazz, "RADIAL_GRADIENT"); _RADIAL_GRADIENTReady = true; } return _RADIAL_GRADIENTContent; } }
        private static int _RADIAL_GRADIENTContent = default;
        private static bool _RADIAL_GRADIENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#RECTANGLE"/>
        /// </summary>
        public static int RECTANGLE { get { if (!_RECTANGLEReady) { _RECTANGLEContent = SGetField<int>(LocalBridgeClazz, "RECTANGLE"); _RECTANGLEReady = true; } return _RECTANGLEContent; } }
        private static int _RECTANGLEContent = default;
        private static bool _RECTANGLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#RING"/>
        /// </summary>
        public static int RING { get { if (!_RINGReady) { _RINGContent = SGetField<int>(LocalBridgeClazz, "RING"); _RINGReady = true; } return _RINGContent; } }
        private static int _RINGContent = default;
        private static bool _RINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#SWEEP_GRADIENT"/>
        /// </summary>
        public static int SWEEP_GRADIENT { get { if (!_SWEEP_GRADIENTReady) { _SWEEP_GRADIENTContent = SGetField<int>(LocalBridgeClazz, "SWEEP_GRADIENT"); _SWEEP_GRADIENTReady = true; } return _SWEEP_GRADIENTContent; } }
        private static int _SWEEP_GRADIENTContent = default;
        private static bool _SWEEP_GRADIENTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#getColor()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Res.ColorStateList"/></returns>
        public Android.Content.Res.ColorStateList GetColor()
        {
            return IExecuteWithSignature<Android.Content.Res.ColorStateList>("getColor", "()Landroid/content/res/ColorStateList;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#getOrientation()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Drawable.GradientDrawable.Orientation"/></returns>
        public Android.Graphics.Drawable.GradientDrawable.Orientation GetOrientation()
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.GradientDrawable.Orientation>("getOrientation", "()Landroid/graphics/drawable/GradientDrawable$Orientation;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#getUseLevel()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetUseLevel()
        {
            return IExecuteWithSignature<bool>("getUseLevel", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#getCornerRadius()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetCornerRadius()
        {
            return IExecuteWithSignature<float>("getCornerRadius", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#getGradientCenterX()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetGradientCenterX()
        {
            return IExecuteWithSignature<float>("getGradientCenterX", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#getGradientCenterY()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetGradientCenterY()
        {
            return IExecuteWithSignature<float>("getGradientCenterY", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#getGradientRadius()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetGradientRadius()
        {
            return IExecuteWithSignature<float>("getGradientRadius", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#getInnerRadiusRatio()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetInnerRadiusRatio()
        {
            return IExecuteWithSignature<float>("getInnerRadiusRatio", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#getThicknessRatio()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetThicknessRatio()
        {
            return IExecuteWithSignature<float>("getThicknessRatio", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#getCornerRadii()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float[] GetCornerRadii()
        {
            return IExecuteWithSignatureArray<float>("getCornerRadii", "()[F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#getGradientType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetGradientType()
        {
            return IExecuteWithSignature<int>("getGradientType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#getInnerRadius()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetInnerRadius()
        {
            return IExecuteWithSignature<int>("getInnerRadius", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#getShape()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetShape()
        {
            return IExecuteWithSignature<int>("getShape", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#getThickness()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetThickness()
        {
            return IExecuteWithSignature<int>("getThickness", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#getColors()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int[] GetColors()
        {
            return IExecuteWithSignatureArray<int>("getColors", "()[I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#setColor(android.content.res.ColorStateList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Res.ColorStateList"/></param>
        public void SetColor(Android.Content.Res.ColorStateList arg0)
        {
            IExecuteWithSignature("setColor", "(Landroid/content/res/ColorStateList;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#setColor(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetColor(int arg0)
        {
            IExecuteWithSignature("setColor", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#setColors(int[],float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public void SetColors(int[] arg0, float[] arg1)
        {
            IExecute("setColors", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#setColors(int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetColors(int[] arg0)
        {
            IExecuteWithSignature("setColors", "([I)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#setCornerRadii(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetCornerRadii(float[] arg0)
        {
            IExecuteWithSignature("setCornerRadii", "([F)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#setCornerRadius(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetCornerRadius(float arg0)
        {
            IExecuteWithSignature("setCornerRadius", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#setGradientCenter(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public void SetGradientCenter(float arg0, float arg1)
        {
            IExecute("setGradientCenter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#setGradientRadius(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetGradientRadius(float arg0)
        {
            IExecuteWithSignature("setGradientRadius", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#setGradientType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetGradientType(int arg0)
        {
            IExecuteWithSignature("setGradientType", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#setInnerRadius(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetInnerRadius(int arg0)
        {
            IExecuteWithSignature("setInnerRadius", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#setInnerRadiusRatio(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetInnerRadiusRatio(float arg0)
        {
            IExecuteWithSignature("setInnerRadiusRatio", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#setOrientation(android.graphics.drawable.GradientDrawable.Orientation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.GradientDrawable.Orientation"/></param>
        public void SetOrientation(Android.Graphics.Drawable.GradientDrawable.Orientation arg0)
        {
            IExecuteWithSignature("setOrientation", "(Landroid/graphics/drawable/GradientDrawable$Orientation;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#setPadding(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void SetPadding(int arg0, int arg1, int arg2, int arg3)
        {
            IExecute("setPadding", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#setShape(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetShape(int arg0)
        {
            IExecuteWithSignature("setShape", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#setSize(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetSize(int arg0, int arg1)
        {
            IExecute("setSize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#setStroke(int,android.content.res.ColorStateList,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Content.Res.ColorStateList"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        public void SetStroke(int arg0, Android.Content.Res.ColorStateList arg1, float arg2, float arg3)
        {
            IExecute("setStroke", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#setStroke(int,android.content.res.ColorStateList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Content.Res.ColorStateList"/></param>
        public void SetStroke(int arg0, Android.Content.Res.ColorStateList arg1)
        {
            IExecute("setStroke", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#setStroke(int,int,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        public void SetStroke(int arg0, int arg1, float arg2, float arg3)
        {
            IExecute("setStroke", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#setStroke(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetStroke(int arg0, int arg1)
        {
            IExecute("setStroke", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#setThickness(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetThickness(int arg0)
        {
            IExecuteWithSignature("setThickness", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#setThicknessRatio(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetThicknessRatio(float arg0)
        {
            IExecuteWithSignature("setThicknessRatio", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.html#setUseLevel(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetUseLevel(bool arg0)
        {
            IExecuteWithSignature("setUseLevel", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes
        #region Orientation
        public partial class Orientation
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.Orientation.html#BL_TR"/>
            /// </summary>
            public static Android.Graphics.Drawable.GradientDrawable.Orientation BL_TR { get { if (!_BL_TRReady) { _BL_TRContent = SGetField<Android.Graphics.Drawable.GradientDrawable.Orientation>(LocalBridgeClazz, "BL_TR"); _BL_TRReady = true; } return _BL_TRContent; } }
            private static Android.Graphics.Drawable.GradientDrawable.Orientation _BL_TRContent = default;
            private static bool _BL_TRReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.Orientation.html#BOTTOM_TOP"/>
            /// </summary>
            public static Android.Graphics.Drawable.GradientDrawable.Orientation BOTTOM_TOP { get { if (!_BOTTOM_TOPReady) { _BOTTOM_TOPContent = SGetField<Android.Graphics.Drawable.GradientDrawable.Orientation>(LocalBridgeClazz, "BOTTOM_TOP"); _BOTTOM_TOPReady = true; } return _BOTTOM_TOPContent; } }
            private static Android.Graphics.Drawable.GradientDrawable.Orientation _BOTTOM_TOPContent = default;
            private static bool _BOTTOM_TOPReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.Orientation.html#BR_TL"/>
            /// </summary>
            public static Android.Graphics.Drawable.GradientDrawable.Orientation BR_TL { get { if (!_BR_TLReady) { _BR_TLContent = SGetField<Android.Graphics.Drawable.GradientDrawable.Orientation>(LocalBridgeClazz, "BR_TL"); _BR_TLReady = true; } return _BR_TLContent; } }
            private static Android.Graphics.Drawable.GradientDrawable.Orientation _BR_TLContent = default;
            private static bool _BR_TLReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.Orientation.html#LEFT_RIGHT"/>
            /// </summary>
            public static Android.Graphics.Drawable.GradientDrawable.Orientation LEFT_RIGHT { get { if (!_LEFT_RIGHTReady) { _LEFT_RIGHTContent = SGetField<Android.Graphics.Drawable.GradientDrawable.Orientation>(LocalBridgeClazz, "LEFT_RIGHT"); _LEFT_RIGHTReady = true; } return _LEFT_RIGHTContent; } }
            private static Android.Graphics.Drawable.GradientDrawable.Orientation _LEFT_RIGHTContent = default;
            private static bool _LEFT_RIGHTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.Orientation.html#RIGHT_LEFT"/>
            /// </summary>
            public static Android.Graphics.Drawable.GradientDrawable.Orientation RIGHT_LEFT { get { if (!_RIGHT_LEFTReady) { _RIGHT_LEFTContent = SGetField<Android.Graphics.Drawable.GradientDrawable.Orientation>(LocalBridgeClazz, "RIGHT_LEFT"); _RIGHT_LEFTReady = true; } return _RIGHT_LEFTContent; } }
            private static Android.Graphics.Drawable.GradientDrawable.Orientation _RIGHT_LEFTContent = default;
            private static bool _RIGHT_LEFTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.Orientation.html#TL_BR"/>
            /// </summary>
            public static Android.Graphics.Drawable.GradientDrawable.Orientation TL_BR { get { if (!_TL_BRReady) { _TL_BRContent = SGetField<Android.Graphics.Drawable.GradientDrawable.Orientation>(LocalBridgeClazz, "TL_BR"); _TL_BRReady = true; } return _TL_BRContent; } }
            private static Android.Graphics.Drawable.GradientDrawable.Orientation _TL_BRContent = default;
            private static bool _TL_BRReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.Orientation.html#TOP_BOTTOM"/>
            /// </summary>
            public static Android.Graphics.Drawable.GradientDrawable.Orientation TOP_BOTTOM { get { if (!_TOP_BOTTOMReady) { _TOP_BOTTOMContent = SGetField<Android.Graphics.Drawable.GradientDrawable.Orientation>(LocalBridgeClazz, "TOP_BOTTOM"); _TOP_BOTTOMReady = true; } return _TOP_BOTTOMContent; } }
            private static Android.Graphics.Drawable.GradientDrawable.Orientation _TOP_BOTTOMContent = default;
            private static bool _TOP_BOTTOMReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.Orientation.html#TR_BL"/>
            /// </summary>
            public static Android.Graphics.Drawable.GradientDrawable.Orientation TR_BL { get { if (!_TR_BLReady) { _TR_BLContent = SGetField<Android.Graphics.Drawable.GradientDrawable.Orientation>(LocalBridgeClazz, "TR_BL"); _TR_BLReady = true; } return _TR_BLContent; } }
            private static Android.Graphics.Drawable.GradientDrawable.Orientation _TR_BLContent = default;
            private static bool _TR_BLReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.Orientation.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Graphics.Drawable.GradientDrawable.Orientation"/></returns>
            public static Android.Graphics.Drawable.GradientDrawable.Orientation ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Graphics.Drawable.GradientDrawable.Orientation>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/graphics/drawable/GradientDrawable$Orientation;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/drawable/GradientDrawable.Orientation.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Graphics.Drawable.GradientDrawable.Orientation"/></returns>
            public static Android.Graphics.Drawable.GradientDrawable.Orientation[] Values()
            {
                return SExecuteWithSignatureArray<Android.Graphics.Drawable.GradientDrawable.Orientation>(LocalBridgeClazz, "values", "()[Landroid/graphics/drawable/GradientDrawable$Orientation;");
            }

            #endregion

            #region Instance methods

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