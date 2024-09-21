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

namespace Android.View.Translation
{
    #region TranslationManager declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/view/translation/TranslationManager.html"/>
    /// </summary>
    public partial class TranslationManager : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TranslationManager>
    {
        const string _bridgeClassName = "android.view.translation.TranslationManager";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TranslationManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TranslationManager(params object[] args) : base(args) { }

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

    #region TranslationManager implementation
    public partial class TranslationManager
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
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationManager.html#getOnDeviceTranslationSettingsActivityIntent()"/>
        /// </summary>
        /// <returns><see cref="Android.App.PendingIntent"/></returns>
        public Android.App.PendingIntent GetOnDeviceTranslationSettingsActivityIntent()
        {
            return IExecuteWithSignature<Android.App.PendingIntent>("getOnDeviceTranslationSettingsActivityIntent", "()Landroid/app/PendingIntent;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationManager.html#getOnDeviceTranslationCapabilities(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Android.View.Translation.TranslationCapability> GetOnDeviceTranslationCapabilities(int arg0, int arg1)
        {
            return IExecute<Java.Util.Set<Android.View.Translation.TranslationCapability>>("getOnDeviceTranslationCapabilities", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationManager.html#addOnDeviceTranslationCapabilityUpdateListener(java.util.concurrent.Executor,java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Consumer"/></param>
        public void AddOnDeviceTranslationCapabilityUpdateListener(Java.Util.Concurrent.Executor arg0, Java.Util.Function.Consumer<Android.View.Translation.TranslationCapability> arg1)
        {
            IExecute("addOnDeviceTranslationCapabilityUpdateListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationManager.html#createOnDeviceTranslator(android.view.translation.TranslationContext,java.util.concurrent.Executor,java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Translation.TranslationContext"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.Consumer"/></param>
        public void CreateOnDeviceTranslator(Android.View.Translation.TranslationContext arg0, Java.Util.Concurrent.Executor arg1, Java.Util.Function.Consumer<Android.View.Translation.Translator> arg2)
        {
            IExecute("createOnDeviceTranslator", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationManager.html#removeOnDeviceTranslationCapabilityUpdateListener(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        public void RemoveOnDeviceTranslationCapabilityUpdateListener(Java.Util.Function.Consumer<Android.View.Translation.TranslationCapability> arg0)
        {
            IExecuteWithSignature("removeOnDeviceTranslationCapabilityUpdateListener", "(Ljava/util/function/Consumer;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}