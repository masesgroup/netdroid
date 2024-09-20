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

namespace Android.Graphics.Fonts
{
    #region Font
    public partial class Font
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/fonts/Font.html#getStyle()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Fonts.FontStyle"/></returns>
        public Android.Graphics.Fonts.FontStyle GetStyle()
        {
            return IExecuteWithSignature<Android.Graphics.Fonts.FontStyle>("getStyle", "()Landroid/graphics/fonts/FontStyle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/fonts/Font.html#getAxes()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Fonts.FontVariationAxis"/></returns>
        public Android.Graphics.Fonts.FontVariationAxis[] GetAxes()
        {
            return IExecuteWithSignatureArray<Android.Graphics.Fonts.FontVariationAxis>("getAxes", "()[Landroid/graphics/fonts/FontVariationAxis;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/fonts/Font.html#getLocaleList()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.LocaleList"/></returns>
        public Android.Os.LocaleList GetLocaleList()
        {
            return IExecuteWithSignature<Android.Os.LocaleList>("getLocaleList", "()Landroid/os/LocaleList;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/fonts/Font.html#getGlyphBounds(int,android.graphics.Paint,android.graphics.RectF)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Paint"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.RectF"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetGlyphBounds(int arg0, Android.Graphics.Paint arg1, Android.Graphics.RectF arg2)
        {
            return IExecute<float>("getGlyphBounds", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/fonts/Font.html#getSourceIdentifier()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSourceIdentifier()
        {
            return IExecuteWithSignature<int>("getSourceIdentifier", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/fonts/Font.html#getTtcIndex()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTtcIndex()
        {
            return IExecuteWithSignature<int>("getTtcIndex", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/fonts/Font.html#getFile()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.File"/></returns>
        public Java.Io.File GetFile()
        {
            return IExecuteWithSignature<Java.Io.File>("getFile", "()Ljava/io/File;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/fonts/Font.html#getBuffer()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer GetBuffer()
        {
            return IExecuteWithSignature<Java.Nio.ByteBuffer>("getBuffer", "()Ljava/nio/ByteBuffer;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/fonts/Font.html#getMetrics(android.graphics.Paint,android.graphics.Paint.FontMetrics)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Paint"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Paint.FontMetrics"/></param>
        public void GetMetrics(Android.Graphics.Paint arg0, Android.Graphics.Paint.FontMetrics arg1)
        {
            IExecute("getMetrics", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/fonts/Font.Builder.html#%3Cinit%3E(android.content.res.AssetManager,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Res.AssetManager"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            public Builder(Android.Content.Res.AssetManager arg0, Java.Lang.String arg1)
                : base(arg0, arg1)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/fonts/Font.Builder.html#%3Cinit%3E(android.content.res.Resources,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Res.Resources"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public Builder(Android.Content.Res.Resources arg0, int arg1)
                : base(arg0, arg1)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/fonts/Font.Builder.html#%3Cinit%3E(android.graphics.fonts.Font)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Fonts.Font"/></param>
            public Builder(Android.Graphics.Fonts.Font arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/fonts/Font.Builder.html#%3Cinit%3E(android.os.ParcelFileDescriptor,long,long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.ParcelFileDescriptor"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            /// <param name="arg2"><see cref="long"/></param>
            public Builder(Android.Os.ParcelFileDescriptor arg0, long arg1, long arg2)
                : base(arg0, arg1, arg2)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/fonts/Font.Builder.html#%3Cinit%3E(android.os.ParcelFileDescriptor)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.ParcelFileDescriptor"/></param>
            public Builder(Android.Os.ParcelFileDescriptor arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/fonts/Font.Builder.html#%3Cinit%3E(java.io.File)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Io.File"/></param>
            public Builder(Java.Io.File arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/fonts/Font.Builder.html#%3Cinit%3E(java.nio.ByteBuffer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
            public Builder(Java.Nio.ByteBuffer arg0)
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
            /// <see href="https://developer.android.com/reference/android/graphics/fonts/Font.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Graphics.Fonts.Font"/></returns>
            /// <exception cref="Java.Io.IOException"/>
            public Android.Graphics.Fonts.Font Build()
            {
                return IExecuteWithSignature<Android.Graphics.Fonts.Font>("build", "()Landroid/graphics/fonts/Font;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/fonts/Font.Builder.html#setFontVariationSettings(android.graphics.fonts.FontVariationAxis[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Fonts.FontVariationAxis"/></param>
            /// <returns><see cref="Android.Graphics.Fonts.Font.Builder"/></returns>
            public Android.Graphics.Fonts.Font.Builder SetFontVariationSettings(Android.Graphics.Fonts.FontVariationAxis[] arg0)
            {
                return IExecuteWithSignature<Android.Graphics.Fonts.Font.Builder>("setFontVariationSettings", "([Landroid/graphics/fonts/FontVariationAxis;)Landroid/graphics/fonts/Font$Builder;", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/fonts/Font.Builder.html#setFontVariationSettings(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Graphics.Fonts.Font.Builder"/></returns>
            public Android.Graphics.Fonts.Font.Builder SetFontVariationSettings(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Graphics.Fonts.Font.Builder>("setFontVariationSettings", "(Ljava/lang/String;)Landroid/graphics/fonts/Font$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/fonts/Font.Builder.html#setSlant(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Graphics.Fonts.Font.Builder"/></returns>
            public Android.Graphics.Fonts.Font.Builder SetSlant(int arg0)
            {
                return IExecuteWithSignature<Android.Graphics.Fonts.Font.Builder>("setSlant", "(I)Landroid/graphics/fonts/Font$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/fonts/Font.Builder.html#setTtcIndex(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Graphics.Fonts.Font.Builder"/></returns>
            public Android.Graphics.Fonts.Font.Builder SetTtcIndex(int arg0)
            {
                return IExecuteWithSignature<Android.Graphics.Fonts.Font.Builder>("setTtcIndex", "(I)Landroid/graphics/fonts/Font$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/fonts/Font.Builder.html#setWeight(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Graphics.Fonts.Font.Builder"/></returns>
            public Android.Graphics.Fonts.Font.Builder SetWeight(int arg0)
            {
                return IExecuteWithSignature<Android.Graphics.Fonts.Font.Builder>("setWeight", "(I)Landroid/graphics/fonts/Font$Builder;", arg0);
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