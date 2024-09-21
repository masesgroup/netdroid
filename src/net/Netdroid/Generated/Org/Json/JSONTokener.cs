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

namespace Org.Json
{
    #region JSONTokener declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/org/json/JSONTokener.html"/>
    /// </summary>
    public partial class JSONTokener : MASES.JCOBridge.C2JBridge.JVMBridgeBase<JSONTokener>
    {
        const string _bridgeClassName = "org.json.JSONTokener";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public JSONTokener() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public JSONTokener(params object[] args) : base(args) { }

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

    #region JSONTokener implementation
    public partial class JSONTokener
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONTokener.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public JSONTokener(Java.Lang.String arg0)
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
        /// <see href="https://developer.android.com/reference/org/json/JSONTokener.html#dehexchar(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Dehexchar(char arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "dehexchar", "(C)I", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONTokener.html#more()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool More()
        {
            return IExecuteWithSignature<bool>("more", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONTokener.html#next()"/>
        /// </summary>
        /// <returns><see cref="char"/></returns>
        public char Next()
        {
            return IExecuteWithSignature<char>("next", "()C");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONTokener.html#next(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="char"/></returns>
        /// <exception cref="Org.Json.JSONException"/>
        public char Next(char arg0)
        {
            return IExecuteWithSignature<char>("next", "(C)C", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONTokener.html#nextClean()"/>
        /// </summary>
        /// <returns><see cref="char"/></returns>
        /// <exception cref="Org.Json.JSONException"/>
        public char NextClean()
        {
            return IExecuteWithSignature<char>("nextClean", "()C");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONTokener.html#skipTo(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="char"/></returns>
        public char SkipTo(char arg0)
        {
            return IExecuteWithSignature<char>("skipTo", "(C)C", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONTokener.html#nextValue()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Org.Json.JSONException"/>
        public object NextValue()
        {
            return IExecuteWithSignature("nextValue", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONTokener.html#next(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Org.Json.JSONException"/>
        public Java.Lang.String Next(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("next", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONTokener.html#nextString(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Org.Json.JSONException"/>
        public Java.Lang.String NextString(char arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("nextString", "(C)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONTokener.html#nextTo(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String NextTo(char arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("nextTo", "(C)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONTokener.html#nextTo(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String NextTo(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("nextTo", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONTokener.html#syntaxError(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Json.JSONException"/></returns>
        public Org.Json.JSONException SyntaxError(Java.Lang.String arg0)
        {
            var obj = IExecuteWithSignature<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>("syntaxError", "(Ljava/lang/String;)Lorg/json/JSONException;", arg0); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<Org.Json.JSONException>(obj);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONTokener.html#back()"/>
        /// </summary>
        public void Back()
        {
            IExecuteWithSignature("back", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/json/JSONTokener.html#skipPast(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SkipPast(Java.Lang.String arg0)
        {
            IExecuteWithSignature("skipPast", "(Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}