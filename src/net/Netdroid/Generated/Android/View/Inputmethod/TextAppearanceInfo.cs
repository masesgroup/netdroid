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

namespace Android.View.Inputmethod
{
    #region TextAppearanceInfo declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.html"/>
    /// </summary>
    public partial class TextAppearanceInfo : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.view.inputmethod.TextAppearanceInfo";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TextAppearanceInfo() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TextAppearanceInfo(params object[] args) : base(args) { }
    
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
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.view.inputmethod.TextAppearanceInfo$Builder";
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

    #region TextAppearanceInfo implementation
    public partial class TextAppearanceInfo
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.html#getTextLocales()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.LocaleList"/></returns>
        public Android.Os.LocaleList GetTextLocales()
        {
            return IExecuteWithSignature<Android.Os.LocaleList>("getTextLocales", "()Landroid/os/LocaleList;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.html#isAllCaps()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAllCaps()
        {
            return IExecuteWithSignature<bool>("isAllCaps", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.html#isElegantTextHeight()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsElegantTextHeight()
        {
            return IExecuteWithSignature<bool>("isElegantTextHeight", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.html#isFallbackLineSpacing()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFallbackLineSpacing()
        {
            return IExecuteWithSignature<bool>("isFallbackLineSpacing", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.html#getLetterSpacing()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetLetterSpacing()
        {
            return IExecuteWithSignature<float>("getLetterSpacing", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.html#getShadowDx()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetShadowDx()
        {
            return IExecuteWithSignature<float>("getShadowDx", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.html#getShadowDy()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetShadowDy()
        {
            return IExecuteWithSignature<float>("getShadowDy", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.html#getShadowRadius()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetShadowRadius()
        {
            return IExecuteWithSignature<float>("getShadowRadius", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.html#getTextScaleX()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetTextScaleX()
        {
            return IExecuteWithSignature<float>("getTextScaleX", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.html#getTextSize()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetTextSize()
        {
            return IExecuteWithSignature<float>("getTextSize", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.html#getHighlightTextColor()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetHighlightTextColor()
        {
            return IExecuteWithSignature<int>("getHighlightTextColor", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.html#getHintTextColor()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetHintTextColor()
        {
            return IExecuteWithSignature<int>("getHintTextColor", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.html#getLineBreakStyle()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetLineBreakStyle()
        {
            return IExecuteWithSignature<int>("getLineBreakStyle", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.html#getLineBreakWordStyle()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetLineBreakWordStyle()
        {
            return IExecuteWithSignature<int>("getLineBreakWordStyle", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.html#getLinkTextColor()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetLinkTextColor()
        {
            return IExecuteWithSignature<int>("getLinkTextColor", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.html#getShadowColor()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetShadowColor()
        {
            return IExecuteWithSignature<int>("getShadowColor", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.html#getTextColor()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTextColor()
        {
            return IExecuteWithSignature<int>("getTextColor", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.html#getTextFontWeight()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTextFontWeight()
        {
            return IExecuteWithSignature<int>("getTextFontWeight", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.html#getTextStyle()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTextStyle()
        {
            return IExecuteWithSignature<int>("getTextStyle", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.html#getFontFeatureSettings()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetFontFeatureSettings()
        {
            return IExecuteWithSignature<Java.Lang.String>("getFontFeatureSettings", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.html#getFontVariationSettings()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetFontVariationSettings()
        {
            return IExecuteWithSignature<Java.Lang.String>("getFontVariationSettings", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.html#getSystemFontFamilyName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSystemFontFamilyName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSystemFontFamilyName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecuteWithSignature("writeToParcel", "(Landroid/os/Parcel;I)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
        #region Builder implementation
        public partial class Builder
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
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.View.Inputmethod.TextAppearanceInfo"/></returns>
            public Android.View.Inputmethod.TextAppearanceInfo Build()
            {
                return IExecuteWithSignature<Android.View.Inputmethod.TextAppearanceInfo>("build", "()Landroid/view/inputmethod/TextAppearanceInfo;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.Builder.html#setAllCaps(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.View.Inputmethod.TextAppearanceInfo.Builder"/></returns>
            public Android.View.Inputmethod.TextAppearanceInfo.Builder SetAllCaps(bool arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.TextAppearanceInfo.Builder>("setAllCaps", "(Z)Landroid/view/inputmethod/TextAppearanceInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.Builder.html#setElegantTextHeight(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.View.Inputmethod.TextAppearanceInfo.Builder"/></returns>
            public Android.View.Inputmethod.TextAppearanceInfo.Builder SetElegantTextHeight(bool arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.TextAppearanceInfo.Builder>("setElegantTextHeight", "(Z)Landroid/view/inputmethod/TextAppearanceInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.Builder.html#setFallbackLineSpacing(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.View.Inputmethod.TextAppearanceInfo.Builder"/></returns>
            public Android.View.Inputmethod.TextAppearanceInfo.Builder SetFallbackLineSpacing(bool arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.TextAppearanceInfo.Builder>("setFallbackLineSpacing", "(Z)Landroid/view/inputmethod/TextAppearanceInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.Builder.html#setFontFeatureSettings(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.View.Inputmethod.TextAppearanceInfo.Builder"/></returns>
            public Android.View.Inputmethod.TextAppearanceInfo.Builder SetFontFeatureSettings(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.TextAppearanceInfo.Builder>("setFontFeatureSettings", "(Ljava/lang/String;)Landroid/view/inputmethod/TextAppearanceInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.Builder.html#setFontVariationSettings(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.View.Inputmethod.TextAppearanceInfo.Builder"/></returns>
            public Android.View.Inputmethod.TextAppearanceInfo.Builder SetFontVariationSettings(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.TextAppearanceInfo.Builder>("setFontVariationSettings", "(Ljava/lang/String;)Landroid/view/inputmethod/TextAppearanceInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.Builder.html#setHighlightTextColor(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.View.Inputmethod.TextAppearanceInfo.Builder"/></returns>
            public Android.View.Inputmethod.TextAppearanceInfo.Builder SetHighlightTextColor(int arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.TextAppearanceInfo.Builder>("setHighlightTextColor", "(I)Landroid/view/inputmethod/TextAppearanceInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.Builder.html#setHintTextColor(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.View.Inputmethod.TextAppearanceInfo.Builder"/></returns>
            public Android.View.Inputmethod.TextAppearanceInfo.Builder SetHintTextColor(int arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.TextAppearanceInfo.Builder>("setHintTextColor", "(I)Landroid/view/inputmethod/TextAppearanceInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.Builder.html#setLetterSpacing(float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <returns><see cref="Android.View.Inputmethod.TextAppearanceInfo.Builder"/></returns>
            public Android.View.Inputmethod.TextAppearanceInfo.Builder SetLetterSpacing(float arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.TextAppearanceInfo.Builder>("setLetterSpacing", "(F)Landroid/view/inputmethod/TextAppearanceInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.Builder.html#setLineBreakStyle(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.View.Inputmethod.TextAppearanceInfo.Builder"/></returns>
            public Android.View.Inputmethod.TextAppearanceInfo.Builder SetLineBreakStyle(int arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.TextAppearanceInfo.Builder>("setLineBreakStyle", "(I)Landroid/view/inputmethod/TextAppearanceInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.Builder.html#setLineBreakWordStyle(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.View.Inputmethod.TextAppearanceInfo.Builder"/></returns>
            public Android.View.Inputmethod.TextAppearanceInfo.Builder SetLineBreakWordStyle(int arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.TextAppearanceInfo.Builder>("setLineBreakWordStyle", "(I)Landroid/view/inputmethod/TextAppearanceInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.Builder.html#setLinkTextColor(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.View.Inputmethod.TextAppearanceInfo.Builder"/></returns>
            public Android.View.Inputmethod.TextAppearanceInfo.Builder SetLinkTextColor(int arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.TextAppearanceInfo.Builder>("setLinkTextColor", "(I)Landroid/view/inputmethod/TextAppearanceInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.Builder.html#setShadowColor(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.View.Inputmethod.TextAppearanceInfo.Builder"/></returns>
            public Android.View.Inputmethod.TextAppearanceInfo.Builder SetShadowColor(int arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.TextAppearanceInfo.Builder>("setShadowColor", "(I)Landroid/view/inputmethod/TextAppearanceInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.Builder.html#setShadowDx(float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <returns><see cref="Android.View.Inputmethod.TextAppearanceInfo.Builder"/></returns>
            public Android.View.Inputmethod.TextAppearanceInfo.Builder SetShadowDx(float arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.TextAppearanceInfo.Builder>("setShadowDx", "(F)Landroid/view/inputmethod/TextAppearanceInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.Builder.html#setShadowDy(float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <returns><see cref="Android.View.Inputmethod.TextAppearanceInfo.Builder"/></returns>
            public Android.View.Inputmethod.TextAppearanceInfo.Builder SetShadowDy(float arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.TextAppearanceInfo.Builder>("setShadowDy", "(F)Landroid/view/inputmethod/TextAppearanceInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.Builder.html#setShadowRadius(float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <returns><see cref="Android.View.Inputmethod.TextAppearanceInfo.Builder"/></returns>
            public Android.View.Inputmethod.TextAppearanceInfo.Builder SetShadowRadius(float arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.TextAppearanceInfo.Builder>("setShadowRadius", "(F)Landroid/view/inputmethod/TextAppearanceInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.Builder.html#setSystemFontFamilyName(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.View.Inputmethod.TextAppearanceInfo.Builder"/></returns>
            public Android.View.Inputmethod.TextAppearanceInfo.Builder SetSystemFontFamilyName(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.TextAppearanceInfo.Builder>("setSystemFontFamilyName", "(Ljava/lang/String;)Landroid/view/inputmethod/TextAppearanceInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.Builder.html#setTextColor(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.View.Inputmethod.TextAppearanceInfo.Builder"/></returns>
            public Android.View.Inputmethod.TextAppearanceInfo.Builder SetTextColor(int arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.TextAppearanceInfo.Builder>("setTextColor", "(I)Landroid/view/inputmethod/TextAppearanceInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.Builder.html#setTextFontWeight(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.View.Inputmethod.TextAppearanceInfo.Builder"/></returns>
            public Android.View.Inputmethod.TextAppearanceInfo.Builder SetTextFontWeight(int arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.TextAppearanceInfo.Builder>("setTextFontWeight", "(I)Landroid/view/inputmethod/TextAppearanceInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.Builder.html#setTextLocales(android.os.LocaleList)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.LocaleList"/></param>
            /// <returns><see cref="Android.View.Inputmethod.TextAppearanceInfo.Builder"/></returns>
            public Android.View.Inputmethod.TextAppearanceInfo.Builder SetTextLocales(Android.Os.LocaleList arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.TextAppearanceInfo.Builder>("setTextLocales", "(Landroid/os/LocaleList;)Landroid/view/inputmethod/TextAppearanceInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.Builder.html#setTextScaleX(float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <returns><see cref="Android.View.Inputmethod.TextAppearanceInfo.Builder"/></returns>
            public Android.View.Inputmethod.TextAppearanceInfo.Builder SetTextScaleX(float arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.TextAppearanceInfo.Builder>("setTextScaleX", "(F)Landroid/view/inputmethod/TextAppearanceInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.Builder.html#setTextSize(float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <returns><see cref="Android.View.Inputmethod.TextAppearanceInfo.Builder"/></returns>
            public Android.View.Inputmethod.TextAppearanceInfo.Builder SetTextSize(float arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.TextAppearanceInfo.Builder>("setTextSize", "(F)Landroid/view/inputmethod/TextAppearanceInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextAppearanceInfo.Builder.html#setTextStyle(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.View.Inputmethod.TextAppearanceInfo.Builder"/></returns>
            public Android.View.Inputmethod.TextAppearanceInfo.Builder SetTextStyle(int arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.TextAppearanceInfo.Builder>("setTextStyle", "(I)Landroid/view/inputmethod/TextAppearanceInfo$Builder;", arg0);
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