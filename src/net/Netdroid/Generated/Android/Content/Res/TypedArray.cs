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

namespace Android.Content.Res
{
    #region TypedArray declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/content/res/TypedArray.html"/>
    /// </summary>
    public partial class TypedArray : Java.Lang.AutoCloseable
    {
        const string _bridgeClassName = "android.content.res.TypedArray";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TypedArray() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TypedArray(params object[] args) : base(args) { }
    
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

    #region TypedArray implementation
    public partial class TypedArray
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
        /// <see href="https://developer.android.com/reference/android/content/res/TypedArray.html#getColorStateList(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Content.Res.ColorStateList"/></returns>
        public Android.Content.Res.ColorStateList GetColorStateList(int arg0)
        {
            return IExecute<Android.Content.Res.ColorStateList>("getColorStateList", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/TypedArray.html#getResources()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Res.Resources"/></returns>
        public Android.Content.Res.Resources GetResources()
        {
            return IExecute<Android.Content.Res.Resources>("getResources");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/TypedArray.html#getDrawable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable GetDrawable(int arg0)
        {
            return IExecute<Android.Graphics.Drawable.Drawable>("getDrawable", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/TypedArray.html#getFont(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Typeface"/></returns>
        public Android.Graphics.Typeface GetFont(int arg0)
        {
            return IExecute<Android.Graphics.Typeface>("getFont", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/TypedArray.html#peekValue(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Util.TypedValue"/></returns>
        public Android.Util.TypedValue PeekValue(int arg0)
        {
            return IExecute<Android.Util.TypedValue>("peekValue", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/TypedArray.html#getBoolean(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool GetBoolean(int arg0, bool arg1)
        {
            return IExecute<bool>("getBoolean", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/TypedArray.html#getValue(int,android.util.TypedValue)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Util.TypedValue"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool GetValue(int arg0, Android.Util.TypedValue arg1)
        {
            return IExecute<bool>("getValue", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/TypedArray.html#hasValue(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasValue(int arg0)
        {
            return IExecute<bool>("hasValue", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/TypedArray.html#hasValueOrEmpty(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasValueOrEmpty(int arg0)
        {
            return IExecute<bool>("hasValueOrEmpty", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/TypedArray.html#getDimension(int,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetDimension(int arg0, float arg1)
        {
            return IExecute<float>("getDimension", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/TypedArray.html#getFloat(int,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetFloat(int arg0, float arg1)
        {
            return IExecute<float>("getFloat", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/TypedArray.html#getFraction(int,int,int,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetFraction(int arg0, int arg1, int arg2, float arg3)
        {
            return IExecute<float>("getFraction", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/TypedArray.html#getChangingConfigurations()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetChangingConfigurations()
        {
            return IExecute<int>("getChangingConfigurations");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/TypedArray.html#getColor(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetColor(int arg0, int arg1)
        {
            return IExecute<int>("getColor", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/TypedArray.html#getDimensionPixelOffset(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetDimensionPixelOffset(int arg0, int arg1)
        {
            return IExecute<int>("getDimensionPixelOffset", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/TypedArray.html#getDimensionPixelSize(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetDimensionPixelSize(int arg0, int arg1)
        {
            return IExecute<int>("getDimensionPixelSize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/TypedArray.html#getIndex(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetIndex(int arg0)
        {
            return IExecute<int>("getIndex", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/TypedArray.html#getIndexCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetIndexCount()
        {
            return IExecute<int>("getIndexCount");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/TypedArray.html#getInt(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetInt(int arg0, int arg1)
        {
            return IExecute<int>("getInt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/TypedArray.html#getInteger(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetInteger(int arg0, int arg1)
        {
            return IExecute<int>("getInteger", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/TypedArray.html#getLayoutDimension(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetLayoutDimension(int arg0, int arg1)
        {
            return IExecute<int>("getLayoutDimension", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/TypedArray.html#getLayoutDimension(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetLayoutDimension(int arg0, Java.Lang.String arg1)
        {
            return IExecute<int>("getLayoutDimension", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/TypedArray.html#getResourceId(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetResourceId(int arg0, int arg1)
        {
            return IExecute<int>("getResourceId", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/TypedArray.html#getSourceResourceId(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetSourceResourceId(int arg0, int arg1)
        {
            return IExecute<int>("getSourceResourceId", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/TypedArray.html#getType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetType(int arg0)
        {
            return IExecute<int>("getType", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/TypedArray.html#length()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Length()
        {
            return IExecute<int>("length");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/TypedArray.html#getText(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetText(int arg0)
        {
            return IExecute<Java.Lang.CharSequence>("getText", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/TypedArray.html#getTextArray(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence[] GetTextArray(int arg0)
        {
            return IExecuteArray<Java.Lang.CharSequence>("getTextArray", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/TypedArray.html#getNonResourceString(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetNonResourceString(int arg0)
        {
            return IExecute<Java.Lang.String>("getNonResourceString", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/TypedArray.html#getPositionDescription()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPositionDescription()
        {
            return IExecute<Java.Lang.String>("getPositionDescription");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/TypedArray.html#getString(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetString(int arg0)
        {
            return IExecute<Java.Lang.String>("getString", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/TypedArray.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/TypedArray.html#recycle()"/>
        /// </summary>
        public void Recycle()
        {
            IExecute("recycle");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}