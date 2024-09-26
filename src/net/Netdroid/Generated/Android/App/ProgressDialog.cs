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

namespace Android.App
{
    #region ProgressDialog declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/app/ProgressDialog.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class ProgressDialog : Android.App.AlertDialog
    {
        const string _bridgeClassName = "android.app.ProgressDialog";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ProgressDialog() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ProgressDialog(params object[] args) : base(args) { }

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

    #region ProgressDialog implementation
    public partial class ProgressDialog
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ProgressDialog.html#%3Cinit%3E(android.content.Context,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        [global::System.Obsolete()]
        public ProgressDialog(Android.Content.Context arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ProgressDialog.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        [global::System.Obsolete()]
        public ProgressDialog(Android.Content.Context arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ProgressDialog.html#STYLE_HORIZONTAL"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int STYLE_HORIZONTAL { get { if (!_STYLE_HORIZONTALReady) { _STYLE_HORIZONTALContent = SGetField<int>(LocalBridgeClazz, "STYLE_HORIZONTAL"); _STYLE_HORIZONTALReady = true; } return _STYLE_HORIZONTALContent; } }
        private static int _STYLE_HORIZONTALContent = default;
        private static bool _STYLE_HORIZONTALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ProgressDialog.html#STYLE_SPINNER"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int STYLE_SPINNER { get { if (!_STYLE_SPINNERReady) { _STYLE_SPINNERContent = SGetField<int>(LocalBridgeClazz, "STYLE_SPINNER"); _STYLE_SPINNERReady = true; } return _STYLE_SPINNERContent; } }
        private static int _STYLE_SPINNERContent = default;
        private static bool _STYLE_SPINNERReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ProgressDialog.html#show(android.content.Context,java.lang.CharSequence,java.lang.CharSequence,boolean,boolean,android.content.DialogInterface.OnCancelListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg2"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        /// <param name="arg5"><see cref="Android.Content.DialogInterface.OnCancelListener"/></param>
        /// <returns><see cref="Android.App.ProgressDialog"/></returns>
        [global::System.Obsolete()]
        public static Android.App.ProgressDialog Show(Android.Content.Context arg0, Java.Lang.CharSequence arg1, Java.Lang.CharSequence arg2, bool arg3, bool arg4, Android.Content.DialogInterface.OnCancelListener arg5)
        {
            return SExecuteWithSignature<Android.App.ProgressDialog>(LocalBridgeClazz, "show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;ZZLandroid/content/DialogInterface$OnCancelListener;)Landroid/app/ProgressDialog;", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ProgressDialog.html#show(android.content.Context,java.lang.CharSequence,java.lang.CharSequence,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg2"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        /// <returns><see cref="Android.App.ProgressDialog"/></returns>
        [global::System.Obsolete()]
        public static Android.App.ProgressDialog Show(Android.Content.Context arg0, Java.Lang.CharSequence arg1, Java.Lang.CharSequence arg2, bool arg3, bool arg4)
        {
            return SExecuteWithSignature<Android.App.ProgressDialog>(LocalBridgeClazz, "show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;ZZ)Landroid/app/ProgressDialog;", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ProgressDialog.html#show(android.content.Context,java.lang.CharSequence,java.lang.CharSequence,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg2"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <returns><see cref="Android.App.ProgressDialog"/></returns>
        [global::System.Obsolete()]
        public static Android.App.ProgressDialog Show(Android.Content.Context arg0, Java.Lang.CharSequence arg1, Java.Lang.CharSequence arg2, bool arg3)
        {
            return SExecuteWithSignature<Android.App.ProgressDialog>(LocalBridgeClazz, "show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;Z)Landroid/app/ProgressDialog;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ProgressDialog.html#show(android.content.Context,java.lang.CharSequence,java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg2"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Android.App.ProgressDialog"/></returns>
        [global::System.Obsolete()]
        public static Android.App.ProgressDialog Show(Android.Content.Context arg0, Java.Lang.CharSequence arg1, Java.Lang.CharSequence arg2)
        {
            return SExecuteWithSignature<Android.App.ProgressDialog>(LocalBridgeClazz, "show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Landroid/app/ProgressDialog;", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ProgressDialog.html#isIndeterminate()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsIndeterminate()
        {
            return IExecuteWithSignature<bool>("isIndeterminate", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ProgressDialog.html#getMax()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetMax()
        {
            return IExecuteWithSignature<int>("getMax", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ProgressDialog.html#getProgress()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetProgress()
        {
            return IExecuteWithSignature<int>("getProgress", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ProgressDialog.html#getSecondaryProgress()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetSecondaryProgress()
        {
            return IExecuteWithSignature<int>("getSecondaryProgress", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ProgressDialog.html#incrementProgressBy(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void IncrementProgressBy(int arg0)
        {
            IExecuteWithSignature("incrementProgressBy", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ProgressDialog.html#incrementSecondaryProgressBy(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void IncrementSecondaryProgressBy(int arg0)
        {
            IExecuteWithSignature("incrementSecondaryProgressBy", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ProgressDialog.html#onStart()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void OnStart()
        {
            IExecuteWithSignature("onStart", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ProgressDialog.html#setIndeterminate(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void SetIndeterminate(bool arg0)
        {
            IExecuteWithSignature("setIndeterminate", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ProgressDialog.html#setIndeterminateDrawable(android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        [global::System.Obsolete()]
        public void SetIndeterminateDrawable(Android.Graphics.Drawable.Drawable arg0)
        {
            IExecuteWithSignature("setIndeterminateDrawable", "(Landroid/graphics/drawable/Drawable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ProgressDialog.html#setMax(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetMax(int arg0)
        {
            IExecuteWithSignature("setMax", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ProgressDialog.html#setProgress(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetProgress(int arg0)
        {
            IExecuteWithSignature("setProgress", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ProgressDialog.html#setProgressDrawable(android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        [global::System.Obsolete()]
        public void SetProgressDrawable(Android.Graphics.Drawable.Drawable arg0)
        {
            IExecuteWithSignature("setProgressDrawable", "(Landroid/graphics/drawable/Drawable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ProgressDialog.html#setProgressNumberFormat(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public void SetProgressNumberFormat(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setProgressNumberFormat", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ProgressDialog.html#setProgressPercentFormat(java.text.NumberFormat)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.NumberFormat"/></param>
        [global::System.Obsolete()]
        public void SetProgressPercentFormat(Java.Text.NumberFormat arg0)
        {
            IExecuteWithSignature("setProgressPercentFormat", "(Ljava/text/NumberFormat;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ProgressDialog.html#setProgressStyle(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetProgressStyle(int arg0)
        {
            IExecuteWithSignature("setProgressStyle", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ProgressDialog.html#setSecondaryProgress(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetSecondaryProgress(int arg0)
        {
            IExecuteWithSignature("setSecondaryProgress", "(I)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}