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
    /// Listener for Java UnaryOperator <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/UnaryOperator.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    /// <typeparam name="TObject">The data type associated to the event</typeparam>
    public interface IUnaryOperator<TObject> : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the UnaryOperator action in the CLR
        /// </summary>
        /// <param name="obj">The UnaryOperator object</param>
        /// <returns>The apply <typeparamref name="TObject"/></returns>
        TObject Apply(TObject obj);
    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/UnaryOperator.html"/>. Extends <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener.htm"/>
    /// </summary>
    public abstract class UnaryOperator : JVMBridgeListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.mases.netdroid.developed.java.util.function.UnaryOperator";
    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/UnaryOperator.html"/>. Extends <see cref="UnaryOperator"/>
    /// </summary>
    /// <typeparam name="TObject">The data type associated to the event</typeparam>
    public class UnaryOperator<TObject> : UnaryOperator, IUnaryOperator<TObject>
    {
        /// <summary>
        /// The <see cref="Func{TObject, TObject}"/> to be executed
        /// </summary>
        public virtual Func<TObject, TObject> OnApply { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="UnaryOperator{TObject}"/>
        /// </summary>
        public UnaryOperator()
        {
            AddEventHandler("apply", new EventHandler<CLRListenerEventArgs<CLREventData<TObject>>>(ApplyEventHandler)); OnApply = Apply;
        }

        void ApplyEventHandler(object sender, CLRListenerEventArgs<CLREventData<TObject>> data)
        {
            var retVal = OnApply(data.EventData.TypedEventData);
            data.SetReturnValue(retVal);
        }
        /// <summary>
        /// Executes the UnaryOperator action in the CLR
        /// </summary>
        /// <param name="obj">The UnaryOperator object</param>
        /// <returns>The apply <typeparamref name="TObject"/></returns>
        public virtual TObject Apply(TObject obj) { return default(TObject); }
    }
}