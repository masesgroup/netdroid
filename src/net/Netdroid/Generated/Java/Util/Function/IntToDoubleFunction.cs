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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Function
{
    #region IIntToDoubleFunction
    /// <summary>
    /// .NET interface for org.mases.netdroid.generated.java.util.function.IntToDoubleFunction implementing <see href="https://developer.android.com/reference/java/util/function/IntToDoubleFunction.html"/>
    /// </summary>
    public partial interface IIntToDoubleFunction
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IntToDoubleFunction
    public partial class IntToDoubleFunction : Java.Util.Function.IIntToDoubleFunction
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
        /// Handlers initializer for <see cref="IntToDoubleFunction"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("applyAsDouble", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(ApplyAsDoubleEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java/util/function/IntToDoubleFunction.html#applyAsDouble(int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnApplyAsDouble"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<int, double> OnApplyAsDouble { get; set; } = null;

        void ApplyAsDoubleEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            var methodToExecute = (OnApplyAsDouble != null) ? OnApplyAsDouble : ApplyAsDouble;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/IntToDoubleFunction.html#applyAsDouble(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="double"/></returns>
        public virtual double ApplyAsDouble(int arg0)
        {
            return default;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IntToDoubleFunctionDirect
    public partial class IntToDoubleFunctionDirect : Java.Util.Function.IIntToDoubleFunction
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
        /// <see href="https://developer.android.com/reference/java/util/function/IntToDoubleFunction.html#applyAsDouble(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="double"/></returns>
        public override double ApplyAsDouble(int arg0)
        {
            return IExecuteWithSignature<double>("applyAsDouble", "(I)D", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}