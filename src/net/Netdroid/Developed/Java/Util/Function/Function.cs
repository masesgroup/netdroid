﻿/*
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

using MASES.JCOBridge.C2JBridge;
using System;

namespace Java.Util.Function
{
    /// <summary>
    /// Listener for Java Function <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/Function.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    /// <typeparam name="TObject">The data type associated to the event</typeparam>
    /// <typeparam name="TReturn">The return data type associated to the event</typeparam>
    public interface IFunction<TObject, TReturn> : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the Function action in the CLR
        /// </summary>
        /// <param name="obj">The Function object</param>
        /// <returns>The apply <typeparamref name="TReturn"/></returns>
        TReturn Apply(TObject obj);
    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/Function.html"/>. Extends <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener.htm"/>
    /// </summary>
    public abstract class Function : JVMBridgeListener
    {
        /// <summary>
        /// Enable/disable handlers initialization, default is <see langword="true"/>
        /// </summary>
        protected virtual bool InitHandlers { get; } = true;

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.mases.netdroid.developed.java.util.function.Function";
    }


    /// <summary>
    /// Direct override of <see cref="Function"/>
    /// </summary>
    public class FunctionDirect : Function
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.12/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc cref="Predicate.InitHandlers"/>
        protected override bool InitHandlers => false;

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "java.util.function.Function";
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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    }

    /// <summary>
    /// Listener for Java Function <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/Function.html"/>. Extends <see cref="Function"/>
    /// </summary>
    /// <typeparam name="TObject">The data type associated to the event</typeparam>
    /// <typeparam name="TReturn">The return data type associated to the event</typeparam>
    public class Function<TObject, TReturn> : Function, IFunction<TObject, TReturn>
    {
        /// <summary>
        /// The <see cref="Func{TObject, TReturn}"/> to be executed
        /// </summary>
        public virtual Func<TObject, TReturn> OnApply { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="Function{TObject, TReturn}"/>
        /// </summary>
        public Function()
        {
            if (InitHandlers)
            {
                AddEventHandler("apply", new EventHandler<CLRListenerEventArgs<CLREventData<TObject>>>(ApplyEventHandler)); OnApply = Apply;
            }
        }

        void ApplyEventHandler(object sender, CLRListenerEventArgs<CLREventData<TObject>> data)
        {
            var retVal = OnApply(data.EventData.TypedEventData);
            data.SetReturnValue(retVal);
        }
        /// <summary>
        /// Executes the Function action in the CLR
        /// </summary>
        /// <param name="obj">The Function object</param>
        /// <returns>The apply <typeparamref name="TReturn"/></returns>
        public virtual TReturn Apply(TObject obj) { return default; }
    }

    /// <summary>
    /// Direct override of <see cref="Function{TObject, TReturn}"/>
    /// </summary>
    public class FunctionDirect<TObject, TReturn> : Function<TObject, TReturn>
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.12/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc cref="Predicate.InitHandlers"/>
        protected override bool InitHandlers => false;

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "java.util.function.Function";
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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    }
}