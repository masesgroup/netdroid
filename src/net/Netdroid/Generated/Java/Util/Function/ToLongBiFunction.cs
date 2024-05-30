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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Function
{
    #region ToLongBiFunction
    public partial class ToLongBiFunction
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
        /// Handlers initializer for <see cref="ToLongBiFunction"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("applyAsLong", new System.EventHandler<CLRListenerEventArgs<CLREventData<object>>>(ApplyAsLongEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java.base/java/util/function/ToLongBiFunction.html#applyAsLong(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <remarks>If <see cref="OnApplyAsLong"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<object, object, long> OnApplyAsLong { get; set; } = null;

        void ApplyAsLongEventHandler(object sender, CLRListenerEventArgs<CLREventData<object>> data)
        {
            var methodToExecute = (OnApplyAsLong != null) ? OnApplyAsLong : ApplyAsLong;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<object>(0));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/function/ToLongBiFunction.html#applyAsLong(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="long"/></returns>
        public virtual long ApplyAsLong(object arg0, object arg1)
        {
            return default;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ToLongBiFunctionDirect
    public partial class ToLongBiFunctionDirect
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
        /// <see href="https://developer.android.com/reference/java.base/java/util/function/ToLongBiFunction.html#applyAsLong(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="long"/></returns>
        public override long ApplyAsLong(object arg0, object arg1)
        {
            return IExecute<long>("applyAsLong", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IToLongBiFunction<T, U>
    /// <summary>
    /// .NET interface for org.mases.netdroid.generated.java.util.function.ToLongBiFunction implementing <see href="https://developer.android.com/reference/java.base/java/util/function/ToLongBiFunction.html"/>
    /// </summary>
    public partial interface IToLongBiFunction<T, U>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/function/ToLongBiFunction.html#applyAsLong(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><typeparamref name="U"/></param>
        /// <returns><see cref="long"/></returns>
        long ApplyAsLong(T arg0, U arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ToLongBiFunction<T, U>
    public partial class ToLongBiFunction<T, U> : Java.Util.Function.IToLongBiFunction<T, U>
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
        /// Handlers initializer for <see cref="ToLongBiFunction"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("applyAsLong", new System.EventHandler<CLRListenerEventArgs<CLREventData<T>>>(ApplyAsLongEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java.base/java/util/function/ToLongBiFunction.html#applyAsLong(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <remarks>If <see cref="OnApplyAsLong"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<T, U, long> OnApplyAsLong { get; set; } = null;

        void ApplyAsLongEventHandler(object sender, CLRListenerEventArgs<CLREventData<T>> data)
        {
            var methodToExecute = (OnApplyAsLong != null) ? OnApplyAsLong : ApplyAsLong;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<U>(0));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/function/ToLongBiFunction.html#applyAsLong(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><typeparamref name="U"/></param>
        /// <returns><see cref="long"/></returns>
        public virtual long ApplyAsLong(T arg0, U arg1)
        {
            return default;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ToLongBiFunctionDirect<T, U>
    public partial class ToLongBiFunctionDirect<T, U> : Java.Util.Function.IToLongBiFunction<T, U>
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
        /// <see href="https://developer.android.com/reference/java.base/java/util/function/ToLongBiFunction.html#applyAsLong(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><typeparamref name="U"/></param>
        /// <returns><see cref="long"/></returns>
        public override long ApplyAsLong(T arg0, U arg1)
        {
            return IExecute<long>("applyAsLong", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}