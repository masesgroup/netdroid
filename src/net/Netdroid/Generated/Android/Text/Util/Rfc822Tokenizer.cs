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

namespace Android.Text.Util
{
    #region Rfc822Tokenizer declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/text/util/Rfc822Tokenizer.html"/>
    /// </summary>
    public partial class Rfc822Tokenizer : Android.Widget.MultiAutoCompleteTextView.Tokenizer
    {
        const string _bridgeClassName = "android.text.util.Rfc822Tokenizer";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Rfc822Tokenizer() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Rfc822Tokenizer(params object[] args) : base(args) { }

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

    #region Rfc822Tokenizer implementation
    public partial class Rfc822Tokenizer
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/util/Rfc822Tokenizer.html#tokenize(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Android.Text.Util.Rfc822Token"/></returns>
        public static Android.Text.Util.Rfc822Token[] Tokenize(Java.Lang.CharSequence arg0)
        {
            return SExecuteWithSignatureArray<Android.Text.Util.Rfc822Token>(LocalBridgeClazz, "tokenize", "(Ljava/lang/CharSequence;)[Landroid/text/util/Rfc822Token;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/util/Rfc822Tokenizer.html#tokenize(java.lang.CharSequence,java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Util.Collection"/></param>
        public static void Tokenize(Java.Lang.CharSequence arg0, Java.Util.Collection<Android.Text.Util.Rfc822Token> arg1)
        {
            SExecuteWithSignature(LocalBridgeClazz, "tokenize", "(Ljava/lang/CharSequence;Ljava/util/Collection;)V", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/util/Rfc822Tokenizer.html#findTokenEnd(java.lang.CharSequence,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int FindTokenEnd(Java.Lang.CharSequence arg0, int arg1)
        {
            return IExecuteWithSignature<int>("findTokenEnd", "(Ljava/lang/CharSequence;I)I", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/util/Rfc822Tokenizer.html#findTokenStart(java.lang.CharSequence,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int FindTokenStart(Java.Lang.CharSequence arg0, int arg1)
        {
            return IExecuteWithSignature<int>("findTokenStart", "(Ljava/lang/CharSequence;I)I", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/util/Rfc822Tokenizer.html#terminateToken(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence TerminateToken(Java.Lang.CharSequence arg0)
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("terminateToken", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}