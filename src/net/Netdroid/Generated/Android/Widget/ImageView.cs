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

namespace Android.Widget
{
    #region ImageView
    public partial class ImageView
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public ImageView(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public ImageView(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public ImageView(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public ImageView(Android.Content.Context arg0)
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
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#getImageTintList()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Res.ColorStateList"/></returns>
        public Android.Content.Res.ColorStateList GetImageTintList()
        {
            return IExecuteWithSignature<Android.Content.Res.ColorStateList>("getImageTintList", "()Landroid/content/res/ColorStateList;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#getImageTintBlendMode()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.BlendMode"/></returns>
        public Android.Graphics.BlendMode GetImageTintBlendMode()
        {
            return IExecuteWithSignature<Android.Graphics.BlendMode>("getImageTintBlendMode", "()Landroid/graphics/BlendMode;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#getColorFilter()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.ColorFilter"/></returns>
        public Android.Graphics.ColorFilter GetColorFilter()
        {
            return IExecuteWithSignature<Android.Graphics.ColorFilter>("getColorFilter", "()Landroid/graphics/ColorFilter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#getDrawable()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable GetDrawable()
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getDrawable", "()Landroid/graphics/drawable/Drawable;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#getImageMatrix()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Matrix"/></returns>
        public Android.Graphics.Matrix GetImageMatrix()
        {
            return IExecuteWithSignature<Android.Graphics.Matrix>("getImageMatrix", "()Landroid/graphics/Matrix;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#getImageTintMode()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.PorterDuff.Mode"/></returns>
        public Android.Graphics.PorterDuff.Mode GetImageTintMode()
        {
            return IExecuteWithSignature<Android.Graphics.PorterDuff.Mode>("getImageTintMode", "()Landroid/graphics/PorterDuff$Mode;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#getScaleType()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.ImageView.ScaleType"/></returns>
        public Android.Widget.ImageView.ScaleType GetScaleType()
        {
            return IExecuteWithSignature<Android.Widget.ImageView.ScaleType>("getScaleType", "()Landroid/widget/ImageView$ScaleType;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#getAdjustViewBounds()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetAdjustViewBounds()
        {
            return IExecuteWithSignature<bool>("getAdjustViewBounds", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#getBaselineAlignBottom()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetBaselineAlignBottom()
        {
            return IExecuteWithSignature<bool>("getBaselineAlignBottom", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#getCropToPadding()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetCropToPadding()
        {
            return IExecuteWithSignature<bool>("getCropToPadding", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#clearColorFilter()"/>
        /// </summary>
        public void ClearColorFilter()
        {
            IExecuteWithSignature("clearColorFilter", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#setColorFilter(int,android.graphics.PorterDuff.Mode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.PorterDuff.Mode"/></param>
        public void SetColorFilter(int arg0, Android.Graphics.PorterDuff.Mode arg1)
        {
            IExecute("setColorFilter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#setColorFilter(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetColorFilter(int arg0)
        {
            IExecuteWithSignature("setColorFilter", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#getImageAlpha()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetImageAlpha()
        {
            return IExecuteWithSignature<int>("getImageAlpha", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#getMaxHeight()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaxHeight()
        {
            return IExecuteWithSignature<int>("getMaxHeight", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#getMaxWidth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaxWidth()
        {
            return IExecuteWithSignature<int>("getMaxWidth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#onCreateDrawableState(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int[] OnCreateDrawableState(int arg0)
        {
            return IExecuteWithSignatureArray<int>("onCreateDrawableState", "(I)[I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#animateTransform(android.graphics.Matrix)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Matrix"/></param>
        public void AnimateTransform(Android.Graphics.Matrix arg0)
        {
            IExecuteWithSignature("animateTransform", "(Landroid/graphics/Matrix;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#setAdjustViewBounds(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetAdjustViewBounds(bool arg0)
        {
            IExecuteWithSignature("setAdjustViewBounds", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#setAlpha(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetAlpha(int arg0)
        {
            IExecuteWithSignature("setAlpha", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#setBaseline(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetBaseline(int arg0)
        {
            IExecuteWithSignature("setBaseline", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#setBaselineAlignBottom(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetBaselineAlignBottom(bool arg0)
        {
            IExecuteWithSignature("setBaselineAlignBottom", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#setColorFilter(android.graphics.ColorFilter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.ColorFilter"/></param>
        public void SetColorFilter(Android.Graphics.ColorFilter arg0)
        {
            IExecuteWithSignature("setColorFilter", "(Landroid/graphics/ColorFilter;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#setCropToPadding(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetCropToPadding(bool arg0)
        {
            IExecuteWithSignature("setCropToPadding", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#setImageAlpha(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetImageAlpha(int arg0)
        {
            IExecuteWithSignature("setImageAlpha", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#setImageBitmap(android.graphics.Bitmap)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Bitmap"/></param>
        public void SetImageBitmap(Android.Graphics.Bitmap arg0)
        {
            IExecuteWithSignature("setImageBitmap", "(Landroid/graphics/Bitmap;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#setImageDrawable(android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        public void SetImageDrawable(Android.Graphics.Drawable.Drawable arg0)
        {
            IExecuteWithSignature("setImageDrawable", "(Landroid/graphics/drawable/Drawable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#setImageIcon(android.graphics.drawable.Icon)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Icon"/></param>
        public void SetImageIcon(Android.Graphics.Drawable.Icon arg0)
        {
            IExecuteWithSignature("setImageIcon", "(Landroid/graphics/drawable/Icon;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#setImageLevel(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetImageLevel(int arg0)
        {
            IExecuteWithSignature("setImageLevel", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#setImageMatrix(android.graphics.Matrix)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Matrix"/></param>
        public void SetImageMatrix(Android.Graphics.Matrix arg0)
        {
            IExecuteWithSignature("setImageMatrix", "(Landroid/graphics/Matrix;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#setImageResource(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetImageResource(int arg0)
        {
            IExecuteWithSignature("setImageResource", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#setImageState(int[],boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void SetImageState(int[] arg0, bool arg1)
        {
            IExecute("setImageState", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#setImageTintBlendMode(android.graphics.BlendMode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.BlendMode"/></param>
        public void SetImageTintBlendMode(Android.Graphics.BlendMode arg0)
        {
            IExecuteWithSignature("setImageTintBlendMode", "(Landroid/graphics/BlendMode;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#setImageTintList(android.content.res.ColorStateList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Res.ColorStateList"/></param>
        public void SetImageTintList(Android.Content.Res.ColorStateList arg0)
        {
            IExecuteWithSignature("setImageTintList", "(Landroid/content/res/ColorStateList;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#setImageTintMode(android.graphics.PorterDuff.Mode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.PorterDuff.Mode"/></param>
        public void SetImageTintMode(Android.Graphics.PorterDuff.Mode arg0)
        {
            IExecuteWithSignature("setImageTintMode", "(Landroid/graphics/PorterDuff$Mode;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#setImageURI(android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        public void SetImageURI(Android.Net.Uri arg0)
        {
            IExecuteWithSignature("setImageURI", "(Landroid/net/Uri;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#setMaxHeight(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetMaxHeight(int arg0)
        {
            IExecuteWithSignature("setMaxHeight", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#setMaxWidth(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetMaxWidth(int arg0)
        {
            IExecuteWithSignature("setMaxWidth", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ImageView.html#setScaleType(android.widget.ImageView.ScaleType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.ImageView.ScaleType"/></param>
        public void SetScaleType(Android.Widget.ImageView.ScaleType arg0)
        {
            IExecuteWithSignature("setScaleType", "(Landroid/widget/ImageView$ScaleType;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region ScaleType
        public partial class ScaleType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/ImageView.ScaleType.html#CENTER"/>
            /// </summary>
            public static Android.Widget.ImageView.ScaleType CENTER { get { if (!_CENTERReady) { _CENTERContent = SGetField<Android.Widget.ImageView.ScaleType>(LocalBridgeClazz, "CENTER"); _CENTERReady = true; } return _CENTERContent; } }
            private static Android.Widget.ImageView.ScaleType _CENTERContent = default;
            private static bool _CENTERReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/ImageView.ScaleType.html#CENTER_CROP"/>
            /// </summary>
            public static Android.Widget.ImageView.ScaleType CENTER_CROP { get { if (!_CENTER_CROPReady) { _CENTER_CROPContent = SGetField<Android.Widget.ImageView.ScaleType>(LocalBridgeClazz, "CENTER_CROP"); _CENTER_CROPReady = true; } return _CENTER_CROPContent; } }
            private static Android.Widget.ImageView.ScaleType _CENTER_CROPContent = default;
            private static bool _CENTER_CROPReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/ImageView.ScaleType.html#CENTER_INSIDE"/>
            /// </summary>
            public static Android.Widget.ImageView.ScaleType CENTER_INSIDE { get { if (!_CENTER_INSIDEReady) { _CENTER_INSIDEContent = SGetField<Android.Widget.ImageView.ScaleType>(LocalBridgeClazz, "CENTER_INSIDE"); _CENTER_INSIDEReady = true; } return _CENTER_INSIDEContent; } }
            private static Android.Widget.ImageView.ScaleType _CENTER_INSIDEContent = default;
            private static bool _CENTER_INSIDEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/ImageView.ScaleType.html#FIT_CENTER"/>
            /// </summary>
            public static Android.Widget.ImageView.ScaleType FIT_CENTER { get { if (!_FIT_CENTERReady) { _FIT_CENTERContent = SGetField<Android.Widget.ImageView.ScaleType>(LocalBridgeClazz, "FIT_CENTER"); _FIT_CENTERReady = true; } return _FIT_CENTERContent; } }
            private static Android.Widget.ImageView.ScaleType _FIT_CENTERContent = default;
            private static bool _FIT_CENTERReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/ImageView.ScaleType.html#FIT_END"/>
            /// </summary>
            public static Android.Widget.ImageView.ScaleType FIT_END { get { if (!_FIT_ENDReady) { _FIT_ENDContent = SGetField<Android.Widget.ImageView.ScaleType>(LocalBridgeClazz, "FIT_END"); _FIT_ENDReady = true; } return _FIT_ENDContent; } }
            private static Android.Widget.ImageView.ScaleType _FIT_ENDContent = default;
            private static bool _FIT_ENDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/ImageView.ScaleType.html#FIT_START"/>
            /// </summary>
            public static Android.Widget.ImageView.ScaleType FIT_START { get { if (!_FIT_STARTReady) { _FIT_STARTContent = SGetField<Android.Widget.ImageView.ScaleType>(LocalBridgeClazz, "FIT_START"); _FIT_STARTReady = true; } return _FIT_STARTContent; } }
            private static Android.Widget.ImageView.ScaleType _FIT_STARTContent = default;
            private static bool _FIT_STARTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/ImageView.ScaleType.html#FIT_XY"/>
            /// </summary>
            public static Android.Widget.ImageView.ScaleType FIT_XY { get { if (!_FIT_XYReady) { _FIT_XYContent = SGetField<Android.Widget.ImageView.ScaleType>(LocalBridgeClazz, "FIT_XY"); _FIT_XYReady = true; } return _FIT_XYContent; } }
            private static Android.Widget.ImageView.ScaleType _FIT_XYContent = default;
            private static bool _FIT_XYReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/ImageView.ScaleType.html#MATRIX"/>
            /// </summary>
            public static Android.Widget.ImageView.ScaleType MATRIX { get { if (!_MATRIXReady) { _MATRIXContent = SGetField<Android.Widget.ImageView.ScaleType>(LocalBridgeClazz, "MATRIX"); _MATRIXReady = true; } return _MATRIXContent; } }
            private static Android.Widget.ImageView.ScaleType _MATRIXContent = default;
            private static bool _MATRIXReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/ImageView.ScaleType.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Widget.ImageView.ScaleType"/></returns>
            public static Android.Widget.ImageView.ScaleType ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Widget.ImageView.ScaleType>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/widget/ImageView$ScaleType;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/ImageView.ScaleType.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Widget.ImageView.ScaleType"/></returns>
            public static Android.Widget.ImageView.ScaleType[] Values()
            {
                return SExecuteWithSignatureArray<Android.Widget.ImageView.ScaleType>(LocalBridgeClazz, "values", "()[Landroid/widget/ImageView$ScaleType;");
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