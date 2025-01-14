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

namespace Android.App
{
    #region GameManager declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/app/GameManager.html"/>
    /// </summary>
    public partial class GameManager : MASES.JCOBridge.C2JBridge.JVMBridgeBase<GameManager>
    {
        const string _bridgeClassName = "android.app.GameManager";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public GameManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public GameManager(params object[] args) : base(args) { }
    
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

    #region GameManager implementation
    public partial class GameManager
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/GameManager.html#GAME_MODE_BATTERY"/>
        /// </summary>
        public static int GAME_MODE_BATTERY { get { if (!_GAME_MODE_BATTERYReady) { _GAME_MODE_BATTERYContent = SGetField<int>(LocalBridgeClazz, "GAME_MODE_BATTERY"); _GAME_MODE_BATTERYReady = true; } return _GAME_MODE_BATTERYContent; } }
        private static int _GAME_MODE_BATTERYContent = default;
        private static bool _GAME_MODE_BATTERYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/GameManager.html#GAME_MODE_CUSTOM"/>
        /// </summary>
        public static int GAME_MODE_CUSTOM { get { if (!_GAME_MODE_CUSTOMReady) { _GAME_MODE_CUSTOMContent = SGetField<int>(LocalBridgeClazz, "GAME_MODE_CUSTOM"); _GAME_MODE_CUSTOMReady = true; } return _GAME_MODE_CUSTOMContent; } }
        private static int _GAME_MODE_CUSTOMContent = default;
        private static bool _GAME_MODE_CUSTOMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/GameManager.html#GAME_MODE_PERFORMANCE"/>
        /// </summary>
        public static int GAME_MODE_PERFORMANCE { get { if (!_GAME_MODE_PERFORMANCEReady) { _GAME_MODE_PERFORMANCEContent = SGetField<int>(LocalBridgeClazz, "GAME_MODE_PERFORMANCE"); _GAME_MODE_PERFORMANCEReady = true; } return _GAME_MODE_PERFORMANCEContent; } }
        private static int _GAME_MODE_PERFORMANCEContent = default;
        private static bool _GAME_MODE_PERFORMANCEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/GameManager.html#GAME_MODE_STANDARD"/>
        /// </summary>
        public static int GAME_MODE_STANDARD { get { if (!_GAME_MODE_STANDARDReady) { _GAME_MODE_STANDARDContent = SGetField<int>(LocalBridgeClazz, "GAME_MODE_STANDARD"); _GAME_MODE_STANDARDReady = true; } return _GAME_MODE_STANDARDContent; } }
        private static int _GAME_MODE_STANDARDContent = default;
        private static bool _GAME_MODE_STANDARDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/GameManager.html#GAME_MODE_UNSUPPORTED"/>
        /// </summary>
        public static int GAME_MODE_UNSUPPORTED { get { if (!_GAME_MODE_UNSUPPORTEDReady) { _GAME_MODE_UNSUPPORTEDContent = SGetField<int>(LocalBridgeClazz, "GAME_MODE_UNSUPPORTED"); _GAME_MODE_UNSUPPORTEDReady = true; } return _GAME_MODE_UNSUPPORTEDContent; } }
        private static int _GAME_MODE_UNSUPPORTEDContent = default;
        private static bool _GAME_MODE_UNSUPPORTEDReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/GameManager.html#getGameMode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetGameMode()
        {
            return IExecuteWithSignature<int>("getGameMode", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/GameManager.html#setGameState(android.app.GameState)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.GameState"/></param>
        public void SetGameState(Android.App.GameState arg0)
        {
            IExecuteWithSignature("setGameState", "(Landroid/app/GameState;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}