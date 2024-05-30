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
    #region ToIntBiFunction
    public partial class ToIntBiFunction
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
        /// Handlers initializer for <see cref="ToIntBiFunction"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("applyAsInt", new System.EventHandler<CLRListenerEventArgs<CLREventData<object>>>(ApplyAsIntEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java.base/java/util/function/ToIntBiFunction.html#applyAsInt(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <remarks>If <see cref="OnApplyAsInt"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<object, object, int> OnApplyAsInt { get; set; } = null;

        void ApplyAsIntEventHandler(object sender, CLRListenerEventArgs<CLREventData<object>> data)
        {
            var methodToExecute = (OnApplyAsInt != null) ? OnApplyAsInt : ApplyAsInt;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<object>(0));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/function/ToIntBiFunction.html#applyAsInt(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public virtual int ApplyAsInt(object arg0, object arg1)
        {
            return default;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ToIntBiFunctionDirect
    public partial class ToIntBiFunctionDirect
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
        /// <see href="https://developer.android.com/reference/java.base/java/util/function/ToIntBiFunction.html#applyAsInt(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public override int ApplyAsInt(object arg0, object arg1)
        {
            return IExecute<int>("applyAsInt", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IToIntBiFunction<T, U>
    /// <summary>
    /// .NET interface for org.mases.netdroid.generated.java.util.function.ToIntBiFunction implementing <see href="https://developer.android.com/reference/java.base/java/util/function/ToIntBiFunction.html"/>
    /// </summary>
    public partial interface IToIntBiFunction<T, U>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/function/ToIntBiFunction.html#applyAsInt(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><typeparamref name="U"/></param>
        /// <returns><see cref="int"/></returns>
        int ApplyAsInt(T arg0, U arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ToIntBiFunction<T, U>
    public partial class ToIntBiFunction<T, U> : Java.Util.Function.IToIntBiFunction<T, U>
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
        /// Handlers initializer for <see cref="ToIntBiFunction"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("applyAsInt", new System.EventHandler<CLRListenerEventArgs<CLREventData<T>>>(ApplyAsIntEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java.base/java/util/function/ToIntBiFunction.html#applyAsInt(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <remarks>If <see cref="OnApplyAsInt"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<T, U, int> OnApplyAsInt { get; set; } = null;

        void ApplyAsIntEventHandler(object sender, CLRListenerEventArgs<CLREventData<T>> data)
        {
            var methodToExecute = (OnApplyAsInt != null) ? OnApplyAsInt : ApplyAsInt;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<U>(0));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/function/ToIntBiFunction.html#applyAsInt(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><typeparamref name="U"/></param>
        /// <returns><see cref="int"/></returns>
        public virtual int ApplyAsInt(T arg0, U arg1)
        {
            return default;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ToIntBiFunctionDirect<T, U>
    public partial class ToIntBiFunctionDirect<T, U> : Java.Util.Function.IToIntBiFunction<T, U>
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
        /// <see href="https://developer.android.com/reference/java.base/java/util/function/ToIntBiFunction.html#applyAsInt(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><typeparamref name="U"/></param>
        /// <returns><see cref="int"/></returns>
        public override int ApplyAsInt(T arg0, U arg1)
        {
            return IExecute<int>("applyAsInt", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}