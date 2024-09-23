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

namespace Java.Util.Stream
{
    #region DoubleStream declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html"/>
    /// </summary>
    public partial class DoubleStream : Java.Util.Stream.BaseStream<Java.Lang.Double, Java.Util.Stream.DoubleStream>
    {
        const string _bridgeClassName = "java.util.stream.DoubleStream";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("DoubleStream class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public DoubleStream() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("DoubleStream class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public DoubleStream(params object[] args) : base(args) { }
    
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

    #region IDoubleStream
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDoubleStream : Java.Util.Stream.IBaseStream<Java.Lang.Double, Java.Util.Stream.DoubleStream>
    {
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region DoubleStream implementation
    public partial class DoubleStream : Java.Util.Stream.IDoubleStream
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#concat(java.util.stream.DoubleStream,java.util.stream.DoubleStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Stream.DoubleStream"/></param>
        /// <param name="arg1"><see cref="Java.Util.Stream.DoubleStream"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public static Java.Util.Stream.DoubleStream Concat(Java.Util.Stream.DoubleStream arg0, Java.Util.Stream.DoubleStream arg1)
        {
            return SExecute<Java.Util.Stream.DoubleStream>(LocalBridgeClazz, "concat", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#empty()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public static Java.Util.Stream.DoubleStream Empty()
        {
            return SExecuteWithSignature<Java.Util.Stream.DoubleStream>(LocalBridgeClazz, "empty", "()Ljava/util/stream/DoubleStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#generate(java.util.function.DoubleSupplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleSupplier"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public static Java.Util.Stream.DoubleStream Generate(Java.Util.Function.DoubleSupplier arg0)
        {
            return SExecuteWithSignature<Java.Util.Stream.DoubleStream>(LocalBridgeClazz, "generate", "(Ljava/util/function/DoubleSupplier;)Ljava/util/stream/DoubleStream;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#iterate(double,java.util.function.DoublePredicate,java.util.function.DoubleUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.DoublePredicate"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.DoubleUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public static Java.Util.Stream.DoubleStream Iterate(double arg0, Java.Util.Function.DoublePredicate arg1, Java.Util.Function.DoubleUnaryOperator arg2)
        {
            return SExecute<Java.Util.Stream.DoubleStream>(LocalBridgeClazz, "iterate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#iterate(double,java.util.function.DoubleUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.DoubleUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public static Java.Util.Stream.DoubleStream Iterate(double arg0, Java.Util.Function.DoubleUnaryOperator arg1)
        {
            return SExecute<Java.Util.Stream.DoubleStream>(LocalBridgeClazz, "iterate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#of(double[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public static Java.Util.Stream.DoubleStream Of(params double[] arg0)
        {
            if (arg0.Length == 0) return SExecuteWithSignature<Java.Util.Stream.DoubleStream>(LocalBridgeClazz, "of", "([D)Ljava/util/stream/DoubleStream;"); else return SExecuteWithSignature<Java.Util.Stream.DoubleStream>(LocalBridgeClazz, "of", "([D)Ljava/util/stream/DoubleStream;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#of(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public static Java.Util.Stream.DoubleStream Of(double arg0)
        {
            return SExecuteWithSignature<Java.Util.Stream.DoubleStream>(LocalBridgeClazz, "of", "(D)Ljava/util/stream/DoubleStream;", arg0);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#collect(java.util.function.Supplier,java.util.function.ObjDoubleConsumer,java.util.function.BiConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.ObjDoubleConsumer"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.BiConsumer"/></param>
        /// <typeparam name="R"></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        public R Collect<R>(Java.Util.Function.Supplier<R> arg0, Java.Util.Function.ObjDoubleConsumer<R> arg1, Java.Util.Function.BiConsumer<R, R> arg2)
        {
            return IExecute<R>("collect", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#mapToObj(java.util.function.DoubleFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleFunction"/></param>
        /// <typeparam name="U"></typeparam>
        /// <typeparam name="Arg0ExtendsU"><typeparamref name="U"/></typeparam>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<U> MapToObj<U, Arg0ExtendsU>(Java.Util.Function.DoubleFunction<Arg0ExtendsU> arg0) where Arg0ExtendsU : U
        {
            return IExecuteWithSignature<Java.Util.Stream.Stream<U>>("mapToObj", "(Ljava/util/function/DoubleFunction;)Ljava/util/stream/Stream;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#allMatch(java.util.function.DoublePredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoublePredicate"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AllMatch(Java.Util.Function.DoublePredicate arg0)
        {
            return IExecuteWithSignature<bool>("allMatch", "(Ljava/util/function/DoublePredicate;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#anyMatch(java.util.function.DoublePredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoublePredicate"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AnyMatch(Java.Util.Function.DoublePredicate arg0)
        {
            return IExecuteWithSignature<bool>("anyMatch", "(Ljava/util/function/DoublePredicate;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#noneMatch(java.util.function.DoublePredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoublePredicate"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool NoneMatch(Java.Util.Function.DoublePredicate arg0)
        {
            return IExecuteWithSignature<bool>("noneMatch", "(Ljava/util/function/DoublePredicate;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#reduce(double,java.util.function.DoubleBinaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.DoubleBinaryOperator"/></param>
        /// <returns><see cref="double"/></returns>
        public double Reduce(double arg0, Java.Util.Function.DoubleBinaryOperator arg1)
        {
            return IExecute<double>("reduce", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#sum()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double Sum()
        {
            return IExecuteWithSignature<double>("sum", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#toArray()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double[] ToArray()
        {
            return IExecuteWithSignatureArray<double>("toArray", "()[D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#summaryStatistics()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.DoubleSummaryStatistics"/></returns>
        public Java.Util.DoubleSummaryStatistics SummaryStatistics()
        {
            return IExecuteWithSignature<Java.Util.DoubleSummaryStatistics>("summaryStatistics", "()Ljava/util/DoubleSummaryStatistics;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#average()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.OptionalDouble"/></returns>
        public Java.Util.OptionalDouble Average()
        {
            return IExecuteWithSignature<Java.Util.OptionalDouble>("average", "()Ljava/util/OptionalDouble;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#findAny()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.OptionalDouble"/></returns>
        public Java.Util.OptionalDouble FindAny()
        {
            return IExecuteWithSignature<Java.Util.OptionalDouble>("findAny", "()Ljava/util/OptionalDouble;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#findFirst()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.OptionalDouble"/></returns>
        public Java.Util.OptionalDouble FindFirst()
        {
            return IExecuteWithSignature<Java.Util.OptionalDouble>("findFirst", "()Ljava/util/OptionalDouble;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#max()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.OptionalDouble"/></returns>
        public Java.Util.OptionalDouble Max()
        {
            return IExecuteWithSignature<Java.Util.OptionalDouble>("max", "()Ljava/util/OptionalDouble;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#min()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.OptionalDouble"/></returns>
        public Java.Util.OptionalDouble Min()
        {
            return IExecuteWithSignature<Java.Util.OptionalDouble>("min", "()Ljava/util/OptionalDouble;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#reduce(java.util.function.DoubleBinaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleBinaryOperator"/></param>
        /// <returns><see cref="Java.Util.OptionalDouble"/></returns>
        public Java.Util.OptionalDouble Reduce(Java.Util.Function.DoubleBinaryOperator arg0)
        {
            return IExecuteWithSignature<Java.Util.OptionalDouble>("reduce", "(Ljava/util/function/DoubleBinaryOperator;)Ljava/util/OptionalDouble;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#distinct()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public Java.Util.Stream.DoubleStream Distinct()
        {
            return IExecuteWithSignature<Java.Util.Stream.DoubleStream>("distinct", "()Ljava/util/stream/DoubleStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#filter(java.util.function.DoublePredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoublePredicate"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public Java.Util.Stream.DoubleStream Filter(Java.Util.Function.DoublePredicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Stream.DoubleStream>("filter", "(Ljava/util/function/DoublePredicate;)Ljava/util/stream/DoubleStream;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#flatMap(java.util.function.DoubleFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleFunction"/></param>
        /// <typeparam name="Arg0ExtendsJava_Util_Stream_DoubleStream"><see cref="Java.Util.Stream.DoubleStream"/></typeparam>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public Java.Util.Stream.DoubleStream FlatMap<Arg0ExtendsJava_Util_Stream_DoubleStream>(Java.Util.Function.DoubleFunction<Arg0ExtendsJava_Util_Stream_DoubleStream> arg0) where Arg0ExtendsJava_Util_Stream_DoubleStream : Java.Util.Stream.DoubleStream
        {
            return IExecuteWithSignature<Java.Util.Stream.DoubleStream>("flatMap", "(Ljava/util/function/DoubleFunction;)Ljava/util/stream/DoubleStream;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#limit(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public Java.Util.Stream.DoubleStream Limit(long arg0)
        {
            return IExecuteWithSignature<Java.Util.Stream.DoubleStream>("limit", "(J)Ljava/util/stream/DoubleStream;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#map(java.util.function.DoubleUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public Java.Util.Stream.DoubleStream Map(Java.Util.Function.DoubleUnaryOperator arg0)
        {
            return IExecuteWithSignature<Java.Util.Stream.DoubleStream>("map", "(Ljava/util/function/DoubleUnaryOperator;)Ljava/util/stream/DoubleStream;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#peek(java.util.function.DoubleConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleConsumer"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public Java.Util.Stream.DoubleStream Peek(Java.Util.Function.DoubleConsumer arg0)
        {
            return IExecuteWithSignature<Java.Util.Stream.DoubleStream>("peek", "(Ljava/util/function/DoubleConsumer;)Ljava/util/stream/DoubleStream;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#skip(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public Java.Util.Stream.DoubleStream Skip(long arg0)
        {
            return IExecuteWithSignature<Java.Util.Stream.DoubleStream>("skip", "(J)Ljava/util/stream/DoubleStream;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#sorted()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public Java.Util.Stream.DoubleStream Sorted()
        {
            return IExecuteWithSignature<Java.Util.Stream.DoubleStream>("sorted", "()Ljava/util/stream/DoubleStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#mapToInt(java.util.function.DoubleToIntFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleToIntFunction"/></param>
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public Java.Util.Stream.IntStream MapToInt(Java.Util.Function.DoubleToIntFunction arg0)
        {
            return IExecuteWithSignature<Java.Util.Stream.IntStream>("mapToInt", "(Ljava/util/function/DoubleToIntFunction;)Ljava/util/stream/IntStream;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#mapToLong(java.util.function.DoubleToLongFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleToLongFunction"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public Java.Util.Stream.LongStream MapToLong(Java.Util.Function.DoubleToLongFunction arg0)
        {
            return IExecuteWithSignature<Java.Util.Stream.LongStream>("mapToLong", "(Ljava/util/function/DoubleToLongFunction;)Ljava/util/stream/LongStream;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#boxed()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<Java.Lang.Double> Boxed()
        {
            return IExecuteWithSignature<Java.Util.Stream.Stream<Java.Lang.Double>>("boxed", "()Ljava/util/stream/Stream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#count()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long Count()
        {
            return IExecuteWithSignature<long>("count", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#forEach(java.util.function.DoubleConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleConsumer"/></param>
        public void ForEach(Java.Util.Function.DoubleConsumer arg0)
        {
            IExecuteWithSignature("forEach", "(Ljava/util/function/DoubleConsumer;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#forEachOrdered(java.util.function.DoubleConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleConsumer"/></param>
        public void ForEachOrdered(Java.Util.Function.DoubleConsumer arg0)
        {
            IExecuteWithSignature("forEachOrdered", "(Ljava/util/function/DoubleConsumer;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#iterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator Iterator()
        {
            return IExecuteWithSignature<Java.Util.Iterator>("iterator", "()Ljava/util/Iterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#spliterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Spliterator"/></returns>
        public Java.Util.Spliterator Spliterator()
        {
            return IExecuteWithSignature<Java.Util.Spliterator>("spliterator", "()Ljava/util/Spliterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#parallel()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.BaseStream"/></returns>
        public Java.Util.Stream.BaseStream Parallel()
        {
            return IExecuteWithSignature<Java.Util.Stream.BaseStream>("parallel", "()Ljava/util/stream/BaseStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#sequential()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.BaseStream"/></returns>
        public Java.Util.Stream.BaseStream Sequential()
        {
            return IExecuteWithSignature<Java.Util.Stream.BaseStream>("sequential", "()Ljava/util/stream/BaseStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#dropWhile(java.util.function.DoublePredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoublePredicate"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public Java.Util.Stream.DoubleStream DropWhile(Java.Util.Function.DoublePredicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Stream.DoubleStream>("dropWhile", "(Ljava/util/function/DoublePredicate;)Ljava/util/stream/DoubleStream;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/DoubleStream.html#takeWhile(java.util.function.DoublePredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoublePredicate"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public Java.Util.Stream.DoubleStream TakeWhile(Java.Util.Function.DoublePredicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Stream.DoubleStream>("takeWhile", "(Ljava/util/function/DoublePredicate;)Ljava/util/stream/DoubleStream;", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}