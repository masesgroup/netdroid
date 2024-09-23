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

namespace Android.Os
{
    #region AsyncTask declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/os/AsyncTask.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class AsyncTask : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AsyncTask>
    {
        const string _bridgeClassName = "android.os.AsyncTask";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("AsyncTask class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AsyncTask() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("AsyncTask class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AsyncTask(params object[] args) : base(args) { }
    
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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
        #region Status declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/AsyncTask.Status.html"/>
        /// </summary>
        [global::System.Obsolete()]
        public partial class Status : Java.Lang.Enum<Android.Os.AsyncTask.Status>
        {
            const string _bridgeClassName = "android.os.AsyncTask$Status";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Status() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Status(params object[] args) : base(args) { }
        
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
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

    
    }
    #endregion

    #region AsyncTask<Params, Progress, Result> declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/os/AsyncTask.html"/>
    /// </summary>
    /// <typeparam name="Params"></typeparam>
    /// <typeparam name="Progress"></typeparam>
    /// <typeparam name="Result"></typeparam>
    [global::System.Obsolete()]
    public partial class AsyncTask<Params, Progress, Result> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AsyncTask<Params, Progress, Result>>
    {
        const string _bridgeClassName = "android.os.AsyncTask";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("AsyncTask class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AsyncTask() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("AsyncTask class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AsyncTask(params object[] args) : base(args) { }
    
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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
    
    }
    #endregion

    #region AsyncTask implementation
    public partial class AsyncTask
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/AsyncTask.html#SERIAL_EXECUTOR"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Util.Concurrent.Executor SERIAL_EXECUTOR { get { if (!_SERIAL_EXECUTORReady) { _SERIAL_EXECUTORContent = SGetField<Java.Util.Concurrent.Executor>(LocalBridgeClazz, "SERIAL_EXECUTOR"); _SERIAL_EXECUTORReady = true; } return _SERIAL_EXECUTORContent; } }
        private static Java.Util.Concurrent.Executor _SERIAL_EXECUTORContent = default;
        private static bool _SERIAL_EXECUTORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/AsyncTask.html#THREAD_POOL_EXECUTOR"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Util.Concurrent.Executor THREAD_POOL_EXECUTOR { get { if (!_THREAD_POOL_EXECUTORReady) { _THREAD_POOL_EXECUTORContent = SGetField<Java.Util.Concurrent.Executor>(LocalBridgeClazz, "THREAD_POOL_EXECUTOR"); _THREAD_POOL_EXECUTORReady = true; } return _THREAD_POOL_EXECUTORContent; } }
        private static Java.Util.Concurrent.Executor _THREAD_POOL_EXECUTORContent = default;
        private static bool _THREAD_POOL_EXECUTORReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/AsyncTask.html#execute(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        [global::System.Obsolete()]
        public static void Execute(Java.Lang.Runnable arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "execute", "(Ljava/lang/Runnable;)V", arg0);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/AsyncTask.html#execute(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Android.Os.AsyncTask"/></returns>
        [global::System.Obsolete()]
        public Android.Os.AsyncTask Execute(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecuteWithSignature<Android.Os.AsyncTask>("execute", "([Ljava/lang/Object;)Landroid/os/AsyncTask;"); else return IExecuteWithSignature<Android.Os.AsyncTask>("execute", "([Ljava/lang/Object;)Landroid/os/AsyncTask;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/AsyncTask.html#executeOnExecutor(java.util.concurrent.Executor,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Android.Os.AsyncTask"/></returns>
        [global::System.Obsolete()]
        public Android.Os.AsyncTask ExecuteOnExecutor(Java.Util.Concurrent.Executor arg0, params object[] arg1)
        {
            if (arg1.Length == 0) return IExecute<Android.Os.AsyncTask>("executeOnExecutor", arg0); else return IExecute<Android.Os.AsyncTask>("executeOnExecutor", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/AsyncTask.html#getStatus()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.AsyncTask.Status"/></returns>
        [global::System.Obsolete()]
        public Android.Os.AsyncTask.Status GetStatus()
        {
            return IExecuteWithSignature<Android.Os.AsyncTask.Status>("getStatus", "()Landroid/os/AsyncTask$Status;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/AsyncTask.html#cancel(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool Cancel(bool arg0)
        {
            return IExecuteWithSignature<bool>("cancel", "(Z)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/AsyncTask.html#isCancelled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsCancelled()
        {
            return IExecuteWithSignature<bool>("isCancelled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/AsyncTask.html#get()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Util.Concurrent.ExecutionException"/>
        /// <exception cref="Java.Lang.InterruptedException"/>
        [global::System.Obsolete()]
        public object Get()
        {
            return IExecuteWithSignature("get", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/AsyncTask.html#get(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Util.Concurrent.ExecutionException"/>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Java.Util.Concurrent.TimeoutException"/>
        [global::System.Obsolete()]
        public object Get(long arg0, Java.Util.Concurrent.TimeUnit arg1)
        {
            return IExecute("get", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
        #region Status implementation
        public partial class Status
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/AsyncTask.Status.html#FINISHED"/>
            /// </summary>
            [global::System.Obsolete()]
            public static Android.Os.AsyncTask.Status FINISHED { get { if (!_FINISHEDReady) { _FINISHEDContent = SGetField<Android.Os.AsyncTask.Status>(LocalBridgeClazz, "FINISHED"); _FINISHEDReady = true; } return _FINISHEDContent; } }
            private static Android.Os.AsyncTask.Status _FINISHEDContent = default;
            private static bool _FINISHEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/AsyncTask.Status.html#PENDING"/>
            /// </summary>
            [global::System.Obsolete()]
            public static Android.Os.AsyncTask.Status PENDING { get { if (!_PENDINGReady) { _PENDINGContent = SGetField<Android.Os.AsyncTask.Status>(LocalBridgeClazz, "PENDING"); _PENDINGReady = true; } return _PENDINGContent; } }
            private static Android.Os.AsyncTask.Status _PENDINGContent = default;
            private static bool _PENDINGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/AsyncTask.Status.html#RUNNING"/>
            /// </summary>
            [global::System.Obsolete()]
            public static Android.Os.AsyncTask.Status RUNNING { get { if (!_RUNNINGReady) { _RUNNINGContent = SGetField<Android.Os.AsyncTask.Status>(LocalBridgeClazz, "RUNNING"); _RUNNINGReady = true; } return _RUNNINGContent; } }
            private static Android.Os.AsyncTask.Status _RUNNINGContent = default;
            private static bool _RUNNINGReady = false; // this is used because in case of generics 
        
            #endregion
        
            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/AsyncTask.Status.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Os.AsyncTask.Status"/></returns>
            public static Android.Os.AsyncTask.Status ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Os.AsyncTask.Status>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/os/AsyncTask$Status;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/AsyncTask.Status.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Os.AsyncTask.Status"/></returns>
            public static Android.Os.AsyncTask.Status[] Values()
            {
                return SExecuteWithSignatureArray<Android.Os.AsyncTask.Status>(LocalBridgeClazz, "values", "()[Landroid/os/AsyncTask$Status;");
            }
        
            #endregion
        
            #region Instance methods
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region AsyncTask<Params, Progress, Result> implementation
    public partial class AsyncTask<Params, Progress, Result>
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Os.AsyncTask{Params, Progress, Result}"/> to <see cref="Android.Os.AsyncTask"/>
        /// </summary>
        public static implicit operator Android.Os.AsyncTask(Android.Os.AsyncTask<Params, Progress, Result> t) => t.Cast<Android.Os.AsyncTask>();
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/AsyncTask.html#SERIAL_EXECUTOR"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Util.Concurrent.Executor SERIAL_EXECUTOR { get { if (!_SERIAL_EXECUTORReady) { _SERIAL_EXECUTORContent = SGetField<Java.Util.Concurrent.Executor>(LocalBridgeClazz, "SERIAL_EXECUTOR"); _SERIAL_EXECUTORReady = true; } return _SERIAL_EXECUTORContent; } }
        private static Java.Util.Concurrent.Executor _SERIAL_EXECUTORContent = default;
        private static bool _SERIAL_EXECUTORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/AsyncTask.html#THREAD_POOL_EXECUTOR"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Util.Concurrent.Executor THREAD_POOL_EXECUTOR { get { if (!_THREAD_POOL_EXECUTORReady) { _THREAD_POOL_EXECUTORContent = SGetField<Java.Util.Concurrent.Executor>(LocalBridgeClazz, "THREAD_POOL_EXECUTOR"); _THREAD_POOL_EXECUTORReady = true; } return _THREAD_POOL_EXECUTORContent; } }
        private static Java.Util.Concurrent.Executor _THREAD_POOL_EXECUTORContent = default;
        private static bool _THREAD_POOL_EXECUTORReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/AsyncTask.html#execute(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        [global::System.Obsolete()]
        public static void Execute(Java.Lang.Runnable arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "execute", "(Ljava/lang/Runnable;)V", arg0);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/AsyncTask.html#execute(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="Params"/></param>
        /// <returns><see cref="Android.Os.AsyncTask"/></returns>
        [global::System.Obsolete()]
        public Android.Os.AsyncTask<Params, Progress, Result> Execute(params Params[] arg0)
        {
            if (arg0.Length == 0) return IExecuteWithSignature<Android.Os.AsyncTask<Params, Progress, Result>>("execute", "([Ljava/lang/Object;)Landroid/os/AsyncTask;"); else return IExecuteWithSignature<Android.Os.AsyncTask<Params, Progress, Result>>("execute", "([Ljava/lang/Object;)Landroid/os/AsyncTask;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/AsyncTask.html#executeOnExecutor(java.util.concurrent.Executor,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><typeparamref name="Params"/></param>
        /// <returns><see cref="Android.Os.AsyncTask"/></returns>
        [global::System.Obsolete()]
        public Android.Os.AsyncTask<Params, Progress, Result> ExecuteOnExecutor(Java.Util.Concurrent.Executor arg0, params Params[] arg1)
        {
            if (arg1.Length == 0) return IExecute<Android.Os.AsyncTask<Params, Progress, Result>>("executeOnExecutor", arg0); else return IExecute<Android.Os.AsyncTask<Params, Progress, Result>>("executeOnExecutor", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/AsyncTask.html#getStatus()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.AsyncTask.Status"/></returns>
        [global::System.Obsolete()]
        public Android.Os.AsyncTask.Status GetStatus()
        {
            return IExecuteWithSignature<Android.Os.AsyncTask.Status>("getStatus", "()Landroid/os/AsyncTask$Status;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/AsyncTask.html#cancel(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool Cancel(bool arg0)
        {
            return IExecuteWithSignature<bool>("cancel", "(Z)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/AsyncTask.html#isCancelled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsCancelled()
        {
            return IExecuteWithSignature<bool>("isCancelled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/AsyncTask.html#get()"/>
        /// </summary>
        /// <returns><typeparamref name="Result"/></returns>
        /// <exception cref="Java.Util.Concurrent.ExecutionException"/>
        /// <exception cref="Java.Lang.InterruptedException"/>
        [global::System.Obsolete()]
        public Result Get()
        {
            return IExecuteWithSignature<Result>("get", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/AsyncTask.html#get(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><typeparamref name="Result"/></returns>
        /// <exception cref="Java.Util.Concurrent.ExecutionException"/>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Java.Util.Concurrent.TimeoutException"/>
        [global::System.Obsolete()]
        public Result Get(long arg0, Java.Util.Concurrent.TimeUnit arg1)
        {
            return IExecute<Result>("get", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}