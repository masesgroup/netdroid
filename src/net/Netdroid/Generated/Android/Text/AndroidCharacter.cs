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

namespace Android.Text
{
    #region AndroidCharacter declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/text/AndroidCharacter.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class AndroidCharacter : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AndroidCharacter>
    {
        const string _bridgeClassName = "android.text.AndroidCharacter";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AndroidCharacter() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AndroidCharacter(params object[] args) : base(args) { }
    
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

    #region AndroidCharacter implementation
    public partial class AndroidCharacter
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/AndroidCharacter.html#EAST_ASIAN_WIDTH_AMBIGUOUS"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int EAST_ASIAN_WIDTH_AMBIGUOUS { get { if (!_EAST_ASIAN_WIDTH_AMBIGUOUSReady) { _EAST_ASIAN_WIDTH_AMBIGUOUSContent = SGetField<int>(LocalBridgeClazz, "EAST_ASIAN_WIDTH_AMBIGUOUS"); _EAST_ASIAN_WIDTH_AMBIGUOUSReady = true; } return _EAST_ASIAN_WIDTH_AMBIGUOUSContent; } }
        private static int _EAST_ASIAN_WIDTH_AMBIGUOUSContent = default;
        private static bool _EAST_ASIAN_WIDTH_AMBIGUOUSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/AndroidCharacter.html#EAST_ASIAN_WIDTH_FULL_WIDTH"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int EAST_ASIAN_WIDTH_FULL_WIDTH { get { if (!_EAST_ASIAN_WIDTH_FULL_WIDTHReady) { _EAST_ASIAN_WIDTH_FULL_WIDTHContent = SGetField<int>(LocalBridgeClazz, "EAST_ASIAN_WIDTH_FULL_WIDTH"); _EAST_ASIAN_WIDTH_FULL_WIDTHReady = true; } return _EAST_ASIAN_WIDTH_FULL_WIDTHContent; } }
        private static int _EAST_ASIAN_WIDTH_FULL_WIDTHContent = default;
        private static bool _EAST_ASIAN_WIDTH_FULL_WIDTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/AndroidCharacter.html#EAST_ASIAN_WIDTH_HALF_WIDTH"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int EAST_ASIAN_WIDTH_HALF_WIDTH { get { if (!_EAST_ASIAN_WIDTH_HALF_WIDTHReady) { _EAST_ASIAN_WIDTH_HALF_WIDTHContent = SGetField<int>(LocalBridgeClazz, "EAST_ASIAN_WIDTH_HALF_WIDTH"); _EAST_ASIAN_WIDTH_HALF_WIDTHReady = true; } return _EAST_ASIAN_WIDTH_HALF_WIDTHContent; } }
        private static int _EAST_ASIAN_WIDTH_HALF_WIDTHContent = default;
        private static bool _EAST_ASIAN_WIDTH_HALF_WIDTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/AndroidCharacter.html#EAST_ASIAN_WIDTH_NARROW"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int EAST_ASIAN_WIDTH_NARROW { get { if (!_EAST_ASIAN_WIDTH_NARROWReady) { _EAST_ASIAN_WIDTH_NARROWContent = SGetField<int>(LocalBridgeClazz, "EAST_ASIAN_WIDTH_NARROW"); _EAST_ASIAN_WIDTH_NARROWReady = true; } return _EAST_ASIAN_WIDTH_NARROWContent; } }
        private static int _EAST_ASIAN_WIDTH_NARROWContent = default;
        private static bool _EAST_ASIAN_WIDTH_NARROWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/AndroidCharacter.html#EAST_ASIAN_WIDTH_NEUTRAL"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int EAST_ASIAN_WIDTH_NEUTRAL { get { if (!_EAST_ASIAN_WIDTH_NEUTRALReady) { _EAST_ASIAN_WIDTH_NEUTRALContent = SGetField<int>(LocalBridgeClazz, "EAST_ASIAN_WIDTH_NEUTRAL"); _EAST_ASIAN_WIDTH_NEUTRALReady = true; } return _EAST_ASIAN_WIDTH_NEUTRALContent; } }
        private static int _EAST_ASIAN_WIDTH_NEUTRALContent = default;
        private static bool _EAST_ASIAN_WIDTH_NEUTRALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/AndroidCharacter.html#EAST_ASIAN_WIDTH_WIDE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int EAST_ASIAN_WIDTH_WIDE { get { if (!_EAST_ASIAN_WIDTH_WIDEReady) { _EAST_ASIAN_WIDTH_WIDEContent = SGetField<int>(LocalBridgeClazz, "EAST_ASIAN_WIDTH_WIDE"); _EAST_ASIAN_WIDTH_WIDEReady = true; } return _EAST_ASIAN_WIDTH_WIDEContent; } }
        private static int _EAST_ASIAN_WIDTH_WIDEContent = default;
        private static bool _EAST_ASIAN_WIDTH_WIDEReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/AndroidCharacter.html#mirror(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public static bool Mirror(char[] arg0, int arg1, int arg2)
        {
            return SExecute<bool>(LocalBridgeClazz, "mirror", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/AndroidCharacter.html#getMirror(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="char"/></returns>
        [global::System.Obsolete()]
        public static char GetMirror(char arg0)
        {
            return SExecuteWithSignature<char>(LocalBridgeClazz, "getMirror", "(C)C", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/AndroidCharacter.html#getEastAsianWidth(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public static int GetEastAsianWidth(char arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getEastAsianWidth", "(C)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/AndroidCharacter.html#getDirectionalities(char[],byte[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        [global::System.Obsolete()]
        public static void GetDirectionalities(char[] arg0, byte[] arg1, int arg2)
        {
            SExecute(LocalBridgeClazz, "getDirectionalities", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/AndroidCharacter.html#getEastAsianWidths(char[],int,int,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="byte"/></param>
        [global::System.Obsolete()]
        public static void GetEastAsianWidths(char[] arg0, int arg1, int arg2, byte[] arg3)
        {
            SExecute(LocalBridgeClazz, "getEastAsianWidths", arg0, arg1, arg2, arg3);
        }
    
        #endregion
    
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}