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

namespace Android.Text.Style
{
    #region BulletSpan declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/text/style/BulletSpan.html"/>
    /// </summary>
    public partial class BulletSpan : MASES.JCOBridge.C2JBridge.JVMBridgeBase<BulletSpan>
    {
        const string _bridgeClassName = "android.text.style.BulletSpan";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public BulletSpan() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public BulletSpan(params object[] args) : base(args) { }
    
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

    #region BulletSpan implementation
    public partial class BulletSpan : Android.Text.Style.ILeadingMarginSpan, Android.Text.IParcelableSpan
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/BulletSpan.html#%3Cinit%3E(android.os.Parcel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        public BulletSpan(Android.Os.Parcel arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/BulletSpan.html#%3Cinit%3E(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public BulletSpan(int arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/BulletSpan.html#%3Cinit%3E(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public BulletSpan(int arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/BulletSpan.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public BulletSpan(int arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Text.Style.BulletSpan"/> to <see cref="Android.Text.Style.LeadingMarginSpan"/>
        /// </summary>
        public static implicit operator Android.Text.Style.LeadingMarginSpan(Android.Text.Style.BulletSpan t) => t.Cast<Android.Text.Style.LeadingMarginSpan>();
        /// <summary>
        /// Converter from <see cref="Android.Text.Style.BulletSpan"/> to <see cref="Android.Text.ParcelableSpan"/>
        /// </summary>
        public static implicit operator Android.Text.ParcelableSpan(Android.Text.Style.BulletSpan t) => t.Cast<Android.Text.ParcelableSpan>();
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/BulletSpan.html#STANDARD_GAP_WIDTH"/>
        /// </summary>
        public static int STANDARD_GAP_WIDTH { get { if (!_STANDARD_GAP_WIDTHReady) { _STANDARD_GAP_WIDTHContent = SGetField<int>(LocalBridgeClazz, "STANDARD_GAP_WIDTH"); _STANDARD_GAP_WIDTHReady = true; } return _STANDARD_GAP_WIDTHContent; } }
        private static int _STANDARD_GAP_WIDTHContent = default;
        private static bool _STANDARD_GAP_WIDTHReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/BulletSpan.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/BulletSpan.html#getBulletRadius()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetBulletRadius()
        {
            return IExecuteWithSignature<int>("getBulletRadius", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/BulletSpan.html#getColor()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetColor()
        {
            return IExecuteWithSignature<int>("getColor", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/BulletSpan.html#getGapWidth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetGapWidth()
        {
            return IExecuteWithSignature<int>("getGapWidth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/BulletSpan.html#getLeadingMargin(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetLeadingMargin(bool arg0)
        {
            return IExecuteWithSignature<int>("getLeadingMargin", "(Z)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/BulletSpan.html#getSpanTypeId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSpanTypeId()
        {
            return IExecuteWithSignature<int>("getSpanTypeId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/BulletSpan.html#drawLeadingMargin(android.graphics.Canvas,android.graphics.Paint,int,int,int,int,int,java.lang.CharSequence,int,int,boolean,android.text.Layout)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Canvas"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Paint"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        /// <param name="arg9"><see cref="int"/></param>
        /// <param name="arg10"><see cref="bool"/></param>
        /// <param name="arg11"><see cref="Android.Text.Layout"/></param>
        public void DrawLeadingMargin(Android.Graphics.Canvas arg0, Android.Graphics.Paint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, Java.Lang.CharSequence arg7, int arg8, int arg9, bool arg10, Android.Text.Layout arg11)
        {
            IExecute("drawLeadingMargin", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/BulletSpan.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}