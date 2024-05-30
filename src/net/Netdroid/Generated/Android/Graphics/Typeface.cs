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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Graphics
{
    #region Typeface
    public partial class Typeface
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Typeface.html#DEFAULT"/>
        /// </summary>
        public static Android.Graphics.Typeface DEFAULT { get { if (!_DEFAULTReady) { _DEFAULTContent = SGetField<Android.Graphics.Typeface>(LocalBridgeClazz, "DEFAULT"); _DEFAULTReady = true; } return _DEFAULTContent; } }
        private static Android.Graphics.Typeface _DEFAULTContent = default;
        private static bool _DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Typeface.html#DEFAULT_BOLD"/>
        /// </summary>
        public static Android.Graphics.Typeface DEFAULT_BOLD { get { if (!_DEFAULT_BOLDReady) { _DEFAULT_BOLDContent = SGetField<Android.Graphics.Typeface>(LocalBridgeClazz, "DEFAULT_BOLD"); _DEFAULT_BOLDReady = true; } return _DEFAULT_BOLDContent; } }
        private static Android.Graphics.Typeface _DEFAULT_BOLDContent = default;
        private static bool _DEFAULT_BOLDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Typeface.html#MONOSPACE"/>
        /// </summary>
        public static Android.Graphics.Typeface MONOSPACE { get { if (!_MONOSPACEReady) { _MONOSPACEContent = SGetField<Android.Graphics.Typeface>(LocalBridgeClazz, "MONOSPACE"); _MONOSPACEReady = true; } return _MONOSPACEContent; } }
        private static Android.Graphics.Typeface _MONOSPACEContent = default;
        private static bool _MONOSPACEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Typeface.html#SANS_SERIF"/>
        /// </summary>
        public static Android.Graphics.Typeface SANS_SERIF { get { if (!_SANS_SERIFReady) { _SANS_SERIFContent = SGetField<Android.Graphics.Typeface>(LocalBridgeClazz, "SANS_SERIF"); _SANS_SERIFReady = true; } return _SANS_SERIFContent; } }
        private static Android.Graphics.Typeface _SANS_SERIFContent = default;
        private static bool _SANS_SERIFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Typeface.html#SERIF"/>
        /// </summary>
        public static Android.Graphics.Typeface SERIF { get { if (!_SERIFReady) { _SERIFContent = SGetField<Android.Graphics.Typeface>(LocalBridgeClazz, "SERIF"); _SERIFReady = true; } return _SERIFContent; } }
        private static Android.Graphics.Typeface _SERIFContent = default;
        private static bool _SERIFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Typeface.html#BOLD"/>
        /// </summary>
        public static int BOLD { get { if (!_BOLDReady) { _BOLDContent = SGetField<int>(LocalBridgeClazz, "BOLD"); _BOLDReady = true; } return _BOLDContent; } }
        private static int _BOLDContent = default;
        private static bool _BOLDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Typeface.html#BOLD_ITALIC"/>
        /// </summary>
        public static int BOLD_ITALIC { get { if (!_BOLD_ITALICReady) { _BOLD_ITALICContent = SGetField<int>(LocalBridgeClazz, "BOLD_ITALIC"); _BOLD_ITALICReady = true; } return _BOLD_ITALICContent; } }
        private static int _BOLD_ITALICContent = default;
        private static bool _BOLD_ITALICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Typeface.html#ITALIC"/>
        /// </summary>
        public static int ITALIC { get { if (!_ITALICReady) { _ITALICContent = SGetField<int>(LocalBridgeClazz, "ITALIC"); _ITALICReady = true; } return _ITALICContent; } }
        private static int _ITALICContent = default;
        private static bool _ITALICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Typeface.html#NORMAL"/>
        /// </summary>
        public static int NORMAL { get { if (!_NORMALReady) { _NORMALContent = SGetField<int>(LocalBridgeClazz, "NORMAL"); _NORMALReady = true; } return _NORMALContent; } }
        private static int _NORMALContent = default;
        private static bool _NORMALReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Typeface.html#create(android.graphics.Typeface,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Typeface"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="Android.Graphics.Typeface"/></returns>
        public static Android.Graphics.Typeface Create(Android.Graphics.Typeface arg0, int arg1, bool arg2)
        {
            return SExecute<Android.Graphics.Typeface>(LocalBridgeClazz, "create", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Typeface.html#create(android.graphics.Typeface,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Typeface"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Typeface"/></returns>
        public static Android.Graphics.Typeface Create(Android.Graphics.Typeface arg0, int arg1)
        {
            return SExecute<Android.Graphics.Typeface>(LocalBridgeClazz, "create", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Typeface.html#create(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Typeface"/></returns>
        public static Android.Graphics.Typeface Create(Java.Lang.String arg0, int arg1)
        {
            return SExecute<Android.Graphics.Typeface>(LocalBridgeClazz, "create", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Typeface.html#createFromAsset(android.content.res.AssetManager,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Res.AssetManager"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Graphics.Typeface"/></returns>
        public static Android.Graphics.Typeface CreateFromAsset(Android.Content.Res.AssetManager arg0, Java.Lang.String arg1)
        {
            return SExecute<Android.Graphics.Typeface>(LocalBridgeClazz, "createFromAsset", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Typeface.html#createFromFile(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Android.Graphics.Typeface"/></returns>
        public static Android.Graphics.Typeface CreateFromFile(Java.Io.File arg0)
        {
            return SExecuteWithSignature<Android.Graphics.Typeface>(LocalBridgeClazz, "createFromFile", "(Ljava/io/File;)Landroid/graphics/Typeface;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Typeface.html#createFromFile(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Graphics.Typeface"/></returns>
        public static Android.Graphics.Typeface CreateFromFile(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Android.Graphics.Typeface>(LocalBridgeClazz, "createFromFile", "(Ljava/lang/String;)Landroid/graphics/Typeface;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Typeface.html#defaultFromStyle(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Typeface"/></returns>
        public static Android.Graphics.Typeface DefaultFromStyle(int arg0)
        {
            return SExecuteWithSignature<Android.Graphics.Typeface>(LocalBridgeClazz, "defaultFromStyle", "(I)Landroid/graphics/Typeface;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Typeface.html#getStyle()"/> 
        /// </summary>
        public int Style
        {
            get { return IExecuteWithSignature<int>("getStyle", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Typeface.html#getSystemFontFamilyName()"/> 
        /// </summary>
        public Java.Lang.String SystemFontFamilyName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getSystemFontFamilyName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Typeface.html#getWeight()"/> 
        /// </summary>
        public int Weight
        {
            get { return IExecuteWithSignature<int>("getWeight", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Typeface.html#isBold()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsBold()
        {
            return IExecuteWithSignature<bool>("isBold", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Typeface.html#isItalic()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsItalic()
        {
            return IExecuteWithSignature<bool>("isItalic", "()Z");
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Typeface.Builder.html#%3Cinit%3E(android.content.res.AssetManager,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Res.AssetManager"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            public Builder(Android.Content.Res.AssetManager arg0, Java.Lang.String arg1)
                : base(arg0, arg1)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Typeface.Builder.html#%3Cinit%3E(java.io.File)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Io.File"/></param>
            public Builder(Java.Io.File arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Typeface.Builder.html#%3Cinit%3E(java.io.FileDescriptor)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Io.FileDescriptor"/></param>
            public Builder(Java.Io.FileDescriptor arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Typeface.Builder.html#%3Cinit%3E(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            public Builder(Java.Lang.String arg0)
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
            /// <see href="https://developer.android.com/reference/android/graphics/Typeface.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Graphics.Typeface"/></returns>
            public Android.Graphics.Typeface Build()
            {
                return IExecuteWithSignature<Android.Graphics.Typeface>("build", "()Landroid/graphics/Typeface;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Typeface.Builder.html#setFallback(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Graphics.Typeface.Builder"/></returns>
            public Android.Graphics.Typeface.Builder SetFallback(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Graphics.Typeface.Builder>("setFallback", "(Ljava/lang/String;)Landroid/graphics/Typeface$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Typeface.Builder.html#setFontVariationSettings(android.graphics.fonts.FontVariationAxis[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Fonts.FontVariationAxis"/></param>
            /// <returns><see cref="Android.Graphics.Typeface.Builder"/></returns>
            public Android.Graphics.Typeface.Builder SetFontVariationSettings(Android.Graphics.Fonts.FontVariationAxis[] arg0)
            {
                return IExecuteWithSignature<Android.Graphics.Typeface.Builder>("setFontVariationSettings", "([Landroid/graphics/fonts/FontVariationAxis;)Landroid/graphics/Typeface$Builder;", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Typeface.Builder.html#setFontVariationSettings(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Graphics.Typeface.Builder"/></returns>
            public Android.Graphics.Typeface.Builder SetFontVariationSettings(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Graphics.Typeface.Builder>("setFontVariationSettings", "(Ljava/lang/String;)Landroid/graphics/Typeface$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Typeface.Builder.html#setItalic(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Graphics.Typeface.Builder"/></returns>
            public Android.Graphics.Typeface.Builder SetItalic(bool arg0)
            {
                return IExecuteWithSignature<Android.Graphics.Typeface.Builder>("setItalic", "(Z)Landroid/graphics/Typeface$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Typeface.Builder.html#setTtcIndex(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Graphics.Typeface.Builder"/></returns>
            public Android.Graphics.Typeface.Builder SetTtcIndex(int arg0)
            {
                return IExecuteWithSignature<Android.Graphics.Typeface.Builder>("setTtcIndex", "(I)Landroid/graphics/Typeface$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Typeface.Builder.html#setWeight(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Graphics.Typeface.Builder"/></returns>
            public Android.Graphics.Typeface.Builder SetWeight(int arg0)
            {
                return IExecuteWithSignature<Android.Graphics.Typeface.Builder>("setWeight", "(I)Landroid/graphics/Typeface$Builder;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region CustomFallbackBuilder
        public partial class CustomFallbackBuilder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Typeface.CustomFallbackBuilder.html#%3Cinit%3E(android.graphics.fonts.FontFamily)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Fonts.FontFamily"/></param>
            public CustomFallbackBuilder(Android.Graphics.Fonts.FontFamily arg0)
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
            /// <see href="https://developer.android.com/reference/android/graphics/Typeface.CustomFallbackBuilder.html#getMaxCustomFallbackCount()"/> 
            /// </summary>
            public static int MaxCustomFallbackCount
            {
                get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getMaxCustomFallbackCount", "()I"); }
            }

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Typeface.CustomFallbackBuilder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Graphics.Typeface"/></returns>
            public Android.Graphics.Typeface Build()
            {
                return IExecuteWithSignature<Android.Graphics.Typeface>("build", "()Landroid/graphics/Typeface;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Typeface.CustomFallbackBuilder.html#addCustomFallback(android.graphics.fonts.FontFamily)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Fonts.FontFamily"/></param>
            /// <returns><see cref="Android.Graphics.Typeface.CustomFallbackBuilder"/></returns>
            public Android.Graphics.Typeface.CustomFallbackBuilder AddCustomFallback(Android.Graphics.Fonts.FontFamily arg0)
            {
                return IExecuteWithSignature<Android.Graphics.Typeface.CustomFallbackBuilder>("addCustomFallback", "(Landroid/graphics/fonts/FontFamily;)Landroid/graphics/Typeface$CustomFallbackBuilder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Typeface.CustomFallbackBuilder.html#setStyle(android.graphics.fonts.FontStyle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Fonts.FontStyle"/></param>
            /// <returns><see cref="Android.Graphics.Typeface.CustomFallbackBuilder"/></returns>
            public Android.Graphics.Typeface.CustomFallbackBuilder SetStyle(Android.Graphics.Fonts.FontStyle arg0)
            {
                return IExecuteWithSignature<Android.Graphics.Typeface.CustomFallbackBuilder>("setStyle", "(Landroid/graphics/fonts/FontStyle;)Landroid/graphics/Typeface$CustomFallbackBuilder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Typeface.CustomFallbackBuilder.html#setSystemFallback(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Graphics.Typeface.CustomFallbackBuilder"/></returns>
            public Android.Graphics.Typeface.CustomFallbackBuilder SetSystemFallback(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Graphics.Typeface.CustomFallbackBuilder>("setSystemFallback", "(Ljava/lang/String;)Landroid/graphics/Typeface$CustomFallbackBuilder;", arg0);
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