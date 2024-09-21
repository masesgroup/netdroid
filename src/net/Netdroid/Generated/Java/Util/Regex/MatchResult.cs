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

namespace Java.Util.Regex
{
    #region MatchResult declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/regex/MatchResult.html"/>
    /// </summary>
    public partial class MatchResult : MASES.JCOBridge.C2JBridge.JVMBridgeBase<MatchResult>
    {
        const string _bridgeClassName = "java.util.regex.MatchResult";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("MatchResult class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public MatchResult() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("MatchResult class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public MatchResult(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region IMatchResult
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IMatchResult
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MatchResult implementation
    public partial class MatchResult : Java.Util.Regex.IMatchResult
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
        /// <see href="https://developer.android.com/reference/java/util/regex/MatchResult.html#end()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int End()
        {
            return IExecuteWithSignature<int>("end", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/MatchResult.html#end(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int End(int arg0)
        {
            return IExecuteWithSignature<int>("end", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/MatchResult.html#groupCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GroupCount()
        {
            return IExecuteWithSignature<int>("groupCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/MatchResult.html#start()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Start()
        {
            return IExecuteWithSignature<int>("start", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/MatchResult.html#start(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int Start(int arg0)
        {
            return IExecuteWithSignature<int>("start", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/MatchResult.html#group()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Group()
        {
            return IExecuteWithSignature<Java.Lang.String>("group", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/MatchResult.html#group(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Group(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("group", "(I)Ljava/lang/String;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}